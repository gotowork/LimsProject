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
    public partial class FormUnitMeasure : LibraryBasicForm.FormMantBase
    {
        short idUnit = -1;

        public short IDUnit
        {
            get {
                return idUnit;
            }
            set {
                idUnit = value;
            }
        }

        public FormUnitMeasure()
        {
            InitializeComponent();
        }

        #region inherit methods

        protected override void Recuperar_Registro()
        {
            CMeasurement_unit oMeasurement_unit = new CMeasurement_unit();
            CMeasurement_unitFactory faMeasurement_unit = new CMeasurement_unitFactory();

            oMeasurement_unit = faMeasurement_unit.GetByPrimaryKey(new CMeasurement_unitKeys(IDUnit));

            if (oMeasurement_unit != null)
            {
                tbNameUnit.Text = oMeasurement_unit.Name_unit;
                tbDescription.Text = oMeasurement_unit.Description;
                cbConcentration_unit.EditValue = oMeasurement_unit.Concentration_unit;
            }
        }

        protected override bool Grabar_Registro()
        {
            bool result = false;

            CMeasurement_unit oMeasurement_unit = new CMeasurement_unit();
            CMeasurement_unitFactory faMeasurement_unit = new CMeasurement_unitFactory();
            oMeasurement_unit.Idunit = IDUnit;
            oMeasurement_unit.Name_unit = tbNameUnit.Text;
            oMeasurement_unit.Description = tbDescription.Text;
            oMeasurement_unit.Concentration_unit = Convert.ToInt32(cbConcentration_unit.EditValue);

            if (!(result = faMeasurement_unit.Update(oMeasurement_unit)))
            {
                result = faMeasurement_unit.Insert(oMeasurement_unit);
            }
            return result;
        }

        protected override void Limpiar_Campos()
        {
            tbNameUnit.Text = "";
            tbDescription.Text = "";
            cbConcentration_unit.EditValue = null;
        }

        protected override bool Son_Datos_Correctos()
        {
 	        if (tbNameUnit.Text.Trim() == "")
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: no se admite el campo nombre vacio.");
                return false;
            }
            if (tbDescription.Text.Trim() == "")
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: no se admite el campo descripción en vacio.");
                return false;
            }
            if (cbConcentration_unit.EditValue == null)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: no se admite la unidad de concentración vacía.");
                return false;
            }
            return true;
        }        

        #endregion

        #region events

        private void FormUnitMeasure_Load(object sender, EventArgs e)
        {
            LoadDataMasterSearh(new CMeasurement_unitFactory().GetAllDataTable());
        }

        #endregion 

    }
}
