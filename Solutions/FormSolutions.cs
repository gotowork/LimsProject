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

        #region constructor

        public FormSolutions()
        {
            InitializeComponent();
        }

        #endregion        

        void Init()
        {
            // --- init element
            cbElement.Properties.DataSource = new CElementFactory().GetAll();
            cbElement.Properties.ValueMember = "Idelement";
            cbElement.Properties.DisplayMember = "Cod_element";
        }        

        #region events

        private void FormStdCalibMain_Load(object sender, EventArgs e)
        {
            Init();
        }            

        protected override void Recuperar_Registro()
        {
            if (cbElement.EditValue != null)
            {                
            }
        }
        

        #endregion        

                     

        private void cbElement_EditValueChanged(object sender, EventArgs e)
        {
            if (cbElement.EditValue != null)
            {                                
                /// listar los métodos por elementos que coincidan con el tipo de solución 
                /// seleccionada
                ///1:SC, 2:SI-1, 3:SI-2, 4:EV, 5:ST
                ///  
                                               
            }
        }
    }
}
