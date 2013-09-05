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
    public partial class FormTypeSample : LibraryBasicForm.FormMantBase
    {
        string Cod_Type_Sample { get; set; }

        public FormTypeSample()
        {
            InitializeComponent();
        }

        #region methods inherit

        protected override void Recuperar_Registro()
        {
            CType_sampleFactory faType_sample = new CType_sampleFactory();
            CType_sample oType_sample = faType_sample.GetByPrimaryKey(new CType_sampleKeys(Cod_Type_Sample));
            if (oType_sample != null)
            {
                tbCode.Text = oType_sample.Cod_type_sample;
                tbName.Text = oType_sample.Name_type_sample;
                tbDescription.Text = oType_sample.Description;
                tbPrefix.Text = oType_sample.Prefix;
            }
        }

        protected override bool Grabar_Registro()
        {
            CType_sampleFactory faType_sample = new CType_sampleFactory();
            CType_sample oType_sample = new CType_sample();
            oType_sample.Cod_type_sample = tbCode.Text;
            oType_sample.Name_type_sample = tbName.Text;
            oType_sample.Description = tbDescription.Text;
            oType_sample.Prefix = tbPrefix.Text;

            bool result = false;

            if (!(result = faType_sample.Update(oType_sample)))
            {
                result = faType_sample.Insert(oType_sample);
            }
            return result;
        }

        protected override void Limpiar_Campos()
        {
            tbCode.Text = "";
            tbName.Text = "";
            tbDescription.Text = "";
            tbPrefix.Text = "";
        }

        protected override bool Son_Datos_Correctos()
        {
            if (tbCode.Text == "")
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: no se admite el código vacio.");
                return false;
            }
            if (tbName.Text == "")
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: no se admite el nombre vacio.");
                return false;
            }
            if (tbPrefix.Text == "")
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: no se admite el prefijo vacio.");
                return false;
            }
            return true;
        }

        #endregion

        private void FormTypeSample_Load(object sender, EventArgs e)
        {
            LoadDataMasterSearh(new CType_sampleFactory().GetAllDataTable());
        }

    }
}
