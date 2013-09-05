using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using LimsProject.BusinessLayer;
using LimsProject.BusinessLayer.Modules;
using DevExpress.XtraTreeList.Nodes;

namespace LimsProject
{
    public partial class FormSolutions : LibraryBasicForm.FormBaseEmpty
    {

        #region calibration's attributes

        DevExpress.XtraTreeList.Nodes.TreeListNode treeStdCalib;
        DevExpress.XtraTreeList.Nodes.TreeListNode treeSolInterm1;
        DevExpress.XtraTreeList.Nodes.TreeListNode treeSolInterm2;
        DevExpress.XtraTreeList.Nodes.TreeListNode treeStdVerif;
        DevExpress.XtraTreeList.Nodes.TreeListNode treeSolTitration;

        CGroup_solution group_solution = null;
        CTemplate_method_aa template_method_aa = null;

        #endregion

        public int TypeSolution;

        #region constructor

        public FormSolutions()
        {
            InitializeComponent();
        }

        #endregion

        void InitTree()
        {
            treeStdCalib = treeSolution.Nodes[0];
            treeSolInterm1 = treeSolution.Nodes[1];
            treeSolInterm2 = treeSolution.Nodes[2];
            treeStdVerif = treeSolution.Nodes[3];
            treeSolTitration = treeSolution.Nodes[4];

            // --- solutions
            treeStdCalib.Tag = 1;
            treeSolInterm1.Tag = 2;
            treeSolInterm2.Tag = 3;
            treeStdVerif.Tag = 4;
            treeSolTitration.Tag = 5;

            TypeSolution = Convert.ToInt32(treeStdCalib.Tag);

            // --- limpiar nodos constantes
            treeStdCalib.Nodes.Clear();
            treeSolInterm1.Nodes.Clear();
            treeSolInterm2.Nodes.Clear();
            treeStdVerif.Nodes.Clear();
            treeSolTitration.Nodes.Clear();

            ModSolution oModSolution = new ModSolution();
            CGroup_solutionFactory faGroup_solution = new CGroup_solutionFactory();
            List<CGroup_solution> lstGroup_solution = faGroup_solution.GetAll();

            // 1:SC, 2:SI-1, 3:SI-2, 4:EV, 5:ST
            foreach (var item in lstGroup_solution)
            {                
                // solución de calibracion (SC)
                if (item.Type_solution == 1)
                {
                    object[] obj = { item.Cod_solution, item.Idgroup_solution, item.Idmr_detail /*, item.Idsolution_pattern*/ };
                    TreeListNode node = treeSolution.AppendNode(obj, treeStdCalib);
                    node.Tag = treeStdCalib.Tag;
                    node.ImageIndex = 1;
                    node.SelectImageIndex = 1;
                }
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
                if (item.Type_solution == 5)
                {
                    object[] obj = { item.Cod_solution, item.Idgroup_solution, item.Idmr_detail /*, item.Idsolution_pattern*/ };
                    TreeListNode node = treeSolution.AppendNode(obj, treeSolTitration);
                    node.Tag = treeSolTitration.Tag;
                    node.ImageIndex = 1;
                    node.SelectImageIndex = 1;                    
                }
            }

            treeSolution.ExpandAll();
        }

        void Init()
        {
            // --- init element
            cbElement.Properties.DataSource = new CElementFactory().GetAll();
            cbElement.Properties.ValueMember = "Idelement";
            cbElement.Properties.DisplayMember = "Cod_element";
            
        }

        void ShowStatusControls(CGroup_solution oGroup_solution)
        {
            if (oGroup_solution.Type_solution == 1) // Estandar de calibracion
            {
                // --- show panels

                tabSupCalib.PageVisible = true;
                tabSupTitration.PageVisible = false;
                tabSupSolInterm.PageVisible = false;

                // --- status control
                ucCalibStd1.ApplyStatus();
            }
            else if (oGroup_solution.Type_solution == 2
                || oGroup_solution.Type_solution == 3
                || oGroup_solution.Type_solution == 4) // Soluciones intermedias y estandares de verificación
            {
                // --- show panels

                tabSupCalib.PageVisible = false;
                tabSupSolInterm.PageVisible = true;
                tabSupTitration.PageVisible = false;
             
            }
            else if (oGroup_solution.Type_solution == 5) // soluciones titulantes
            {
                // --- show panels

                tabSupCalib.PageVisible = false;
                tabSupSolInterm.PageVisible = false;
                tabSupTitration.PageVisible = true;
            }
        }

        #region events

        private void FormStdCalibMain_Load(object sender, EventArgs e)
        {            
            treeSolution.ExpandAll();                                  
            InitTree();
            Init();
        }

        private void Clear_detail()
        {
            template_method_aa = null;
            cbMethod.EditValue = null; 
            cbElement.EditValue = null;                       
            ucMethodCalib.Clear();            
            ucCalibStd1.Clear();
            ucSolInterm1.Clear();            
        }

        private void treeSolution_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            Clear_detail();

            // --- recuperar data sólo si se seleccionó una solución existente
            if (e.Node == treeStdCalib || e.Node == treeSolInterm1 || e.Node == treeSolInterm2
                || e.Node == treeSolTitration || e.Node == treeStdVerif) // estos nodos son sólo nombres
            {                
                gpTitle.Text = "";                
                gpTitle.Enabled = true;
                group_solution = null;
                TypeSolution = Convert.ToInt32(e.Node.Tag);
                tabMain.Visible = false;
            }
            else // este nodo es un grupo existente
            {
                // --- recuperar filtros bloqueados
                gpTitle.Enabled = false;
                gpTitle.Text = "";
                TypeSolution = Convert.ToInt32(e.Node.Tag);
                tabMain.Visible = true;
                cbElement.EditValue = null;
                cbMethod.EditValue = null;
                
                // --- recuperar datos
                // calibraciones: recuperar datos de calibraciones
                // soluciones intermedias: recuperar el grupo o raiz de soluciones
                // estandar de verificacion: recuperar el grupo o raiz de soluciones                
                int? idgroup_solution = null;

                if (treeSolution.FocusedNode["Idgroup_solution"] != null)
                    idgroup_solution = Convert.ToInt32(treeSolution.FocusedNode["Idgroup_solution"]);                                

                if (idgroup_solution != null)
                {
                    group_solution = new CGroup_solutionFactory().GetByPrimaryKey(new CGroup_solutionKeys(Convert.ToInt32(idgroup_solution)));

                    // --- recuperar titulo
                    if (group_solution != null)
                    {
                        cbElement.EditValue = Convert.ToInt16(group_solution.Idelement);
                        cbMethod.EditValue = group_solution.Idtemplate_method;                                                
                    }
                }
            }
        }

        void Recuperate_calib(CGroup_solution group_solution)
        {
            // --- recuperar metodos
            ucMethodCalib.Init(group_solution);

            // --- recuperar absorbancias de cada calibración.
            ucCalibStd1.Enabled = true;
            ucCalibStd1.Init(group_solution, ucMethodCalib.LstTemplate_method);
        }

        void Recuperate_SolInterm(CGroup_solution group_solution)
        {            
            // --- inicilizar método
            template_method_aa = new CTemplate_method_aaFactory().GetByPrimaryKey(new CTemplate_method_aaKeys(Convert.ToInt32(group_solution.Idtemplate_method)));

            // --- inicilizar grupo de solución
            tabSupCalib.PageVisible = false;
            tabSupTitration.PageVisible = false;
            tabSupSolInterm.PageVisible = true;

            ///Determinar el límite a crear soluciones según el método seleccionado y 
            ///los métodos ya presentes
            ///
            List<CSolution> query = new CSolutionFactory().GetAll().Where(c=> c.Idgroup_solution == group_solution.Idgroup_solution).ToList();
            var query2 = 
                (from m in query
                 join n in new CSolution_methodsFactory().GetAll() on m.Idsolution equals n.Idsolution
                 join p in new CTemplate_method_aaFactory().GetAll() on n.Idtemplate_method equals p.Idtemplate_method
                 select new
                 {
                     flag1 = p.Std_flag_sol_intermedia1 == null ? false : p.Std_flag_sol_intermedia1,
                     flag2 = p.Std_flag_sol_intermedia2 == null ? false : p.Std_flag_sol_intermedia2
                 }).ToList();
            
            foreach (var item in query2)
            {
                if (Convert.ToBoolean(item.flag1) == true)
                    group_solution.Flag_sol_intermedia1 = true;
                if (Convert.ToBoolean(item.flag2) == true)
                    group_solution.Flag_sol_intermedia2 = true;
            }

            group_solution.Idreactive_medium = template_method_aa.Medium;
            group_solution.Idreactive_modif = template_method_aa.Modif;
            group_solution.Idmr_detail = Convert.ToInt16(template_method_aa.Std_mrorpattern);
            group_solution.Type_pattern = template_method_aa.Std_type_pattern;
            //group_solution.Flag_sol_intermedia1 = template_method_aa.Std_flag_sol_intermedia1;
            //group_solution.Flag_sol_intermedia2 = template_method_aa.Std_flag_sol_intermedia2;
            group_solution.Idtemplate_method = template_method_aa.Idtemplate_method;            

            // --- inicializar soluciones
            ucSolInterm1.Init(group_solution);
        }

        CGroup_solution GetGroup_solution(int? p_idgroup_solution)
        {
            if (p_idgroup_solution != null)
            {
                CGroup_solution oGroup_solution = new CGroup_solutionFactory().GetByPrimaryKey(new CGroup_solutionKeys(Convert.ToInt32(p_idgroup_solution)));
                return oGroup_solution;
            }
            return null;
        }

        void PreparedNewGroup()
        {
            // --- no existe una coincidencia para el pivot seleccionado.
            group_solution = new CGroup_solution();
            group_solution.Idelement = Convert.ToInt32(cbElement.EditValue);
            group_solution.Idtemplate_method = template_method_aa.Idtemplate_method;            

            // listar los tabuladores
            if (TypeSolution == 1) // calibraciones
            {
                tabSupCalib.PageVisible = true;
                tabSupTitration.PageVisible = false;
                tabSupSolInterm.PageVisible = false;
                group_solution.Type_solution = Convert.ToInt32(TypeSolution);
                group_solution.Idmr_detail = template_method_aa.Mrorpattern;
                group_solution.Idreactive_medium = template_method_aa.Medium;
                group_solution.Idreactive_modif = template_method_aa.Modif;
                group_solution.Type_pattern = template_method_aa.Type_pattern;

                // --- inicializar método
                ucMethodCalib.Init(group_solution, template_method_aa);
            }
            else if (TypeSolution == 2 || TypeSolution == 3 || TypeSolution == 4) // solución intermedia y estandar de verificación
            {
                tabSupCalib.PageVisible = false;
                tabSupTitration.PageVisible = false;
                tabSupSolInterm.PageVisible = true;
                group_solution.Type_solution = Convert.ToInt32(TypeSolution);
                group_solution.Idreactive_medium = template_method_aa.Medium;
                group_solution.Idreactive_modif = template_method_aa.Modif;
                group_solution.Idmr_detail = Convert.ToInt16(template_method_aa.Std_mrorpattern);
                group_solution.Type_pattern = template_method_aa.Std_type_pattern;
                group_solution.Flag_sol_intermedia1 = template_method_aa.Std_flag_sol_intermedia1;
                group_solution.Flag_sol_intermedia2 = template_method_aa.Std_flag_sol_intermedia2;

                // --- inicializar método    
                ucSolInterm1.Init(group_solution);
            }
            else if (TypeSolution == 5) // solución titulante
            {
                tabSupCalib.PageVisible = false;
                tabSupTitration.PageVisible = true;
                tabSupSolInterm.PageVisible = false;
                group_solution.Type_solution = Convert.ToInt32(TypeSolution);
                //<PENDIENTE>
                //ucMethodTitration.Init(group_solution, template_method_aa);
            }
        }

        void GetDetailGroup(CGroup_solution group_solution)
        {            
            // --- recuperar datos
            // calibraciones: recuperar datos de calibraciones
            // soluciones intermedias: recuperar el grupo o raiz de soluciones
            // estandar de verificacion: recuperar el grupo o raiz de soluciones                

            // --- recuperar titulo
            if (group_solution != null)
            {
                group_solution.Idtemplate_method = template_method_aa.Idtemplate_method;

                // --- recuperar filtros bloqueados
                gpTitle.Enabled = false;
                gpTitle.Text = "";
                TypeSolution = Convert.ToInt32(group_solution.Type_solution);
                tabMain.Visible = true;                

                if (group_solution.Cod_solution == null)                
                    gpTitle.Text = "";                                    
                else
                    gpTitle.Text = group_solution.Cod_solution;

                gpTitle.Enabled = false;

                cbElement.EditValue = Convert.ToInt16(group_solution.Idelement);

                // --- mostrar tabuladores principales
                ShowStatusControls(group_solution);

                // --- recuperar calibraciones
                if (group_solution.Type_solution == 1)
                    Recuperate_calib(group_solution);

                // --- recuperar soluciones intermedias
                else if (group_solution.Type_solution == 2 || group_solution.Type_solution == 3 || group_solution.Type_solution == 4)
                    Recuperate_SolInterm(group_solution);
            }
        }

        protected override void Recuperar_Registro()
        {
            if (cbElement.EditValue != null && cbMethod.EditValue != null)
            {

                tabMain.Visible = true;
                int typeSol = Convert.ToInt32(treeSolution.FocusedNode.Tag);


                if (template_method_aa == null)
                    template_method_aa = new CTemplate_method_aaFactory().GetByPrimaryKey(new CTemplate_method_aaKeys(Convert.ToInt32(cbMethod.EditValue)));

                // --- recuperar group_solution
                ModSolution modSolution = new ModSolution();
                //group_solution = modSolution.GetGroupSolution(Convert.ToInt32(cbElement.EditValue), template_method_aa.Medium, template_method_aa.Modif, template_method_aa.Idtemplate_method, typeSol);            

                if (group_solution == null)
                {
                    group_solution = modSolution.GetGroupSolution(template_method_aa.Idtemplate_method, typeSol);                    

                    if (group_solution == null)
                    {
                        PreparedNewGroup();
                    }
                    else
                    {                        
                        GetDetailGroup(group_solution);
                    }
                }
                else
                    GetDetailGroup(group_solution);
            }
        }
        

        #endregion        

        private void ucCalibStd1_onNewCalib(CGroup_solution e)
        {
            // --- mensaje que se agregó una nueva calibración
            FormMessage fmMessage = new FormMessage();
            fmMessage.Message = "Se agregó la calibración " + e.Cod_solution;
            if (fmMessage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {                
                // --- inicializar el arbol
                InitTree();

                // --- seleccionar el nuevo nodo agregado
                FindAndFocusNode(e);
            }
        }

        void FocusNode(TreeListNode node, int idgroup_solution)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                if (Convert.ToInt32(node.Nodes[i]["Idgroup_solution"]) == idgroup_solution)
                {
                    treeSolution.FocusedNode = node.Nodes[i];
                    return;
                }
            }
        }

        void FindAndFocusNode(CGroup_solution nodo)
        {
            if (nodo.Type_solution == 1)            
                FocusNode(treeStdCalib, nodo.Idgroup_solution);
            if (nodo.Type_solution == 2)
                FocusNode(treeSolInterm1, nodo.Idgroup_solution);
            if (nodo.Type_solution == 3)
                FocusNode(treeSolInterm2, nodo.Idgroup_solution);
            if (nodo.Type_solution == 4)
                FocusNode(treeStdVerif, nodo.Idgroup_solution);
            if (nodo.Type_solution == 5)
                FocusNode(treeSolTitration, nodo.Idgroup_solution);
        }

        private void cbElement_EditValueChanged(object sender, EventArgs e)
        {
            if (cbElement.EditValue != null)
            {
                int typeSolution = Convert.ToInt32(treeSolution.FocusedNode.Tag);
                
                /// listar los métodos por elementos que coincidan con el tipo de solución 
                /// seleccionada
                ///1:SC, 2:SI-1, 3:SI-2, 4:EV, 5:ST
                ///
                bool? solInterm1 = null;
                bool? solInterm2 = null; 
                
                if (typeSolution == 2 || typeSolution == 3)
                {
                    if (typeSolution == 2)
                    {
                        solInterm1 = true;
                        //solInterm2 = false;
                    }
                    if (typeSolution == 3)
                    {
                        solInterm1 = true;
                        solInterm2 = true;
                    }
                }

                var lstTemplate =
                    (from m in new CTemplate_methodFactory().GetAll()
                     where m.Idelement == Convert.ToInt32(cbElement.EditValue)                     
                     select new
                     {
                         Idtemplate_method = m.Idtemplate_method,
                         Cod_template_method = m.Cod_template_method,
                         Title = m.Title,
                         CodTitle = m.Cod_template_method + " - " + m.Title
                     }).ToList();

                var lstTemplate_aa =
                    (from m in new CTemplate_method_aaFactory().GetAll()
                     join n in lstTemplate on m.Idtemplate_method equals n.Idtemplate_method
                     where (m.Std_flag_sol_intermedia1 == solInterm1 || solInterm1 == null)
                     && (m.Std_flag_sol_intermedia2 == solInterm2 || solInterm2 == null)
                     select new {
                         Idtemplate_method = n.Idtemplate_method,
                         Cod_template_method = n.Cod_template_method,
                         Title = n.Title,
                         CodTitle = n.CodTitle
                     }).ToList();
                                    
                cbMethod.Properties.DataSource = lstTemplate_aa;
                cbMethod.Properties.DisplayMember = "CodTitle";
                cbMethod.Properties.ValueMember = "Idtemplate_method";
            }
        }

        void RecuperateDetail()
        {
            
        }        

        private void ucMethodCalib_onConfirmSelection()
        {            
            ucCalibStd1.Enabled = true;
            ucCalibStd1.Init(group_solution, ucMethodCalib.LstTemplate_method);

            // --- show method
            if (group_solution.Type_solution == 1)
                tabProcessCalib.SelectedTabPage = tabModCalib;            
        }

        private void ucCalibStd1_onSignCalibs(CGroup_solution e)
        {
            // inicializar el arbol
            InitTree();

            // seleccionar el nuevo nodo agregado
            FindAndFocusNode(e);
        }        

        private void ucSolInterm1_onSignSolInterm(CGroup_solution e)
        {
            // inicializar el arbol
            InitTree();

            // seleccionar el nuevo nodo agregado
            FindAndFocusNode(e);
        }

        private void cbMethod_EditValueChanged(object sender, EventArgs e)
        {
            Recuperar_Registro();
        }
        
    }
}
