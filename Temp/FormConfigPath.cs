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
    public partial class FormConfigPath : LibraryBasicForm.FormBase
    {
        string root_path { get; set; }

        public FormConfigPath()
        {
            InitializeComponent();
        }

        private void FormConfigPath_Load(object sender, EventArgs e)
        {
            Load_directories();
        }

        public void Load_directories()
        {
            // --- 
            Authorization oAuthorization = new Authorization();
            root_path = oAuthorization.GetRootDirectory().Path;
            btRootDirectory.Text = root_path;

            // --- 
            gcDirectories.DataSource = oAuthorization.GetListConfiguration_folder();
        }

        private void btRootDirectory_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (fbdFindRoot.ShowDialog() == System.Windows.Forms.DialogResult.OK)            
                btRootDirectory.Text = fbdFindRoot.SelectedPath;            
        }
    }
}
