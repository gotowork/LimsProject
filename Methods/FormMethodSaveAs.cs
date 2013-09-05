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
    public partial class FormMethodSaveAs : LibraryBasicForm.FormConfirm
    {
        public string Cod_method
        {
            get
            {
                return tbCod_method.Text;
            }
        }

        public string Title
        {
            get
            {
                return tbTitle.Text;
            }
        }        

        public List<CTemplate_method> ListTemplate { get; set; }       

        public FormMethodSaveAs()
        {
            InitializeComponent();
        }        

        private void FormMethodSaveAs_Load(object sender, EventArgs e)
        {            
            gcMethods.DataSource = ListTemplate;
        }

        public bool Son_Datos_Correctos()
        {
            if (tbCod_method.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error al ingresar el código del método.");
                DialogResult = System.Windows.Forms.DialogResult.None;
                tbCod_method.Focus();
                return false;
            }
            if (tbTitle.Text.Trim().Length == 0)
            {
                MessageBox.Show("Error al ingresar el título del método.");
                DialogResult = System.Windows.Forms.DialogResult.None;
                tbCod_method.Focus();
                return false;
            }
            return true;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Son_Datos_Correctos();
        }

        private void tbCod_method_Validating(object sender, CancelEventArgs e)
        {
            try
            {                
                List<CTemplate_method> lstTemplateMethod = new Methods().GetAllLastVersionMethods();
                if (lstTemplateMethod.Exists(c => c.Cod_template_method == tbCod_method.Text.Trim()))
                    e.Cancel = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbCod_method_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            try
            {
                List<CTemplate_method> lstTemplateMethod = new Methods().GetAllLastVersionMethods();
                CTemplate_method oTemplate_method = lstTemplateMethod.Single(c => c.Cod_template_method == tbCod_method.Text);
                if (oTemplate_method == null)
                    e.ErrorText = "el código de método ya se encuentra asignado";
                else
                    e.ErrorText = "el código de método ya se encuentra asignado al método " + oTemplate_method.Abbreviation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
