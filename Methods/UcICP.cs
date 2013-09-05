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
    public partial class UcICP : UserControl
    {
        #region attributes
        
        Dictionary<string, string> conditions = new Dictionary<string, string>();
        int? idtemplate_method = null;
        int? type_analisys = null;

        public int? Idtemplate_method
        {
            get
            {
                return idtemplate_method;
            }
            set
            {
                idtemplate_method = value;
            }
        }

        public int? Type_analisys
        {
            get
            {
                return type_analisys;
            }
            set
            {
                type_analisys = value;
            }
        }

        CTemplate_method_icp oTemplate_method_icp = new CTemplate_method_icp();

        Dictionary<string, CControl_sample> dicControl = new Dictionary<string, CControl_sample>();        

        #endregion 

        #region constructors

        public UcICP()
        {
            InitializeComponent();
            Init();
        }

        public UcICP(int pIdtemplate_method)
        {
            InitializeComponent();
            Idtemplate_method = pIdtemplate_method;
            Init();
        }

        #endregion

        #region inherited methods

        public bool Son_Datos_Correctos()
        {
            if (!ucSampleControl1.Son_Datos_Correctos())
            {
                return false;
            }
            if (!ucSampleFrequency1.Son_Datos_Correctos())
            {
                return false;
            }
            return true;
        }

        public void RetrieveTypeAnalysis()
        {            
            if (oTemplate_method_icp != null)
            {
                tbVolumen.Value = Convert.ToDecimal(oTemplate_method_icp.Volumen);
                tbAliquot.Value = Convert.ToDecimal(oTemplate_method_icp.Aliquot);
                ckDilution.Checked = Convert.ToBoolean(oTemplate_method_icp.Dilution_flag);
                tbDilution.Value = Convert.ToDecimal(oTemplate_method_icp.Dilution_value);

                ucSampleControl1.Idtemplate_method = idtemplate_method;
                ucSampleControl1.Type_analisys = type_analisys;
                ucSampleControl1.Recuperar_Registro();

                ucSampleFrequency1.Idtemplate_method = idtemplate_method;
                ucSampleFrequency1.Type_analisys = type_analisys;
                ucSampleFrequency1.Recuperar_Registro();                

            }

            //recuperar control samples
            //get muestras de control     
            idtemplate_method = idtemplate_method == 0 ? null : idtemplate_method;

            ucSampleControl1.Init(idtemplate_method, type_analisys);
            ucSampleFrequency1.Init(idtemplate_method, type_analisys);

            //recuperar detalle
            
            gcMethodIcp.DataSource = new CTemplate_method_icp_detailFactory().GetAll().Where(x => x.Idtemplate_method == Idtemplate_method).ToList();
        }

        public bool SaveTypeAnalysis(int? pIdtemplate_method)
        {
            // grabar template_method_icp
            Idtemplate_method = pIdtemplate_method;

            if (oTemplate_method_icp == null)
            {
                //BLOQUE INSERT
                oTemplate_method_icp = new CTemplate_method_icp();
                oTemplate_method_icp.Idtemplate_method = Convert.ToInt32(Idtemplate_method);
                oTemplate_method_icp.Volumen = tbVolumen.Value;
                oTemplate_method_icp.Aliquot = tbAliquot.Value;
                oTemplate_method_icp.Dilution_flag = ckDilution.Checked;
                oTemplate_method_icp.Dilution_value = tbDilution.Value;

                if (new CTemplate_method_icpFactory().Insert(oTemplate_method_icp))
                {
                    // guardar control sample  
                    ucSampleControl1.Idtemplate_method = idtemplate_method;
                    ucSampleFrequency1.Type_analisys = type_analisys;

                    ucSampleFrequency1.Idtemplate_method = idtemplate_method;
                    ucSampleFrequency1.Type_analisys = type_analisys;

                    ucSampleControl1.Grabar_Registro();
                    ucSampleFrequency1.Grabar_Registro();                                        

                    // guardar detalle 
                    foreach (CTemplate_method_icp_detail item in gcMethodIcp.DataSource as BindingList<CTemplate_method_icp_detail>)
                    {
                        item.Idtemplate_method = oTemplate_method_icp.Idtemplate_method;                        
                        item.Status = true;

                        new CTemplate_method_icp_detailFactory().Insert(item);
                    }
                }
            }
            else
            {
                //BLOQUE UPDATE
                oTemplate_method_icp.Volumen = tbVolumen.Value;
                oTemplate_method_icp.Aliquot = tbAliquot.Value;
                oTemplate_method_icp.Dilution_flag = ckDilution.Checked;
                oTemplate_method_icp.Dilution_value = tbDilution.Value;

                //eliminar todo el detalle
                foreach (CTemplate_method_icp tmi in new CTemplate_method_icpFactory().GetAll().Where(x => x.Idtemplate_method == Idtemplate_method).ToList())
                {
                    tmi.Status = false;
                    new CTemplate_method_icpFactory().Update(tmi);
                }

                if (new CTemplate_method_icpFactory().Update(oTemplate_method_icp))
                {
                    //IPC
                    foreach (CTemplate_method_icp_detail item in gcMethodIcp.DataSource as BindingList<CTemplate_method_icp_detail>)
                    {
                        item.Idtemplate_method = oTemplate_method_icp.Idtemplate_method;
                        item.Status = true;

                        if (!new CTemplate_method_icp_detailFactory().Update(item))
                            new CTemplate_method_icp_detailFactory().Insert(item);
                    }
                }

                //grabar control_sample                
                ucSampleControl1.Grabar_Registro();
                ucSampleFrequency1.Grabar_Registro();
            }
            return true; 
        }

        public void Limpiar_Campos()
        { 
        }

        #endregion

        Dictionary<int, string> dicRegexTempIntervalo = new Dictionary<int, string>();
        Dictionary<int, string> dicRegexTempFrecuencia = new Dictionary<int, string>();

        void Init()
        {                                    
            //get muestras de control     
            ucSampleControl1.Init(null, null);
            ucSampleFrequency1.Init(null, null);

            #region codigo de prototipo
            /*
            List<CUnidad_medida> lstUnidadMedida = new List<CUnidad_medida>();
            lstUnidadMedida.Add(new CUnidad_medida() { Nombre = "mg/L" });
            lstUnidadMedida.Add(new CUnidad_medida() { Nombre = "ppm" });

            List<CMethodME_detail> lstMethodME_detail = new List<CMethodME_detail>();
            lstMethodME_detail.Add(new CMethodME_detail()
            {
                Elemento = "Ag",
                Longitud = 328.024M,
                IDL = 0.0074M,
                Linealidad = 2.5M,

                STD2 = 1,
                Num_decimal = 4,
                STD1 = 0.5M,
                IPC = 0.25M,
                MDL = 0.0074M,
                LFB = 0.100M,               
                LFM = 0.35M,

                Limite_inferior_MD = 0.0074M,
                Limite_inferior_MT = 0.001M,
                Limite_superior = 2.5M
            });

            lstMethodME_detail.Add(new CMethodME_detail()
            {
                Elemento = "Ag",
                Longitud = 330.257M,
                IDL = 0.0074M,
                Linealidad = 2.5M,
                
                STD2 = 1,
                Num_decimal = 4,
                STD1 = 0.5M,
                IPC = 0.25M,
                MDL = 0.0074M,
                LFB = 0.130M,

                LFM = 0.38M,
                Limite_inferior_MD = 0.0074M,
                Limite_inferior_MT = 0.001M,
                Limite_superior = 2.5M
            });

            lstMethodME_detail.Add(new CMethodME_detail()
            {
                Elemento = "Cu",
                Longitud = 330.257M,
                IDL = 0.0074M,
                Linealidad = 2.5M,

                STD2 = 1,
                Num_decimal = 4,
                STD1 = 0.5M,
                IPC = 0.25M,
                MDL = 0.0074M,
                LFB = 0.130M,

                LFM = 0.38M,
                Limite_inferior_MD = 0.0074M,
                Limite_inferior_MT = 0.001M,
                Limite_superior = 2.5M
            });

            lstMethodME_detail.Add(new CMethodME_detail()
            {
                Elemento = "ᵃᵃ B",
                Longitud = 330.257M,
                IDL = 0.0074M,
                Linealidad = 2.5M,

                STD2 = 1,
                Num_decimal = 4,
                STD1 = 0.5M,
                IPC = 0.25M,
                MDL = 0.0074M,
                LFB = 0.130M,                
                LFM = 0.38M,

                Limite_inferior_MD = 0.0074M,
                Limite_inferior_MT = 0.001M,
                Limite_superior = 2.5M
            });

            List<CMethodME> lstMethodMe = new List<CMethodME>();
            lstMethodMe.Add(new CMethodME()
            {

                Num_muestras = 10,
                DUP_rank_qc = 0.15M,
                LRB_rank_qc = 2.2M,
                IPC_rank_qc = 0.10M,
                LFB_rank_qc = 0.15M,
                LFM_rank_qc = 0.30M,
                IPC_cada_n_muestras = 10,
                LRB_cada_n_muestras = 20,
                List_MethodME_detail = lstMethodME_detail
            });

            CMethodME method = lstMethodMe[0];

            
            tbIPC_frecuencia.Value = method.IPC_cada_n_muestras;
            tbLRB_frecuencia.Value = method.LRB_cada_n_muestras;
            tbNumMuestras.Value = method.Num_muestras;
            tbDUP_rango.Value = method.DUP_rank_qc;
            tbIPC_rango.Value = method.IPC_rank_qc;
            tbLFB_rango.Value = method.LFB_rank_qc;
            tbLFM_rango.Value = method.LFM_rank_qc;
            tbLRB_criterio.Value = method.LRB_rank_qc;
            

            //gridControl1.DataSource = new BindingList<CMethodME_detail>(method.List_MethodME_detail);

            gcMethodIcp.DataSource = new CMethods_multiFactory().GetAll();
            ShowColumns(tpPesosLecturas);
             * 
             */
            #endregion


        }

        void ShowColumns(DevExpress.XtraTab.XtraTabPage page)
        {
            for (int i = 0; i < gvMethodIcp.Columns.Count; i++)
                gvMethodIcp.Columns[i].VisibleIndex = -1;

            gcCol_Elemento.VisibleIndex = 100;
            gcCol_Longitud.VisibleIndex = 100;
            tabExpControl.PageVisible = false;
            tabExpBlancoReactivo.PageVisible = false;
            tabExpResultados.PageVisible = false;
            tabExpPesosLecturas.PageVisible = false;
            expandablePanel1.Visible = false;

            if (page == tpPesosLecturas)
            {
                gcCol_Num_decimal.VisibleIndex = 100;

                tabExpPesosLecturas.PageVisible = true;

                expandablePanel1.Visible = true;
            }
            else if (page == tpCalibraciones)
            {
                gcCol_STD1.VisibleIndex = 100;
                gcCol_STD2.VisibleIndex = 100;
            }
            else if (page == tpControlCalidad)
            {               

                tabExpControl.PageVisible = true;
                tabExpBlancoReactivo.PageVisible = true;
                tabExpResultados.PageVisible = false;

                expandablePanel1.Visible = true;
            }
            else if (page == tpResultados)
            {                
                gcCol_IDL.VisibleIndex = 100;
                gcCol_MDL.VisibleIndex = 100;
                gcCol_Linealidad.VisibleIndex = 100;
                gcCol_Limite_inferior_MD.VisibleIndex = 100;
                gcCol_Limite_inferior_MT.VisibleIndex = 100;
                gcCol_Limite_superior.VisibleIndex = 100;

                tabExpControl.PageVisible = false;
                tabExpBlancoReactivo.PageVisible = false;
                tabExpResultados.PageVisible = true;

                expandablePanel1.Visible = true;
            }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            ShowColumns(e.Page);
        }

        private void ckIPC_CheckedChanged(object sender, EventArgs e)
        {
            ShowColumns(xtraTabControl1.SelectedTabPage);
        }

        private void ckLFB_CheckedChanged(object sender, EventArgs e)
        {
            ShowColumns(xtraTabControl1.SelectedTabPage);

        }

        private void ckLFM_CheckedChanged(object sender, EventArgs e)
        {
            ShowColumns(xtraTabControl1.SelectedTabPage);
        }
        

        private void gcSampleControl_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Append)
            {
                e.Handled = true;
                MessageBox.Show("");
            }
        }
        
    }

    public class CMethodME
    {
        public int Num_muestras { get; set; }
        public int IPC_cada_n_muestras { get; set; }
        public int LRB_cada_n_muestras { get; set; }
        public decimal IPC_rank_qc { get; set; }
        public decimal LRB_rank_qc { get; set; }
        public decimal LFB_rank_qc { get; set; }
        public decimal LFM_rank_qc { get; set; }
        public decimal DUP_rank_qc { get; set; }
        
        public List<CMethodME_detail> List_MethodME_detail { get; set; }
    }

    public class CUnidad_medida
    {
        public string Nombre { get; set; }
    }

    public class CMethodME_detail
    {
        public string Elemento { get; set; }
        public decimal Longitud { get; set; }
        public decimal IDL { get; set; }
        public decimal MDL { get; set; }   // ordenar en forma, elemento, intervalo(mdl)
        public decimal Linealidad { get; set; }      
        public int Num_decimal { get; set; } // 
        public decimal STD1 { get; set; }
        public decimal STD2 { get; set; }        
        public decimal IPC { get; set; }        
        public decimal LFB { get; set; }        
        public decimal LFM { get; set; }
        public decimal Limite_inferior_MD { get; set; }  // = a MDL
        public decimal Limite_inferior_MT { get; set; }  // = a IDL
        public decimal Limite_superior { get; set; }  // volumen/alicuota*dilucion2*linealidad
    }
}
