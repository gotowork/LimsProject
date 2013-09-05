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

            // Estandares de calibración.
            if (group_solution.Type_solution == 1)
            {
                // --- elemento, mr pattern, medio y modif
                // getLstMethods(group_solution)
                lstMethod = modSolution.GetMethodsByMrcPattern(group_solution).ToList();
            }
            // Soluciones intermedias 1 y 2 y estandares de verificación.
            else if (group_solution.Type_solution == 2
                || group_solution.Type_solution == 3
                || group_solution.Type_solution == 4)
            {
                // elemento, mr pattern, sol intermedia (1 ó 2 implicito)
                // getLstMethods(group_solution, type_solution_intermedia)
                lstMethod = modSolution.GetMethodsBySolInterm(group_solution, currentTypeSol).ToList();
            }

            // Crear nueva lista de métodos
            lstMethodMini = new BindingList<CMethodMini>(
                (from m in lstMethod
                 select new CMethodMini
                 {
                     Sel = m.Idtemplate_method == group_solution.Idtemplate_method ? true : false,
                     Idtemplate_method = m.Idtemplate_method,
                     Cod_template_method = m.Cod_template_method,
                     Title = m.Title,                     
                 }).ToList());

            gcMethods.DataSource = lstMethodMini;            

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
