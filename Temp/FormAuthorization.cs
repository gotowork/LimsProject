using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LimsProject.BusinessLayer;
using LimsProject.BusinessLayer.Modules;

namespace LimsProject
{
    public partial class FormAuthorization : LibraryBasicForm.FormMantBase
    {
        BindingList<CDocumentation> lstDocumentation = new BindingList<CDocumentation>();
        
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            Load_process();
        }

        public void Load_process()
        {
            Authorization oAuthorization = new Authorization();
            cbDocument.Properties.DataSource = oAuthorization.GetDocument();
            cbDocument.Properties.DisplayMember = "Folder_name";
            cbDocument.Properties.ValueMember = "Idconfiguration_folder";

            cbProcedure.Properties.DataSource = oAuthorization.GetProcedure();
            cbProcedure.Properties.DisplayMember = "Name";
            cbProcedure.Properties.ValueMember = "Id";

            ShowDocumentation();
        }

        public void ShowDocumentation()
        {
            if (cbDocument.EditValue != null && cbProcedure.EditValue != null)
            {
                Authorization oAuthorization = new Authorization();
                lstDocumentation = new BindingList<CDocumentation>(oAuthorization.GetDocumentation(Convert.ToInt16(cbDocument.EditValue), Convert.ToChar(cbProcedure.EditValue)));
                treeAuthorization.DataSource = lstDocumentation;
            }
        }

        void AddParentNode()
        {
            // --- this method add a son node for one node selected            
            lstDocumentation.Add(
                    new CDocumentation
                    {
                        Iddocumentation = -1,
                        Idtemplate_method = null,
                        Idconfiguration_folder = Convert.ToInt16(cbDocument.EditValue),
                        Procedure_type = Convert.ToChar(cbProcedure.EditValue),
                        Type_doc = 'C',
                        Image_index = 0,
                        Id = GetNewIdNode(),
                        Parentid = 0
                    });
            treeAuthorization.DataSource = lstDocumentation;
        }

        void AddChildNode()
        {
            // --- 
            if (treeAuthorization.FocusedNode.Level == 0)
            {
                lstDocumentation.Add(
                        new CDocumentation
                        {
                            Iddocumentation = -1,
                            Idtemplate_method = null,
                            Idconfiguration_folder = Convert.ToInt16(cbDocument.EditValue),
                            Procedure_type = Convert.ToChar(cbProcedure.EditValue),
                            Type_doc = 'E',
                            Id = GetNewIdNode(),
                            Image_index = 1,
                            Parentid = Convert.ToInt32(treeAuthorization.FocusedNode["Id"])
                        });
                treeAuthorization.DataSource = lstDocumentation;
            }
            if (treeAuthorization.FocusedNode.Level == 1)
            {
                lstDocumentation.Add(
                        new CDocumentation
                        {
                            Iddocumentation = -1,
                            Idtemplate_method = null,
                            Idconfiguration_folder = Convert.ToInt16(cbDocument.EditValue),
                            Procedure_type = Convert.ToChar(cbProcedure.EditValue),
                            Type_doc = 'E',
                            Id = GetNewIdNode(),
                            Image_index = 1,
                            Parentid = Convert.ToInt32(treeAuthorization.FocusedNode.ParentNode["Id"])
                        });
                treeAuthorization.DataSource = lstDocumentation;
            }
        }

        int GetNewIdNode()
        {
            // --- this method return a new node
            int result;
            if (lstDocumentation.Count() == 0)
                result = 0;
            else
                result = lstDocumentation.Max(c => c.Id);

            return result+1;
        }

        private void btAddParent_Click(object sender, EventArgs e)
        {
            AddParentNode();
        }

        private void btAttach_Click(object sender, EventArgs e)
        {
            AddChildNode();
        }

        private void cbDocument_EditValueChanged(object sender, EventArgs e)
        {
            ShowDocumentation();
        }

        private void cbProcedure_EditValueChanged(object sender, EventArgs e)
        {
            ShowDocumentation();
        }
    }
}
