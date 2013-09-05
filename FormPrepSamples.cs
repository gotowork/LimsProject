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

namespace LimsProject
{
    public partial class FormPrepSamples : LibraryBasicForm.FormBaseEmpty
    {
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

            BindingList<CPrepSamples> lst = new BindingList<CPrepSamples>();

            lst.Add(new CPrepSamples() { Cod_sample = "1300001", Date_input = null, Date_output = null, Flag_60Celsius = true, Flag_counter_sample = 1, Flag_humidity_analysis = false, Flag_reject = true });
            lst.Add(new CPrepSamples() { Cod_sample = "1300002", Date_input = null, Date_output = null, Flag_60Celsius = true, Flag_counter_sample = 1, Flag_humidity_analysis = false, Flag_reject = true });
            lst.Add(new CPrepSamples() { Cod_sample = "1300003", Date_input = null, Date_output = null, Flag_60Celsius = false, Flag_counter_sample = 1, Flag_humidity_analysis = false, Flag_reject = true });
            lst.Add(new CPrepSamples() { Cod_sample = "1300004", Date_input = null, Date_output = null, Flag_60Celsius = false, Flag_counter_sample = 1, Flag_humidity_analysis = false, Flag_reject = true });
            lst.Add(new CPrepSamples() { Cod_sample = "1300005", Date_input = null, Date_output = null, Flag_60Celsius = false, Flag_counter_sample = 1, Flag_humidity_analysis = false, Flag_reject = true });
            lst.Add(new CPrepSamples() { Cod_sample = "1300006", Date_input = null, Date_output = null, Flag_60Celsius = false, Flag_counter_sample = 1, Flag_humidity_analysis = false, Flag_reject = true });
            lst.Add(new CPrepSamples() { Cod_sample = "1300007", Date_input = null, Date_output = null, Flag_60Celsius = true, Flag_counter_sample = 1, Flag_humidity_analysis = false, Flag_reject = true });
            lst.Add(new CPrepSamples() { Cod_sample = "1300008", Date_input = null, Date_output = null, Flag_60Celsius = true, Flag_counter_sample = 1, Flag_humidity_analysis = false, Flag_reject = true });
            lst.Add(new CPrepSamples() { Cod_sample = "1300009", Date_input = null, Date_output = null, Flag_60Celsius = true, Flag_counter_sample = 1, Flag_humidity_analysis = false, Flag_reject = true });
            lst.Add(new CPrepSamples() { Cod_sample = "1300010", Date_input = null, Date_output = null, Flag_60Celsius = false, Flag_counter_sample = 1, Flag_humidity_analysis = false, Flag_reject = true });
            lst.Add(new CPrepSamples() { Cod_sample = "1300011", Date_input = null, Date_output = null, Flag_60Celsius = false, Flag_counter_sample = 1, Flag_humidity_analysis = false, Flag_reject = true });
            lst.Add(new CPrepSamples() { Cod_sample = "1300012", Date_input = null, Date_output = null, Flag_60Celsius = false, Flag_counter_sample = 1, Flag_humidity_analysis = false, Flag_reject = true });
            lst.Add(new CPrepSamples() { Cod_sample = "1300013", Date_input = null, Date_output = null, Flag_60Celsius = false, Flag_counter_sample = 1, Flag_humidity_analysis = false, Flag_reject = true });
            lst.Add(new CPrepSamples() { Cod_sample = "1300014", Date_input = null, Date_output = null, Flag_60Celsius = false, Flag_counter_sample = 1, Flag_humidity_analysis = false, Flag_reject = true });
            lst.Add(new CPrepSamples() { Cod_sample = "1300015", Date_input = null, Date_output = null, Flag_60Celsius = false, Flag_counter_sample = 1, Flag_humidity_analysis = false, Flag_reject = true });
            lst.Add(new CPrepSamples() { Cod_sample = "1300016", Date_input = null, Date_output = null, Flag_60Celsius = false, Flag_counter_sample = 1, Flag_humidity_analysis = false, Flag_reject = true });

            gcPrepSample.DataSource = lst;
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
                for (int i = 0; i < gvPrepSample.RowCount; i++)
                {
                    string item = gvPrepSample.GetRowCellDisplayText(i, "Cod_sample");
                    if (gvPrepSample.GetRowCellDisplayText(i, "Cod_sample") == barcode.Replace('\n', ' ').Trim())
                    {                        
                        gvPrepSample.FocusedRowHandle = i;                        
                        gvPrepSample.SetFocusedRowCellValue(gvPrepSample.Columns["Sel"], true);
                        gvPrepSample.SetFocusedRowCellValue(gvPrepSample.Columns["Date_input"], DateTime.Now);                        
                        //gvPrepSample.UpdateCurrentRow();
                        return true;
                    }
                }                
            }
            return false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SimulRecepCodigoBarra();
        }
    }

    public class CPrepSamples
    {
        public bool Sel { get; set; }
        public string Cod_sample { get; set; }
        public bool Flag_60Celsius { get; set; }
        public bool Flag_humidity_analysis { get; set; }
        public bool Flag_reject { get; set; }
        public short? Flag_counter_sample { get; set; }
        public DateTime? Date_input { get; set; }
        public DateTime? Date_output { get; set; }
    }
}
