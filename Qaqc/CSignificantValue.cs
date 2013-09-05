using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LimsProject.BusinessLayer;

namespace LimsProject
{
    public class CSignificantValue
    {
        int idtemplate_method;
        List<CCalib> lstCalibrations = new List<CCalib>();

        // --- num decimals control
        public int NumDecimalsCalib { get; private set; }
        public int NumDecFactorAA { get; private set; }
        public int NumDecReadingAA { get; private set; }
        public int NumDecLawAA { get; private set; }

        // --- format values
        public string Factor { get; private set; }
        public string Reading { get; private set; }
        public string Law { get; private set; }
        public string ReportLaw { get; private set; }

        // --- law limit
        public double Limit_top_law { get; private set; }
        public double Limit_bottom_law { get; private set; }
        public double Reading_min { get; private set; }
        public double Reading_max { get; private set; }


        List<CRank> lstRanksCalibration = new List<CRank>();
        List<CRank> lstRanksFactorAA = new List<CRank>();

        public CSignificantValue(int p_idtemplate_method)
        {
            idtemplate_method = p_idtemplate_method;

            InitConfiguration();
        }

        public void InitConfiguration()
        {
            CCalibFactory faCalib = new CCalibFactory();
            lstCalibrations = faCalib.GetAll().Where(x => x.Idtemplate_method == idtemplate_method).ToList();

            CTemplate_method_aaFactory faTemplate_method_aa = new CTemplate_method_aaFactory();
            CTemplate_method_aa oTemplate_method_aa = new CTemplate_method_aa();


            oTemplate_method_aa = faTemplate_method_aa.GetByPrimaryKey(new CTemplate_method_aaKeys(idtemplate_method));
            NumDecimalsCalib = Convert.ToInt16(oTemplate_method_aa.Num_decimal);
            Limit_bottom_law = Convert.ToDouble(oTemplate_method_aa.Law_limit_bottom);
            Limit_top_law = Convert.ToDouble(oTemplate_method_aa.Law_limit_top);

            Reading_min = Convert.ToDouble(oTemplate_method_aa.Reading_min);
            Reading_max = Convert.ToDouble(oTemplate_method_aa.Reading_max);

            CreateListRanksCalibAA();

            CreateListRanksFactorAA();
        }

        public int GetNumDecFactorAA(double factor)
        {
            foreach (CRank rank in lstRanksFactorAA)
            {
                if (Math.Log10(factor) >= rank.rizq && Math.Log10(factor) <= rank.rder)
                    return rank.num_digits;
            }
            return 0;
        }

        public int GetNumDecCalibAA(double lectura)
        {
            foreach (CRank rank in lstRanksCalibration)
            {
                if (lectura >= rank.rizq && lectura <= rank.rder)
                    return rank.num_digits;
            }
            return 0;
        }

        public string Round(double value, int digits)
        {
            if (digits < 0)
                digits = 0;

            double valueRound = Math.Round(value, digits);
            string strValue = valueRound.ToString();
            string result = "";

            // --- cute string by dot            
            if (digits == 0)
            {
                strValue = strValue.Replace(".", "");
            }
            else
            {
                if (strValue.Contains('.'))
                    strValue = strValue.PadRight(15, '0');
                else
                    strValue = (strValue + ".").PadRight(15, '0');

                int positionPoint = strValue.IndexOf('.');

                //return result = strValue.Substring(0, positionPoint + 1) + strValue.Substring(positionPoint + 1, digits);
                strValue = strValue.Substring(0, positionPoint + 1) + strValue.Substring(positionPoint + 1, digits);
            }            

            return strValue;
        }

        public string GetReading(string strValue)
        {
            double myValue = 0;
            string pattern_min = "<{0}({1})";
            string pattern_max = ">{0}({1})";
            if (double.TryParse(strValue, out myValue))
            {

                if (myValue < Reading_min)
                    strValue = String.Format(pattern_min, Reading_min.ToString(), strValue);
                if (myValue > Reading_max)
                    strValue = String.Format(pattern_max, Reading_max.ToString(), strValue);
            }

            return strValue;
        }        

        public string GetReportLaw(double law)
        {
            if (law < Limit_bottom_law)
            {
                return "<" + Limit_bottom_law.ToString();
            }
            else if (law > Limit_top_law)
            {
                return ">" + Limit_top_law.ToString();
            }
            else
                return Round(law, NumDecLawAA);
        }

        public string ApplySignificant(double factor, double reading, double law)
        {
            NumDecFactorAA = GetNumDecFactorAA(factor);
            NumDecReadingAA = GetNumDecCalibAA(reading);
            NumDecLawAA = NumDecFactorAA + NumDecReadingAA;

            //Factor = Round(factor, NumDecFactorAA);
            Factor = factor.ToString();
            Reading = Round(reading, NumDecReadingAA);
            Law = Round(law, NumDecLawAA);
            ReportLaw = GetReportLaw(law);

            return Law;
        }

        public string ApplySignificant2(string factor, string reading, string law)
        {
            ClearProperties();

            double factorValue = 0;
            double readingValue = 0;
            double lawValue = 0;
            if (double.TryParse(factor, out factorValue)
                && double.TryParse(reading, out readingValue)
                && double.TryParse(law, out lawValue))
            {
                NumDecFactorAA = GetNumDecFactorAA(factorValue);
                NumDecReadingAA = GetNumDecCalibAA(readingValue);
                NumDecLawAA = NumDecFactorAA + NumDecReadingAA;

                //Factor = Round(factor, NumDecFactorAA);
                Factor = factor.ToString();
                Reading = Round(readingValue, NumDecReadingAA);
                Law = Round(lawValue, NumDecLawAA);
                ReportLaw = GetReportLaw(lawValue);
            }
            else
            {
                Factor = factor;
                Reading = reading;
                Law = law;
            }
            return Law;
        }

        void ClearProperties()
        {
            Factor = null;
            Reading = null;
            Law = null;
            ReportLaw = null;
        }

        void CreateListRanksCalibAA()
        {
            lstRanksCalibration.Clear();

            double numAddDer, numAddIzq;
            string strNumAddDer = "0.", strNumAddIzq = "0.";

            strNumAddDer = strNumAddDer.PadRight(NumDecimalsCalib + 2, '9');
            numAddDer = Convert.ToDouble(strNumAddDer);

            if (NumDecimalsCalib >= 1)
                strNumAddIzq = strNumAddIzq.PadRight(2 + NumDecimalsCalib - 1, '0') + "1";
            else
                strNumAddIzq = "0";

            numAddIzq = Convert.ToDouble(strNumAddIzq);

            lstRanksCalibration.Add(new CRank { rizq = -1000000.00, rder = 0, num_digits = NumDecimalsCalib });
            lstRanksCalibration.Add(new CRank { rizq = 0 + numAddIzq, rder = 0 + numAddDer, num_digits = NumDecimalsCalib });
            lstRanksCalibration.Add(new CRank { rizq = 1.00, rder = 9 + numAddDer, num_digits = NumDecimalsCalib });
            lstRanksCalibration.Add(new CRank { rizq = 10.00, rder = 99 + numAddDer, num_digits = NumDecimalsCalib });
            lstRanksCalibration.Add(new CRank { rizq = 100.00, rder = 999 + numAddDer, num_digits = NumDecimalsCalib });
            lstRanksCalibration.Add(new CRank { rizq = 1000.00, rder = 9999 + numAddDer, num_digits = NumDecimalsCalib });
            lstRanksCalibration.Add(new CRank { rizq = 10000.00, rder = 99999 + numAddDer, num_digits = NumDecimalsCalib });
            lstRanksCalibration.Add(new CRank { rizq = 100000.00, rder = 999999 + numAddDer, num_digits = NumDecimalsCalib });
            lstRanksCalibration.Add(new CRank { rizq = 1000000.00, rder = 9999999 + numAddDer, num_digits = NumDecimalsCalib });
        }

        void CreateListRanksFactorAA()
        {
            lstRanksFactorAA.Clear();

            lstRanksFactorAA.Add(new CRank { rizq = -5.26, rder = -4.26, num_digits = -(-5) });
            lstRanksFactorAA.Add(new CRank { rizq = -4.26, rder = -3.26, num_digits = -(-4) });
            lstRanksFactorAA.Add(new CRank { rizq = -3.26, rder = -2.26, num_digits = -(-3) });
            lstRanksFactorAA.Add(new CRank { rizq = -2.26, rder = -1.26, num_digits = -(-2) });
            lstRanksFactorAA.Add(new CRank { rizq = -1.26, rder = -0.26, num_digits = -(-1) });
            lstRanksFactorAA.Add(new CRank { rizq = -0.26, rder = 0.74, num_digits = 0 });
            lstRanksFactorAA.Add(new CRank { rizq = 0.74, rder = 1.74, num_digits = -1 });
            lstRanksFactorAA.Add(new CRank { rizq = 1.74, rder = 2.74, num_digits = -2 });
            lstRanksFactorAA.Add(new CRank { rizq = 2.74, rder = 3.74, num_digits = -3 });
            lstRanksFactorAA.Add(new CRank { rizq = 3.74, rder = 4.74, num_digits = -4 });
            lstRanksFactorAA.Add(new CRank { rizq = 4.74, rder = 5.74, num_digits = -5 });
        }

        #region rank class

        public class CRank
        {
            public double rizq { get; set; }
            public double rder { get; set; }
            public int num_digits { get; set; }
        }

        #endregion
    }
}
