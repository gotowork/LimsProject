using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using LimsProject.BusinessLayer;
using LimsProject.BusinessLayer.Modules;

namespace LimsProject
{
    public partial class FormPrepSamples : LibraryBasicForm.FormBaseEmpty
    {
        public enum TipoProceso
        {            
            RecepSample = 1,
            Humedad = 2,
            SalidaMuestreria = 3,            
            PesarRechazos = 4,
            Almacen = 5
        }

        public FormPrepSamples()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            #region prep samples
            /*
             * Modulo de almacen de muestras
             * 1. registrar modalidad de almacenamiento tiempo y costos
             * 
             * 
             * 1. recepción de muestras
             * ------------------------
             * aumentar campo: sobre sellado
             * 
             * 2. métodos
             * -----------------------
             * - implementar método de análisis de humedad
             * 
             * 3. Muestrería
             * ---------------------             
             * - registrar peso bruto de la muestra
             * 
             * 4. Preparación de muestras
             * - se registra el tiempo de entrada
             * - se pesa las muestras
             * - se pesa las contramuestras
             * - se pesa los rechazos
             * - se registra el tiempo de salida
             * 
             * 5. Qaqc de análisis de humedad: 
             * - Se realiza el peso humedo, peso seco y se determina 
             *   el análisis de humedad según la especificación del método
             * - Rechazo del análisis de humedad (datos?)
             * 
             * 6. Almacen de muestras
             * - registrar fecha de entrada de muestras, contramuestras y rechazos
             * - registrar fechas de salida de muestras, contramuestras y rechazos (devolucion)
             * 
            */
            #endregion

            rgPreparationSamples.SelectedIndex = 0;
            deDateIni.DateTime = DateTime.Now.AddDays(-1);
            deDateEnd.DateTime = DateTime.Now;

            switch (Convert.ToInt32(rgPreparationSamples.EditValue))
            {
                case 1:
                    ShowColumns(TipoProceso.RecepSample);
                    break;
                case 2:
                    ShowColumns(TipoProceso.Humedad);
                    break;
                case 3:
                    ShowColumns(TipoProceso.SalidaMuestreria);
                    break;
                case 4:
                    ShowColumns(TipoProceso.PesarRechazos);
                    break;
                case 5:
                    ShowColumns(TipoProceso.Almacen);
                    break;
            }

            repCode.DataSource = new CRecep_sample_detailFactory().GetAll();
            repCode.ValueMember = "Idrecep_sample_detail";
            repCode.DisplayMember = "Cod_sample";

            RetrieveData();
        }

        void RetrieveData()
        {
            gcPrepSample.DataSource = new BindingList<CPrep_samples>(new CPrep_samplesFactory().GetAll().Where(x => x.Date_creation > deDateIni.DateTime && x.Date_creation < deDateEnd.DateTime).ToList());
            gvPrepSample.BestFitColumns();
        }

        void ShowColumns(TipoProceso tipoProceso)
        {
            // ocultar bandas
            for (int i = 0; i < gvPrepSample.Bands.Count; i++)
                if (gvPrepSample.Bands[i] != gbMuestra)
                    gvPrepSample.Bands[i].Visible = false;

            // ocultar todas las columnas
            for (int i = 0; i < gvPrepSample.Columns.Count; i++)            
                gvPrepSample.Columns[i].Visible = false;

            // asignar visibilidad
            gcol_Cod_sample.Visible = false;
            gcol_Idrecep_sample_detail.Visible = true;
            gcol_Weight_gross.Visible = true;
            gcol_Weight_gross_date.Visible = true;
            gcol_Weight_gross_user.Visible = true;

            switch(tipoProceso)
            {
                case TipoProceso.RecepSample:

                    gcol_Flag_humidity_analysis.OwnerBand.Visible = true;

                    gcol_Flag_humidity_analysis.Visible = true;
                    gcol_Flag_60celsius.Visible = true;
                    gcol_Flag_reject.Visible = true;
                    gcol_Flag_counter_sample.Visible = true;

                    gcol_Input_sample_date.Visible = true;
                    gcol_Input_sample_user.Visible = true;                    
                    

                    break;
                case TipoProceso.PesarRechazos:
                    // peso de rechazo para almacenamiento
                    gcol_Weight_gross.Visible = false;
                    gcol_Weight_gross_date.Visible = false;
                    gcol_Weight_gross_user.Visible = false;

                    gcol_Weight_gross_reject.OwnerBand.Visible = true;
                    gcol_Weight_gross_reject.Visible = true;
                    gcol_Weight_gross_reject_date.Visible = true;
                    gcol_Weight_gross_reject_user.Visible = true;
                    break;
                case TipoProceso.Humedad:
                    gcol_Weight_gross.Visible = false;
                    gcol_Weight_gross_date.Visible = false;
                    gcol_Weight_gross_user.Visible = false;

                    // determinación de humedad
                    gcol_Weight_moisture.OwnerBand.Visible = true;
                    gcol_Weight_moisture.Visible = true;
                    gcol_Weight_moisture_date.Visible = true;
                    gcol_Weight_moisture_user.Visible = true;

                    gcol_Weight_dry.Visible = true;
                    gcol_Weight_dry_date.Visible = true;
                    gcol_Weight_dry_user.Visible = true;

                    gcol_Percent_moisture.Visible = true;

                    gcol_Moisture_reject.Visible = true;
                    gcol_Moisture_reject_date.Visible = true;
                    gcol_Moisture_reject_user.Visible = true;
                    break;
                case TipoProceso.SalidaMuestreria:
                    gcol_Weight_gross.Visible = false;
                    gcol_Weight_gross_date.Visible = false;
                    gcol_Weight_gross_user.Visible = false;

                    // marcar salida de muestra, contramuestra y rechazo
                    gcol_Output_date_sample.OwnerBand.Visible = true;
                    gcol_Output_date_sample.Visible = true; // a ataque
                    gcol_Output_user_sample.Visible = true; // a ataque
                    gcol_Output_date_cs.Visible = true;     // contramuestra
                    gcol_Output_user_cs.Visible = true;     // contramuestra
                    gcol_Output_date_re.Visible = true;     // rechazo
                    gcol_Output_user_re.Visible = true;     // rechazo
                    break;
                case TipoProceso.Almacen:
                    gcol_Weight_gross.Visible = false;
                    gcol_Weight_gross_date.Visible = false;
                    gcol_Weight_gross_user.Visible = false;

                    // entrada y salida almacen
                    gcol_Store_input_date_cs.OwnerBand.Visible = true;
                    gcol_Store_input_date_cs.Visible = true;
                    gcol_Store_input_user_cs.Visible = true;

                    gcol_Store_input_date_re.Visible = true;
                    gcol_Store_input_user_re.Visible = true;

                    gcol_Store_output_date_cs.Visible = true;
                    gcol_Store_output_user_cs.Visible = true;

                    gcol_Store_output_date_re.Visible = true;
                    gcol_Store_output_user_re.Visible = true;
                    break;                        
            }
        }

        public void SimulRecepCodigoBarra()
        {
            List<string> lstCodBarraRead = new List<string>();
            lstCodBarraRead.Add("1300001\n");
            lstCodBarraRead.Add("1300002\n");
            //lstCodBarraRead.Add("1300003\n");
            //lstCodBarraRead.Add("1300004\n");
            //lstCodBarraRead.Add("1300005\n");
            //lstCodBarraRead.Add("1300006\n");
            //lstCodBarraRead.Add("1300007\n");
            //lstCodBarraRead.Add("1300008\n");
            //lstCodBarraRead.Add("1300009\n");
            //lstCodBarraRead.Add("1300010\n");
            //lstCodBarraRead.Add("1300011\n");
            //lstCodBarraRead.Add("1300012\n");
            //lstCodBarraRead.Add("1300013\n");
            //lstCodBarraRead.Add("1300014\n");
            //lstCodBarraRead.Add("1300015\n");
            //lstCodBarraRead.Add("1300016\n");

            foreach (var item in lstCodBarraRead)
            {
                if (RecepBarCode(item))
                {
                    //actualizar grid
                    
                }
                //Thread.Sleep(5000);
            }
        }

        bool RecepBarCode(string barcode)
        {
            //if (barcode.Contains('\n'))
            {
                //buscar en el grid y seleccionar
                //modificar grid
                //for (int i = 0; i < gvPrepSample.RowCount; i++)
                //{
                //    string item = gvPrepSample.GetRowCellDisplayText(i, "Cod_sample");
                //    if (gvPrepSample.GetRowCellDisplayText(i, "Cod_sample") == barcode.Replace('\n', ' ').Trim())
                //    {                        
                //        gvPrepSample.FocusedRowHandle = i;                        
                //        gvPrepSample.SetFocusedRowCellValue(gvPrepSample.Columns["Sel"], true);
                //        gvPrepSample.SetFocusedRowCellValue(gvPrepSample.Columns["Date_input"], DateTime.Now);                        
                //        //gvPrepSample.UpdateCurrentRow();
                //        return true;
                //    }
                //}                
            }
            return false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SimulRecepCodigoBarra();
        }

        private void rgPreparationSamples_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetrieveData();

            switch (Convert.ToInt32(rgPreparationSamples.EditValue))
            {
                case 1:
                    ShowColumns(TipoProceso.RecepSample);
                    break;
                case 2:
                    ShowColumns(TipoProceso.Humedad);
                    break;
                case 3:
                    ShowColumns(TipoProceso.SalidaMuestreria);
                    break;
                case 4:
                    ShowColumns(TipoProceso.PesarRechazos);
                    break;
                case 5:
                    ShowColumns(TipoProceso.Almacen);
                    break;
            }
        }

        private void gvPrepSample_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == gcol_Weight_gross)
            {
                // actualizar fecha entrada y usuario                                                                
                CPrep_samples oPrep_sample = gvPrepSample.GetRow(e.RowHandle) as CPrep_samples;
                oPrep_sample.Weight_gross_date = Comun.GetDate();
                oPrep_sample.Weight_gross_user = Comun.GetUser();                
                new CPrep_samplesFactory().Update(oPrep_sample);

                //gvPrepSample.UpdateCurrentRow();
            }
            else if (e.Column == gcol_Weight_moisture)
            {
                // actualizar fecha de peso húmedo y usuario
                CPrep_samples oPrep_sample = gvPrepSample.GetRow(e.RowHandle) as CPrep_samples;
                if (oPrep_sample.Weight_moisture != null && oPrep_sample.Weight_dry != null
                    && oPrep_sample.Weight_dry > 0 && oPrep_sample.Weight_moisture > 0)
                    oPrep_sample.Percent_moisture = (oPrep_sample.Weight_moisture - oPrep_sample.Weight_dry) / oPrep_sample.Weight_moisture;

                oPrep_sample.Weight_moisture_date = Comun.GetDate();
                oPrep_sample.Weight_moisture_user = Comun.GetUser();
                new CPrep_samplesFactory().Update(oPrep_sample);
            }
            else if (e.Column == gcol_Weight_dry)
            {
                // actualizar fecha de peso seco y usuario y calcular la humedad
                CPrep_samples oPrep_sample = gvPrepSample.GetRow(e.RowHandle) as CPrep_samples;

                if (oPrep_sample.Weight_moisture != null && oPrep_sample.Weight_dry != null
                    && oPrep_sample.Weight_dry > 0 && oPrep_sample.Weight_moisture > 0)
                {
                    oPrep_sample.Percent_moisture = (oPrep_sample.Weight_moisture - oPrep_sample.Weight_dry) / oPrep_sample.Weight_moisture;
                    oPrep_sample.Weight_dry_date = Comun.GetDate();
                    oPrep_sample.Weight_dry_user = Comun.GetUser();
                    new CPrep_samplesFactory().Update(oPrep_sample);
                }
            }
        }

        
    }    
}
