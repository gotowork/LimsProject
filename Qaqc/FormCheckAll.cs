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

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Columns;

using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.Controls;

namespace LimsProject
{
    public delegate void OpenBatch(long idbatch, string nom_tray);
    public delegate void CloseParent(System.Windows.Forms.DialogResult dlg);

    public partial class FormCheckAll: Form
    {
        #region attributes

        public long Idbatch { get; set; }
        public int Idtemplate_method { get; set; }
        public long Idrecep_sample_detail_elem { get; set; }
        public int Idretest { get; set; }
        public Comun.TypeSample TypeSample { get; set; }

        #endregion 

        #region event of delegates

        public event OpenBatch evenOpenBatch;
        public event CloseParent evenCloseParent;

        #endregion

        #region properties

        public Comun.WindowsTray Windows_current { get; set; } 

        public string Text_obs
        {
            get
            {
                return tbObservation.Text;
            }
            set 
            {
                tbObservation.Text = value;
            }
        }

        public bool EnableRetest
        {
            get{
                return ckEnableRetest.Checked;
            }
            set {
                ckEnableRetest.Checked = value;
            }
        }

        #endregion 

        #region constructor

        public FormCheckAll()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        void LoadQaqcStatus()
        {
            if (TypeSample == Comun.TypeSample.Sample)
            {

                // --- get repetitions
                repRepetition.DataSource = Comun.ListTypeRepetition;
                repRepetition.DisplayMember = "Name_repetition";
                repRepetition.ValueMember = "Cod_repetition";

                // --- get methods
                CTemplate_methodFactory faTemplate_method = new CTemplate_methodFactory();
                CTemplate_method oTemplate_method = faTemplate_method.GetByPrimaryKey(new CTemplate_methodKeys(Idtemplate_method));
                Methods oMethods = new Methods();

                gcMethods.DataSource = oMethods.GetAllLastVersionMethods(Convert.ToInt32(oTemplate_method.Idelement), oTemplate_method.Cod_type_sample);

                // --- assign to popup controls
                // observation
                Idtemplate_method = Convert.ToInt32(gvMethods.GetFocusedRowCellValue(gcMet_Idtemplate_method));
                tbObservation.Text = Text_obs;

                // method
                if (Idretest > 0)
                {
                    faTemplate_method = new CTemplate_methodFactory();
                    oTemplate_method = faTemplate_method.GetByPrimaryKey(new CTemplate_methodKeys(Idretest));

                    tbCod_method.Text = oTemplate_method.Cod_template_method;
                    tbAbbrevMethod.Text = oTemplate_method.Abbreviation;
                    ckEnableRetest.Checked = true;
                }
                else
                {
                    faTemplate_method = new CTemplate_methodFactory();
                    oTemplate_method = faTemplate_method.GetByPrimaryKey(new CTemplate_methodKeys(Idtemplate_method));

                    tbCod_method.Text = oTemplate_method.Cod_template_method;
                    tbAbbrevMethod.Text = oTemplate_method.Abbreviation;
                    ckEnableRetest.Checked = false;
                    ckChangeMethod.Checked = false;
                }

                // --- get retest
                #region codigo anterior

                /*
                 CREATE OR REPLACE FUNCTION public.sp_retest_getBySample(p_idrecep_sample_detail_elem bigint, p_idbatch bigint) 
                returns TABLE ("Idbatch" BIGINT, "Num_tray" VARCHAR, "Idrecep_sample_detail_elem" BIGINT, "Idrecep_sample_detail" BIGINT
                ,"Cod_module" VARCHAR, "Cod_process" VARCHAR, "Status_process" CHAR, "Result_analysis" DECIMAL
                , "Str_result_analysis" VARCHAR, "Status_result" int, "Cod_sample" VARCHAR
                , "Flag_current_batch" boolean 
                )AS $$
                BEGIN
	                -- 
	                CREATE TEMP TABLE tmp_batch ON COMMIT DROP AS
	                SELECT origin_batch as idbatch, idrecep_sample_detail_elem, idrecep_sample_detail
	                FROM retest
	                WHERE (origin_batch = p_idbatch OR destiny_batch = p_idbatch)
	                UNION ALL
	                SELECT destiny_batch as idbatch, idrecep_sample_detail_elem, idrecep_sample_detail
	                FROM retest
	                WHERE (destiny_batch = p_idbatch OR origin_batch = p_idbatch);	

	                RETURN QUERY
	                SELECT DISTINCT t1.idbatch, CAST(LPAD(CAST(t2.num_tray AS VARCHAR), 5, '0') AS VARCHAR), t1.idrecep_sample_detail_elem, t4.idrecep_sample_detail
		                , t2.cod_module, t2.cod_process, t2.status_process, t3.result_analysis
		                , t3.str_result_analysis, COALESCE(CAST(t3.Qaqc_status_result AS INT), 0) as ER, t3.cod_sample		                
		                , CAST(CASE
			                WHEN t1.idbatch = p_idbatch THEN 1
			                ELSE 0
		                  END AS BOOLEAN) AS flag_current_batch		
	                FROM tmp_batch t1
		                INNER JOIN batch t2
			                ON t1.idbatch = t2.idbatch
		                LEFT OUTER JOIN batch_detail_aa_twofold t3
			                ON t2.idbatch = t3.idbatch
			                AND t1.idrecep_sample_detail_elem = t3.idrecep_sample_detail_elem
		                LEFT OUTER JOIN recep_sample_detail t4
			                ON t1.idrecep_sample_detail = t4.idrecep_sample_detail
	                WHERE t1.idrecep_sample_detail_elem = p_idrecep_sample_detail_elem;

                END;
                $$ LANGUAGE plpgsql; 
                */

                #endregion 

                var tmp_batch =
                    (from m in new CRetestFactory().GetAll().Where(x => x.Origin_batch == Idbatch || x.Destiny_batch == Idbatch)
                     select new { idbatch = m.Origin_batch, m.Idrecep_sample_detail_elem, m.Idrecep_sample_detail })
                     .Union(from m in new CRetestFactory().GetAll().Where(x => x.Destiny_batch == Idbatch || x.Origin_batch == Idbatch)
                            select new { idbatch = m.Destiny_batch, m.Idrecep_sample_detail_elem, m.Idrecep_sample_detail });

                var query2 =
                    (from m in tmp_batch.Where(x => x.Idrecep_sample_detail_elem == Idrecep_sample_detail_elem)
                     from n in new CBatchFactory().GetAll().Where(x => x.Idbatch == m.idbatch)
                     join p in new CBatch_detail_aa_twofoldFactory().GetAll()
                        on new { field1 = m.idbatch, field2 = m.Idrecep_sample_detail_elem } 
                            equals new { field1 = p.Idbatch, field2 = p.Idrecep_sample_detail_elem } into np
                     from q in np.DefaultIfEmpty()
                     join r in new CRecep_sample_detailFactory().GetAll()
                        on q.Idrecep_sample_detail equals r.Idrecep_sample_detail into qr
                     from s in qr
                     select new
                     {
                         m.idbatch,
                         Num_tray = n.Num_tray.ToString().PadLeft(5, '0'),
                         m.Idrecep_sample_detail_elem,
                         m.Idrecep_sample_detail,
                         n.Cod_module,
                         n.Cod_process,
                         n.Status_process,
                         q.Result_analysis,
                         q.Str_result_analysis,
                         Status_result = q == null ? 0 : q.Qaqc_status_result,
                         q.Cod_sample,
                         Flag_current_batch = m.idbatch == Idbatch ? true : false
                     }).Distinct();

                gcListRetest.DataSource = query2;

                Show_controls(Windows_current);
            }
            else
            {
                // --- reensayo de muestras de control de encontrar algún error
                gcObservation.Visible = false;
                ckEnableRetest.Visible = false;
                xtraTabControl1.TabPages[0].Text = "Reensayo de Bandeja";
                xtraTabControl1.TabPages[1].PageVisible = false;

                // --- get repetitions
                repRepetition.DataSource = Comun.ListTypeRepetition;
                repRepetition.DisplayMember = "Name_repetition";
                repRepetition.ValueMember = "Cod_repetition";

                // --- get methods
                CTemplate_methodFactory faTemplate_method = new CTemplate_methodFactory();
                CTemplate_method oTemplate_method = faTemplate_method.GetByPrimaryKey(new CTemplate_methodKeys(Idtemplate_method));
                Methods oMethods = new Methods();

                gcMethods.DataSource = oMethods.GetAllLastVersionMethods(Convert.ToInt32(oTemplate_method.Idelement), oTemplate_method.Cod_type_sample);

                // --- assign to popup controls
                // observation
                Idtemplate_method = Convert.ToInt32(gvMethods.GetFocusedRowCellValue(gcMet_Idtemplate_method));
                tbObservation.Text = Text_obs;

                // method
                faTemplate_method = new CTemplate_methodFactory();
                oTemplate_method = faTemplate_method.GetByPrimaryKey(new CTemplate_methodKeys(Idtemplate_method));

                tbCod_method.Text = oTemplate_method.Cod_template_method;
                tbAbbrevMethod.Text = oTemplate_method.Abbreviation;
                ckEnableRetest.Checked = true;
                ckChangeMethod.Checked = false;
                ckEnableRetest.Visible = false;
            }
        }

        public void Show_controls(Comun.WindowsTray window)
        {
            if (window == Comun.WindowsTray.PendingApprove)
            {
                this.Text = "Aprobar";
                gvListRetest.OptionsBehavior.Editable = false;
                btOkLstRetest.Enabled = false;                
            }
            else
            {
                this.Text = "Revisar";
                if (Has_wait_samples())
                {
                    gvListRetest.OptionsBehavior.Editable = false;
                    btOkLstRetest.Enabled = false;
                }
                else 
                {
                    gvListRetest.OptionsBehavior.Editable = true;
                    btOkLstRetest.Enabled = true;
                }
            }
        }

        public bool Has_wait_samples()
        {
            for (int i = 0; i < gvListRetest.RowCount; i++)
            {
                if (Convert.ToInt16(gvListRetest.GetRowCellValue(i, gcLRet_StatusResult)) == 0)
                    return true;
            }
            return false;
        }

        public void SaveStatusResultRetest()
        {
            // --- save 
            try
            {
                for (int i = 0; i < gvListRetest.RowCount; i++)
                {
                    CBatch_result_aa_qaqcFactory faBatch_result_aa_qaqc = new CBatch_result_aa_qaqcFactory();
                    long? idbatch = Convert.ToInt64(gvListRetest.GetRowCellValue(i, gcLRet_Idbatch));
                    long? idrecep_sample_detail = Convert.ToInt64(gvListRetest.GetRowCellValue(i, gcLRet_Idrecep_sample_detail));
                    long? idrecep_sample_detail_elem = Convert.ToInt64(gvListRetest.GetRowCellValue(i, gcLRet_Idrecep_sample_detail_elem));
                    short status_result = Convert.ToInt16(gvListRetest.GetRowCellValue(i, gcLRet_StatusResult));
                    string str_result_analysis = gvListRetest.GetRowCellValue(i, gcLRet_Law).ToString();
                    decimal result_analysis = Convert.ToDecimal(gvListRetest.GetRowCellValue(i, gcLRet_Result_analysis));

                    var query =
                        (from m in new CBatch_detail_aa_twofoldFactory().GetAll()
                         where m.Idbatch == idbatch && m.Idrecep_sample_detail == idrecep_sample_detail
                            && m.Idrecep_sample_detail_elem == idrecep_sample_detail_elem
                         select m).ToList();

                    foreach (var item in query)
                    {
                        item.Qaqc_status_result = status_result;
                        item.Qaqc_review = true;
                        new CBatch_detail_aa_twofoldFactory().Update(item);
                    }

                    var query2 =
                        (from m in new CRecep_sample_detail_elemFactory().GetAll()
                         where m.Idrecep_sample_detail_elem == idrecep_sample_detail_elem
                         select m).ToList();

                    foreach (var item in query2)
                    {
                        item.Str_result_analysis = str_result_analysis;
                        item.Result_analysis = result_analysis;
                        new CRecep_sample_detail_elemFactory().Update(item);
                    }                                        
                }
            }
            catch (Exception ex) {
                Comun.Send_message(this.Text, TypeMsg.error, ex.InnerException.ToString());
            }
        }

        #endregion

        #region events

        private void ckChangeMethod_CheckedChanged(object sender, EventArgs e)
        {
            paChooseMethod.Visible = ckChangeMethod.Checked;
            CTemplate_method_aaFactory faTemplate_method_aa = new CTemplate_method_aaFactory();
            object obj = gvMethods.GetFocusedRowCellValue(gcMet_Idtemplate_method);

            if (obj != null)
            {
                if (gvMethods.RowCount > 0)                
                    ShowColumnsByTypeAnalysis(Comun.GetTypeAnalysis(Convert.ToChar(gvMethods.GetFocusedRowCellValue(gcMet_Type_analisys))));
            }
        }

        private void ckEnableRetest_CheckedChanged(object sender, EventArgs e)
        {
            paDefaultMethod.Enabled = ckEnableRetest.Checked;
        }

        private void gvMethods_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {            
            // --- get type method            
            ShowColumnsByTypeAnalysis(Comun.GetTypeAnalysis(Convert.ToChar(gvMethods.GetFocusedRowCellValue(gcMet_Type_analisys))));
        }

        void ShowColumnsByTypeAnalysis(Comun.TypeAnalysis type_analysis)
        {
            switch (type_analysis)
            {
                case Comun.TypeAnalysis.AbsorcionAtomica:
                    ShowColumnsAA();
                    break;
                case Comun.TypeAnalysis.Volumetria:
                    ShowColumnsVC();
                    break;
                case Comun.TypeAnalysis.Gravimetria:
                    ShowColumnsGR();
                    break;
                case Comun.TypeAnalysis.NewmontAA:
                    ShowColumnsNewmontAA();
                    break;
                case Comun.TypeAnalysis.NewmontGr:
                    ShowColumnsNewmontGR();
                    break;
            }
        }

        void ShowColumnsAA()
        {
            // --- get columns
            CTemplate_method_aaFactory faTemplate_method_aa = new CTemplate_method_aaFactory();
            Methods oMethods = new Methods();
            
            gcMethodsDetail.DataSource = oMethods.GetMethodsAbsorcionAtomica(Convert.ToInt32(gvMethods.GetFocusedRowCellValue(gcMet_Idtemplate_method)));

            // --- set caption columns
            cvMethodsDetail.Columns["Idtemplate_method"].Caption = "";
            cvMethodsDetail.Columns["Num_version"].Caption = "Versión";
            cvMethodsDetail.Columns["Cod_template_method"].Caption = "Código";
            cvMethodsDetail.Columns["Name_repetition"].Caption = "N°Repeticiones";
            cvMethodsDetail.Columns["Title"].Caption = "Título";
            cvMethodsDetail.Columns["Abbreviation"].Caption = "Abreviación";            
            cvMethodsDetail.Columns["Name_type_analysis"].Caption = "Tipo de análisis";
            cvMethodsDetail.Columns["Name_type_sample"].Caption = "Tipo de muestra";
            cvMethodsDetail.Columns["Name_digestion"].Caption = "Tipo de digestión";
            cvMethodsDetail.Columns["Name_unit_result"].Caption = "Unidad";
            cvMethodsDetail.Columns["Weight"].Caption = "Peso";
            cvMethodsDetail.Columns["Volumen"].Caption = "Volumen";
            cvMethodsDetail.Columns["Reading_min"].Caption = "Lectura Mínima";
            cvMethodsDetail.Columns["Reading_max"].Caption = "Lectura Máxima";
            cvMethodsDetail.Columns["Dilution2"].Caption = "Dilución2";
            cvMethodsDetail.Columns["Dilution3"].Caption = "Dilución3";
            cvMethodsDetail.Columns["Reason_rep"].Caption = "Razón Repetibilidad";
            cvMethodsDetail.Columns["Law_limit_bottom"].Caption = "Ley Mínima";
            cvMethodsDetail.Columns["Law_limit_top"].Caption = "Ley Máxima";
            cvMethodsDetail.Columns["Name_unit_calib"].Caption = "Unidad de calibración";

            // --- set visible columns
            cvMethodsDetail.Columns["Idtemplate_method"].Visible = false;
            cvMethodsDetail.Columns["Num_version"].Visible = true;
            cvMethodsDetail.Columns["Cod_template_method"].Visible = true;
            cvMethodsDetail.Columns["Name_repetition"].Visible = true;
            cvMethodsDetail.Columns["Title"].Visible = true;
            cvMethodsDetail.Columns["Abbreviation"].Visible = true;            
            cvMethodsDetail.Columns["Name_type_analysis"].Visible = true;
            cvMethodsDetail.Columns["Name_type_sample"].Visible = true;
            cvMethodsDetail.Columns["Name_digestion"].Visible = true;
            cvMethodsDetail.Columns["Name_unit_result"].Visible = true;
            cvMethodsDetail.Columns["Weight"].Visible = true;
            cvMethodsDetail.Columns["Volumen"].Visible = true;
            cvMethodsDetail.Columns["Reading_min"].Visible = true;
            cvMethodsDetail.Columns["Reading_max"].Visible = true;
            cvMethodsDetail.Columns["Dilution2"].Visible = true;
            cvMethodsDetail.Columns["Dilution3"].Visible = true;
            cvMethodsDetail.Columns["Reason_rep"].Visible = true;
            cvMethodsDetail.Columns["Law_limit_bottom"].Visible = true;
            cvMethodsDetail.Columns["Law_limit_top"].Visible = true;
            cvMethodsDetail.Columns["Name_unit_calib"].Visible = true;
        }

        void ShowColumnsVC()
        { 
        }

        void ShowColumnsGR()
        { 
        }

        void ShowColumnsNewmontAA()
        { 
        }

        void ShowColumnsNewmontGR()
        { 
        }

        private void FormPopupRetest_Load(object sender, EventArgs e)
        {
            LoadQaqcStatus();
        }

        private void repGoBatch_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            evenOpenBatch(Convert.ToInt64(gvListRetest.GetFocusedRowCellValue(gcLRet_Idbatch)), gvListRetest.GetFocusedRowCellValue(gcLRet_Num_tray).ToString());
        }

        private void btOkObs_Click(object sender, EventArgs e)
        {
            if (ckEnableRetest.Checked || tbObservation.Text.Trim().Length > 0)
                evenCloseParent(System.Windows.Forms.DialogResult.OK);
            else
                Comun.Send_message(this.Text, TypeMsg.error, "Para continuar debe ingresar una observación o habilitar un reensayo.");
        }

        private void tbCancelar_Click(object sender, EventArgs e)
        {
            evenCloseParent(System.Windows.Forms.DialogResult.Cancel);
        }

        #endregion 

        private void btOkLstRetest_Click(object sender, EventArgs e)
        {
            SaveStatusResultRetest();

            evenCloseParent(System.Windows.Forms.DialogResult.OK);
        }

        private void btCancelLstRetest_Click(object sender, EventArgs e)
        {
            evenCloseParent(System.Windows.Forms.DialogResult.Cancel);
        }

    }
}
