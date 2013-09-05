using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;

using LimsProject.BusinessLayer;

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;

namespace LimsProject
{
    public class CQualityControl
    {
        #region atributes

        BindingList<CBatch_detail_aa_twofold> pivot = new BindingList<CBatch_detail_aa_twofold>();
        GridControl gridcontrol = new GridControl();
        BandedGridView gridview = new BandedGridView();

        Color COLOR_HIGHER_ALLOWED_ERROR = Color.FromArgb(234, 87, 96);
        Color COLOR_LESSER_ALLOWED_ERROR = Color.FromArgb(234, 87, 96);

        Color COLOR_SD_MR_OUT_RANK = Color.FromArgb(234, 87, 96);
        Color COLOR_SD_MR_IN_RANK = Color.FromArgb(173, 218, 140);
        Color COLOR_SD_BLK_OUT_RANK = Color.FromArgb(234, 87, 96);
        Color COLOR_SD_BLK_IN_RANK = Color.FromArgb(173, 218, 140);
        
        int Idtemplate_method = 0;
        decimal Max_value_blk = 0;
        decimal Factor_repetibility = 0;
        decimal Factor_reproducibility = 0;
        decimal Law_fixed = 0;

        CTemplate_method_aa oTemplate_method_aa;

        #endregion

        #region properties        

        public double Mri_measured { get; set; }
        public double Lrb_measured { get; set; }
        public bool? Flag_correct_mri { get; set; }
        public bool? Flag_correct_lrb { get; set; }

        #endregion

        #region constructor

        public CQualityControl(BindingList<CBatch_detail_aa_twofold> p, int p_idtemplate_method)
        {
            pivot = p;
            Idtemplate_method = p_idtemplate_method;
            InitConfiguration();
            ApplyQaQc();
            GetSd();
        }        
        
        public void InitConfiguration()
        {
            Mri_measured = 0;
            Lrb_measured = 0;
            Flag_correct_mri = null;
            Flag_correct_lrb = null;

            CTemplate_method_aaFactory faTemplate_method_aa = new CTemplate_method_aaFactory();

            oTemplate_method_aa = faTemplate_method_aa.GetByPrimaryKey(new CTemplate_method_aaKeys(Idtemplate_method));

            Max_value_blk = Convert.ToDecimal(oTemplate_method_aa.Blk_max);
            Factor_repetibility = Convert.ToDecimal(oTemplate_method_aa.Reason_rep);
            Factor_reproducibility = Convert.ToDecimal(oTemplate_method_aa.Reproducibility);

            CMr_detailFactory faMr_detail = new CMr_detailFactory();
            CMr_detail oMr_detail = faMr_detail.GetByPrimaryKey(new CMr_detailKeys(Convert.ToInt16(oTemplate_method_aa.Idmr_detail)));

            Law_fixed = Convert.ToDecimal(oMr_detail.Nominal_value);
        }

        #endregion

        #region methods

        public bool? IsCorrectMri()
        {
            foreach (CBatch_detail_aa_twofold item in pivot)
            {                                    
                if (item.Flag_mri == 1)
                {
                    if (item.Reading2 == null)
                        return null;
                    else if (item.Qaqc_mr == 1)
                        return true;
                    else if (item.Qaqc_mr == 2)
                        return false;
                }
            }
            return null;
        }

        public bool? IsCorrectBlk()
        {
            foreach (CBatch_detail_aa_twofold item in pivot)
            {
                if (item.Flag_mri == 1)
                {
                    if (item.Reading1 == null)
                        return null;
                    else if (item.Qaqc_blk == 1)
                        return true;
                    else if (item.Qaqc_blk == 2)
                        return false;
                }
            }
            return null;
        }

        public void ApplyQaQc()
        {
            foreach (CBatch_detail_aa_twofold row in pivot)
            {
                ApplyQaQcRow(row);
            }
        }

        public void ApplyQaQcRow(CBatch_detail_aa_twofold current_row)
        {
            //if (Contain_all_reading(current_row))
            {                
                ApplyQaqcMrBlk(current_row);
                ApplyQaQcParity(current_row);
                ApplyQaQcTryApprove(current_row);
                //ApplyQaqcSumary();                
            }
        }
        
        public void ApplyQaqcMrBlk(CBatch_detail_aa_twofold current_row)
        {
            int flag_mri = Convert.ToInt32(current_row.Flag_mri);
            
            // only work with rows that are reference material
            if (flag_mri == 1)
            {
                long idbatch = Convert.ToInt64(pivot[0].Idbatch);
                CBatchFactory faBatch = new CBatchFactory();
                CBatch oBatch = faBatch.GetByPrimaryKey(new CBatchKeys(idbatch));
                GetSd();

                // recuperate the blk 
                decimal value_blk = Convert.ToDecimal(current_row.Reading1);

                // blk
                if (current_row.Reading1 != null)
                {
                    if (value_blk <= Max_value_blk)
                    {
                        current_row.Qaqc_blk = 1;   // --- correcto

                        oBatch.Flag_correct_lrb = true;
                        oBatch.Lrb_measured = Convert.ToDecimal(Lrb_measured);
                    }
                    if (value_blk > Max_value_blk)
                    {
                        current_row.Qaqc_blk = 2;   // --- error en el blanco 
                                                                                            
                        oBatch.Flag_correct_lrb = false;
                        oBatch.Lrb_measured = Convert.ToDecimal(Lrb_measured);
                    }
                }                

                // mri
                if (current_row.Reading2 != null)
                {
                    // ley mri +- repetibilidad*2 <= ley conocida + reproducibilidad

                    decimal min = Law_fixed - Factor_reproducibility;
                    decimal max = Law_fixed + Factor_reproducibility;

                    decimal law_mr = Convert.ToDecimal(current_row.Law2);
                    decimal value = law_mr;

                    if (value >= min && value <= max)
                    {
                        current_row.Qaqc_mr = 1;    // correcto
                        oBatch.Flag_correct_mri = true;
                        oBatch.Mri_measured = Convert.ToDecimal(Mri_measured);
                    }
                    if (value < min || value > max)
                    {
                        current_row.Qaqc_mr = 2;    // error en el mri                    
                        oBatch.Flag_correct_mri = false;
                        oBatch.Mri_measured = Convert.ToDecimal(Mri_measured);
                    }                    
                }

                faBatch.Update(oBatch);
            }
            else
            {
                // no es mri
                current_row.Qaqc_blk = 3;
                current_row.Qaqc_mr = 3;
            }
        }        

        public void ApplyQaQcParity(CBatch_detail_aa_twofold current_row)
        {            
            ///Qaqc_par
            ///---------
            ///1: diferencia de lecturas dentro del factor de repetibilidad
            ///2: diferencia de lecturas fuera del factor de repetibilidad
            ///3: reservado para mri
            ///4: lecturas fuera del límite mínimo y máximo
            ///5: lecturas vacias

            int flag_mri = Convert.ToInt32(current_row.Flag_mri);

            if (flag_mri == 0)
            {
                decimal max_reading = -100;
                decimal min_reading = 0;
                
                decimal reading1 = 0;
                decimal reading2 = 0;

                if (decimal.TryParse(current_row.Reading1, out reading1)
                    && decimal.TryParse(current_row.Reading2, out reading2))
                {
                    // --- ambas lecturas son decimales
                    // --- get min and max
                    if (reading1 >= max_reading)
                        max_reading = reading1;
                    if (reading2 >= max_reading)
                        max_reading = reading2;

                    min_reading = max_reading;

                    if (reading1 <= min_reading)
                        min_reading = reading1;
                    if (reading2 <= min_reading)
                        min_reading = reading2;

                    // --- verificar que están dentro del límite de lecturas
                    if (min_reading < oTemplate_method_aa.Reading_min
                        || max_reading > oTemplate_method_aa.Reading_max)
                        current_row.Qaqc_par = 4; // purple
                    else
                    {
                        if (Math.Abs(max_reading - min_reading) <= Factor_repetibility)
                            current_row.Qaqc_par = 1; // dentro del factor de repetibilidad
                        else
                            current_row.Qaqc_par = 2; // fuera del factor de repetibilidad
                    }                    
                }
                else 
                {
                    // --- una o ambas lecturas no son decimales
                    if (decimal.TryParse(current_row.Reading1, out reading1))
                    {
                        // --- la lectura 1 es decimal
                        if (reading1 < oTemplate_method_aa.Reading_min || reading1 > oTemplate_method_aa.Reading_max)
                            current_row.Qaqc_par = 4;
                    }
                    else if (decimal.TryParse(current_row.Reading2, out reading2))
                    {
                        // --- la lectura 2 es decimal
                        if (reading2 < oTemplate_method_aa.Reading_min || reading2 > oTemplate_method_aa.Reading_max)
                            current_row.Qaqc_par = 4;
                    }
                    else
                    {
                        // --- ambas lecturas no son decimales
                        current_row.Qaqc_par = 5; // 5: para designar que no se tiene muestras                    
                    }
                }
                SetTypeErrorParity(current_row);
            }
            else
                current_row.Qaqc_par = 3; // reservado para mri (sin imagen)
        }

        public void ApplyQaQcTryApprove(CBatch_detail_aa_twofold current_row)
        {
            if (Convert.ToInt32(current_row.Flag_mri) == 0)
            {
                if ((current_row.Qaqc_par == 1 && current_row.Qaqc_error == 0)
                    || (current_row.Qaqc_par == 1 && current_row.Qaqc_error == 1)
                    || (current_row.Qaqc_par == 1 && current_row.Qaqc_error == 2))
                {
                    current_row.Qaqc_status_result = 2; // set as right (plausible)
                    current_row.Qaqc_approve = true;
                }                                
                else if ((current_row.Qaqc_par == 2 && current_row.Qaqc_error == 4)
                    || current_row.Qaqc_par == 2 && current_row.Qaqc_error == 5)
                {
                    current_row.Qaqc_status_result = 4; // set as right (incorrecta plausible)
                    current_row.Qaqc_approve = true;
                }
                else if ((current_row.Qaqc_par == 4 && current_row.Qaqc_error == 4)
                    || current_row.Qaqc_par == 4 && current_row.Qaqc_error == 5)
                {
                    current_row.Qaqc_status_result = 4; // set as right with errors
                    current_row.Qaqc_approve = true;
                }
                else if ((current_row.Qaqc_par == 5 && current_row.Qaqc_error == 4)
                || current_row.Qaqc_par == 5 && current_row.Qaqc_error == 5)
                {
                    current_row.Qaqc_status_result = 4; // set as right with errors                    
                    current_row.Qaqc_approve = true;
                }
                else
                {
                    ///si llegó aqui es que no hubo un paso previo para aprobar 
                    ///(ingresar una observación o mandar un reensayo) y levantar la observación
                    ///que tiene como muestra incorrecta.                    
                    current_row.Qaqc_status_result = 1; // set as unright (incorrecta)
                    current_row.Qaqc_approve = false;
                }
            }
        }



        public void SetTypeErrorParity(CBatch_detail_aa_twofold current_row)
        {            
            ///qaqc_error = (
            ///0:sin errores, 
            ///1:sin error con texto, 
            ///2:sin error con reensayo, 
            ///3:con error no aprobado,
            ///4:con error aprobado con observacion, 
            ///5:con error aprobado con reensayo 
            ///

            // --- current status
            bool Flag_parity = false;
            bool Flag_approve_with_retest = false;
            bool Flag_approve_with_text = false;

            Flag_parity = false;
            // 1=true, 2=false
            if (Convert.ToInt32(current_row.Qaqc_par) == 1)
                Flag_parity = true;

            Flag_approve_with_text = false;
            if (current_row.Qaqc_approve_text.Trim().Length > 0)
                Flag_approve_with_text = true;

            Flag_approve_with_retest = false;
            // Qaqc_idretest: >0 (idtemplate_method)
            if (Convert.ToBoolean(current_row.Qaqc_tmp_retest))
                Flag_approve_with_retest = true;

            if (Flag_parity)
            {
                current_row.Qaqc_error = Comun.GetStatusErrorParity(Comun.StatusErrorParity.WithoutError);

                if (Flag_approve_with_text)
                    current_row.Qaqc_error = Comun.GetStatusErrorParity(Comun.StatusErrorParity.WithoutErrorWithText); 
                if (Flag_approve_with_retest)
                    current_row.Qaqc_error = Comun.GetStatusErrorParity(Comun.StatusErrorParity.WithoutErrorWithRetest);
            }
            else
            {
                current_row.Qaqc_error = Comun.GetStatusErrorParity(Comun.StatusErrorParity.WithErrorNotApproved);

                if (Flag_approve_with_text)
                    current_row.Qaqc_error = Comun.GetStatusErrorParity(Comun.StatusErrorParity.WithErrorApprovedWithText);
                if (Flag_approve_with_retest)
                    current_row.Qaqc_error = Comun.GetStatusErrorParity(Comun.StatusErrorParity.WithErrorApprovedWithRetest);
            }
        }

        bool Contain_all_reading(CBatch_detail_aa_twofold current_row)
        {
            string evalReading1 = current_row.Reading1;
            string evalReading2 = current_row.Reading2;

            if (evalReading1 == null || evalReading2 == null)
                return false;
            if (evalReading1.Trim().Length == 0)
                return false;
            if (evalReading2.Trim().Length == 0)
                return false;
            
            return true;
        }

        public void GetSd()
        {
            // --- calculate sd
            List<double> lstMrLaw = new List<double>();
            List<double> lstBlkLaw = new List<double>();

            for (int i = 0; i < pivot.Count; i++)
            {
                int flag_mri = Convert.ToInt32(pivot[i].Flag_mri);
                CBatch_detail_aa_twofold current_row = pivot[i];

                if (flag_mri == 1)
                {
                    if (current_row.Law1 != null && current_row.ToString().Trim().Length != 0)
                    {
                        // -- blk
                        double law_blk = Convert.ToDouble(current_row.Law1);
                        lstBlkLaw.Add(law_blk);
                    }
                    if (current_row.Law2 != null && current_row.ToString().Trim().Length != 0)
                    {
                        // -- mr
                        double law_mr = Convert.ToDouble(current_row.Law2);
                        lstMrLaw.Add(law_mr);                        
                    }                    
                }
            }

            Mri_measured = Convert.ToDouble(Standard_desviation(lstMrLaw));            
            Lrb_measured = Convert.ToDouble(Standard_desviation(lstBlkLaw));            
        }

        double Standard_desviation(List<double> listaDatos)
        {
            double desvStd = 0;
            double N = 0, prom = 0, suma = 0, NrestadoUno = 0, sumapotencias = 0;
            N = listaDatos.Count;
            NrestadoUno = N - 1;
            foreach (double dato in listaDatos)
            {
                suma += dato;
            }
            prom = suma / N;
            foreach (double dato in listaDatos)
            {
                sumapotencias += Math.Pow((dato - prom), 2);
            }
            desvStd = Math.Sqrt((1 * sumapotencias) / NrestadoUno);

            if (double.IsNaN(desvStd))
                desvStd = listaDatos[0];

            return desvStd;
        }

        #endregion

    }
}
