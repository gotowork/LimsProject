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
    public partial class FormSelMethods : LibraryBasicForm.FormBaseEmpty
    {        
        public FormSelMethods()
        {
            InitializeComponent();
        }                

        private void repSel_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int idtemplate_method = Convert.ToInt32(gvMethods.GetFocusedRowCellValue(gmet_Idtemplate_method));

            //if (idtemplate_method == group_solution.Idtemplate_method)
            //    e.Cancel = true;
        }
    }

    public class CMethodMini
    {
        public int Idtemplate_method { get; set; }
        public string Cod_template_method { get; set; }
        public string Title { get; set; }
        public bool Sel { get; set; }
        public bool Std_flag_sol_intermedia1 { get; set; }
        public bool Std_flag_sol_intermedia2 { get; set; }
    }
}
