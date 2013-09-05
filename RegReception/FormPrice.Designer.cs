namespace LimsProject
{
    partial class FormPrice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gvHistory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolHis_Button = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repBuOpenPrice = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcolHis_Idprice_version = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolHis_Cod_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolHis_Num_version = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolHis_Amount_item = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolHis_Unit_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolHis_Date_creation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPrice = new DevExpress.XtraGrid.GridControl();
            this.gvPrice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolItem_Num_item = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolItem_Idtemplate_method = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolItem_Rank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolItem_Amount_item = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repAmount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gcolItem_Unit_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolItem_Sale_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolItem_Den_method = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repTemplateMethod = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tbNumVersion = new DevExpress.XtraEditors.TextEdit();
            this.tbCodPrice = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.ucSign1 = new LimsProject.UcSign();
            this.cbTypeSample = new LimsProject.MyLookUpEdit();
            this.label26 = new System.Windows.Forms.Label();
            this.deDateExpiration = new DevExpress.XtraEditors.DateEdit();
            this.deDateCreation = new DevExpress.XtraEditors.DateEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbTotalIgv = new DevExpress.XtraEditors.SpinEdit();
            this.tbTotalAmount = new DevExpress.XtraEditors.SpinEdit();
            this.tbSubTotalAmount = new DevExpress.XtraEditors.SpinEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ucCopyTo = new LimsProject.UcGenerar();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumDaysValid = new DevExpress.XtraEditors.SpinEdit();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.tabHead = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage8 = new DevExpress.XtraTab.XtraTabPage();
            this.tbObservation = new DevExpress.XtraEditors.MemoEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.tbFax = new DevExpress.XtraEditors.TextEdit();
            this.tbClientPhone = new DevExpress.XtraEditors.TextEdit();
            this.tbClientRuc = new DevExpress.XtraEditors.TextEdit();
            this.tbClientDomicile = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCompany = new LimsProject.MyLookUpEdit();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.gcContact = new DevExpress.XtraGrid.GridControl();
            this.gvContact = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCon_Idprice_company_person = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCon_Idperson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCon_Idcompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCon_Idrecep_sample = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCon_Allname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCon_Mail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCon_Person_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repPerson_type = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcCon_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repPhone = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gcCon_Cellphone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCellPhone = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repNum = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.ckDispatchFax = new DevExpress.XtraEditors.CheckEdit();
            this.ckDispatchPerson = new DevExpress.XtraEditors.CheckEdit();
            this.ckDispatchTransport = new DevExpress.XtraEditors.CheckEdit();
            this.ckDispatchCurier = new DevExpress.XtraEditors.CheckEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gcAnexos = new DevExpress.XtraGrid.GridControl();
            this.gvAnexos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolAt_Filename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repOpenFile = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcolAt_Idprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolAt_Idprice_version = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolAt_Num_version = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repText = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gcolAt_Source_filename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabParagraphIni = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.richTextIni = new RichTextBoxExtended.RichTextBoxExtended();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.ckSaveHistoryIni = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcParagraphHistoryIni = new DevExpress.XtraGrid.GridControl();
            this.gvParagraphHistoryIni = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolphi_Paragraph = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gcolphi_Paragraph_rtf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSelectIni = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tabItems = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl10 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelControl9 = new DevExpress.XtraEditors.PanelControl();
            this.btAdd = new DevExpress.XtraEditors.SimpleButton();
            this.cbMethodAdd = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.tabParagraphEnd = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.richTextEnd = new RichTextBoxExtended.RichTextBoxExtended();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.ckSaveHistoryEnd = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.gcParagraphHistoryEnd = new DevExpress.XtraGrid.GridControl();
            this.gvParagraphHistoryEnd = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolPhe_Paragraph_rtf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolPhe_Paragraph = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repSelectEnd = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btRefreshParagraphIni = new DevExpress.XtraEditors.SimpleButton();
            this.btDesign = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.ucToolButtons = new LimsProject.UcToolStrip();
            this.previewControl1 = new FastReport.Preview.PreviewControl();
            this.panelControl8 = new DevExpress.XtraEditors.PanelControl();
            this.ofdPrice = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).BeginInit();
            this.paTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).BeginInit();
            this.paBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.paCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            this.paTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBuOpenPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTemplateMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTypeSample.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateExpiration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateCreation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTotalIgv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumDaysValid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.tabHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).BeginInit();
            this.xtraTabControl3.SuspendLayout();
            this.xtraTabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbObservation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientRuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientDomicile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCompany.Properties)).BeginInit();
            this.xtraTabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPerson_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCellPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNum)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckDispatchFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckDispatchPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckDispatchTransport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckDispatchCurier.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAnexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repOpenFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repText)).BeginInit();
            this.tabParagraphIni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckSaveHistoryIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcParagraphHistoryIni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParagraphHistoryIni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSelectIni)).BeginInit();
            this.tabItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).BeginInit();
            this.panelControl10.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).BeginInit();
            this.panelControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMethodAdd.Properties)).BeginInit();
            this.tabParagraphEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckSaveHistoryEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcParagraphHistoryEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParagraphHistoryEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSelectEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).BeginInit();
            this.panelControl8.SuspendLayout();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Size = new System.Drawing.Size(999, 33);
            this.laTitle.Text = "Cotizaciones";
            // 
            // paTitle
            // 
            this.paTitle.Location = new System.Drawing.Point(0, 25);
            this.paTitle.Size = new System.Drawing.Size(1003, 37);
            // 
            // paBottom
            // 
            this.paBottom.Controls.Add(this.ucCopyTo);
            this.paBottom.Controls.Add(this.ucSign1);
            this.paBottom.Location = new System.Drawing.Point(0, 550);
            this.paBottom.Size = new System.Drawing.Size(1003, 45);
            this.paBottom.TabIndex = 2;
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.previewControl1);
            this.paCenter.Controls.Add(this.panelControl8);
            this.paCenter.Controls.Add(this.xtraTabControl2);
            this.paCenter.Location = new System.Drawing.Point(0, 84);
            this.paCenter.Size = new System.Drawing.Size(1003, 466);
            this.paCenter.TabIndex = 1;
            // 
            // paTop
            // 
            this.paTop.Controls.Add(this.label6);
            this.paTop.Location = new System.Drawing.Point(0, 62);
            this.paTop.Size = new System.Drawing.Size(1003, 22);
            this.paTop.TabIndex = 0;
            this.paTop.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ucToolButtons);
            this.panelControl1.Size = new System.Drawing.Size(1003, 25);
            // 
            // gvHistory
            // 
            this.gvHistory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolHis_Button,
            this.gcolHis_Idprice_version,
            this.gcolHis_Cod_price,
            this.gcolHis_Num_version,
            this.gcolHis_Amount_item,
            this.gcolHis_Unit_price,
            this.gcolHis_Date_creation});
            this.gvHistory.GridControl = this.gcPrice;
            this.gvHistory.Name = "gvHistory";
            this.gvHistory.OptionsDetail.ShowDetailTabs = false;
            this.gvHistory.OptionsView.ShowGroupPanel = false;
            // 
            // gcolHis_Button
            // 
            this.gcolHis_Button.Caption = "#";
            this.gcolHis_Button.ColumnEdit = this.repBuOpenPrice;
            this.gcolHis_Button.Name = "gcolHis_Button";
            this.gcolHis_Button.OptionsColumn.AllowSize = false;
            this.gcolHis_Button.Visible = true;
            this.gcolHis_Button.VisibleIndex = 0;
            this.gcolHis_Button.Width = 47;
            // 
            // repBuOpenPrice
            // 
            this.repBuOpenPrice.AutoHeight = false;
            this.repBuOpenPrice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Abrir", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.repBuOpenPrice.Name = "repBuOpenPrice";
            this.repBuOpenPrice.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repBuOpenPrice.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repBuOpenPrice_ButtonClick);
            // 
            // gcolHis_Idprice_version
            // 
            this.gcolHis_Idprice_version.Caption = "Idprice_version";
            this.gcolHis_Idprice_version.FieldName = "Idprice_version";
            this.gcolHis_Idprice_version.Name = "gcolHis_Idprice_version";
            // 
            // gcolHis_Cod_price
            // 
            this.gcolHis_Cod_price.Caption = "Código";
            this.gcolHis_Cod_price.FieldName = "Cod_price";
            this.gcolHis_Cod_price.Name = "gcolHis_Cod_price";
            this.gcolHis_Cod_price.Visible = true;
            this.gcolHis_Cod_price.VisibleIndex = 1;
            this.gcolHis_Cod_price.Width = 103;
            // 
            // gcolHis_Num_version
            // 
            this.gcolHis_Num_version.Caption = "Versión";
            this.gcolHis_Num_version.FieldName = "Num_version";
            this.gcolHis_Num_version.Name = "gcolHis_Num_version";
            this.gcolHis_Num_version.Visible = true;
            this.gcolHis_Num_version.VisibleIndex = 2;
            this.gcolHis_Num_version.Width = 103;
            // 
            // gcolHis_Amount_item
            // 
            this.gcolHis_Amount_item.Caption = "Cantidad";
            this.gcolHis_Amount_item.FieldName = "Amount_item";
            this.gcolHis_Amount_item.Name = "gcolHis_Amount_item";
            this.gcolHis_Amount_item.Visible = true;
            this.gcolHis_Amount_item.VisibleIndex = 3;
            this.gcolHis_Amount_item.Width = 103;
            // 
            // gcolHis_Unit_price
            // 
            this.gcolHis_Unit_price.Caption = "P.Unitario";
            this.gcolHis_Unit_price.FieldName = "Unit_price";
            this.gcolHis_Unit_price.Name = "gcolHis_Unit_price";
            this.gcolHis_Unit_price.Visible = true;
            this.gcolHis_Unit_price.VisibleIndex = 4;
            this.gcolHis_Unit_price.Width = 103;
            // 
            // gcolHis_Date_creation
            // 
            this.gcolHis_Date_creation.Caption = "F.Creación";
            this.gcolHis_Date_creation.FieldName = "Date_creation";
            this.gcolHis_Date_creation.Name = "gcolHis_Date_creation";
            this.gcolHis_Date_creation.Visible = true;
            this.gcolHis_Date_creation.VisibleIndex = 5;
            this.gcolHis_Date_creation.Width = 113;
            // 
            // gcPrice
            // 
            this.gcPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPrice.EmbeddedNavigator.Buttons.First.Enabled = false;
            this.gcPrice.EmbeddedNavigator.Buttons.Last.Enabled = false;
            this.gcPrice.EmbeddedNavigator.Buttons.NextPage.Enabled = false;
            this.gcPrice.EmbeddedNavigator.Buttons.PrevPage.Enabled = false;
            this.gcPrice.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gvHistory;
            gridLevelNode1.RelationName = "History";
            this.gcPrice.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcPrice.Location = new System.Drawing.Point(0, 60);
            this.gcPrice.MainView = this.gvPrice;
            this.gcPrice.Name = "gcPrice";
            this.gcPrice.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repAmount,
            this.repTemplateMethod,
            this.repositoryItemMemoEdit3,
            this.repBuOpenPrice});
            this.gcPrice.Size = new System.Drawing.Size(593, 0);
            this.gcPrice.TabIndex = 0;
            this.gcPrice.UseEmbeddedNavigator = true;
            this.gcPrice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPrice,
            this.gvHistory});
            this.gcPrice.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.gcPrice_ViewRegistered);
            // 
            // gvPrice
            // 
            this.gvPrice.Appearance.Row.Options.UseTextOptions = true;
            this.gvPrice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gcolItem_Num_item,
            this.gcolItem_Idtemplate_method,
            this.gcolItem_Rank,
            this.gcolItem_Amount_item,
            this.gcolItem_Unit_price,
            this.gcolItem_Sale_price,
            this.gcolItem_Den_method});
            this.gvPrice.GridControl = this.gcPrice;
            this.gvPrice.Name = "gvPrice";
            this.gvPrice.OptionsDetail.EnableDetailToolTip = true;
            this.gvPrice.OptionsDetail.ShowDetailTabs = false;
            this.gvPrice.OptionsView.RowAutoHeight = true;
            this.gvPrice.OptionsView.ShowGroupPanel = false;
            this.gvPrice.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvPrice_CellValueChanged);
            this.gvPrice.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvPrice_RowUpdated);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "idCotizacion";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gcolItem_Num_item
            // 
            this.gcolItem_Num_item.Caption = "Item";
            this.gcolItem_Num_item.FieldName = "Num_item";
            this.gcolItem_Num_item.Name = "gcolItem_Num_item";
            this.gcolItem_Num_item.OptionsColumn.AllowEdit = false;
            this.gcolItem_Num_item.OptionsFilter.AllowAutoFilter = false;
            this.gcolItem_Num_item.OptionsFilter.AllowFilter = false;
            this.gcolItem_Num_item.Visible = true;
            this.gcolItem_Num_item.VisibleIndex = 0;
            this.gcolItem_Num_item.Width = 32;
            // 
            // gcolItem_Idtemplate_method
            // 
            this.gcolItem_Idtemplate_method.Caption = "Método";
            this.gcolItem_Idtemplate_method.FieldName = "Idtemplate_method";
            this.gcolItem_Idtemplate_method.Name = "gcolItem_Idtemplate_method";
            this.gcolItem_Idtemplate_method.Width = 370;
            // 
            // gcolItem_Rank
            // 
            this.gcolItem_Rank.Caption = "Rango";
            this.gcolItem_Rank.FieldName = "Rank";
            this.gcolItem_Rank.Name = "gcolItem_Rank";
            this.gcolItem_Rank.OptionsColumn.AllowEdit = false;
            this.gcolItem_Rank.Visible = true;
            this.gcolItem_Rank.VisibleIndex = 2;
            this.gcolItem_Rank.Width = 63;
            // 
            // gcolItem_Amount_item
            // 
            this.gcolItem_Amount_item.Caption = "Cantidad";
            this.gcolItem_Amount_item.ColumnEdit = this.repAmount;
            this.gcolItem_Amount_item.FieldName = "Amount_item";
            this.gcolItem_Amount_item.Name = "gcolItem_Amount_item";
            this.gcolItem_Amount_item.OptionsFilter.AllowAutoFilter = false;
            this.gcolItem_Amount_item.OptionsFilter.AllowFilter = false;
            this.gcolItem_Amount_item.Visible = true;
            this.gcolItem_Amount_item.VisibleIndex = 3;
            this.gcolItem_Amount_item.Width = 60;
            // 
            // repAmount
            // 
            this.repAmount.AutoHeight = false;
            this.repAmount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repAmount.Name = "repAmount";
            this.repAmount.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repAmount_EditValueChanging);
            // 
            // gcolItem_Unit_price
            // 
            this.gcolItem_Unit_price.Caption = "P. Unitario";
            this.gcolItem_Unit_price.FieldName = "Unit_price";
            this.gcolItem_Unit_price.Name = "gcolItem_Unit_price";
            this.gcolItem_Unit_price.OptionsFilter.AllowAutoFilter = false;
            this.gcolItem_Unit_price.OptionsFilter.AllowFilter = false;
            this.gcolItem_Unit_price.Visible = true;
            this.gcolItem_Unit_price.VisibleIndex = 4;
            this.gcolItem_Unit_price.Width = 70;
            // 
            // gcolItem_Sale_price
            // 
            this.gcolItem_Sale_price.Caption = "P.Venta";
            this.gcolItem_Sale_price.FieldName = "Sale_price";
            this.gcolItem_Sale_price.Name = "gcolItem_Sale_price";
            this.gcolItem_Sale_price.OptionsColumn.AllowEdit = false;
            this.gcolItem_Sale_price.OptionsFilter.AllowAutoFilter = false;
            this.gcolItem_Sale_price.OptionsFilter.AllowFilter = false;
            this.gcolItem_Sale_price.Visible = true;
            this.gcolItem_Sale_price.VisibleIndex = 5;
            this.gcolItem_Sale_price.Width = 67;
            // 
            // gcolItem_Den_method
            // 
            this.gcolItem_Den_method.Caption = "Método";
            this.gcolItem_Den_method.ColumnEdit = this.repositoryItemMemoEdit3;
            this.gcolItem_Den_method.FieldName = "Den_method";
            this.gcolItem_Den_method.Name = "gcolItem_Den_method";
            this.gcolItem_Den_method.Visible = true;
            this.gcolItem_Den_method.VisibleIndex = 1;
            this.gcolItem_Den_method.Width = 280;
            // 
            // repositoryItemMemoEdit3
            // 
            this.repositoryItemMemoEdit3.Name = "repositoryItemMemoEdit3";
            // 
            // repTemplateMethod
            // 
            this.repTemplateMethod.Appearance.Options.UseTextOptions = true;
            this.repTemplateMethod.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repTemplateMethod.AutoHeight = false;
            this.repTemplateMethod.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTemplateMethod.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idtemplate_method", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title")});
            this.repTemplateMethod.Name = "repTemplateMethod";
            this.repTemplateMethod.NullText = "Seleccionar";
            this.repTemplateMethod.ShowFooter = false;
            this.repTemplateMethod.ShowHeader = false;
            // 
            // tbNumVersion
            // 
            this.tbNumVersion.Location = new System.Drawing.Point(212, 14);
            this.tbNumVersion.Name = "tbNumVersion";
            this.tbNumVersion.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(222)))), ((int)(((byte)(243)))));
            this.tbNumVersion.Properties.Appearance.Options.UseBackColor = true;
            this.tbNumVersion.Properties.ReadOnly = true;
            this.tbNumVersion.Size = new System.Drawing.Size(43, 20);
            this.tbNumVersion.TabIndex = 16;
            this.tbNumVersion.TabStop = false;
            // 
            // tbCodPrice
            // 
            this.tbCodPrice.Location = new System.Drawing.Point(110, 14);
            this.tbCodPrice.Name = "tbCodPrice";
            this.tbCodPrice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(222)))), ((int)(((byte)(243)))));
            this.tbCodPrice.Properties.Appearance.Options.UseBackColor = true;
            this.tbCodPrice.Properties.ReadOnly = true;
            this.tbCodPrice.Size = new System.Drawing.Size(100, 20);
            this.tbCodPrice.TabIndex = 14;
            this.tbCodPrice.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Cod. Cotización:";
            // 
            // ucSign1
            // 
            this.ucSign1.Location = new System.Drawing.Point(7, 3);
            this.ucSign1.Margin = new System.Windows.Forms.Padding(0);
            this.ucSign1.Name = "ucSign1";
            this.ucSign1.Pwd = null;
            this.ucSign1.Size = new System.Drawing.Size(158, 40);
            this.ucSign1.TabIndex = 0;
            this.ucSign1.Title = "";
            this.ucSign1.OnSign += new LimsProject.sign(this.ucSign1_OnSign);
            // 
            // cbTypeSample
            // 
            this.cbTypeSample.Location = new System.Drawing.Point(90, 6);
            this.cbTypeSample.Name = "cbTypeSample";
            this.cbTypeSample.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTypeSample.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cod_type_sample", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name_type_sample")});
            this.cbTypeSample.Properties.NullText = "Seleccionar";
            this.cbTypeSample.Properties.ShowFooter = false;
            this.cbTypeSample.Properties.ShowHeader = false;
            this.cbTypeSample.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbTypeSample.Size = new System.Drawing.Size(145, 20);
            this.cbTypeSample.TabIndex = 0;
            this.cbTypeSample.EditValueChanged += new System.EventHandler(this.cbTypeSample_EditValueChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(4, 9);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(86, 13);
            this.label26.TabIndex = 18;
            this.label26.Text = "Tipo de muestra:";
            // 
            // deDateExpiration
            // 
            this.deDateExpiration.EditValue = null;
            this.deDateExpiration.Location = new System.Drawing.Point(414, 36);
            this.deDateExpiration.Name = "deDateExpiration";
            this.deDateExpiration.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateExpiration.Properties.ReadOnly = true;
            this.deDateExpiration.Size = new System.Drawing.Size(89, 20);
            this.deDateExpiration.TabIndex = 5;
            // 
            // deDateCreation
            // 
            this.deDateCreation.EditValue = null;
            this.deDateCreation.Location = new System.Drawing.Point(110, 36);
            this.deDateCreation.Name = "deDateCreation";
            this.deDateCreation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateCreation.Properties.ReadOnly = true;
            this.deDateCreation.Size = new System.Drawing.Size(89, 20);
            this.deDateCreation.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(337, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Válido hasta :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(51, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Creado el :";
            // 
            // tbTotalIgv
            // 
            this.tbTotalIgv.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbTotalIgv.Location = new System.Drawing.Point(58, 23);
            this.tbTotalIgv.Name = "tbTotalIgv";
            this.tbTotalIgv.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbTotalIgv.Properties.Appearance.Options.UseBackColor = true;
            this.tbTotalIgv.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.tbTotalIgv.Properties.Mask.EditMask = "n2";
            this.tbTotalIgv.Properties.ReadOnly = true;
            this.tbTotalIgv.Size = new System.Drawing.Size(87, 20);
            this.tbTotalIgv.TabIndex = 21;
            this.tbTotalIgv.TabStop = false;
            // 
            // tbTotalAmount
            // 
            this.tbTotalAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbTotalAmount.Location = new System.Drawing.Point(58, 44);
            this.tbTotalAmount.Name = "tbTotalAmount";
            this.tbTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.tbTotalAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.tbTotalAmount.Properties.Mask.EditMask = "n2";
            this.tbTotalAmount.Properties.ReadOnly = true;
            this.tbTotalAmount.Size = new System.Drawing.Size(87, 20);
            this.tbTotalAmount.TabIndex = 22;
            this.tbTotalAmount.TabStop = false;
            // 
            // tbSubTotalAmount
            // 
            this.tbSubTotalAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbSubTotalAmount.Location = new System.Drawing.Point(58, 2);
            this.tbSubTotalAmount.Name = "tbSubTotalAmount";
            this.tbSubTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbSubTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.tbSubTotalAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.tbSubTotalAmount.Properties.Mask.EditMask = "n2";
            this.tbSubTotalAmount.Properties.ReadOnly = true;
            this.tbSubTotalAmount.Size = new System.Drawing.Size(87, 20);
            this.tbSubTotalAmount.TabIndex = 23;
            this.tbSubTotalAmount.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Igv:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sub total:";
            // 
            // ucCopyTo
            // 
            this.ucCopyTo.Location = new System.Drawing.Point(340, 11);
            this.ucCopyTo.Margin = new System.Windows.Forms.Padding(0);
            this.ucCopyTo.Name = "ucCopyTo";
            this.ucCopyTo.Size = new System.Drawing.Size(90, 30);
            this.ucCopyTo.TabIndex = 26;
            this.ucCopyTo.Title = "Copiar a";
            this.ucCopyTo.onSelectedIndex += new LimsProject.SelectedIndex(this.ucCopyTo_onSelectedIndex);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Días de validez :";
            // 
            // tbNumDaysValid
            // 
            this.tbNumDaysValid.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbNumDaysValid.Location = new System.Drawing.Point(292, 36);
            this.tbNumDaysValid.Name = "tbNumDaysValid";
            this.tbNumDaysValid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbNumDaysValid.Size = new System.Drawing.Size(42, 20);
            this.tbNumDaysValid.TabIndex = 4;
            this.tbNumDaysValid.EditValueChanged += new System.EventHandler(this.tbNumDaysValid_EditValueChanged);
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.xtraTabControl2.Appearance.Options.UseBackColor = true;
            this.xtraTabControl2.AppearancePage.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(222)))), ((int)(((byte)(243)))));
            this.xtraTabControl2.AppearancePage.Header.BorderColor = System.Drawing.Color.White;
            this.xtraTabControl2.AppearancePage.Header.Options.UseBackColor = true;
            this.xtraTabControl2.AppearancePage.Header.Options.UseBorderColor = true;
            this.xtraTabControl2.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.LightSteelBlue;
            this.xtraTabControl2.AppearancePage.HeaderActive.BorderColor = System.Drawing.Color.Gainsboro;
            this.xtraTabControl2.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.xtraTabControl2.AppearancePage.HeaderActive.Options.UseBorderColor = true;
            this.xtraTabControl2.AppearancePage.PageClient.BorderColor = System.Drawing.Color.Gainsboro;
            this.xtraTabControl2.AppearancePage.PageClient.Options.UseBorderColor = true;
            this.xtraTabControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.xtraTabControl2.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.PaintStyleName = "PropertyView";
            this.xtraTabControl2.SelectedTabPage = this.tabHead;
            this.xtraTabControl2.Size = new System.Drawing.Size(595, 462);
            this.xtraTabControl2.TabIndex = 5;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabHead,
            this.tabParagraphIni,
            this.tabItems,
            this.tabParagraphEnd});
            // 
            // tabHead
            // 
            this.tabHead.Controls.Add(this.xtraTabControl3);
            this.tabHead.Controls.Add(this.xtraTabControl1);
            this.tabHead.Controls.Add(this.tbNumDaysValid);
            this.tabHead.Controls.Add(this.label16);
            this.tabHead.Controls.Add(this.label15);
            this.tabHead.Controls.Add(this.label17);
            this.tabHead.Controls.Add(this.label3);
            this.tabHead.Controls.Add(this.tbNumVersion);
            this.tabHead.Controls.Add(this.deDateExpiration);
            this.tabHead.Controls.Add(this.tbCodPrice);
            this.tabHead.Controls.Add(this.deDateCreation);
            this.tabHead.Name = "tabHead";
            this.tabHead.Size = new System.Drawing.Size(593, 441);
            this.tabHead.Text = "Datos";
            // 
            // xtraTabControl3
            // 
            this.xtraTabControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.xtraTabControl3.Appearance.Options.UseBackColor = true;
            this.xtraTabControl3.AppearancePage.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(222)))), ((int)(((byte)(243)))));
            this.xtraTabControl3.AppearancePage.Header.BorderColor = System.Drawing.Color.White;
            this.xtraTabControl3.AppearancePage.Header.Options.UseBackColor = true;
            this.xtraTabControl3.AppearancePage.Header.Options.UseBorderColor = true;
            this.xtraTabControl3.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.LightSteelBlue;
            this.xtraTabControl3.AppearancePage.HeaderActive.BorderColor = System.Drawing.Color.Gainsboro;
            this.xtraTabControl3.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.xtraTabControl3.AppearancePage.HeaderActive.Options.UseBorderColor = true;
            this.xtraTabControl3.AppearancePage.PageClient.BorderColor = System.Drawing.Color.Gainsboro;
            this.xtraTabControl3.AppearancePage.PageClient.Options.UseBorderColor = true;
            this.xtraTabControl3.Location = new System.Drawing.Point(21, 293);
            this.xtraTabControl3.Name = "xtraTabControl3";
            this.xtraTabControl3.PaintStyleName = "PropertyView";
            this.xtraTabControl3.SelectedTabPage = this.xtraTabPage8;
            this.xtraTabControl3.Size = new System.Drawing.Size(534, 134);
            this.xtraTabControl3.TabIndex = 19;
            this.xtraTabControl3.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage8});
            this.xtraTabControl3.Text = "xtraTabControl1";
            // 
            // xtraTabPage8
            // 
            this.xtraTabPage8.Controls.Add(this.tbObservation);
            this.xtraTabPage8.Name = "xtraTabPage8";
            this.xtraTabPage8.Padding = new System.Windows.Forms.Padding(10);
            this.xtraTabPage8.Size = new System.Drawing.Size(532, 113);
            this.xtraTabPage8.Text = "Observaciones";
            // 
            // tbObservation
            // 
            this.tbObservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbObservation.Location = new System.Drawing.Point(10, 10);
            this.tbObservation.Name = "tbObservation";
            this.tbObservation.Size = new System.Drawing.Size(512, 93);
            this.tbObservation.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.AppearancePage.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(222)))), ((int)(((byte)(243)))));
            this.xtraTabControl1.AppearancePage.Header.BorderColor = System.Drawing.Color.White;
            this.xtraTabControl1.AppearancePage.Header.Options.UseBackColor = true;
            this.xtraTabControl1.AppearancePage.Header.Options.UseBorderColor = true;
            this.xtraTabControl1.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.LightSteelBlue;
            this.xtraTabControl1.AppearancePage.HeaderActive.BorderColor = System.Drawing.Color.Gainsboro;
            this.xtraTabControl1.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.xtraTabControl1.AppearancePage.HeaderActive.Options.UseBorderColor = true;
            this.xtraTabControl1.AppearancePage.PageClient.BorderColor = System.Drawing.Color.Gainsboro;
            this.xtraTabControl1.AppearancePage.PageClient.Options.UseBorderColor = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(21, 82);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.PaintStyleName = "PropertyView";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl1.Size = new System.Drawing.Size(534, 205);
            this.xtraTabControl1.TabIndex = 19;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage6,
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.Text = "xtraTabControl1";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.tbFax);
            this.xtraTabPage3.Controls.Add(this.tbClientPhone);
            this.xtraTabPage3.Controls.Add(this.tbClientRuc);
            this.xtraTabPage3.Controls.Add(this.tbClientDomicile);
            this.xtraTabPage3.Controls.Add(this.label9);
            this.xtraTabPage3.Controls.Add(this.label28);
            this.xtraTabPage3.Controls.Add(this.label11);
            this.xtraTabPage3.Controls.Add(this.label8);
            this.xtraTabPage3.Controls.Add(this.label10);
            this.xtraTabPage3.Controls.Add(this.cbCompany);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(532, 184);
            this.xtraTabPage3.Text = "Cliente";
            // 
            // tbFax
            // 
            this.tbFax.Location = new System.Drawing.Point(176, 71);
            this.tbFax.Name = "tbFax";
            this.tbFax.Properties.Mask.EditMask = "\\+\\d\\d(\\(\\d{1,3}\\))\\d{1,10}";
            this.tbFax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tbFax.Size = new System.Drawing.Size(74, 20);
            this.tbFax.TabIndex = 6;
            // 
            // tbClientPhone
            // 
            this.tbClientPhone.Location = new System.Drawing.Point(66, 71);
            this.tbClientPhone.Name = "tbClientPhone";
            this.tbClientPhone.Properties.Mask.EditMask = "\\+\\d\\d(\\(\\d{1,3}\\))\\d{1,10}";
            this.tbClientPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tbClientPhone.Size = new System.Drawing.Size(74, 20);
            this.tbClientPhone.TabIndex = 6;
            // 
            // tbClientRuc
            // 
            this.tbClientRuc.Location = new System.Drawing.Point(66, 27);
            this.tbClientRuc.Name = "tbClientRuc";
            this.tbClientRuc.Properties.Mask.EditMask = "\\d{0,11}";
            this.tbClientRuc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tbClientRuc.Size = new System.Drawing.Size(123, 20);
            this.tbClientRuc.TabIndex = 3;
            // 
            // tbClientDomicile
            // 
            this.tbClientDomicile.Location = new System.Drawing.Point(66, 49);
            this.tbClientDomicile.Name = "tbClientDomicile";
            this.tbClientDomicile.Size = new System.Drawing.Size(424, 20);
            this.tbClientDomicile.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ruc:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(143, 74);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(27, 13);
            this.label28.TabIndex = 9;
            this.label28.Text = "Fax:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Tel:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Domicilio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nombre:";
            // 
            // cbCompany
            // 
            this.cbCompany.Location = new System.Drawing.Point(66, 5);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idcompany", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Business_name")});
            this.cbCompany.Properties.NullText = "Seleccionar";
            this.cbCompany.Properties.ShowFooter = false;
            this.cbCompany.Properties.ShowHeader = false;
            this.cbCompany.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbCompany.Size = new System.Drawing.Size(259, 20);
            this.cbCompany.TabIndex = 2;
            this.cbCompany.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.cbCompany_ProcessNewValue);
            this.cbCompany.EditValueChanged += new System.EventHandler(this.cbCompany_EditValueChanged);
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Controls.Add(this.gcContact);
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Padding = new System.Windows.Forms.Padding(10);
            this.xtraTabPage6.Size = new System.Drawing.Size(532, 184);
            this.xtraTabPage6.Text = "Contactos";
            // 
            // gcContact
            // 
            this.gcContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcContact.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gcContact.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gcContact.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gcContact.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gcContact.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gcContact.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gcContact.EmbeddedNavigator.Name = "";
            this.gcContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcContact.Location = new System.Drawing.Point(10, 10);
            this.gcContact.MainView = this.gvContact;
            this.gcContact.Name = "gcContact";
            this.gcContact.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repPerson_type,
            this.repNum,
            this.repCellPhone,
            this.repPhone});
            this.gcContact.Size = new System.Drawing.Size(512, 164);
            this.gcContact.TabIndex = 0;
            this.gcContact.UseEmbeddedNavigator = true;
            this.gcContact.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvContact});
            // 
            // gvContact
            // 
            this.gvContact.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcCon_Idprice_company_person,
            this.gcCon_Idperson,
            this.gcCon_Idcompany,
            this.gcCon_Idrecep_sample,
            this.gcCon_Allname,
            this.gcCon_Mail,
            this.gcCon_Person_type,
            this.gcCon_Phone,
            this.gcCon_Cellphone});
            this.gvContact.GridControl = this.gcContact;
            this.gvContact.Name = "gvContact";
            this.gvContact.OptionsView.ShowGroupPanel = false;
            this.gvContact.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvContact_InitNewRow);
            // 
            // gcCon_Idprice_company_person
            // 
            this.gcCon_Idprice_company_person.Caption = "Idprice_company_person";
            this.gcCon_Idprice_company_person.FieldName = "Idprice_company_person";
            this.gcCon_Idprice_company_person.Name = "gcCon_Idprice_company_person";
            // 
            // gcCon_Idperson
            // 
            this.gcCon_Idperson.Caption = "Idperson";
            this.gcCon_Idperson.FieldName = "Idperson";
            this.gcCon_Idperson.Name = "gcCon_Idperson";
            // 
            // gcCon_Idcompany
            // 
            this.gcCon_Idcompany.Caption = "Idcompany";
            this.gcCon_Idcompany.FieldName = "Idcompany";
            this.gcCon_Idcompany.Name = "gcCon_Idcompany";
            // 
            // gcCon_Idrecep_sample
            // 
            this.gcCon_Idrecep_sample.Caption = "Idrecep_sample";
            this.gcCon_Idrecep_sample.FieldName = "Idrecep_sample";
            this.gcCon_Idrecep_sample.Name = "gcCon_Idrecep_sample";
            // 
            // gcCon_Allname
            // 
            this.gcCon_Allname.Caption = "Nombre";
            this.gcCon_Allname.FieldName = "Allname";
            this.gcCon_Allname.Name = "gcCon_Allname";
            this.gcCon_Allname.Visible = true;
            this.gcCon_Allname.VisibleIndex = 0;
            this.gcCon_Allname.Width = 152;
            // 
            // gcCon_Mail
            // 
            this.gcCon_Mail.Caption = "Email";
            this.gcCon_Mail.FieldName = "Mail";
            this.gcCon_Mail.Name = "gcCon_Mail";
            this.gcCon_Mail.Visible = true;
            this.gcCon_Mail.VisibleIndex = 1;
            this.gcCon_Mail.Width = 122;
            // 
            // gcCon_Person_type
            // 
            this.gcCon_Person_type.Caption = "Tipo";
            this.gcCon_Person_type.ColumnEdit = this.repPerson_type;
            this.gcCon_Person_type.FieldName = "Person_type";
            this.gcCon_Person_type.Name = "gcCon_Person_type";
            this.gcCon_Person_type.Visible = true;
            this.gcCon_Person_type.VisibleIndex = 2;
            this.gcCon_Person_type.Width = 64;
            // 
            // repPerson_type
            // 
            this.repPerson_type.AutoHeight = false;
            this.repPerson_type.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repPerson_type.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name")});
            this.repPerson_type.Name = "repPerson_type";
            this.repPerson_type.NullText = "";
            this.repPerson_type.ShowFooter = false;
            this.repPerson_type.ShowHeader = false;
            // 
            // gcCon_Phone
            // 
            this.gcCon_Phone.Caption = "Teléfono";
            this.gcCon_Phone.ColumnEdit = this.repPhone;
            this.gcCon_Phone.FieldName = "Phone";
            this.gcCon_Phone.Name = "gcCon_Phone";
            this.gcCon_Phone.Visible = true;
            this.gcCon_Phone.VisibleIndex = 3;
            this.gcCon_Phone.Width = 85;
            // 
            // repPhone
            // 
            this.repPhone.AutoHeight = false;
            this.repPhone.Mask.EditMask = "\\+\\d\\d(\\(\\d{1,2}\\))\\d{1,10}";
            this.repPhone.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repPhone.Name = "repPhone";
            // 
            // gcCon_Cellphone
            // 
            this.gcCon_Cellphone.Caption = "Celular";
            this.gcCon_Cellphone.ColumnEdit = this.repCellPhone;
            this.gcCon_Cellphone.FieldName = "Cellphone";
            this.gcCon_Cellphone.Name = "gcCon_Cellphone";
            this.gcCon_Cellphone.Visible = true;
            this.gcCon_Cellphone.VisibleIndex = 4;
            this.gcCon_Cellphone.Width = 88;
            // 
            // repCellPhone
            // 
            this.repCellPhone.AutoHeight = false;
            this.repCellPhone.Mask.EditMask = "(\\(\\d{1,3}\\))?\\d{1,3}-\\d{1,3}-\\d{1,6}";
            this.repCellPhone.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repCellPhone.Name = "repCellPhone";
            // 
            // repNum
            // 
            this.repNum.AutoHeight = false;
            this.repNum.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.repNum.IsFloatValue = false;
            this.repNum.Mask.EditMask = "N00";
            this.repNum.Name = "repNum";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.ckDispatchFax);
            this.xtraTabPage1.Controls.Add(this.ckDispatchPerson);
            this.xtraTabPage1.Controls.Add(this.ckDispatchTransport);
            this.xtraTabPage1.Controls.Add(this.ckDispatchCurier);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(532, 184);
            this.xtraTabPage1.Text = "Envío";
            // 
            // ckDispatchFax
            // 
            this.ckDispatchFax.Location = new System.Drawing.Point(141, 15);
            this.ckDispatchFax.Name = "ckDispatchFax";
            this.ckDispatchFax.Properties.Caption = "Fax";
            this.ckDispatchFax.Size = new System.Drawing.Size(107, 19);
            this.ckDispatchFax.TabIndex = 0;
            // 
            // ckDispatchPerson
            // 
            this.ckDispatchPerson.Location = new System.Drawing.Point(20, 15);
            this.ckDispatchPerson.Name = "ckDispatchPerson";
            this.ckDispatchPerson.Properties.Caption = "Personal";
            this.ckDispatchPerson.Size = new System.Drawing.Size(75, 19);
            this.ckDispatchPerson.TabIndex = 0;
            // 
            // ckDispatchTransport
            // 
            this.ckDispatchTransport.Location = new System.Drawing.Point(20, 53);
            this.ckDispatchTransport.Name = "ckDispatchTransport";
            this.ckDispatchTransport.Properties.Caption = "Emp. Transporte";
            this.ckDispatchTransport.Size = new System.Drawing.Size(107, 19);
            this.ckDispatchTransport.TabIndex = 0;
            // 
            // ckDispatchCurier
            // 
            this.ckDispatchCurier.Location = new System.Drawing.Point(20, 34);
            this.ckDispatchCurier.Name = "ckDispatchCurier";
            this.ckDispatchCurier.Properties.Caption = "Curier";
            this.ckDispatchCurier.Size = new System.Drawing.Size(75, 19);
            this.ckDispatchCurier.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gcAnexos);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.xtraTabPage2.Size = new System.Drawing.Size(532, 184);
            this.xtraTabPage2.Text = "Anexos";
            // 
            // gcAnexos
            // 
            this.gcAnexos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAnexos.EmbeddedNavigator.Name = "";
            this.gcAnexos.Location = new System.Drawing.Point(10, 10);
            this.gcAnexos.MainView = this.gvAnexos;
            this.gcAnexos.Name = "gcAnexos";
            this.gcAnexos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repOpenFile,
            this.repText});
            this.gcAnexos.Size = new System.Drawing.Size(512, 164);
            this.gcAnexos.TabIndex = 0;
            this.gcAnexos.UseEmbeddedNavigator = true;
            this.gcAnexos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAnexos});
            // 
            // gvAnexos
            // 
            this.gvAnexos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolAt_Filename,
            this.gcolAt_Idprice,
            this.gcolAt_Idprice_version,
            this.gcolAt_Num_version,
            this.gcolAt_Source_filename});
            this.gvAnexos.GridControl = this.gcAnexos;
            this.gvAnexos.Name = "gvAnexos";
            this.gvAnexos.OptionsView.ShowGroupPanel = false;
            // 
            // gcolAt_Filename
            // 
            this.gcolAt_Filename.Caption = "Archivo";
            this.gcolAt_Filename.ColumnEdit = this.repOpenFile;
            this.gcolAt_Filename.FieldName = "Filename";
            this.gcolAt_Filename.Name = "gcolAt_Filename";
            this.gcolAt_Filename.Visible = true;
            this.gcolAt_Filename.VisibleIndex = 1;
            this.gcolAt_Filename.Width = 447;
            // 
            // repOpenFile
            // 
            this.repOpenFile.AutoHeight = false;
            this.repOpenFile.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Cargar", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Abrir", -1, true, true, true, DevExpress.Utils.HorzAlignment.Center, null)});
            this.repOpenFile.Name = "repOpenFile";
            this.repOpenFile.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repOpenFile_ButtonClick);
            // 
            // gcolAt_Idprice
            // 
            this.gcolAt_Idprice.Caption = "Idprice";
            this.gcolAt_Idprice.FieldName = "Idprice";
            this.gcolAt_Idprice.Name = "gcolAt_Idprice";
            // 
            // gcolAt_Idprice_version
            // 
            this.gcolAt_Idprice_version.Caption = "Idprice_version";
            this.gcolAt_Idprice_version.FieldName = "Idprice_version";
            this.gcolAt_Idprice_version.Name = "gcolAt_Idprice_version";
            // 
            // gcolAt_Num_version
            // 
            this.gcolAt_Num_version.Caption = "Versión";
            this.gcolAt_Num_version.ColumnEdit = this.repText;
            this.gcolAt_Num_version.FieldName = "Num_version";
            this.gcolAt_Num_version.Name = "gcolAt_Num_version";
            this.gcolAt_Num_version.Visible = true;
            this.gcolAt_Num_version.VisibleIndex = 0;
            // 
            // repText
            // 
            this.repText.AutoHeight = false;
            this.repText.Name = "repText";
            // 
            // gcolAt_Source_filename
            // 
            this.gcolAt_Source_filename.Caption = "Source_filename";
            this.gcolAt_Source_filename.FieldName = "Source_filename";
            this.gcolAt_Source_filename.Name = "gcolAt_Source_filename";
            // 
            // tabParagraphIni
            // 
            this.tabParagraphIni.Controls.Add(this.panelControl3);
            this.tabParagraphIni.Controls.Add(this.panelControl4);
            this.tabParagraphIni.Controls.Add(this.panelControl2);
            this.tabParagraphIni.Name = "tabParagraphIni";
            this.tabParagraphIni.Size = new System.Drawing.Size(593, 108);
            this.tabParagraphIni.Text = "Párrafo inicial";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.richTextIni);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 208);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl3.Size = new System.Drawing.Size(593, 0);
            this.panelControl3.TabIndex = 4;
            this.panelControl3.Text = "panelControl3";
            // 
            // richTextIni
            // 
            this.richTextIni.AcceptsTab = false;
            this.richTextIni.AutoWordSelection = true;
            this.richTextIni.DetectURLs = true;
            this.richTextIni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextIni.Location = new System.Drawing.Point(12, 11);
            this.richTextIni.Name = "richTextIni";
            this.richTextIni.ReadOnly = false;
            // 
            // 
            // 
            this.richTextIni.RichTextBox.AutoWordSelection = true;
            this.richTextIni.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextIni.RichTextBox.Location = new System.Drawing.Point(0, 20);
            this.richTextIni.RichTextBox.Name = "rtb1";
            this.richTextIni.RichTextBox.Size = new System.Drawing.Size(569, 0);
            this.richTextIni.RichTextBox.TabIndex = 1;
            this.richTextIni.ShowBold = true;
            this.richTextIni.ShowCenterJustify = true;
            this.richTextIni.ShowColors = true;
            this.richTextIni.ShowCopy = true;
            this.richTextIni.ShowCut = true;
            this.richTextIni.ShowFont = true;
            this.richTextIni.ShowFontSize = true;
            this.richTextIni.ShowItalic = true;
            this.richTextIni.ShowLeftJustify = true;
            this.richTextIni.ShowOpen = false;
            this.richTextIni.ShowPaste = true;
            this.richTextIni.ShowRedo = true;
            this.richTextIni.ShowRightJustify = true;
            this.richTextIni.ShowSave = false;
            this.richTextIni.ShowStamp = true;
            this.richTextIni.ShowStrikeout = true;
            this.richTextIni.ShowToolBarText = false;
            this.richTextIni.ShowUnderline = true;
            this.richTextIni.ShowUndo = true;
            this.richTextIni.Size = new System.Drawing.Size(569, 0);
            this.richTextIni.StampAction = RichTextBoxExtended.StampActions.EditedBy;
            this.richTextIni.StampColor = System.Drawing.Color.Blue;
            this.richTextIni.TabIndex = 1;
            // 
            // 
            // 
            this.richTextIni.Toolbar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.richTextIni.Toolbar.ButtonSize = new System.Drawing.Size(16, 16);
            this.richTextIni.Toolbar.Divider = false;
            this.richTextIni.Toolbar.DropDownArrows = true;
            this.richTextIni.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.richTextIni.Toolbar.Name = "tb1";
            this.richTextIni.Toolbar.ShowToolTips = true;
            this.richTextIni.Toolbar.Size = new System.Drawing.Size(569, 20);
            this.richTextIni.Toolbar.TabIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.ckSaveHistoryIni);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl4.Location = new System.Drawing.Point(0, 69);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl4.Size = new System.Drawing.Size(593, 39);
            this.panelControl4.TabIndex = 5;
            this.panelControl4.Text = "panelControl4";
            // 
            // ckSaveHistoryIni
            // 
            this.ckSaveHistoryIni.Location = new System.Drawing.Point(13, 11);
            this.ckSaveHistoryIni.Name = "ckSaveHistoryIni";
            this.ckSaveHistoryIni.Properties.Caption = "Guardar como plantilla";
            this.ckSaveHistoryIni.Size = new System.Drawing.Size(136, 19);
            this.ckSaveHistoryIni.TabIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcParagraphHistoryIni);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl2.Size = new System.Drawing.Size(593, 208);
            this.panelControl2.TabIndex = 3;
            this.panelControl2.Text = "panelControl2";
            // 
            // gcParagraphHistoryIni
            // 
            this.gcParagraphHistoryIni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcParagraphHistoryIni.EmbeddedNavigator.Name = "";
            this.gcParagraphHistoryIni.Location = new System.Drawing.Point(12, 12);
            this.gcParagraphHistoryIni.MainView = this.gvParagraphHistoryIni;
            this.gcParagraphHistoryIni.Name = "gcParagraphHistoryIni";
            this.gcParagraphHistoryIni.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repSelectIni});
            this.gcParagraphHistoryIni.Size = new System.Drawing.Size(569, 184);
            this.gcParagraphHistoryIni.TabIndex = 0;
            this.gcParagraphHistoryIni.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvParagraphHistoryIni});
            // 
            // gvParagraphHistoryIni
            // 
            this.gvParagraphHistoryIni.Appearance.Row.Options.UseTextOptions = true;
            this.gvParagraphHistoryIni.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolphi_Paragraph,
            this.gcolphi_Paragraph_rtf});
            this.gvParagraphHistoryIni.GridControl = this.gcParagraphHistoryIni;
            this.gvParagraphHistoryIni.Name = "gvParagraphHistoryIni";
            this.gvParagraphHistoryIni.OptionsBehavior.Editable = false;
            this.gvParagraphHistoryIni.OptionsView.ShowGroupPanel = false;
            this.gvParagraphHistoryIni.DoubleClick += new System.EventHandler(this.gvParagraphHistoryIni_DoubleClick);
            // 
            // gcolphi_Paragraph
            // 
            this.gcolphi_Paragraph.Caption = "Párrafo";
            this.gcolphi_Paragraph.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gcolphi_Paragraph.FieldName = "Paragraph";
            this.gcolphi_Paragraph.Name = "gcolphi_Paragraph";
            this.gcolphi_Paragraph.Visible = true;
            this.gcolphi_Paragraph.VisibleIndex = 0;
            this.gcolphi_Paragraph.Width = 346;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // gcolphi_Paragraph_rtf
            // 
            this.gcolphi_Paragraph_rtf.Caption = "gridColumn1";
            this.gcolphi_Paragraph_rtf.FieldName = "Paragraph_rtf";
            this.gcolphi_Paragraph_rtf.Name = "gcolphi_Paragraph_rtf";
            // 
            // repSelectIni
            // 
            this.repSelectIni.AutoHeight = false;
            this.repSelectIni.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Right)});
            this.repSelectIni.Name = "repSelectIni";
            this.repSelectIni.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // tabItems
            // 
            this.tabItems.Controls.Add(this.gcPrice);
            this.tabItems.Controls.Add(this.panelControl10);
            this.tabItems.Controls.Add(this.panelControl9);
            this.tabItems.Name = "tabItems";
            this.tabItems.Size = new System.Drawing.Size(593, 108);
            this.tabItems.Text = "Items";
            // 
            // panelControl10
            // 
            this.panelControl10.Controls.Add(this.panel1);
            this.panelControl10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl10.Location = new System.Drawing.Point(0, 37);
            this.panelControl10.Name = "panelControl10";
            this.panelControl10.Size = new System.Drawing.Size(593, 71);
            this.panelControl10.TabIndex = 2;
            this.panelControl10.Text = "panelControl10";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTotalAmount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbTotalIgv);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbSubTotalAmount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(443, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 67);
            this.panel1.TabIndex = 27;
            // 
            // panelControl9
            // 
            this.panelControl9.Controls.Add(this.btAdd);
            this.panelControl9.Controls.Add(this.cbMethodAdd);
            this.panelControl9.Controls.Add(this.cbTypeSample);
            this.panelControl9.Controls.Add(this.label1);
            this.panelControl9.Controls.Add(this.label26);
            this.panelControl9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl9.Location = new System.Drawing.Point(0, 0);
            this.panelControl9.Name = "panelControl9";
            this.panelControl9.Size = new System.Drawing.Size(593, 60);
            this.panelControl9.TabIndex = 1;
            this.panelControl9.Text = "panelControl9";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(509, 27);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 20;
            this.btAdd.Text = "Agregar";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // cbMethodAdd
            // 
            this.cbMethodAdd.Location = new System.Drawing.Point(56, 28);
            this.cbMethodAdd.Name = "cbMethodAdd";
            this.cbMethodAdd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMethodAdd.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idtemplate_method", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title")});
            this.cbMethodAdd.Properties.NullText = "Seleccionar";
            this.cbMethodAdd.Properties.ShowFooter = false;
            this.cbMethodAdd.Properties.ShowHeader = false;
            this.cbMethodAdd.Size = new System.Drawing.Size(448, 20);
            this.cbMethodAdd.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Método:";
            // 
            // tabParagraphEnd
            // 
            this.tabParagraphEnd.Controls.Add(this.panelControl7);
            this.tabParagraphEnd.Controls.Add(this.panelControl6);
            this.tabParagraphEnd.Controls.Add(this.panelControl5);
            this.tabParagraphEnd.Name = "tabParagraphEnd";
            this.tabParagraphEnd.Size = new System.Drawing.Size(593, 108);
            this.tabParagraphEnd.Text = "Párrafo final";
            // 
            // panelControl7
            // 
            this.panelControl7.Controls.Add(this.richTextEnd);
            this.panelControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl7.Location = new System.Drawing.Point(0, 208);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl7.Size = new System.Drawing.Size(593, 0);
            this.panelControl7.TabIndex = 8;
            this.panelControl7.Text = "panelControl7";
            // 
            // richTextEnd
            // 
            this.richTextEnd.AcceptsTab = false;
            this.richTextEnd.AutoWordSelection = true;
            this.richTextEnd.DetectURLs = true;
            this.richTextEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextEnd.Location = new System.Drawing.Point(12, 11);
            this.richTextEnd.Name = "richTextEnd";
            this.richTextEnd.ReadOnly = false;
            // 
            // 
            // 
            this.richTextEnd.RichTextBox.AutoWordSelection = true;
            this.richTextEnd.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextEnd.RichTextBox.Location = new System.Drawing.Point(0, 20);
            this.richTextEnd.RichTextBox.Name = "rtb1";
            this.richTextEnd.RichTextBox.Size = new System.Drawing.Size(569, 0);
            this.richTextEnd.RichTextBox.TabIndex = 1;
            this.richTextEnd.ShowBold = true;
            this.richTextEnd.ShowCenterJustify = true;
            this.richTextEnd.ShowColors = true;
            this.richTextEnd.ShowCopy = true;
            this.richTextEnd.ShowCut = true;
            this.richTextEnd.ShowFont = true;
            this.richTextEnd.ShowFontSize = true;
            this.richTextEnd.ShowItalic = true;
            this.richTextEnd.ShowLeftJustify = true;
            this.richTextEnd.ShowOpen = false;
            this.richTextEnd.ShowPaste = true;
            this.richTextEnd.ShowRedo = true;
            this.richTextEnd.ShowRightJustify = true;
            this.richTextEnd.ShowSave = false;
            this.richTextEnd.ShowStamp = true;
            this.richTextEnd.ShowStrikeout = true;
            this.richTextEnd.ShowToolBarText = false;
            this.richTextEnd.ShowUnderline = true;
            this.richTextEnd.ShowUndo = true;
            this.richTextEnd.Size = new System.Drawing.Size(569, 0);
            this.richTextEnd.StampAction = RichTextBoxExtended.StampActions.EditedBy;
            this.richTextEnd.StampColor = System.Drawing.Color.Blue;
            this.richTextEnd.TabIndex = 1;
            // 
            // 
            // 
            this.richTextEnd.Toolbar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.richTextEnd.Toolbar.ButtonSize = new System.Drawing.Size(16, 16);
            this.richTextEnd.Toolbar.Divider = false;
            this.richTextEnd.Toolbar.DropDownArrows = true;
            this.richTextEnd.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.richTextEnd.Toolbar.Name = "tb1";
            this.richTextEnd.Toolbar.ShowToolTips = true;
            this.richTextEnd.Toolbar.Size = new System.Drawing.Size(569, 20);
            this.richTextEnd.Toolbar.TabIndex = 0;
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.ckSaveHistoryEnd);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl6.Location = new System.Drawing.Point(0, 69);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl6.Size = new System.Drawing.Size(593, 39);
            this.panelControl6.TabIndex = 7;
            this.panelControl6.Text = "panelControl6";
            // 
            // ckSaveHistoryEnd
            // 
            this.ckSaveHistoryEnd.Location = new System.Drawing.Point(13, 11);
            this.ckSaveHistoryEnd.Name = "ckSaveHistoryEnd";
            this.ckSaveHistoryEnd.Properties.Caption = "Guardar como plantilla";
            this.ckSaveHistoryEnd.Size = new System.Drawing.Size(136, 19);
            this.ckSaveHistoryEnd.TabIndex = 3;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.gcParagraphHistoryEnd);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl5.Location = new System.Drawing.Point(0, 0);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl5.Size = new System.Drawing.Size(593, 208);
            this.panelControl5.TabIndex = 6;
            this.panelControl5.Text = "panelControl5";
            // 
            // gcParagraphHistoryEnd
            // 
            this.gcParagraphHistoryEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcParagraphHistoryEnd.EmbeddedNavigator.Name = "";
            this.gcParagraphHistoryEnd.Location = new System.Drawing.Point(12, 12);
            this.gcParagraphHistoryEnd.MainView = this.gvParagraphHistoryEnd;
            this.gcParagraphHistoryEnd.Name = "gcParagraphHistoryEnd";
            this.gcParagraphHistoryEnd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit2,
            this.repSelectEnd});
            this.gcParagraphHistoryEnd.Size = new System.Drawing.Size(569, 184);
            this.gcParagraphHistoryEnd.TabIndex = 3;
            this.gcParagraphHistoryEnd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvParagraphHistoryEnd});
            // 
            // gvParagraphHistoryEnd
            // 
            this.gvParagraphHistoryEnd.Appearance.Row.Options.UseTextOptions = true;
            this.gvParagraphHistoryEnd.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolPhe_Paragraph_rtf,
            this.gcolPhe_Paragraph});
            this.gvParagraphHistoryEnd.GridControl = this.gcParagraphHistoryEnd;
            this.gvParagraphHistoryEnd.Name = "gvParagraphHistoryEnd";
            this.gvParagraphHistoryEnd.OptionsBehavior.Editable = false;
            this.gvParagraphHistoryEnd.OptionsView.ShowGroupPanel = false;
            this.gvParagraphHistoryEnd.DoubleClick += new System.EventHandler(this.gvParagraphHistoryEnd_DoubleClick);
            // 
            // gcolPhe_Paragraph_rtf
            // 
            this.gcolPhe_Paragraph_rtf.FieldName = "Paragraph_rtf";
            this.gcolPhe_Paragraph_rtf.Name = "gcolPhe_Paragraph_rtf";
            // 
            // gcolPhe_Paragraph
            // 
            this.gcolPhe_Paragraph.Caption = "Parrafo";
            this.gcolPhe_Paragraph.ColumnEdit = this.repositoryItemMemoEdit2;
            this.gcolPhe_Paragraph.FieldName = "Paragraph";
            this.gcolPhe_Paragraph.Name = "gcolPhe_Paragraph";
            this.gcolPhe_Paragraph.Visible = true;
            this.gcolPhe_Paragraph.VisibleIndex = 0;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // repSelectEnd
            // 
            this.repSelectEnd.AutoHeight = false;
            this.repSelectEnd.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Right, "Select", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.repSelectEnd.Name = "repSelectEnd";
            this.repSelectEnd.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btRefreshParagraphIni
            // 
            this.btRefreshParagraphIni.Location = new System.Drawing.Point(10, 6);
            this.btRefreshParagraphIni.Name = "btRefreshParagraphIni";
            this.btRefreshParagraphIni.Size = new System.Drawing.Size(75, 23);
            this.btRefreshParagraphIni.TabIndex = 2;
            this.btRefreshParagraphIni.Text = "Refrescar >";
            this.btRefreshParagraphIni.Click += new System.EventHandler(this.btRefreshParagraphIni_Click);
            // 
            // btDesign
            // 
            this.btDesign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDesign.Location = new System.Drawing.Point(344, 6);
            this.btDesign.Name = "btDesign";
            this.btDesign.Size = new System.Drawing.Size(55, 23);
            this.btDesign.TabIndex = 4;
            this.btDesign.Text = "Diseñar";
            this.btDesign.Click += new System.EventHandler(this.btDesign_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "las bambas";
            // 
            // ucToolButtons
            // 
            this.ucToolButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucToolButtons.Location = new System.Drawing.Point(2, 2);
            this.ucToolButtons.Name = "ucToolButtons";
            this.ucToolButtons.Size = new System.Drawing.Size(999, 21);
            this.ucToolButtons.TabIndex = 0;
            this.ucToolButtons.onFind += new LimsProject.Find(this.ucToolButtons_onFind);
            this.ucToolButtons.onNew += new LimsProject.New(this.ucToolButtons_onNew);
            // 
            // previewControl1
            // 
            this.previewControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.previewControl1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.previewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewControl1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.previewControl1.Location = new System.Drawing.Point(597, 2);
            this.previewControl1.Name = "previewControl1";
            this.previewControl1.PageOffset = new System.Drawing.Point(10, 10);
            this.previewControl1.Size = new System.Drawing.Size(404, 430);
            this.previewControl1.TabIndex = 6;
            this.previewControl1.UIStyle = FastReport.Utils.UIStyle.VisualStudio2005;
            // 
            // panelControl8
            // 
            this.panelControl8.Controls.Add(this.btDesign);
            this.panelControl8.Controls.Add(this.btRefreshParagraphIni);
            this.panelControl8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl8.Location = new System.Drawing.Point(597, 432);
            this.panelControl8.Name = "panelControl8";
            this.panelControl8.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl8.Size = new System.Drawing.Size(404, 32);
            this.panelControl8.TabIndex = 7;
            this.panelControl8.Text = "panelControl8";
            // 
            // ofdPrice
            // 
            this.ofdPrice.FileName = "openFileDialog1";
            // 
            // FormPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 595);
            this.Name = "FormPrice";
            this.Text = "Cotizaciones";
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).EndInit();
            this.paTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            this.paBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            this.paTop.ResumeLayout(false);
            this.paTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBuOpenPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTemplateMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTypeSample.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateExpiration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateCreation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTotalIgv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumDaysValid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.tabHead.ResumeLayout(false);
            this.tabHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).EndInit();
            this.xtraTabControl3.ResumeLayout(false);
            this.xtraTabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbObservation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientRuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientDomicile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCompany.Properties)).EndInit();
            this.xtraTabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPerson_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCellPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNum)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckDispatchFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckDispatchPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckDispatchTransport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckDispatchCurier.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAnexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repOpenFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repText)).EndInit();
            this.tabParagraphIni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckSaveHistoryIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcParagraphHistoryIni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParagraphHistoryIni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSelectIni)).EndInit();
            this.tabItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).EndInit();
            this.panelControl10.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).EndInit();
            this.panelControl9.ResumeLayout(false);
            this.panelControl9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMethodAdd.Properties)).EndInit();
            this.tabParagraphEnd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckSaveHistoryEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcParagraphHistoryEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParagraphHistoryEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSelectEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).EndInit();
            this.panelControl8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tbNumVersion;
        private DevExpress.XtraEditors.TextEdit tbCodPrice;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraGrid.GridControl gcPrice;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrice;
        private UcSign ucSign1;
        private DevExpress.XtraGrid.Columns.GridColumn gcolItem_Idtemplate_method;
        private DevExpress.XtraGrid.Columns.GridColumn gcolItem_Amount_item;
        private DevExpress.XtraGrid.Columns.GridColumn gcolItem_Unit_price;
        private DevExpress.XtraGrid.Columns.GridColumn gcolItem_Sale_price;
        private MyLookUpEdit cbTypeSample;
        private System.Windows.Forms.Label label26;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gcolItem_Rank;
        private DevExpress.XtraEditors.DateEdit deDateExpiration;
        private DevExpress.XtraEditors.DateEdit deDateCreation;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.SpinEdit tbTotalIgv;
        private DevExpress.XtraEditors.SpinEdit tbTotalAmount;
        private DevExpress.XtraEditors.SpinEdit tbSubTotalAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repAmount;
        private DevExpress.XtraGrid.Columns.GridColumn gcolItem_Num_item;
        private UcGenerar ucCopyTo;
        private DevExpress.XtraEditors.SpinEdit tbNumDaysValid;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage tabParagraphIni;
        private DevExpress.XtraGrid.GridControl gcParagraphHistoryIni;
        private DevExpress.XtraGrid.Views.Grid.GridView gvParagraphHistoryIni;
        private DevExpress.XtraTab.XtraTabPage tabItems;
        private DevExpress.XtraTab.XtraTabPage tabParagraphEnd;
        private DevExpress.XtraTab.XtraTabPage tabHead;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private UcToolStrip ucToolButtons;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHistory;
        private DevExpress.XtraGrid.Columns.GridColumn gcolphi_Paragraph;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repSelectIni;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTemplateMethod;
        private DevExpress.XtraGrid.GridControl gcParagraphHistoryEnd;
        private DevExpress.XtraGrid.Views.Grid.GridView gvParagraphHistoryEnd;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repSelectEnd;
        private RichTextBoxExtended.RichTextBoxExtended richTextIni;
        private DevExpress.XtraEditors.SimpleButton btRefreshParagraphIni;
        private FastReport.Preview.PreviewControl previewControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.CheckEdit ckSaveHistoryIni;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private RichTextBoxExtended.RichTextBoxExtended richTextEnd;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.CheckEdit ckSaveHistoryEnd;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton btDesign;
        private DevExpress.XtraEditors.PanelControl panelControl8;
        private DevExpress.XtraGrid.Columns.GridColumn gcolphi_Paragraph_rtf;
        private DevExpress.XtraGrid.Columns.GridColumn gcolPhe_Paragraph_rtf;
        private DevExpress.XtraGrid.Columns.GridColumn gcolItem_Den_method;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.TextEdit tbFax;
        private DevExpress.XtraEditors.TextEdit tbClientPhone;
        private DevExpress.XtraEditors.TextEdit tbClientRuc;
        private DevExpress.XtraEditors.TextEdit tbClientDomicile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private MyLookUpEdit cbCompany;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private DevExpress.XtraGrid.GridControl gcContact;
        private DevExpress.XtraGrid.Views.Grid.GridView gvContact;
        private DevExpress.XtraGrid.Columns.GridColumn gcCon_Idprice_company_person;
        private DevExpress.XtraGrid.Columns.GridColumn gcCon_Idperson;
        private DevExpress.XtraGrid.Columns.GridColumn gcCon_Idcompany;
        private DevExpress.XtraGrid.Columns.GridColumn gcCon_Idrecep_sample;
        private DevExpress.XtraGrid.Columns.GridColumn gcCon_Allname;
        private DevExpress.XtraGrid.Columns.GridColumn gcCon_Mail;
        private DevExpress.XtraGrid.Columns.GridColumn gcCon_Person_type;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repPerson_type;
        private DevExpress.XtraGrid.Columns.GridColumn gcCon_Phone;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repPhone;
        private DevExpress.XtraGrid.Columns.GridColumn gcCon_Cellphone;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repCellPhone;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repNum;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.CheckEdit ckDispatchFax;
        private DevExpress.XtraEditors.CheckEdit ckDispatchPerson;
        private DevExpress.XtraEditors.CheckEdit ckDispatchTransport;
        private DevExpress.XtraEditors.CheckEdit ckDispatchCurier;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gcAnexos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAnexos;
        private DevExpress.XtraGrid.Columns.GridColumn gcolAt_Filename;
        private DevExpress.XtraEditors.PanelControl panelControl10;
        private DevExpress.XtraEditors.PanelControl panelControl9;
        private DevExpress.XtraGrid.Columns.GridColumn gcolPhe_Paragraph;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn gcolHis_Idprice_version;
        private DevExpress.XtraGrid.Columns.GridColumn gcolHis_Cod_price;
        private DevExpress.XtraGrid.Columns.GridColumn gcolHis_Num_version;
        private DevExpress.XtraGrid.Columns.GridColumn gcolHis_Amount_item;
        private DevExpress.XtraGrid.Columns.GridColumn gcolHis_Unit_price;
        private DevExpress.XtraGrid.Columns.GridColumn gcolHis_Date_creation;
        private DevExpress.XtraGrid.Columns.GridColumn gcolHis_Button;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repBuOpenPrice;
        private DevExpress.XtraEditors.LookUpEdit cbMethodAdd;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btAdd;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repOpenFile;
        private DevExpress.XtraGrid.Columns.GridColumn gcolAt_Idprice;
        private System.Windows.Forms.OpenFileDialog ofdPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gcolAt_Num_version;
        private DevExpress.XtraGrid.Columns.GridColumn gcolAt_Idprice_version;
        private DevExpress.XtraGrid.Columns.GridColumn gcolAt_Source_filename;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage8;
        private DevExpress.XtraEditors.MemoEdit tbObservation;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repText;
    }
}