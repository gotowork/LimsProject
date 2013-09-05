namespace LimsProject
{
    partial class FormTitration
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
            this.btEnterReadings = new DevExpress.XtraEditors.SimpleButton();
            this.tbMainForAliquot = new DevExpress.XtraEditors.SpinEdit();
            this.tbMainNumAnalyst = new DevExpress.XtraEditors.SpinEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMainNumTest = new DevExpress.XtraEditors.SpinEdit();
            this.gcSolTitration = new DevExpress.XtraGrid.GridControl();
            this.gvSolTitration = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCol_Aliquot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repValue = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gcCol_Practice_reading = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Theorical_reading = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Factor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Prepared_by = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repUser = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcCol_Average = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Status_titration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSelect = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gcCol_Idsolution = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Date_prepared = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbShowPanel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btNewFactor = new DevExpress.XtraEditors.SimpleButton();
            this.paSignData = new System.Windows.Forms.Panel();
            this.ucSignData = new LimsProject.UcSign();
            this.cbFactorUnitMeasure = new DevExpress.XtraEditors.LookUpEdit();
            this.tbFactorEnd = new DevExpress.XtraEditors.SpinEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ucSignFactor = new LimsProject.UcSign();
            this.cbMainMasaVolumen = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cbMainAverageType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.ucTraceTitration = new LimsProject.UcTraceUser();
            this.paSignFactor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).BeginInit();
            this.paTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).BeginInit();
            this.paBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.paCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            this.paTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMainForAliquot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMainNumAnalyst.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMainNumTest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSolTitration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSolTitration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowPanel.Properties)).BeginInit();
            this.paSignData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFactorUnitMeasure.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFactorEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMainMasaVolumen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMainAverageType.Properties)).BeginInit();
            this.paSignFactor.SuspendLayout();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Size = new System.Drawing.Size(791, 37);
            this.laTitle.Text = "Titulación de Soluciones";
            // 
            // paTitle
            // 
            this.paTitle.Size = new System.Drawing.Size(795, 41);
            // 
            // paBottom
            // 
            this.paBottom.Controls.Add(this.paSignFactor);
            this.paBottom.Controls.Add(this.ucTraceTitration);
            this.paBottom.Location = new System.Drawing.Point(0, 428);
            this.paBottom.Size = new System.Drawing.Size(795, 53);
            this.paBottom.Visible = false;
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.gcSolTitration);
            this.paCenter.Controls.Add(this.panelControl1);
            this.paCenter.Location = new System.Drawing.Point(0, 92);
            this.paCenter.Size = new System.Drawing.Size(795, 336);
            // 
            // paTop
            // 
            this.paTop.Controls.Add(this.cbMainAverageType);
            this.paTop.Controls.Add(this.cbMainMasaVolumen);
            this.paTop.Controls.Add(this.btEnterReadings);
            this.paTop.Controls.Add(this.tbMainForAliquot);
            this.paTop.Controls.Add(this.tbMainNumAnalyst);
            this.paTop.Controls.Add(this.label9);
            this.paTop.Controls.Add(this.label7);
            this.paTop.Controls.Add(this.label8);
            this.paTop.Controls.Add(this.label6);
            this.paTop.Controls.Add(this.tbMainNumTest);
            this.paTop.Location = new System.Drawing.Point(0, 41);
            this.paTop.Size = new System.Drawing.Size(795, 51);
            // 
            // btEnterReadings
            // 
            this.btEnterReadings.Location = new System.Drawing.Point(642, 14);
            this.btEnterReadings.Name = "btEnterReadings";
            this.btEnterReadings.Size = new System.Drawing.Size(99, 23);
            this.btEnterReadings.TabIndex = 14;
            this.btEnterReadings.Text = "Ingresar Lecturas";
            this.btEnterReadings.Click += new System.EventHandler(this.btEnterReadings_Click);
            // 
            // tbMainForAliquot
            // 
            this.tbMainForAliquot.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbMainForAliquot.Location = new System.Drawing.Point(45, 16);
            this.tbMainForAliquot.Name = "tbMainForAliquot";
            this.tbMainForAliquot.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbMainForAliquot.Size = new System.Drawing.Size(45, 20);
            this.tbMainForAliquot.TabIndex = 5;
            // 
            // tbMainNumAnalyst
            // 
            this.tbMainNumAnalyst.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbMainNumAnalyst.Location = new System.Drawing.Point(222, 16);
            this.tbMainNumAnalyst.Name = "tbMainNumAnalyst";
            this.tbMainNumAnalyst.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbMainNumAnalyst.Properties.IsFloatValue = false;
            this.tbMainNumAnalyst.Properties.Mask.EditMask = "N00";
            this.tbMainNumAnalyst.Properties.MaxValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.tbMainNumAnalyst.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbMainNumAnalyst.Size = new System.Drawing.Size(45, 20);
            this.tbMainNumAnalyst.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Para:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "N°Ensayos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "N°Analistas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cálculo de promedio:";
            // 
            // tbMainNumTest
            // 
            this.tbMainNumTest.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbMainNumTest.Location = new System.Drawing.Point(569, 16);
            this.tbMainNumTest.Name = "tbMainNumTest";
            this.tbMainNumTest.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbMainNumTest.Properties.IsFloatValue = false;
            this.tbMainNumTest.Properties.Mask.EditMask = "N00";
            this.tbMainNumTest.Size = new System.Drawing.Size(67, 20);
            this.tbMainNumTest.TabIndex = 7;
            // 
            // gcSolTitration
            // 
            this.gcSolTitration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSolTitration.EmbeddedNavigator.Buttons.First.Enabled = false;
            this.gcSolTitration.EmbeddedNavigator.Buttons.Last.Enabled = false;
            this.gcSolTitration.EmbeddedNavigator.Buttons.Next.Enabled = false;
            this.gcSolTitration.EmbeddedNavigator.Buttons.NextPage.Enabled = false;
            this.gcSolTitration.EmbeddedNavigator.Buttons.Prev.Enabled = false;
            this.gcSolTitration.EmbeddedNavigator.Buttons.PrevPage.Enabled = false;
            this.gcSolTitration.EmbeddedNavigator.Name = "";
            this.gcSolTitration.Location = new System.Drawing.Point(2, 2);
            this.gcSolTitration.MainView = this.gvSolTitration;
            this.gcSolTitration.Name = "gcSolTitration";
            this.gcSolTitration.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repValue,
            this.repUser,
            this.repSelect});
            this.gcSolTitration.Size = new System.Drawing.Size(791, 284);
            this.gcSolTitration.TabIndex = 1;
            this.gcSolTitration.UseEmbeddedNavigator = true;
            this.gcSolTitration.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSolTitration});
            // 
            // gvSolTitration
            // 
            this.gvSolTitration.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSolTitration.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSolTitration.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSolTitration.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvSolTitration.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSolTitration.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvSolTitration.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvSolTitration.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvSolTitration.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvSolTitration.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvSolTitration.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvSolTitration.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSolTitration.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvSolTitration.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvSolTitration.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvSolTitration.Appearance.Empty.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvSolTitration.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvSolTitration.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvSolTitration.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSolTitration.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSolTitration.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSolTitration.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvSolTitration.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSolTitration.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvSolTitration.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvSolTitration.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvSolTitration.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvSolTitration.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvSolTitration.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvSolTitration.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvSolTitration.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvSolTitration.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvSolTitration.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvSolTitration.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvSolTitration.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvSolTitration.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSolTitration.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSolTitration.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSolTitration.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvSolTitration.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSolTitration.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvSolTitration.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvSolTitration.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSolTitration.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSolTitration.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvSolTitration.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvSolTitration.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvSolTitration.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSolTitration.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSolTitration.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvSolTitration.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvSolTitration.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvSolTitration.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvSolTitration.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSolTitration.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvSolTitration.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSolTitration.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSolTitration.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvSolTitration.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvSolTitration.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvSolTitration.Appearance.GroupRow.Options.UseFont = true;
            this.gvSolTitration.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvSolTitration.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSolTitration.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSolTitration.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSolTitration.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvSolTitration.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSolTitration.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvSolTitration.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvSolTitration.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvSolTitration.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvSolTitration.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvSolTitration.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvSolTitration.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvSolTitration.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvSolTitration.Appearance.OddRow.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.OddRow.Options.UseForeColor = true;
            this.gvSolTitration.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvSolTitration.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvSolTitration.Appearance.Preview.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.Preview.Options.UseForeColor = true;
            this.gvSolTitration.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvSolTitration.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvSolTitration.Appearance.Row.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.Row.Options.UseForeColor = true;
            this.gvSolTitration.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvSolTitration.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvSolTitration.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvSolTitration.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvSolTitration.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvSolTitration.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvSolTitration.Appearance.VertLine.Options.UseBackColor = true;
            this.gvSolTitration.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcCol_Aliquot,
            this.gcCol_Practice_reading,
            this.gcCol_Theorical_reading,
            this.gcCol_Factor,
            this.gcCol_Prepared_by,
            this.gcCol_Average,
            this.gcCol_Status_titration,
            this.gcCol_Idsolution,
            this.gcCol_Date_prepared});
            this.gvSolTitration.GridControl = this.gcSolTitration;
            this.gvSolTitration.GroupCount = 1;
            this.gvSolTitration.Name = "gvSolTitration";
            this.gvSolTitration.OptionsBehavior.Editable = false;
            this.gvSolTitration.OptionsView.AllowCellMerge = true;
            this.gvSolTitration.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSolTitration.OptionsView.EnableAppearanceOddRow = true;
            this.gvSolTitration.OptionsView.ShowGroupPanel = false;
            this.gvSolTitration.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcCol_Prepared_by, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvSolTitration.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvSolTitration_InitNewRow);
            this.gvSolTitration.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvSolTitration_CellValueChanged);
            // 
            // gcCol_Aliquot
            // 
            this.gcCol_Aliquot.Caption = "Alicuota";
            this.gcCol_Aliquot.ColumnEdit = this.repValue;
            this.gcCol_Aliquot.FieldName = "Aliquot";
            this.gcCol_Aliquot.Name = "gcCol_Aliquot";
            this.gcCol_Aliquot.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcCol_Aliquot.Visible = true;
            this.gcCol_Aliquot.VisibleIndex = 0;
            this.gcCol_Aliquot.Width = 97;
            // 
            // repValue
            // 
            this.repValue.AutoHeight = false;
            this.repValue.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repValue.Name = "repValue";
            this.repValue.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repValue_EditValueChanging);
            // 
            // gcCol_Practice_reading
            // 
            this.gcCol_Practice_reading.Caption = "Lect. practica";
            this.gcCol_Practice_reading.ColumnEdit = this.repValue;
            this.gcCol_Practice_reading.FieldName = "Practice_reading";
            this.gcCol_Practice_reading.Name = "gcCol_Practice_reading";
            this.gcCol_Practice_reading.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcCol_Practice_reading.Visible = true;
            this.gcCol_Practice_reading.VisibleIndex = 2;
            this.gcCol_Practice_reading.Width = 101;
            // 
            // gcCol_Theorical_reading
            // 
            this.gcCol_Theorical_reading.Caption = "Lec. Teorica";
            this.gcCol_Theorical_reading.ColumnEdit = this.repValue;
            this.gcCol_Theorical_reading.FieldName = "Theorical_reading";
            this.gcCol_Theorical_reading.Name = "gcCol_Theorical_reading";
            this.gcCol_Theorical_reading.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcCol_Theorical_reading.Visible = true;
            this.gcCol_Theorical_reading.VisibleIndex = 1;
            this.gcCol_Theorical_reading.Width = 101;
            // 
            // gcCol_Factor
            // 
            this.gcCol_Factor.AppearanceCell.Options.UseTextOptions = true;
            this.gcCol_Factor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gcCol_Factor.Caption = "Factor parcial";
            this.gcCol_Factor.FieldName = "Factor";
            this.gcCol_Factor.Name = "gcCol_Factor";
            this.gcCol_Factor.OptionsColumn.AllowEdit = false;
            this.gcCol_Factor.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcCol_Factor.Visible = true;
            this.gcCol_Factor.VisibleIndex = 3;
            this.gcCol_Factor.Width = 104;
            // 
            // gcCol_Prepared_by
            // 
            this.gcCol_Prepared_by.Caption = "Analista";
            this.gcCol_Prepared_by.ColumnEdit = this.repUser;
            this.gcCol_Prepared_by.FieldName = "Prepared_by";
            this.gcCol_Prepared_by.Name = "gcCol_Prepared_by";
            this.gcCol_Prepared_by.Width = 102;
            // 
            // repUser
            // 
            this.repUser.AutoHeight = false;
            this.repUser.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repUser.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Iduser", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cod_user")});
            this.repUser.Name = "repUser";
            this.repUser.NullText = "Seleccionar";
            this.repUser.ShowFooter = false;
            this.repUser.ShowHeader = false;
            // 
            // gcCol_Average
            // 
            this.gcCol_Average.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gcCol_Average.AppearanceCell.Options.UseFont = true;
            this.gcCol_Average.AppearanceCell.Options.UseTextOptions = true;
            this.gcCol_Average.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcCol_Average.Caption = "Promedio";
            this.gcCol_Average.FieldName = "Average";
            this.gcCol_Average.Name = "gcCol_Average";
            this.gcCol_Average.OptionsColumn.AllowEdit = false;
            this.gcCol_Average.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.gcCol_Average.Visible = true;
            this.gcCol_Average.VisibleIndex = 5;
            this.gcCol_Average.Width = 97;
            // 
            // gcCol_Status_titration
            // 
            this.gcCol_Status_titration.Caption = "Seleccionar";
            this.gcCol_Status_titration.ColumnEdit = this.repSelect;
            this.gcCol_Status_titration.FieldName = "Status_titration";
            this.gcCol_Status_titration.Name = "gcCol_Status_titration";
            this.gcCol_Status_titration.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcCol_Status_titration.Visible = true;
            this.gcCol_Status_titration.VisibleIndex = 4;
            this.gcCol_Status_titration.Width = 112;
            // 
            // repSelect
            // 
            this.repSelect.AutoHeight = false;
            this.repSelect.Name = "repSelect";
            this.repSelect.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repSelect_EditValueChanging);
            // 
            // gcCol_Idsolution
            // 
            this.gcCol_Idsolution.Caption = "Idsolution";
            this.gcCol_Idsolution.FieldName = "Idsolution";
            this.gcCol_Idsolution.Name = "gcCol_Idsolution";
            // 
            // gcCol_Date_prepared
            // 
            this.gcCol_Date_prepared.Caption = "Fecha/Hora";
            this.gcCol_Date_prepared.FieldName = "Date_prepared";
            this.gcCol_Date_prepared.Name = "gcCol_Date_prepared";
            this.gcCol_Date_prepared.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcCol_Date_prepared.Visible = true;
            this.gcCol_Date_prepared.VisibleIndex = 6;
            this.gcCol_Date_prepared.Width = 158;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbShowPanel);
            this.panelControl1.Controls.Add(this.btNewFactor);
            this.panelControl1.Controls.Add(this.paSignData);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 286);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(791, 48);
            this.panelControl1.TabIndex = 2;
            this.panelControl1.Text = "panelControl1";
            // 
            // cbShowPanel
            // 
            this.cbShowPanel.EditValue = "Ingreso de Datos";
            this.cbShowPanel.Location = new System.Drawing.Point(266, 23);
            this.cbShowPanel.Name = "cbShowPanel";
            this.cbShowPanel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbShowPanel.Properties.Items.AddRange(new object[] {
            "Ingreso de Datos",
            "Determinación de Factor"});
            this.cbShowPanel.Size = new System.Drawing.Size(153, 20);
            this.cbShowPanel.TabIndex = 1;
            this.cbShowPanel.SelectedValueChanged += new System.EventHandler(this.cbShowPanel_SelectedValueChanged);
            // 
            // btNewFactor
            // 
            this.btNewFactor.Location = new System.Drawing.Point(8, 21);
            this.btNewFactor.Name = "btNewFactor";
            this.btNewFactor.Size = new System.Drawing.Size(78, 23);
            this.btNewFactor.TabIndex = 6;
            this.btNewFactor.Text = "Nuevo factor";
            // 
            // paSignData
            // 
            this.paSignData.Controls.Add(this.ucSignData);
            this.paSignData.Dock = System.Windows.Forms.DockStyle.Right;
            this.paSignData.Location = new System.Drawing.Point(616, 2);
            this.paSignData.Name = "paSignData";
            this.paSignData.Size = new System.Drawing.Size(173, 44);
            this.paSignData.TabIndex = 5;
            // 
            // ucSignData
            // 
            this.ucSignData.Enabled = false;
            this.ucSignData.Location = new System.Drawing.Point(10, 2);
            this.ucSignData.Margin = new System.Windows.Forms.Padding(0);
            this.ucSignData.Name = "ucSignData";
            this.ucSignData.Pwd = null;
            this.ucSignData.Size = new System.Drawing.Size(158, 40);
            this.ucSignData.TabIndex = 0;
            this.ucSignData.Title = "Datos";
            this.ucSignData.OnSign += new LimsProject.sign(this.ucSignTitration_OnSign);
            // 
            // cbFactorUnitMeasure
            // 
            this.cbFactorUnitMeasure.Location = new System.Drawing.Point(113, 22);
            this.cbFactorUnitMeasure.Name = "cbFactorUnitMeasure";
            this.cbFactorUnitMeasure.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFactorUnitMeasure.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idunit", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name_unit")});
            this.cbFactorUnitMeasure.Properties.NullText = "Seleccionar";
            this.cbFactorUnitMeasure.Properties.ShowFooter = false;
            this.cbFactorUnitMeasure.Properties.ShowHeader = false;
            this.cbFactorUnitMeasure.Size = new System.Drawing.Size(85, 20);
            this.cbFactorUnitMeasure.TabIndex = 4;
            this.cbFactorUnitMeasure.EditValueChanged += new System.EventHandler(this.cbFactorUnitMeasure_EditValueChanged);
            // 
            // tbFactorEnd
            // 
            this.tbFactorEnd.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbFactorEnd.Location = new System.Drawing.Point(6, 22);
            this.tbFactorEnd.Name = "tbFactorEnd";
            this.tbFactorEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbFactorEnd.Properties.ReadOnly = true;
            this.tbFactorEnd.Size = new System.Drawing.Size(100, 20);
            this.tbFactorEnd.TabIndex = 1;
            this.tbFactorEnd.EditValueChanged += new System.EventHandler(this.tbFactorEnd_EditValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Resultado en:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Factor final";
            // 
            // ucSignFactor
            // 
            this.ucSignFactor.Enabled = false;
            this.ucSignFactor.Location = new System.Drawing.Point(208, 2);
            this.ucSignFactor.Margin = new System.Windows.Forms.Padding(0);
            this.ucSignFactor.Name = "ucSignFactor";
            this.ucSignFactor.Pwd = null;
            this.ucSignFactor.Size = new System.Drawing.Size(158, 40);
            this.ucSignFactor.TabIndex = 0;
            this.ucSignFactor.Title = "Factor";
            this.ucSignFactor.OnSign += new LimsProject.sign(this.ucSignFactor_OnSign);
            // 
            // cbMainMasaVolumen
            // 
            this.cbMainMasaVolumen.EditValue = 1;
            this.cbMainMasaVolumen.Location = new System.Drawing.Point(93, 16);
            this.cbMainMasaVolumen.Name = "cbMainMasaVolumen";
            this.cbMainMasaVolumen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMainMasaVolumen.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("g", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("ml", 2, -1)});
            this.cbMainMasaVolumen.Size = new System.Drawing.Size(40, 20);
            this.cbMainMasaVolumen.TabIndex = 15;
            // 
            // cbMainAverageType
            // 
            this.cbMainAverageType.EditValue = 1;
            this.cbMainAverageType.Location = new System.Drawing.Point(396, 16);
            this.cbMainAverageType.Name = "cbMainAverageType";
            this.cbMainAverageType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMainAverageType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Global", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Por analista", 2, -1)});
            this.cbMainAverageType.Size = new System.Drawing.Size(80, 20);
            this.cbMainAverageType.TabIndex = 16;
            // 
            // ucTraceTitration
            // 
            this.ucTraceTitration.Location = new System.Drawing.Point(10, 7);
            this.ucTraceTitration.Name = "ucTraceTitration";
            this.ucTraceTitration.Size = new System.Drawing.Size(149, 37);
            this.ucTraceTitration.TabIndex = 5;
            this.ucTraceTitration.UserSign = "---------";
            // 
            // paSignFactor
            // 
            this.paSignFactor.Controls.Add(this.label10);
            this.paSignFactor.Controls.Add(this.label5);
            this.paSignFactor.Controls.Add(this.ucSignFactor);
            this.paSignFactor.Controls.Add(this.tbFactorEnd);
            this.paSignFactor.Controls.Add(this.cbFactorUnitMeasure);
            this.paSignFactor.Dock = System.Windows.Forms.DockStyle.Right;
            this.paSignFactor.Location = new System.Drawing.Point(420, 2);
            this.paSignFactor.Name = "paSignFactor";
            this.paSignFactor.Size = new System.Drawing.Size(373, 49);
            this.paSignFactor.TabIndex = 6;
            // 
            // FormTitration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 481);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTitration";
            this.Text = "Titulación de Soluciones";
            this.Load += new System.EventHandler(this.FormTitration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).EndInit();
            this.paTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            this.paBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            this.paTop.ResumeLayout(false);
            this.paTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMainForAliquot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMainNumAnalyst.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMainNumTest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSolTitration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSolTitration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbShowPanel.Properties)).EndInit();
            this.paSignData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbFactorUnitMeasure.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFactorEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMainMasaVolumen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMainAverageType.Properties)).EndInit();
            this.paSignFactor.ResumeLayout(false);
            this.paSignFactor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btEnterReadings;
        private DevExpress.XtraEditors.SpinEdit tbMainForAliquot;
        private DevExpress.XtraEditors.SpinEdit tbMainNumAnalyst;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SpinEdit tbMainNumTest;
        private DevExpress.XtraGrid.GridControl gcSolTitration;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSolTitration;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Aliquot;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Practice_reading;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repValue;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Theorical_reading;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Factor;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Prepared_by;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repUser;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Average;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Status_titration;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Idsolution;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Date_prepared;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel paSignData;
        private DevExpress.XtraEditors.LookUpEdit cbFactorUnitMeasure;
        private DevExpress.XtraEditors.SpinEdit tbFactorEnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btNewFactor;
        private UcSign ucSignFactor;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repSelect;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbMainMasaVolumen;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbMainAverageType;
        private DevExpress.XtraEditors.ComboBoxEdit cbShowPanel;
        private UcSign ucSignData;
        private UcTraceUser ucTraceTitration;
        private System.Windows.Forms.Panel paSignFactor;
    }
}