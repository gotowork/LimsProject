namespace LimsProject
{
    partial class UcSolIntermV2
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcSolIntermV2));
            this.tcol_Solution_status = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repStatusSolution = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btStdVerif = new DevExpress.XtraEditors.SimpleButton();
            this.btSolInterm1 = new DevExpress.XtraEditors.SimpleButton();
            this.btSolInterm2 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucSign1 = new LimsProject.UcSign();
            this.treeSolInterm = new DevExpress.XtraTreeList.TreeList();
            this.tcol_Cod_solution = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tcol_Nombre = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tcol_Concentration = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tcol_Aliquot = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tcol_Volumen = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repVolumen = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.tcol_Idreactive_medium = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repReactive = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tcol_Reactive_medium_value = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repReactiveValue = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.tcol_Idreactive_modif = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tcol_Reactive_modif_value = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tcol_Date_begin = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.redDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.tcol_Date_end = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tcol_Prepared_by = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repUser = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tcol_Concat_methods = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tcol_Idsolution = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tcol_Type_sol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbMedium = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUnd = new DevExpress.XtraEditors.TextEdit();
            this.tbConcentPattern = new DevExpress.XtraEditors.TextEdit();
            this.cbMrpattern = new DevExpress.XtraEditors.LookUpEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbModif = new DevExpress.XtraEditors.LookUpEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbTypeSolPatron = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.paHeader = new DevExpress.XtraEditors.PanelControl();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.repStatusSolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeSolInterm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repReactive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repReactiveValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMedium.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConcentPattern.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMrpattern.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbModif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTypeSolPatron.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paHeader)).BeginInit();
            this.paHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcol_Solution_status
            // 
            this.tcol_Solution_status.Caption = "Estado";
            this.tcol_Solution_status.ColumnEdit = this.repStatusSolution;
            this.tcol_Solution_status.FieldName = "Solution_status";
            this.tcol_Solution_status.Name = "tcol_Solution_status";
            this.tcol_Solution_status.VisibleIndex = 10;
            // 
            // repStatusSolution
            // 
            this.repStatusSolution.AutoHeight = false;
            this.repStatusSolution.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repStatusSolution.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Desactivado", false, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Activado", true, -1)});
            this.repStatusSolution.Name = "repStatusSolution";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 389);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(847, 68);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Text = "paBottom";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btStdVerif);
            this.groupControl1.Controls.Add(this.btSolInterm1);
            this.groupControl1.Controls.Add(this.btSolInterm2);
            this.groupControl1.Location = new System.Drawing.Point(9, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(250, 58);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Agregar";
            // 
            // btStdVerif
            // 
            this.btStdVerif.Appearance.Options.UseTextOptions = true;
            this.btStdVerif.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btStdVerif.Location = new System.Drawing.Point(168, 20);
            this.btStdVerif.Name = "btStdVerif";
            this.btStdVerif.Size = new System.Drawing.Size(75, 35);
            this.btStdVerif.TabIndex = 3;
            this.btStdVerif.Text = "Estandar de Verificación";
            this.btStdVerif.Click += new System.EventHandler(this.btStdVerf1_Click);
            // 
            // btSolInterm1
            // 
            this.btSolInterm1.Appearance.Options.UseTextOptions = true;
            this.btSolInterm1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btSolInterm1.Location = new System.Drawing.Point(5, 20);
            this.btSolInterm1.Name = "btSolInterm1";
            this.btSolInterm1.Size = new System.Drawing.Size(76, 35);
            this.btSolInterm1.TabIndex = 5;
            this.btSolInterm1.Text = "Solución Intermedia 1";
            this.btSolInterm1.Click += new System.EventHandler(this.btSolInterm1_Click);
            // 
            // btSolInterm2
            // 
            this.btSolInterm2.Appearance.Options.UseTextOptions = true;
            this.btSolInterm2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btSolInterm2.Location = new System.Drawing.Point(87, 20);
            this.btSolInterm2.Name = "btSolInterm2";
            this.btSolInterm2.Size = new System.Drawing.Size(75, 35);
            this.btSolInterm2.TabIndex = 4;
            this.btSolInterm2.Text = "Solución Intermedia 2";
            this.btSolInterm2.Click += new System.EventHandler(this.btSolInterm2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucSign1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(674, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 64);
            this.panel1.TabIndex = 8;
            // 
            // ucSign1
            // 
            this.ucSign1.Location = new System.Drawing.Point(7, 12);
            this.ucSign1.Margin = new System.Windows.Forms.Padding(0);
            this.ucSign1.Name = "ucSign1";
            this.ucSign1.Pwd = null;
            this.ucSign1.Size = new System.Drawing.Size(158, 40);
            this.ucSign1.TabIndex = 6;
            this.ucSign1.Title = "";
            this.ucSign1.OnSign += new LimsProject.sign(this.ucSign1_OnSign);
            // 
            // treeSolInterm
            // 
            this.treeSolInterm.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.treeSolInterm.Appearance.Empty.Options.UseBackColor = true;
            this.treeSolInterm.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.treeSolInterm.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.treeSolInterm.Appearance.EvenRow.Options.UseBackColor = true;
            this.treeSolInterm.Appearance.EvenRow.Options.UseForeColor = true;
            this.treeSolInterm.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.treeSolInterm.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.treeSolInterm.Appearance.FocusedCell.Options.UseBackColor = true;
            this.treeSolInterm.Appearance.FocusedCell.Options.UseForeColor = true;
            this.treeSolInterm.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(240)))));
            this.treeSolInterm.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.treeSolInterm.Appearance.FocusedRow.Options.UseBackColor = true;
            this.treeSolInterm.Appearance.FocusedRow.Options.UseForeColor = true;
            this.treeSolInterm.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.treeSolInterm.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.treeSolInterm.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.treeSolInterm.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.treeSolInterm.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.treeSolInterm.Appearance.FooterPanel.Options.UseBackColor = true;
            this.treeSolInterm.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.treeSolInterm.Appearance.FooterPanel.Options.UseForeColor = true;
            this.treeSolInterm.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.treeSolInterm.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.treeSolInterm.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.treeSolInterm.Appearance.GroupButton.Options.UseBackColor = true;
            this.treeSolInterm.Appearance.GroupButton.Options.UseBorderColor = true;
            this.treeSolInterm.Appearance.GroupButton.Options.UseForeColor = true;
            this.treeSolInterm.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.treeSolInterm.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.treeSolInterm.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.treeSolInterm.Appearance.GroupFooter.Options.UseBackColor = true;
            this.treeSolInterm.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.treeSolInterm.Appearance.GroupFooter.Options.UseForeColor = true;
            this.treeSolInterm.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.treeSolInterm.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.treeSolInterm.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.treeSolInterm.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.treeSolInterm.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.treeSolInterm.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.treeSolInterm.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.treeSolInterm.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.treeSolInterm.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.treeSolInterm.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.treeSolInterm.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.treeSolInterm.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.treeSolInterm.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.treeSolInterm.Appearance.HorzLine.Options.UseBackColor = true;
            this.treeSolInterm.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.treeSolInterm.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.treeSolInterm.Appearance.OddRow.Options.UseBackColor = true;
            this.treeSolInterm.Appearance.OddRow.Options.UseForeColor = true;
            this.treeSolInterm.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.treeSolInterm.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.treeSolInterm.Appearance.Preview.Options.UseBackColor = true;
            this.treeSolInterm.Appearance.Preview.Options.UseForeColor = true;
            this.treeSolInterm.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.treeSolInterm.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.treeSolInterm.Appearance.Row.Options.UseBackColor = true;
            this.treeSolInterm.Appearance.Row.Options.UseForeColor = true;
            this.treeSolInterm.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(240)))));
            this.treeSolInterm.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.treeSolInterm.Appearance.SelectedRow.Options.UseBackColor = true;
            this.treeSolInterm.Appearance.SelectedRow.Options.UseForeColor = true;
            this.treeSolInterm.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.treeSolInterm.Appearance.TreeLine.Options.UseBackColor = true;
            this.treeSolInterm.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.treeSolInterm.Appearance.VertLine.Options.UseBackColor = true;
            this.treeSolInterm.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tcol_Cod_solution,
            this.tcol_Nombre,
            this.tcol_Concentration,
            this.tcol_Aliquot,
            this.tcol_Volumen,
            this.tcol_Idreactive_medium,
            this.tcol_Reactive_medium_value,
            this.tcol_Idreactive_modif,
            this.tcol_Reactive_modif_value,
            this.tcol_Date_begin,
            this.tcol_Date_end,
            this.tcol_Solution_status,
            this.tcol_Prepared_by,
            this.tcol_Concat_methods,
            this.tcol_Idsolution,
            this.tcol_Type_sol});
            this.treeSolInterm.Dock = System.Windows.Forms.DockStyle.Fill;
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.tcol_Solution_status;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = false;
            this.treeSolInterm.FormatConditions.AddRange(new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition[] {
            styleFormatCondition1});
            this.treeSolInterm.ImageIndexFieldName = "Image_index";
            this.treeSolInterm.KeyFieldName = "Id";
            this.treeSolInterm.Location = new System.Drawing.Point(0, 79);
            this.treeSolInterm.Name = "treeSolInterm";
            this.treeSolInterm.OptionsView.AutoWidth = false;
            this.treeSolInterm.OptionsView.EnableAppearanceEvenRow = true;
            this.treeSolInterm.OptionsView.EnableAppearanceOddRow = true;
            this.treeSolInterm.ParentFieldName = "Parentid";
            this.treeSolInterm.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repStatusSolution,
            this.repReactive,
            this.repReactiveValue,
            this.redDate,
            this.repUser,
            this.repVolumen});
            this.treeSolInterm.SelectImageList = this.imageList1;
            this.treeSolInterm.Size = new System.Drawing.Size(847, 310);
            this.treeSolInterm.TabIndex = 1;
            this.treeSolInterm.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.treeSolInterm_CellValueChanged);
            // 
            // tcol_Cod_solution
            // 
            this.tcol_Cod_solution.Caption = "Codigo";
            this.tcol_Cod_solution.FieldName = "Cod_solution";
            this.tcol_Cod_solution.MinWidth = 64;
            this.tcol_Cod_solution.Name = "tcol_Cod_solution";
            this.tcol_Cod_solution.OptionsColumn.AllowEdit = false;
            this.tcol_Cod_solution.OptionsColumn.FixedWidth = true;
            this.tcol_Cod_solution.VisibleIndex = 0;
            this.tcol_Cod_solution.Width = 154;
            // 
            // tcol_Nombre
            // 
            this.tcol_Nombre.Caption = "Nombre";
            this.tcol_Nombre.FieldName = "Nombre";
            this.tcol_Nombre.Name = "tcol_Nombre";
            this.tcol_Nombre.Width = 112;
            // 
            // tcol_Concentration
            // 
            this.tcol_Concentration.Caption = "concentracion";
            this.tcol_Concentration.FieldName = "Concentration";
            this.tcol_Concentration.Name = "tcol_Concentration";
            this.tcol_Concentration.OptionsColumn.AllowEdit = false;
            this.tcol_Concentration.VisibleIndex = 1;
            this.tcol_Concentration.Width = 81;
            // 
            // tcol_Aliquot
            // 
            this.tcol_Aliquot.Caption = "alicuota";
            this.tcol_Aliquot.FieldName = "Aliquot";
            this.tcol_Aliquot.Name = "tcol_Aliquot";
            this.tcol_Aliquot.OptionsColumn.AllowEdit = false;
            this.tcol_Aliquot.VisibleIndex = 2;
            this.tcol_Aliquot.Width = 57;
            // 
            // tcol_Volumen
            // 
            this.tcol_Volumen.Caption = "volumen";
            this.tcol_Volumen.ColumnEdit = this.repVolumen;
            this.tcol_Volumen.FieldName = "Volumen";
            this.tcol_Volumen.Name = "tcol_Volumen";
            this.tcol_Volumen.VisibleIndex = 3;
            this.tcol_Volumen.Width = 63;
            // 
            // repVolumen
            // 
            this.repVolumen.AutoHeight = false;
            this.repVolumen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repVolumen.Name = "repVolumen";
            this.repVolumen.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repVolumen_EditValueChanging);
            // 
            // tcol_Idreactive_medium
            // 
            this.tcol_Idreactive_medium.Caption = "Matriz";
            this.tcol_Idreactive_medium.ColumnEdit = this.repReactive;
            this.tcol_Idreactive_medium.FieldName = "Idreactive_medium";
            this.tcol_Idreactive_medium.Name = "tcol_Idreactive_medium";
            this.tcol_Idreactive_medium.OptionsColumn.AllowEdit = false;
            this.tcol_Idreactive_medium.VisibleIndex = 4;
            this.tcol_Idreactive_medium.Width = 86;
            // 
            // repReactive
            // 
            this.repReactive.AutoHeight = false;
            this.repReactive.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repReactive.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idreactive", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Reactive_name")});
            this.repReactive.Name = "repReactive";
            this.repReactive.NullText = "---";
            this.repReactive.ShowFooter = false;
            this.repReactive.ShowHeader = false;
            // 
            // tcol_Reactive_medium_value
            // 
            this.tcol_Reactive_medium_value.Caption = "Matriz%";
            this.tcol_Reactive_medium_value.ColumnEdit = this.repReactiveValue;
            this.tcol_Reactive_medium_value.FieldName = "Reactive_medium_value";
            this.tcol_Reactive_medium_value.Name = "tcol_Reactive_medium_value";
            this.tcol_Reactive_medium_value.OptionsColumn.AllowEdit = false;
            this.tcol_Reactive_medium_value.VisibleIndex = 5;
            this.tcol_Reactive_medium_value.Width = 62;
            // 
            // repReactiveValue
            // 
            this.repReactiveValue.AutoHeight = false;
            this.repReactiveValue.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repReactiveValue.Name = "repReactiveValue";
            // 
            // tcol_Idreactive_modif
            // 
            this.tcol_Idreactive_modif.Caption = "Modif";
            this.tcol_Idreactive_modif.ColumnEdit = this.repReactive;
            this.tcol_Idreactive_modif.FieldName = "Idreactive_modif";
            this.tcol_Idreactive_modif.Name = "tcol_Idreactive_modif";
            this.tcol_Idreactive_modif.OptionsColumn.AllowEdit = false;
            this.tcol_Idreactive_modif.VisibleIndex = 6;
            this.tcol_Idreactive_modif.Width = 91;
            // 
            // tcol_Reactive_modif_value
            // 
            this.tcol_Reactive_modif_value.Caption = "Modif%";
            this.tcol_Reactive_modif_value.ColumnEdit = this.repReactiveValue;
            this.tcol_Reactive_modif_value.FieldName = "Reactive_modif_value";
            this.tcol_Reactive_modif_value.Name = "tcol_Reactive_modif_value";
            this.tcol_Reactive_modif_value.OptionsColumn.AllowEdit = false;
            this.tcol_Reactive_modif_value.VisibleIndex = 7;
            this.tcol_Reactive_modif_value.Width = 62;
            // 
            // tcol_Date_begin
            // 
            this.tcol_Date_begin.Caption = "Fecha Inicial";
            this.tcol_Date_begin.ColumnEdit = this.redDate;
            this.tcol_Date_begin.FieldName = "Date_begin";
            this.tcol_Date_begin.Name = "tcol_Date_begin";
            this.tcol_Date_begin.OptionsColumn.AllowEdit = false;
            this.tcol_Date_begin.VisibleIndex = 8;
            this.tcol_Date_begin.Width = 72;
            // 
            // redDate
            // 
            this.redDate.AutoHeight = false;
            this.redDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.redDate.Name = "redDate";
            // 
            // tcol_Date_end
            // 
            this.tcol_Date_end.Caption = "Fecha Final";
            this.tcol_Date_end.ColumnEdit = this.redDate;
            this.tcol_Date_end.FieldName = "Date_end";
            this.tcol_Date_end.Name = "tcol_Date_end";
            this.tcol_Date_end.OptionsColumn.AllowEdit = false;
            this.tcol_Date_end.VisibleIndex = 9;
            this.tcol_Date_end.Width = 74;
            // 
            // tcol_Prepared_by
            // 
            this.tcol_Prepared_by.Caption = "Preparado por";
            this.tcol_Prepared_by.ColumnEdit = this.repUser;
            this.tcol_Prepared_by.FieldName = "Prepared_by";
            this.tcol_Prepared_by.Name = "tcol_Prepared_by";
            this.tcol_Prepared_by.VisibleIndex = 11;
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
            this.repUser.ShowFooter = false;
            this.repUser.ShowHeader = false;
            // 
            // tcol_Concat_methods
            // 
            this.tcol_Concat_methods.Caption = "Métodos";
            this.tcol_Concat_methods.FieldName = "Concat_cod_methods";
            this.tcol_Concat_methods.Name = "tcol_Concat_methods";
            // 
            // tcol_Idsolution
            // 
            this.tcol_Idsolution.Caption = "Idsolution";
            this.tcol_Idsolution.FieldName = "Idsolution";
            this.tcol_Idsolution.Name = "tcol_Idsolution";
            // 
            // tcol_Type_sol
            // 
            this.tcol_Type_sol.Caption = "type_sol";
            this.tcol_Type_sol.FieldName = "Type_sol";
            this.tcol_Type_sol.Name = "tcol_Type_sol";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "fiola.png");
            this.imageList1.Images.SetKeyName(1, "fiola_ver.png");
            // 
            // cbMedium
            // 
            this.cbMedium.Location = new System.Drawing.Point(46, 49);
            this.cbMedium.Name = "cbMedium";
            this.cbMedium.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbMedium.Properties.Appearance.Options.UseFont = true;
            this.cbMedium.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMedium.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idreactive", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Reactive_name")});
            this.cbMedium.Properties.NullText = "---";
            this.cbMedium.Properties.ShowFooter = false;
            this.cbMedium.Properties.ShowHeader = false;
            this.cbMedium.Size = new System.Drawing.Size(121, 20);
            this.cbMedium.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Und";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Concentración";
            // 
            // tbUnd
            // 
            this.tbUnd.Location = new System.Drawing.Point(310, 26);
            this.tbUnd.Name = "tbUnd";
            this.tbUnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbUnd.Properties.Appearance.Options.UseFont = true;
            this.tbUnd.Size = new System.Drawing.Size(24, 20);
            this.tbUnd.TabIndex = 30;
            // 
            // tbConcentPattern
            // 
            this.tbConcentPattern.EditValue = "";
            this.tbConcentPattern.Location = new System.Drawing.Point(222, 26);
            this.tbConcentPattern.Name = "tbConcentPattern";
            this.tbConcentPattern.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbConcentPattern.Properties.Appearance.Options.UseFont = true;
            this.tbConcentPattern.Size = new System.Drawing.Size(85, 20);
            this.tbConcentPattern.TabIndex = 30;
            // 
            // cbMrpattern
            // 
            this.cbMrpattern.Location = new System.Drawing.Point(116, 26);
            this.cbMrpattern.Name = "cbMrpattern";
            this.cbMrpattern.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbMrpattern.Properties.Appearance.Options.UseFont = true;
            this.cbMrpattern.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMrpattern.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idmr_detail", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idsolution", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.cbMrpattern.Properties.NullText = "Seleccionar";
            this.cbMrpattern.Properties.ShowFooter = false;
            this.cbMrpattern.Properties.ShowHeader = false;
            this.cbMrpattern.Size = new System.Drawing.Size(100, 20);
            this.cbMrpattern.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(135, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Cod MR";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Tipo de MR";
            // 
            // cbModif
            // 
            this.cbModif.Location = new System.Drawing.Point(222, 49);
            this.cbModif.Name = "cbModif";
            this.cbModif.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbModif.Properties.Appearance.Options.UseFont = true;
            this.cbModif.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbModif.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idreactive", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Reactive_name")});
            this.cbModif.Properties.NullText = "---";
            this.cbModif.Properties.ShowFooter = false;
            this.cbModif.Properties.ShowHeader = false;
            this.cbModif.Size = new System.Drawing.Size(112, 20);
            this.cbModif.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Medio:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(180, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Modif:";
            // 
            // cbTypeSolPatron
            // 
            this.cbTypeSolPatron.Location = new System.Drawing.Point(10, 26);
            this.cbTypeSolPatron.Name = "cbTypeSolPatron";
            this.cbTypeSolPatron.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbTypeSolPatron.Properties.Appearance.Options.UseFont = true;
            this.cbTypeSolPatron.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTypeSolPatron.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("MRC", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Sol. Patron", 2, -1)});
            this.cbTypeSolPatron.Size = new System.Drawing.Size(100, 20);
            this.cbTypeSolPatron.TabIndex = 28;
            this.cbTypeSolPatron.SelectedIndexChanged += new System.EventHandler(this.cbTypeSolPatron_SelectedIndexChanged);
            // 
            // paHeader
            // 
            this.paHeader.Controls.Add(this.cbTypeSolPatron);
            this.paHeader.Controls.Add(this.label16);
            this.paHeader.Controls.Add(this.label15);
            this.paHeader.Controls.Add(this.cbModif);
            this.paHeader.Controls.Add(this.label14);
            this.paHeader.Controls.Add(this.label13);
            this.paHeader.Controls.Add(this.cbMrpattern);
            this.paHeader.Controls.Add(this.tbConcentPattern);
            this.paHeader.Controls.Add(this.tbUnd);
            this.paHeader.Controls.Add(this.label5);
            this.paHeader.Controls.Add(this.label1);
            this.paHeader.Controls.Add(this.cbMedium);
            this.paHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.paHeader.Enabled = false;
            this.paHeader.Location = new System.Drawing.Point(0, 0);
            this.paHeader.Name = "paHeader";
            this.paHeader.Size = new System.Drawing.Size(847, 79);
            this.paHeader.TabIndex = 36;
            this.paHeader.Text = "panelControl2";
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Id";
            this.treeListColumn2.FieldName = "Id";
            this.treeListColumn2.Name = "treeListColumn2";
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Parentid";
            this.treeListColumn3.FieldName = "Parentid";
            this.treeListColumn3.Name = "treeListColumn3";
            // 
            // UcSolIntermV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeSolInterm);
            this.Controls.Add(this.paHeader);
            this.Controls.Add(this.panelControl1);
            this.Name = "UcSolIntermV2";
            this.Size = new System.Drawing.Size(847, 457);
            ((System.ComponentModel.ISupportInitialize)(this.repStatusSolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeSolInterm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repReactive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repReactiveValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMedium.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConcentPattern.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMrpattern.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbModif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTypeSolPatron.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paHeader)).EndInit();
            this.paHeader.ResumeLayout(false);
            this.paHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private UcSign ucSign1;
        private DevExpress.XtraEditors.SimpleButton btStdVerif;
        private DevExpress.XtraEditors.SimpleButton btSolInterm2;
        private DevExpress.XtraEditors.SimpleButton btSolInterm1;
        private DevExpress.XtraTreeList.TreeList treeSolInterm;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Cod_solution;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Nombre;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Concentration;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Aliquot;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Volumen;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Idreactive_medium;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Reactive_medium_value;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Idreactive_modif;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Reactive_modif_value;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Date_begin;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Date_end;
        private DevExpress.XtraEditors.LookUpEdit cbMedium;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit tbUnd;
        private DevExpress.XtraEditors.TextEdit tbConcentPattern;
        private DevExpress.XtraEditors.LookUpEdit cbMrpattern;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.LookUpEdit cbModif;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbTypeSolPatron;
        private DevExpress.XtraEditors.PanelControl paHeader;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Solution_status;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repStatusSolution;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repReactive;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repReactiveValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit redDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Prepared_by;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repUser;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Concat_methods;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Idsolution;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repVolumen;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Type_sol;
        private System.Windows.Forms.ImageList imageList1;
    }
}
