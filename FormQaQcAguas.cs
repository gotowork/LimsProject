using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LimsProject
{
    public partial class FormQaQcAguas : Form
    {
        public FormQaQcAguas()
        {
            InitializeComponent();
        }

        public void init()
        {
            CDigestion Digestion = new CDigestion();
            Digestion.fecha = DateTime.Now;
            Digestion.analista = "Isaac";
            Digestion.metodo = "MT";

            #region digestion

            Digestion.LstDigestion_detalle.Add(new CDigestion_detalle()
            {
                alicuota = 50,
                codigo = "IPC",
                factor = 1,
                T_85C = true,
                volumen = 50,
                dilucion = 1,
                observaciones = "",
                matriz = "---",
                item = 1
            });

            Digestion.LstDigestion_detalle.Add(new CDigestion_detalle()
            {
                alicuota = 50,
                codigo = "LRB",
                factor = 1,
                T_85C = true,
                volumen = 50,
                dilucion = 1,
                observaciones = "",
                matriz = "---",
                item = 2
            });

            Digestion.LstDigestion_detalle.Add(new CDigestion_detalle()
            {
                alicuota = 50,
                codigo = "LFB",
                factor = 1,
                T_85C = true,
                volumen = 50,
                dilucion = 1,
                observaciones = "",
                matriz = "---",
                item = 3
            });

            Digestion.LstDigestion_detalle.Add(new CDigestion_detalle()
            {
                alicuota = 50,
                codigo = "AG13000460",
                factor = 1,
                T_85C = true,
                volumen = 50,
                dilucion = 1,
                observaciones = "",
                matriz = "---",
                item = 4
            });

            Digestion.LstDigestion_detalle.Add(new CDigestion_detalle()
            {
                alicuota = 50,
                codigo = "DUP-AG13000460",
                factor = 1,
                T_85C = true,
                volumen = 50,
                dilucion = 1,
                observaciones = "",
                matriz = "---",
                item = 5
            });

            Digestion.LstDigestion_detalle.Add(new CDigestion_detalle()
            {
                alicuota = 50,
                codigo = "LFM-AG13000460",
                factor = 1,
                T_85C = true,
                volumen = 50,
                dilucion = 1,
                observaciones = "",
                matriz = "---",
                item = 6
            });

            Digestion.LstDigestion_detalle.Add(new CDigestion_detalle()
            {
                alicuota = 50,
                codigo = "AG13000458",
                factor = 1,
                T_85C = true,
                volumen = 50,
                dilucion = 1,
                observaciones = "",
                matriz = "an",
                item = 7
            });

            Digestion.LstDigestion_detalle.Add(new CDigestion_detalle()
            {
                alicuota = 50,
                codigo = "AG13000450",
                factor = 1,
                T_85C = true,
                volumen = 50,
                dilucion = 1,
                observaciones = "",
                matriz = "ap",
                item = 8
            });

            Digestion.LstDigestion_detalle.Add(new CDigestion_detalle()
            {
                alicuota = 50,
                codigo = "AG13000451",
                factor = 1,
                T_85C = true,
                volumen = 50,
                dilucion = 1,
                observaciones = "",
                matriz = "ap",
                item = 9
            });

            Digestion.LstDigestion_detalle.Add(new CDigestion_detalle()
            {
                alicuota = 50,
                codigo = "AG13000452",
                factor = 1,
                T_85C = true,
                volumen = 50,
                dilucion = 1,
                observaciones = "",
                matriz = "ar",
                item = 10
            });

            Digestion.LstDigestion_detalle.Add(new CDigestion_detalle()
            {
                alicuota = 50,
                codigo = "IPC",
                factor = 1,
                T_85C = true,
                volumen = 50,
                dilucion = 1,
                observaciones = "",
                matriz = "---",
                item = 11
            });

            Digestion.LstDigestion_detalle.Add(new CDigestion_detalle()
            {
                alicuota = 50,
                codigo = "AG13000453",
                factor = 1,
                T_85C = true,
                volumen = 50,
                dilucion = 1,
                observaciones = "",
                matriz = "an",
                item = 12
            });

            Digestion.LstDigestion_detalle.Add(new CDigestion_detalle()
            {
                alicuota = 50,
                codigo = "AG13000454",
                factor = 1,
                T_85C = true,
                volumen = 50,
                dilucion = 1,
                observaciones = "",
                matriz = "an",
                item = 13
            });

            Digestion.LstDigestion_detalle.Add(new CDigestion_detalle()
            {
                alicuota = 50,
                codigo = "AG13000455",
                factor = 1,
                T_85C = true,
                volumen = 50,
                dilucion = 1,
                observaciones = "",
                matriz = "ac",
                item = 14
            });

            Digestion.LstDigestion_detalle.Add(new CDigestion_detalle()
            {
                alicuota = 50,
                codigo = "AG13000457",
                factor = 1,
                T_85C = true,
                volumen = 50,
                dilucion = 1,
                observaciones = "",
                matriz = "an",
                item = 15
            });

            Digestion.LstDigestion_detalle.Add(new CDigestion_detalle()
            {
                alicuota = 50,
                codigo = "AG13000459",
                factor = 1,
                T_85C = true,
                volumen = 50,
                dilucion = 1,
                observaciones = "",
                matriz = "ap",
                item = 16
            });

            

            #endregion

            deFecha.DateTime = Digestion.fecha;
            tbAnalista.Text = Digestion.analista;
            tbMetodo.Text = Digestion.metodo;

            //gridControl1.DataSource = Digestion.LstDigestion_detalle;
            RecuperarControlValues();
            RecuperarIcp();
        }

        private void FormQaQcAguas_Load(object sender, EventArgs e)
        {
            init();
        }

        Dictionary<string, CCeldaProcesada> dicCeldaProcesada = new Dictionary<string, CCeldaProcesada>();
        Dictionary<string, CControlValues> dicControlValues = new Dictionary<string, CControlValues>();
        Dictionary<int, DataRow> dicFilasLecturas = new Dictionary<int, DataRow>();
        Dictionary<int, DataRow> dicFilasLeyes = new Dictionary<int, DataRow>();

        Dictionary<string, string> dicToolTip = new Dictionary<string, string>();

        Dictionary<int, decimal> dicFactor = new Dictionary<int, decimal>();
        Dictionary<int, decimal> dicDilucion = new Dictionary<int, decimal>();

        List<LimsProject.BusinessLayer.CMethods_multi> queryMethodsMulti = new LimsProject.BusinessLayer.CMethods_multiFactory().GetAll();
        List<LimsProject.BusinessLayer.CIcp_lecturas> queryLecturasIcp = new LimsProject.BusinessLayer.CIcp_lecturasFactory().GetAll();
        List<CMuestrasIteva> queryFilasIteva = new List<CMuestrasIteva>();
        decimal factor = 1M;

        DataTable dtSamples = new DataTable();
        DataTable dtLecturas = new DataTable();
        DataTable dtLeyes = new DataTable();

        void RecuperarControlValues()
        {
            foreach (var item in queryMethodsMulti)
            {
                CControlValues control = new CControlValues();
                control.IDL = Convert.ToDecimal(item.Idl);
                control.IPC = Convert.ToDecimal(item.Ipc);
                control.LFB = Convert.ToDecimal(item.Lfb);
                control.LFM = Convert.ToDecimal(item.Lfm);
                control.MDL = Convert.ToDecimal(item.Mdl);
                control.LDR = Convert.ToDecimal(item.Linealidad);

                dicControlValues.Add(item.Elemento.PadRight(2, '_') +  item.Longitud.ToString(), control);
            }
        }

        void RecuperarIcp()
        {
            // columnas
            var queryColumns =
                (from m in queryLecturasIcp
                 orderby m.Elemento
                 select new 
                 {
                     m.Elemento
                 }).Distinct();

            dtSamples.Columns.Add("Matriz");
            dtSamples.Columns.Add("Codigo");
            dtSamples.Columns.Add("Factor");
            dtSamples.Columns.Add("T_85C");
            dtSamples.Columns.Add("Alicuota");
            dtSamples.Columns.Add("Volumen");
            dtSamples.Columns.Add("Dilucion");
            dtSamples.Columns.Add("Idmuestra");
            dtSamples.Columns.Add("Muestra");
            dtSamples.Columns.Add("Metodo");
            
            dtLeyes.Columns.Add("Matriz");
            dtLeyes.Columns.Add("Codigo");
            dtLeyes.Columns.Add("Factor");
            dtLeyes.Columns.Add("T_85C");
            dtLeyes.Columns.Add("Alicuota");
            dtLeyes.Columns.Add("Volumen");
            dtLeyes.Columns.Add("Dilucion");
            dtLeyes.Columns.Add("Idmuestra");
            dtLeyes.Columns.Add("Muestra");
            dtLeyes.Columns.Add("Metodo");

            dtLecturas.Columns.Add("Matriz");
            dtLecturas.Columns.Add("Codigo");
            dtLecturas.Columns.Add("Factor");
            dtLecturas.Columns.Add("T_85C");
            dtLecturas.Columns.Add("Alicuota");
            dtLecturas.Columns.Add("Volumen");
            dtLecturas.Columns.Add("Dilucion");
            dtLecturas.Columns.Add("Idmuestra");
            dtLecturas.Columns.Add("Muestra");
            dtLecturas.Columns.Add("Metodo");

            // filas
            var queryFilas = 
                (from m in queryLecturasIcp
                 select new
                 {
                     m.Idmuestra,
                     m.Muestra,
                     m.Dilucion2
                 }).Distinct().OrderBy(c => c.Idmuestra);  

            int idbatch = 0;
            foreach (var item in queryFilas)
            {

                if (item.Muestra.Contains("IPC") || item.Muestra.Contains("LRB") 
                    || item.Muestra.Contains("LFB") || item.Muestra.Contains("LFM") 
                    || item.Muestra.ToUpper().Contains("DUP"))
                    idbatch++;
                
                queryFilasIteva.Add(new CMuestrasIteva() { Idbatch = idbatch, Idmuestra = Convert.ToInt32(item.Idmuestra), Muestra = item.Muestra });
            }

            // agregando columnas
            foreach (var item in queryColumns)
            {                
                dtLecturas.Columns.Add(item.Elemento);
                dtLeyes.Columns.Add(item.Elemento);                
            }

            // agregando filas            
            foreach (var item in queryFilas)
            {
                DataRow drSamples = dtSamples.NewRow();
                drSamples["Idmuestra"] = item.Idmuestra;
                drSamples["Muestra"] = item.Muestra;
                drSamples["Metodo"] = "MD";
                drSamples["Factor"] = factor;
                if (Convert.ToInt32(item.Dilucion2) == 1)
                    drSamples["Dilucion"] = 20;
                else
                    drSamples["Dilucion"] = 1;

                dtSamples.Rows.Add(drSamples);

                DataRow drLey = dtLeyes.NewRow();
                drLey["Idmuestra"] = item.Idmuestra;
                drLey["Muestra"] = item.Muestra;
                drLey["Metodo"] = "MD";
                drLey["Factor"] = factor;
                if (Convert.ToInt32(item.Dilucion2) == 1)
                    drLey["Dilucion"] = 20;
                else
                    drLey["Dilucion"] = 1;

                if (!dicFilasLeyes.ContainsKey(Convert.ToInt32(item.Idmuestra)))
                {
                    dicFilasLeyes.Add(Convert.ToInt32(item.Idmuestra), drLey);
                    dtLeyes.Rows.Add(drLey);
                }

                //-----------------------------------------------------
                DataRow drLec = dtLecturas.NewRow();
                drLec["Idmuestra"] = item.Idmuestra;
                drLec["Muestra"] = item.Muestra;
                drLec["Metodo"] = "MD";
                drLec["Factor"] = factor;
                if (Convert.ToInt32(item.Dilucion2) == 1)
                    drLec["Dilucion"] = 20;
                else
                    drLec["Dilucion"] = 1;

                if (!dicFilasLecturas.ContainsKey(Convert.ToInt32(item.Idmuestra)))
                {
                    dicFilasLecturas.Add(Convert.ToInt32(item.Idmuestra), drLec);
                    dtLecturas.Rows.Add(drLec);
                }
            }
            // procesar control de calidad
            foreach (var item in queryLecturasIcp)
            {
                if (item.Muestra.Contains("IPC") || !item.Muestra.Contains("LRB")
                    || !item.Muestra.Contains("LFB"))
                {
                    dicFilasLecturas[Convert.ToInt32(item.Idmuestra)][item.Elemento] = item.Lectura.ToString();

                    CCeldaProcesada celdaProcesada = ProcesarMuestraControl(Convert.ToInt32(item.Idmuestra), item.Elemento, item.Lectura.ToString());

                    if (celdaProcesada != null)                    
                        dicFilasLeyes[Convert.ToInt32(item.Idmuestra)][item.Elemento] = celdaProcesada.ValueCelda.ToString();
                    
                }
            }

            // procesar muestras de control
            foreach (var item in queryLecturasIcp)
            {
                if (!item.Muestra.Contains("IPC") && !item.Muestra.Contains("LRB")
                    && !item.Muestra.Contains("LFB"))
                {
                    dicFilasLecturas[Convert.ToInt32(item.Idmuestra)][item.Elemento] = item.Lectura.ToString();

                    CCeldaProcesada celdaProcesada = ProcesarMuestra(Convert.ToInt32(item.Idmuestra), item.Elemento, item.Lectura.ToString());

                    if (celdaProcesada != null)
                        dicFilasLeyes[Convert.ToInt32(item.Idmuestra)][item.Elemento] = celdaProcesada.ValueCelda.ToString();
                }
            }            

            // procesar dilusiones y columnas de control
            // procesar muestras de control
            foreach (var item in queryLecturasIcp)
            {
                if (!item.Muestra.Contains("IPC") && !item.Muestra.Contains("LRB")
                    && !item.Muestra.Contains("LFB") && !item.Muestra.Contains("Blank")
                    && !item.Muestra.Contains("STD"))
                {
                    dicFilasLecturas[Convert.ToInt32(item.Idmuestra)][item.Elemento] = item.Lectura.ToString();

                    //CCeldaProcesada celdaProcesada = 
                        ProcesarDilucionElementos(item.Muestra, item.Elemento);

                    //if (celdaProcesada != null)
                    //    dicFilasLeyes[Convert.ToInt32(item.Idmuestra)][item.Elemento] = celdaProcesada.ValueCelda.ToString();
                }
            }            
            
            gridControl1.DataSource = dtSamples;
            gridControl2.DataSource = dtLecturas;
            gridControl3.DataSource = dtLeyes;

            //ocultar columnas en las lecturas y leyes
            gridView2.Columns["Matriz"].Visible = false;
            gridView2.Columns["Codigo"].Visible = false;
            
            gridView2.Columns["T_85C"].Visible = false;
            gridView2.Columns["Alicuota"].Visible = false;
            gridView2.Columns["Volumen"].Visible = false;            
            gridView2.Columns["Idmuestra"].Visible = false;            
            gridView2.Columns["Metodo"].Visible = false;
            gridView2.Columns["Muestra"].Visible = true;
            gridView2.Columns["Factor"].Visible = true;
            gridView2.Columns["Dilucion"].Visible = true;

            gridView3.Columns["Matriz"].Visible = false;
            gridView3.Columns["Codigo"].Visible = false;            
            gridView3.Columns["T_85C"].Visible = false;
            gridView3.Columns["Alicuota"].Visible = false;
            gridView3.Columns["Volumen"].Visible = false;            
            gridView3.Columns["Idmuestra"].Visible = false;            
            gridView3.Columns["Metodo"].Visible = false;

            gridView3.Columns["Muestra"].Visible = true;
            gridView3.Columns["Factor"].Visible = true;
            gridView3.Columns["Dilucion"].Visible = true;

            gridView2.Columns["Muestra"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gridView2.Columns["Factor"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gridView2.Columns["Dilucion"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            
            gridView3.Columns["Muestra"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gridView3.Columns["Factor"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            gridView3.Columns["Dilucion"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            
            
        }

        public CCeldaProcesada ProcesarMuestraControl(int idmuestra, string elemento, string value_celda)
        {
            if (dicControlValues.ContainsKey(elemento) && !value_celda.Contains("NULL"))
            {
                System.Drawing.Color colorError = System.Drawing.Color.NavajoWhite;

                CCeldaProcesada celdaProcesada = new CCeldaProcesada();
                decimal value_celda_decimal = Convert.ToDecimal(value_celda);
                CControlValues controlValues = dicControlValues[elemento];

                // procesar celda: idmuestra + elemento
                DataRow fila = dicFilasLeyes[idmuestra];
                celdaProcesada.ColorCelda = Color.White;
                celdaProcesada.ValueCelda = value_celda;
                string nombreMuestra = fila["Muestra"].ToString();
                string metodo = fila["Metodo"].ToString();
                decimal factor = Convert.ToDecimal(fila["Factor"]);
                decimal dilucion2 = Convert.ToDecimal(fila["Dilucion"]);

                if (EsIPC(nombreMuestra)) // IPC
                {
                    celdaProcesada.ValueCelda = "OK IPC";
                    if (!EstaEntre(value_celda_decimal, controlValues.IPC * 0.9M, controlValues.IPC * 1.1M))
                    {
                        celdaProcesada.ColorCelda = colorError;
                        celdaProcesada.ValueCelda = "Out IPC";
                    }

                    StringBuilder mensaje = new StringBuilder();
                    mensaje.Append("IPC de {0}: {1}");
                    mensaje.Append("\nIntervalo: {1} * 0.9 <= lectura <= {1} * 1.1");
                    mensaje.Append("\nIntervalo: {2} <= {4} <= {3}");
                    mensaje.Append("\nResultado: {5}");

                    string txt = string.Format(
                        mensaje.ToString(), elemento, controlValues.IPC, controlValues.IPC * 0.9M, 
                        controlValues.IPC * 1.1M, value_celda, celdaProcesada.ValueCelda);
                    dicToolTip.Add(idmuestra.ToString() + elemento, txt);
                }
                else if (EsLRB(nombreMuestra)) // LRB en (MT ó MD)
                {
                    decimal MDL_or_IDL = metodo == "MT" ? controlValues.MDL : controlValues.IDL;
                    celdaProcesada.ValueCelda = "OK LRB";
                    if (!(value_celda_decimal < MDL_or_IDL * 2.2M))
                    {
                        celdaProcesada.ColorCelda = colorError;
                        celdaProcesada.ValueCelda = "Cont LRB";
                    }
                }
                else if (EsLFB(nombreMuestra))
                {
                    int idbatch_muestra = queryFilasIteva.Single(c => c.Idmuestra == idmuestra).Idbatch;
                    int idmuestra_lrb = queryFilasIteva.Single(c => c.Muestra == "LRB" && c.Idbatch == idbatch_muestra).Idmuestra;

                    DataRow drLrb = dicFilasLecturas[idmuestra_lrb];
                    decimal lrb = Convert.ToDecimal(drLrb[elemento]);
                    celdaProcesada.ValueCelda = "OK LFB";
                    if (!EstaEntre(Math.Abs(value_celda_decimal - lrb), controlValues.LFB * 0.85M, controlValues.LFB * 1.15M))
                    {
                        celdaProcesada.ColorCelda = colorError;
                        celdaProcesada.ValueCelda = "Cont LFB";
                    }
                }
                else if (EsDUP(nombreMuestra))
                {
                    // encontrar muestra original
                    int idmuestra_orig = queryFilasIteva.Single(c => nombreMuestra.Contains(c.Muestra) && nombreMuestra != c.Muestra).Idmuestra;
                    DataRow drOri = dicFilasLeyes[idmuestra_orig];
                    decimal value_orig = Convert.ToDecimal(drOri[elemento].ToString().Replace('<', ' '));
                    decimal MDL_or_IDL = metodo == "MT" ? controlValues.MDL : controlValues.IDL;
                    celdaProcesada.ValueCelda = "OK Dup";
                    if (value_orig > MDL_or_IDL)
                    {
                        if (!(Math.Abs(value_orig - value_celda_decimal) < 0.15M * value_orig))
                        {
                            celdaProcesada.ColorCelda = colorError;
                            celdaProcesada.ValueCelda = "Out Dup";
                        }
                    }
                    else
                    {
                        if (!(value_celda_decimal < 2.2M * controlValues.MDL))
                        {
                            celdaProcesada.ColorCelda = colorError;
                            celdaProcesada.ValueCelda = "Out Dup";
                        }
                    }
                }                                              

                // agregar/actualizar el diccionario
                string key = idmuestra.ToString() + elemento;
                celdaProcesada.Idmuestra = idmuestra;
                celdaProcesada.Elemento = elemento;

                if (!dicCeldaProcesada.ContainsKey(key))
                    dicCeldaProcesada.Add(key, celdaProcesada);
                else
                    dicCeldaProcesada[key] = celdaProcesada;

                return celdaProcesada;
            }
            else
                return null;
        }

        public CCeldaProcesada ProcesarMuestra(int idmuestra, string elemento, string value_celda)
        {
            if (dicControlValues.ContainsKey(elemento) && !value_celda.Contains("NULL"))
            {
                System.Drawing.Color colorError = System.Drawing.Color.NavajoWhite;

                CCeldaProcesada celdaProcesada = new CCeldaProcesada();
                decimal value_celda_decimal = Convert.ToDecimal(value_celda);
                CControlValues controlValues = dicControlValues[elemento];

                // procesar celda: idmuestra + elemento
                DataRow fila = dicFilasLeyes[idmuestra];
                celdaProcesada.ColorCelda = Color.White;
                celdaProcesada.ValueCelda = value_celda;
                string nombreMuestra = fila["Muestra"].ToString();
                string metodo = fila["Metodo"].ToString();
                decimal factor = Convert.ToDecimal(fila["Factor"]);
                decimal dilucion2 = Convert.ToDecimal(fila["Dilucion"]);

                
                if (EsDUP(nombreMuestra))
                {
                    // encontrar muestra original
                    int idmuestra_orig = queryFilasIteva.Single(c => nombreMuestra.Contains(c.Muestra) && nombreMuestra != c.Muestra).Idmuestra;
                    DataRow drOri = dicFilasLeyes[idmuestra_orig];
                    decimal value_orig = Convert.ToDecimal(drOri[elemento].ToString().Replace('<', ' '));
                    decimal MDL_or_IDL = metodo == "MT" ? controlValues.MDL : controlValues.IDL;
                    celdaProcesada.ValueCelda = "OK Dup";
                    if (value_orig > MDL_or_IDL)
                    {
                        if (!(Math.Abs(value_orig - value_celda_decimal) < 0.15M * value_orig))
                        {
                            celdaProcesada.ColorCelda = colorError;
                            celdaProcesada.ValueCelda = "Out Dup";
                        }
                    }
                    else
                    {
                        if (!(value_celda_decimal < 2.2M * controlValues.MDL))
                        {
                            celdaProcesada.ColorCelda = colorError;
                            celdaProcesada.ValueCelda = "Out Dup";
                        }
                    }
                }
                else if (EsLFM(nombreMuestra))
                {
                    int idmuestra_orig = queryFilasIteva.Single(c => nombreMuestra.Contains(c.Muestra) && nombreMuestra != c.Muestra).Idmuestra;
                    DataRow drOri = dicFilasLeyes[idmuestra_orig];
                    decimal value_orig = Convert.ToDecimal(drOri[elemento].ToString().Replace('<', ' '));
                    decimal MDL_or_IDL = metodo == "MT" ? controlValues.MDL : controlValues.IDL;
                    celdaProcesada.ValueCelda = "OK LFM";
                    if (value_orig > MDL_or_IDL)
                    {
                        if (!EstaEntre(Math.Abs(value_orig - value_celda_decimal), controlValues.LFM * 0.70M, controlValues.LFM * 1.30M))
                        {
                            celdaProcesada.ColorCelda = colorError;
                            celdaProcesada.ValueCelda = "Out LFM";
                        }
                    }
                    else
                    {
                        if (!EstaEntre(value_celda_decimal, controlValues.LFM * 0.70M, controlValues.LFM * 1.30M))
                        {
                            celdaProcesada.ColorCelda = colorError;
                            celdaProcesada.ValueCelda = "Out LFM";
                        }
                    }
                }
                else if (EsSoloMuestra(nombreMuestra))
                {
                    
                    decimal MDL_or_IDL = metodo == "MT" ? controlValues.IDL : controlValues.MDL;
                    string limite_inferior = metodo == "MT" ? "IDL" : "MDL";
                    string txt;

                    if (value_celda_decimal < MDL_or_IDL)                    
                        celdaProcesada.ValueCelda = "<" + MDL_or_IDL;
                    else
                    {
                        if (value_celda_decimal < controlValues.LDR)                        
                            celdaProcesada.ValueCelda = (value_celda_decimal * factor * dilucion2).ToString();
                        else                        
                            celdaProcesada.ValueCelda = ">" + controlValues.LDR.ToString();
                    }

                    #region comentario

                    ///Metodo:
                    ///LimiteInferior:
                    ///LimiteSuperior:
                    ///Prueba: LimiteInferior < lectura < LimiteSuperior .......
                    ///Resultado:

                    StringBuilder mensaje = new StringBuilder();
                    mensaje.Append("Metodo: {0}");
                    mensaje.Append("\nLímite inferior {1}: {2}");
                    mensaje.Append("\nLímite superior LDR: {3}");                  
                    mensaje.Append("\nPrueba: {4} < {5} < {6}");
                    mensaje.Append("\nResultado: {7}");

                    txt = string.Format(mensaje.ToString(),
                        metodo,
                        limite_inferior, MDL_or_IDL,
                        controlValues.LDR,
                        MDL_or_IDL, value_celda, controlValues.LDR,
                        celdaProcesada.ValueCelda);

                    dicToolTip.Add(idmuestra.ToString() + elemento, txt);
                    
                    #endregion

                }

                // agregar/actualizar el diccionario
                string key = idmuestra.ToString() + elemento;
                celdaProcesada.Idmuestra = idmuestra;
                celdaProcesada.Elemento = elemento;

                if (!dicCeldaProcesada.ContainsKey(key))
                    dicCeldaProcesada.Add(key, celdaProcesada);
                else
                    dicCeldaProcesada[key] = celdaProcesada;

                return celdaProcesada;
            }
            else
                return null;
        }

        Dictionary<string, bool> DicDilusionElementos = new Dictionary<string, bool>();

        public void ProcesarDilucionElementos(string muestra, string columna_elemento)
        {
            if (dicControlValues.ContainsKey(columna_elemento))
            {
                string elemento = columna_elemento.Substring(0, 2); //queryMethodsMulti.First(c => columna_elemento.Contains(c.Elemento)).Elemento;

                if (!DicDilusionElementos.ContainsKey(muestra + elemento))
                {

                    if (elemento == "Zn" && muestra == "SS13000697")
                        elemento = elemento;

                    var queryMetodosPrioridad =
                        (from m in queryMethodsMulti.Where(c => c.Elemento_longitud.Contains(elemento))
                         select new
                         {
                             m.Elemento_longitud,
                             m.Prioridad
                         }).ToList();

                    //seleccionar muestras con diluciones
                    var queryMuestrasDilusion =
                        (from m in queryLecturasIcp
                         where Convert.ToInt32(m.Dilucion2) == 1
                         && m.Elemento.Contains(elemento)
                         && m.Muestra == muestra
                         select new
                         {
                             m.Muestra
                         }
                         ).Distinct();

                    //seleccionar muestras
                    var queryMuestras =
                        (from m in queryLecturasIcp.Where(c => c.Muestra.Contains(muestra))
                         from n in queryMuestrasDilusion
                         join p in queryMetodosPrioridad on m.Elemento equals p.Elemento_longitud
                         where m.Muestra == n.Muestra && m.Elemento.Contains(elemento)
                         select new CGrupoLeyes
                         {
                             Idmuestra = m.Idmuestra,
                             Muestra = m.Muestra,
                             Dilusion2 = Convert.ToInt32(m.Dilucion2) == 1 ? true : false,
                             Elemento = m.Elemento,
                             ControlValue = dicControlValues.ContainsKey(m.Elemento) ? dicControlValues[m.Elemento] : null,
                             Lectura = m.Lectura,
                             Prioridad = Convert.ToInt32(p.Prioridad)
                         }).ToList();                    

                    ElegirLeyes(queryMuestras);

                    if (!DicDilusionElementos.ContainsKey(muestra + elemento))
                        DicDilusionElementos.Add(muestra + elemento, true);

                    
                }
            }
        }

        public void ElegirLeyes(List<CGrupoLeyes> grupoLeyes)
        {
            CGrupoLeyes leySel = 
                (from m in grupoLeyes
                 where m.Lectura != "NULL" && Convert.ToDecimal(m.Lectura) < m.ControlValue.LDR
                 orderby Convert.ToInt32(m.Dilusion2), m.Prioridad
                 select m).FirstOrDefault();

            if (leySel == null)
            {
                //buscar otra respuesta alternativa
                //mientras setearlo como vacio
                foreach (var item in grupoLeyes)
                    dicFilasLeyes[Convert.ToInt32(item.Idmuestra)][item.Elemento] = "";
            }
            else 
            {
                foreach (var item in grupoLeyes)
                {
                    //setear como vacio todas los items que no fueron elegidos
                    if (!(item.Idmuestra == leySel.Idmuestra && item.Elemento == leySel.Elemento))
                    {
                        dicFilasLeyes[Convert.ToInt32(item.Idmuestra)][item.Elemento] = "";
                    }
                }
            }            
        }

        bool EsValorNumerico(string value)
        {
            try
            {
                decimal valueNumerico = Convert.ToDecimal(value);
                return true;
            }
            catch {
                return false;
            }
        }

        bool EsIPC(string name_sample)
        {
            return name_sample == "IPC";
        }

        bool EsLRB(string name_sample)
        {
            return name_sample == "LRB";
        }

        bool EsLFB(string name_sample)
        {
            return name_sample == "LFB";
        }

        bool EsDUP(string name_sample)
        {
            return name_sample.ToUpper().Contains("DUP");
        }

        bool EsLFM(string name_sample)
        {
            return name_sample.ToUpper().Contains("LFM");
        }

        bool EsSoloMuestra(string name_sample)
        {
            return !EsIPC(name_sample) && !EsLRB(name_sample) && !EsLFB(name_sample) && !EsDUP(name_sample) && !EsLFM(name_sample);
        }

        bool EstaEntre(decimal testValue, decimal leftValue, decimal rightValue)
        {
            return testValue > leftValue && testValue < rightValue;
        }

        bool EsMenor(decimal testValue, decimal valueControl)
        {
            return testValue < valueControl;
        }

        bool EsMayor(decimal testValue, decimal valueControl)
        {
            return testValue > valueControl;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            UcICP fm = new UcICP();
            fm.Show();
        }
        
        private void gridView2_LeftCoordChanged(object sender, EventArgs e)
        {
            gridView3.LeftCoord = gridView2.LeftCoord;
        }

        private void splitContent_SizeChanged(object sender, EventArgs e)
        {
            splitContent.SplitterPosition = splitContent.Width / 2;
        }

        private void gridView3_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            // --- recuperar celda procesada
            string key = dtLeyes.Rows[e.RowHandle]["Idmuestra"].ToString() + e.Column.FieldName;

            if (dicCeldaProcesada.ContainsKey(key))
            {
                if (dicCeldaProcesada[key].ColorCelda == Color.NavajoWhite)
                    e.Appearance.BackColor = dicCeldaProcesada[key].ColorCelda;
            }
        }

        private void gridView3_LeftCoordChanged(object sender, EventArgs e)
        {
            gridView2.LeftCoord = gridView3.LeftCoord;            
        }

        private void gridView2_TopRowChanged(object sender, EventArgs e)
        {
            gridView3.TopRowIndex = gridView2.TopRowIndex;
            gridView1.TopRowIndex = gridView2.TopRowIndex;
        }

        private void gridView3_TopRowChanged(object sender, EventArgs e)
        {
            gridView2.TopRowIndex = gridView3.TopRowIndex;
            gridView1.TopRowIndex = gridView3.TopRowIndex;
        }

        private void gridView1_TopRowChanged(object sender, EventArgs e)
        {
            gridView2.TopRowIndex = gridView1.TopRowIndex;
            gridView3.TopRowIndex = gridView1.TopRowIndex;
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridView3.FocusedRowHandle = e.FocusedRowHandle;
        }

        private void gridView2_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            gridView3.FocusedColumn = gridView3.Columns[gridView2.FocusedColumn.FieldName];
        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridView2.FocusedRowHandle = e.FocusedRowHandle;
        }

        private void gridView3_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            gridView2.FocusedColumn = gridView2.Columns[gridView3.FocusedColumn.FieldName];
        }        

        private void gridView3_Click(object sender, EventArgs e)
        {
            string key = gridView3.GetFocusedRowCellValue("Idmuestra").ToString() +
                gridView3.FocusedColumn.FieldName;

            if (dicToolTip.ContainsKey(key))
            {
                toolTipController1.HideHint();
                toolTipController1.ShowHint(dicToolTip[key], "Detalles");
            }
            else
            {
                toolTipController1.HideHint();
            }
        }
    }

    public class CGrupoLeyes
    {
        public int? Idmuestra { get; set; }
        public string Muestra { get; set; }
        public bool Dilusion2 { get; set; }
        public string Elemento { get; set; }
        public CControlValues ControlValue { get; set; }
        public string Lectura { get; set; }
        public int Prioridad { get; set; }
    }

    public class CMuestrasIteva
    {
        public int Idbatch { get; set; }
        public int Idmuestra { get; set; }
        public string Muestra { get; set; }        
    }

    public class CControlValues
    {        
        public decimal IPC { get; set; }
        public decimal MDL { get; set; }
        public decimal IDL { get; set; }
        public decimal LFB { get; set; }
        public decimal LFM { get; set; }
        public decimal LDR { get; set; }
    }

    public class CConfigBatch
    {
        public int Num_muestras_batch { get; set; }
        public int Frecuencia_ipc { get; set; }
        public int Frecuencia_lrb { get; set; }
        public int Frecuencia_lfb { get; set; }
    }

    public class CCeldaProcesada
    {
        public int Idmuestra { get; set; }
        public string Elemento { get; set; }        
        public Color ColorCelda { get; set; }
        public string ValueCelda { get; set; }
    }

    public class CDigestion
    {
        public DateTime fecha { get; set; }
        public string analista { get; set; }
        public string metodo { get; set; }

        public List<CDigestion_detalle> LstDigestion_detalle = new List<CDigestion_detalle>();
    }

    public class CDigestion_detalle
    {
        public int item { get; set; }
        public string matriz { get; set; }    // viene de recepción: se asigna en recepción
        public string codigo { get; set; }
        public int factor { get; set; }
        public bool T_85C { get; set; }
        public decimal alicuota { get; set; }
        public decimal volumen { get; set; }
        public decimal dilucion { get; set; }
        public string observaciones { get; set; }
    }

    
}
