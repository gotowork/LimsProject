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
    public partial class FormCalibStd : LibraryBasicForm.FormBaseEmpty
    {
        ModCalibStd oModCalibStd = new ModCalibStd();
        BindingList<CCustomCalibStd> LstAllCalibs = new BindingList<CCustomCalibStd>();        
        List<ChartPoint> lstChartPoint_serie1 = new List<ChartPoint>();
        List<ChartPoint> lstChartPoint_serie2 = new List<ChartPoint>();
        Dictionary<int, CCalib_std> DicCurve = new Dictionary<int, CCalib_std>();
        
        CGroup_solution oGroup_solution = new CGroup_solution();

        int idtemplate_method = 0;
        int idelement = 0;
        short idmr_detail = 0;
        int? idreactive_medium = 0;
        int? idreactive_modif = 0;

        public DateTime Date_init { get; set; }
        public DateTime Date_end { get; set; }

        public List<CCustomCalibStd> LstCalibrations
        {
            get {
                return new List<CCustomCalibStd>(LstAllCalibs.Where(c => c.Idtemplate_method == idtemplate_method).ToList());                
            }
        }

        public FormCalibStd()
        {
            InitializeComponent();
        }

        public FormCalibStd(int p_idelement, short p_idmr_detail, int p_idtemplate_method)
        {
            idelement = p_idelement;
            idmr_detail = p_idmr_detail;
            idtemplate_method = p_idtemplate_method;
            InitializeComponent();
        }

        void InitData()
        {
            CReactiveFactory faReactive = new CReactiveFactory();
            List<CReactive> lstReactive = faReactive.GetAll();

            lstReactive.Add(new CReactive() { Idreactive = 0, Reactive_name = "---", Chemical_formula = "---" });

            cbMedium.Properties.DataSource = lstReactive;
            cbMedium.Properties.ValueMember = "Idreactive";
            cbMedium.Properties.DisplayMember = "Reactive_name";

            cbModif.Properties.DataSource = lstReactive;
            cbModif.Properties.ValueMember = "Idreactive";
            cbModif.Properties.DisplayMember = "Reactive_name";

            CTemplate_method_aa oTemplate_method_aa = new CTemplate_method_aa();
            CTemplate_method_aaFactory faTemplate_method_aa = new CTemplate_method_aaFactory();

            oTemplate_method_aa = 
                faTemplate_method_aa.GetByPrimaryKey(new CTemplate_method_aaKeys(idtemplate_method));

            idreactive_medium = oTemplate_method_aa.Medium;
            idreactive_modif = oTemplate_method_aa.Modif;

            LstAllCalibs = oModCalibStd.GetCustomCalibStd(idelement, idmr_detail, idreactive_medium, idreactive_modif);
            gcCalibStd.DataSource = LstAllCalibs;
            gvCalibStd.ExpandAllGroups();


            //oGroup_solution = oModCalibStd.GetMethodCalib(idelement, idmr_detail, idreactive_medium, idreactive_modif);

            CElement oElement = new CElementFactory()
                .GetByPrimaryKey(new CElementKeys(Convert.ToInt16(idelement)));
                      

            ucTraceUser1.UserSign = Comun.GetUser();
            ucTraceUser1.DateSign = Comun.GetDate();
        }

        

        void InitXYDiagram()
        {
            chartCalib.Series[0].Points.Clear();
            chartCalib.Series[1].Points.Clear();

            chartCalib.Series[0].LegendText = "---";
            chartCalib.Series[1].LegendText = "---";
            
            string serie = "{0}, {1}";

            RegressionLineal oRL_serie1 = new RegressionLineal();
            RegressionLineal oRL_serie2 = new RegressionLineal();

            foreach (ChartPoint item in lstChartPoint_serie1)
            {
                DevExpress.XtraCharts.SeriesPoint punto = new DevExpress.XtraCharts.SeriesPoint();
                punto.Argument = item.X.ToString();
                punto.Values = new double[] { Convert.ToDouble(item.Y) };

                oRL_serie1.AddPoint(Convert.ToDouble(item.X), Convert.ToDouble(item.Y));

                chartCalib.Series[0].Points.Add(punto);

                chartCalib.Series[0].LegendText = string.Format(serie, oRL_serie1.getEcuation(), oRL_serie1.getR());
            }

            foreach (ChartPoint item in lstChartPoint_serie2)
            {
                DevExpress.XtraCharts.SeriesPoint punto = new DevExpress.XtraCharts.SeriesPoint();
                punto.Argument = item.X.ToString();
                punto.Values = new double[] { Convert.ToDouble(item.Y) };

                oRL_serie2.AddPoint(Convert.ToDouble(item.X), Convert.ToDouble(item.Y));

                chartCalib.Series[1].Points.Add(punto);

                chartCalib.Series[1].LegendText = string.Format(serie, oRL_serie2.getEcuation(), oRL_serie2.getR());
            }            
        }

        private void FormCalibStandar_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void gvCalibStd_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            PlotChart();
        }

        void PlotChart()
        {
            lstChartPoint_serie1.Clear();
            lstChartPoint_serie2.Clear();

            // --- recuperar datos del método
            CTemplate_method_aa oTemplate_method_aa = new CTemplate_method_aaFactory().GetByPrimaryKey(new CTemplate_method_aaKeys(idtemplate_method));
            tbValidity_calib.Value = Convert.ToInt32(oTemplate_method_aa.Validity_calib);
            tbRexp2.Value = Convert.ToDecimal(oTemplate_method_aa.Rexp2);
            cbMedium.EditValue = oTemplate_method_aa.Medium;
            tbMediumConc.Value = Convert.ToDecimal(oTemplate_method_aa.Medium_conc);
            cbModif.EditValue = oTemplate_method_aa.Modif;
            tbModifConc.Value = Convert.ToDecimal(oTemplate_method_aa.Modif_conc);

            // --- recuperar metodo actual
            if (gvCalibStd.GetFocusedRowCellValue(gcCal_Idtemplate_method) != null)
            {            
                CTemplate_method_aa currentTemplate_method_aa =
                    new CTemplate_method_aaFactory()
                    .GetByPrimaryKey(new CTemplate_method_aaKeys(
                        Convert.ToInt32(gvCalibStd.GetFocusedRowCellValue(gcCal_Idtemplate_method))));

                // --- dibujar curva
                if (rgSelectGraphic.SelectedIndex == 0
                    || rgSelectGraphic.SelectedIndex == 2)
                {                    
                    lstChartPoint_serie1 =
                        (from t in LstAllCalibs
                         where t.Idtemplate_method == currentTemplate_method_aa.Idtemplate_method
                         select new ChartPoint
                         {
                             X = Convert.ToDecimal(t.Concentration),
                             Y = t.Absorbance_previus
                         }).ToList();
                }

                // --- dibujar curva
                if (rgSelectGraphic.SelectedIndex == 1
                    || rgSelectGraphic.SelectedIndex == 2)
                {
                    lstChartPoint_serie2 =
                        (from t in LstAllCalibs
                         where t.Idtemplate_method == currentTemplate_method_aa.Idtemplate_method
                         select new ChartPoint
                         {
                             X = Convert.ToDecimal(t.Concentration),
                             Y = t.Absorbance
                         }).ToList();
                }

                InitXYDiagram();
            }
        }

        private void gvCalibStd_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {                       
            // --- mostrar grafica
            PlotChart();
        }

        private void ucSignCalibStd_OnSign(bool login)
        {
            if (login)
            {
                if (oGroup_solution != null)
                {
                    // --- guardar calibraciones, grupo1, grupo2
                    CSet_methods_calibFactory faSet_methods_calib = new CSet_methods_calibFactory();
                    CSet_calibsFactory faSet_calib = new CSet_calibsFactory();
                    CCalib_stdFactory faCalib_std = new CCalib_stdFactory();

                    foreach (CCustomCalibStd item in LstAllCalibs)
                    {
                        CSet_calibsFactory faSet_calibs = new CSet_calibsFactory();

                        // --- recuperar fila modificada
                        CSet_calibs oSet_calib = faSet_calibs.GetByPrimaryKey(new CSet_calibsKeys(item.Idset_calibs));
                        if (oSet_calib == null)
                        {
                            oSet_calib = new CSet_calibs();
                            oSet_calib.Idset_calibs = 0;
                            oSet_calib.Idtemplate_method = item.Idtemplate_method;
                            oSet_calib.Idset_calibs = item.Idset_calibs;
                        }
                        oSet_calib.Idgroup_solution = oGroup_solution.Idgroup_solution;

                        bool result_set_calib = false;

                        // --- grupo de calibración
                        if (!(result_set_calib = faSet_calibs.Update(oSet_calib)))
                            result_set_calib = faSet_calibs.Insert(oSet_calib);

                        if (result_set_calib)
                        {
                            // --- guardar calibración
                            CCalib_std oCalib_std = new CCalib_std();

                            oCalib_std = faCalib_std.GetByPrimaryKey(new CCalib_stdKeys(item.Idcalib_std));

                            if (oCalib_std == null)
                                oCalib_std = new CCalib_std();

                            oCalib_std.Idcalib_std = 0;
                            oCalib_std.Absorbance_previus = item.Absorbance;
                            oCalib_std.Concentration = item.Concentration;
                            oCalib_std.Idcalib = item.Idcalib;
                            oCalib_std.Idcalib_std = item.Idcalib_std;
                            oCalib_std.Idset_calibs = oSet_calib.Idset_calibs;

                            if (!faCalib_std.Update(oCalib_std))
                                faCalib_std.Insert(oCalib_std);
                        }
                    }

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
            else
            {
            }
        }

        private void rgSelectGraphic_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlotChart();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        
    }

    #region Clases

    public class ChartPoint
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }
    }

    public class CCurve
    {
        public decimal a { get; set; }
        public decimal b { get; set; }
        public decimal R { get; set; }
    }

    #endregion

    #region Regresion lineal

    public class RegressionLineal
    {
        public List<double> LstX = new List<double>();
        public List<double> LstY = new List<double>();        

        public void AddPoint(double x, double y)
        {
            LstX.Add(x);
            LstY.Add(y);
        }

        double SumX()
        {
            double sumx = 0;
            foreach (double item in LstX)
            {
                sumx = sumx + item;
            }
            return sumx;
        }

        double SumY()
        {
            double sumy = 0;
            foreach (double item in LstY)
            {
                sumy = sumy + item;
            }
            return sumy;
        }

        double SumXY()
        {
            double sumxy = 0;
            for (int i = 0; i < LstX.Count; i++)
            {
                sumxy = sumxy + LstX[i]*LstY[i];
            }
            return sumxy;
        }

        double SumXX()
        {
            double sumxx = 0;
            foreach (double item in LstX)
            {
                sumxx = sumxx + item * item;
            }
            return sumxx;
        }

        double SumYY()
        {
            double sumyy = 0;
            foreach (double item in LstY)
            {
                sumyy = sumyy + item * item;
            }
            return sumyy;
        }

        public double a()
        {
            int n = LstX.Count;
            return (n * SumXY() - SumX() * SumY()) / (n * SumXX() - Math.Pow(SumX(), 2));
        }

        public double b()
        {
            int n = LstX.Count;
            return (SumY() * SumXX() - SumX() * SumXY()) / (n * SumXX() - Math.Pow(SumX(), 2));
        }

        public double r()
        {
            int n = LstX.Count;
            return (n * SumXY() - SumX() * SumY()) / Math.Sqrt((n * SumXX() - Math.Pow(SumX(), 2)) * (n * SumYY() - Math.Pow(SumY(), 2)));
        }

        public string getEcuation()
        {
            string ecuation = "y = {0}x + {1}";
            return string.Format(ecuation, Math.Round(a(), 4), Math.Round(b(), 4));
        }

        public string getR()
        {
            string strr = "r = {0}";
            return string.Format(strr, Math.Round(r(), 4));
        }
    }

    #endregion 

}
