using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer;
using System.ComponentModel;

namespace LimsProject
{
    public class CEvaluatorBatch
    {
        #region attributes

        MathParserNet.Parser parser = new MathParserNet.Parser();        

        BindingList<CBatch_detail_aa_twofold> DTBatch = new BindingList<CBatch_detail_aa_twofold>();
        int Position_row = 0;

        #endregion

        #region constructor

        public CEvaluatorBatch(BindingList<CBatch_detail_aa_twofold> dt, int position_row)
        {            
            DTBatch = dt;
            Position_row = position_row;            
            registerVariables(dt[position_row]);
        }

        public CEvaluatorBatch(BindingList<CBatch_detail_aa_twofold> dt)
        {         
            DTBatch = dt;            
            registerVariables();
        }

        #endregion

        #region properties

        BindingList<CBatch_detail_aa_twofold> getRowCalculated
        {
            get
            {
                return DTBatch;
            }
        }

        #endregion

        #region register variables and fx

        void registerVariables()
        {
            for (int i = 0; i < DTBatch.Count; i++)
                if (Contain_all_reading(DTBatch[i])) 
                    registerVariables(DTBatch[i]);
        }

        void registerVariables(CBatch_detail_aa_twofold current_row)
        {
            parser = new MathParserNet.Parser();
            
            // --- register functions
            parser.RegisterCustomDoubleFunction("deter_dilu", Deter_Dilu);                        
            
            // --- register variables
            //parser.AddVariable("", Convert.ToDouble());

            parser.AddVariable("weight1", Convert.ToDouble(current_row.Weight1));
            parser.AddVariable("weight2", Convert.ToDouble(current_row.Weight2));
            parser.AddVariable("volumen1", Convert.ToDouble(current_row.Volumen1));
            parser.AddVariable("volumen2", Convert.ToDouble(current_row.Volumen2));

            if (current_row.Reading1 != null && current_row.Reading1.Trim() != "")
                parser.AddVariable("reading1", current_row.Reading1);
            else
                parser.AddVariable("reading1", 0);

            if (current_row.Reading2 != null && current_row.Reading2.Trim() != "")
                parser.AddVariable("reading2", current_row.Reading2);
            else
                parser.AddVariable("reading2", 0);

            parser.AddVariable("dilu2", Convert.ToDouble(current_row.Dilu2));            
            parser.AddVariable("dilu3", Convert.ToDouble(current_row.Dilu3));   
         
            parser.AddVariable("flag_dilu2", Convert.ToDouble(current_row.Flag_dilu2));            
            parser.AddVariable("flag_dilu3", Convert.ToDouble(current_row.Flag_dilu3));

            parser.AddVariable("fum", Convert.ToDouble(current_row.Fum));

            parser.AddVariable("calc_dilu2", "deter_dilu(dilu2, flag_dilu2)");
            parser.AddVariable("calc_dilu3", "deter_dilu(dilu3, flag_dilu3)");            

            parser.AddVariable("factor1", "volumen1/weight1*calc_dilu2*calc_dilu3*fum");
            parser.AddVariable("factor2", "volumen2/weight2*calc_dilu2*calc_dilu3*fum");

            parser.AddVariable("law1", "reading1*factor1");
            parser.AddVariable("law2", "reading2*factor2");

            parser.AddVariable("Result_analysis", "(law1+law2)/2");    
        
            AssignValues(current_row);
        }                       

        #endregion

        #region delegates fx

        public double Deter_Dilu(double dilution, double flag_dilu)
        {
            if (flag_dilu == 1)
                return dilution;
            else
                return 1;
        }

        public bool RowIsMri(CBatch_detail_aa_twofold current_row)
        {
            if (Convert.ToInt32(current_row.Flag_mri) == 1)
                return true;
            return false;
        }

        #endregion

        #region evaluate expressions

        void AssignValues(CBatch_detail_aa_twofold current_row)
        {
            CSignificantValue oSignificantValue = new CSignificantValue(Convert.ToInt32(current_row.Idtemplate_method));

            string factor1 = "", factor2 = "", reading1 = "", reading2 = "", law1 = "", law2 = "";
            double law_avg;

            //law_avg = parser.SimplifyDouble("Result_analysis");

            object evalReading1 = current_row.Reading1;
            object evalReading2 = current_row.Reading2;

            if (current_row.Reading1 != null)
                reading1 = current_row.Reading1;
            if (current_row.Reading2 != null)
                reading2 = current_row.Reading2;

            factor1 = current_row.Factor1;
            law1 = current_row.Law1;

            factor2 = current_row.Factor2;
            law2 = current_row.Law2;

            double reading_value1 = 0;
            double reading_value2 = 0;

            if (double.TryParse(current_row.Reading1, out reading_value1))
            {
                law1 = parser.SimplifyDouble("law1").ToString();                
                factor1 = parser.DicVar["factor1"].FloatNumber.ToString();

                oSignificantValue.ApplySignificant2(factor1, reading1, law1);
                current_row.Law1 = oSignificantValue.Law;
                current_row.Factor1 = oSignificantValue.Factor;
                current_row.Reading1 = oSignificantValue.Reading;
            }

            if (double.TryParse(current_row.Reading2, out reading_value2))
            {
                law2 = parser.SimplifyDouble("law2").ToString();
                factor2 = parser.DicVar["factor2"].FloatNumber.ToString();

                oSignificantValue.ApplySignificant2(factor2, reading2, law2);
                current_row.Law2 = oSignificantValue.Law;
                current_row.Factor2 = oSignificantValue.Factor;
                current_row.Reading2 = oSignificantValue.Reading;
            }                       

            // --- the avg law convert to significative value 
            // --- calculate only the rows aren't mri
            if (!RowIsMri(current_row))
            {
                if (Contain_all_reading(current_row))
                {
                    law_avg = parser.SimplifyDouble("Result_analysis");
                    current_row.Result_analysis = Convert.ToDecimal(law_avg);
                    current_row.Str_result_analysis = oSignificantValue.GetReportLaw(law_avg);
                }
            }
            else
            {
                current_row.Result_analysis = Convert.ToDecimal(current_row.Law2_long);
                current_row.Str_result_analysis = current_row.Law2;
            }
        }

        /// <summary>
        /// This function verify if all reading of repetitions are complete 
        /// </summary>
        /// <param name="current_row"></param>
        /// <returns></returns>
        bool Contain_all_reading(CBatch_detail_aa_twofold current_row)
        {            
            object evalReading1 = current_row.Reading1;
            object evalReading2 = current_row.Reading2;

            if (evalReading1 == null || evalReading2 == null)
                return false;
            if (evalReading1.ToString().Trim().Length == 0)
                return false;
            if (evalReading2.ToString().Trim().Length == 0)
                return false;

            return true;
        }

        #endregion

    }
}
