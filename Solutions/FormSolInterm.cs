using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LimsProject.BusinessLayer;
using LimsProject.BusinessLayer.Modules;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;

namespace LimsProject
{
    public partial class FormSolInterm : LibraryBasicForm.FormBaseEmpty
    {
        CGroup_solution group_solution = null;
        ModSolInterm modSolInterm = new ModSolInterm();
        ModSolution modSolution = new ModSolution();
        List<CSolution> lstSolution = new List<CSolution>();
        CTemplate_method_aa template_method_aa = new CTemplate_method_aa();

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
            get
            {
                return treeSolInterm.Nodes[0];
            }
        }

        public FormSolInterm()
        {
            InitializeComponent();
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

        bool IsSolidSolutionPattern()
        {
            CMr_detail oMr_detail =
                new CMr_detailFactory()
                .GetByPrimaryKey(new CMr_detailKeys(Convert.ToInt16(template_method_aa.Std_mrorpattern)));

            CMr oMr = new CMrFactory().GetByPrimaryKey(new CMrKeys(Convert.ToInt16(oMr_detail.Idmr)));

            return Convert.ToBoolean(oMr.Solid);
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
            }  
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
            //filtrar soluciones por elemento  y tipo de solucion
            //modSolInterm.GetLstSolution(idelement, type_pattern_solution)
            //lstSolution = modSolInterm.GetLstSolution(group_solution);
            lstSolution = modSolInterm.GetLstSolution(Idelement, TypeSolution);

            //
            treeSolInterm.DataSource = lstSolution;
            treeSolInterm.ExpandAll();
        }

        CSolution GetActiveFirstSolution()
        {
            if (lstSolution.Exists(c => c.Type_sol == 1 && c.Solution_status == true))
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
            //CTemplate_method_aa template_method_aa = 
            //    new CTemplate_method_aaFactory()
            //    .GetByPrimaryKey(new CTemplate_method_aaKeys(Convert.ToInt32(group_solution.Idtemplate_method)));

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
                        Idelement = Idelement,
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
                        Idreactive_medium = Convert.ToInt32(cbMedium.EditValue),
                        Idreactive_modif = Convert.ToInt32(cbModif.EditValue),
                        Reactive_medium_value = GetMedium(1),
                        Image_index = 1
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
                        Idelement = Idelement,
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
                        Idreactive_medium = Convert.ToInt32(cbMedium.EditValue),
                        Idreactive_modif = Convert.ToInt32(cbModif.EditValue),
                        Reactive_medium_value = GetMedium(2),
                        Image_index = 1
                    });

                treeSolInterm.DataSource = new BindingList<CSolution>(lstSolution);
                treeSolInterm.ExpandAll();

                SetButtonsInProcess();
            }
            else
                new FormMessage("Agregar solución", "No es posible agregar. Existe una solución intermedia 2 en proceso", true, false).ShowDialog();
        }

        //void AddStdInRootSolution()
        //{
        //    // --- añadir dentro de una solución intermedia 1 o 2
        //    //modificar los campos según la configuración del estandar de verificación.

        //    lstSolution.Add(
        //        new CSolution
        //        {
        //            Idsolution = 0,
        //            Id = GetMaxCorrelativeNode() + 1,
        //            Parentid = 0,
        //            Cod_solution = "Nuevo estandar", //modSolution.GetCorrelative(ModSolution.Correlative.EstandarVerificacion),
        //            Date_begin = DateTime.Now,
        //            Date_end = DateTime.Now.AddMonths(new CSettings().GetNumMonthSolInterm()),
        //            Idelement = Idelement,
        //            Lote = "",
        //            Observation = "",
        //            Prepared_by = Comun.User_system.Iduser,
        //            Purity = 0,
        //            Solution_name = "",
        //            Solution_status = true,
        //            Type_sol = 5,
        //            Volumen = 0,
        //            Concentration = template_method_aa.Std_verif,
        //            Aliquot = 0,
        //            Idreactive_medium = Convert.ToInt32(cbMedium.EditValue),
        //            Idreactive_modif = Convert.ToInt32(cbModif.EditValue),
        //            Reactive_medium_value = GetMedium(3),
        //            Image_index = 1
        //        });

        //    treeSolInterm.DataSource = new BindingList<CSolution>(lstSolution);
        //    treeSolInterm.ExpandAll();

        //    SetButtonsInProcess();
        //}

        //void AddStdInFistSolution()
        //{
        //    // --- añadir dentro de una solución intermedia 1 o 2
        //    //modificar los campos según la configuración del estandar de verificación.
        //    int someId = Convert.ToInt32(GetActiveFirstSolution().Id);

        //    lstSolution.Add(
        //        new CSolution
        //        {
        //            Idsolution = 0,
        //            Id = GetMaxCorrelativeNode() + 1,
        //            Parentid = someId,
        //            Cod_solution = "Nuevo estandar", //modSolution.GetCorrelative(ModSolution.Correlative.EstandarVerificacion),
        //            Date_begin = DateTime.Now,
        //            Date_end = DateTime.Now.AddMonths(new CSettings().GetNumMonthSolInterm()),
        //            Idelement = Idelement,
        //            Lote = "",
        //            Observation = "",
        //            Prepared_by = Comun.User_system.Iduser,
        //            Purity = 0,
        //            Solution_name = "",
        //            Solution_status = true,
        //            Type_sol = 3,
        //            Volumen = 0,
        //            Concentration = template_method_aa.Std_verif,
        //            Aliquot = 0,
        //            Idreactive_medium = Convert.ToInt32(cbMedium.EditValue),
        //            Idreactive_modif = Convert.ToInt32(cbModif.EditValue),
        //            Reactive_medium_value = GetMedium(3),
        //            Image_index = 1
        //        });

        //    treeSolInterm.DataSource = new BindingList<CSolution>(lstSolution);
        //    treeSolInterm.ExpandAll();

        //    SetButtonsInProcess();
        //}

        //void AddStdInSecondSolution()
        //{
        //    // --- añadir dentro de una solución intermedia 1 o 2
        //    //modificar los campos según la configuración del estandar de verificación.
        //    int someId = Convert.ToInt32(GetActiveSecondSolution().Id);

        //    lstSolution.Add(
        //        new CSolution
        //        {
        //            Idsolution = 0,
        //            Id = GetMaxCorrelativeNode() + 1,
        //            Parentid = someId,
        //            Cod_solution = "Nuevo estandar", //modSolution.GetCorrelative(ModSolution.Correlative.EstandarVerificacion),
        //            Date_begin = DateTime.Now,
        //            Date_end = DateTime.Now.AddMonths(new CSettings().GetNumMonthSolInterm()),
        //            Idelement = Idelement,
        //            Lote = "",
        //            Observation = "",
        //            Prepared_by = Comun.User_system.Iduser,
        //            Purity = 0,
        //            Solution_name = "",
        //            Solution_status = true,
        //            Type_sol = 4,
        //            Volumen = 0,
        //            Concentration = template_method_aa.Std_verif,
        //            Aliquot = 0,
        //            Idreactive_medium = Convert.ToInt32(cbMedium.EditValue),
        //            Idreactive_modif = Convert.ToInt32(cbModif.EditValue),
        //            Reactive_medium_value = GetMedium(3),
        //            Image_index = 1
        //        });

        //    treeSolInterm.DataSource = new BindingList<CSolution>(lstSolution);
        //    treeSolInterm.ExpandAll();

        //    SetButtonsInProcess();            
        //}

        void AddStdSolution()
        {
            // --- añadir dentro de una solución intermedia 1 o 2
            //modificar los campos según la configuración del estandar de verificación.

            int parentId = 0;

            if (tree.FocusedNode == null)
                parentId = 0;
            else
                parentId = Convert.ToInt32(tree.FocusedNode["Id"]);

            lstSolution.Add(
                new CSolution
                {
                    Idsolution = 0,
                    Id = GetMaxCorrelativeNode() + 1,
                    Parentid = parentId,
                    Cod_solution = "Nuevo estandar", //modSolution.GetCorrelative(ModSolution.Correlative.EstandarVerificacion),
                    Date_begin = DateTime.Now,
                    Date_end = DateTime.Now.AddMonths(new CSettings().GetNumMonthSolInterm()),
                    Idelement = Idelement,
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
                    Idreactive_medium = Convert.ToInt32(cbMedium.EditValue),
                    Idreactive_modif = Convert.ToInt32(cbModif.EditValue),
                    Reactive_medium_value = GetMedium(3),
                    Image_index = 2
                });

            treeSolInterm.DataSource = new BindingList<CSolution>(lstSolution);
            treeSolInterm.ExpandAll();

            SetButtonsInProcess();
        }

        void SetButtonsInProcess()
        {
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
                max = Convert.ToInt32(lstSolution.Max(c => c.Id));

            return max;
        }        

        bool IsSolutionInterm1(TreeListNode node)
        {
            if (lstSolution.Exists(c => c.Id == Convert.ToInt32(node["Id"]) && c.Type_sol == 1 && c.Solution_status == true))
                return true;
            return false;
        }

        bool IsSolutionInterm2(TreeListNode node)
        {
            if (lstSolution.Exists(c => c.Id == Convert.ToInt32(node["Id"]) && c.Type_sol == 2 && c.Solution_status == true))
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

        private void btNewSolution_Click(object sender, EventArgs e)
        {
            //agregar un nuevo nodo de solución intermedia 1

            AddFirstSolution();
        }

        bool StatusSave = true;
        TreeList tree;

        private void treeSolInterm_MouseDown(object sender, MouseEventArgs e)
        {
            tree = sender as TreeList;
            TreeListHitInfo ht = tree.CalcHitInfo(e.Location);
            if (ht != null && ht.Node != null)
            {
                tree.FocusedNode = ht.Node;

                // determinar que tipo de solucion es el nodo seleccionado
                int typeSol = Convert.ToInt32(tree.FocusedNode["Type_sol"]);

                // habilitar los botones en popup
                btNewSolInt1.Enabled = false;
                btNewSolInt2.Enabled = false;
                btNewSolStdVer.Enabled = false;
                if (typeSol == 1) // solucion intermedia 1
                {
                    //habilitar solucion intermedia 2
                    btNewSolInt2.Enabled = true;

                    //habilitar el estandar de verificacion 
                    btNewSolStdVer.Enabled = true;
                }
                else if (typeSol == 2) // solución intermedia 2
                {
                    //habilitar solucion intermedia 2
                    btNewSolStdVer.Enabled = true;
                }
            }
            else if (ht != null && ht.Node == null)
            {
                tree.FocusedNode = ht.Node;

                btNewSolInt1.Enabled = false;
                btNewSolInt2.Enabled = false;
                btNewSolStdVer.Enabled = false;

                // habilitar el boton agregar solución
                btNewSolInt1.Enabled = true;
            }
        }

        private void btNewSolInt1_Click(object sender, EventArgs e)
        {
            AddFirstSolution();
            StatusSave = false;
        }

        private void btNewSolInt2_Click(object sender, EventArgs e)
        {
            AddSecondSolution();
            StatusSave = false;
        }

        private void btNewSolStdVer_Click(object sender, EventArgs e)
        {
            AddStdSolution();
            StatusSave = false;
        }

        private void repBtOpenMethods_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FormSelMethods fmSelMethods = new FormSelMethods();
            if (fmSelMethods.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void FormSolInterm_Load(object sender, EventArgs e)
        {
            cbElement1.Bind();
            cbMedium.Bind();
            cbModif.Bind();            
        }

        private void cbElement1_EditValueChanged(object sender, EventArgs e)
        {
            Init(Convert.ToInt16(cbElement1.EditValue));
        }

    }
}
