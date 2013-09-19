using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
using LimsProject.BusinessLayer.Modules;
using System.Collections;


namespace LimsProject
{
    public partial class FormNewQaQc : LibraryBasicForm.FormMantBase
    {
        #region attributes

        DevExpress.XtraTreeList.Nodes.TreeListNode Focused_batch;
        int Num_repetitions = 0;
        long Idbatch = 0;
        int Idtemplate_method = 0;
        CDataBatch oDataBatch;

        CTemplate_method_aa oTemplate_method_aa_current = new CTemplate_method_aa();
        CTemplate_method oTemplate_method_current = new CTemplate_method();
        

        #endregion

        #region constructor

        public FormNewQaQc()
        {
            InitializeComponent();
        }

        #endregion

        #region methods inherited

        protected override void Recuperar_Registro()
        {
            base.Recuperar_Registro();
        }

        protected override bool Grabar_Registro()
        {
            return base.Grabar_Registro();
        }

        protected override void Eliminar_Registro()
        {
            base.Eliminar_Registro();
        }

        protected override void Limpiar_Campos()
        {
            base.Limpiar_Campos();
        }

        protected override bool Son_Datos_Correctos()
        {
            if (!Is_qaqc_right())
                return false;
            return true;
        }

        #endregion

        #region validations qaqc
        
        public bool Is_qaqc_right()
        {            
            if (!oDataBatch.Is_law_right())
                return false;
            return true;
        }

        #endregion

        #region events

        private void FormQaQc_Load(object sender, EventArgs e)
        {
            treeTrayWaiting.ExpandAll();
            InitCombos();
            //InitTreeBatch(StatusWork.Waiting);
        }

        private void gvBandeja_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            int numImage = 0;
            if (e.DisplayText.Trim() != "")
                numImage = Convert.ToInt32(e.DisplayText);
            DevExpress.XtraGrid.Views.Grid.GridView view = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            //Image icon = ((MyObject)view.GetRow(e.RowHandle)).IconProperty;

            e.Graphics.DrawImage(imageStatus.Images[numImage], new Rectangle(e.Bounds.X, e.Bounds.Y, 17, 17));
            e.Appearance.DrawString(e.Cache, e.DisplayText, new Rectangle(e.Bounds.X + 20, e.Bounds.Y, e.Bounds.Width - 20, e.Bounds.Height));
            e.Handled = true;
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (tabTreeQaqc.SelectedTabPageIndex == 0 && e.Node != null) // 0: the tray is waiting to analize
            {
                if (e.Node.ParentNode == null && e.Node.Level == 0)
                    Focused_batch = e.Node;
                else if (e.Node.Level == 1)
                    Focused_batch = e.Node.ParentNode;
                else
                    Focused_batch = treeTrayWaiting.MoveFirst();

                // --- get data by node selected                

                if (Focused_batch.GetValue("Cod_repetition") != null
                    && Focused_batch.GetValue("Id") != null
                    && Focused_batch.GetValue("Idtemplate_method") != null
                    && Focused_batch.GetValue("Cod_repetition").ToString().Trim().Length != 0
                    && Focused_batch.GetValue("Id").ToString().Trim().Length != 0
                    && Focused_batch.GetValue("Idtemplate_method").ToString().Trim().Length != 0)
                {                    
                    Num_repetitions = Convert.ToInt32(Focused_batch.GetValue("Cod_repetition"));
                    Idbatch = Convert.ToInt64(Focused_batch.GetValue("Id"));
                    Idtemplate_method = Convert.ToInt32(Focused_batch.GetValue("Idtemplate_method"));

                    Show_batch();

                    // --- OPTIMIZAR A USER CONTROL
                    if (AllSamplesApproveSelected())
                        paAuthorization.Visible = true;
                    else
                        paAuthorization.Visible = false;
                }
            }
            InitConfigurationAbsStd();
        }

        void Clear_detail_batch()
        {
            // --- clear columns
            laTitleModule.Text = "";
            tbCodMethod.Text = "";
            tbTitle.Text = "";
            tbAbbreviation.Text = "";
            tbErrorAllowed.Text = "";
            tbMri.Text = "";
            tbLawMri.Text = "";
            tbSdBlk.Text = "";
            tbSdMr.Text = "";
            tbUnitMeasure.Text = "";
            deDate_allowed_error.Text = "";
            gcBachCalc.DataSource = null;
        }

        void Show_batch()
        {
            // --- show trace groups
            gbApprove.Visible = false;
            gbReview.Visible = false;
            gv2col_Qaqc_approve.ImageIndex = 0;
            gv2col_Qaqc_review.ImageIndex = 0;

            // --- show template method
            ShowDilution();

            // --- show description method
            CBatchFactory faBatch = new CBatchFactory();
            CBatch oBatch = faBatch.GetByPrimaryKey(new CBatchKeys(Idbatch));
            laTitleModule.Text = String.Format("Bandeja {0} en Espera", Comun.FormatCorrelativeCode("B-", Convert.ToInt64(oBatch.Num_tray), 5));

            if (oBatch.Status_process == 'W')
            {                
                ucSignCloseTray.Title = "Cerrar bandeja";
                ucSignCloseTray.Enabled = true;
                bgvBatchCalc2.OptionsBehavior.Editable = false;
                    
            }
            if (oBatch.Status_process == 'P')
            {
                ucSignCloseTray.Title = "Cerrado("+oBatch.User_close_tray+")";
                ucSignCloseTray.Enabled = false;
                bgvBatchCalc2.OptionsBehavior.Editable = true;
            }

            CTemplate_methodFactory faTemplate_method = new CTemplate_methodFactory();
            oTemplate_method_current = faTemplate_method.GetByPrimaryKey(new CTemplate_methodKeys(Idtemplate_method));
            tbCodMethod.Text = oTemplate_method_current.Cod_template_method;
            tbTitle.Text = oTemplate_method_current.Title;
            tbAbbreviation.Text = oTemplate_method_current.Abbreviation;

            #region <optimizar>            
                                    
            CTemplate_method_aaFactory faTemplate_method_aa = new CTemplate_method_aaFactory();
            oTemplate_method_aa_current = faTemplate_method_aa.GetByPrimaryKey(new CTemplate_method_aaKeys(Idtemplate_method));

            deDate_allowed_error.DateTime = Convert.ToDateTime(oTemplate_method_aa_current.Date_allowed_error);            

            CMr_detailFactory faMr_detail = new CMr_detailFactory();
            CMr_detail oMr_detail = faMr_detail.GetByPrimaryKey(new CMr_detailKeys(Convert.ToInt16(oTemplate_method_aa_current.Idmr_detail)));
            tbLawMri.Text = oMr_detail.Nominal_value.ToString();

            CMrFactory faMr = new CMrFactory();
            CMr oMr = faMr.GetByPrimaryKey(new CMrKeys(
                Convert.ToInt16(oMr_detail.Idmr)
                ));
            tbMri.Text = oMr.Cod_mr;
            
            CMeasurement_unitFactory faMeasure = new CMeasurement_unitFactory();
            CMeasurement_unit oMeasurement_unit = faMeasure.GetByPrimaryKey(new CMeasurement_unitKeys(Convert.ToInt16(oMr_detail.Idunit1)));
            tbUnitMeasure.Text = oMeasurement_unit.Name_unit;
            
            #endregion

            // --- clear columns
            gcBachCalc.DataSource = null;

            // --- format the datatable with the number of repetitions
            oDataBatch = new CDataBatch(Idbatch, Idtemplate_method, Comun.StatusWork.Waiting, Comun.CriteriaSort.BySample);            
            gcBachCalc.DataSource = oDataBatch.ListSamples;    
        
            // --- show sd
            tbAbs.Value = oDataBatch.Absorbance;
            tbStd.Value = oDataBatch.StdVerification;
            tbAbs.BackColor = oDataBatch.ColorAbsorbance;
            tbStd.BackColor = oDataBatch.ColorStd;            
            tbSdBlk.Text = oDataBatch.LrbMeasured.ToString();
            tbSdBlk.BackColor = oDataBatch.ColorLrbMeasured;
            tbSdMr.Text = oDataBatch.MriMeasured.ToString();
            tbSdMr.BackColor = oDataBatch.ColorMriMeasured;
        
            // --- show empty sample
            ShowParityEmptySample(false);
        }

        void Show_batch_finished()
        {
            gbApprove.Visible = true;
            gbReview.Visible = true;
            gv2col_Qaqc_approve.ImageIndex = 0;
            gv2col_Qaqc_review.ImageIndex = 0;            

            // --- show template method
            ShowDilution();

            // --- show description method
            CTemplate_methodFactory faTemplate_method = new CTemplate_methodFactory();
            CTemplate_method oTemplate_method = faTemplate_method.GetByPrimaryKey(new CTemplate_methodKeys(Idtemplate_method));
            tbCodMethod.Text = oTemplate_method.Cod_template_method;
            tbTitle.Text = oTemplate_method.Title;
            tbAbbreviation.Text = oTemplate_method.Abbreviation;

            // --- get batch trace_batch
            CTrace_batchFactory faTrace_batch = new CTrace_batchFactory();
            Dictionary<string, string> dtTrace_batch = new BusinessLayer.Modules.ModProcessBatch().GetCurrentAndBelow(Idbatch, LimsProcess.PROCESS_IN_READING);            

            CBatchFactory faBatch = new CBatchFactory();
            CBatch oBatch = faBatch.GetByPrimaryKey(new CBatchKeys(Idbatch));
            laTitleModule.Text = String.Format("Bandeja {0} Aprobada\n ({1})"
                , "B-" + oBatch.Num_tray.ToString().PadLeft(5, '0')
                , dtTrace_batch["User_approved"].ToString());

            laUser_approved.Text = dtTrace_batch["User_approved"].ToString();
            laDate_approved.Text = dtTrace_batch["Date_approved"].ToString();
            laUser_revised.Text = dtTrace_batch["User_revised"].ToString();
            laDate_revised.Text = dtTrace_batch["Date_revised"].ToString();

            #region <optimizar>
            
            CTemplate_method_aaFactory faTemplate_method_aa = new CTemplate_method_aaFactory();
            CTemplate_method_aa oTemplate_method_aa = faTemplate_method_aa.GetByPrimaryKey(new CTemplate_method_aaKeys(Idtemplate_method));

            deDate_allowed_error.DateTime = Convert.ToDateTime(oTemplate_method_aa.Date_allowed_error);

            CMr_detailFactory faMr_detail = new CMr_detailFactory();
            CMr_detail oMr_detail = faMr_detail.GetByPrimaryKey(new CMr_detailKeys(Convert.ToInt16(oTemplate_method_aa.Idmr_detail)));
            tbLawMri.Text = oMr_detail.Nominal_value.ToString();

            CMrFactory faMr = new CMrFactory();
            CMr oMr = faMr.GetByPrimaryKey(new CMrKeys(
                Convert.ToInt16(oMr_detail.Idmr)
                ));
            tbMri.Text = oMr.Cod_mr;

            CMeasurement_unitFactory faMeasure = new CMeasurement_unitFactory();
            CMeasurement_unit oMeasurement_unit = faMeasure.GetByPrimaryKey(new CMeasurement_unitKeys(Convert.ToInt16(oMr_detail.Idunit1)));
            tbUnitMeasure.Text = oMeasurement_unit.Name_unit;

            #endregion

            // --- clear columns
            gcBachCalc.DataSource = null;

            // --- format the datatable with the number of repetitions    
            if (cbAuthorizationApproved.EditValue.ToString() == "0000")
                oDataBatch = new CDataBatch(Idbatch, Idtemplate_method, Comun.StatusWork.Saved, Comun.CriteriaSort.BySample);
            else
                oDataBatch = new CDataBatch(Idbatch, Idtemplate_method, Comun.StatusWork.Management, Comun.CriteriaSort.BySample);

            gcBachCalc.DataSource = oDataBatch.ListSamples;

            // --- show sd
            tbAbs.Value = oDataBatch.Absorbance;
            tbStd.Value = oDataBatch.StdVerification;
            tbAbs.BackColor = oDataBatch.ColorAbsorbance;
            tbStd.BackColor = oDataBatch.ColorStd;
            tbSdBlk.Text = oDataBatch.LrbMeasured.ToString();
            tbSdBlk.BackColor = oDataBatch.ColorLrbMeasured;
            tbSdMr.Text = oDataBatch.MriMeasured.ToString();
            tbSdMr.BackColor = oDataBatch.ColorMriMeasured;

            // --- OPTIMIZAR A USER CONTROL
            paAuthorization.Visible = true;

            // --- show empty sample
            ShowParityEmptySample(true);
        }

        private bool AreDecimalCells(int row)
        {
            if (!Comun.isDecimal(bgvBatchCalc2.GetRowCellValue(row, gv2col_Reading1)))
                return false;
            if (!Comun.isDecimal(bgvBatchCalc2.GetRowCellValue(row, gv2col_Reading2)))
                return false;
            return true;
        }

        void ShowParityEmptySample(bool value)
        {
            if (value)
                repQaqc_parity.Items[4].ImageIndex = 0;
            else
                repQaqc_parity.Items[4].ImageIndex = -1;
        }

        void ModifyWhenCellChanged(DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!e.Column.FieldName.Contains("Flag_dilu"))
            {
                BindingList<CBatch_detail_aa_twofold> dt = (BindingList<CBatch_detail_aa_twofold>)gcBachCalc.DataSource;
                
                // --- save reading cell and calculated cells
                int currentrow = bgvBatchCalc2.FocusedRowHandle;
                oDataBatch.ExecuteExpEval(currentrow);
                oDataBatch.ExecuteQaqc(currentrow);
                oDataBatch.Save(currentrow);

                // --- 
                tbSdBlk.Text = oDataBatch.LrbMeasured.ToString();
                tbSdBlk.BackColor = oDataBatch.ColorLrbMeasured;
                tbSdMr.Text = oDataBatch.MriMeasured.ToString();
                tbSdMr.BackColor = oDataBatch.ColorMriMeasured;
            }

            // --- OPTIMIZAR A USER CONTROL
            if (AllSamplesApproveSelected())
                paAuthorization.Visible = true;
            else
                paAuthorization.Visible = false;
        }

        void ModifyWhenCellChanging(DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            // --- only when the column is dilution
            if (e.Column.FieldName.Contains("Flag_dilu"))
            {
                bgvBatchCalc2.SetFocusedRowCellValue(e.Column, e.Value);
                BindingList<CBatch_detail_aa_twofold> dt = (BindingList<CBatch_detail_aa_twofold>)gcBachCalc.DataSource;
                
                // --- save reading cell and calculated cells
                int currentrow = bgvBatchCalc2.FocusedRowHandle;
                oDataBatch.ExecuteExpEval(currentrow);
                oDataBatch.ExecuteQaqc(currentrow);
                oDataBatch.Save(bgvBatchCalc2.FocusedRowHandle);
                
                bgvBatchCalc2.UpdateCurrentRow();                
            }
        }

        private void bgvBatchCalc_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {                 
            if (tabTreeQaqc.SelectedTabPageIndex == 0)
                ModifyWhenCellChanged(e);
        }
        
        private void bgvBatchCalc_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (tabTreeQaqc.SelectedTabPageIndex == 0)
                ModifyWhenCellChanging(e);
        }

        #endregion

        #region methods

        void InitCombos()
        {
            
            repRepetition.DataSource = Comun.ListTypeRepetition;
            repRepetition.ValueMember = "Cod_repetition";
            repRepetition.DisplayMember = "Name_repetition";

            List<CType_sample> lstType_sample = new CType_sampleFactory().GetAll();
            cbTypeSample.Properties.DataSource = lstType_sample;
            cbTypeSample.Properties.DisplayMember = "Cod_type_sample";
            cbTypeSample.Properties.ValueMember = "Cod_type_sample";
            cbTypeSample.EditValue = lstType_sample[0].Cod_type_sample;

            InitComboFilterAthorization();

            List<CCompany> lstCompany = new CCompanyFactory().GetAll();
            cbCompany.Properties.DataSource = lstCompany;
            cbCompany.Properties.DisplayMember = "Business_name";
            cbCompany.Properties.ValueMember = "Idcompany";
            cbCompany.EditValue = lstCompany[0].Cod_company;

            List<CDescription_sample> lstDescription = new CDescription_sampleFactory().GetAll();
            repDes_Sample.DataSource = lstDescription;
            repDes_Sample.DisplayMember = "Description";
            repDes_Sample.ValueMember = "Cod_des_sample";
        }        

        public class CProcessAuthorization
        {
            public string Cod_area { get; set; }
            public string Nom_area { get; set; }
        }

        void InitComboFilterAthorization()
        {
            // --- dates
            deFrom.EditValue = Comun.GetDate();
            deUntil.EditValue = Comun.GetDate();

            // --- process user system
            CProcess_user_systemFactory faProcess_user_system = new CProcess_user_systemFactory();
            CProcessFactory faProces = new CProcessFactory();
            CAreaFactory faArea = new CAreaFactory();

            List<CProcessAuthorization> lstHistory = new List<CProcessAuthorization>();
            lstHistory.Add(new CProcessAuthorization { Cod_area = "0000", Nom_area = "Historial" });

            var history =
                from c in lstHistory
                select new
                {
                    c.Cod_area,
                    c.Nom_area
                };

            var areasByUser =
                (from p in faProcess_user_system.GetAll()
                 join c in faArea.GetAll()
                   on p.Cod_area equals c.Cod_area
                 where p.Iduser == Comun.User_system.Iduser
                 select new
                 {
                     c.Cod_area,
                     c.Nom_area
                 }).Distinct();

            cbAuthorizationWait.Properties.DataSource = areasByUser.ToList();
            cbAuthorizationWait.Properties.DisplayMember = "Nom_area";
            cbAuthorizationWait.Properties.ValueMember = "Cod_area";
            cbAuthorizationWait.EditValue = areasByUser.ToList()[0].Cod_area;

            cbAuthorizationApproved.Properties.DataSource = areasByUser.Concat(history).ToList();
            cbAuthorizationApproved.Properties.DisplayMember = "Nom_area";
            cbAuthorizationApproved.Properties.ValueMember = "Cod_area";
            cbAuthorizationApproved.EditValue = areasByUser.ToList()[0].Cod_area;
        }

        void InitTreeBatch(Comun.StatusWork statusWork)
        {            
            if (statusWork == Comun.StatusWork.Waiting)
            {
                treeTrayWaiting.DataSource = new ModQaQc().GetAllTree(cbAuthorizationWait.EditValue.ToString(), "M002", false, deFrom.DateTime, deUntil.DateTime, 0, 0);

                
                if (treeTrayWaiting.Nodes.Count > 0)
                {                    
                    treeTrayWaiting.FocusedNode = treeTrayWaiting.Nodes.FirstNode;
                }
                else
                {
                    gcBachCalc.DataSource = null;
                }

                treeTrayWaiting.BestFitColumns();
                treeTrayWaiting.Columns["Date_result"].SortOrder = SortOrder.Ascending;
                treeTrayWaiting.Columns["Hour_result"].SortOrder = SortOrder.Ascending;
            }
            else if (statusWork == Comun.StatusWork.Management)
            {
                bool enabled_history = false;
                if (cbAuthorizationApproved.EditValue.ToString() == "0000")
                    enabled_history = true;

                long? idrecep_sample_detail = null;
                if (ckSample.Checked)
                    idrecep_sample_detail = Convert.ToInt64(txSample.EditValue);

                long? idcompany = null;
                if (ckCompany.Checked)
                    idcompany = Convert.ToInt64(cbCompany.EditValue);

                treeTrayFinished.DataSource =
                    new ModQaQc().GetAllTree(cbAuthorizationApproved.EditValue.ToString(), "M003", enabled_history, deFrom.DateTime, deUntil.DateTime, idrecep_sample_detail, idcompany);

                if (treeTrayFinished.Nodes.Count > 0)
                {
                    //treeTrayFinished.FocusedNode = treeTrayFinished.Nodes[0].ParentNode;
                    treeTrayFinished.FocusedNode = treeTrayFinished.Nodes.FirstNode;
                }
                else
                {
                    gcBachCalc.DataSource = null;
                }
                treeTrayFinished.BestFitColumns();
                treeTrayWaiting.Columns["Date_result"].SortOrder = SortOrder.Ascending;
                treeTrayWaiting.Columns["Hour_result"].SortOrder = SortOrder.Ascending;
            }            
        }

        void ShowDilution()
        {
            // --- get method
            CTemplate_method_aaFactory faTemplate_method_aa = new CTemplate_method_aaFactory();
            CTemplate_method_aa oTemplate_method_aa = faTemplate_method_aa.GetByPrimaryKey(new CTemplate_method_aaKeys(Idtemplate_method));

            // --- assign visibility columns
            // dilution 2
            if (oTemplate_method_aa.Dilution2 == 1)
            {
                gv2col_Dilua1.Visible = false;
                gv2col_Flag_dila1.Visible = false;
            }
            else
            {
                gv2col_Dilua1.Visible = true;
                gv2col_Flag_dila1.Visible = true;
            }

            // dilution 3
            if (oTemplate_method_aa.Dilution3 == 1)
            {
                gv2col_Dilub1.Visible = false;
                gv2col_Flag_dilb1.Visible = false;
            }
            else
            {
                gv2col_Dilub1.Visible = true;
                gv2col_Flag_dilb1.Visible = true;
            }
            if (oTemplate_method_aa.Dilution2 == 1 && oTemplate_method_aa.Dilution3 == 1)
                gbDilution.Visible = false;
            else
                gbDilution.Visible = true;
                        
        }

        #endregion

        void SelectFinishedTray(long idbatch)
        {
            tabTreeQaqc.SelectedTabPageIndex = 1;

            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode node in treeTrayFinished.Nodes)
            {
                if (Convert.ToInt64(node["Id"]) == idbatch)
                {
                    treeTrayFinished.SetFocusedNode(node);
                    break;
                }
            }
        }

        void SelectWaitingTray(int idbatch)
        {
            tabTreeQaqc.SelectedTabPageIndex = 0;

            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode node in treeTrayWaiting.Nodes)
            {
                if (Convert.ToInt64(node["Id"]) == idbatch)
                {
                    treeTrayWaiting.SetFocusedNode(node);
                    break;
                }
            }
        }

        private void treeTrayFinished_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (tabTreeQaqc.SelectedTabPageIndex == 1 && e.Node != null) // --- only when the tray has finished
            {                
                if (e.Node.ParentNode == null && e.Node.Level == 0)
                    Focused_batch = e.Node;
                else if (e.Node.Level == 1)
                    Focused_batch = e.Node.ParentNode;
                else                
                    Focused_batch = treeTrayWaiting.MoveFirst();
                             
                // --- get data by node selected                
                Num_repetitions = Convert.ToInt32(Focused_batch.GetValue("Cod_repetition"));
                Idbatch = Convert.ToInt64(Focused_batch.GetValue("Id"));
                Idtemplate_method = Convert.ToInt32(Focused_batch.GetValue("Idtemplate_method"));
                Show_batch_finished();
            }

            InitConfigurationAbsStd();
        }

        private void tabTreeQaqc_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            tbStd.Value = 0;
            tbAbs.Value = 0;

            // 0:tray waiting, 1:tray finished            
            if (tabTreeQaqc.SelectedTabPageIndex == 0)
            {                
             
                paQaqc1.BackColor = Color.LightSteelBlue;
                ucSignCloseTray.Visible = true;
                ucSign1.Clear();
                paAuthorization.Visible = false;                
                bgvBatchCalc2.Columns["Qaqc_status_result"].Visible = false;
                bgvBatchCalc2.Columns["Qaqc_approve"].Visible = true;
                
                treeTrayFinished.Nodes.Clear();
                Clear_detail_batch();

                InitTreeBatch(Comun.StatusWork.Waiting);

                if (treeTrayWaiting.Nodes.Count > 0)                                    
                    treeTrayWaiting.FocusedNode = treeTrayWaiting.Nodes.FirstNode;
                else                
                    gcBachCalc.DataSource = null;
                
            }
            else
            {                
                paQaqc1.BackColor = Color.Tan;                
                ucSignCloseTray.Visible = false;
                ucSign1.Clear();                
                paAuthorization.Visible = false;
                treeTrayFinished.Nodes.Clear();
                Clear_detail_batch();                                

                bgvBatchCalc2.Columns["Qaqc_approve"].Visible = false;                
                bgvBatchCalc2.Columns["Qaqc_status_result"].Visible = false;                

                if (cbAuthorizationApproved.EditValue.ToString() == "0000")
                {                    
                    paHistoryFilter.Visible = false;
                    Clear_detail_batch();
                    treeTrayFinished.ClearNodes();
                    InitTreeBatch(Comun.StatusWork.Management);
                    tabTreeQaqc.SelectedTabPage.Text = "Historial";
                }
                else
                {
                    InitTreeBatch(Comun.StatusWork.Management);
                    paHistoryFilter.Visible = false;
                    tabTreeQaqc.SelectedTabPage.Text = "Gerencia";
                }

                if (treeTrayFinished.Nodes.Count > 0)
                {
                    //treeTrayFinished.FocusedNode = treeTrayFinished.Nodes[0].ParentNode;
                    treeTrayFinished.FocusedNode = treeTrayFinished.Nodes.FirstNode;
                }
                else
                {
                    gcBachCalc.DataSource = null;
                }
            }            
        }

        private void btSearchTray_Click(object sender, EventArgs e)
        {
            InitTreeBatch(Comun.StatusWork.Management);

            if (treeTrayFinished.Nodes.Count == 0)
                Clear_detail_batch();
            else
            {
                treeTrayFinished.FocusedNode = treeTrayFinished.Nodes[0].ParentNode;
                treeTrayFinished.FocusedNode = treeTrayFinished.Nodes.FirstNode;
            }
        }

        private void cbAuthorization_EditValueChanged(object sender, EventArgs e)
        {
            if (tabTreeQaqc.SelectedTabPageIndex == 1) // in review sample
            {
                if (cbAuthorizationApproved.EditValue.ToString() == "0000")
                {
                    paHistoryFilter.Visible = true;
                    Clear_detail_batch();
                    treeTrayFinished.ClearNodes();
                    InitTreeBatch(Comun.StatusWork.Management);
                    tabTreeQaqc.SelectedTabPage.Text = "Historial";
                    paAuthorization.Visible = false;                    
                }
                else
                {
                    InitTreeBatch(Comun.StatusWork.Management);
                    paHistoryFilter.Visible = false;
                    tabTreeQaqc.SelectedTabPage.Text = "Gerencia";                    
                    paAuthorization.Visible = true;
                }
            }
        }

        private void ckCompany_CheckedChanged(object sender, EventArgs e)
        {
            cbCompany.Visible = ckCompany.Checked;
            if (ckCompany.Checked)
                ckSample.Checked = !ckCompany.Checked;
        }

        private void ckSample_CheckedChanged(object sender, EventArgs e)
        {
            txSample.Visible = ckSample.Checked;
            cbTypeSample.Visible = ckSample.Checked;
            txYear.Visible = ckSample.Checked;
            if (ckSample.Checked)
                ckCompany.Checked = !ckSample.Checked;
            txSample.Select();
            txSample.Focus();
        }

        private void cbAuthorizationWait_EditValueChanged(object sender, EventArgs e)
        {
            InitTreeBatch(Comun.StatusWork.Waiting);
        }

        private System.Windows.Forms.DialogResult OpenShowPopup(Comun.TypeSample type_sample)
        {
            CBatch_detail_aa_twofold current_row = oDataBatch.ListSamples[bgvBatchCalc2.FocusedRowHandle];
            System.Windows.Forms.DialogResult result = System.Windows.Forms.DialogResult.Cancel;

            FormCheckContent ofmPopupContent = new FormCheckContent();
            if (tabTreeQaqc.SelectedTabPageIndex == 0)
            {
                ofmPopupContent.Text = "Aprobar";
                ofmPopupContent.Windows_current = Comun.WindowsTray.PendingApprove;
            }
            else
            {
                ofmPopupContent.Text = "Revisar";
                ofmPopupContent.Windows_current = Comun.WindowsTray.PendingReview;
            }

            // --- retrieve observation and method
            ofmPopupContent.Idtemplate_method = Idtemplate_method;
            ofmPopupContent.Text_obs = bgvBatchCalc2.GetFocusedRowCellValue("Qaqc_approve_text").ToString();
            ofmPopupContent.Idretest = Convert.ToInt32(bgvBatchCalc2.GetFocusedRowCellValue("Qaqc_tmp_retest_idmethod"));
            ofmPopupContent.Idrecep_sample_detail_elem = Convert.ToInt64(bgvBatchCalc2.GetFocusedRowCellValue("Idrecep_sample_detail_elem"));
            ofmPopupContent.Idbatch = Idbatch;
            ofmPopupContent.TypeSample = type_sample;
            
            if (ofmPopupContent.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {                
                if (tabTreeQaqc.SelectedTabPageIndex == 0) // approved samples
                {                    
                    // --- save observation and change of method
                    if (ofmPopupContent.Text_obs.Trim().Length > 0)
                    {
                        current_row.Qaqc_approve_text = ofmPopupContent.Text_obs;
                        current_row.Qaqc_tmp_retest_idmethod = 0;
                        current_row.Qaqc_tmp_retest = 0;                        

                        DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e =
                            new CellValueChangedEventArgs(bgvBatchCalc2.FocusedRowHandle, gv2col_Qaqc_approve_text, ofmPopupContent.Idtemplate_method);
                        ModifyWhenCellChanged(e);
                        
                    }
                    if (ofmPopupContent.EnableRetest)
                    {
                        current_row.Qaqc_approve_text = ofmPopupContent.Text_obs;
                        current_row.Qaqc_tmp_retest_idmethod = ofmPopupContent.Idtemplate_method;
                        current_row.Qaqc_tmp_retest = 1;
                        current_row.Qaqc_has_retest = 1;                        

                        DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e =
                            new CellValueChangedEventArgs(bgvBatchCalc2.FocusedRowHandle, gv2col_Qaqc_tmp_retest_idmethod, ofmPopupContent.Idtemplate_method);
                        ModifyWhenCellChanged(e);
                    }
                    //oPivotDataBatch.ListSamples[bgvBatchCalc2.FocusedRowHandle].Qaqc_approve = true;

                    result = System.Windows.Forms.DialogResult.OK;
                }
                else // review samples
                {
                    // --- save observation and change of method
                    if (ofmPopupContent.Text_obs.Trim().Length > 0)
                    {
                        current_row.Qaqc_review_text = ofmPopupContent.Text_obs;
                        current_row.Qaqc_tmp_retest_idmethod = 0;
                        current_row.Qaqc_tmp_retest = 0;

                        DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e =
                            new CellValueChangedEventArgs(bgvBatchCalc2.FocusedRowHandle, gv2col_Qaqc_review_text, ofmPopupContent.Idtemplate_method);
                        ModifyWhenCellChanged(e);
                    }
                    if (ofmPopupContent.EnableRetest)
                    {
                        current_row.Qaqc_review_text = ofmPopupContent.Text_obs;
                        current_row.Qaqc_tmp_retest_idmethod = ofmPopupContent.Idtemplate_method;
                        current_row.Qaqc_tmp_retest = 1;
                        current_row.Qaqc_has_retest = 1;
                        
                        DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e =
                            new CellValueChangedEventArgs(bgvBatchCalc2.FocusedRowHandle, gv2col_Qaqc_tmp_retest_idmethod, ofmPopupContent.Idtemplate_method);
                        ModifyWhenCellChanged(e);
                    }
                    
                    bgvBatchCalc2.UpdateCurrentRow();
                    result = System.Windows.Forms.DialogResult.OK;
                }
            }
            else
            {
                if (tabTreeQaqc.SelectedTabPageIndex == 0) // approved samples
                    bgvBatchCalc2.SetRowCellValue(bgvBatchCalc2.FocusedRowHandle, "Qaqc_approve", false);                
            }

            // --- OPTIMIZAR A USER CONTROL
            if (AllSamplesApproveSelected())
                paAuthorization.Visible = true;
            else
                paAuthorization.Visible = false;

            return result;
        }

        private void repQaqc_ShowPopup_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            CBatch_detail_aa_twofold current_row = oDataBatch.ListSamples[bgvBatchCalc2.FocusedRowHandle];
            bool flag_open_popup = current_row.Qaqc_has_retest == null ? false : Convert.ToBoolean(current_row.Qaqc_has_retest);
            if (!flag_open_popup && current_row.Flag_mri == 0)
                OpenShowPopup(Comun.TypeSample.Sample);
        }        

        void Review_samples()
        {
            // --- approve data
            try
            {
                oDataBatch.Review();
                MessageBox.Show("Revisado con éxito.");

                // --- save temp approved batch
                long Idapproved_batch = oDataBatch.Idbatch;

                // --- initialize trees
                InitTreeBatch(Comun.StatusWork.Management);

                // --- it will select approved tray in finished tree group
                SelectFinishedTray(Idapproved_batch);

                paAuthorization.Visible = false;

                ComunForm.Send_message(this.Text, TypeMsg.ok, "");
            }
            catch (Exception ex)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, ex.Message);
            }
        }

        bool AllSamplesReviewSelected()
        {
            for (int i = 0; i < bgvBatchCalc2.RowCount; i++)
            {
                if (!Convert.ToBoolean(bgvBatchCalc2.GetRowCellValue(i, "Qaqc_review"))
                    && Convert.ToInt32(bgvBatchCalc2.GetFocusedRowCellValue("Flag_mri")) == 0)
                    return false;
            }
            return true;
        }

        bool AllSamplesApproveSelected()
        {
            for (int i = 0; i < bgvBatchCalc2.RowCount; i++)
            {
                if (!Convert.ToBoolean(bgvBatchCalc2.GetRowCellValue(i, "Qaqc_approve"))
                    && Convert.ToInt32(bgvBatchCalc2.GetRowCellValue(i, "Flag_mri")) == 0)
                    return false;
            }
            return true;
        }

        void Approve_samples()
        {
            // --- approve data
            try
            {
                if (!oDataBatch.ExistErrorBeforeApprove())
                {
                    if (oDataBatch.IsSampleControlRight())
                    {                        
                        oDataBatch.Approve();
                        MessageBox.Show("Aprobado con éxito.");

                        // --- initialize trees
                        InitTreeBatch(Comun.StatusWork.Waiting);                        
                        paAuthorization.Visible = false;
                        ucSign1.Clear();

                        ComunForm.Send_message(this.Text, TypeMsg.ok, "");
                    }
                    else
                    {
                        // --- retest batch
                        oDataBatch.RetestBatch();
                        MessageBox.Show("Revisado con éxito.");

                        // --- initialize trees
                        InitTreeBatch(Comun.StatusWork.Waiting);
                        paAuthorization.Visible = false;
                        ucSign1.Clear();

                        ComunForm.Send_message(this.Text, TypeMsg.ok, "");
                    }
                }
                else
                    MessageBox.Show("No es posible aprobar la bandeja.");
            }
            catch (Exception ex)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, ex.Message);
            }
        } 

        private void bgvBatchCalc2_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            CTemplate_method_aa oTemplate_method_aa = new CTemplate_method_aaFactory().GetByPrimaryKey(new CTemplate_method_aaKeys(Idtemplate_method));

            GridView view = sender as GridView;

            if (!Convert.ToBoolean(bgvBatchCalc2.GetFocusedRowCellValue(gv2col_Flag_dila1)) &&
                Convert.ToBoolean(bgvBatchCalc2.GetFocusedRowCellValue(gv2col_Flag_dilb1)))
            {
                e.Valid = false;
                view.SetColumnError(gv2col_Flag_dila1, "Selección de diluciones mal efectuada.");
                view.SetColumnError(gv2col_Flag_dilb1, "Selección de diluciones mal efectuada.");
            }           
        }

        private void bgvBatchCalc2_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;            
        }

        private void btCloseTray_Click(object sender, EventArgs e)
        {
            
        }

        private void tbCodMethod_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            FormMethod fmMethod = new FormMethod();
            fmMethod.Cod_template_method_const = tbCodMethod.Text;
            fmMethod.Show();
        }

        private void ucSign1_OnSign(bool login)
        {
            if (login)
            {
                if (tabTreeQaqc.SelectedTabPageIndex == 0)
                {
                    Approve_samples();
                }
                else
                {
                    Review_samples();
                }
            }
        }

        private void bgvBatchCalc2_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.Column == gv2col_Reading1 || e.Column == gv2col_Reading2)
            {
                CTemplate_method_aa method = new CTemplate_method_aaFactory().GetByPrimaryKey(new CTemplate_method_aaKeys(Idtemplate_method));
                // --- draw color style cell without result
                if (bgvBatchCalc2.GetRowCellValue(e.RowHandle, e.Column) != null)
                {
                    string strReading = bgvBatchCalc2.GetRowCellValue(e.RowHandle, e.Column).ToString();
                    decimal reading = 0;
                    if (decimal.TryParse(strReading, out reading))
                    {
                        if (reading < method.Reading_min || reading > method.Reading_max)
                        {
                            e.Appearance.BackColor = Comun.ColorMorado;
                            e.Appearance.Options.UseBackColor = true;
                        }
                    }
                }
            }
            if (e.Column == gv2col_Str_result_analysis)
            {
                if (tabTreeQaqc.SelectedTabPageIndex == 1)
                {
                    CBatch_detail_aa_twofold oBatch_detail_aa_twofold = oDataBatch.ListSamples[e.RowHandle];
                    ///1 : incorrecto : rojo
                    ///2 : plausible : ambar
                    ///3 : aceptado : verde
                    ///4 : incorrecto con observacion o reensayo : rojo
                    if (oBatch_detail_aa_twofold.Qaqc_status_result == 1)
                        e.Appearance.BackColor = Comun.ColorRojo;
                    if (oBatch_detail_aa_twofold.Qaqc_status_result == 2)
                        e.Appearance.BackColor = Comun.ColorAmbar;
                    if (oBatch_detail_aa_twofold.Qaqc_status_result == 3)
                        e.Appearance.BackColor = Comun.ColorVerde;
                    if (oBatch_detail_aa_twofold.Qaqc_status_result == 4)
                        e.Appearance.BackColor = Comun.ColorRojo;
                }
            }

        }

        private void btRegAbsStd_Click(object sender, EventArgs e)
        {
            // registrar absorvancia y habilitar columnas de lecturas de absorción atómica
            // -- registrar absorvancia.
            if (MessageBox.Show("Registrar Absorvancia y Estandar de Verificación", "Datos de Calibración", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                CBatch oBatch = new CBatchFactory().GetByPrimaryKey(new CBatchKeys(Idbatch));
                oBatch.Absorvance = Convert.ToDecimal(tbAbs.Text);
                oBatch.Std_verification = Convert.ToDecimal(tbStd.Text);
                oBatch.Flag_abs_std = true;

                // -- absorbance
                decimal absMin = Convert.ToDecimal(oTemplate_method_aa_current.Absorvance) - Convert.ToDecimal(oTemplate_method_aa_current.Abs_incertitude);
                decimal absMax = Convert.ToDecimal(oTemplate_method_aa_current.Absorvance) + Convert.ToDecimal(oTemplate_method_aa_current.Abs_incertitude);

                oBatch.Flag_correct_abs = false;
                if (oBatch.Absorvance >= absMin && oBatch.Absorvance <= absMax)
                    oBatch.Flag_correct_abs = true;
                
                // -- std verification
                decimal stdMin = Convert.ToDecimal(oTemplate_method_aa_current.Std_verif) - Convert.ToDecimal(oTemplate_method_aa_current.Std_verif_incertitude);
                decimal stdMax = Convert.ToDecimal(oTemplate_method_aa_current.Std_verif) + Convert.ToDecimal(oTemplate_method_aa_current.Std_verif_incertitude);

                oBatch.Flag_correct_std = false;
                if (oBatch.Std_verification >= stdMin && oBatch.Std_verification <= stdMax)
                    oBatch.Flag_correct_std = true;
                
                CBatchFactory faBatch = new CBatchFactory();

                // -- habilitar columnas si está dentro del valor permitido.
                if (faBatch.Update(oBatch))
                {
                    paQaqc2.Enabled = false;
                    tbAbs.Properties.ReadOnly = true;
                    tbStd.Properties.ReadOnly = true;
                    gv2col_Reading1.OptionsColumn.AllowEdit = true;
                    gv2col_Reading2.OptionsColumn.AllowEdit = true;
                    btRegAbsStd.Enabled = false;
                    bgvBatchCalc2.OptionsBehavior.Editable = true;
                }

                SetApareanceAbsorvance();
                SetApareanceStdVerif();
            }
        }

        void InitConfigurationAbsStd()
        {
            if (tabTreeQaqc.SelectedTabPageIndex == 0)
            {
                CBatch oBatch = new CBatchFactory().GetByPrimaryKey(new CBatchKeys(Idbatch));

                if (oBatch.Status_process == 'P')
                {
                    paQaqc2.Enabled = true;

                    if (oBatch.Flag_abs_std == null)
                    {
                        tbAbs.Properties.ReadOnly = false;
                        tbStd.Properties.ReadOnly = false;
                        gv2col_Reading1.OptionsColumn.AllowEdit = false;
                        gv2col_Reading2.OptionsColumn.AllowEdit = false;
                        btRegAbsStd.Enabled = true;
                        bgvBatchCalc2.OptionsBehavior.Editable = false;
                    }
                    else
                    {
                        if (Convert.ToBoolean(oBatch.Flag_abs_std))
                        {
                            SetApareanceAbsorvance();
                            SetApareanceStdVerif();
                            paQaqc2.Enabled = false;
                            tbAbs.Properties.ReadOnly = true;
                            tbStd.Properties.ReadOnly = true;
                            btRegAbsStd.Enabled = false;
                            gv2col_Reading1.OptionsColumn.AllowEdit = true;
                            gv2col_Reading2.OptionsColumn.AllowEdit = true;
                            bgvBatchCalc2.OptionsBehavior.Editable = true;
                        }
                        else
                        {
                            tbAbs.Properties.ReadOnly = false;
                            tbStd.Properties.ReadOnly = false;
                            paQaqc2.Enabled = true;
                            btRegAbsStd.Enabled = true;
                            gv2col_Reading1.OptionsColumn.AllowEdit = false;
                            gv2col_Reading2.OptionsColumn.AllowEdit = false;
                            bgvBatchCalc2.OptionsBehavior.Editable = false;
                        }
                    }
                }
                else if (oBatch.Status_process == 'W')
                {
                    paQaqc2.Enabled = false;
                    gv2col_Reading1.OptionsColumn.AllowEdit = false;
                    gv2col_Reading2.OptionsColumn.AllowEdit = false;
                    bgvBatchCalc2.OptionsBehavior.Editable = false;
                }
            }
            else
            {
                paQaqc2.Enabled = false;

                tbAbs.Properties.ReadOnly = false;
                tbStd.Properties.ReadOnly = false;
                gv2col_Reading1.OptionsColumn.AllowEdit = false;
                gv2col_Reading2.OptionsColumn.AllowEdit = false;
                bgvBatchCalc2.OptionsBehavior.Editable = true;

                btRegAbsStd.Enabled = false;
            }
        }

        void SetApareanceAbsorvance()
        {
            oDataBatch.RefreshQaqcSummary();
            tbAbs.Value = oDataBatch.Absorbance;
            tbAbs.BackColor = oDataBatch.ColorAbsorbance;
        }
        void SetApareanceStdVerif()
        {
            oDataBatch.RefreshQaqcSummary();
            tbStd.Value = oDataBatch.StdVerification;
            tbStd.BackColor = oDataBatch.ColorStd;
        }

        private void tbAbs_Leave(object sender, EventArgs e)
        {
            if (tbAbs.Value >= oTemplate_method_aa_current.Absorvance - oTemplate_method_aa_current.Abs_incertitude
                && tbAbs.Value <= oTemplate_method_aa_current.Absorvance + oTemplate_method_aa_current.Abs_incertitude)
                tbAbs.BackColor = Comun.ColorVerde;
            else
                tbAbs.BackColor = Comun.ColorRojo;
        }

        private void tbStd_Leave(object sender, EventArgs e)
        {
            if (tbStd.Value >= oTemplate_method_aa_current.Std_verif - oTemplate_method_aa_current.Std_verif_incertitude
                && tbStd.Value <= oTemplate_method_aa_current.Std_verif + oTemplate_method_aa_current.Std_verif_incertitude)
                tbStd.BackColor = Comun.ColorVerde;
            else
                tbStd.BackColor = Comun.ColorRojo;
        }

        private void bgvBatchCalc2_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Columns.GridColumn column = ((DevExpress.XtraGrid.Views.Grid.GridView)sender).PressedColumn;

            if (oDataBatch.Batch.Status_process == 'W')
            {
                if (column == gv2col_Cod_sample)
                {
                    oDataBatch.CriteriaSort = Comun.CriteriaSort.BySample;
                    gcBachCalc.DataSource = oDataBatch.ListSamples;
                }
                if (column == gv2col_Cod_des_sample)
                {
                    oDataBatch.CriteriaSort = Comun.CriteriaSort.ByDescription;
                    gcBachCalc.DataSource = oDataBatch.ListSamples;
                }
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            // --- refrescar arbol
            if (tabTreeQaqc.SelectedTabPageIndex == 0)
                InitTreeBatch(Comun.StatusWork.Waiting);
            else
                InitTreeBatch(Comun.StatusWork.Management);
        }

        private void ucSignCloseTray_OnSign(bool login)
        {
            if (login)
            {
                // --- close samples tray
                CBatch oBatch = new CBatchFactory().GetByPrimaryKey(new CBatchKeys(Idbatch));
                oBatch.User_close_tray = Comun.GetUser();
                oBatch.Date_close_tray = Comun.GetDate();

                if (oBatch != null)
                {
                    FormMessage fmMessage = new FormMessage();
                    fmMessage.Title = String.Format("Cerrar Bandeja {0}", Comun.FormatCorrelativeCode("B-", Convert.ToInt64(oBatch.Num_tray), 5));
                    fmMessage.Message = "Al efectuar esta acción, la bandeja cambia a estado en 'proceso', se bloqueará el ingreso de muestras entrantes. Presione Ok para confirmar.";
                    if (fmMessage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        oBatch.Status_process = 'P';    // --- in process

                        // --- add control sample if not exist 
                        if (Convert.ToBoolean(!oBatch.Has_sample_control))
                        {
                            CBatchManager oBatchManager = new CBatchManager();

                            oBatchManager.SaveControlSample(Idtemplate_method, Idbatch);

                            // --- retrieve batch detail
                            Show_batch();
                        }

                        if (new CBatchFactory().Update(oBatch))
                        {
                            ucSignCloseTray.Enabled = false;
                            ucSignCloseTray.Title = "Cerrado("+oBatch.User_close_tray+")";
                        }

                        paQaqc2.Enabled = true;
                        bgvBatchCalc2.OptionsBehavior.Editable = false;
                        InitConfigurationAbsStd();
                    }
                }
            }
        }

        #region drag and drop samples in TreeList

        private void treeTrayWaiting_AfterDragNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            long id_drag = Convert.ToInt64(hi_drag.Node.GetValue("Idbatch_detail_aa"));
            long id_over = Convert.ToInt64(hi_over.Node.GetValue("Idbatch_detail_aa"));
            CBatch_detail_aa_twofold oBatch_detail_aa_twofold_drag = new CBatch_detail_aa_twofoldFactory().GetByPrimaryKey(new CBatch_detail_aa_twofoldKeys(id_drag));
            CBatch_detail_aa_twofold oBatch_detail_aa_twofold_over = new CBatch_detail_aa_twofoldFactory().GetByPrimaryKey(new CBatch_detail_aa_twofoldKeys(id_over));

            //List<CBatch> lstBatch = new CBatchFactory().GetAll().Where(c => Convert.ToChar(c.Status_process) == 'W').ToList();
            CBatchManager batch_manager = new CBatchManager();
            bool result_interchange = batch_manager.InterchangeSample(oBatch_detail_aa_twofold_drag, oBatch_detail_aa_twofold_over);

            // --- refrescar arbol
            InitTreeBatch(Comun.StatusWork.Waiting);

            // expand parent nodes of drag and drop nodes
            ExpandBatchNode(Convert.ToInt64(oBatch_detail_aa_twofold_drag.Idbatch));
            ExpandBatchNode(Convert.ToInt64(oBatch_detail_aa_twofold_over.Idbatch));
        }

        void ExpandBatchNode(long idbatch)
        {
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode nodo_batch in treeTrayWaiting.Nodes)
            {
                if (Convert.ToInt64(nodo_batch.GetValue("Id")) == idbatch)
                    nodo_batch.ExpandAll();
            }
        }

        DevExpress.XtraTreeList.TreeListHitInfo hi_drag = null;
        private void treeTrayWaiting_MouseMove(object sender, MouseEventArgs e)
        {
            hi_drag = treeTrayWaiting.CalcHitInfo(new Point(e.X, e.Y));

            if (hi_drag == null) return;

            if (e.Button != MouseButtons.Left) return;

            Rectangle dragRect = new Rectangle(new Point(
                hi_drag.MousePoint.X - SystemInformation.DragSize.Width / 2,
                hi_drag.MousePoint.Y - SystemInformation.DragSize.Height / 2), SystemInformation.DragSize);

            if (!dragRect.Contains(new Point(e.X, e.Y)))
            {
                if (hi_drag.Node.ParentNode == null)
                    treeTrayWaiting.DoDragDrop(hi_drag.Node, DragDropEffects.Move);
                else
                {
                    treeTrayWaiting.DoDragDrop(null, DragDropEffects.None);
                }
            }
        }

        DevExpress.XtraTreeList.TreeListHitInfo hi_over = null;
        private void treeTrayWaiting_DragOver(object sender, DragEventArgs e)
        {
            DevExpress.XtraTreeList.TreeList tl = sender as DevExpress.XtraTreeList.TreeList;

            hi_over = tl.CalcHitInfo(tl.PointToClient(new Point(e.X, e.Y)));
            if (hi_over.Node != null && hi_drag.Node != null)
            {
                if (hi_over.Node != null && hi_over.Node.Level == 0)
                    e.Effect = DragDropEffects.None;
                else
                {
                    DevExpress.XtraTreeList.Nodes.TreeListNode node_drag = hi_drag.Node as DevExpress.XtraTreeList.Nodes.TreeListNode;
                    DevExpress.XtraTreeList.Nodes.TreeListNode node_over = hi_over.Node as DevExpress.XtraTreeList.Nodes.TreeListNode;

                    long idbatch_over = Convert.ToInt64(node_over.ParentNode.GetValue("Id"));

                    // get father level 1
                    long idbatch_drag = Convert.ToInt64(node_drag.ParentNode.GetValue("Id"));

                    if (idbatch_drag != idbatch_over)
                    {
                        int idtemplate_method_drag = Convert.ToInt32(node_drag.GetValue("Idtemplate_method"));

                        CBatch oBatch_over = new CBatchFactory().GetByPrimaryKey(new CBatchKeys(idbatch_over));

                        if (oBatch_over.Status_process == 'W' &&
                            oBatch_over.Idtemplate_method == idtemplate_method_drag)
                            e.Effect = DragDropEffects.Move;
                        else// batch en proceso
                            e.Effect = DragDropEffects.None;
                    }
                    else
                        e.Effect = DragDropEffects.None;
                }
            }
        }

        #endregion

        #region drag and drop panel New Batch

        private void paNewTray_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void paNewTray_DragDrop(object sender, DragEventArgs e)
        {
            // --- get object column
            DevExpress.XtraTreeList.Nodes.TreeListNode nodo = (DevExpress.XtraTreeList.Nodes.TreeListNode)e.Data.GetData(typeof(DevExpress.XtraTreeList.Nodes.TreeListNode));

            CBatch_detail_aa_twofoldFactory faBatch_detail_aa_twofold = new CBatch_detail_aa_twofoldFactory();
            CBatch_detail_aa_twofold sample = new CBatch_detail_aa_twofoldFactory().GetByPrimaryKey(new CBatch_detail_aa_twofoldKeys(Convert.ToInt64(nodo.GetValue("Idbatch_detail_aa"))));
            CBatchManager oBatchManager = new CBatchManager();
            long idbatch = Convert.ToInt64(oBatchManager.GetNewBatch(Idtemplate_method, Comun.GetUser(), Idbatch));
            sample.Idbatch = idbatch;
            faBatch_detail_aa_twofold.Update(sample);

            // --- refrescar arbol
            InitTreeBatch(Comun.StatusWork.Waiting);
        }

        #endregion

        #region drag and drop samples in GridView

        DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo hitInfo = null;
        private void gcBachCalc_MouseDown(object sender, MouseEventArgs e)
        {            
            hitInfo = bgvBatchCalc2.CalcHitInfo(new Point(e.X, e.Y));
            if (hitInfo.RowHandle < 0) hitInfo = null; 
        }

        private void gcBachCalc_MouseMove(object sender, MouseEventArgs e)
        {
            if (hitInfo == null) return;
            if (e.Button != MouseButtons.Left) return;
            Rectangle dragRect = new Rectangle(new Point(
                hitInfo.HitPoint.X - SystemInformation.DragSize.Width / 2,
                hitInfo.HitPoint.Y - SystemInformation.DragSize.Height / 2), SystemInformation.DragSize);
            if (!dragRect.Contains(new Point(e.X, e.Y)))
            {
                if (hitInfo.InRow)
                {
                    gcBachCalc.DoDragDrop(new object[] { hitInfo.RowHandle, gcBachCalc }, DragDropEffects.All);
                }
            }
        }

        private void gcBachCalc_DragOver(object sender, DragEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo hi = bgvBatchCalc2.CalcHitInfo(gcBachCalc.PointToClient(new Point(e.X, e.Y)));
            int handle = GetDragObject(sender, e.Data);
            if (hi.InRow && handle >= 0 && handle != hi.RowHandle)
            {
                if ((e.KeyState & 8) != 0)
                    e.Effect = DragDropEffects.Copy;
                else
                    e.Effect = DragDropEffects.Move;
            }
            else e.Effect = DragDropEffects.None;
            
        }

        private int GetDragObject(object sender, IDataObject data)
        {
            object[] obj = data.GetData(typeof(object[])) as object[];
            if (obj == null || !sender.Equals(gcBachCalc)) return -2;
            if (obj[0] is Int32)
                return (int)obj[0];
            else return -1;
        }

        private void gcBachCalc_DragDrop(object sender, DragEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo hi = bgvBatchCalc2.CalcHitInfo(gcBachCalc.PointToClient(new Point(e.X, e.Y)));
            int handle = GetDragObject(sender, e.Data);
            if (handle < 0) return;

            if (hi.InRow)
            {
                CBatch_detail_aa_twofold row_drag = bgvBatchCalc2.GetRow(handle) as CBatch_detail_aa_twofold;
                //the following code determines whether the target row is a group row and if a group row is detected, 
                //it retrieves the actual data row corresponding to it.
                int newHandle = hi.RowHandle;                
                CBatch_detail_aa_twofold row_drop = bgvBatchCalc2.GetRow(newHandle) as CBatch_detail_aa_twofold;
                oDataBatch.MovePositionRow(row_drag, row_drop);                
                gcBachCalc.DataSource = oDataBatch.ListSamples;
            }
        }

        #endregion

        

    }    

    
   
}
