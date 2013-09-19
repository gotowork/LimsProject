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
    public partial class FormCorrelatives : LibraryBasicForm.FormMantBase
    {
        #region constructor

        public FormCorrelatives()
        {
            InitializeComponent();
        }

        #endregion

        #region events

        private void FormCorrelativos_Load(object sender, EventArgs e)
        {
            InitCombos();
            Recuperar_Registro();
        }

        private void btNewCorrelative_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvCorrelativos.RowCount; i++)
            {
                gvCorrelativos.SetRowCellValue(i, gcCorr_prefix, cbYear.Text);
            }
        }

        #endregion

        #region inherit methods

        protected override bool Grabar_Registro()
        {
            CCorrelativeFactory faCorrelative = new CCorrelativeFactory();
            CCorrelative oCorrelative = new CCorrelative();

            CCorr_modulesFactory faCorr_module = new CCorr_modulesFactory();
            CCorr_modules oCorr_module = new CCorr_modules();

            bool result = false;

            try
            {
                for (int i = 0; i < gvCorrelativos.RowCount; i++)
                {
                    //oCorrelative = new CCorrelative();
                    //oCorrelative.Cod_type_sample = gvCorrelativos.GetRowCellValue(i, gcCorr_cod_type_sample).ToString();
                    //oCorrelative.Cod_serie = gvCorrelativos.GetRowCellValue(i, gcCorr_cod_serie).ToString();
                    //oCorrelative.Correlative = Convert.ToInt32(gvCorrelativos.GetRowCellValue(i, gcCorr_correlative));
                    //oCorrelative.Mreach15 = Convert.ToBoolean(gvCorrelativos.GetRowCellValue(i, gcCorr_mreach15));
                    //oCorrelative.Num_digits = Convert.ToInt16(gvCorrelativos.GetRowCellValue(i, gcCorr_num_digits));
                    //oCorrelative.Prefix = gvCorrelativos.GetRowCellValue(i, gcCorr_prefix).ToString();

                    //if (!(result = faCorrelative.Update(oCorrelative)))
                    //    result = faCorrelative.Insert(oCorrelative);

                    //if (!result)
                    //    break;

                    oCorrelative = (CCorrelative)gvCorrelativos.GetRow(i);
                    if (!new CCorrelativeFactory().Update(oCorrelative))
                        new CCorrelativeFactory().Insert(oCorrelative);
                }

                for (int i = 0; i < gvVarios.RowCount; i++)
                {
                    oCorr_module = (CCorr_modules)gvVarios.GetRow(i);
                    new CCorr_modulesFactory().Update(oCorr_module);                    
                }
            }
            catch (Exception ex)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, ex.Message);
                result = false;
            }

            return result;
        }

        protected override void Recuperar_Registro()
        {
            BindingList<CCorrelative> lstCorrelative = new BindingList<CCorrelative>(new CCorrelativeFactory().GetAll());
            gcCorrelativos.DataSource = lstCorrelative;

            if (lstCorrelative.Count == 0)
            {
                BindingList<CCorrelative> query = new BindingList<CCorrelative>(
                    (from t1 in new CType_sampleFactory().GetAll()
                     select new CCorrelative
                     {
                         Cod_type_sample = t1.Cod_type_sample,
                         Correlative = 0,
                         Num_digits = 5,
                         Prefix = t1.Cod_type_sample
                     }).ToList<CCorrelative>());
                gcCorrelativos.DataSource = query;
            }

            gcVarios.DataSource = new BindingList<CCorr_modules>(new CCorr_modulesFactory().GetAll());
            
        }

        protected override void Limpiar_Campos()
        {
            // --- does not apply
            base.Limpiar_Campos();
        }

        protected override bool Son_Datos_Correctos()
        {
            if (!EsColumnPrefixRigth())
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error la columna prefijo no puede ser vacia");
                return false;
            }
            return true;
        }

        #endregion

        #region methods

        void InitCombos()
        {
            cbYear.Properties.DataSource = new CSerieFactory().GetAll().Where(c=> c.Status_serie == true).ToList();
            cbYear.Properties.DisplayMember = "Nom_serie";
            cbYear.Properties.ValueMember = "Cod_serie";

            repTypeSample.DataSource = new CType_sampleFactory().GetAll();
            repTypeSample.ValueMember = "Cod_type_sample";
            repTypeSample.DisplayMember = "Name_type_sample";
        }

        bool EsColumnPrefixRigth()
        {
            for (int i = 0; i < gvCorrelativos.RowCount; i++)
            {
                object obj = gvCorrelativos.GetRowCellValue(i, gcCorr_prefix);
                if (gvCorrelativos.GetRowCellValue(i, gcCorr_prefix) == null)
                    return false;
            }
            return true;
        }

        #endregion

        private void cbYear_EditValueChanged(object sender, EventArgs e)
        {
            if (cbYear.EditValue != null && cbYear.Text.Trim().Length != 0)
            {
                Recuperar_Registro();

                for (int i = 0; i < gvCorrelativos.RowCount; i++)
                    gvCorrelativos.SetRowCellValue(i, gcCorr_cod_serie, cbYear.GetColumnValue("Cod_serie"));

                for (int i = 0; i < gvVarios.RowCount; i++)
                    gvVarios.SetRowCellValue(i, gcVar_Cod_serie, cbYear.GetColumnValue("Cod_serie"));
            }
        }

        private void cbYear_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                FormSerie fmSerie = new FormSerie();
                fmSerie.ShowDialog();
                cbYear.Properties.DataSource = new BindingList<CSerie>(new CSerieFactory().GetAll().Where(c => c.Status_serie == true).ToList());
                cbYear.Properties.ValueMember = "Cod_serie";
                cbYear.Properties.DisplayMember = "Nom_serie";
                cbYear.ItemIndex = 0;
            }
        }
    }
}
