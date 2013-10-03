namespace LimsProject
{
    partial class UcCalibStd
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            this.gcCal_Absorbance_previus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCal_Absorbance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.paCalibCenter = new DevExpress.XtraEditors.PanelControl();
            this.gcCalibStd = new DevExpress.XtraGrid.GridControl();
            this.gvCalibStd = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCal_Idcalib_std = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCal_Idcalib = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCal_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCal_Concentration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCal_Idtemplate_method = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTemplate_method = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ucTraceUser1 = new LimsProject.UcTraceUser();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.chartCalib = new DevExpress.XtraCharts.ChartControl();
            this.rgSelectGraphic = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label127 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.cbModif = new DevExpress.XtraEditors.LookUpEdit();
            this.cbMedium = new DevExpress.XtraEditors.LookUpEdit();
            this.label133 = new System.Windows.Forms.Label();
            this.tbModifConc = new DevExpress.XtraEditors.SpinEdit();
            this.tbValidity_calib = new DevExpress.XtraEditors.SpinEdit();
            this.tbMediumConc = new DevExpress.XtraEditors.SpinEdit();
            this.tbRexp2 = new DevExpress.XtraEditors.SpinEdit();
            this.label130 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paCalibCenter)).BeginInit();
            this.paCalibCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCalibStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCalibStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTemplate_method)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCalib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSelectGraphic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbModif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMedium.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbModifConc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValidity_calib.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMediumConc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRexp2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCal_Absorbance_previus
            // 
            this.gcCal_Absorbance_previus.Caption = "COD Absorbancia";
            this.gcCal_Absorbance_previus.FieldName = "Absorbance_previus";
            this.gcCal_Absorbance_previus.Name = "gcCal_Absorbance_previus";
            this.gcCal_Absorbance_previus.OptionsColumn.ReadOnly = true;
            this.gcCal_Absorbance_previus.Visible = true;
            this.gcCal_Absorbance_previus.VisibleIndex = 2;
            // 
            // gcCal_Absorbance
            // 
            this.gcCal_Absorbance.Caption = "Nueva Absorbancia";
            this.gcCal_Absorbance.FieldName = "Absorbance";
            this.gcCal_Absorbance.Name = "gcCal_Absorbance";
            this.gcCal_Absorbance.Visible = true;
            this.gcCal_Absorbance.VisibleIndex = 3;
            // 
            // paCalibCenter
            // 
            this.paCalibCenter.Controls.Add(this.gcCalibStd);
            this.paCalibCenter.Controls.Add(this.panelControl1);
            this.paCalibCenter.Controls.Add(this.panelControl3);
            this.paCalibCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paCalibCenter.Location = new System.Drawing.Point(0, 0);
            this.paCalibCenter.Name = "paCalibCenter";
            this.paCalibCenter.Size = new System.Drawing.Size(806, 477);
            this.paCalibCenter.TabIndex = 0;
            this.paCalibCenter.Text = "paCalibCenter";
            // 
            // gcCalibStd
            // 
            this.gcCalibStd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCalibStd.EmbeddedNavigator.Name = "";
            this.gcCalibStd.Location = new System.Drawing.Point(2, 2);
            this.gcCalibStd.MainView = this.gvCalibStd;
            this.gcCalibStd.Name = "gcCalibStd";
            this.gcCalibStd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repTemplate_method});
            this.gcCalibStd.Size = new System.Drawing.Size(420, 423);
            this.gcCalibStd.TabIndex = 1;
            this.gcCalibStd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCalibStd});
            // 
            // gvCalibStd
            // 
            this.gvCalibStd.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCalibStd.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCalibStd.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCalibStd.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvCalibStd.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCalibStd.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvCalibStd.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvCalibStd.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvCalibStd.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvCalibStd.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvCalibStd.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvCalibStd.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCalibStd.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvCalibStd.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvCalibStd.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvCalibStd.Appearance.Empty.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvCalibStd.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvCalibStd.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvCalibStd.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCalibStd.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCalibStd.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCalibStd.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvCalibStd.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCalibStd.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvCalibStd.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvCalibStd.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvCalibStd.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvCalibStd.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvCalibStd.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvCalibStd.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvCalibStd.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvCalibStd.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvCalibStd.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvCalibStd.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvCalibStd.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvCalibStd.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCalibStd.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCalibStd.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCalibStd.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCalibStd.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCalibStd.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvCalibStd.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvCalibStd.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCalibStd.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCalibStd.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvCalibStd.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvCalibStd.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvCalibStd.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCalibStd.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCalibStd.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvCalibStd.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvCalibStd.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvCalibStd.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvCalibStd.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCalibStd.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvCalibStd.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCalibStd.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCalibStd.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvCalibStd.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvCalibStd.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvCalibStd.Appearance.GroupRow.Options.UseFont = true;
            this.gvCalibStd.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvCalibStd.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCalibStd.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCalibStd.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCalibStd.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCalibStd.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCalibStd.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvCalibStd.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvCalibStd.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvCalibStd.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvCalibStd.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvCalibStd.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvCalibStd.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvCalibStd.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvCalibStd.Appearance.OddRow.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.OddRow.Options.UseForeColor = true;
            this.gvCalibStd.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvCalibStd.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvCalibStd.Appearance.Preview.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.Preview.Options.UseForeColor = true;
            this.gvCalibStd.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvCalibStd.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvCalibStd.Appearance.Row.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.Row.Options.UseForeColor = true;
            this.gvCalibStd.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvCalibStd.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvCalibStd.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvCalibStd.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvCalibStd.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvCalibStd.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvCalibStd.Appearance.VertLine.Options.UseBackColor = true;
            this.gvCalibStd.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcCal_Idcalib_std,
            this.gcCal_Idcalib,
            this.gcCal_Name,
            this.gcCal_Concentration,
            this.gcCal_Absorbance_previus,
            this.gcCal_Absorbance,
            this.gcCal_Idtemplate_method});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Column = this.gcCal_Absorbance_previus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = -1D;
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.DarkKhaki;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Column = this.gcCal_Absorbance;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition2.Value1 = -1D;
            this.gvCalibStd.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gvCalibStd.GridControl = this.gcCalibStd;
            this.gvCalibStd.Name = "gvCalibStd";
            this.gvCalibStd.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCalibStd.OptionsView.EnableAppearanceOddRow = true;
            this.gvCalibStd.OptionsView.ShowGroupPanel = false;
            this.gvCalibStd.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvCalibStd_FocusedRowChanged);
            this.gvCalibStd.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvCalibStd_CellValueChanged);
            // 
            // gcCal_Idcalib_std
            // 
            this.gcCal_Idcalib_std.Caption = "Idcalib_std";
            this.gcCal_Idcalib_std.FieldName = "Idcalib_std";
            this.gcCal_Idcalib_std.Name = "gcCal_Idcalib_std";
            this.gcCal_Idcalib_std.Width = 127;
            // 
            // gcCal_Idcalib
            // 
            this.gcCal_Idcalib.Caption = "Idcalib";
            this.gcCal_Idcalib.FieldName = "Idcalib";
            this.gcCal_Idcalib.Name = "gcCal_Idcalib";
            this.gcCal_Idcalib.Width = 82;
            // 
            // gcCal_Name
            // 
            this.gcCal_Name.Caption = "Nombre";
            this.gcCal_Name.FieldName = "Name";
            this.gcCal_Name.Name = "gcCal_Name";
            this.gcCal_Name.Visible = true;
            this.gcCal_Name.VisibleIndex = 0;
            this.gcCal_Name.Width = 63;
            // 
            // gcCal_Concentration
            // 
            this.gcCal_Concentration.Caption = "Concentración";
            this.gcCal_Concentration.FieldName = "Concentration";
            this.gcCal_Concentration.Name = "gcCal_Concentration";
            this.gcCal_Concentration.Visible = true;
            this.gcCal_Concentration.VisibleIndex = 1;
            // 
            // gcCal_Idtemplate_method
            // 
            this.gcCal_Idtemplate_method.Caption = "Idtemplate_method";
            this.gcCal_Idtemplate_method.FieldName = "Idtemplate_method";
            this.gcCal_Idtemplate_method.Name = "gcCal_Idtemplate_method";
            // 
            // repTemplate_method
            // 
            this.repTemplate_method.AutoHeight = false;
            this.repTemplate_method.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTemplate_method.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idtemplate_method", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cod_template_method")});
            this.repTemplate_method.Name = "repTemplate_method";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ucTraceUser1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 425);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(420, 50);
            this.panelControl1.TabIndex = 3;
            this.panelControl1.Text = "panelControl1";
            // 
            // ucTraceUser1
            // 
            this.ucTraceUser1.Location = new System.Drawing.Point(5, 6);
            this.ucTraceUser1.Name = "ucTraceUser1";
            this.ucTraceUser1.Size = new System.Drawing.Size(133, 37);
            this.ucTraceUser1.TabIndex = 0;
            this.ucTraceUser1.UserSign = "---------";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.chartCalib);
            this.panelControl3.Controls.Add(this.rgSelectGraphic);
            this.panelControl3.Controls.Add(this.groupControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(422, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(382, 473);
            this.panelControl3.TabIndex = 2;
            this.panelControl3.Text = "panelControl3";
            // 
            // chartCalib
            // 
            this.chartCalib.AppearanceName = "The Trees";
            xyDiagram1.AxisX.Title.Text = "Concentracion";
            xyDiagram1.AxisX.Title.Visible = true;
            xyDiagram1.AxisY.Title.Text = "Absorbancia";
            xyDiagram1.AxisY.Title.Visible = true;
            this.chartCalib.Diagram = xyDiagram1;
            this.chartCalib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCalib.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartCalib.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chartCalib.Location = new System.Drawing.Point(2, 2);
            this.chartCalib.Name = "chartCalib";
            series1.Name = "Series 1";
            series1.View = lineSeriesView1;
            pointSeriesLabel1.Angle = 0;
            pointSeriesLabel1.LineLength = 30;
            pointSeriesLabel1.Border.Visible = false;
            series1.Label = pointSeriesLabel1;
            series1.PointOptionsTypeName = "PointOptions";
            series2.Name = "Series 2";
            series2.View = lineSeriesView2;
            pointSeriesLabel2.Angle = 90;
            pointSeriesLabel2.LineLength = 20;
            pointSeriesLabel2.Border.Visible = false;
            series2.Label = pointSeriesLabel2;
            series2.PointOptionsTypeName = "PointOptions";
            this.chartCalib.Series.AddRange(new DevExpress.XtraCharts.Series[] {
            series1,
            series2});
            this.chartCalib.SeriesTemplate.View = lineSeriesView3;
            this.chartCalib.SeriesTemplate.PointOptionsTypeName = "PointOptions";
            this.chartCalib.Size = new System.Drawing.Size(378, 348);
            this.chartCalib.TabIndex = 1;
            // 
            // rgSelectGraphic
            // 
            this.rgSelectGraphic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rgSelectGraphic.EditValue = 1D;
            this.rgSelectGraphic.Location = new System.Drawing.Point(2, 350);
            this.rgSelectGraphic.Name = "rgSelectGraphic";
            this.rgSelectGraphic.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0D, "Actual Absorbancia"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1D, "Nueva Absorbancia"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2D, "Ambas Absorbancias")});
            this.rgSelectGraphic.Size = new System.Drawing.Size(378, 30);
            this.rgSelectGraphic.TabIndex = 3;
            this.rgSelectGraphic.SelectedIndexChanged += new System.EventHandler(this.rgSelectGraphic_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label127);
            this.groupControl1.Controls.Add(this.label124);
            this.groupControl1.Controls.Add(this.cbModif);
            this.groupControl1.Controls.Add(this.cbMedium);
            this.groupControl1.Controls.Add(this.label133);
            this.groupControl1.Controls.Add(this.tbModifConc);
            this.groupControl1.Controls.Add(this.tbValidity_calib);
            this.groupControl1.Controls.Add(this.tbMediumConc);
            this.groupControl1.Controls.Add(this.tbRexp2);
            this.groupControl1.Controls.Add(this.label130);
            this.groupControl1.Controls.Add(this.label129);
            this.groupControl1.Controls.Add(this.label132);
            this.groupControl1.Controls.Add(this.label131);
            this.groupControl1.Controls.Add(this.label128);
            this.groupControl1.Controls.Add(this.label126);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(2, 380);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(378, 91);
            this.groupControl1.TabIndex = 0;
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label127.Location = new System.Drawing.Point(227, 24);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(9, 9);
            this.label127.TabIndex = 23;
            this.label127.Text = "2";
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(215, 26);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(27, 13);
            this.label124.TabIndex = 35;
            this.label124.Text = "R   :";
            // 
            // cbModif
            // 
            this.cbModif.Location = new System.Drawing.Point(69, 65);
            this.cbModif.Name = "cbModif";
            this.cbModif.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbModif.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idreactive", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Chemical_formula", "", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Reactive_name")});
            this.cbModif.Properties.NullText = "---";
            this.cbModif.Properties.ReadOnly = true;
            this.cbModif.Properties.ShowFooter = false;
            this.cbModif.Properties.ShowHeader = false;
            this.cbModif.Size = new System.Drawing.Size(105, 20);
            this.cbModif.TabIndex = 33;
            // 
            // cbMedium
            // 
            this.cbMedium.Location = new System.Drawing.Point(69, 43);
            this.cbMedium.Name = "cbMedium";
            this.cbMedium.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMedium.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idreactive", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Chemical_formula", "", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Reactive_name")});
            this.cbMedium.Properties.NullText = "---";
            this.cbMedium.Properties.ReadOnly = true;
            this.cbMedium.Properties.ShowFooter = false;
            this.cbMedium.Properties.ShowHeader = false;
            this.cbMedium.Size = new System.Drawing.Size(105, 20);
            this.cbMedium.TabIndex = 34;
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Location = new System.Drawing.Point(23, 24);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(44, 13);
            this.label133.TabIndex = 22;
            this.label133.Text = "Validez:";
            // 
            // tbModifConc
            // 
            this.tbModifConc.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbModifConc.Location = new System.Drawing.Point(251, 65);
            this.tbModifConc.Name = "tbModifConc";
            this.tbModifConc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbModifConc.Properties.ReadOnly = true;
            this.tbModifConc.Size = new System.Drawing.Size(70, 20);
            this.tbModifConc.TabIndex = 30;
            // 
            // tbValidity_calib
            // 
            this.tbValidity_calib.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbValidity_calib.Location = new System.Drawing.Point(69, 21);
            this.tbValidity_calib.Name = "tbValidity_calib";
            this.tbValidity_calib.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbValidity_calib.Properties.ReadOnly = true;
            this.tbValidity_calib.Size = new System.Drawing.Size(105, 20);
            this.tbValidity_calib.TabIndex = 21;
            // 
            // tbMediumConc
            // 
            this.tbMediumConc.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbMediumConc.Location = new System.Drawing.Point(251, 43);
            this.tbMediumConc.Name = "tbMediumConc";
            this.tbMediumConc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbMediumConc.Properties.ReadOnly = true;
            this.tbMediumConc.Size = new System.Drawing.Size(70, 20);
            this.tbMediumConc.TabIndex = 31;
            // 
            // tbRexp2
            // 
            this.tbRexp2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbRexp2.Location = new System.Drawing.Point(251, 21);
            this.tbRexp2.Name = "tbRexp2";
            this.tbRexp2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbRexp2.Properties.ReadOnly = true;
            this.tbRexp2.Size = new System.Drawing.Size(70, 20);
            this.tbRexp2.TabIndex = 32;
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Location = new System.Drawing.Point(216, 68);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(35, 13);
            this.label130.TabIndex = 24;
            this.label130.Text = "Conc:";
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Location = new System.Drawing.Point(23, 68);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(36, 13);
            this.label129.TabIndex = 25;
            this.label129.Text = "Modif:";
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Location = new System.Drawing.Point(319, 68);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(15, 13);
            this.label132.TabIndex = 26;
            this.label132.Text = "%";
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Location = new System.Drawing.Point(319, 46);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(15, 13);
            this.label131.TabIndex = 27;
            this.label131.Text = "%";
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Location = new System.Drawing.Point(216, 46);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(35, 13);
            this.label128.TabIndex = 28;
            this.label128.Text = "Conc:";
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(23, 46);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(39, 13);
            this.label126.TabIndex = 29;
            this.label126.Text = "Medio:";
            // 
            // UcCalibStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paCalibCenter);
            this.Name = "UcCalibStd";
            this.Size = new System.Drawing.Size(806, 477);
            ((System.ComponentModel.ISupportInitialize)(this.paCalibCenter)).EndInit();
            this.paCalibCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCalibStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCalibStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTemplate_method)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCalib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSelectGraphic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbModif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMedium.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbModifConc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValidity_calib.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMediumConc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRexp2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl paCalibCenter;
        private DevExpress.XtraGrid.GridControl gcCalibStd;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCalibStd;
        private DevExpress.XtraGrid.Columns.GridColumn gcCal_Idcalib_std;
        private DevExpress.XtraGrid.Columns.GridColumn gcCal_Idcalib;
        private DevExpress.XtraGrid.Columns.GridColumn gcCal_Name;
        private DevExpress.XtraGrid.Columns.GridColumn gcCal_Concentration;
        private DevExpress.XtraGrid.Columns.GridColumn gcCal_Absorbance_previus;
        private DevExpress.XtraGrid.Columns.GridColumn gcCal_Absorbance;
        private DevExpress.XtraGrid.Columns.GridColumn gcCal_Idtemplate_method;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTemplate_method;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraCharts.ChartControl chartCalib;
        private DevExpress.XtraEditors.RadioGroup rgSelectGraphic;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.Label label124;
        private DevExpress.XtraEditors.LookUpEdit cbModif;
        private DevExpress.XtraEditors.LookUpEdit cbMedium;
        private System.Windows.Forms.Label label133;
        private DevExpress.XtraEditors.SpinEdit tbModifConc;
        private DevExpress.XtraEditors.SpinEdit tbValidity_calib;
        private DevExpress.XtraEditors.SpinEdit tbMediumConc;
        private DevExpress.XtraEditors.SpinEdit tbRexp2;
        private System.Windows.Forms.Label label130;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.Label label131;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.Label label126;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private UcTraceUser ucTraceUser1;
    }
}
