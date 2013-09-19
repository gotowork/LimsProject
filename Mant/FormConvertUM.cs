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
    public partial class FormConvertUM : LibraryBasicForm.FormMantBase
    {

        #region attributes

        

        #endregion

        public FormConvertUM()
        {
            InitializeComponent();
        }

        private void FormConvertUM_Load(object sender, EventArgs e)
        {            
            Recuperar_Registro();
            InitCombos();
        }

        #region methods

        void InitCombos()
        {
            // --- Init : measurement unit 1
            CMeasurement_unitFactory faMeasurement_unit = new CMeasurement_unitFactory();
            repUm1.DataSource = faMeasurement_unit.GetAll();
            repUm1.DisplayMember = "Name_unit";
            repUm1.ValueMember = "Idunit";

            // --- Init : measurement unit 2           
            repUm2.DataSource = faMeasurement_unit.GetAll();
            repUm2.DisplayMember = "Name_unit";
            repUm2.ValueMember = "Idunit";

        }

        #endregion

        #region inherit methods

        protected override void Limpiar_Campos()
        {
            //gcConvertionUM.DataSource = null;
        }

        protected override bool Grabar_Registro()
        {
            CConvert_unit_measurementFactory faConvert_unit_measurement = new CConvert_unit_measurementFactory();
            CConvert_unit_measurement oConvert_unit_measurement = new CConvert_unit_measurement();
            for(int i = 0; i < gvConvertionUM.RowCount; i++)
            {
                oConvert_unit_measurement.Idconvert = Convert.ToInt16(gvConvertionUM.GetRowCellValue(i, gcUmc_idconvert));
                oConvert_unit_measurement.Idunit1 = Convert.ToInt16(gvConvertionUM.GetRowCellValue(i, gcUmc_idunit1));
                oConvert_unit_measurement.Idunit2 = Convert.ToInt16(gvConvertionUM.GetRowCellValue(i, gcUmc_idunit2));
                oConvert_unit_measurement.Den_unit1 = gvConvertionUM.GetRowCellValue(i, gcUmc_den_unit1).ToString();
                oConvert_unit_measurement.Den_unit2 = gvConvertionUM.GetRowCellValue(i, gcUmc_den_unit2).ToString();
                oConvert_unit_measurement.Factor = Convert.ToDecimal( gvConvertionUM.GetRowCellValue(i, gcUmc_factor));

                if (!faConvert_unit_measurement.Update(oConvert_unit_measurement))
                    faConvert_unit_measurement.Insert(oConvert_unit_measurement);
            }
            return true;
        }

        protected override void Recuperar_Registro()
        {
            CConvert_unit_measurementFactory faConvert_unit_measure = new CConvert_unit_measurementFactory();
            gcConvertionUM.DataSource = new BindingList<CConvert_unit_measurement>(faConvert_unit_measure.GetAll());

        }

        protected override bool Son_Datos_Correctos()
        {            
            for (int i = 0; i < gvConvertionUM.RowCount; i++)
            {
                if (gvConvertionUM.GetRowCellValue(i, gcUmc_den_unit1) == null 
                    || gvConvertionUM.GetRowCellValue(i, gcUmc_den_unit2) == null
                    || gvConvertionUM.GetRowCellValue(i, gcUmc_factor) == null)
                {
                    string error = "Error: En la fila {0} se requiere llenar todos los campos.";
                    ComunForm.Send_message(this.Text, TypeMsg.error, string.Format(error, i.ToString()));
                    return false;
                }
            }
            return true;
        }

        #endregion

        private void repUm1_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit combo = (DevExpress.XtraEditors.LookUpEdit)sender;
            if (combo.EditValue != null)
                gvConvertionUM.SetFocusedRowCellValue(gcUmc_idunit1, combo.EditValue);
        }

        private void repUm2_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit combo = (DevExpress.XtraEditors.LookUpEdit)sender;
            if (combo.EditValue != null)
                gvConvertionUM.SetFocusedRowCellValue(gcUmc_idunit2, combo.EditValue);
        }

        private void gvConvertionUM_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvConvertionUM.SetFocusedRowCellValue(gcUmc_factor, 1);
        }

    }
}
