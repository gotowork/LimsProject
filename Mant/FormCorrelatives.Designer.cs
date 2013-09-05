namespace LimsProject
{
    partial class FormCorrelatives
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCorrelatives));
            this.gcCorrelativos = new DevExpress.XtraGrid.GridControl();
            this.gvCorrelativos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCorr_cod_type_sample = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTypeSample = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcCorr_prefix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCorr_cod_serie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCorr_correlative = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCorr_num_digits = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCorr_mreach15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.cbYear = new DevExpress.XtraEditors.LookUpEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gcVarios = new DevExpress.XtraGrid.GridControl();
            this.gvVarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcVar_Cod_module = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcVar_Name_module = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcVar_Prefix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcVar_Cod_serie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcVar_Correlative = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcVar_Num_digits = new DevExpress.XtraGrid.Columns.GridColumn();
            this.paTitleSearch.SuspendLayout();
            this.paTopBasicButtons.SuspendLayout();
            this.paTopSearch.SuspendLayout();
            this.paBottomSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.paSearchGen.SuspendLayout();
            this.paInferior.SuspendLayout();
            this.paTitulo.SuspendLayout();
            this.paCentral.SuspendLayout();
            this.thePanelTab1.SuspendLayout();
            this.tpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCorrelativos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCorrelativos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTypeSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbYear.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVarios)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "save.png");
            this.imageList1.Images.SetKeyName(1, "nuevo.png");
            this.imageList1.Images.SetKeyName(2, "eliminar.png");
            this.imageList1.Images.SetKeyName(3, "buscar.png");
            this.imageList1.Images.SetKeyName(4, "salir.png");
            this.imageList1.Images.SetKeyName(5, "cancelar.png");
            this.imageList1.Images.SetKeyName(6, "ok.png");
            this.imageList1.Images.SetKeyName(7, "deshacer.png");
            this.imageList1.Images.SetKeyName(8, "editar.png");
            // 
            // paTitleSearch
            // 
            this.paTitleSearch.Size = new System.Drawing.Size(526, 37);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(443, 37);
            this.label1.Text = "Correlativos en Muestras - Búsqueda";
            // 
            // btSalir2
            // 
            this.btSalir2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btSalir2.FlatAppearance.BorderSize = 0;
            // 
            // btGuardar
            // 
            this.btGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btGuardar.FlatAppearance.BorderSize = 0;
            // 
            // btNuevo2
            // 
            this.btNuevo2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btNuevo2.FlatAppearance.BorderSize = 0;
            // 
            // btEliminar2
            // 
            this.btEliminar2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btEliminar2.FlatAppearance.BorderSize = 0;
            // 
            // paTopSearch
            // 
            this.paTopSearch.Size = new System.Drawing.Size(526, 57);
            // 
            // paBottomSearch
            // 
            this.paBottomSearch.Location = new System.Drawing.Point(3, 194);
            this.paBottomSearch.Size = new System.Drawing.Size(526, 43);
            // 
            // btBuscar
            // 
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.Visible = false;
            // 
            // btEditar
            // 
            this.btEditar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btEditar.FlatAppearance.BorderSize = 0;
            // 
            // btCancel
            // 
            this.btCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btCancel.FlatAppearance.BorderSize = 0;
            // 
            // btOk
            // 
            this.btOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btOk.FlatAppearance.BorderSize = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(483, 0);
            // 
            // btFiltroBuscar
            // 
            this.btFiltroBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btFiltroBuscar.FlatAppearance.BorderSize = 0;
            // 
            // paMiddleFind
            // 
            this.paMiddleFind.Size = new System.Drawing.Size(526, 97);
            // 
            // paInferior
            // 
            this.paInferior.Location = new System.Drawing.Point(3, 318);
            this.paInferior.Size = new System.Drawing.Size(555, 45);
            // 
            // paTitulo
            // 
            this.paTitulo.Size = new System.Drawing.Size(555, 36);
            // 
            // paCentral
            // 
            this.paCentral.Controls.Add(this.xtraTabControl1);
            this.paCentral.Controls.Add(this.panel4);
            this.paCentral.Location = new System.Drawing.Point(3, 58);
            this.paCentral.Size = new System.Drawing.Size(555, 260);
            // 
            // paSupBotones
            // 
            this.paSupBotones.Size = new System.Drawing.Size(569, 32);
            // 
            // paSuperior
            // 
            this.paSuperior.Size = new System.Drawing.Size(555, 19);
            this.paSuperior.Visible = false;
            // 
            // laTitulo
            // 
            this.laTitulo.Size = new System.Drawing.Size(471, 36);
            this.laTitulo.Text = "Correlativos en Muestras";
            // 
            // thePanelTab1
            // 
            this.thePanelTab1.Size = new System.Drawing.Size(569, 395);
            // 
            // tpDatos
            // 
            this.tpDatos.Size = new System.Drawing.Size(561, 366);
            // 
            // gcCorrelativos
            // 
            this.gcCorrelativos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCorrelativos.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcCorrelativos.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcCorrelativos.EmbeddedNavigator.Name = "";
            this.gcCorrelativos.Location = new System.Drawing.Point(0, 0);
            this.gcCorrelativos.MainView = this.gvCorrelativos;
            this.gcCorrelativos.Name = "gcCorrelativos";
            this.gcCorrelativos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repTypeSample});
            this.gcCorrelativos.Size = new System.Drawing.Size(546, 194);
            this.gcCorrelativos.TabIndex = 0;
            this.gcCorrelativos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCorrelativos});
            // 
            // gvCorrelativos
            // 
            this.gvCorrelativos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCorrelativos.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCorrelativos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCorrelativos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvCorrelativos.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCorrelativos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvCorrelativos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvCorrelativos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvCorrelativos.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvCorrelativos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvCorrelativos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvCorrelativos.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCorrelativos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvCorrelativos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvCorrelativos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvCorrelativos.Appearance.Empty.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvCorrelativos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvCorrelativos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvCorrelativos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCorrelativos.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCorrelativos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCorrelativos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvCorrelativos.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCorrelativos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvCorrelativos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvCorrelativos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvCorrelativos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvCorrelativos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvCorrelativos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvCorrelativos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvCorrelativos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvCorrelativos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvCorrelativos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvCorrelativos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvCorrelativos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvCorrelativos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCorrelativos.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCorrelativos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCorrelativos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCorrelativos.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCorrelativos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvCorrelativos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvCorrelativos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCorrelativos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCorrelativos.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvCorrelativos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvCorrelativos.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvCorrelativos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCorrelativos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCorrelativos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvCorrelativos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvCorrelativos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvCorrelativos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvCorrelativos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCorrelativos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvCorrelativos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCorrelativos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCorrelativos.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvCorrelativos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvCorrelativos.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvCorrelativos.Appearance.GroupRow.Options.UseFont = true;
            this.gvCorrelativos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvCorrelativos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCorrelativos.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCorrelativos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCorrelativos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCorrelativos.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCorrelativos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvCorrelativos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvCorrelativos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvCorrelativos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvCorrelativos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvCorrelativos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvCorrelativos.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvCorrelativos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvCorrelativos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvCorrelativos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvCorrelativos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvCorrelativos.Appearance.Preview.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.Preview.Options.UseForeColor = true;
            this.gvCorrelativos.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvCorrelativos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvCorrelativos.Appearance.Row.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.Row.Options.UseForeColor = true;
            this.gvCorrelativos.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvCorrelativos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvCorrelativos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvCorrelativos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvCorrelativos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvCorrelativos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvCorrelativos.Appearance.VertLine.Options.UseBackColor = true;
            this.gvCorrelativos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcCorr_cod_type_sample,
            this.gcCorr_prefix,
            this.gcCorr_cod_serie,
            this.gcCorr_correlative,
            this.gcCorr_num_digits,
            this.gcCorr_mreach15});
            this.gvCorrelativos.GridControl = this.gcCorrelativos;
            this.gvCorrelativos.Name = "gvCorrelativos";
            this.gvCorrelativos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCorrelativos.OptionsView.EnableAppearanceOddRow = true;
            this.gvCorrelativos.OptionsView.ShowGroupPanel = false;
            // 
            // gcCorr_cod_type_sample
            // 
            this.gcCorr_cod_type_sample.Caption = "Tipo de Muestra";
            this.gcCorr_cod_type_sample.ColumnEdit = this.repTypeSample;
            this.gcCorr_cod_type_sample.FieldName = "Cod_type_sample";
            this.gcCorr_cod_type_sample.Name = "gcCorr_cod_type_sample";
            this.gcCorr_cod_type_sample.OptionsColumn.AllowEdit = false;
            this.gcCorr_cod_type_sample.OptionsColumn.ReadOnly = true;
            this.gcCorr_cod_type_sample.Visible = true;
            this.gcCorr_cod_type_sample.VisibleIndex = 0;
            this.gcCorr_cod_type_sample.Width = 93;
            // 
            // repTypeSample
            // 
            this.repTypeSample.AutoHeight = false;
            this.repTypeSample.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTypeSample.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cod_type_sample"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name_type_sample")});
            this.repTypeSample.Name = "repTypeSample";
            // 
            // gcCorr_prefix
            // 
            this.gcCorr_prefix.Caption = "Prefijo";
            this.gcCorr_prefix.FieldName = "Prefix";
            this.gcCorr_prefix.Name = "gcCorr_prefix";
            this.gcCorr_prefix.Visible = true;
            this.gcCorr_prefix.VisibleIndex = 1;
            this.gcCorr_prefix.Width = 117;
            // 
            // gcCorr_cod_serie
            // 
            this.gcCorr_cod_serie.Caption = "Cod serie";
            this.gcCorr_cod_serie.FieldName = "Cod_serie";
            this.gcCorr_cod_serie.Name = "gcCorr_cod_serie";
            this.gcCorr_cod_serie.OptionsColumn.AllowEdit = false;
            this.gcCorr_cod_serie.Visible = true;
            this.gcCorr_cod_serie.VisibleIndex = 2;
            // 
            // gcCorr_correlative
            // 
            this.gcCorr_correlative.Caption = "Correlativo";
            this.gcCorr_correlative.FieldName = "Correlative";
            this.gcCorr_correlative.Name = "gcCorr_correlative";
            this.gcCorr_correlative.Visible = true;
            this.gcCorr_correlative.VisibleIndex = 3;
            this.gcCorr_correlative.Width = 94;
            // 
            // gcCorr_num_digits
            // 
            this.gcCorr_num_digits.Caption = "N°Dígitos";
            this.gcCorr_num_digits.FieldName = "Num_digits";
            this.gcCorr_num_digits.Name = "gcCorr_num_digits";
            this.gcCorr_num_digits.Visible = true;
            this.gcCorr_num_digits.VisibleIndex = 4;
            this.gcCorr_num_digits.Width = 108;
            // 
            // gcCorr_mreach15
            // 
            this.gcCorr_mreach15.Caption = "Mr cada 15";
            this.gcCorr_mreach15.FieldName = "Mreach15";
            this.gcCorr_mreach15.Name = "gcCorr_mreach15";
            this.gcCorr_mreach15.Width = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Periodo:";
            // 
            // cbYear
            // 
            this.cbYear.Location = new System.Drawing.Point(57, 6);
            this.cbYear.Name = "cbYear";
            this.cbYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Nuevo", -1, true, true, true, DevExpress.Utils.HorzAlignment.Center, null)});
            this.cbYear.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cod_serie"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nom_serie")});
            this.cbYear.Properties.NullText = "Seleccionar";
            this.cbYear.Properties.ShowFooter = false;
            this.cbYear.Properties.ShowHeader = false;
            this.cbYear.Size = new System.Drawing.Size(147, 20);
            this.cbYear.TabIndex = 7;
            this.cbYear.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbYear_ButtonClick);
            this.cbYear.EditValueChanged += new System.EventHandler(this.cbYear_EditValueChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbYear);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(555, 36);
            this.panel4.TabIndex = 7;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 36);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(555, 224);
            this.xtraTabControl1.TabIndex = 8;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.Text = "xtraTabControl1";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcCorrelativos);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(546, 194);
            this.xtraTabPage1.Text = "Tipo de muestra";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gcVarios);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(546, 194);
            this.xtraTabPage2.Text = "Varios";
            // 
            // gcVarios
            // 
            this.gcVarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVarios.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcVarios.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gcVarios.EmbeddedNavigator.Name = "";
            this.gcVarios.Location = new System.Drawing.Point(0, 0);
            this.gcVarios.MainView = this.gvVarios;
            this.gcVarios.Name = "gcVarios";
            this.gcVarios.Size = new System.Drawing.Size(546, 194);
            this.gcVarios.TabIndex = 1;
            this.gcVarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVarios});
            // 
            // gvVarios
            // 
            this.gvVarios.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVarios.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvVarios.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVarios.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvVarios.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvVarios.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvVarios.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvVarios.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvVarios.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvVarios.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvVarios.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvVarios.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvVarios.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvVarios.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvVarios.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvVarios.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvVarios.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvVarios.Appearance.Empty.Options.UseBackColor = true;
            this.gvVarios.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvVarios.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvVarios.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvVarios.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvVarios.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVarios.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvVarios.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVarios.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvVarios.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvVarios.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvVarios.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvVarios.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvVarios.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvVarios.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvVarios.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvVarios.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvVarios.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvVarios.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvVarios.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvVarios.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvVarios.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvVarios.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvVarios.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvVarios.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvVarios.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvVarios.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvVarios.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVarios.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvVarios.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVarios.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvVarios.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvVarios.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvVarios.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvVarios.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvVarios.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvVarios.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvVarios.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvVarios.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvVarios.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvVarios.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvVarios.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvVarios.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvVarios.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvVarios.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvVarios.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvVarios.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvVarios.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvVarios.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVarios.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvVarios.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvVarios.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvVarios.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvVarios.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvVarios.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvVarios.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvVarios.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvVarios.Appearance.GroupRow.Options.UseFont = true;
            this.gvVarios.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvVarios.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVarios.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvVarios.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVarios.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvVarios.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvVarios.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvVarios.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvVarios.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvVarios.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvVarios.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvVarios.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvVarios.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvVarios.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvVarios.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvVarios.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvVarios.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvVarios.Appearance.OddRow.Options.UseBackColor = true;
            this.gvVarios.Appearance.OddRow.Options.UseForeColor = true;
            this.gvVarios.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvVarios.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvVarios.Appearance.Preview.Options.UseBackColor = true;
            this.gvVarios.Appearance.Preview.Options.UseForeColor = true;
            this.gvVarios.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvVarios.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvVarios.Appearance.Row.Options.UseBackColor = true;
            this.gvVarios.Appearance.Row.Options.UseForeColor = true;
            this.gvVarios.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvVarios.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvVarios.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvVarios.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvVarios.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvVarios.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvVarios.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvVarios.Appearance.VertLine.Options.UseBackColor = true;
            this.gvVarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcVar_Cod_module,
            this.gcVar_Name_module,
            this.gcVar_Prefix,
            this.gcVar_Cod_serie,
            this.gcVar_Correlative,
            this.gcVar_Num_digits});
            this.gvVarios.GridControl = this.gcVarios;
            this.gvVarios.Name = "gvVarios";
            this.gvVarios.OptionsView.EnableAppearanceEvenRow = true;
            this.gvVarios.OptionsView.EnableAppearanceOddRow = true;
            this.gvVarios.OptionsView.ShowGroupPanel = false;
            // 
            // gcVar_Cod_module
            // 
            this.gcVar_Cod_module.Caption = "Cod. Modulo";
            this.gcVar_Cod_module.FieldName = "Cod_module";
            this.gcVar_Cod_module.Name = "gcVar_Cod_module";
            this.gcVar_Cod_module.Width = 93;
            // 
            // gcVar_Name_module
            // 
            this.gcVar_Name_module.Caption = "Nombre";
            this.gcVar_Name_module.FieldName = "Name_module";
            this.gcVar_Name_module.Name = "gcVar_Name_module";
            this.gcVar_Name_module.Visible = true;
            this.gcVar_Name_module.VisibleIndex = 0;
            this.gcVar_Name_module.Width = 117;
            // 
            // gcVar_Prefix
            // 
            this.gcVar_Prefix.Caption = "Prefijo";
            this.gcVar_Prefix.FieldName = "Prefix";
            this.gcVar_Prefix.Name = "gcVar_Prefix";
            this.gcVar_Prefix.Visible = true;
            this.gcVar_Prefix.VisibleIndex = 1;
            this.gcVar_Prefix.Width = 94;
            // 
            // gcVar_Cod_serie
            // 
            this.gcVar_Cod_serie.Caption = "Cod serie";
            this.gcVar_Cod_serie.FieldName = "Cod_serie";
            this.gcVar_Cod_serie.Name = "gcVar_Cod_serie";
            this.gcVar_Cod_serie.OptionsColumn.AllowEdit = false;
            this.gcVar_Cod_serie.Visible = true;
            this.gcVar_Cod_serie.VisibleIndex = 2;
            // 
            // gcVar_Correlative
            // 
            this.gcVar_Correlative.Caption = "Correlativo";
            this.gcVar_Correlative.FieldName = "Correlative";
            this.gcVar_Correlative.Name = "gcVar_Correlative";
            this.gcVar_Correlative.Visible = true;
            this.gcVar_Correlative.VisibleIndex = 3;
            this.gcVar_Correlative.Width = 97;
            // 
            // gcVar_Num_digits
            // 
            this.gcVar_Num_digits.Caption = "N°Dígitos";
            this.gcVar_Num_digits.FieldName = "Num_digits";
            this.gcVar_Num_digits.Name = "gcVar_Num_digits";
            this.gcVar_Num_digits.Visible = true;
            this.gcVar_Num_digits.VisibleIndex = 4;
            this.gcVar_Num_digits.Width = 108;
            // 
            // FormCorrelatives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 427);
            this.Name = "FormCorrelatives";
            this.Text = "Correlativos";
            this.Load += new System.EventHandler(this.FormCorrelativos_Load);
            this.paTitleSearch.ResumeLayout(false);
            this.paTopBasicButtons.ResumeLayout(false);
            this.paTopSearch.ResumeLayout(false);
            this.paBottomSearch.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.paSearchGen.ResumeLayout(false);
            this.paSearchGen.PerformLayout();
            this.paInferior.ResumeLayout(false);
            this.paTitulo.ResumeLayout(false);
            this.paCentral.ResumeLayout(false);
            this.thePanelTab1.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCorrelativos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCorrelativos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTypeSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbYear.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcVarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCorrelativos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCorrelativos;
        private DevExpress.XtraGrid.Columns.GridColumn gcCorr_prefix;
        private DevExpress.XtraGrid.Columns.GridColumn gcCorr_correlative;
        private DevExpress.XtraGrid.Columns.GridColumn gcCorr_mreach15;
        private DevExpress.XtraGrid.Columns.GridColumn gcCorr_num_digits;
        private DevExpress.XtraGrid.Columns.GridColumn gcCorr_cod_type_sample;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.LookUpEdit cbYear;
        private DevExpress.XtraGrid.Columns.GridColumn gcCorr_cod_serie;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gcVarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVarios;
        private DevExpress.XtraGrid.Columns.GridColumn gcVar_Cod_module;
        private DevExpress.XtraGrid.Columns.GridColumn gcVar_Name_module;
        private DevExpress.XtraGrid.Columns.GridColumn gcVar_Prefix;
        private DevExpress.XtraGrid.Columns.GridColumn gcVar_Correlative;
        private DevExpress.XtraGrid.Columns.GridColumn gcVar_Num_digits;
        private DevExpress.XtraGrid.Columns.GridColumn gcVar_Cod_serie;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTypeSample;
    }
}