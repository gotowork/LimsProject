using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using LimsProject.BusinessLayer;
using LimsProject.BusinessLayer.Modules;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace LimsProject
{

    public class CDataBatch
    {
        #region attributes

        BindingList<CBatch_detail_aa_twofold> dtPivotBatch = new BindingList<CBatch_detail_aa_twofold>();
        int Idtemplate_method = 0;

        #endregion

        #region properties

        public int Count_Repetition { get; private set; }
        public long Idbatch { get; set; }
        public decimal Absorbance { get; set; }
        public decimal StdVerification { get; set; }
        public decimal MriMeasured { get; set; }
        public decimal LrbMeasured { get; set; }
        public System.Drawing.Color ColorAbsorbance { get; set; }
        public System.Drawing.Color ColorStd { get; set; }
        public System.Drawing.Color ColorMriMeasured { get; set; }
        public System.Drawing.Color ColorLrbMeasured { get; set; }

        public CBatch Batch
        {
            get {
                if (Idbatch > 0)
                    return new CBatchFactory().GetByPrimaryKey(new CBatchKeys(Idbatch));
                return null;
            }
        }

        private Comun.StatusWork TypeBatch { get; set; }


        Comun.CriteriaSort criteria_sort = Comun.CriteriaSort.BySample;
        public Comun.CriteriaSort CriteriaSort
        {
            get
            {
                return criteria_sort;
            }
            set
            {
                criteria_sort = value;                
                ApplyCriteriaSort();
            }
        }

        public BindingList<CBatch_detail_aa_twofold> ListSamples
        {
            get
            {
                return new BindingList<CBatch_detail_aa_twofold>(dtPivotBatch.OrderBy(c => c.Order_sample_batch).ToList());                
            }
        }

        void ApplyCriteriaSort()
        {
            CBatch_detail_aa_twofoldFactory faBatch_detail_aa_twofold = new CBatch_detail_aa_twofoldFactory();

            // --- get by a criteria sort
            var query = GetListByCriteriaSort();

            // --- assign new order sample
            short count = 1;
            foreach (var varitem in query)
            {
                CBatch_detail_aa_twofold item = varitem as CBatch_detail_aa_twofold;
                item.Order_sample_batch = count;
                faBatch_detail_aa_twofold.Update(item);
                count++;
            }

            // --- get source data
            dtPivotBatch =
                new BindingList<CBatch_detail_aa_twofold>(
                    faBatch_detail_aa_twofold
                    .GetAll()
                    .Where(c => c.Idbatch == Idbatch && c.Idtemplate_method == Idtemplate_method).ToList());
        }

        BindingList<CBatch_detail_aa_twofold> GetListByCriteriaSort()
        {
            if (CriteriaSort == Comun.CriteriaSort.BySample)
                return new BindingList<CBatch_detail_aa_twofold>(dtPivotBatch.OrderBy(c => c.Cod_interno).ToList());
            else
                return new BindingList<CBatch_detail_aa_twofold>(dtPivotBatch.OrderBy(c => c.Order_des_sample).ToList());
        }

        #endregion        

        public CDataBatch(long p_idbatch, int p_idtemplate_method, Comun.StatusWork statusWork, Comun.CriteriaSort criteriaSort)
        {
            Idtemplate_method = p_idtemplate_method;
            Idbatch = p_idbatch;
            TypeBatch = statusWork;
            CriteriaSort = criteriaSort;
            CBatch_detail_aa_twofoldFactory faBatch_detail_aa_twofold = new CBatch_detail_aa_twofoldFactory();
            dtPivotBatch = 
                new BindingList<CBatch_detail_aa_twofold>(
                    faBatch_detail_aa_twofold
                    .GetAll()
                    .Where(c => c.Idbatch == p_idbatch && c.Idtemplate_method == p_idtemplate_method).ToList());

            ExecuteQaqc(statusWork);
        }        

        CEvaluatorBatch oEvaluatorBatch;
        CQualityControl oQualitycontrol;

        public void ExecuteQaqc(Comun.StatusWork statusWork)
        {
            if (statusWork == Comun.StatusWork.Waiting)
            {
                oQualitycontrol = new CQualityControl(ListSamples, Idtemplate_method);
                RefreshQaqcSummary();
            }
            else
                RefreshQaqcSummary();
        }

        public void RefreshQaqcSummary()
        {
            CBatch oBatch = new CBatchFactory().GetByPrimaryKey(new CBatchKeys(Idbatch));
            Absorbance = oBatch.Absorvance == null ? 0 : Convert.ToDecimal(oBatch.Absorvance);
            StdVerification = oBatch.Std_verification == null ? 0 : Convert.ToDecimal(oBatch.Std_verification);
            MriMeasured = oBatch.Mri_measured == null ? 0 : Convert.ToDecimal(oBatch.Mri_measured);
            LrbMeasured = oBatch.Lrb_measured == null ? 0 : Convert.ToDecimal(oBatch.Lrb_measured);

            // --- absorbance
            if (oBatch.Flag_correct_abs == null)
                ColorAbsorbance = Color.White;
            else if (oBatch.Flag_correct_abs == true)
                ColorAbsorbance = Comun.ColorVerde;
            else
                ColorAbsorbance = Comun.ColorRojo;

            // --- std 
            if (oBatch.Flag_correct_std == null)
                ColorStd = Color.White;
            else if (oBatch.Flag_correct_std == true)
                ColorStd = Comun.ColorVerde;
            else
                ColorStd = Comun.ColorRojo;

            // --- mri
            if (oBatch.Flag_correct_mri == null)
                ColorMriMeasured = Color.White;
            else if (oBatch.Flag_correct_mri == true)
                ColorMriMeasured = Comun.ColorVerde;
            else
                ColorMriMeasured = Comun.ColorRojo;

            // --- lrb
            if (oBatch.Flag_correct_lrb == null)
                ColorLrbMeasured = Color.White;
            else if (oBatch.Flag_correct_lrb == true)
                ColorLrbMeasured = Comun.ColorVerde;
            else
                ColorLrbMeasured = Comun.ColorRojo;            
        }

        public void ExecuteExpEval(int rowhandle)
        {
            // --- eval formula expression 
            oEvaluatorBatch = new CEvaluatorBatch(ListSamples, rowhandle);
        }

        public void ExecuteQaqc(int rowhandle)
        {
            // --- eval qaqc
            //oQualitycontrol = new CQualityControl(ListSamples, rowhandle, Idtemplate_method);
            oQualitycontrol.ApplyQaQcRow(ListSamples[rowhandle]);
            RefreshQaqcSummary();
        }        

        public bool Is_reading_right()
        {
            CTemplate_method_aaFactory faTemplate_method_aa = new CTemplate_method_aaFactory();
            CTemplate_method_aa oTemplate_method_aa = faTemplate_method_aa.GetByPrimaryKey(new CTemplate_method_aaKeys(Idtemplate_method));

            // --- recorring reading columns
            for (int i = 0; i < ListSamples.Count; i++)
            {
                decimal reading1 = Convert.ToDecimal(ListSamples[i].Reading1);
                decimal reading2 = Convert.ToDecimal(ListSamples[i].Reading2);

                if (reading1 <= oTemplate_method_aa.Reading_min || reading1 >= oTemplate_method_aa.Reading_max)
                {
                    ComunForm.Send_message("Formulario de QaQc", TypeMsg.error, "Error: la lectura esta fuera de los límites permitidos.");
                    return false;
                }
                if (reading2 <= oTemplate_method_aa.Reading_min || reading2 >= oTemplate_method_aa.Reading_max)
                {
                    ComunForm.Send_message("Formulario de QaQc", TypeMsg.error, "Error: la lectura esta fuera de los límites permitidos.");
                    return false;
                }
            }
            return true;
        }

        public bool Is_law_right()
        {
            CTemplate_method_aaFactory faTemplate_method_aa = new CTemplate_method_aaFactory();
            CTemplate_method_aa oTemplate_method_aa = faTemplate_method_aa.GetByPrimaryKey(new CTemplate_method_aaKeys(Idtemplate_method));
            
            // --- recorring law columns
            for (int i = 0; i < ListSamples.Count; i++)
            {
                CBatch_detail_aa_twofold row = ListSamples[i];

                decimal law1 = Convert.ToDecimal(row.Law1);
                decimal law2 = Convert.ToDecimal(row.Law2);

                if (law1 <= oTemplate_method_aa.Law_limit_bottom || law1 >= oTemplate_method_aa.Law_limit_top)
                {
                    ComunForm.Send_message("Formulario de QaQc", TypeMsg.error, "Error: la ley esta fuera de los límites permitidos.");
                    return false;
                }
                if (law2 <= oTemplate_method_aa.Law_limit_bottom || law1 >= oTemplate_method_aa.Law_limit_top)
                {
                    ComunForm.Send_message("Formulario de QaQc", TypeMsg.error, "Error: la ley esta fuera de los límites permitidos.");
                    return false;
                }                
            }

            return true;
        }

        public void Save(int position)
        {
            try
            {                             
                CBatch_detail_aa_twofold oBatch_detail_aa_twofold = ((BindingList<CBatch_detail_aa_twofold>)ListSamples)[position];                

                CBatch_detail_aa_twofoldFactory faBatch_detail_aa_twofold = new CBatch_detail_aa_twofoldFactory();                
                faBatch_detail_aa_twofold.Update(oBatch_detail_aa_twofold);

                long Idrecep_sample_detail_elem = Convert.ToInt64(oBatch_detail_aa_twofold.Idrecep_sample_detail_elem);

                // --- register in process,
                LimsProcess.Advance_process(Idbatch, Idrecep_sample_detail_elem, LimsProcess.PROCESS_IN_READING);

            }
            catch (Exception ex)
            {
                Comun.Save_log(ex.InnerException.ToString());
                //throw new Exception("pivot data row::update::Error occured.", ex);
            }
        }

        public void Save()
        {
            try
            {
                for (int i = 0; i < ListSamples.Count; i++)
                {
                    Save(i);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("pivot data::update::Error occured.", ex);
            }
        }        

        public bool ExistErrorBeforeApprove()
        {
            for (int i = 0; i < ListSamples.Count; i++)
            {
                if (Convert.ToInt32(ListSamples[i].Flag_mri) != 1)
                {
                    bool Qaqc_error = Convert.ToBoolean(ListSamples[i].Qaqc_approve);

                    if (!Qaqc_error)
                        return true;
                }
            }
            return false;
        }

        public bool IsSampleControlRight()
        {
            return Is_mri_right() && Is_blk_right();
        }

        public bool Is_mri_right()
        {
            foreach (CBatch_detail_aa_twofold item in ListSamples)
            {
                if (item.Flag_mri == 1)
                {
                    if (item.Qaqc_mr == 2)
                        return false;
                }
            }
            return true;
        }

        public bool Is_blk_right()
        {
            foreach (CBatch_detail_aa_twofold item in ListSamples)
            {
                if (item.Flag_mri == 1)
                {
                    if (item.Qaqc_blk == 2)
                        return false;
                }
            }
            return true;
        }

        public void Approve()
        {
            try
            {
                CBatchFactory faBatch = new CBatchFactory();
                CBatch oBatch = faBatch.GetByPrimaryKey(new CBatchKeys(Idbatch));                

                // --- check parity
                for (int i = 0; i < ListSamples.Count; i++)
                {
                    CBatch_detail_aa_twofold row = ListSamples[i];
                    CBatch_detail_aa_twofoldFactory faBatch_detail_aa_twofold = new CBatch_detail_aa_twofoldFactory();

                    if (Convert.ToInt32(row.Flag_mri) == 0)
                    {
                        // --- reset retest temp configuration
                        row.Qaqc_tmp_retest = 0;
                        row.Qaqc_tmp_retest_idmethod = 0;
                                                                             
                        if (row.Qaqc_error >= 0 && row.Qaqc_error <= 2)
                            row.Qaqc_status_result = 2;
                        else
                        {
                            if (row.Qaqc_error == 4)
                                row.Qaqc_status_result = 4;
                        }

                        faBatch_detail_aa_twofold.Update(row);

                        // --- save retest
                        if (row.Qaqc_error == 2 || row.Qaqc_error == 5)
                        {                            
                            string cod_type_sample = new CTemplate_methodFactory().GetByPrimaryKey(new CTemplate_methodKeys(Convert.ToInt32(row.Idtemplate_method))).Cod_type_sample;
                            CCorrelative oCorrelative = new CCorrelativeFactory().GetByPrimaryKey(new CCorrelativeKeys(cod_type_sample));

                            CBatchManager oBatchManager = new CBatchManager();

                            oBatchManager.CallSaveSampleBatchWithRetest(
                                                    Convert.ToInt32(row.Idtemplate_method),
                                                    Convert.ToInt64(row.Idrecep_sample),
                                                    Convert.ToInt64(row.Idrecep_sample_detail),
                                                    Convert.ToInt64(row.Idrecep_sample_detail_elem),
                                                    Convert.ToInt64(row.Cod_interno),
                                                    row.Cod_sample,
                                                    Comun.GetUser(),
                                                    oCorrelative,
                                                    Convert.ToInt32(row.Qaqc_par),
                                                    Convert.ToInt64(row.Idbatch));
                        }

                        // --- register as finished trace process
                        CProcess_Sample_Manage.Finalize_process(Convert.ToInt64(row.Idrecep_sample_detail_elem), LimsProcess.PROCESS_IN_READING, LimsProcess.PROCESS_APPROVE_SAMPLES);
                    }
                }

                // --- modify the batch status, put in other process    
                CProcess oProcess = new CProcessFactory().GetByPrimaryKey(new CProcessKeys(LimsProcess.PROCESS_APPROVE_SAMPLES));
                oBatch.Status_process = Convert.ToChar(LimsProcess.Status_Process.Waiting);
                oBatch.Cod_module = oProcess.Cod_module;
                oBatch.Cod_area = oProcess.Cod_area;
                oBatch.Cod_process = LimsProcess.PROCESS_APPROVE_SAMPLES;
                oBatch.User_approve_tray = Comun.GetUser();
                oBatch.Date_approve_tray = Comun.GetDate();
                faBatch.Update(oBatch);

                // --- register as finished trace batch
                Cprocess_Batch_Manage.Finalize_process(Idbatch, LimsProcess.PROCESS_IN_READING, LimsProcess.PROCESS_APPROVE_SAMPLES);                

            }
            catch (Exception ex)
            {
                Comun.Save_log(ex.InnerException.ToString());
                throw new Exception("pivot data::approve::Error occured.", ex);
            }
        }

        public void RetestBatch()
        {
            try
            {
                CBatchFactory faBatch = new CBatchFactory();
                CBatch oBatch = faBatch.GetByPrimaryKey(new CBatchKeys(Idbatch));                

                // --- check parity
                for (int i = 0; i < ListSamples.Count; i++)
                {
                    CBatch_detail_aa_twofold row = ListSamples[i];
                    CBatch_detail_aa_twofoldFactory faBatch_detail_aa_twofold = new CBatch_detail_aa_twofoldFactory();

                    if (Convert.ToInt32(row.Flag_mri) == 0)
                    {
                        // --- approved samples with additional retest mark
                        row.Qaqc_has_retest = 1;
                        faBatch_detail_aa_twofold.Update(row);

                        // --- save retest
                        string cod_type_sample = new CTemplate_methodFactory().GetByPrimaryKey(new CTemplate_methodKeys(Convert.ToInt32(row.Idtemplate_method))).Cod_type_sample;
                        CCorrelative oCorrelative = new CCorrelativeFactory().GetByPrimaryKey(new CCorrelativeKeys(cod_type_sample));

                        CBatchManager oBatchManager = new CBatchManager();
                        
                        oBatchManager.CallSaveFromRetestFullBatch(
                            Convert.ToInt32(row.Idtemplate_method),
                            Convert.ToInt64(row.Idrecep_sample),
                            Convert.ToInt64(row.Idrecep_sample_detail),
                            Convert.ToInt64(row.Idrecep_sample_detail_elem),
                            Convert.ToInt64(row.Cod_interno),
                            row.Cod_sample,
                            Comun.GetUser(),
                            oCorrelative,
                            row.Qaqc_par);
                        
                        // --- register as finished trace process
                        CProcess_Sample_Manage.Finalize_process(Convert.ToInt64(row.Idrecep_sample_detail_elem), LimsProcess.PROCESS_IN_READING, LimsProcess.PROCESS_APPROVE_SAMPLES);
                    }
                }

                // --- modify the batch status, put in other process
                CProcess oProcess = new CProcessFactory().GetByPrimaryKey(new CProcessKeys(LimsProcess.PROCESS_APPROVE_SAMPLES));
                oBatch.Status_process = Convert.ToChar(LimsProcess.Status_Process.Waiting);
                oBatch.Cod_module = oProcess.Cod_module;
                oBatch.Cod_area = oProcess.Cod_area;
                oBatch.Cod_process = LimsProcess.PROCESS_APPROVE_SAMPLES;
                oBatch.User_approve_tray = Comun.GetUser();
                oBatch.Date_approve_tray = Comun.GetDate();
                faBatch.Update(oBatch);

                // --- register as finished trace batch
                Cprocess_Batch_Manage.Finalize_process(Idbatch, LimsProcess.PROCESS_IN_READING, LimsProcess.PROCESS_APPROVE_SAMPLES);
                

            }
            catch (Exception ex)
            {
                Comun.Save_log(ex.InnerException.ToString());
                throw new Exception("pivot data::approve::Error occured.", ex);
            }
        }

        public void Review()
        {
            try
            {
                CBatchFactory faBatch = new CBatchFactory();
                CBatch oBatch = faBatch.GetByPrimaryKey(new CBatchKeys(Idbatch));

                // --- save trace
                CRecep_sample_detail_elemFactory faRecep_sample_detail_elem = new CRecep_sample_detail_elemFactory();

                for (int i = 0; i < ListSamples.Count; i++)
                {
                    CBatch_detail_aa_twofold current_row = ListSamples[i];
                                        
                    int status_result = Convert.ToInt32(current_row.Qaqc_status_result);

                    if (Convert.ToInt32(current_row.Flag_mri) == 0)
                    {
                        // --- set how accepted sample
                        // Espera = 0,
                        // Incorrecto = 1,
                        // Plausible = 2,
                        // Aceptado = 3,
                        // IncorrectoPlausible = 4,
                        // Espera reensayos = 5
                        // --- save only the accept samples
                        long Idrecep_sample_detail_elem = Convert.ToInt64(current_row.Idrecep_sample_detail_elem);

                        if (Convert.ToBoolean(oBatch.Flag_correct_mri) && Convert.ToBoolean(oBatch.Flag_correct_lrb))
                        {

                            if (status_result == Convert.ToInt32(Comun.Status_result.Plausible))
                                current_row.Qaqc_status_result = Convert.ToInt16(Comun.Status_result.Aceptado);

                            Qaqc oQaqc = new Qaqc();
                            if (!oQaqc.IsRetest(Idrecep_sample_detail_elem, Idbatch))
                            {
                                // --- save final element law
                                if (current_row.Qaqc_status_result == Convert.ToInt16(Comun.Status_result.Aceptado))
                                {
                                    CRecep_sample_detail_elem oRecep_sample_detail_elem = faRecep_sample_detail_elem.GetByPrimaryKey(new CRecep_sample_detail_elemKeys(Idrecep_sample_detail_elem));
                                    oRecep_sample_detail_elem.Result_analysis = current_row.Result_analysis;
                                    oRecep_sample_detail_elem.Str_result_analysis = current_row.Str_result_analysis.ToString();
                                    oRecep_sample_detail_elem.With_result = true;
                                    if (current_row.Str_result_analysis == null)
                                        oRecep_sample_detail_elem.With_result = false;
                                    faRecep_sample_detail_elem.Update(oRecep_sample_detail_elem);
                                }
                                CBatch_detail_aa_twofoldFactory faBatch_detail_aa_twofold = new CBatch_detail_aa_twofoldFactory();
                                faBatch_detail_aa_twofold.Update(current_row);
                            }
                            else// --- es un reensayo
                            {
                                if (!oQaqc.ExistsResultPendingSel(Idrecep_sample_detail_elem, Idbatch))
                                {
                                    // --- si no está pendiente de seleccionar entre varios análisis
                                    // --- save final element law
                                    if (current_row.Qaqc_status_result == Convert.ToInt16(Comun.Status_result.Aceptado))
                                    {
                                        CRecep_sample_detail_elem oRecep_sample_detail_elem = faRecep_sample_detail_elem.GetByPrimaryKey(new CRecep_sample_detail_elemKeys(Idrecep_sample_detail_elem));
                                        oRecep_sample_detail_elem.Result_analysis = current_row.Result_analysis;
                                        oRecep_sample_detail_elem.Str_result_analysis = current_row.Str_result_analysis.ToString();
                                        oRecep_sample_detail_elem.With_result = true;
                                        if (current_row.Str_result_analysis == null)
                                            oRecep_sample_detail_elem.With_result = false;
                                        faRecep_sample_detail_elem.Update(oRecep_sample_detail_elem);
                                    }
                                    CBatch_detail_aa_twofoldFactory faBatch_detail_aa_twofold = new CBatch_detail_aa_twofoldFactory();
                                    faBatch_detail_aa_twofold.Update(current_row);
                                }
                            }

                            // --- save retest
                            if (current_row.Qaqc_tmp_retest == 1)
                            {
                                string cod_type_sample = new CTemplate_methodFactory().GetByPrimaryKey(new CTemplate_methodKeys(Convert.ToInt32(current_row.Idtemplate_method))).Cod_type_sample;
                                CCorrelative oCorrelative = new CCorrelativeFactory().GetByPrimaryKey(new CCorrelativeKeys(cod_type_sample));

                                CBatchManager oBatchManager = new CBatchManager();

                                oBatchManager.CallSaveSampleBatchWithRetest(
                                    Convert.ToInt32(current_row.Idtemplate_method),
                                    Convert.ToInt64(current_row.Idrecep_sample),
                                    Convert.ToInt64(current_row.Idrecep_sample_detail),
                                    Convert.ToInt64(current_row.Idrecep_sample_detail_elem),
                                    Convert.ToInt64(current_row.Cod_interno),
                                    current_row.Cod_sample,
                                    Comun.GetUser(),
                                    oCorrelative, Convert.ToInt32(current_row.Qaqc_par), Idbatch);
                            }
                            
                            // --- register as finished trace process
                            CProcess_Sample_Manage.Finalize_process(Idrecep_sample_detail_elem, LimsProcess.PROCESS_APPROVE_SAMPLES, LimsProcess.PROCESS_ACCEPT_RESULTS);
                        }
                        else
                        {
                            // --- the samples pertain to batch with full batch retest
                            CProcess_Sample_Manage.Finalize_process(Idrecep_sample_detail_elem, LimsProcess.PROCESS_APPROVE_SAMPLES, LimsProcess.PROCESS_ACCEPT_RESULTS);
                        }
                        
                    }
                }

                // --- modify the batch status, put in other process    
                CProcess oProcess = new CProcessFactory().GetByPrimaryKey(new CProcessKeys(LimsProcess.PROCESS_ACCEPT_RESULTS));
                oBatch.Status_process = Convert.ToChar(LimsProcess.Status_Process.Waiting);
                oBatch.Cod_module = oProcess.Cod_module;
                oBatch.Cod_area = oProcess.Cod_area;
                oBatch.Cod_process = LimsProcess.PROCESS_ACCEPT_RESULTS;
                oBatch.User_review_tray = Comun.GetUser();
                oBatch.Date_review_tray = Comun.GetDate();
                faBatch.Update(oBatch);

                // --- register as finished trace batch
                Cprocess_Batch_Manage.Finalize_process(Idbatch, LimsProcess.PROCESS_APPROVE_SAMPLES, LimsProcess.PROCESS_ACCEPT_RESULTS);

            }
            catch (Exception ex)
            {
                Comun.Save_log(ex.InnerException.ToString());
                throw new Exception("pivot data::approve::Error occured.", ex);
            }
        }

        public void UpdateStatusResult(long p_idbatch, long p_idrecep_sample_detail, long p_idrecep_sample_detail_elem, short p_status_result, string p_str_result_analysis, decimal p_result_analysis)
        {            
            CBatch_detail_aa_twofoldFactory faBatch_detail_aa_twofold = new CBatch_detail_aa_twofoldFactory();
            List<CBatch_detail_aa_twofold> lst =
                ListSamples.Where(c => c.Idbatch == p_idbatch
                    && c.Idrecep_sample_detail == p_idrecep_sample_detail
                    && c.Idrecep_sample_detail_elem == p_idrecep_sample_detail_elem).ToList();

            foreach (CBatch_detail_aa_twofold item in lst)
            {
                item.Qaqc_review = true;
                item.Qaqc_status_result = p_status_result;
                faBatch_detail_aa_twofold.Update(item);
            }

            CRecep_sample_detail_elemFactory faRecep_sample_detail_elem = new CRecep_sample_detail_elemFactory();
            List<CRecep_sample_detail_elem> lst2 =
                faRecep_sample_detail_elem.GetAll().Where(c => c.Idrecep_sample_detail_elem == p_idrecep_sample_detail_elem).ToList();

            foreach (CRecep_sample_detail_elem item in lst2)
            {
                item.Str_result_analysis = p_str_result_analysis;
                item.Result_analysis = p_result_analysis;
                faRecep_sample_detail_elem.Update(item);
            }            
        }

        public void MovePositionRow(CBatch_detail_aa_twofold row_ini, CBatch_detail_aa_twofold row_end)
        {
            CBatch_detail_aa_twofoldFactory faBatch_detail_aa_twofold = new CBatch_detail_aa_twofoldFactory();
            BindingList<CBatch_detail_aa_twofold> lst = new BindingList<CBatch_detail_aa_twofold>(ListSamples);

            // --- copiar muestra drag como temporal
            CBatch_detail_aa_twofold tmp_row_ini = lst.Single(c => c.Cod_interno == row_ini.Cod_interno);
            CBatch_detail_aa_twofold tmp_row_end = lst.Single(c => c.Cod_interno == row_end.Cod_interno);

            // --- quitar muestra drag de la lista
            lst.Remove(tmp_row_ini);

            // --- obetener indice o posición a donde será movido
            int new_index_end = lst.IndexOf(tmp_row_end);

            // --- insertar la muestra que fue removida
            lst.Insert(new_index_end, tmp_row_ini);            

            // --- reset orden de las muestras
            short count = 1;
            foreach (CBatch_detail_aa_twofold item in lst)
            {
                item.Order_sample_batch = count;
                count++;

                faBatch_detail_aa_twofold.Update(item);
            }

            // --- get source data
            dtPivotBatch =
                new BindingList<CBatch_detail_aa_twofold>(
                    faBatch_detail_aa_twofold
                    .GetAll()
                    .Where(c => c.Idbatch == Idbatch && c.Idtemplate_method == Idtemplate_method).ToList());
        }
    }
}
