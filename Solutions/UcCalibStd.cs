using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LimsProject.BusinessLayer;
using LimsProject.BusinessLayer.Modules;

namespace LimsProject
{
    public delegate void signCalibs(CGroup_solution e);
    public delegate void newCalib(CGroup_solution e);

    public partial class UcCalibStd : UserControl
    {
        #region Attributes

        ModCalibStd oModCalibStd = new ModCalibStd();
        BindingList<CCustomCalibStd> LstAllCalibs = new BindingList<CCustomCalibStd>();
        List<ChartPoint> lstChartPoint_serie1 = new List<ChartPoint>();
        List<ChartPoint> lstChartPoint_serie2 = new List<ChartPoint>();
        Dictionary<int, CCalib_std> DicCurve = new Dictionary<int, CCalib_std>();
        List<CCustom_method_solution> LstTemplate_method { get; set; }   

        int idtemplate_method = 0;
        int idelement = 0;
        short idmr_detail = 0;
        int? idreactive_medium = 0;
        int? idreactive_modif = 0;

        public DateTime Date_init { get; set; }
        public DateTime Date_end { get; set; }

        CGroup_solution group_solution = new CGroup_solution();

        public event signCalibs onSignCalibs;
        public event newCalib onNewCalib;

        #endregion

        #region properties

        public List<CCustomCalibStd> LstCalibrations
        {
            get
            {
                return new List<CCustomCalibStd>(LstAllCalibs.Where(c => c.Idtemplate_method == idtemplate_method).ToList());
            }
        }

        public CGroup_solution Group_solution
        {
            get
            {
                return group_solution;
            }
            set
            {
                group_solution = value;                
            }
        }

        #endregion

        #region constructores

        #endregion

        #region constructor

        public UcCalibStd()
        {
            InitializeComponent();
        }        

        #endregion

        #region methods

        public void Init(CGroup_solution p_group_solution, BindingList<CCustom_method_solution> lstTemplate_method)
        {
            group_solution = p_group_solution;
            LstTemplate_method = new List<CCustom_method_solution>(lstTemplate_method);

            CReactiveFactory faReactive = new CReactiveFactory();
            List<CReactive> lstReactive = faReactive.GetAll();

            lstReactive.Add(new CReactive() { Idreactive = 0, Reactive_name = "---", Chemical_formula = "---" });            

            cbMedium.Properties.DataSource = lstReactive;
            cbMedium.Properties.ValueMember = "Idreactive";
            cbMedium.Properties.DisplayMember = "Reactive_name";

            cbModif.Properties.DataSource = lstReactive;
            cbModif.Properties.ValueMember = "Idreactive";
            cbModif.Properties.DisplayMember = "Reactive_name";                        

            LstAllCalibs = oModCalibStd.GetCustomCalibStd(group_solution, lstTemplate_method);

            gcCalibStd.DataSource = LstAllCalibs;
            gvCalibStd.ExpandAllGroups();

            CUser_system oUser = new CUser_systemFactory()
                .GetByPrimaryKey(new CUser_systemKeys(Convert.ToInt16(group_solution.User_sign_calib)));

            if (oUser != null)
            {
            ucTraceUser1.UserSign = oUser.Cod_user;
            ucTraceUser1.DateSign = Convert.ToDateTime(group_solution.Date_sign_calib);
            }
            ApplyStatus();
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

            try
            {                
                if (!double.IsNaN(oRL_serie2.r()))
                    tbRexp2.BackColor = oRL_serie2.r() > Convert.ToDouble(tbRexp2.Value) ? Color.White : Color.Red;

                if (!double.IsNaN(oRL_serie1.r()))
                    tbRexp2.BackColor = oRL_serie1.r() > Convert.ToDouble(tbRexp2.Value) ? Color.White : Color.Red;
            }
            catch
            {
            }
            
        }

        void PlotChart()
        {
            lstChartPoint_serie1.Clear();
            lstChartPoint_serie2.Clear();

            // --- recuperar metodo actual
            if (gvCalibStd.GetFocusedRowCellValue(gcCal_Idtemplate_method) != null)
            {
                CTemplate_method_aa currentTemplate_method_aa =
                    new CTemplate_method_aaFactory()
                    .GetByPrimaryKey(new CTemplate_method_aaKeys(
                        Convert.ToInt32(gvCalibStd.GetFocusedRowCellValue(gcCal_Idtemplate_method))));

                tbValidity_calib.Value = Convert.ToInt32(currentTemplate_method_aa.Validity_calib);
                tbRexp2.Value = Convert.ToDecimal(currentTemplate_method_aa.Rexp2);
                cbMedium.EditValue = currentTemplate_method_aa.Medium;
                tbMediumConc.Value = Convert.ToDecimal(currentTemplate_method_aa.Medium_conc);
                cbModif.EditValue = currentTemplate_method_aa.Modif;
                tbModifConc.Value = Convert.ToDecimal(currentTemplate_method_aa.Modif_conc);


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

        void GrabarStdFocused(int rowindex)
        {
            CSet_calibsFactory faSet_calibs = new CSet_calibsFactory();

            CCustomCalibStd customCalibStd = gvCalibStd.GetRow(rowindex) as CCustomCalibStd;

            ModCalibStd oModCalibStd = new ModCalibStd();
            
            int idtemplate_method = Convert.ToInt32(gvCalibStd.GetRowCellValue(rowindex, gcCal_Idtemplate_method));
            CSet_calibs oSet_calib = oModCalibStd.GetSet_CalibBy(group_solution.Idgroup_solution, idtemplate_method);

            if (oSet_calib == null)
            {
                oSet_calib = new CSet_calibs();
                oSet_calib.Idset_calibs = 0;
                oSet_calib.Idtemplate_method = customCalibStd.Idtemplate_method;
                oSet_calib.Idset_calibs = customCalibStd.Idset_calibs;
                oSet_calib.Idgroup_solution = group_solution.Idgroup_solution;
            }

            bool result_set_calib = false;

            // --- grupo de calibración
            if (!(result_set_calib = faSet_calibs.Update(oSet_calib)))
                result_set_calib = faSet_calibs.Insert(oSet_calib);

            if (result_set_calib)
            {
                // --- guardar calibración
                CCalib_stdFactory faCalib_std = new CCalib_stdFactory();
                CCalib_std oCalib_std = new CCalib_std();

                oCalib_std = faCalib_std.GetByPrimaryKey(new CCalib_stdKeys(customCalibStd.Idcalib_std));

                if (oCalib_std == null)
                    oCalib_std = new CCalib_std();
                
                oCalib_std.Absorbance = customCalibStd.Absorbance;
                oCalib_std.Concentration = customCalibStd.Concentration;
                oCalib_std.Idcalib = customCalibStd.Idcalib;
                oCalib_std.Idset_calibs = oSet_calib.Idset_calibs;
                oCalib_std.Idgroup_solution = group_solution.Idgroup_solution;
                oCalib_std.Idtemplate_method = idtemplate_method;

                bool result_std = false;
                if (!(result_std = faCalib_std.Update(oCalib_std)))
                    result_std = faCalib_std.Insert(oCalib_std);

                if (result_std)                                    
                    gvCalibStd.SetRowCellValue(rowindex, gcCal_Idcalib_std, oCalib_std.Idcalib_std);
                
            }
        }

        public void ApplyStatus()
        {
            if (Convert.ToBoolean(group_solution.Flag_sign_calib))
            {                
                gvCalibStd.OptionsBehavior.Editable = false;
                paCalibNew.Enabled = true;
                paCalibSign.Enabled = false;                
            }
            else
            {                
                gvCalibStd.OptionsBehavior.Editable = true;
                paCalibNew.Enabled = false;
                paCalibSign.Enabled = true;
            }
            if (Convert.ToBoolean(group_solution.Flag_close_calib))
                paCalibNew.Enabled = false;
            else if (Convert.ToBoolean(group_solution.Flag_sign_calib))
                paCalibNew.Enabled = true;
            else if (!Convert.ToBoolean(group_solution.Flag_sign_calib))
                paCalibNew.Enabled = false;
        }

        protected bool Grabar_Nuevo_Registro()
        {
            CGroup_solutionFactory faGroup_solution = new CGroup_solutionFactory();

            CGroup_solution NewGroup_solution = new CGroup_solution();
            NewGroup_solution.Idelement = group_solution.Idelement;            

            bool result = false;
            if (!(result = faGroup_solution.Update(NewGroup_solution)))
                result = faGroup_solution.Insert(NewGroup_solution);

            ModSolution oModSolution = new ModSolution();
            ModCorrelatives oModCorrelatives = new ModCorrelatives();
            if (result)
            {                
                if (faGroup_solution.Update(NewGroup_solution))
                {
                    group_solution.Flag_close_calib = true;
                    faGroup_solution.Update(group_solution);
                    paCalibNew.Enabled = false;

                    onNewCalib(NewGroup_solution);
                }
            }
            return result;
        }

        #endregion

        #region events

        private void gvCalibStd_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            PlotChart();
        }

        private void gvCalibStd_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {            
            if (e.Column == gcCal_Absorbance)
            {
                // --- grabar
                //GrabarStdFocused();

                // --- mostrar grafica
                PlotChart();
            }
        }

        private void rgSelectGraphic_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlotChart();
        }

        private void ucSignCalibStd_OnSign(bool login)
        {
            if (login)
            {
                bool result = false;

                ModSolution modSolution = new ModSolution();
                group_solution.User_sign_calib = Comun.User_system.Iduser;
                group_solution.Date_sign_calib = Comun.GetDate();
                group_solution.Flag_sign_calib = true;
                group_solution.Date_ini = DateTime.Now;
                group_solution.Date_end = DateTime.Now.AddMonths(new CSettings().GetNumMonthStdCalib());

                CGroup_solutionFactory faGroup_solution = new CGroup_solutionFactory();
                if (!(result = faGroup_solution.Update(group_solution)))
                    result = faGroup_solution.Insert(group_solution);

                if (result)
                {
                    ModCorrelatives oModCorrelatives = new ModCorrelatives();
                    group_solution.Cod_solution = oModCorrelatives.GetCorrelative(ModCorrelatives.Correlative.EstandarCalibracion);
                    result = faGroup_solution.Update(group_solution);
                }

                if (result)
                {
                    deDateIni.DateTime = Convert.ToDateTime(group_solution.Date_ini);
                    deDateEnd.DateTime = Convert.ToDateTime(group_solution.Date_end);

                    ucTraceUser1.UserSign = Comun.GetUser();
                    ucTraceUser1.DateSign = Comun.GetDate();
                                                            
                    gcCal_Cod_template_method.GroupIndex = -1;

                    for (int i = 0; i < gvCalibStd.RowCount; i++)                                            
                        GrabarStdFocused(i);                            
                    
                    gcCal_Cod_template_method.GroupIndex = 0;


                    // --- guardar los metodos seleccionados
                    CGroup_solution_methodsFactory faGroup_solutions_methods = new CGroup_solution_methodsFactory();
                    CGroup_solution_methods oGroup_solution_methods = new CGroup_solution_methods();
                    foreach (CCustom_method_solution item in LstTemplate_method)
                    {
                        if (item.Sel)
                        {
                            oGroup_solution_methods = modSolution.GetGroup_solution_methods(item.Idtemplate_method, group_solution.Idgroup_solution);
                            if (oGroup_solution_methods == null)
                            {
                                oGroup_solution_methods = new CGroup_solution_methods();
                                oGroup_solution_methods.Idtemplate_method = item.Idtemplate_method;
                                oGroup_solution_methods.Idgroup_solution = group_solution.Idgroup_solution;
                                
                            }
                            oGroup_solution_methods.Status = true;                                

                            if (!faGroup_solutions_methods.Update(oGroup_solution_methods))
                                faGroup_solutions_methods.Insert(oGroup_solution_methods);
                        }                        
                    }

                    ApplyStatus();

                    ucSignCalibStd.Clear();

                    onSignCalibs(group_solution);
                }
            }
        }

        #endregion

        private void btNuevaCalibracion_Click(object sender, EventArgs e)
        {
            // --- nueva calibración
            Grabar_Nuevo_Registro();
        }

        public void Clear()
        {
            gcCalibStd.DataSource = null;
            chartCalib.Series[0].Points.Clear();
            chartCalib.Series[1].Points.Clear();
            tbValidity_calib.Value = 0;
            cbMedium.EditValue = null;
            cbModif.EditValue = null;
            tbRexp2.Value = 0;
            tbMediumConc.Value = 0;
            tbModifConc.Value = 0;
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
                sumxy = sumxy + LstX[i] * LstY[i];
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
