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
    public partial class FormDigestion : LibraryBasicForm.FormMantBase
    {        
        public FormDigestion()
        {
            InitializeComponent();
        }

        // --- attributes
        int Cod_digestion { get; set; }

        protected override bool Grabar_Registro()
        {
            CDigestion_methodFactory faDigestion_Method = new CDigestion_methodFactory();
            CDigestion_method oDigestion_Method = new CDigestion_method();
            oDigestion_Method.Cod_digestion_method = tbCodDigestion.Text;
            oDigestion_Method.Name_digestion_method = tbNameDigestion.Text;

            bool result = false;

            if (!(result = faDigestion_Method.Update(oDigestion_Method)))
                result = faDigestion_Method.Insert(oDigestion_Method);
            return result;
        }

        protected override void Recuperar_Registro()
        {
            CDigestion_methodFactory faDigestion_Method = new CDigestion_methodFactory();
            CDigestion_method oDigestion_Method = new CDigestion_method();
            oDigestion_Method = faDigestion_Method.GetByPrimaryKey(new CDigestion_methodKeys(""));
            if (oDigestion_Method != null)
            {
                tbCodDigestion.Text = oDigestion_Method.Cod_digestion_method;
                tbNameDigestion.Text = oDigestion_Method.Name_digestion_method;
            }
        }

        protected override bool Son_Datos_Correctos()
        {
            if (tbNameDigestion.Text.Trim() == "")
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Guardar: error no se admite el nombre de digestion vacio.");
                return false;
            }
            if (tbCodDigestion.Text.Trim() == "")
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Guardar: error no se admite el código de digestion vacio.");
                return false;
            }
            return true;
        }

        protected override void Limpiar_Campos()
        {
            tbCodDigestion.Text = "";
            tbNameDigestion.Text = "";
        }

        private void FormDigestion_Load(object sender, EventArgs e)
        {
            LoadDataMasterSearh(new CDigestion_methodFactory().GetAllDataTable());
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
