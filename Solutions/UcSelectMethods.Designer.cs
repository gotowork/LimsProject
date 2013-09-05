namespace LimsProject
{
    partial class UcSelectMethods
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
            this.gcStd = new DevExpress.XtraGrid.GridControl();
            this.gvStd = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcStd_Std_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcStd_Concentration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMethods = new DevExpress.XtraGrid.GridControl();
            this.gvMethods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcTM_Sel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTM_Idtemplate_met = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTM_NameMethod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTM_Title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btConfirmSelMethods = new DevExpress.XtraEditors.SimpleButton();
            this.paHeaderSolution = new System.Windows.Forms.Panel();
            this.cbMediumHead = new DevExpress.XtraEditors.LookUpEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUnd = new DevExpress.XtraEditors.TextEdit();
            this.tbConcentPatternHeader = new DevExpress.XtraEditors.TextEdit();
            this.cbMrcOrPatternHeader = new DevExpress.XtraEditors.LookUpEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label125 = new System.Windows.Forms.Label();
            this.cbModifHead = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTypePattern = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMethods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMethods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.paHeaderSolution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMediumHead.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConcentPatternHeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMrcOrPatternHeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbModifHead.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTypePattern.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcStd
            // 
            this.gcStd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcStd.EmbeddedNavigator.Name = "";
            this.gcStd.Location = new System.Drawing.Point(538, 44);
            this.gcStd.MainView = this.gvStd;
            this.gcStd.Name = "gcStd";
            this.gcStd.Size = new System.Drawing.Size(178, 363);
            this.gcStd.TabIndex = 42;
            this.gcStd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStd});
            // 
            // gvStd
            // 
            this.gvStd.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvStd.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvStd.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvStd.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvStd.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvStd.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvStd.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvStd.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvStd.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvStd.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvStd.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvStd.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvStd.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvStd.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvStd.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvStd.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvStd.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvStd.Appearance.Empty.Options.UseBackColor = true;
            this.gvStd.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvStd.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvStd.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvStd.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvStd.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvStd.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvStd.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvStd.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvStd.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvStd.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvStd.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvStd.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvStd.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvStd.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvStd.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvStd.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvStd.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvStd.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvStd.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvStd.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvStd.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvStd.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvStd.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvStd.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvStd.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvStd.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvStd.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvStd.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvStd.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvStd.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvStd.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvStd.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvStd.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvStd.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvStd.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvStd.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvStd.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvStd.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvStd.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvStd.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvStd.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvStd.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvStd.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvStd.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvStd.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvStd.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvStd.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvStd.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvStd.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvStd.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvStd.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvStd.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvStd.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvStd.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvStd.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvStd.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvStd.Appearance.GroupRow.Options.UseFont = true;
            this.gvStd.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvStd.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvStd.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvStd.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvStd.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvStd.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvStd.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvStd.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvStd.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvStd.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvStd.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvStd.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvStd.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvStd.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvStd.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvStd.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvStd.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvStd.Appearance.OddRow.Options.UseBackColor = true;
            this.gvStd.Appearance.OddRow.Options.UseForeColor = true;
            this.gvStd.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvStd.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvStd.Appearance.Preview.Options.UseBackColor = true;
            this.gvStd.Appearance.Preview.Options.UseForeColor = true;
            this.gvStd.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvStd.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvStd.Appearance.Row.Options.UseBackColor = true;
            this.gvStd.Appearance.Row.Options.UseForeColor = true;
            this.gvStd.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvStd.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvStd.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvStd.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvStd.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvStd.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvStd.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvStd.Appearance.VertLine.Options.UseBackColor = true;
            this.gvStd.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcStd_Std_name,
            this.gcStd_Concentration});
            this.gvStd.GridControl = this.gcStd;
            this.gvStd.Name = "gvStd";
            this.gvStd.OptionsBehavior.Editable = false;
            this.gvStd.OptionsView.EnableAppearanceEvenRow = true;
            this.gvStd.OptionsView.EnableAppearanceOddRow = true;
            this.gvStd.OptionsView.ShowGroupPanel = false;
            // 
            // gcStd_Std_name
            // 
            this.gcStd_Std_name.Caption = "Nombre";
            this.gcStd_Std_name.FieldName = "Std_name";
            this.gcStd_Std_name.Name = "gcStd_Std_name";
            this.gcStd_Std_name.Visible = true;
            this.gcStd_Std_name.VisibleIndex = 0;
            // 
            // gcStd_Concentration
            // 
            this.gcStd_Concentration.Caption = "Concentración";
            this.gcStd_Concentration.FieldName = "Concentration";
            this.gcStd_Concentration.Name = "gcStd_Concentration";
            this.gcStd_Concentration.Visible = true;
            this.gcStd_Concentration.VisibleIndex = 1;
            // 
            // gcMethods
            // 
            this.gcMethods.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcMethods.EmbeddedNavigator.Name = "";
            this.gcMethods.Location = new System.Drawing.Point(0, 44);
            this.gcMethods.MainView = this.gvMethods;
            this.gcMethods.Name = "gcMethods";
            this.gcMethods.Size = new System.Drawing.Size(538, 363);
            this.gcMethods.TabIndex = 41;
            this.gcMethods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMethods});
            // 
            // gvMethods
            // 
            this.gvMethods.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvMethods.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvMethods.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvMethods.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvMethods.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvMethods.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvMethods.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvMethods.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvMethods.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvMethods.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvMethods.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvMethods.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvMethods.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvMethods.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvMethods.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvMethods.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvMethods.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvMethods.Appearance.Empty.Options.UseBackColor = true;
            this.gvMethods.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvMethods.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvMethods.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvMethods.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvMethods.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvMethods.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvMethods.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvMethods.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvMethods.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvMethods.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvMethods.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvMethods.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvMethods.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvMethods.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvMethods.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvMethods.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvMethods.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvMethods.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvMethods.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvMethods.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvMethods.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvMethods.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvMethods.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvMethods.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvMethods.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvMethods.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvMethods.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvMethods.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvMethods.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvMethods.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMethods.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvMethods.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvMethods.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvMethods.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvMethods.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvMethods.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvMethods.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvMethods.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvMethods.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvMethods.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvMethods.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvMethods.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvMethods.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvMethods.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvMethods.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvMethods.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvMethods.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvMethods.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvMethods.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvMethods.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvMethods.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvMethods.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvMethods.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvMethods.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvMethods.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvMethods.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvMethods.Appearance.GroupRow.Options.UseFont = true;
            this.gvMethods.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvMethods.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvMethods.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvMethods.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvMethods.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMethods.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvMethods.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvMethods.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvMethods.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvMethods.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvMethods.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvMethods.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvMethods.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvMethods.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvMethods.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvMethods.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvMethods.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvMethods.Appearance.OddRow.Options.UseBackColor = true;
            this.gvMethods.Appearance.OddRow.Options.UseForeColor = true;
            this.gvMethods.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvMethods.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvMethods.Appearance.Preview.Options.UseBackColor = true;
            this.gvMethods.Appearance.Preview.Options.UseForeColor = true;
            this.gvMethods.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvMethods.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvMethods.Appearance.Row.Options.UseBackColor = true;
            this.gvMethods.Appearance.Row.Options.UseForeColor = true;
            this.gvMethods.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvMethods.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvMethods.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvMethods.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvMethods.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvMethods.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvMethods.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvMethods.Appearance.VertLine.Options.UseBackColor = true;
            this.gvMethods.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcTM_Sel,
            this.gcTM_Idtemplate_met,
            this.gcTM_NameMethod,
            this.gcTM_Title});
            this.gvMethods.GridControl = this.gcMethods;
            this.gvMethods.Name = "gvMethods";
            this.gvMethods.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvMethods.OptionsView.ColumnAutoWidth = false;
            this.gvMethods.OptionsView.EnableAppearanceEvenRow = true;
            this.gvMethods.OptionsView.EnableAppearanceOddRow = true;
            this.gvMethods.OptionsView.ShowGroupPanel = false;
            this.gvMethods.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvMethods_FocusedRowChanged);
            // 
            // gcTM_Sel
            // 
            this.gcTM_Sel.Caption = "#";
            this.gcTM_Sel.FieldName = "Sel";
            this.gcTM_Sel.Name = "gcTM_Sel";
            this.gcTM_Sel.Visible = true;
            this.gcTM_Sel.VisibleIndex = 0;
            this.gcTM_Sel.Width = 46;
            // 
            // gcTM_Idtemplate_met
            // 
            this.gcTM_Idtemplate_met.Caption = "Idtemplate_method";
            this.gcTM_Idtemplate_met.FieldName = "Idtemplate_method";
            this.gcTM_Idtemplate_met.Name = "gcTM_Idtemplate_met";
            // 
            // gcTM_NameMethod
            // 
            this.gcTM_NameMethod.Caption = "Codigo";
            this.gcTM_NameMethod.FieldName = "Cod_template_method";
            this.gcTM_NameMethod.Name = "gcTM_NameMethod";
            this.gcTM_NameMethod.OptionsColumn.AllowEdit = false;
            this.gcTM_NameMethod.OptionsColumn.ReadOnly = true;
            this.gcTM_NameMethod.Visible = true;
            this.gcTM_NameMethod.VisibleIndex = 1;
            this.gcTM_NameMethod.Width = 59;
            // 
            // gcTM_Title
            // 
            this.gcTM_Title.Caption = "Título";
            this.gcTM_Title.FieldName = "Title";
            this.gcTM_Title.Name = "gcTM_Title";
            this.gcTM_Title.OptionsColumn.AllowEdit = false;
            this.gcTM_Title.OptionsColumn.ReadOnly = true;
            this.gcTM_Title.Visible = true;
            this.gcTM_Title.VisibleIndex = 2;
            this.gcTM_Title.Width = 392;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 407);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(716, 42);
            this.panelControl1.TabIndex = 43;
            this.panelControl1.Text = "panelControl1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btConfirmSelMethods);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(583, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 38);
            this.panel1.TabIndex = 1;
            // 
            // btConfirmSelMethods
            // 
            this.btConfirmSelMethods.Location = new System.Drawing.Point(8, 7);
            this.btConfirmSelMethods.Name = "btConfirmSelMethods";
            this.btConfirmSelMethods.Size = new System.Drawing.Size(115, 23);
            this.btConfirmSelMethods.TabIndex = 0;
            this.btConfirmSelMethods.Text = "Confirmar selección";
            this.btConfirmSelMethods.Click += new System.EventHandler(this.btConfirmSelMethods_Click);
            // 
            // paHeaderSolution
            // 
            this.paHeaderSolution.Controls.Add(this.cbMediumHead);
            this.paHeaderSolution.Controls.Add(this.label11);
            this.paHeaderSolution.Controls.Add(this.label6);
            this.paHeaderSolution.Controls.Add(this.tbUnd);
            this.paHeaderSolution.Controls.Add(this.tbConcentPatternHeader);
            this.paHeaderSolution.Controls.Add(this.cbMrcOrPatternHeader);
            this.paHeaderSolution.Controls.Add(this.label10);
            this.paHeaderSolution.Controls.Add(this.label125);
            this.paHeaderSolution.Controls.Add(this.cbModifHead);
            this.paHeaderSolution.Controls.Add(this.label3);
            this.paHeaderSolution.Controls.Add(this.label4);
            this.paHeaderSolution.Controls.Add(this.cbTypePattern);
            this.paHeaderSolution.Dock = System.Windows.Forms.DockStyle.Top;
            this.paHeaderSolution.Enabled = false;
            this.paHeaderSolution.Location = new System.Drawing.Point(0, 0);
            this.paHeaderSolution.Name = "paHeaderSolution";
            this.paHeaderSolution.Size = new System.Drawing.Size(716, 44);
            this.paHeaderSolution.TabIndex = 44;
            // 
            // cbMediumHead
            // 
            this.cbMediumHead.Location = new System.Drawing.Point(497, 18);
            this.cbMediumHead.Name = "cbMediumHead";
            this.cbMediumHead.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbMediumHead.Properties.Appearance.Options.UseFont = true;
            this.cbMediumHead.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMediumHead.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idreactive", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Reactive_name")});
            this.cbMediumHead.Properties.NullText = "---";
            this.cbMediumHead.Properties.ShowFooter = false;
            this.cbMediumHead.Properties.ShowHeader = false;
            this.cbMediumHead.Size = new System.Drawing.Size(100, 20);
            this.cbMediumHead.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(305, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Und";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Concen:";
            // 
            // tbUnd
            // 
            this.tbUnd.Location = new System.Drawing.Point(307, 18);
            this.tbUnd.Name = "tbUnd";
            this.tbUnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbUnd.Properties.Appearance.Options.UseFont = true;
            this.tbUnd.Size = new System.Drawing.Size(24, 20);
            this.tbUnd.TabIndex = 30;
            // 
            // tbConcentPatternHeader
            // 
            this.tbConcentPatternHeader.Location = new System.Drawing.Point(219, 18);
            this.tbConcentPatternHeader.Name = "tbConcentPatternHeader";
            this.tbConcentPatternHeader.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbConcentPatternHeader.Properties.Appearance.Options.UseFont = true;
            this.tbConcentPatternHeader.Size = new System.Drawing.Size(85, 20);
            this.tbConcentPatternHeader.TabIndex = 30;
            // 
            // cbMrcOrPatternHeader
            // 
            this.cbMrcOrPatternHeader.Location = new System.Drawing.Point(113, 18);
            this.cbMrcOrPatternHeader.Name = "cbMrcOrPatternHeader";
            this.cbMrcOrPatternHeader.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbMrcOrPatternHeader.Properties.Appearance.Options.UseFont = true;
            this.cbMrcOrPatternHeader.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMrcOrPatternHeader.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idmr_detail", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idsolution", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.cbMrcOrPatternHeader.Properties.NullText = "Seleccionar";
            this.cbMrcOrPatternHeader.Properties.ShowFooter = false;
            this.cbMrcOrPatternHeader.Properties.ShowHeader = false;
            this.cbMrcOrPatternHeader.Size = new System.Drawing.Size(100, 20);
            this.cbMrcOrPatternHeader.TabIndex = 26;
            this.cbMrcOrPatternHeader.EditValueChanged += new System.EventHandler(this.cbMrcOrPatternHeader_EditValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Cod MR";
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(13, 2);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(63, 13);
            this.label125.TabIndex = 27;
            this.label125.Text = "Tipo de MR";
            // 
            // cbModifHead
            // 
            this.cbModifHead.Location = new System.Drawing.Point(603, 18);
            this.cbModifHead.Name = "cbModifHead";
            this.cbModifHead.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbModifHead.Properties.Appearance.Options.UseFont = true;
            this.cbModifHead.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbModifHead.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idreactive", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Reactive_name")});
            this.cbModifHead.Properties.NullText = "---";
            this.cbModifHead.Properties.ShowFooter = false;
            this.cbModifHead.Properties.ShowHeader = false;
            this.cbModifHead.Size = new System.Drawing.Size(100, 20);
            this.cbModifHead.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Medio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Modif:";
            // 
            // cbTypePattern
            // 
            this.cbTypePattern.Location = new System.Drawing.Point(7, 18);
            this.cbTypePattern.Name = "cbTypePattern";
            this.cbTypePattern.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbTypePattern.Properties.Appearance.Options.UseFont = true;
            this.cbTypePattern.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTypePattern.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("MRC", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Sol. Patron", 2, -1)});
            this.cbTypePattern.Size = new System.Drawing.Size(100, 20);
            this.cbTypePattern.TabIndex = 28;
            this.cbTypePattern.SelectedIndexChanged += new System.EventHandler(this.cbTypePattern_SelectedIndexChanged);
            // 
            // UcSelectMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcStd);
            this.Controls.Add(this.gcMethods);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.paHeaderSolution);
            this.Name = "UcSelectMethods";
            this.Size = new System.Drawing.Size(716, 449);
            ((System.ComponentModel.ISupportInitialize)(this.gcStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMethods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMethods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.paHeaderSolution.ResumeLayout(false);
            this.paHeaderSolution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMediumHead.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConcentPatternHeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMrcOrPatternHeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbModifHead.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTypePattern.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcStd;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStd;
        private DevExpress.XtraGrid.Columns.GridColumn gcStd_Std_name;
        private DevExpress.XtraGrid.Columns.GridColumn gcStd_Concentration;
        private DevExpress.XtraGrid.GridControl gcMethods;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMethods;
        private DevExpress.XtraGrid.Columns.GridColumn gcTM_Sel;
        private DevExpress.XtraGrid.Columns.GridColumn gcTM_Idtemplate_met;
        private DevExpress.XtraGrid.Columns.GridColumn gcTM_NameMethod;
        private DevExpress.XtraGrid.Columns.GridColumn gcTM_Title;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btConfirmSelMethods;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel paHeaderSolution;
        private DevExpress.XtraEditors.LookUpEdit cbMediumHead;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit tbUnd;
        private DevExpress.XtraEditors.TextEdit tbConcentPatternHeader;
        private DevExpress.XtraEditors.LookUpEdit cbMrcOrPatternHeader;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label125;
        private DevExpress.XtraEditors.LookUpEdit cbModifHead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbTypePattern;
    }
}
