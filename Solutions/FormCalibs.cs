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
    public partial class FormCalibs : LibraryBasicForm.FormBaseEmpty
    {
        #region attributes

        ModSolInterm modSolInterm = new ModSolInterm();
        ModSolution modSolution = new ModSolution();
        List<CSolution_interm> lstSolution = new List<CSolution_interm>();
        CTemplate_method_aa template_method_aa = new CTemplate_method_aa();
        TreeListNode nodeSolutionInProcess = null;
        TreeList tree;
        public int TypeSolution;

        #endregion

        #region properties

        BindingList<CCustom_method_solution> LstTemplate_method { get; set; }
        
        short? Idelement { get; set; }

        TreeListNode NodePatternRoot
        {
            get
            {
                return treeSolInterm.Nodes[0];
            }
        }

        #endregion

        #region enumerators

        public enum typeSolution
        {
            StdCalib = 1,
            SolInterm1 = 2,
            SolInterm2 = 3,
            StdVerif = 4,
            SolTitration = 5
        }

        #endregion

        #region constructor

        public FormCalibs()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        public bool Son_Datos_Correctos()
        {            
            if (ckAssignMethod.Visible && !ckAssignMethod.Checked)
            {
                ComunForm.Send_message("Soluciones Intermedias", TypeMsg.error, "No se asigno el método.");
                return false;
            }
            return true;
        }

        public void Init(short pIdelement)
        {
            //seleccionar métodos
            Idelement = pIdelement;
            
            cbMethod1.Bind(pIdelement);            

            InitCombos();
            InitHeader();            
        }        

        void InitCombos()
        {
            List<CReactive> lstReactive = new CReactiveFactory().GetAll();
            cbParentMedium.Bind();
            cbParentModif.Bind();

            repReactive.DataSource = lstReactive;
            repReactive.ValueMember = "Idreactive";
            repReactive.DisplayMember = "Reactive_name";

            repUser.DataSource = new CUser_systemFactory().GetAll();
            repUser.ValueMember = "Iduser";
            repUser.DisplayMember = "Cod_user";
        }

        void InitHeader()
        {
            cbParentMedium.Bind();
            cbParentModif.Bind();
        }

        void InitTreeSolution()
        {
            //filtrar soluciones por elemento  y tipo de solucion
            //modSolInterm.GetLstSolution(idelement, type_pattern_solution)
            //lstSolution = modSolInterm.GetLstSolution(group_solution);
            lstSolution = modSolInterm.GetLstSolution(Convert.ToInt32(cbMethod1.EditValue), Idelement, Comun.TypePatternMr.SolucionPatron);

            //
            treeSolInterm.DataSource = lstSolution;
            treeSolInterm.ExpandAll();
        }

        CSolution_interm GetActiveFirstSolution()
        {
            if (lstSolution.Exists(c => c.Type_sol == 1 && c.Solution_status == true))
            {
                return lstSolution.First(c => c.Type_sol == 1 && c.Solution_status == true);
            }
            return null;
        }

        CSolution_interm GetActiveSecondSolution()
        {
            if (lstSolution.Exists(c => c.Type_sol == 2 && c.Solution_status == true))
            {
                return lstSolution.First(c => c.Type_sol == 2 && c.Solution_status == true);
            }
            return null;
        }

        CSolution_interm GetActiveStdVerification(CSolution_interm parent)
        {
            if (lstSolution.Exists(c => c.Type_sol == 3 && c.Solution_status == true && c.Parentid == parent.Id))
            {
                return lstSolution.First(c => c.Type_sol == 3 && c.Solution_status == true && c.Parentid == parent.Id);
            }
            return null;
        }

        CSolution_interm GetActiveStdVerification1()
        {
            if (lstSolution.Exists(c => c.Type_sol == 3 && c.Solution_status == true))
                return lstSolution.First(c => c.Type_sol == 3 && c.Solution_status == true);
            return null;
        }

        CSolution_interm GetActiveStdVerification2()
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
            if (!lstSolution.Exists(c => c.Idsolution_interm == 0 && c.Solution_status == true && c.Type_sol == 1))
            {
                int parentId = 0;

                if (tree.FocusedNode == null)
                    parentId = 0;
                else
                    parentId = Convert.ToInt32(tree.FocusedNode["Id"]);

                // obtener la validez de solucion intermedia desde el metodo                

                // --- añadir en la raiz
                lstSolution.Add(
                    new CSolution_interm
                    {
                        Idsolution_interm = 0,
                        Id = GetMaxCorrelativeNode() + 1,
                        Parentid = parentId,
                        Cod_solution = "Nueva solución intermedia 1", //modSolution.GetCorrelative(ModSolution.Correlative.SolucionIntermedia),
                        Date_begin = DateTime.Now,
                        Date_end = DateTime.Now.AddMonths(Convert.ToInt16(template_method_aa.Std_validity_sol1)),
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
                        Idreactive_medium = cbParentMedium.EditValue == null ? Comun.NullInt32 : Convert.ToInt32(cbParentMedium.EditValue),
                        Idreactive_modif = cbParentModif.EditValue == null ? Comun.NullInt32 : Convert.ToInt32(cbParentModif.EditValue),
                        Reactive_medium_value = GetMedium(1),
                        Root_type_pattern = Convert.ToInt32(treeSolInterm.FocusedNode["Root_type_pattern"]),
                        Root_idmr_detail = Convert.ToInt16(tree.FocusedNode["Root_idmr_detail"]),
                        Image_index = 1,
                        Flag_current_method = true
                    });

                treeSolInterm.DataSource = new BindingList<CSolution_interm>(lstSolution);
                treeSolInterm.ExpandAll();

                SetButtonsInProcess();
            }
            else
                new FormMessage("Agregar solución", "No es posible agregar. Existe una solución intermedia 1 en proceso.", true, false).ShowDialog();
        }

        void AddSecondSolution()
        {
            if (!lstSolution.Exists(c => c.Idsolution_interm == 0 && c.Solution_status == true && c.Type_sol == 2))
            {

                int parentId = 0;

                if (tree.FocusedNode == null)
                    parentId = 0;
                else
                    parentId = Convert.ToInt32(tree.FocusedNode["Id"]);

                // --- añadir dentro de una solución intermedia 1
                lstSolution.Add(
                    new CSolution_interm
                    {
                        Idsolution_interm = 0,
                        Id = GetMaxCorrelativeNode() + 1,
                        Parentid = parentId,
                        Cod_solution = "Nueva solución intermedia 2", //modSolution.GetCorrelative(ModSolution.Correlative.SolucionIntermedia),
                        Date_begin = DateTime.Now,
                        Date_end = DateTime.Now.AddMonths(Convert.ToInt16(template_method_aa.Std_validity_sol2)),
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
                        Idreactive_medium = cbParentMedium.EditValue == null ? Comun.NullInt32 : Convert.ToInt32(cbParentMedium.EditValue),
                        Idreactive_modif = cbParentModif.EditValue == null ? Comun.NullInt32 : Convert.ToInt32(cbParentModif.EditValue),
                        Reactive_medium_value = GetMedium(2),
                        Root_type_pattern = Convert.ToInt32(treeSolInterm.FocusedNode["Root_type_pattern"]),
                        Root_idmr_detail = Convert.ToInt16(tree.FocusedNode["Root_idmr_detail"]),
                        Image_index = 1,
                        Flag_current_method = true
                    });

                treeSolInterm.DataSource = new BindingList<CSolution_interm>(lstSolution);
                treeSolInterm.ExpandAll();
                
                SetButtonsInProcess();
            }
            else
                new FormMessage("Agregar solución", "No es posible agregar. Existe una solución intermedia 2 en proceso", true, false).ShowDialog();
        }        

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
                new CSolution_interm
                {
                    Idsolution_interm = 0,
                    Id = GetMaxCorrelativeNode() + 1,
                    Parentid = parentId,
                    Cod_solution = "Nuevo estandar", //modSolution.GetCorrelative(ModSolution.Correlative.EstandarVerificacion),
                    Date_begin = DateTime.Now,
                    Date_end = DateTime.Now.AddMonths(Convert.ToInt16(template_method_aa.Std_validity_sv)),
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
                    Idreactive_medium = cbParentMedium.EditValue == null ? Comun.NullInt32 : Convert.ToInt32(cbParentMedium.EditValue),
                    Idreactive_modif = cbParentModif.EditValue == null ? Comun.NullInt32 : Convert.ToInt32(cbParentModif.EditValue),
                    Reactive_medium_value = GetMedium(3),
                    Root_type_pattern = Convert.ToInt32(treeSolInterm.FocusedNode["Root_type_pattern"]),
                    Root_idmr_detail = Convert.ToInt16(tree.FocusedNode["Root_idmr_detail"]),
                    Image_index = 2,
                    Flag_current_method = true
                });

            treeSolInterm.DataSource = new BindingList<CSolution_interm>(lstSolution);
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
            if (Convert.ToInt32(parentNode["Idsolution_interm"]) == 0)
            {
                nodeSolutionInProcess = parentNode;
                treeSolInterm.FocusedNode = parentNode;
            }
            else
            {
                foreach (TreeListNode nodo in parentNode.Nodes)
                    GetNodeInProcess(nodo);
            }
        }

        int GetMaxCorrelativeNode()
        {
            var lista = lstSolution.Where(x => x.Parentid != 0).ToList(); // excluir raices (mr o patron solucion)
            int max = lista.Count == 0 ? 100 : Convert.ToInt32(lista.Max(c => c.Id));

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

        bool IsSolidSolutionPattern()
        {
            CMr_detail oMr_detail =
                new CMr_detailFactory()
                .GetByPrimaryKey(new CMr_detailKeys(Convert.ToInt16(template_method_aa.Std_mrorpattern)));
            CMr oMr = new CMrFactory().GetByPrimaryKey(new CMrKeys(Convert.ToInt16(oMr_detail.Idmr)));
            return Convert.ToBoolean(oMr.Solid);
        }

        public void Clear()
        {
            treeSolInterm.ClearNodes();
            cbParentMedium.EditValue = null;
            cbParentModif.EditValue = null;
            cbParentMedium.EditValue = null;
            cbParentModif.EditValue = null;
        }

        #endregion

        #region events

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
                //if (e.Node.Level == 0)
                //{
                //    // Muestra patron es terminal
                //    if (IsSolidSolutionPattern()) // sólido
                //        e.Node["Aliquot"] = Convert.ToDecimal(e.Node["Volumen"]) * Convert.ToDecimal(e.Node["Concentration"]) / template_method_aa.Std_concentration;
                //    else // líquido
                //        e.Node["Aliquot"] = Convert.ToDecimal(e.Node["Volumen"]) / (template_method_aa.Std_concentration / Convert.ToDecimal(e.Node["Concentration"]));

                //    tbAliquot.Value = Convert.ToInt32(e.Node["Aliquot"]);
                //}
                //else if (e.Node.Level >= 1) // solucion intermedia 
                //{
                //    // solución intermedia 1 o 2 es terminal
                //    // determinar la concentración
                //    decimal parentConcentration = Convert.ToDecimal(e.Node.ParentNode["Concentration"]);

                //    e.Node["Aliquot"] = Convert.ToDecimal(e.Node["Volumen"]) / Convert.ToDecimal(e.Node["Concentration"]) / parentConcentration;

                //    tbAliquot.Value = Convert.ToInt32(e.Node["Aliquot"]);
                //}
            }
            catch (Exception ex)
            {
                ComunForm.Send_message("Soluciones", TypeMsg.error, ex.Message);
            }
        }        

        private void cbMethod1_EditValueChanged(object sender, EventArgs e)
        {
            if (cbMethod1.EditValue != null)
            {
                // obtener modif y medium filtrado por cod template
                template_method_aa = new CTemplate_method_aaFactory().GetByPrimaryKey(new CTemplate_method_aaKeys(Convert.ToInt32(cbMethod1.EditValue)));


                if (template_method_aa != null)
                {
                    cbParentMedium.EditValue = template_method_aa.Medium;
                    cbParentModif.EditValue = template_method_aa.Modif;
                    tbParentMediumValue.Value = Convert.ToDecimal(template_method_aa.Medium_conc);
                    tbParentModifValue.Value = Convert.ToDecimal(template_method_aa.Modif_conc);

                    if (template_method_aa.Std_type_pattern == 1)
                    {
                        lstSolution = modSolInterm.GetLstSolution(Convert.ToInt32(cbMethod1.EditValue), Idelement, Comun.TypePatternMr.MrCertificado);
                        treeSolInterm.DataSource = lstSolution;
                    }
                    if (template_method_aa.Std_type_pattern == 2)
                    {
                        lstSolution = modSolInterm.GetLstSolution(Convert.ToInt32(cbMethod1.EditValue), Idelement, Comun.TypePatternMr.SolucionPatron);
                        treeSolInterm.DataSource = lstSolution;
                    }

                    treeSolInterm.ExpandAll();
                }
            }
        }

        private void repVolumen_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            object idsolution = treeSolInterm.FocusedNode["Idsolution_interm"];
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

        private void treeSolInterm_MouseDown(object sender, MouseEventArgs e)
        {
            tree = sender as TreeList;
            TreeListHitInfo ht = tree.CalcHitInfo(e.Location);
            if (ht != null && ht.Node != null)
            {
                tree.FocusedNode = ht.Node;

                //determinar que tipo de solucion es el nodo seleccionado
                int typeSol = Convert.ToInt32(tree.FocusedNode["Type_sol"]);

                //habilitar los botones en popup
                btNewSolInt1.Enabled = false;
                btNewSolInt2.Enabled = false;
                btNewSolStdVer.Enabled = false;

                if (nodeSolutionInProcess == null)
                {
                    if (typeSol == 0) // mrc o solucion patrón
                    {
                        //habilitar Solucion intermedia 1 y standar de verificacion
                        btNewSolInt1.Enabled = true;
                        btNewSolStdVer.Enabled = true;
                    }
                    else if (typeSol == 1) // solucion intermedia 1
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
            }
            else if (ht != null && ht.Node == null)
            {
                tree.FocusedNode = ht.Node;

                btNewSolInt1.Enabled = false;
                btNewSolInt2.Enabled = false;
                btNewSolStdVer.Enabled = false;
            }
        }

        private void btNewSolInt1_Click(object sender, EventArgs e)
        {
            AddFirstSolution();
        }

        private void btNewSolInt2_Click(object sender, EventArgs e)
        {
            AddSecondSolution();
        }

        private void btNewSolStdVer_Click(object sender, EventArgs e)
        {
            AddStdSolution();
        }
        
        private void FormSolInterm_Load(object sender, EventArgs e)
        {
            cbElement1.Bind();
            cbParentMedium.Bind();
            cbParentModif.Bind();
            cbElement1.Properties.NullText = "Elemento";
            cbMethod1.Properties.NullText = "Método";
            cbUser1.Bind();
        }

        private void cbElement1_EditValueChanged(object sender, EventArgs e)
        {
            Init(Convert.ToInt16(cbElement1.EditValue));
        }

        private void ucSign1_OnSign(bool login)
        {
            if (login)
            {
                //if (ckDisabledSolution.Checked)
                //{
                //    if (MessageBox.Show("Esta seguro que desea desactivar la solución.", "Desactivando solución", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                //    {
                //        //desactivar solucion
                //        TreeListNode node = treeSolInterm.FocusedNode;
                //        int idsolution_interm = Convert.ToInt32(node["Idsolution_interm"]);
                //        CSolution_interm sol = new CSolution_intermFactory().GetAll().Where(x => x.Idsolution_interm == idsolution_interm).FirstOrDefault();
                //        sol.Solution_status = false;
                //        if (sol != null)
                //            new CSolution_intermFactory().Update(sol);

                //    }
                //}
                //else
                //{
                //    if (Son_Datos_Correctos())
                //    {
                //        // --- guardando soluciones                        
                //        int idsolution_interm = 0;
                //        CSolution_intermFactory faSolution_interm = new CSolution_intermFactory();
                //        bool result_solution = false;

                //        TreeListNode node = treeSolInterm.FocusedNode;
                //        idsolution_interm = Convert.ToInt32(node["Idsolution_interm"]);

                //        for (int i = 0; i < lstSolution.Count; i++)
                //        {
                //            result_solution = false;

                //            if (lstSolution[i].Idsolution_interm == idsolution_interm)
                //            {
                //                if (idsolution_interm == 0)
                //                {
                //                    lstSolution[i].Cod_solution = null;

                //                    if (!(result_solution = faSolution_interm.Update(lstSolution[i])))
                //                        result_solution = faSolution_interm.Insert(lstSolution[i]);

                //                    // --- asignar un correlativo dependiendo del tipo de solución
                //                    // 1:{solución intermedia1}, 2:{solución intermedia 2}, 3:{estandar de verificación}
                //                    if (result_solution)
                //                    {
                //                        idsolution_interm = lstSolution[i].Idsolution_interm;

                //                        ModCorrelatives oModCorrelatives = new ModCorrelatives();
                //                        if (lstSolution[i].Type_sol == 1)
                //                            lstSolution[i].Cod_solution = oModCorrelatives.GetCorrelative(Comun.Correlative.SolucionInterm1);
                //                        else if (lstSolution[i].Type_sol == 2)
                //                            lstSolution[i].Cod_solution = oModCorrelatives.GetCorrelative(Comun.Correlative.SolucionInterm2);
                //                        else if (lstSolution[i].Type_sol == 3)
                //                            lstSolution[i].Cod_solution = oModCorrelatives.GetCorrelative(Comun.Correlative.EstandarVerificacion);

                //                        faSolution_interm.Update(lstSolution[i]);

                //                        // guardar método actual a la solución
                //                        CSolution_interm_methods oSolution_interm_methods = new CSolution_interm_methods();
                //                        oSolution_interm_methods.Idsolution_interm = lstSolution[i].Idsolution_interm;
                //                        oSolution_interm_methods.Idtemplate_method = Convert.ToInt32(cbMethod1.EditValue);
                //                        oSolution_interm_methods.Status = true;

                //                        if (!new CSolution_interm_methodsFactory().Update(oSolution_interm_methods))
                //                            new CSolution_interm_methodsFactory().Insert(oSolution_interm_methods);

                //                    }
                //                }
                //                else
                //                {
                //                    if (ckAssignMethod.Checked)
                //                    {
                //                        // guardar método actual a la solución
                //                        CSolution_interm_methods oSolution_interm_methods = new CSolution_interm_methods();
                //                        oSolution_interm_methods.Idsolution_interm = lstSolution[i].Idsolution_interm;
                //                        oSolution_interm_methods.Idtemplate_method = Convert.ToInt32(cbMethod1.EditValue);
                //                        oSolution_interm_methods.Status = true;

                //                        if (!new CSolution_interm_methodsFactory().Update(oSolution_interm_methods))
                //                            new CSolution_interm_methodsFactory().Insert(oSolution_interm_methods);
                //                    }
                //                }
                //            }
                //        }

                //        treeSolInterm.DataSource = lstSolution;
                //        gcMethods.DataSource = new ModSolInterm().GetLstTemplate_methodBySolution(idsolution_interm);

                //        // Seleccionar solucion
                //        if (idsolution_interm != 0)
                //        {
                //            TreeListNode nodo = treeSolInterm.FindNodeByFieldValue("Idsolution_interm", idsolution_interm);
                //            treeSolInterm.FocusedNode = nodo;
                //        }

                //        new FormMessage("Guardado", "Guardado correctamente.", true, false).ShowDialog();

                //        //ucSign1.Clear();
                //        treeSolInterm.ExpandAll();
                //    }
                //    else                    
                //    {
                //        //ucSign1.Clear();
                //    }
                //}
            }
            else
                new FormMessage("Error", "Contraseña incorrecta.", true, false).ShowDialog();
        }

        private void repBtOpenMethods_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // abrir ventana de metodos
            FormSelMethods fmSelMethods = new FormSelMethods();
            if (Convert.ToInt32(treeSolInterm.FocusedNode["Idsolution_interm"]) != 0)
            {
                fmSelMethods.Idsolution_interm = Convert.ToInt32(treeSolInterm.FocusedNode["Idsolution_interm"]);
                fmSelMethods.ShowDialog();
            }
        }

        private void treeSolInterm_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {            
            // mostrar detalle del nodo padre
            TreeListNode node = treeSolInterm.FocusedNode;
            if (node != null)
            {
                //apariencia
                TreeListNode parentNode = treeSolInterm.FocusedNode.ParentNode;

                if (parentNode == null)
                {
                    // solo mostrar panel de padre, mostrar los datos del padre en las cajas
                    gcSolutionParent.Visible = true;
                    gcSolutionChild.Visible = false;
                    paHeader.Height = 85;
                    paSeparator.Visible = false;

                    tbParentConcentration.Text = node["Concentration"].ToString();

                    gcSolutionParent.Text = node["Cod_solution"].ToString() + " - Solución Padre";
                }
                else if (parentNode != null)
                {
                    // mostrar paneles padre e hijo
                    gcSolutionParent.Visible = true;
                    gcSolutionChild.Visible = true;
                    paHeader.Height = 252;
                    paSeparator.Visible = true;

                    //tbConcentration.Text = node["Concentration"].ToString();
                    //tbVolumen.Value = Convert.ToDecimal(node["Volumen"]);
                    //tbAliquot.Value = Convert.ToDecimal(node["Aliquot"]);
                    deDateIni.DateTime = Convert.ToDateTime(node["Date_begin"]);
                    deDateEnd.DateTime = Convert.ToDateTime(node["Date_end"]);
                    cbUser1.EditValue = Convert.ToInt16(node["Prepared_by"]);
                    //ckDisabledSolution.Checked = !Convert.ToBoolean(node["Solution_status"]);
                    //exPanel.Expanded = Convert.ToBoolean(node["Solution_status"]) ? false : true;
                    DateTime currentDate = Comun.GetDate();
                    //laVigencia.Visible = currentDate >= deDateIni.DateTime.RankIni() && currentDate <= deDateEnd.DateTime.RankEnd() ? false : true;

                    tbParentConcentration.Text = parentNode["Concentration"].ToString();

                    gcSolutionParent.Text = parentNode["Cod_solution"].ToString() + " - Solución Padre";
                    gcSolutionChild.Text = node["Cod_solution"].ToString() + " - Solución Hijo";
                }
                
                // mostrar métodos
                int idsolution_interm = Convert.ToInt32(node["Idsolution_interm"]);
                Comun.TypePatternMr typePatterMr = Convert.ToInt32(node["Root_type_pattern"]) == 1 ? Comun.TypePatternMr.MrCertificado : Comun.TypePatternMr.SolucionPatron;
                gcMethods.DataSource = new ModSolInterm().GetLstTemplate_methodBySolution(idsolution_interm);

                ///si es nueva solución seleccionada, no mostrar chekbox y habilitar firma una vez modificado el volumen.
                ///si es solución existente, y el método seleccionado no está linkeado mostrar el chekbox.
                if (idsolution_interm == 0)
                {
                    ckAssignMethod.Visible = false;
                    ckAssignMethod.Checked = false;
                }
                else
                {
                    CSolution_interm_methods solFound = 
                        new CSolution_interm_methodsFactory()
                        .GetAll()
                        .Where(x => x.Idsolution_interm == idsolution_interm
                            && x.Idtemplate_method == Convert.ToInt32(cbMethod1.EditValue)).FirstOrDefault();

                    if (solFound == null)
                    {
                        ckAssignMethod.Visible = true;
                        ckAssignMethod.Checked = false;
                    }
                    else
                    {
                        ckAssignMethod.Visible = false;
                        ckAssignMethod.Checked = false;
                    }
                }                
            }
        }

        private void tbVolumen_EditValueChanged(object sender, EventArgs e)
        {
            TreeListNode node = treeSolInterm.FocusedNode;

            //node["Volumen"] = tbVolumen.Value;

            /*
            Solidos
            -------
            1: Alicuota = volumen*concentracion/concentracion patron

            Líquidos
            --------
            1: Alicuota = volumen/(concentracion patron/concentracion)  */            
            try
            {
                decimal volumen = Convert.ToDecimal(node["Volumen"]);
                decimal concentracion = Convert.ToDecimal(node["Concentration"]);
                decimal aliquot = 0;

                if (node.Level >= 1) // solucion intermedia 
                {
                    TreeListNode parentNode = node.ParentNode;
                    decimal concParent= Convert.ToDecimal(parentNode["Concentration"]);

                    // Muestra patron es terminal
                    if (IsSolidSolutionPattern()) // sólido
                        aliquot = volumen * concentracion / concParent;
                    else // líquido
                        aliquot = volumen / (concParent / concentracion);

                    node["Aliquot"] = aliquot;
                    //tbAliquot.Value = aliquot;
                }
            }
            catch (Exception ex)
            {
                ComunForm.Send_message("Soluciones", TypeMsg.error, ex.Message);
            }
        }

        private void ckAssignMethod_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int idsolution_interm = Convert.ToInt32(treeSolInterm.FocusedNode["Idsolution_interm"]);
            if (idsolution_interm != 0)
            {
                e.Cancel = true;
            }
        }

        private void deDateIni_EditValueChanged(object sender, EventArgs e)
        {
            if (treeSolInterm.FocusedNode != null)
                treeSolInterm.FocusedNode["Date_begin"] = deDateIni.DateTime;
        }

        private void deDateEnd_EditValueChanged(object sender, EventArgs e)
        {
            if (treeSolInterm.FocusedNode != null)
                treeSolInterm.FocusedNode["Date_end"] = deDateEnd.DateTime;
        }

        #endregion
    }
}
