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
        BindingList<CMethodMini> lstMethodMini = new BindingList<CMethodMini>();
        CGroup_solution group_solution = null;

        public BindingList<CMethodMini> LstMethodMini
        {
            get {
                return lstMethodMini;
            }
        }

        public FormSelMethods()
        {
            InitializeComponent();
        }

        public FormSelMethods(CGroup_solution p_group_solution, int currentTypeSol)
        {
            InitializeComponent();

            group_solution = p_group_solution;            

            Init(group_solution, currentTypeSol);
        }

        void Init(CGroup_solution group_solution, int currentTypeSol)
        {
            ModSolution modSolution = new ModSolution();
            List<CCustom_method_solution> lstMethod = new List<CCustom_method_solution>();
        }

        private void repSel_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int idtemplate_method = Convert.ToInt32(gvMethods.GetFocusedRowCellValue(gmet_Idtemplate_method));

            if (idtemplate_method == group_solution.Idtemplate_method)
                e.Cancel = true;
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
