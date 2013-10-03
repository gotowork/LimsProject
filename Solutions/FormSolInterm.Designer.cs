namespace LimsProject
{
    partial class FormSolInterm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSolInterm));
            LimsProject.BusinessLayer.CSolution_interm cSolution_interm1 = new LimsProject.BusinessLayer.CSolution_interm();
            this.tcol_Solution_status = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repStatusSolution = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.paHeader = new DevExpress.XtraEditors.PanelControl();
            this.paSolutionChild = new DevExpress.XtraEditors.GroupControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.paDate = new DevExpress.XtraEditors.PanelControl();
            this.ckAssignMethod = new DevExpress.XtraEditors.CheckEdit();
            this.laVigencia = new System.Windows.Forms.Label();
            this.deDateIni = new LimsProject.customDateEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUser1 = new UserControls.cbUser();
            this.label6 = new System.Windows.Forms.Label();
            this.deDateEnd = new LimsProject.customDateEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.paCalAliquot = new DevExpress.XtraEditors.PanelControl();
            this.tbAliquot = new LimsProject.customSpinEdit();
            this.tbConcentration = new LimsProject.customTextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVolumen = new LimsProject.customSpinEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbParentMediumValue = new LimsProject.customSpinEdit();
            this.cbParentMedium = new LimsProject.cbReactive();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbParentModifValue = new LimsProject.customSpinEdit();
            this.cbParentModif = new LimsProject.cbReactive();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.paCalibraciones = new DevExpress.XtraEditors.GroupControl();
            this.gcCalibracion = new DevExpress.XtraGrid.GridControl();
            this.gvCalibracion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCal_Order = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCal_Nom_Calib = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCal_Concentration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCal_Aliquot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCal_Volumen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.paSeparator = new DevExpress.XtraEditors.PanelControl();
            this.paSolutionParent = new DevExpress.XtraEditors.GroupControl();
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
            this.tcol_Solution_obs = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.cmsAddSolution = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btNewSolInt1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btNewSolInt2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btNewSolStdVer = new System.Windows.Forms.ToolStripMenuItem();
            this.btNewSolCalib = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.ucSign1 = new LimsProject.UcSign();
            this.gcMethods = new DevExpress.XtraGrid.GridControl();
            this.gvMethods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gmet_Idtemplate_method = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gmet_Cod_template_method = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gmet_Title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gmet_Unlink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSel = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.exPanel = new DevComponents.DotNetBar.ExpandablePanel();
            this.cbMotivo = new LimsProject.customComboBoxEdit();
            this.ckDisabledSolution = new DevExpress.XtraEditors.CheckEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.pcDetail = new LimsProject.customPageControl();
            this.tpMethod = new DevExpress.XtraTab.XtraTabPage();
            this.tpCalib = new DevExpress.XtraTab.XtraTabPage();
            this.ucCalibStd1 = new LimsProject.UcCalibStd();
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).BeginInit();
            this.paTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).BeginInit();
            this.paBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.paCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStatusSolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paHeader)).BeginInit();
            this.paHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paSolutionChild)).BeginInit();
            this.paSolutionChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paDate)).BeginInit();
            this.paDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckAssignMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUser1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paCalAliquot)).BeginInit();
            this.paCalAliquot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAliquot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConcentration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolumen.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbParentMediumValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbParentMedium.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbParentModifValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbParentModif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paCalibraciones)).BeginInit();
            this.paCalibraciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCalibracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCalibracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paSolutionParent)).BeginInit();
            this.paSolutionParent.SuspendLayout();
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
            this.exPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMotivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckDisabledSolution.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDetail)).BeginInit();
            this.pcDetail.SuspendLayout();
            this.tpMethod.SuspendLayout();
            this.tpCalib.SuspendLayout();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Size = new System.Drawing.Size(1125, 660);
            // 
            // paTitle
            // 
            this.paTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paTitle.Location = new System.Drawing.Point(0, 26);
            this.paTitle.Size = new System.Drawing.Size(1129, 664);
            this.paTitle.Visible = false;
            // 
            // paBottom
            // 
            this.paBottom.Controls.Add(this.ucSign1);
            this.paBottom.Location = new System.Drawing.Point(0, 644);
            this.paBottom.Size = new System.Drawing.Size(1129, 46);
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.pcDetail);
            this.paCenter.Controls.Add(this.exPanel);
            this.paCenter.Controls.Add(this.paHeader);
            this.paCenter.Controls.Add(this.splitterControl1);
            this.paCenter.Controls.Add(this.expandablePanel1);
            this.paCenter.Location = new System.Drawing.Point(0, 46);
            this.paCenter.Size = new System.Drawing.Size(1129, 598);
            // 
            // paTop
            // 
            this.paTop.Location = new System.Drawing.Point(0, 26);
            this.paTop.Padding = new System.Windows.Forms.Padding(10);
            this.paTop.Size = new System.Drawing.Size(1129, 20);
            this.paTop.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(1129, 26);
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
            this.paHeader.Controls.Add(this.paSolutionChild);
            this.paHeader.Controls.Add(this.panelControl3);
            this.paHeader.Controls.Add(this.paCalibraciones);
            this.paHeader.Controls.Add(this.paSeparator);
            this.paHeader.Controls.Add(this.paSolutionParent);
            this.paHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.paHeader.Location = new System.Drawing.Point(301, 2);
            this.paHeader.Name = "paHeader";
            this.paHeader.Padding = new System.Windows.Forms.Padding(10);
            this.paHeader.Size = new System.Drawing.Size(826, 251);
            this.paHeader.TabIndex = 37;
            this.paHeader.Text = "panelControl2";
            // 
            // paSolutionChild
            // 
            this.paSolutionChild.Controls.Add(this.panelControl4);
            this.paSolutionChild.Controls.Add(this.groupBox3);
            this.paSolutionChild.Controls.Add(this.groupBox2);
            this.paSolutionChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paSolutionChild.Location = new System.Drawing.Point(12, 77);
            this.paSolutionChild.Name = "paSolutionChild";
            this.paSolutionChild.Size = new System.Drawing.Size(478, 162);
            this.paSolutionChild.TabIndex = 39;
            this.paSolutionChild.Text = "Solución Hijo";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.paDate);
            this.panelControl4.Controls.Add(this.paCalAliquot);
            this.panelControl4.Location = new System.Drawing.Point(6, 66);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(474, 89);
            this.panelControl4.TabIndex = 37;
            this.panelControl4.Text = "panelControl4";
            // 
            // paDate
            // 
            this.paDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paDate.Controls.Add(this.ckAssignMethod);
            this.paDate.Controls.Add(this.laVigencia);
            this.paDate.Controls.Add(this.deDateIni);
            this.paDate.Controls.Add(this.label7);
            this.paDate.Controls.Add(this.cbUser1);
            this.paDate.Controls.Add(this.label6);
            this.paDate.Controls.Add(this.deDateEnd);
            this.paDate.Controls.Add(this.label8);
            this.paDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paDate.Location = new System.Drawing.Point(172, 2);
            this.paDate.Name = "paDate";
            this.paDate.Size = new System.Drawing.Size(300, 85);
            this.paDate.TabIndex = 39;
            this.paDate.Text = "panelControl5";
            // 
            // ckAssignMethod
            // 
            this.ckAssignMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ckAssignMethod.Location = new System.Drawing.Point(162, 58);
            this.ckAssignMethod.Margin = new System.Windows.Forms.Padding(0);
            this.ckAssignMethod.Name = "ckAssignMethod";
            this.ckAssignMethod.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ckAssignMethod.Properties.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            this.ckAssignMethod.Properties.Appearance.Options.UseFont = true;
            this.ckAssignMethod.Properties.Appearance.Options.UseForeColor = true;
            this.ckAssignMethod.Properties.Caption = "Asignar al método";
            this.ckAssignMethod.Size = new System.Drawing.Size(135, 19);
            this.ckAssignMethod.TabIndex = 4;
            // 
            // laVigencia
            // 
            this.laVigencia.AutoSize = true;
            this.laVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laVigencia.ForeColor = System.Drawing.Color.Red;
            this.laVigencia.Location = new System.Drawing.Point(165, 24);
            this.laVigencia.Name = "laVigencia";
            this.laVigencia.Size = new System.Drawing.Size(70, 13);
            this.laVigencia.TabIndex = 34;
            this.laVigencia.Text = "EXPIRADO";
            this.laVigencia.Visible = false;
            // 
            // deDateIni
            // 
            this.deDateIni.EditValue = null;
            this.deDateIni.Location = new System.Drawing.Point(75, 10);
            this.deDateIni.Name = "deDateIni";
            this.deDateIni.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateIni.Size = new System.Drawing.Size(86, 20);
            this.deDateIni.TabIndex = 22;
            this.deDateIni.EditValueChanged += new System.EventHandler(this.deDateIni_EditValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Fecha Fin:";
            // 
            // cbUser1
            // 
            this.cbUser1.Location = new System.Drawing.Point(75, 54);
            this.cbUser1.Name = "cbUser1";
            this.cbUser1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.cbUser1.Properties.NullText = "";
            this.cbUser1.Properties.ReadOnly = true;
            this.cbUser1.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.cbUser1.Size = new System.Drawing.Size(86, 20);
            this.cbUser1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Fecha Inicio:";
            // 
            // deDateEnd
            // 
            this.deDateEnd.EditValue = null;
            this.deDateEnd.Location = new System.Drawing.Point(75, 32);
            this.deDateEnd.Name = "deDateEnd";
            this.deDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateEnd.Size = new System.Drawing.Size(86, 20);
            this.deDateEnd.TabIndex = 22;
            this.deDateEnd.EditValueChanged += new System.EventHandler(this.deDateEnd_EditValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Usuario:";
            // 
            // paCalAliquot
            // 
            this.paCalAliquot.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paCalAliquot.Controls.Add(this.tbAliquot);
            this.paCalAliquot.Controls.Add(this.tbConcentration);
            this.paCalAliquot.Controls.Add(this.label1);
            this.paCalAliquot.Controls.Add(this.label2);
            this.paCalAliquot.Controls.Add(this.tbVolumen);
            this.paCalAliquot.Controls.Add(this.label5);
            this.paCalAliquot.Dock = System.Windows.Forms.DockStyle.Left;
            this.paCalAliquot.Location = new System.Drawing.Point(2, 2);
            this.paCalAliquot.Name = "paCalAliquot";
            this.paCalAliquot.Size = new System.Drawing.Size(170, 85);
            this.paCalAliquot.TabIndex = 38;
            this.paCalAliquot.Text = "panelControl5";
            // 
            // tbAliquot
            // 
            this.tbAliquot.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbAliquot.Location = new System.Drawing.Point(88, 53);
            this.tbAliquot.Name = "tbAliquot";
            this.tbAliquot.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.tbAliquot.Properties.ReadOnly = true;
            this.tbAliquot.Size = new System.Drawing.Size(76, 20);
            this.tbAliquot.TabIndex = 3;
            this.tbAliquot.TabStop = false;
            // 
            // tbConcentration
            // 
            this.tbConcentration.Location = new System.Drawing.Point(88, 9);
            this.tbConcentration.Name = "tbConcentration";
            this.tbConcentration.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tbConcentration.Properties.Appearance.Options.UseBackColor = true;
            this.tbConcentration.Properties.ReadOnly = true;
            this.tbConcentration.Size = new System.Drawing.Size(76, 20);
            this.tbConcentration.TabIndex = 1;
            this.tbConcentration.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Concentración:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Volumen:";
            // 
            // tbVolumen
            // 
            this.tbVolumen.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbVolumen.Location = new System.Drawing.Point(88, 31);
            this.tbVolumen.Name = "tbVolumen";
            this.tbVolumen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbVolumen.Size = new System.Drawing.Size(76, 20);
            this.tbVolumen.TabIndex = 2;
            this.tbVolumen.EditValueChanged += new System.EventHandler(this.tbVolumen_EditValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Alicuota:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbParentMediumValue);
            this.groupBox3.Controls.Add(this.cbParentMedium);
            this.groupBox3.Location = new System.Drawing.Point(6, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 42);
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
            this.tbParentMediumValue.Location = new System.Drawing.Point(109, 14);
            this.tbParentMediumValue.Name = "tbParentMediumValue";
            this.tbParentMediumValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.tbParentMediumValue.Properties.ReadOnly = true;
            this.tbParentMediumValue.Size = new System.Drawing.Size(55, 20);
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
            this.cbParentMedium.Size = new System.Drawing.Size(102, 20);
            this.cbParentMedium.TabIndex = 31;
            this.cbParentMedium.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbParentModifValue);
            this.groupBox2.Controls.Add(this.cbParentModif);
            this.groupBox2.Location = new System.Drawing.Point(182, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 42);
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
            this.tbParentModifValue.Location = new System.Drawing.Point(108, 14);
            this.tbParentModifValue.Name = "tbParentModifValue";
            this.tbParentModifValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.tbParentModifValue.Properties.ReadOnly = true;
            this.tbParentModifValue.Size = new System.Drawing.Size(55, 20);
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
            this.cbParentModif.Size = new System.Drawing.Size(100, 20);
            this.cbParentModif.TabIndex = 32;
            this.cbParentModif.TabStop = false;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(490, 77);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(11, 162);
            this.panelControl3.TabIndex = 46;
            this.panelControl3.Text = "panelControl3";
            // 
            // paCalibraciones
            // 
            this.paCalibraciones.Controls.Add(this.gcCalibracion);
            this.paCalibraciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.paCalibraciones.Location = new System.Drawing.Point(501, 77);
            this.paCalibraciones.Name = "paCalibraciones";
            this.paCalibraciones.Size = new System.Drawing.Size(313, 162);
            this.paCalibraciones.TabIndex = 48;
            this.paCalibraciones.Text = "Calibraciones";
            // 
            // gcCalibracion
            // 
            this.gcCalibracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCalibracion.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gcCalibracion.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gcCalibracion.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gcCalibracion.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gcCalibracion.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gcCalibracion.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gcCalibracion.EmbeddedNavigator.Name = "";
            this.gcCalibracion.Location = new System.Drawing.Point(2, 20);
            this.gcCalibracion.MainView = this.gvCalibracion;
            this.gcCalibracion.Name = "gcCalibracion";
            this.gcCalibracion.Size = new System.Drawing.Size(309, 140);
            this.gcCalibracion.TabIndex = 47;
            this.gcCalibracion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCalibracion});
            // 
            // gvCalibracion
            // 
            this.gvCalibracion.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCalibracion.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCalibracion.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCalibracion.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvCalibracion.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCalibracion.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvCalibracion.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvCalibracion.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvCalibracion.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvCalibracion.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvCalibracion.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvCalibracion.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCalibracion.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvCalibracion.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvCalibracion.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvCalibracion.Appearance.Empty.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvCalibracion.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvCalibracion.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvCalibracion.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCalibracion.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCalibracion.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCalibracion.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvCalibracion.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCalibracion.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvCalibracion.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvCalibracion.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvCalibracion.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvCalibracion.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvCalibracion.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvCalibracion.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvCalibracion.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvCalibracion.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvCalibracion.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvCalibracion.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvCalibracion.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvCalibracion.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCalibracion.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCalibracion.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCalibracion.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCalibracion.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCalibracion.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvCalibracion.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvCalibracion.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCalibracion.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCalibracion.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvCalibracion.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvCalibracion.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvCalibracion.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCalibracion.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCalibracion.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvCalibracion.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvCalibracion.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvCalibracion.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvCalibracion.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCalibracion.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvCalibracion.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCalibracion.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCalibracion.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvCalibracion.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvCalibracion.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvCalibracion.Appearance.GroupRow.Options.UseFont = true;
            this.gvCalibracion.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvCalibracion.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCalibracion.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCalibracion.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCalibracion.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCalibracion.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCalibracion.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvCalibracion.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvCalibracion.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvCalibracion.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvCalibracion.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvCalibracion.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvCalibracion.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvCalibracion.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvCalibracion.Appearance.OddRow.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.OddRow.Options.UseForeColor = true;
            this.gvCalibracion.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvCalibracion.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvCalibracion.Appearance.Preview.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.Preview.Options.UseForeColor = true;
            this.gvCalibracion.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvCalibracion.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvCalibracion.Appearance.Row.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.Row.Options.UseForeColor = true;
            this.gvCalibracion.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvCalibracion.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvCalibracion.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvCalibracion.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvCalibracion.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvCalibracion.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvCalibracion.Appearance.VertLine.Options.UseBackColor = true;
            this.gvCalibracion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcCal_Order,
            this.gcCal_Nom_Calib,
            this.gcCal_Concentration,
            this.gcCal_Aliquot,
            this.gcCal_Volumen});
            this.gvCalibracion.GridControl = this.gcCalibracion;
            this.gvCalibracion.Name = "gvCalibracion";
            this.gvCalibracion.OptionsBehavior.Editable = false;
            this.gvCalibracion.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCalibracion.OptionsView.EnableAppearanceOddRow = true;
            this.gvCalibracion.OptionsView.ShowGroupPanel = false;
            // 
            // gcCal_Order
            // 
            this.gcCal_Order.Caption = "N°";
            this.gcCal_Order.FieldName = "Order_calib";
            this.gcCal_Order.Name = "gcCal_Order";
            this.gcCal_Order.OptionsFilter.AllowFilter = false;
            this.gcCal_Order.Visible = true;
            this.gcCal_Order.VisibleIndex = 0;
            this.gcCal_Order.Width = 58;
            // 
            // gcCal_Nom_Calib
            // 
            this.gcCal_Nom_Calib.Caption = "Nombre";
            this.gcCal_Nom_Calib.FieldName = "Name_calib";
            this.gcCal_Nom_Calib.Name = "gcCal_Nom_Calib";
            this.gcCal_Nom_Calib.OptionsFilter.AllowFilter = false;
            this.gcCal_Nom_Calib.Visible = true;
            this.gcCal_Nom_Calib.VisibleIndex = 1;
            this.gcCal_Nom_Calib.Width = 108;
            // 
            // gcCal_Concentration
            // 
            this.gcCal_Concentration.Caption = "Concentración";
            this.gcCal_Concentration.FieldName = "Concentration";
            this.gcCal_Concentration.Name = "gcCal_Concentration";
            this.gcCal_Concentration.OptionsFilter.AllowFilter = false;
            this.gcCal_Concentration.Visible = true;
            this.gcCal_Concentration.VisibleIndex = 2;
            this.gcCal_Concentration.Width = 110;
            // 
            // gcCal_Aliquot
            // 
            this.gcCal_Aliquot.Caption = "Alicuota(g ml)";
            this.gcCal_Aliquot.FieldName = "Aliquot";
            this.gcCal_Aliquot.Name = "gcCal_Aliquot";
            this.gcCal_Aliquot.OptionsFilter.AllowFilter = false;
            this.gcCal_Aliquot.Visible = true;
            this.gcCal_Aliquot.VisibleIndex = 3;
            this.gcCal_Aliquot.Width = 98;
            // 
            // gcCal_Volumen
            // 
            this.gcCal_Volumen.Caption = "Volumen (ml)";
            this.gcCal_Volumen.FieldName = "Volumen";
            this.gcCal_Volumen.Name = "gcCal_Volumen";
            this.gcCal_Volumen.OptionsFilter.AllowFilter = false;
            this.gcCal_Volumen.Visible = true;
            this.gcCal_Volumen.VisibleIndex = 4;
            this.gcCal_Volumen.Width = 106;
            // 
            // paSeparator
            // 
            this.paSeparator.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.paSeparator.Location = new System.Drawing.Point(12, 67);
            this.paSeparator.Name = "paSeparator";
            this.paSeparator.Size = new System.Drawing.Size(802, 10);
            this.paSeparator.TabIndex = 40;
            this.paSeparator.Text = "panelControl4";
            // 
            // paSolutionParent
            // 
            this.paSolutionParent.Controls.Add(this.label3);
            this.paSolutionParent.Controls.Add(this.tbParentConcentration);
            this.paSolutionParent.Dock = System.Windows.Forms.DockStyle.Top;
            this.paSolutionParent.Location = new System.Drawing.Point(12, 12);
            this.paSolutionParent.Name = "paSolutionParent";
            this.paSolutionParent.Size = new System.Drawing.Size(802, 55);
            this.paSolutionParent.TabIndex = 39;
            this.paSolutionParent.Text = "Solucion Padre";
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
            this.expandablePanel1.Size = new System.Drawing.Size(293, 594);
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
            this.tcol_Expired_status,
            this.tcol_Solution_obs});
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
            this.treeSolInterm.Size = new System.Drawing.Size(293, 513);
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
            // tcol_Solution_obs
            // 
            this.tcol_Solution_obs.Caption = "Solution_obs";
            this.tcol_Solution_obs.FieldName = "Solution_obs";
            this.tcol_Solution_obs.Name = "tcol_Solution_obs";
            // 
            // cmsAddSolution
            // 
            this.cmsAddSolution.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNewSolInt1,
            this.btNewSolInt2,
            this.btNewSolStdVer,
            this.btNewSolCalib});
            this.cmsAddSolution.Name = "cmsAddSolution";
            this.cmsAddSolution.Size = new System.Drawing.Size(239, 114);
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
            // btNewSolCalib
            // 
            this.btNewSolCalib.Name = "btNewSolCalib";
            this.btNewSolCalib.Size = new System.Drawing.Size(238, 22);
            this.btNewSolCalib.Text = "Nuevo Estandar de Calibración";
            this.btNewSolCalib.Click += new System.EventHandler(this.btNewSolCalib_Click);
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
            // ucSign1
            // 
            this.ucSign1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSign1.Location = new System.Drawing.Point(966, 4);
            this.ucSign1.Margin = new System.Windows.Forms.Padding(0);
            this.ucSign1.Name = "ucSign1";
            this.ucSign1.Pwd = null;
            this.ucSign1.Size = new System.Drawing.Size(158, 40);
            this.ucSign1.TabIndex = 7;
            this.ucSign1.Title = "";
            this.ucSign1.OnSign += new LimsProject.sign(this.ucSign1_OnSign);
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
            this.gcMethods.Size = new System.Drawing.Size(824, 296);
            this.gcMethods.TabIndex = 40;
            this.gcMethods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMethods});
            // 
            // gvMethods
            // 
            this.gvMethods.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gmet_Idtemplate_method,
            this.gmet_Cod_template_method,
            this.gmet_Title,
            this.gmet_Unlink});
            this.gvMethods.GridControl = this.gcMethods;
            this.gvMethods.Name = "gvMethods";
            this.gvMethods.OptionsView.ShowGroupPanel = false;
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
            this.gmet_Title.OptionsColumn.AllowEdit = false;
            this.gmet_Title.Visible = true;
            this.gmet_Title.VisibleIndex = 1;
            this.gmet_Title.Width = 618;
            // 
            // gmet_Unlink
            // 
            this.gmet_Unlink.Caption = "Desvincular";
            this.gmet_Unlink.ColumnEdit = this.repSel;
            this.gmet_Unlink.FieldName = "Unlink";
            this.gmet_Unlink.Name = "gmet_Unlink";
            // 
            // repSel
            // 
            this.repSel.AutoHeight = false;
            this.repSel.Name = "repSel";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(295, 2);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 594);
            this.splitterControl1.TabIndex = 41;
            this.splitterControl1.TabStop = false;
            // 
            // exPanel
            // 
            this.exPanel.Controls.Add(this.cbMotivo);
            this.exPanel.Controls.Add(this.ckDisabledSolution);
            this.exPanel.Controls.Add(this.label4);
            this.exPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exPanel.Expanded = false;
            this.exPanel.ExpandedBounds = new System.Drawing.Rectangle(301, 542, 826, 54);
            this.exPanel.Location = new System.Drawing.Point(301, 570);
            this.exPanel.Name = "exPanel";
            this.exPanel.Size = new System.Drawing.Size(826, 26);
            this.exPanel.TabIndex = 37;
            this.exPanel.Text = "expandablePanel2";
            this.exPanel.TitleStyle.BackColor1.Color = System.Drawing.Color.LightSteelBlue;
            this.exPanel.TitleStyle.ForeColor.Color = System.Drawing.Color.Blue;
            this.exPanel.TitleText = "Desactivar";
            // 
            // cbMotivo
            // 
            this.cbMotivo.EditValue = "";
            this.cbMotivo.Location = new System.Drawing.Point(509, 29);
            this.cbMotivo.Name = "cbMotivo";
            this.cbMotivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMotivo.Properties.Items.AddRange(new object[] {
            "",
            "Perdida"});
            this.cbMotivo.Size = new System.Drawing.Size(97, 20);
            this.cbMotivo.TabIndex = 22;
            // 
            // ckDisabledSolution
            // 
            this.ckDisabledSolution.Location = new System.Drawing.Point(13, 29);
            this.ckDisabledSolution.Name = "ckDisabledSolution";
            this.ckDisabledSolution.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.ckDisabledSolution.Properties.Appearance.Options.UseForeColor = true;
            this.ckDisabledSolution.Properties.Caption = "Desactivando la solución, no podrá ser usada en ningún módulo que haga referencia" +
    "";
            this.ckDisabledSolution.Size = new System.Drawing.Size(442, 19);
            this.ckDisabledSolution.TabIndex = 1;
            this.ckDisabledSolution.CheckedChanged += new System.EventHandler(this.ckDisabledSolution_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Motivo:";
            // 
            // pcDetail
            // 
            this.pcDetail.AppearancePage.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(222)))), ((int)(((byte)(243)))));
            this.pcDetail.AppearancePage.Header.BorderColor = System.Drawing.Color.White;
            this.pcDetail.AppearancePage.Header.Options.UseBackColor = true;
            this.pcDetail.AppearancePage.Header.Options.UseBorderColor = true;
            this.pcDetail.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pcDetail.AppearancePage.HeaderActive.BorderColor = System.Drawing.Color.Gainsboro;
            this.pcDetail.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.pcDetail.AppearancePage.HeaderActive.Options.UseBorderColor = true;
            this.pcDetail.AppearancePage.PageClient.BorderColor = System.Drawing.Color.Gainsboro;
            this.pcDetail.AppearancePage.PageClient.Options.UseBorderColor = true;
            this.pcDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcDetail.Location = new System.Drawing.Point(301, 253);
            this.pcDetail.Name = "pcDetail";
            this.pcDetail.PaintStyleName = "PropertyView";
            this.pcDetail.SelectedTabPage = this.tpMethod;
            this.pcDetail.Size = new System.Drawing.Size(826, 317);
            this.pcDetail.TabIndex = 42;
            this.pcDetail.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpMethod,
            this.tpCalib});
            this.pcDetail.Text = "customPageControl1";
            // 
            // tpMethod
            // 
            this.tpMethod.Controls.Add(this.gcMethods);
            this.tpMethod.Name = "tpMethod";
            this.tpMethod.Size = new System.Drawing.Size(824, 296);
            this.tpMethod.Text = "Método";
            // 
            // tpCalib
            // 
            this.tpCalib.Controls.Add(this.ucCalibStd1);
            this.tpCalib.Name = "tpCalib";
            this.tpCalib.Size = new System.Drawing.Size(0, 0);
            this.tpCalib.Text = "Calibración";
            // 
            // ucCalibStd1
            // 
            this.ucCalibStd1.Date_end = new System.DateTime(((long)(0)));
            this.ucCalibStd1.Date_init = new System.DateTime(((long)(0)));
            this.ucCalibStd1.DateSign = new System.DateTime(((long)(0)));
            this.ucCalibStd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCalibStd1.Idtemplate_method = 0;
            this.ucCalibStd1.Location = new System.Drawing.Point(0, 0);
            this.ucCalibStd1.Name = "ucCalibStd1";
            this.ucCalibStd1.Size = new System.Drawing.Size(0, 0);
            cSolution_interm1.Aliquot = null;
            cSolution_interm1.Cod_solution = null;
            cSolution_interm1.Concentration = null;
            cSolution_interm1.Date_begin = null;
            cSolution_interm1.Date_end = null;
            cSolution_interm1.Dateedit = null;
            cSolution_interm1.Datenew = null;
            cSolution_interm1.Expired_status = null;
            cSolution_interm1.Flag_current_method = null;
            cSolution_interm1.Id = null;
            cSolution_interm1.Idelement = null;
            cSolution_interm1.Idreactive_medium = null;
            cSolution_interm1.Idreactive_modif = null;
            cSolution_interm1.Idsolution_interm = 0;
            cSolution_interm1.Image_index = null;
            cSolution_interm1.Lote = null;
            cSolution_interm1.Num_months = null;
            cSolution_interm1.Observation = null;
            cSolution_interm1.Parentid = null;
            cSolution_interm1.Prepared_by = null;
            cSolution_interm1.Purity = null;
            cSolution_interm1.Reactive_medium_value = null;
            cSolution_interm1.Reactive_modif_value = null;
            cSolution_interm1.Root_idmr_detail = null;
            cSolution_interm1.Root_type_pattern = null;
            cSolution_interm1.Solution_name = null;
            cSolution_interm1.Solution_obs = null;
            cSolution_interm1.Solution_status = null;
            cSolution_interm1.Status = null;
            cSolution_interm1.Type_sol = null;
            cSolution_interm1.Useredit = null;
            cSolution_interm1.Usernew = null;
            cSolution_interm1.Volumen = null;
            this.ucCalibStd1.Solution_interm = cSolution_interm1;
            this.ucCalibStd1.TabIndex = 0;
            this.ucCalibStd1.UserSign = null;
            // 
            // FormSolInterm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 690);
            this.Name = "FormSolInterm";
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
            this.paBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStatusSolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paHeader)).EndInit();
            this.paHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paSolutionChild)).EndInit();
            this.paSolutionChild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paDate)).EndInit();
            this.paDate.ResumeLayout(false);
            this.paDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckAssignMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUser1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paCalAliquot)).EndInit();
            this.paCalAliquot.ResumeLayout(false);
            this.paCalAliquot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAliquot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConcentration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolumen.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbParentMediumValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbParentMedium.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbParentModifValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbParentModif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paCalibraciones)).EndInit();
            this.paCalibraciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCalibracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCalibracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paSolutionParent)).EndInit();
            this.paSolutionParent.ResumeLayout(false);
            this.paSolutionParent.PerformLayout();
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
            this.exPanel.ResumeLayout(false);
            this.exPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMotivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckDisabledSolution.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDetail)).EndInit();
            this.pcDetail.ResumeLayout(false);
            this.tpMethod.ResumeLayout(false);
            this.tpCalib.ResumeLayout(false);
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
        private UcSign ucSign1;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repSel;
        private DevExpress.XtraGrid.Columns.GridColumn gmet_Idtemplate_method;
        private DevExpress.XtraGrid.Columns.GridColumn gmet_Cod_template_method;
        private DevExpress.XtraGrid.Columns.GridColumn gmet_Title;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private customSpinEdit tbVolumen;
        private customTextEdit tbConcentration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private customTextEdit tbParentConcentration;
        private customSpinEdit tbParentModifValue;
        private customSpinEdit tbParentMediumValue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.CheckEdit ckAssignMethod;
        private customSpinEdit tbAliquot;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.GroupControl paSolutionChild;
        private DevExpress.XtraEditors.GroupControl paSolutionParent;
        private DevExpress.XtraEditors.PanelControl paSeparator;
        private customDateEdit deDateEnd;
        private customDateEdit deDateIni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private UserControls.cbUser cbUser1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Root_type_pattern;
        private DevComponents.DotNetBar.ExpandablePanel exPanel;
        private DevExpress.XtraEditors.CheckEdit ckDisabledSolution;
        private System.Windows.Forms.Label laVigencia;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Expired_status;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gcCalibracion;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCalibracion;
        private DevExpress.XtraGrid.Columns.GridColumn gcCal_Order;
        private DevExpress.XtraGrid.Columns.GridColumn gcCal_Nom_Calib;
        private DevExpress.XtraGrid.Columns.GridColumn gcCal_Concentration;
        private DevExpress.XtraGrid.Columns.GridColumn gcCal_Aliquot;
        private DevExpress.XtraGrid.Columns.GridColumn gcCal_Volumen;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl paDate;
        private DevExpress.XtraEditors.PanelControl paCalAliquot;
        private customPageControl pcDetail;
        private DevExpress.XtraTab.XtraTabPage tpMethod;
        private DevExpress.XtraTab.XtraTabPage tpCalib;
        
        private System.Windows.Forms.ToolStripMenuItem btNewSolCalib;
        private UcCalibStd ucCalibStd1;
        private DevExpress.XtraEditors.GroupControl paCalibraciones;
        private DevExpress.XtraGrid.Columns.GridColumn gmet_Unlink;
        private System.Windows.Forms.Label label4;
        private customComboBoxEdit cbMotivo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tcol_Solution_obs;        

    }
}