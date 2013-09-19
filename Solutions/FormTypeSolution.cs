using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LimsProject.BusinessLayer;

namespace LimsProject
{
    public partial class FormTypeSolution : LibraryBasicForm.FormMantBase
    {
        public FormTypeSolution()
        {
            InitializeComponent();
        }

        #region inherit methods

        protected override bool Grabar_Registro()
        {
            CType_solutionFactory faType_solution = new CType_solutionFactory();

            try
            {
                // --- remove all
                List<CType_solution> lstType_solution = new List<CType_solution>(new CType_solutionFactory().GetAll());

                for (int i = 0; i < lstType_solution.Count; i++)
                {
                    CType_solution current_row = lstType_solution[i];

                    if (current_row.Idtype_solution > 0)
                    {                        
                        current_row.Status = false;
                        faType_solution.Update(current_row);
                    }
                }

                // --- save all
                for (int i = 0; i < gvTypeSolution.RowCount; i++)
                {
                    CType_solution current_row = gvTypeSolution.GetRow(i) as CType_solution;

                    if (current_row.Idtype_solution == 0)
                    {
                        current_row.Usernew = Comun.GetUser();
                        current_row.Datenew = Comun.GetDate();
                        current_row.Status = true;
                    }
                    else
                    {                        
                        current_row.Useredit = Comun.GetUser();
                        current_row.Dateedit = Comun.GetDate();
                        current_row.Status = true;
                    }
                    

                    if (!faType_solution.Update(current_row))
                        faType_solution.Insert(current_row);

                }
                return true;
            }
            catch (Exception ex)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, ex.Message);
                return false;
            }            
        }

        protected override void Recuperar_Registro()
        {
            gcTypeSolution.DataSource = 
                new BindingList<CType_solution>(new CType_solutionFactory()
                    .GetAll()
                    .Where(c=> c.Status == true).ToList());
        }

        protected override bool Son_Datos_Correctos()
        {
            return base.Son_Datos_Correctos();
        }

        #endregion

        #region events

        private void FormTypeSolution_Load(object sender, EventArgs e)
        {
            Recuperar_Registro();
        }

        #endregion 
    }
}
