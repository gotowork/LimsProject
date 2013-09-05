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
using System.IO;
using System.Diagnostics;

namespace LimsProject
{
    public partial class FormDocument : Form
    {
        #region attributes

        Authorization oAuthorization = new Authorization();
        BindingList<CDocumentation> lstDocumentation = new BindingList<CDocumentation>();
        BindingList<CDocumentation_User_File> lstDocumentation_user_file = new BindingList<CDocumentation_User_File>();

        string source_path;
        string destiny_path;

        #endregion

        #region constructors

        public FormDocument()
        {
            InitializeComponent();
        }

        #endregion 

        #region methods

        public void Load_user()
        {            
            CUser_systemFactory faUser_system = new CUser_systemFactory();
            cbUser.Properties.DataSource = faUser_system.GetAll();
            cbUser.Properties.DisplayMember = "Cod_user";
            cbUser.Properties.ValueMember = "Iduser";
        }

        public void Load_process()
        {
            Load_authorization();
            Load_procedure();
            Load_user();
            ShowDocumentation();
        }

        public void Load_authorization()
        {            
            cbDocument.Properties.DataSource = oAuthorization.GetDocument();
            cbDocument.Properties.DisplayMember = "Folder_name";
            cbDocument.Properties.ValueMember = "Idconfiguration_folder";
        }

        public void Load_procedure()
        {
            cbProcedure.Properties.DataSource = oAuthorization.GetProcedure();
            cbProcedure.Properties.DisplayMember = "Name";
            cbProcedure.Properties.ValueMember = "Id";
        }

        public void ShowDocumentation()
        {
            if (cbDocument.EditValue != null && cbProcedure.EditValue != null && cbUser.EditValue != null)
            {
                lstDocumentation_user_file = new BindingList<CDocumentation_User_File>(
                    oAuthorization.GetListDocumentation_User_File(Convert.ToInt16(cbDocument.EditValue), Convert.ToChar(cbProcedure.EditValue), Convert.ToInt16(cbUser.EditValue), Convert.ToInt32(tbExpiration.Value)));
                treeAuthorization.DataSource = lstDocumentation_user_file;
            }
        }

        void AddParentNode()
        {
            // --- this method add a son node for one selected node            

            CDocumentation_User_File oDocUserFile =
                    new CDocumentation_User_File
                    {
                        Iddocumentation = -1,
                        Idtemplate_method = null,
                        Idconfiguration_folder = Convert.ToInt16(cbDocument.EditValue),
                        Name_doc = "Certificado",
                        Procedure_type = Convert.ToChar(cbProcedure.EditValue),
                        Type_doc = 'C',
                        Image_index = 0,
                        Id = GetNewIdNode(),
                        Parentid = 0,
                        Date_ini = DateTime.Now,
                        Date_end = DateTime.Now.AddMonths(12),
                        Rank_valid_inmonth = 12,
                        Prev_authorized = false
                    };

            lstDocumentation_user_file.Add(oDocUserFile);

            // --- save 
            CDocumentationFactory faDocumentation = new CDocumentationFactory();
            CDocumentation oDocumentation = new CDocumentation();
            oDocumentation.Iddocumentation = oDocUserFile.Iddocumentation;
            oDocumentation.Idconfiguration_folder = oDocUserFile.Idconfiguration_folder;
            oDocumentation.Idtemplate_method = oDocUserFile.Idtemplate_method;
            oDocumentation.Image_index = oDocUserFile.Image_index;
            oDocumentation.Name_doc = oDocUserFile.Name_doc;
            oDocumentation.Procedure_type = oDocUserFile.Procedure_type;
            oDocumentation.Type_doc = oDocUserFile.Type_doc;
            oDocumentation.Flag_enabled = true;
            oDocumentation.Id = oDocUserFile.Id;
            oDocumentation.Parentid = oDocUserFile.Parentid;
            oDocumentation.Usernew = Comun.GetUser();
            oDocumentation.Useredit = Comun.GetUser();
            oDocumentation.Datenew = DateTime.Now;
            oDocumentation.Dateedit = DateTime.Now;
            oDocumentation.Status = true;
            treeAuthorization.DataSource = lstDocumentation_user_file;

            faDocumentation.Insert(oDocumentation);

            treeAuthorization.DataSource = lstDocumentation_user_file;
        }

        void AddChildNode()
        {
            // --- 
            if (treeAuthorization.FocusedNode.Level == 0)
            {
                CDocumentation_User_File oDocUserFile =
                    new CDocumentation_User_File
                    {
                        Iddocumentation = -1,
                        Idtemplate_method = null,
                        Idconfiguration_folder = Convert.ToInt16(cbDocument.EditValue),
                        Name_doc = "Adjunto",
                        Procedure_type = Convert.ToChar(cbProcedure.EditValue),
                        Type_doc = 'E',
                        Id = GetNewIdNode(),
                        Image_index = 1,
                        Parentid = Convert.ToInt32(treeAuthorization.FocusedNode["Id"]),
                        Date_ini = DateTime.Now,
                        Date_end = DateTime.Now.AddMonths(12),
                        Rank_valid_inmonth = 12,
                        Prev_authorized = false
                    };

                lstDocumentation_user_file.Add(oDocUserFile);

                // --- save 
                CDocumentationFactory faDocumentation = new CDocumentationFactory();
                CDocumentation oDocumentation = new CDocumentation();
                oDocumentation.Iddocumentation = oDocUserFile.Iddocumentation;
                oDocumentation.Idconfiguration_folder = oDocUserFile.Idconfiguration_folder;
                oDocumentation.Idtemplate_method = oDocUserFile.Idtemplate_method;
                oDocumentation.Image_index = oDocUserFile.Image_index;
                oDocumentation.Name_doc = oDocUserFile.Name_doc;
                oDocumentation.Procedure_type = oDocUserFile.Procedure_type;
                oDocumentation.Type_doc = oDocUserFile.Type_doc;
                oDocumentation.Flag_enabled = true;
                oDocumentation.Id = oDocUserFile.Id;
                oDocumentation.Parentid = oDocUserFile.Parentid;
                oDocumentation.Usernew = Comun.GetUser();
                oDocumentation.Useredit = Comun.GetUser();
                oDocumentation.Datenew = DateTime.Now;
                oDocumentation.Dateedit = DateTime.Now;
                oDocumentation.Status = true;
                treeAuthorization.DataSource = lstDocumentation_user_file;

                //faDocumentation.Insert(oDocumentation);

                treeAuthorization.DataSource = lstDocumentation_user_file;
                treeAuthorization.FocusedNode.ExpandAll();
            }
            else if (treeAuthorization.FocusedNode.Level == 1)
            {
                CDocumentation_User_File oDocUserFile =
                    new CDocumentation_User_File
                    {
                        Iddocumentation = -1,
                        Idtemplate_method = null,
                        Idconfiguration_folder = Convert.ToInt16(cbDocument.EditValue),
                        Procedure_type = Convert.ToChar(cbProcedure.EditValue),
                        Type_doc = 'E',
                        Id = GetNewIdNode(),
                        Image_index = 1,
                        Parentid = Convert.ToInt32(treeAuthorization.FocusedNode.ParentNode["Id"]),
                        Date_ini = DateTime.Now,
                        Date_end = DateTime.Now.AddMonths(12),
                        Rank_valid_inmonth = 12,
                        Prev_authorized = false
                    };

                lstDocumentation_user_file.Add(oDocUserFile);

                // --- save 
                CDocumentationFactory faDocumentation = new CDocumentationFactory();
                CDocumentation oDocumentation = new CDocumentation();
                oDocumentation.Iddocumentation = oDocUserFile.Iddocumentation;
                oDocumentation.Idconfiguration_folder = oDocUserFile.Idconfiguration_folder;
                oDocumentation.Idtemplate_method = oDocUserFile.Idtemplate_method;
                oDocumentation.Image_index = oDocUserFile.Image_index;
                oDocumentation.Name_doc = oDocUserFile.Name_doc;
                oDocumentation.Procedure_type = oDocUserFile.Procedure_type;
                oDocumentation.Type_doc = oDocUserFile.Type_doc;
                oDocumentation.Flag_enabled = true;                
                oDocumentation.Id = oDocUserFile.Id;
                oDocumentation.Parentid = oDocUserFile.Parentid;
                oDocumentation.Usernew = Comun.GetUser();
                oDocumentation.Useredit = Comun.GetUser();
                oDocumentation.Datenew = DateTime.Now;
                oDocumentation.Dateedit = DateTime.Now;
                oDocumentation.Status = true;
                treeAuthorization.DataSource = lstDocumentation_user_file;

                //faDocumentation.Insert(oDocumentation);

            }            
        }

        int GetNewIdNode()
        {
            // --- this method return a new node
            int result;
            if (lstDocumentation_user_file.Count() == 0)
                result = 0;
            else
                result = lstDocumentation_user_file.Max(c => c.Id);

            return result + 1;
        }

        void CopyAndSaveFile(string source_file_name)
        {
            try
            {
                System.IO.FileInfo fInfo = new System.IO.FileInfo(source_file_name);
                string name_file = String.Format("{0}{1}", oAuthorization.Get_next_file_name(
                    Convert.ToInt16(cbUser.EditValue),
                    Convert.ToChar(treeAuthorization.FocusedNode["Type_doc"])), fInfo.Extension);

                string destiny_file = System.IO.Path.Combine(destiny_path, name_file);

                if (!System.IO.Directory.Exists(destiny_path))
                    System.IO.Directory.CreateDirectory(destiny_path);

                // To copy a file to another location and
                // overwrite the destination file if it already exists.
                System.IO.File.Copy(source_file_name, destiny_file, true);

                Modify_file_name(name_file);
            }
            catch (Exception ex){
                Comun.Send_message(this.Text, TypeMsg.error, ex.Message);
            }
        }

        void Modify_file_name(string name)
        {
            // --- assign a name
            treeAuthorization.FocusedNode.SetValue("Name_file", name);

            // --- check how document attach
            treeAuthorization.FocusedNode.SetValue("Allowed", true);
        }

        

        #endregion 

        #region events

        private void FormDocument_Load(object sender, EventArgs e)
        {
            Load_process();
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
            destiny_path = cbDocument.GetColumnValue("Path").ToString();
            ShowDocumentation();
        }

        private void cbProcedure_EditValueChanged(object sender, EventArgs e)
        {
            ShowDocumentation();
        }

        private void cbDocument_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                FormConfigPath ofmConfigPath = new FormConfigPath();
                if (ofmConfigPath.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // --- refresh
                    Load_authorization();
                }
            }
        }

        private void ckAssignUser_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAssignUser.Checked)
            {
                btAddParent.Enabled = false;
                btAttach.Enabled = false;
                cbUser.Enabled = true;
            }
            else
            {
                btAddParent.Enabled = true;
                btAttach.Enabled = true;
                cbUser.Enabled = false;
            }
        }

        private void repGetCopyFileName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (cbDocument.EditValue != null && cbProcedure.EditValue != null && cbUser.EditValue != null)
                {
                    if (e.Button.Index == 0)
                    {
                        if (ofdDocument.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            CopyAndSaveFile(ofdDocument.FileName);
                        }
                    }
                    else if (e.Button.Index == 1)
                    {
                        // --- open document
                        string path_filename = System.IO.Path.Combine(destiny_path, treeAuthorization.FocusedNode.GetValue("Name_file").ToString());
                        Process.Start(path_filename);
                    }
                }
                else
                {
                    MessageBox.Show("No se seleccionó un tipo de documento.");
                }
            }
            catch (Exception ex)
            {
                Comun.Send_message(this.Text, TypeMsg.error, ex.Message);
            }
        }

        private void cbUser_EditValueChanged(object sender, EventArgs e)
        {
            ShowDocumentation();
        }

        private void treeAuthorization_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            if (e.Column == gcDoc_Rank_valid_inmonth
                || e.Column == gcDoc_Prev_authorized)
            {
                DateTime fend = Convert.ToDateTime(e.Node.GetValue("Date_ini")).AddMonths(Convert.ToInt32(e.Node.GetValue("Rank_valid_inmonth")));
                e.Node.SetValue("Date_end", fend);                

                // --- save 
                CDocumentationFactory faDocumentation = new CDocumentationFactory();
                CDocumentation oDocumentation = 
                    faDocumentation
                    .GetByPrimaryKey(new CDocumentationKeys(Convert.ToInt16(e.Node.GetValue("Iddocumentation"))));

                if (oDocumentation == null)
                {
                    oDocumentation = new CDocumentation();
                    oDocumentation.Iddocumentation = 0;
                }
                
                oDocumentation.Idconfiguration_folder = Convert.ToInt16(e.Node.GetValue("Idconfiguration_folder"));

                if (e.Node.GetValue("Idtemplate_method") != null)
                    oDocumentation.Idtemplate_method = Convert.ToInt32(e.Node.GetValue("Idtemplate_method"));

                oDocumentation.Image_index = Convert.ToInt32(e.Node.GetValue("Image_index"));
                oDocumentation.Name_doc = e.Node.GetValue("Name_doc").ToString();
                oDocumentation.Procedure_type = Convert.ToChar(e.Node.GetValue("Procedure_type"));
                oDocumentation.Type_doc = Convert.ToChar(e.Node.GetValue("Type_doc"));
                oDocumentation.Flag_enabled = true;
                oDocumentation.Id = Convert.ToInt32(e.Node.GetValue("Id"));
                oDocumentation.Parentid = Convert.ToInt32(e.Node.GetValue("Parentid"));
                oDocumentation.Usernew = Comun.GetUser();
                oDocumentation.Useredit = Comun.GetUser();
                oDocumentation.Datenew = DateTime.Now;
                oDocumentation.Dateedit = DateTime.Now;
                oDocumentation.Status = true;
                treeAuthorization.DataSource = lstDocumentation_user_file;

                bool result = false;

                if (!(result = faDocumentation.Update(oDocumentation)))
                    result = faDocumentation.Insert(oDocumentation);

                // --- Guardar acceso el usuario
                if (result)
                {                    
                    CDocumentation_userFactory faDocumentation_user = new CDocumentation_userFactory();
                    CDocumentation_user oDocumentation_user = new CDocumentation_user();
                    List<CDocumentation_user> lst = faDocumentation_user.GetAll();

                    if (lst.Exists(c => c.Iddocumentation == oDocumentation.Iddocumentation
                        && c.Iduser == Convert.ToInt16(cbUser.EditValue)))
                    {
                        oDocumentation_user =
                            faDocumentation_user
                            .GetAll()
                            .Single(c => c.Iddocumentation == oDocumentation.Iddocumentation
                                && c.Iduser == Convert.ToInt16(cbUser.EditValue));
                    }
                    else
                    {
                        oDocumentation_user = new CDocumentation_user();
                        oDocumentation_user.Iddocumentation_user = 0;
                    }

                    oDocumentation_user.Iddocumentation = oDocumentation.Iddocumentation;
                    oDocumentation_user.Date_ini = Convert.ToDateTime(e.Node.GetValue("Date_ini"));
                    oDocumentation_user.Date_end = Convert.ToDateTime(e.Node.GetValue("Date_end"));
                    oDocumentation_user.Rank_valid_inmonth = Convert.ToInt32(e.Node.GetValue("Rank_valid_inmonth"));
                    oDocumentation_user.Prev_authorized = Convert.ToBoolean(e.Node.GetValue("Prev_authorized"));
                    oDocumentation_user.Iduser = Convert.ToInt16(cbUser.EditValue);

                    if (!faDocumentation_user.Update(oDocumentation_user))
                        faDocumentation_user.Insert(oDocumentation_user);                    
                }
            }
        }

        #endregion         
    }
}
