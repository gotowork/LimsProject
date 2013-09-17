using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LimsProject.BusinessLayer;
using LimsProject.BusinessLayer.Modules;
using DevExpress.XtraTreeList.Nodes;

namespace LimsProject
{
    public delegate void signSolInterm(CGroup_solution e);

    public partial class UcSolInterm : UserControl
    {
        CGroup_solution group_solution = null;
        ModSolInterm modSolInterm = new ModSolInterm();
        ModSolution modSolution = new ModSolution();
        List<CSolution> lstSolution = new List<CSolution>();
        CTemplate_method_aa template_method_aa = new CTemplate_method_aa();
        bool AllowAddSolInterm1 = false;
        bool AllowAddSolInterm2 = false;
        bool AllowAddStdVerif = false;
        bool FlagSolutionInProcess = false;
        TreeListNode nodeSolutionInProcess = null;
        
        BindingList<CCustom_method_solution> LstTemplate_method { get; set; }
        short? Idelement { get; set; }

        public event signSolInterm onSignSolInterm;
        
        DevExpress.XtraTreeList.Nodes.TreeListNode treeSolInterm1;
        DevExpress.XtraTreeList.Nodes.TreeListNode treeSolInterm2;
        DevExpress.XtraTreeList.Nodes.TreeListNode treeStdVerif;        
                
        public int TypeSolution;

        public enum typeSolution
        {
            StdCalib = 1,
            SolInterm1 = 2,
            SolInterm2 = 3,
            StdVerif = 4,
            SolTitration = 5
        }

        TreeListNode NodePatternRoot
        {
            get {
                return treeSolInterm.Nodes[0];
            }
        }

        public UcSolInterm()
        {
            InitializeComponent();
        }

        public void Init(short pIdelement)
        {
            //seleccionar métodos
            Idelement = pIdelement;
            cbMethod1.Bind(pIdelement);            
            InitTreeLeft();
            InitCombos();
            InitHeader();
            InitTreeSolution();
            
        }

        public void InitTreeLeft()
        {
            treeSolInterm1 = treeSolution.Nodes[0];
            treeSolInterm2 = treeSolution.Nodes[1];
            treeStdVerif = treeSolution.Nodes[2];

            // --- solutions                        
            treeSolInterm1.Tag = Convert.ToInt32(typeSolution.SolInterm1);
            treeSolInterm2.Tag = Convert.ToInt32(typeSolution.SolInterm2);
            treeStdVerif.Tag = Convert.ToInt32(typeSolution.StdVerif);            
                                    
            ModSolution oModSolution = new ModSolution();
            CGroup_solutionFactory faGroup_solution = new CGroup_solutionFactory();
            List<CGroup_solution> lstGroup_solution =
                faGroup_solution
                .GetAll()
                .Where(x => x.Type_solution == Convert.ToInt32(typeSolution.SolInterm1)
                    || x.Type_solution == Convert.ToInt32(typeSolution.SolInterm2)
                    || x.Type_solution == Convert.ToInt32(typeSolution.StdVerif)).ToList();

            // 1:SC, 2:SI-1, 3:SI-2, 4:EV, 5:ST
            foreach (var item in lstGroup_solution)
            {                
                // solución intermedia 1, 2 y estandar de verificación
                if (item.Type_solution == 2 || item.Type_solution == 3 || item.Type_solution == 4) // --- agregar filas de la tabla de soluciones (intermedias)
                {
                    // --- agregar soluciones intermedia-1
                    List<CSolution> lstSolInterm1 = oModSolution.GetLstSolInterm1ByGroup(item.Idgroup_solution);
                    foreach (CSolution solution in lstSolInterm1)
                    {
                        object[] obj = { solution.Cod_solution, solution.Idgroup_solution, item.Idmr_detail };
                        TreeListNode node = treeSolution.AppendNode(obj, treeSolInterm1);
                        node.Tag = treeSolInterm1.Tag;
                        node.ImageIndex = 1;
                        node.SelectImageIndex = 1;
                    }

                    // --- agregar soluciones intermedia-2
                    List<CSolution> lstSolInterm2 = oModSolution.GetLstSolInterm2ByGroup(item.Idgroup_solution);
                    foreach (CSolution solution in lstSolInterm2)
                    {
                        object[] obj = { solution.Cod_solution, solution.Idgroup_solution, item.Idmr_detail };
                        TreeListNode node = treeSolution.AppendNode(obj, treeSolInterm2);
                        node.Tag = treeSolInterm2.Tag;
                        node.ImageIndex = 1;
                        node.SelectImageIndex = 1;
                    }

                    // --- agregar estandares de verificación
                    List<CSolution> lstStdVerif = oModSolution.GetLstStdVerifByGroup(item.Idgroup_solution);

                    foreach (CSolution solution in lstStdVerif)
                    {
                        object[] obj = { solution.Cod_solution, solution.Idgroup_solution, item.Idmr_detail };
                        TreeListNode node = treeSolution.AppendNode(obj, treeStdVerif);
                        node.Tag = treeStdVerif.Tag;
                        node.ImageIndex = 2;
                        node.SelectImageIndex = 2;
                    }
                }             
            }

            treeSolution.ExpandAll();
        }

        void InitCombos()
        {
            List<CReactive> lstReactive = new CReactiveFactory().GetAll();
            cbMedium.Bind();
            cbModif.Bind();

            repReactive.DataSource = lstReactive;
            repReactive.ValueMember = "Idreactive";
            repReactive.DisplayMember = "Reactive_name";

            repUser.DataSource = new CUser_systemFactory().GetAll();
            repUser.ValueMember = "Iduser";
            repUser.DisplayMember = "Cod_user";
        }

        void InitHeader()
        {
            cbMedium.Bind();
            cbModif.Bind();
        }

        void InitTreeSolution()
        {
            lstSolution = modSolInterm.GetLstSolution(group_solution);
            treeSolInterm.DataSource = lstSolution;
            treeSolInterm.ExpandAll();            
        }

        /// <summary>
        /// Estados para los botones:
        /// -------------------------
        /// - si no existe una solución o esta desactivada entonces se habilita el estado de activación del boton
        /// - si existe una solución activa entonces se desactiva el botón y se puede preguntar por los botones 
        ///   siguientes.
        /// </summary>
        void ShowStatusButtons()
        {
            AllowAddSolInterm1 = false;
            AllowAddSolInterm2 = false;
            AllowAddStdVerif = false;
            CSolution firstSolution = null;
            CSolution SecondSolution = null;

            if (!FlagSolutionInProcess)
            {
                // Solución intermedia 1
                if (Convert.ToBoolean(template_method_aa.Std_flag_sol_intermedia1))
                {
                    if ((firstSolution = GetActiveFirstSolution()) == null)
                    {
                        // no existe o está deshabilitado la solución intermedia 1, entonces habilitar agregación
                        AllowAddSolInterm1 = true;
                    }
                    else
                    {
                        // ya existe una solución intermedia 1
                        AllowAddSolInterm1 = false;
                        AllowAddSolInterm2 = false;
                        AllowAddStdVerif = false;

                        //if (GetActiveStdVerification(firstSolution) == null)
                        if (GetActiveStdVerification1() == null)
                            AllowAddStdVerif = true;
                        else
                            // ya existe un estandar de verificación
                            AllowAddStdVerif = false;
                    }
                }
                // Solución intermedia 2
                if (Convert.ToBoolean(template_method_aa.Std_flag_sol_intermedia2))
                {
                    if (GetActiveFirstSolution() == null)
                    {
                        AllowAddSolInterm1 = true;
                        AllowAddSolInterm2 = false;
                        AllowAddStdVerif = false;
                    }
                    else
                    {
                        // ya existe la solución intermedia 1 deshabilitar agregación
                        AllowAddSolInterm1 = false;
                        AllowAddStdVerif = false;

                        // si solución intermedia dos no existe o está desactivada habilitar agregación
                        if ((SecondSolution = GetActiveSecondSolution()) == null)
                            AllowAddSolInterm2 = true;
                        else
                        {
                            // ya existe solución intermedia 2
                            AllowAddSolInterm2 = false;
                            AllowAddStdVerif = false;

                            //if (GetActiveStdVerification(SecondSolution) == null)
                            if (GetActiveStdVerification2() == null)
                                AllowAddStdVerif = true;
                            else
                                // ya existe un estandar de verificación
                                AllowAddStdVerif = false;
                        }
                    }
                }

                btSolInterm1.Enabled = AllowAddSolInterm1;
                btSolInterm2.Enabled = AllowAddSolInterm2;
                btStdVerif.Enabled = AllowAddStdVerif;                
            }
            else
            {
                btSolInterm1.Enabled = AllowAddSolInterm1;
                btSolInterm2.Enabled = AllowAddSolInterm2;
                btStdVerif.Enabled = AllowAddStdVerif;
            }
        }               

        CSolution GetActiveFirstSolution()
        {
            if (lstSolution.Exists(c=> c.Type_sol == 1 && c.Solution_status == true))
            {
                return lstSolution.First(c => c.Type_sol == 1 && c.Solution_status == true);
            }
            return null;
        }

        CSolution GetActiveSecondSolution()
        {
            if (lstSolution.Exists(c => c.Type_sol == 2 && c.Solution_status == true))
            {
                return lstSolution.First(c => c.Type_sol == 2 && c.Solution_status == true);
            }
            return null;
        }

        CSolution GetActiveStdVerification(CSolution parent)
        {
            if (lstSolution.Exists(c => c.Type_sol == 3 && c.Solution_status == true && c.Parentid == parent.Id))
            {
                return lstSolution.First(c => c.Type_sol == 3 && c.Solution_status == true && c.Parentid == parent.Id);
            }
            return null;
        }

        CSolution GetActiveStdVerification1()
        {
            if (lstSolution.Exists(c => c.Type_sol == 3 && c.Solution_status == true))
                return lstSolution.First(c => c.Type_sol == 3 && c.Solution_status == true);
            return null;
        }

        CSolution GetActiveStdVerification2()
        {
            if (lstSolution.Exists(c => c.Type_sol == 4 && c.Solution_status == true))
                return lstSolution.First(c => c.Type_sol == 4 && c.Solution_status == true);
            return null;
        }

        decimal? GetMedium(int typeSol)
        {
            CTemplate_method_aa template_method_aa = 
                new CTemplate_method_aaFactory()
                .GetByPrimaryKey(new CTemplate_method_aaKeys(Convert.ToInt32(group_solution.Idtemplate_method)));

            if (typeSol == 1)
                return template_method_aa.Std_sol1_medium;
            if (typeSol == 2)
                return template_method_aa.Std_sol2_medium;
            if (typeSol == 3)
                return template_method_aa.Std_stdverif_medium;
            return null;
        }

        void AddFirstSolution()
        {
            // --- si existe una solución preguntar
            if (!lstSolution.Exists(c => c.Idsolution == 0 && c.Solution_status == true && c.Type_sol == 1))
            {
                // --- añadir en la raiz
                lstSolution.Add(
                    new CSolution
                    {
                        Idsolution = 0,
                        Id = GetMaxCorrelativeNode() + 1,
                        Parentid = 0,
                        Cod_solution = "Nueva solución intermedia 1", //modSolution.GetCorrelative(ModSolution.Correlative.SolucionIntermedia),
                        Date_begin = DateTime.Now,
                        Date_end = DateTime.Now.AddMonths(new CSettings().GetNumMonthSolInterm()),
                        Idelement = group_solution.Idelement,
                        Lote = "",
                        Observation = "",
                        Prepared_by = Comun.User_system.Iduser,
                        Purity = 0,
                        Solution_name = "",
                        Type_sol = 1,
                        Volumen = 0,
                        Concentration = template_method_aa.Std_concentration_sol1,
                        Aliquot = 0,
                        Solution_status = true,
                        Idreactive_medium = group_solution.Idreactive_medium,
                        Idreactive_modif = group_solution.Idreactive_modif,
                        Reactive_medium_value = GetMedium(1),
                        Image_index = 0
                    });

                treeSolInterm.DataSource = new BindingList<CSolution>(lstSolution);
                treeSolInterm.ExpandAll();

                SetButtonsInProcess();
            }
            else            
                new FormMessage("Agregar solución", "No es posible agregar. Existe una solución intermedia 1 en proceso.", true, false).ShowDialog();
        }

        void AddSecondSolution()
        {
            if (!lstSolution.Exists(c => c.Idsolution == 0 && c.Solution_status == true && c.Type_sol == 2))
            {

                CSolution firstSolution = GetActiveFirstSolution();

                // --- añadir dentro de una solución intermedia 1
                lstSolution.Add(
                    new CSolution
                    {
                        Idsolution = 0,
                        Id = GetMaxCorrelativeNode() + 1,
                        Parentid = firstSolution.Id,
                        Cod_solution = "Nueva solución intermedia 2", //modSolution.GetCorrelative(ModSolution.Correlative.SolucionIntermedia),
                        Date_begin = DateTime.Now,
                        Date_end = DateTime.Now.AddMonths(new CSettings().GetNumMonthSolInterm()),
                        Idelement = group_solution.Idelement,
                        Lote = "",
                        Observation = "",
                        Prepared_by = Comun.User_system.Iduser,
                        Purity = 0,
                        Solution_name = "",
                        Solution_status = true,
                        Type_sol = 2,
                        Volumen = 0,
                        Concentration = template_method_aa.Std_concentration_sol2,
                        Aliquot = 0,
                        Idreactive_medium = group_solution.Idreactive_medium,
                        Idreactive_modif = group_solution.Idreactive_modif,
                        Reactive_medium_value = GetMedium(2),
                        Image_index = 0
                    });

                treeSolInterm.DataSource = new BindingList<CSolution>(lstSolution);
                treeSolInterm.ExpandAll();

                SetButtonsInProcess();                                
            }
            else
                new FormMessage("Agregar solución", "No es posible agregar. Existe una solución intermedia 2 en proceso", true, false).ShowDialog();
        }
        
        void AddStdInRootSolution()
        {
            // --- añadir dentro de una solución intermedia 1 o 2
            //modificar los campos según la configuración del estandar de verificación.

            lstSolution.Add(
                new CSolution
                {
                    Idsolution = 0,
                    Id = GetMaxCorrelativeNode() + 1,
                    Parentid = 0,
                    Cod_solution = "Nuevo estandar", //modSolution.GetCorrelative(ModSolution.Correlative.EstandarVerificacion),
                    Date_begin = DateTime.Now,
                    Date_end = DateTime.Now.AddMonths(new CSettings().GetNumMonthSolInterm()),
                    Idelement = group_solution.Idelement,
                    Lote = "",
                    Observation = "",
                    Prepared_by = Comun.User_system.Iduser,
                    Purity = 0,
                    Solution_name = "",
                    Solution_status = true,
                    Type_sol = 5,
                    Volumen = 0,
                    Concentration = template_method_aa.Std_verif,
                    Aliquot = 0,
                    Idreactive_medium = group_solution.Idreactive_medium,
                    Idreactive_modif = group_solution.Idreactive_modif,
                    Reactive_medium_value = GetMedium(3),
                    Image_index = 1
                });

            treeSolInterm.DataSource = new BindingList<CSolution>(lstSolution);
            treeSolInterm.ExpandAll();

            SetButtonsInProcess();
        }

        void AddStdInFistSolution()
        {
            // --- añadir dentro de una solución intermedia 1 o 2
            //modificar los campos según la configuración del estandar de verificación.
            int someId = Convert.ToInt32(GetActiveFirstSolution().Id);

            lstSolution.Add(
                new CSolution
                {
                    Idsolution = 0,
                    Id = GetMaxCorrelativeNode() + 1,
                    Parentid = someId,
                    Cod_solution = "Nuevo estandar", //modSolution.GetCorrelative(ModSolution.Correlative.EstandarVerificacion),
                    Date_begin = DateTime.Now,
                    Date_end = DateTime.Now.AddMonths(new CSettings().GetNumMonthSolInterm()),
                    Idelement = group_solution.Idelement,
                    Lote = "",
                    Observation = "",
                    Prepared_by = Comun.User_system.Iduser,
                    Purity = 0,
                    Solution_name = "",
                    Solution_status = true,
                    Type_sol = 3,
                    Volumen = 0,
                    Concentration = template_method_aa.Std_verif,
                    Aliquot = 0,
                    Idreactive_medium = group_solution.Idreactive_medium,
                    Idreactive_modif = group_solution.Idreactive_modif,
                    Reactive_medium_value = GetMedium(3),
                    Image_index = 1
                });

            treeSolInterm.DataSource = new BindingList<CSolution>(lstSolution);
            treeSolInterm.ExpandAll();

            SetButtonsInProcess();
        }

        void AddStdInSecondSolution()
        {
            // --- añadir dentro de una solución intermedia 1 o 2
            //modificar los campos según la configuración del estandar de verificación.
            int someId = Convert.ToInt32(GetActiveSecondSolution().Id);

            lstSolution.Add(
                new CSolution
                {
                    Idsolution = 0,
                    Id = GetMaxCorrelativeNode() + 1,
                    Parentid = someId,
                    Cod_solution = "Nuevo estandar", //modSolution.GetCorrelative(ModSolution.Correlative.EstandarVerificacion),
                    Date_begin = DateTime.Now,
                    Date_end = DateTime.Now.AddMonths(new CSettings().GetNumMonthSolInterm()),
                    Idelement = group_solution.Idelement,
                    Lote = "",
                    Observation = "",
                    Prepared_by = Comun.User_system.Iduser,
                    Purity = 0,
                    Solution_name = "",
                    Solution_status = true,
                    Type_sol = 4,
                    Volumen = 0,
                    Concentration = template_method_aa.Std_verif,
                    Aliquot = 0,
                    Idreactive_medium = group_solution.Idreactive_medium,
                    Idreactive_modif = group_solution.Idreactive_modif,
                    Reactive_medium_value = GetMedium(3),
                    Image_index = 1
                });

            treeSolInterm.DataSource = new BindingList<CSolution>(lstSolution);
            treeSolInterm.ExpandAll();

            SetButtonsInProcess();            
        }

        void SetButtonsInProcess()
        {
            FlagSolutionInProcess = true;

            AllowAddSolInterm1 = false;
            AllowAddSolInterm2 = false;
            AllowAddStdVerif = false;            

            btSolInterm1.Enabled = AllowAddSolInterm1;
            btSolInterm2.Enabled = AllowAddSolInterm2;
            btStdVerif.Enabled = AllowAddStdVerif;            

            FindNodeInProcess();
        }

        void FindNodeInProcess()
        {
            nodeSolutionInProcess = null;

            foreach (TreeListNode nodo in treeSolInterm.Nodes)
                GetNodeInProcess(nodo);
        }

        void GetNodeInProcess(TreeListNode parentNode)
        {
            if (Convert.ToInt32(parentNode["Idsolution"]) == 0)
                nodeSolutionInProcess = parentNode;
            else
            {
                foreach (TreeListNode nodo in parentNode.Nodes)
                    GetNodeInProcess(nodo);
            }
        }


        int GetMaxCorrelativeNode()
        {
            int max = 0;

            if (lstSolution.Count > 0)
                max = Convert.ToInt32(lstSolution.Max(c=> c.Id));

            return max;
        }

        bool IsSolidSolutionPattern()
        {
            CMr_detail oMr_detail =
                new CMr_detailFactory()
                .GetByPrimaryKey(new CMr_detailKeys(Convert.ToInt16(template_method_aa.Std_mrorpattern)));

            CMr oMr = new CMrFactory().GetByPrimaryKey(new CMrKeys(Convert.ToInt16(oMr_detail.Idmr)));

            return Convert.ToBoolean(oMr.Solid);
        }

        bool IsSolutionInterm1(TreeListNode node)
        {
            if (lstSolution.Exists(c=> c.Id == Convert.ToInt32(node["Id"]) && c.Type_sol == 1 && c.Solution_status == true))
                return true;
            return false;
        }

        bool IsSolutionInterm2(TreeListNode node)
        {
            if (lstSolution.Exists(c => c.Id == Convert.ToInt32(node["Id"]) && c.Type_sol == 1 && c.Solution_status == true))
                return true;
            return false;
        }

        bool IsStdVerification(TreeListNode node)
        {
            if (lstSolution.Exists(c => c.Id == Convert.ToInt32(node["Id"]) && c.Type_sol == 3 && c.Solution_status == true))
                return true;
            return false;
        }

        bool IsPatternRoot(TreeListNode node)
        {
            if (node == NodePatternRoot)
                return true;
            return false;
        }

        public void Clear()
        {
            treeSolInterm.ClearNodes();
            cbMedium.EditValue = null;
            cbModif.EditValue = null;

            cbTypeSolPatron.EditValue = null;
            cbMrpattern.EditValue = null;
            tbConcentPattern.Text = "";
            tbUnd.Text = "";
            cbMedium.EditValue = null;
            cbModif.EditValue = null;
        }

        private void btSolInterm1_Click(object sender, EventArgs e)
        {
            AddFirstSolution();            
        }

        private void btSolInterm2_Click(object sender, EventArgs e)
        {
            AddSecondSolution();            
        }

        private void btStdVerf1_Click(object sender, EventArgs e)
        {
            // por defecto agregar el estandar de verificación 
            // a la solución intermedia 1
            TreeListNode node = treeSolInterm.FocusedNode;

            if (!Convert.ToBoolean(template_method_aa.Std_flag_sol_intermedia1)
                && !Convert.ToBoolean(template_method_aa.Std_flag_sol_intermedia2))
            {                
                AddStdInRootSolution();
            }
            else if (Convert.ToBoolean(template_method_aa.Std_flag_sol_intermedia2))
                AddStdInSecondSolution();
            else if (Convert.ToBoolean(template_method_aa.Std_flag_sol_intermedia1))            
                AddStdInFistSolution();            
        }

        private void treeSolInterm_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            /*
            Solidos
            -------
            1: Alicuota = volumen*concentracion/concentracion patron

            Líquidos
            --------
            1: Alicuota = volumen/(concentracion patron/concentracion)  */

            // Hacer el cálculo 
            // Si es el patrón de solución es muestra terminal entonces verificar 
            // antes si es sólido o líquido
            // 
            try
            {
                if (e.Node.Level == 0)
                {
                    // Muestra patron es terminal
                    if (IsSolidSolutionPattern()) // sólido
                        e.Node["Aliquot"] = Convert.ToDecimal(e.Node["Volumen"]) * Convert.ToDecimal(e.Node["Concentration"]) / template_method_aa.Std_concentration;
                    else // líquido
                        e.Node["Aliquot"] = Convert.ToDecimal(e.Node["Volumen"]) / (template_method_aa.Std_concentration / Convert.ToDecimal(e.Node["Concentration"]));
                }
                else if (e.Node.Level >= 1) // solucion intermedia 
                {
                    // solución intermedia 1 o 2 es terminal
                    // determinar la concentración
                    decimal parentConcentration = Convert.ToDecimal(e.Node.ParentNode["Concentration"]);

                    e.Node["Aliquot"] = Convert.ToDecimal(e.Node["Volumen"]) / Convert.ToDecimal(e.Node["Concentration"]) / parentConcentration;
                }
            }
            catch (Exception ex)
            {
                Comun.Send_message("Soluciones", TypeMsg.error, ex.Message);
            }
        }

        private void ucSign1_OnSign(bool login)
        {
            if (login)
            {
                if (nodeSolutionInProcess != null)
                {
                    ///si el nuevo nodo seleccionado es un estandar de verificación
                    ///reasignar el tipo de solucion intermedia de su solución padre
                    int type_sol = Convert.ToInt32(nodeSolutionInProcess["Type_sol"]);

                    if (type_sol == 3 || type_sol == 4)
                    {
                        if (nodeSolutionInProcess.Level == 1)
                            type_sol = 1;
                        if (nodeSolutionInProcess.Level == 2)
                            type_sol = 2;
                    }

                    FormSelMethods fmSelMethods = new FormSelMethods(group_solution, type_sol);

                    if (fmSelMethods.ShowDialog() == DialogResult.OK)
                    {
                        // --- guardar grupo de solución
                        CGroup_solutionFactory fagroup_solution = new CGroup_solutionFactory();
                        bool result = false;

                        if (!(result = fagroup_solution.Update(group_solution)))
                            result = fagroup_solution.Insert(group_solution);

                        // --- guardando soluciones
                        if (result)
                        {
                            // --- guardar los cambios en las soluciones
                            CSolutionFactory faSolution = new CSolutionFactory();
                            bool result_solution = false;
                            for (int i = 0; i < lstSolution.Count; i++)
                            {
                                result_solution = false;

                                if (lstSolution[i].Idsolution == 0)
                                {
                                    #region Grabar metodos a nueva solución ingresada

                                    lstSolution[i].Idgroup_solution = group_solution.Idgroup_solution;
                                    lstSolution[i].Cod_solution = null;

                                    if (!(result_solution = faSolution.Update(lstSolution[i])))
                                        result_solution = faSolution.Insert(lstSolution[i]);

                                    // --- asignar un correlativo dependiendo del tipo de solución
                                    // 1:solución intermedia1, 2:solución intermedia 2, 3:estandar de verificación
                                    if (result_solution)
                                    {
                                        ModCorrelatives oModCorrelatives = new ModCorrelatives();
                                        if (lstSolution[i].Type_sol == 1 || lstSolution[i].Type_sol == 2)
                                            lstSolution[i].Cod_solution = oModCorrelatives.GetCorrelative(ModCorrelatives.Correlative.SolucionIntermedia);
                                        else if (lstSolution[i].Type_sol == 3 || lstSolution[i].Type_sol == 4)
                                            lstSolution[i].Cod_solution = oModCorrelatives.GetCorrelative(ModCorrelatives.Correlative.EstandarVerificacion);

                                        faSolution.Update(lstSolution[i]);
                                    }

                                    if (result_solution)
                                    {
                                        // --- grabar métodos de la solución
                                        CSolution_methodsFactory faSolution_methods = new CSolution_methodsFactory();
                                        CSolution_methods oSolution_methods = new CSolution_methods();
                                        string concatMethods = "";
                                        bool result_solution_method = false;

                                        // --- grabar linkeo de solución y métodos
                                        foreach (CMethodMini item in fmSelMethods.LstMethodMini)
                                        {
                                            if (item.Sel)
                                            {
                                                // indexar método a la solución
                                                oSolution_methods = new CSolution_methods();
                                                oSolution_methods.Idsolution = lstSolution[i].Idsolution;
                                                oSolution_methods.Idtemplate_method = item.Idtemplate_method;
                                                oSolution_methods.Status = true;

                                                if (!(result_solution_method = faSolution_methods.Update(oSolution_methods)))
                                                    result_solution_method = faSolution_methods.Insert(oSolution_methods);

                                                // concatenar método 
                                                concatMethods += concatMethods.Trim().Length == 0 ? item.Cod_template_method : ", " + item.Cod_template_method;
                                            }
                                        }

                                        // asignar concatenado de métodos seleccionados al campo de la solucion[i]
                                        lstSolution[i].Concat_cod_methods = concatMethods;
                                        faSolution.Update(lstSolution[i]);
                                    }
                                    #endregion
                                }                                
                            }

                            treeSolInterm.DataSource = lstSolution;
                            FlagSolutionInProcess = false;

                            ShowStatusButtons();

                            new FormMessage("Guardado", "Guardado correctamente.", true, false).ShowDialog();

                            ucSign1.Clear();
                            treeSolInterm.ExpandAll();
                        }

                        onSignSolInterm(group_solution);
                    }
                }
                else
                {
                    ///No existe ningún nodo en proceso, entonces los cambios
                    ///fueron sobre el estado de las soluciones
                    ///
                    CSolutionFactory faSolution = new CSolutionFactory();
                    for (int i = 0; i < lstSolution.Count; i++)                    
                        faSolution.Update(lstSolution[i]);
                    
                    treeSolInterm.DataSource = lstSolution;

                    ShowStatusButtons();
                    new FormMessage("Guardado", "Guardado correctamente.", true, false).ShowDialog();
                    ucSign1.Clear();
                    treeSolInterm.ExpandAll();

                    onSignSolInterm(group_solution);
                }
            }
            else 
                new FormMessage("Error", "Contraseña incorrecta.", true, false).ShowDialog();
        }

        private void cbTypeSolPatron_SelectedIndexChanged(object sender, EventArgs e)
        {
            // --- mostrar mrc o patron de soluciones
            if (cbTypeSolPatron.SelectedIndex == 0)
            {
                ModSolution oModSolution = new ModSolution();
                cbMrpattern.Properties.DataSource = oModSolution.GetLstMrc(Convert.ToInt16(Idelement));
                cbMrpattern.Properties.DisplayMember = "Name";
                cbMrpattern.Properties.ValueMember = "Idmr_detail";

                cbMrpattern.EditValue = null;
            }
            if (cbTypeSolPatron.SelectedIndex == 1)
            {
                ModSolution oModSolution = new ModSolution();
                cbMrpattern.Properties.DataSource = oModSolution.GetLstPatron(Convert.ToInt16(Idelement));
                cbMrpattern.Properties.DisplayMember = "Name";
                cbMrpattern.Properties.ValueMember = "Idmr_detail";

                cbMrpattern.EditValue = null;
            }            
        }

        private void repVolumen_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            object idsolution = treeSolInterm.FocusedNode["Idsolution"];
            if (idsolution != null && Convert.ToInt32(idsolution) != 0)
            {
                e.Cancel = true;
            }
        }

        private void cbMethod1_EditValueChanged(object sender, EventArgs e)
        {
            // obtener modif y medium filtrado por cod template
            template_method_aa = new CTemplate_method_aaFactory().GetByPrimaryKey(new CTemplate_method_aaKeys(Convert.ToInt32(cbMethod1.EditValue)));

            if (template_method_aa != null)
            {
                cbMedium.EditValue = template_method_aa.Medium;
                cbModif.EditValue = template_method_aa.Modif;
                cbTypeSolPatron.EditValue = template_method_aa.Type_pattern;

                ShowStatusButtons();
            }            
        }

        
    }
}
