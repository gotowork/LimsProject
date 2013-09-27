namespace LimsProject
{
    partial class FormCalibs
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalibs));
            LimsProject.BusinessLayer.CGroup_solution cGroup_solution1 = new LimsProject.BusinessLayer.CGroup_solution();
            this.tcol_Solution_status = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repStatusSolution = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.paHeader = new DevExpress.XtraEditors.PanelControl();
            this.gcSolutionChild = new DevExpress.XtraEditors.GroupControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbParentMediumValue = new LimsProject.customSpinEdit();
            this.cbParentMedium = new LimsProject.cbReactive();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbParentModifValue = new LimsProject.customSpinEdit();
            this.cbParentModif = new LimsProject.cbReactive();
            this.cbUser1 = new UserControls.cbUser();
            this.deDateEnd = new LimsProject.customDateEdit();
            this.deDateIni = new LimsProject.customDateEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ckAssignMethod = new DevExpress.XtraEditors.CheckEdit();
            this.paSeparator = new DevExpress.XtraEditors.PanelControl();
            this.gcSolutionParent = new DevExpress.XtraEditors.GroupControl();
            this.label3 = new System.Windows.Forms.Label();
            this.tbParentConcentration = new LimsProject.customTextEdit();
            this.cbElement1 = new LimsProject.cbElement();
            this.cbMethod1 = new LimsProject.cbMethod();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
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
            this.tcol_Flag_current_method = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repAddMethod = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tcol_Idsolution = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tcol_Type_sol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tcol_ShowMethods = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repBtOpenMethods = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tcol_Root_type_pattern = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tcol_Expired_status = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.cmsAddSolution = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btNewSolInt1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btNewSolInt2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btNewSolStdVer = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcMethods = new DevExpress.XtraGrid.GridControl();
            this.gvMethods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gmet_Sel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSel = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gmet_Idtemplate_method = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gmet_Cod_template_method = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gmet_Title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.customPageControl1 = new LimsProject.customPageControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.ucCalibStd1 = new LimsProject.UcCalibStd();
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).BeginInit();
            this.paTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.paCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStatusSolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paHeader)).BeginInit();
            this.paHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSolutionChild)).BeginInit();
            this.gcSolutionChild.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbParentMediumValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbParentMedium.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbParentModifValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbParentModif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUser1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckAssignMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSolutionParent)).BeginInit();
            this.gcSolutionParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbParentConcentration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbElement1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMethod1.Properties)).BeginInit();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeSolInterm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repReactive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repReactiveValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repAddMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBtOpenMethods)).BeginInit();
            this.cmsAddSolution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMethods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMethods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPageControl1)).BeginInit();
            this.customPageControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Size = new System.Drawing.Size(959, 487);
            // 
            // paTitle
            // 
            this.paTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paTitle.Location = new System.Drawing.Point(0, 26);
            this.paTitle.Size = new System.Drawing.Size(963, 491);
            this.paTitle.Visible = false;
            // 
            // paBottom
            // 
            this.paBottom.Location = new System.Drawing.Point(0, 471);
            this.paBottom.Size = new System.Drawing.Size(963, 46);
            this.paBottom.Visible = false;
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.customPageControl1);
            this.paCenter.Controls.Add(this.paHeader);
            this.paCenter.Controls.Add(this.splitterControl1);
            this.paCenter.Controls.Add(this.expandablePanel1);
            this.paCenter.Location = new System.Drawing.Point(0, 46);
            this.paCenter.Size = new System.Drawing.Size(963, 425);
            // 
            // paTop
            // 
            this.paTop.Location = new System.Drawing.Point(0, 26);
            this.paTop.Padding = new System.Windows.Forms.Padding(10);
            this.paTop.Size = new System.Drawing.Size(963, 20);
            this.paTop.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(963, 26);
            this.panelControl1.Visible = false;
            // 
            // tcol_Solution_status
            // 
            this.tcol_Solution_status.Caption = "Estado";
            this.tcol_Solution_status.ColumnEdit = this.repStatusSolution;
            this.tcol_Solution_status.FieldName = "Solution_status";
            this.tcol_Solution_status.Name = "tcol_Solution_status";
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
            // paHeader
            // 
            this.paHeader.Controls.Add(this.gcSolutionChild);
            this.paHeader.Controls.Add(this.paSeparator);
            this.paHeader.Controls.Add(this.gcSolutionParent);
            this.paHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.paHeader.Location = new System.Drawing.Point(303, 2);
            this.paHeader.Name = "paHeader";
            this.paHeader.Padding = new System.Windows.Forms.Padding(10);
            this.paHeader.Size = new System.Drawing.Size(658, 230);
            this.paHeader.TabIndex = 37;
            this.paHeader.Text = "panelControl2";
            // 
            // gcSolutionChild
            // 
            this.gcSolutionChild.Controls.Add(this.groupBox3);
            this.gcSolutionChild.Controls.Add(this.groupBox2);
            this.gcSolutionChild.Controls.Add(this.cbUser1);
            this.gcSolutionChild.Controls.Add(this.deDateEnd);
            this.gcSolutionChild.Controls.Add(this.deDateIni);
            this.gcSolutionChild.Controls.Add(this.label8);
            this.gcSolutionChild.Controls.Add(this.label7);
            this.gcSolutionChild.Controls.Add(this.label6);
            this.gcSolutionChild.Controls.Add(this.ckAssignMethod);
            this.gcSolutionChild.Location = new System.Drawing.Point(12, 77);
            this.gcSolutionChild.Name = "gcSolutionChild";
            this.gcSolutionChild.Size = new System.Drawing.Size(417, 141);
            this.gcSolutionChild.TabIndex = 39;
            this.gcSolutionChild.Text = "Solución Hijo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbParentMediumValue);
            this.groupBox3.Controls.Add(this.cbParentMedium);
            this.groupBox3.Location = new System.Drawing.Point(10, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 42);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Medio";
            // 
            // tbParentMediumValue
            // 
            this.tbParentMediumValue.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbParentMediumValue.Location = new System.Drawing.Point(120, 14);
            this.tbParentMediumValue.Name = "tbParentMediumValue";
            this.tbParentMediumValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbParentMediumValue.Properties.ReadOnly = true;
            this.tbParentMediumValue.Size = new System.Drawing.Size(67, 20);
            this.tbParentMediumValue.TabIndex = 35;
            this.tbParentMediumValue.TabStop = false;
            // 
            // cbParentMedium
            // 
            this.cbParentMedium.Location = new System.Drawing.Point(5, 14);
            this.cbParentMedium.Name = "cbParentMedium";
            this.cbParentMedium.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cbParentMedium.Properties.Appearance.Options.UseBackColor = true;
            this.cbParentMedium.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.cbParentMedium.Properties.NullText = "";
            this.cbParentMedium.Properties.ReadOnly = true;
            this.cbParentMedium.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.cbParentMedium.Size = new System.Drawing.Size(112, 20);
            this.cbParentMedium.TabIndex = 31;
            this.cbParentMedium.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbParentModifValue);
            this.groupBox2.Controls.Add(this.cbParentModif);
            this.groupBox2.Location = new System.Drawing.Point(210, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 42);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificador";
            // 
            // tbParentModifValue
            // 
            this.tbParentModifValue.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbParentModifValue.Location = new System.Drawing.Point(121, 14);
            this.tbParentModifValue.Name = "tbParentModifValue";
            this.tbParentModifValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbParentModifValue.Properties.ReadOnly = true;
            this.tbParentModifValue.Size = new System.Drawing.Size(65, 20);
            this.tbParentModifValue.TabIndex = 35;
            this.tbParentModifValue.TabStop = false;
            // 
            // cbParentModif
            // 
            this.cbParentModif.Location = new System.Drawing.Point(6, 14);
            this.cbParentModif.Name = "cbParentModif";
            this.cbParentModif.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cbParentModif.Properties.Appearance.Options.UseBackColor = true;
            this.cbParentModif.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.cbParentModif.Properties.NullText = "";
            this.cbParentModif.Properties.ReadOnly = true;
            this.cbParentModif.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.cbParentModif.Size = new System.Drawing.Size(112, 20);
            this.cbParentModif.TabIndex = 32;
            this.cbParentModif.TabStop = false;
            // 
            // cbUser1
            // 
            this.cbUser1.Location = new System.Drawing.Point(262, 79);
            this.cbUser1.Name = "cbUser1";
            this.cbUser1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.cbUser1.Properties.NullText = "";
            this.cbUser1.Properties.ReadOnly = true;
            this.cbUser1.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.cbUser1.Size = new System.Drawing.Size(100, 20);
            this.cbUser1.TabIndex = 23;
            // 
            // deDateEnd
            // 
            this.deDateEnd.EditValue = null;
            this.deDateEnd.Location = new System.Drawing.Point(84, 102);
            this.deDateEnd.Name = "deDateEnd";
            this.deDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateEnd.Size = new System.Drawing.Size(100, 20);
            this.deDateEnd.TabIndex = 22;
            this.deDateEnd.EditValueChanged += new System.EventHandler(this.deDateEnd_EditValueChanged);
            // 
            // deDateIni
            // 
            this.deDateIni.EditValue = null;
            this.deDateIni.Location = new System.Drawing.Point(84, 79);
            this.deDateIni.Name = "deDateIni";
            this.deDateIni.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateIni.Size = new System.Drawing.Size(100, 20);
            this.deDateIni.TabIndex = 22;
            this.deDateIni.EditValueChanged += new System.EventHandler(this.deDateIni_EditValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Usuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Fecha Fin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Fecha Inicio:";
            // 
            // ckAssignMethod
            // 
            this.ckAssignMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckAssignMethod.Location = new System.Drawing.Point(226, 106);
            this.ckAssignMethod.Name = "ckAssignMethod";
            this.ckAssignMethod.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ckAssignMethod.Properties.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            this.ckAssignMethod.Properties.Appearance.Options.UseFont = true;
            this.ckAssignMethod.Properties.Appearance.Options.UseForeColor = true;
            this.ckAssignMethod.Properties.Caption = "Asignar al método";
            this.ckAssignMethod.Size = new System.Drawing.Size(143, 21);
            this.ckAssignMethod.TabIndex = 4;
            // 
            // paSeparator
            // 
            this.paSeparator.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.paSeparator.Location = new System.Drawing.Point(12, 67);
            this.paSeparator.Name = "paSeparator";
            this.paSeparator.Size = new System.Drawing.Size(634, 10);
            this.paSeparator.TabIndex = 40;
            this.paSeparator.Text = "panelControl4";
            // 
            // gcSolutionParent
            // 
            this.gcSolutionParent.Controls.Add(this.label3);
            this.gcSolutionParent.Controls.Add(this.tbParentConcentration);
            this.gcSolutionParent.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcSolutionParent.Location = new System.Drawing.Point(12, 12);
            this.gcSolutionParent.Name = "gcSolutionParent";
            this.gcSolutionParent.Size = new System.Drawing.Size(634, 55);
            this.gcSolutionParent.TabIndex = 39;
            this.gcSolutionParent.Text = "Solucion Padre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Concentración:";
            // 
            // tbParentConcentration
            // 
            this.tbParentConcentration.Location = new System.Drawing.Point(104, 26);
            this.tbParentConcentration.Name = "tbParentConcentration";
            this.tbParentConcentration.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbParentConcentration.Properties.Appearance.Options.UseBackColor = true;
            this.tbParentConcentration.Properties.ReadOnly = true;
            this.tbParentConcentration.Size = new System.Drawing.Size(100, 20);
            this.tbParentConcentration.TabIndex = 33;
            this.tbParentConcentration.TabStop = false;
            // 
            // cbElement1
            // 
            this.cbElement1.Location = new System.Drawing.Point(9, 5);
            this.cbElement1.Name = "cbElement1";
            this.cbElement1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbElement1.Size = new System.Drawing.Size(95, 20);
            this.cbElement1.TabIndex = 0;
            this.cbElement1.EditValueChanged += new System.EventHandler(this.cbElement1_EditValueChanged);
            // 
            // cbMethod1
            // 
            this.cbMethod1.Location = new System.Drawing.Point(9, 27);
            this.cbMethod1.Name = "cbMethod1";
            this.cbMethod1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMethod1.Properties.NullText = "Seleccionar";
            this.cbMethod1.Size = new System.Drawing.Size(276, 20);
            this.cbMethod1.TabIndex = 1;
            this.cbMethod1.EditValueChanged += new System.EventHandler(this.cbMethod1_EditValueChanged);
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.LeftToRight;
            this.expandablePanel1.Controls.Add(this.treeSolInterm);
            this.expandablePanel1.Controls.Add(this.panelControl2);
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.expandablePanel1.Location = new System.Drawing.Point(2, 2);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(293, 421);
            this.expandablePanel1.TabIndex = 39;
            this.expandablePanel1.Text = "expandablePanel1";
            this.expandablePanel1.TitleText = "Title Bar";
            // 
            // treeSolInterm
            // 
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
            this.tcol_Flag_current_method,
            this.tcol_Idsolution,
            this.tcol_Type_sol,
            this.tcol_ShowMethods,
            this.tcol_Root_type_pattern,
            this.tcol_Expired_status});
            this.treeSolInterm.ContextMenuStrip = this.cmsAddSolution;
            this.treeSolInterm.Dock = System.Windows.Forms.DockStyle.Fill;
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.White;
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Silver;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.tcol_Solution_status;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = false;
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            styleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.tcol_Solution_status;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "true";
            this.treeSolInterm.FormatConditions.AddRange(new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.treeSolInterm.ImageIndexFieldName = "Image_index";
            this.treeSolInterm.KeyFieldName = "Id";
            this.treeSolInterm.Location = new System.Drawing.Point(0, 81);
            this.treeSolInterm.Name = "treeSolInterm";
            this.treeSolInterm.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeSolInterm.OptionsSelection.MultiSelect = true;
            this.treeSolInterm.OptionsView.AutoWidth = false;
            this.treeSolInterm.ParentFieldName = "Parentid";
            this.treeSolInterm.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repStatusSolution,
            this.repReactive,
            this.repReactiveValue,
            this.redDate,
            this.repUser,
            this.repVolumen,
            this.repBtOpenMethods,
            this.repAddMethod});
            this.treeSolInterm.SelectImageList = this.imageList1;
            this.treeSolInterm.Size = new System.Drawing.Size(293, 340);
            this.treeSolInterm.TabIndex = 40;
            this.treeSolInterm.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeSolInterm_FocusedNodeChanged);
            this.treeSolInterm.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.treeSolInterm_CellValueChanged);
            this.treeSolInterm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeSolInterm_MouseDown);
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
            this.tcol_Cod_solution.Width = 151;
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
            this.tcol_Aliquot.Width = 54;
            // 
            // tcol_Volumen
            // 
            this.tcol_Volumen.Caption = "volumen";
            this.tcol_Volumen.ColumnEdit = this.repVolumen;
            this.tcol_Volumen.FieldName = "Volumen";
            this.tcol_Volumen.Name = "tcol_Volumen";
            this.tcol_Volumen.Width = 57;
            // 
            // repVolumen
            // 
            this.repVolumen.AutoHeight = false;
            this.repVolumen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repVolumen.Name = "repVolumen";
            // 
            // tcol_Idreactive_medium
            // 
            this.tcol_Idreactive_medium.Caption = "Matriz";
            this.tcol_Idreactive_medium.ColumnEdit = this.repReactive;
            this.tcol_Idreactive_medium.FieldName = "Idreactive_medium";
            this.tcol_Idreactive_medium.Name = "tcol_Idreactive_medium";
            this.tcol_Idreactive_medium.OptionsColumn.AllowEdit = false;
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
            this.tcol_Reactive_medium_value.Width = 57;
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
            this.tcol_Idreactive_modif.Width = 91;
            // 
            // tcol_Reactive_modif_value
            // 
            this.tcol_Reactive_modif_value.Caption = "Modif%";
            this.tcol_Reactive_modif_value.ColumnEdit = this.repReactiveValue;
            this.tcol_Reactive_modif_value.FieldName = "Reactive_modif_value";
            this.tcol_Reactive_modif_value.Name = "tcol_Reactive_modif_value";
            this.tcol_Reactive_modif_value.OptionsColumn.AllowEdit = false;
            this.tcol_Reactive_modif_value.Width = 56;
            // 
            // tcol_Date_begin
            // 
            this.tcol_Date_begin.Caption = "Fecha Inicial";
            this.tcol_Date_begin.ColumnEdit = this.redDate;
            this.tcol_Date_begin.FieldName = "Date_begin";
            this.tcol_Date_begin.Name = "tcol_Date_begin";
            this.tcol_Date_begin.OptionsColumn.AllowEdit = false;
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
            this.tcol_Date_end.Width = 74;
            // 
            // tcol_Prepared_by
            // 
            this.tcol_Prepared_by.Caption = "Preparado por";
            this.tcol_Prepared_by.ColumnEdit = this.repUser;
            this.tcol_Prepared_by.FieldName = "Prepared_by";
            this.tcol_Prepared_by.Name = "tcol_Prepared_by";
            this.tcol_Prepared_by.Width = 81;
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
            // tcol_Flag_current_method
            // 
            this.tcol_Flag_current_method.Caption = "Asignado al Método";
            this.tcol_Flag_current_method.ColumnEdit = this.repAddMethod;
            this.tcol_Flag_current_method.FieldName = "Flag_current_method";
            this.tcol_Flag_current_method.Name = "tcol_Flag_current_method";
            this.tcol_Flag_current_method.Width = 108;
            // 
            // repAddMethod
            // 
            this.repAddMethod.AutoHeight = false;
            this.repAddMethod.Name = "repAddMethod";
            // 
            // tcol_Idsolution
            // 
            this.tcol_Idsolution.Caption = "Idsolution";
            this.tcol_Idsolution.FieldName = "Idsolution_interm";
            this.tcol_Idsolution.Name = "tcol_Idsolution";
            // 
            // tcol_Type_sol
            // 
            this.tcol_Type_sol.Caption = "type_sol";
            this.tcol_Type_sol.FieldName = "Type_sol";
            this.tcol_Type_sol.Name = "tcol_Type_sol";
            // 
            // tcol_ShowMethods
            // 
            this.tcol_ShowMethods.Caption = "#";
            this.tcol_ShowMethods.ColumnEdit = this.repBtOpenMethods;
            this.tcol_ShowMethods.FieldName = "#";
            this.tcol_ShowMethods.Name = "tcol_ShowMethods";
            this.tcol_ShowMethods.Width = 53;
            // 
            // repBtOpenMethods
            // 
            this.repBtOpenMethods.AutoHeight = false;
            this.repBtOpenMethods.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Ver", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.repBtOpenMethods.Name = "repBtOpenMethods";
            this.repBtOpenMethods.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repBtOpenMethods.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repBtOpenMethods_ButtonClick);
            // 
            // tcol_Root_type_pattern
            // 
            this.tcol_Root_type_pattern.Caption = "Root_type_pattern";
            this.tcol_Root_type_pattern.FieldName = "Root_type_pattern";
            this.tcol_Root_type_pattern.Name = "tcol_Root_type_pattern";
            // 
            // tcol_Expired_status
            // 
            this.tcol_Expired_status.Caption = "Expiracion";
            this.tcol_Expired_status.FieldName = "Expired_status";
            this.tcol_Expired_status.Name = "tcol_Expired_status";
            // 
            // cmsAddSolution
            // 
            this.cmsAddSolution.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNewSolInt1,
            this.btNewSolInt2,
            this.btNewSolStdVer});
            this.cmsAddSolution.Name = "cmsAddSolution";
            this.cmsAddSolution.Size = new System.Drawing.Size(239, 70);
            // 
            // btNewSolInt1
            // 
            this.btNewSolInt1.Name = "btNewSolInt1";
            this.btNewSolInt1.Size = new System.Drawing.Size(238, 22);
            this.btNewSolInt1.Text = "Nueva Solución Intermedia 1";
            this.btNewSolInt1.Click += new System.EventHandler(this.btNewSolInt1_Click);
            // 
            // btNewSolInt2
            // 
            this.btNewSolInt2.Name = "btNewSolInt2";
            this.btNewSolInt2.Size = new System.Drawing.Size(238, 22);
            this.btNewSolInt2.Text = "Nueva Solución Intermedia 2";
            this.btNewSolInt2.Click += new System.EventHandler(this.btNewSolInt2_Click);
            // 
            // btNewSolStdVer
            // 
            this.btNewSolStdVer.Name = "btNewSolStdVer";
            this.btNewSolStdVer.Size = new System.Drawing.Size(238, 22);
            this.btNewSolStdVer.Text = "Nuevo Estandar de Verificación";
            this.btNewSolStdVer.Click += new System.EventHandler(this.btNewSolStdVer_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "fiola_group.png");
            this.imageList1.Images.SetKeyName(1, "fiola.png");
            this.imageList1.Images.SetKeyName(2, "fiola_ver.png");
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cbMethod1);
            this.panelControl2.Controls.Add(this.cbElement1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 26);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(293, 55);
            this.panelControl2.TabIndex = 41;
            this.panelControl2.Text = "panelControl2";
            // 
            // gcMethods
            // 
            this.gcMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMethods.EmbeddedNavigator.Name = "";
            this.gcMethods.Location = new System.Drawing.Point(0, 0);
            this.gcMethods.MainView = this.gvMethods;
            this.gcMethods.Name = "gcMethods";
            this.gcMethods.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSel});
            this.gcMethods.Size = new System.Drawing.Size(656, 170);
            this.gcMethods.TabIndex = 40;
            this.gcMethods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMethods});
            // 
            // gvMethods
            // 
            this.gvMethods.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gmet_Sel,
            this.gmet_Idtemplate_method,
            this.gmet_Cod_template_method,
            this.gmet_Title});
            this.gvMethods.GridControl = this.gcMethods;
            this.gvMethods.Name = "gvMethods";
            this.gvMethods.OptionsBehavior.Editable = false;
            this.gvMethods.OptionsView.ShowGroupPanel = false;
            // 
            // gmet_Sel
            // 
            this.gmet_Sel.Caption = "#";
            this.gmet_Sel.ColumnEdit = this.repSel;
            this.gmet_Sel.FieldName = "Sel";
            this.gmet_Sel.Name = "gmet_Sel";
            this.gmet_Sel.OptionsColumn.FixedWidth = true;
            this.gmet_Sel.Width = 53;
            // 
            // repSel
            // 
            this.repSel.AutoHeight = false;
            this.repSel.Name = "repSel";
            // 
            // gmet_Idtemplate_method
            // 
            this.gmet_Idtemplate_method.Caption = "Idtemplate_method";
            this.gmet_Idtemplate_method.FieldName = "Idtemplate_method";
            this.gmet_Idtemplate_method.Name = "gmet_Idtemplate_method";
            this.gmet_Idtemplate_method.Width = 86;
            // 
            // gmet_Cod_template_method
            // 
            this.gmet_Cod_template_method.Caption = "Código";
            this.gmet_Cod_template_method.FieldName = "Cod_template_method";
            this.gmet_Cod_template_method.Name = "gmet_Cod_template_method";
            this.gmet_Cod_template_method.OptionsColumn.AllowEdit = false;
            this.gmet_Cod_template_method.OptionsColumn.FixedWidth = true;
            this.gmet_Cod_template_method.Visible = true;
            this.gmet_Cod_template_method.VisibleIndex = 0;
            this.gmet_Cod_template_method.Width = 71;
            // 
            // gmet_Title
            // 
            this.gmet_Title.Caption = "Título";
            this.gmet_Title.FieldName = "Title";
            this.gmet_Title.Name = "gmet_Title";
            this.gmet_Title.Visible = true;
            this.gmet_Title.VisibleIndex = 1;
            this.gmet_Title.Width = 618;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(295, 2);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(8, 421);
            this.splitterControl1.TabIndex = 41;
            this.splitterControl1.TabStop = false;
            // 
            // customPageControl1
            // 
            this.customPageControl1.AppearancePage.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(222)))), ((int)(((byte)(243)))));
            this.customPageControl1.AppearancePage.Header.BorderColor = System.Drawing.Color.White;
            this.customPageControl1.AppearancePage.Header.Options.UseBackColor = true;
            this.customPageControl1.AppearancePage.Header.Options.UseBorderColor = true;
            this.customPageControl1.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.LightSteelBlue;
            this.customPageControl1.AppearancePage.HeaderActive.BorderColor = System.Drawing.Color.Gainsboro;
            this.customPageControl1.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.customPageControl1.AppearancePage.HeaderActive.Options.UseBorderColor = true;
            this.customPageControl1.AppearancePage.PageClient.BorderColor = System.Drawing.Color.Gainsboro;
            this.customPageControl1.AppearancePage.PageClient.Options.UseBorderColor = true;
            this.customPageControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPageControl1.Location = new System.Drawing.Point(303, 232);
            this.customPageControl1.Name = "customPageControl1";
            this.customPageControl1.PaintStyleName = "PropertyView";
            this.customPageControl1.SelectedTabPage = this.xtraTabPage1;
            this.customPageControl1.Size = new System.Drawing.Size(658, 191);
            this.customPageControl1.TabIndex = 42;
            this.customPageControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.customPageControl1.Text = "Calibraciones";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcMethods);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(656, 170);
            this.xtraTabPage1.Text = "Métodos";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.ucCalibStd1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(0, 0);
            this.xtraTabPage2.Text = "Estandares";
            // 
            // ucCalibStd1
            // 
            this.ucCalibStd1.Date_end = new System.DateTime(((long)(0)));
            this.ucCalibStd1.Date_init = new System.DateTime(((long)(0)));
            this.ucCalibStd1.Dock = System.Windows.Forms.DockStyle.Fill;
            cGroup_solution1.Cod_solution = null;
            cGroup_solution1.Date_end = null;
            cGroup_solution1.Date_ini = null;
            cGroup_solution1.Date_sign_calib = null;
            cGroup_solution1.Flag_close_calib = null;
            cGroup_solution1.Flag_selected_methods = null;
            cGroup_solution1.Flag_sign_calib = null;
            cGroup_solution1.Idelement = null;
            cGroup_solution1.Idgroup_solution = 0;
            cGroup_solution1.Idmr_detail = null;
            cGroup_solution1.Idreactive_medium = null;
            cGroup_solution1.Idreactive_modif = null;
            cGroup_solution1.Idtemplate_method = null;
            cGroup_solution1.Type_pattern = null;
            cGroup_solution1.Type_solution = null;
            cGroup_solution1.User_sign_calib = null;            
            this.ucCalibStd1.Location = new System.Drawing.Point(0, 0);
            this.ucCalibStd1.Name = "ucCalibStd1";
            this.ucCalibStd1.Size = new System.Drawing.Size(0, 0);
            this.ucCalibStd1.TabIndex = 0;
            // 
            // FormCalibs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 517);
            this.Name = "FormCalibs";
            this.Text = "Soluciones Intermedias";
            this.Load += new System.EventHandler(this.FormSolInterm_Load);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.paTitle, 0);
            this.Controls.SetChildIndex(this.paBottom, 0);
            this.Controls.SetChildIndex(this.paTop, 0);
            this.Controls.SetChildIndex(this.paCenter, 0);
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).EndInit();
            this.paTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStatusSolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paHeader)).EndInit();
            this.paHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSolutionChild)).EndInit();
            this.gcSolutionChild.ResumeLayout(false);
            this.gcSolutionChild.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbParentMediumValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbParentMedium.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbParentModifValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbParentModif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUser1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckAssignMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSolutionParent)).EndInit();
            this.gcSolutionParent.ResumeLayout(false);
            this.gcSolutionParent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbParentConcentration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbElement1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMethod1.Properties)).EndInit();
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeSolInterm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repReactive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repReactiveValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repAddMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBtOpenMethods)).EndInit();
            this.cmsAddSolution.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMethods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMethods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPageControl1)).EndInit();
            this.customPageControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl paHeader;
        private cbReactive cbParentModif;
        private cbReactive cbParentMedium;
        private cbMethod cbMethod1;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevExpress.XtraTreeList.TreeList treeSolInterm;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Cod_solution;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Nombre;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Concentration;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Aliquot;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Volumen;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repVolumen;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Idreactive_medium;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repReactive;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Reactive_medium_value;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repReactiveValue;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Idreactive_modif;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Reactive_modif_value;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Date_begin;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit redDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Date_end;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Solution_status;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repStatusSolution;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Prepared_by;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repUser;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Flag_current_method;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repBtOpenMethods;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Idsolution;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Type_sol;
        private System.Windows.Forms.ContextMenuStrip cmsAddSolution;
        private System.Windows.Forms.ToolStripMenuItem btNewSolInt1;
        private System.Windows.Forms.ToolStripMenuItem btNewSolInt2;
        private System.Windows.Forms.ToolStripMenuItem btNewSolStdVer;
        private System.Windows.Forms.ImageList imageList1;
        private cbElement cbElement1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repAddMethod;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_ShowMethods;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcMethods;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMethods;
        private DevExpress.XtraGrid.Columns.GridColumn gmet_Sel;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repSel;
        private DevExpress.XtraGrid.Columns.GridColumn gmet_Idtemplate_method;
        private DevExpress.XtraGrid.Columns.GridColumn gmet_Cod_template_method;
        private DevExpress.XtraGrid.Columns.GridColumn gmet_Title;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private System.Windows.Forms.Label label3;
        private customTextEdit tbParentConcentration;
        private customSpinEdit tbParentModifValue;
        private customSpinEdit tbParentMediumValue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.CheckEdit ckAssignMethod;
        private DevExpress.XtraEditors.GroupControl gcSolutionChild;
        private DevExpress.XtraEditors.GroupControl gcSolutionParent;
        private DevExpress.XtraEditors.PanelControl paSeparator;
        private customDateEdit deDateEnd;
        private customDateEdit deDateIni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private UserControls.cbUser cbUser1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Root_type_pattern;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Expired_status;
        private customPageControl customPageControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private UcCalibStd ucCalibStd1;

    }
}