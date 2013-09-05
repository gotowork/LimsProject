using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LimsProject
{
    public partial class FormConfirmSaveMethod : LibraryBasicForm.FormConfirm
    {
        public Comun.Save_type SaveType { get; set; }

        bool Flag_saveas { get; set; }

        public FormConfirmSaveMethod()
        {
            InitializeComponent();
        }

        public FormConfirmSaveMethod(bool flag_saveas)
        {
            InitializeComponent();
            Flag_saveas = flag_saveas;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            SaveType = Comun.Save_type.Save;
            this.Close();
        }

        private void btSaveAs_Click(object sender, EventArgs e)
        {
            SaveType = Comun.Save_type.SaveAs;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            SaveType = Comun.Save_type.Cancel;
            this.Close();
        }

        private void FormConfirmSaveMethod_Load(object sender, EventArgs e)
        {
            if (Flag_saveas)
                btSaveAs.Visible = true;
            else
                btSaveAs.Visible = false;
        }


    }
}
