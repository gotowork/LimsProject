using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LimsProject.BusinessLayer;

namespace LimsProject
{
    #region process management

    public class CProcess_Sample
    {
        public string IDProcess { get; set; }
        public string Process_name { get; set; }
        public CProcess_Sample Prev_process { get; set; }
        public List<CProcess_Sample> Next_process { get; set; }
    }

    public static class CConfigProcess
    {
        public static CProcess_Sample getStartProcess()
        {
            CProcess_Sample oProcess_Recep_Sample = new CProcess_Sample() 
            {  
                IDProcess = LimsProcess.PROCESS_RECEP_SAMPLE.ToString(), 
                Process_name = "Recepción de muestras",                 
            };

            CProcess_Sample oProcess_InCalib = new CProcess_Sample()
            {
                IDProcess = LimsProcess.PROCESS_IN_CALIB.ToString(),
                Process_name = "Proceso de calibración",
            };

            CProcess_Sample oProcess_InReading = new CProcess_Sample()
            {
                IDProcess = LimsProcess.PROCESS_IN_READING.ToString(),
                Process_name = "Proceso de lectura AA"
            };

            CProcess_Sample oProcess_Approve_Samples = new CProcess_Sample()
            {
                IDProcess = LimsProcess.PROCESS_APPROVE_SAMPLES.ToString(),
                Process_name = "Proceso de aprobación de bandeja"
            };

            CProcess_Sample oProcess_Route_Samples = new CProcess_Sample()
            {
                IDProcess = LimsProcess.PROCESS_ROUTE_SAMPLES.ToString(),
                Process_name = "Proceso de encaminar muestras"
            };

            CProcess_Sample oProcess_Recep_Result_Sample = new CProcess_Sample() 
            { 
                IDProcess = LimsProcess.PROCESS_RECEP_RESULT_SAMPLE.ToString(),
                Process_name = "Proceso de recibir leyes como resultado"
            };

            CProcess_Sample oProcess_Partial_Report_Sample = new CProcess_Sample()
            {
                IDProcess = LimsProcess.PROCESS_PARTIAL_REPORT_SAMPLE.ToString(),
                Process_name = "Proceso de reporte parcial para una muestra"
            };

            CProcess_Sample oProcess_Final_Report_Sample = new CProcess_Sample()
            {
                IDProcess = LimsProcess.PROCESS_PARTIAL_REPORT_SAMPLE.ToString(),
                Process_name = "Proceso de reporte final para una muestra"
            };
            
            // --- mapping
            oProcess_Recep_Sample.Next_process.Add(oProcess_InCalib);

            oProcess_InCalib.Next_process.Add(oProcess_InReading);
            oProcess_InCalib.Prev_process = oProcess_Recep_Sample;

            oProcess_InReading.Next_process.Add(oProcess_Approve_Samples);
            oProcess_InReading.Prev_process = oProcess_InCalib;

            oProcess_Approve_Samples.Next_process.Add(oProcess_Route_Samples);
            oProcess_Approve_Samples.Prev_process = oProcess_InReading;

            oProcess_Route_Samples.Next_process.Add(oProcess_Recep_Result_Sample);
            oProcess_Route_Samples.Prev_process = oProcess_Approve_Samples;

            oProcess_Recep_Result_Sample.Next_process.Add(oProcess_Partial_Report_Sample);
            oProcess_Recep_Result_Sample.Next_process.Add(oProcess_Final_Report_Sample);
            oProcess_Partial_Report_Sample.Prev_process = oProcess_Recep_Result_Sample;
            oProcess_Final_Report_Sample.Prev_process = oProcess_Recep_Result_Sample;

            return oProcess_Recep_Sample;
        }
    }

    public static class LimsProcess
    {
        #region attributes

        #endregion 

        #region trace

        // CONSTANTS
        // modules  
        public const string MODULE_RECEPTION_SAMPLE = "M001";
        public const string MODULE_PREP_SAMPLE = "M002";
        public const string MODULE_BALANCE = "M003";
        public const string MODULE_DIGESTION_SAMPLE = "M004";
        public const string MODULE_AA = "M005";
        public const string MODULE_REVITION_DATE = "M006";
        public const string MODULE_EMITION_REPORT = "M007";

        public const string PROCESS_RECEP_SAMPLE = "P001";
        public const string PROCESS_RECEP_RESULT_SAMPLE = "P019";
        public const string PROCESS_PARTIAL_REPORT_SAMPLE = "P020";
        public const string PROCESS_FINAL_REPORT_SAMPLE = "P021";
        public const string PROCESS_IN_CALIB = "P012";
        public const string PROCESS_IN_READING = "P013";
        public const string PROCESS_APPROVE_SAMPLES = "P014";
        public const string PROCESS_ROUTE_SAMPLES = "P015";
        public const string PROCESS_ACCEPT_RESULTS = "P016";

        // MODULE STATUS
        public enum ModuleStatus
        {
            Joined = 1,
            InProcess = 2,
            Finished = 3
        }

        public enum Status_Process
        {
            Waiting = 'W',
            InProcess = 'P',
            Finished = 'F',
            Annulled = 'N'
        }

        #endregion

        public static void Initialize_process(long idbatch, long idrecep_sample_detail_elem, string process)
        {
            Cprocess_Batch_Manage.Initialize_process(idbatch, process);
            CProcess_Sample_Manage.Initialize_process(idrecep_sample_detail_elem, process);
        }

        public static void Finalize_process(long idbatch, long idrecep_sample_detail_elem, string process, string sgtProcess)
        {
            Cprocess_Batch_Manage.Finalize_process(idbatch, process, sgtProcess);
            CProcess_Sample_Manage.Finalize_process(idrecep_sample_detail_elem, process, sgtProcess);
        }

        public static void Advance_process(long idbatch, long idrecep_sample_detail_elem, string process)
        {
            Cprocess_Batch_Manage.Advance_process(idbatch, process);
            CProcess_Sample_Manage.Advance_process(idrecep_sample_detail_elem, process);
        }
    }

    public static class Cprocess_Batch_Manage
    {
        public static void Initialize_process(long idbatch, string process)
        {
            // --- register the finished process,
            CTrace_batchFactory faTrace_batch = new CTrace_batchFactory();
            CTrace_batch oTrace_batch = new CTrace_batch();

            // --- register the initiatied process
            oTrace_batch = new CTrace_batch();
            oTrace_batch.Date_in = Comun.GetDate();
            oTrace_batch.Cod_process = process;
            //oTrace_batch.Cod_module = module;
            oTrace_batch.Idbatch = idbatch;
            oTrace_batch.Status_process = Convert.ToChar(LimsProcess.Status_Process.Waiting);
            oTrace_batch.Usernew = Comun.GetUser();
            oTrace_batch.Datenew = Comun.GetDate();

            faTrace_batch.Insert(oTrace_batch);
        }

        public static void Finalize_process(long idbatch, string process, string sgtProcess)
        {
            CTrace_batchFactory faTrace_batch = new CTrace_batchFactory();

            // --- get a process existing
            CTrace_batch oTrace_batch = new LimsProject.BusinessLayer.Modules.ModProcessBatch().GetLastProcessBatch(process, idbatch);
            CProcess oProcess = new CProcessFactory().GetByPrimaryKey(new CProcessKeys(process));

            if (oTrace_batch == null)
            {
                oTrace_batch = new CTrace_batch();
                oTrace_batch.Date_in = Comun.GetDate();
                oTrace_batch.Usernew = Comun.GetUser();
                oTrace_batch.Idbatch = idbatch;
            }
            
            oTrace_batch.Date_out = Comun.GetDate();
            oTrace_batch.Cod_process = process;            
            //oTrace_batch.Cod_module = modulo;
            oTrace_batch.Useredit = Comun.GetUser();
            oTrace_batch.Status_process = Convert.ToChar(LimsProcess.Status_Process.Finished);

            if (!faTrace_batch.Update(oTrace_batch))
                faTrace_batch.Insert(oTrace_batch);

            // --- create a new process            
            Initialize_process(idbatch, sgtProcess);
        }

        public static void Advance_process(long idbatch, string process)
        {
            CTrace_batchFactory faTrace_batch = new CTrace_batchFactory();

            // --- get a process existing
            CTrace_batch oTrace_batch = new LimsProject.BusinessLayer.Modules.ModProcessBatch().GetLastProcessBatch(process, idbatch);

            if (oTrace_batch == null)
            {
                oTrace_batch = new CTrace_batch();
                oTrace_batch.Date_in = Comun.GetDate();
                oTrace_batch.Usernew = Comun.GetUser();
                oTrace_batch.Idbatch = idbatch;
            }

            oTrace_batch.Cod_process = process;
            //oTrace_batch.Cod_module = module;
            oTrace_batch.Usernew = Comun.GetUser();
            oTrace_batch.Useredit = Comun.GetUser();
            oTrace_batch.Status_process = Convert.ToChar(LimsProcess.Status_Process.InProcess);

            if (!faTrace_batch.Update(oTrace_batch))
                faTrace_batch.Insert(oTrace_batch);
        }
    }

    public static class CProcess_Sample_Manage
    {
        public static void Initialize_process(long idrecep_sample_detail_elem, string process)
        {
            // --- register the finished process,
            CTrace_sample_elemFactory faTrace_sample_elem = new CTrace_sample_elemFactory();
            CTrace_sample_elem oTrace_sample_elem = new CTrace_sample_elem();
            
            // --- register the initiatied process
            oTrace_sample_elem = new CTrace_sample_elem();
            oTrace_sample_elem.Date_in = Comun.GetDate();
            //oTrace_sample_elem.Cod_module = module;
            oTrace_sample_elem.Cod_process = process;
            oTrace_sample_elem.Idrecep_sample_detail_elem = idrecep_sample_detail_elem;
            oTrace_sample_elem.Status_process = Convert.ToChar(LimsProcess.Status_Process.Waiting);
            oTrace_sample_elem.Usernew = Comun.GetUser();
            oTrace_sample_elem.Useredit = Comun.GetUser();

            faTrace_sample_elem.Insert(oTrace_sample_elem);
        }

        public static void Finalize_process(long idrecep_sample_detail_elem, string process, string sgtProcess)
        {
            CTrace_sample_elemFactory faTrace_sample_elem = new CTrace_sample_elemFactory();
            
            // --- get a process existing            
            CTrace_sample_elem oTrace_sample_elem =
                faTrace_sample_elem.GetAll()
                .Where(x => x.Idrecep_sample_detail_elem == idrecep_sample_detail_elem && x.Cod_process == process)
                .OrderBy(x => x.Idtrace_sample_elem).OrderByDescending(x => x.Date_in).FirstOrDefault();

            if (oTrace_sample_elem == null)
            {
                oTrace_sample_elem = new CTrace_sample_elem();
                oTrace_sample_elem.Date_in = Comun.GetDate();
                oTrace_sample_elem.Usernew = Comun.User_system.Cod_user;
                oTrace_sample_elem.Idrecep_sample_detail_elem = idrecep_sample_detail_elem;
                //oTrace_sample_elem.Cod_module = module;
                oTrace_sample_elem.Cod_process = process;
            }

            oTrace_sample_elem.Date_out = Comun.GetDate();
            oTrace_sample_elem.Status_process = Convert.ToChar(LimsProcess.Status_Process.Finished);
            oTrace_sample_elem.Useredit = Comun.GetUser();

            if (!faTrace_sample_elem.Update(oTrace_sample_elem))
                faTrace_sample_elem.Insert(oTrace_sample_elem);

            // --- create a new process
            Initialize_process(idrecep_sample_detail_elem, sgtProcess);
        }

        public static void Advance_process(long idrecep_sample_detail_elem, string process)
        {
            CTrace_sample_elemFactory faTrace_sample_elem = new CTrace_sample_elemFactory();

            // --- get a process existing
            CTrace_sample_elem oTrace_sample_elem =
                faTrace_sample_elem.GetAll()
                .Where(x => x.Idrecep_sample_detail_elem == idrecep_sample_detail_elem && x.Cod_process == process)
                .OrderBy(x => x.Idtrace_sample_elem).OrderByDescending(x => x.Date_in).FirstOrDefault();

            if (oTrace_sample_elem == null)
            {
                oTrace_sample_elem = new CTrace_sample_elem();
                oTrace_sample_elem.Usernew = Comun.GetUser();
                oTrace_sample_elem.Date_in = Comun.GetDate();
            }
                        
            oTrace_sample_elem.Cod_process = process;
            oTrace_sample_elem.Idrecep_sample_detail_elem = idrecep_sample_detail_elem;
            oTrace_sample_elem.Status_process = Convert.ToChar(LimsProcess.ModuleStatus.InProcess);
            oTrace_sample_elem.Useredit = Comun.GetUser();

            if (!faTrace_sample_elem.Update(oTrace_sample_elem))
                faTrace_sample_elem.Insert(oTrace_sample_elem);
        }
    }

    #endregion
}
