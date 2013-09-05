namespace LimsProject
{
    partial class FormSolutions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSolutions));
            LimsProject.BusinessLayer.CGroup_solution cGroup_solution1 = new LimsProject.BusinessLayer.CGroup_solution();
            this.treeSolution = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.tabMain = new DevExpress.XtraTab.XtraTabControl();
            this.tabSupCalib = new DevExpress.XtraTab.XtraTabPage();
            this.tabProcessCalib = new DevExpress.XtraTab.XtraTabControl();
            this.tabModCalib = new DevExpress.XtraTab.XtraTabPage();
            this.ucCalibStd1 = new LimsProject.UcCalibStd();
            this.tabMethodCalib = new DevExpress.XtraTab.XtraTabPage();
            this.ucMethodCalib = new LimsProject.UcSelectMethods();
            this.tabSupTitration = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.ucTitration1 = new LimsProject.UcTitration();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.ucMethodTitration = new LimsProject.UcSelectMethods();
            this.tabSupSolInterm = new DevExpress.XtraTab.XtraTabPage();
            this.ucSolInterm1 = new LimsProject.UcSolInterm();
            this.gpTitle = new DevExpress.XtraEditors.GroupControl();
            this.cbMethod = new DevExpress.XtraEditors.LookUpEdit();
            this.cbElement = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.treeListColumn16 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn17 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).BeginInit();
            this.paTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.paCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeSolution)).BeginInit();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabSupCalib.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabProcessCalib)).BeginInit();
            this.tabProcessCalib.SuspendLayout();
            this.tabModCalib.SuspendLayout();
            this.tabMethodCalib.SuspendLayout();
            this.tabSupTitration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
            this.tabSupSolInterm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpTitle)).BeginInit();
            this.gpTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbElement.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitle.Size = new System.Drawing.Size(1050, 39);
            this.laTitle.Text = "Preparación de Soluciones";
            // 
            // paTitle
            // 
            this.paTitle.Size = new System.Drawing.Size(1054, 43);
            // 
            // paBottom
            // 
            this.paBottom.Location = new System.Drawing.Point(0, 556);
            this.paBottom.Size = new System.Drawing.Size(1054, 46);
            this.paBottom.Visible = false;
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.panel1);
            this.paCenter.Controls.Add(this.expandablePanel1);
            this.paCenter.Location = new System.Drawing.Point(0, 71);
            this.paCenter.Size = new System.Drawing.Size(1054, 485);
            // 
            // paTop
            // 
            this.paTop.Size = new System.Drawing.Size(1054, 28);
            this.paTop.Visible = false;
            // 
            // treeSolution
            // 
            this.treeSolution.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4});
            this.treeSolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeSolution.Location = new System.Drawing.Point(0, 26);
            this.treeSolution.Name = "treeSolution";
            this.treeSolution.BeginUnboundLoad();
            this.treeSolution.AppendNode(new object[] {
            "Estandar de Calibración",
            null,
            null,
            null}, -1);
            this.treeSolution.AppendNode(new object[] {
            "Solución Intermedia 1",
            null,
            null,
            null}, -1);
            this.treeSolution.AppendNode(new object[] {
            "Solución Intermedia 2",
            null,
            null,
            null}, -1);
            this.treeSolution.AppendNode(new object[] {
            "Estandar de Verificación",
            null,
            null,
            null}, -1);
            this.treeSolution.AppendNode(new object[] {
            "Solución Titulante",
            null,
            null,
            null}, -1);
            this.treeSolution.EndUnboundLoad();
            this.treeSolution.OptionsBehavior.KeepSelectedOnClick = false;
            this.treeSolution.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeSolution.OptionsView.ShowFocusedFrame = false;
            this.treeSolution.OptionsView.ShowHorzLines = false;
            this.treeSolution.OptionsView.ShowIndicator = false;
            this.treeSolution.SelectImageList = this.imageList1;
            this.treeSolution.Size = new System.Drawing.Size(166, 455);
            this.treeSolution.TabIndex = 0;
            this.treeSolution.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeSolution_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Nombre";
            this.treeListColumn1.FieldName = "Nombre";
            this.treeListColumn1.MinWidth = 46;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 106;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Idgroup_solution";
            this.treeListColumn2.FieldName = "Idgroup_solution";
            this.treeListColumn2.Name = "treeListColumn2";
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Idmr_detail";
            this.treeListColumn3.FieldName = "Idmr_detail";
            this.treeListColumn3.Name = "treeListColumn3";
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Idsolution_pattern";
            this.treeListColumn4.FieldName = "Idsolution_pattern";
            this.treeListColumn4.Name = "treeListColumn4";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "fiola_group.png");
            this.imageList1.Images.SetKeyName(1, "fiola.png");
            this.imageList1.Images.SetKeyName(2, "fiola_ver.png");
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.LeftToRight;
            this.expandablePanel1.Controls.Add(this.treeSolution);
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.expandablePanel1.Location = new System.Drawing.Point(2, 2);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(166, 481);
            this.expandablePanel1.TabIndex = 1;
            this.expandablePanel1.Text = "expandablePanel1";
            this.expandablePanel1.TitleText = "Title Bar";
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 75);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedTabPage = this.tabSupCalib;
            this.tabMain.Size = new System.Drawing.Size(884, 406);
            this.tabMain.TabIndex = 0;
            this.tabMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabSupCalib,
            this.tabSupTitration,
            this.tabSupSolInterm});
            this.tabMain.Text = "Metodos";
            this.tabMain.Visible = false;
            // 
            // tabSupCalib
            // 
            this.tabSupCalib.Controls.Add(this.tabProcessCalib);
            this.tabSupCalib.Name = "tabSupCalib";
            this.tabSupCalib.Size = new System.Drawing.Size(875, 376);
            this.tabSupCalib.Text = "Calibraciones";
            // 
            // tabProcessCalib
            // 
            this.tabProcessCalib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProcessCalib.Location = new System.Drawing.Point(0, 0);
            this.tabProcessCalib.Name = "tabProcessCalib";
            this.tabProcessCalib.SelectedTabPage = this.tabModCalib;
            this.tabProcessCalib.Size = new System.Drawing.Size(875, 376);
            this.tabProcessCalib.TabIndex = 1;
            this.tabProcessCalib.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabMethodCalib,
            this.tabModCalib});
            this.tabProcessCalib.Text = "Métodos agrupables";
            // 
            // tabModCalib
            // 
            this.tabModCalib.Controls.Add(this.ucCalibStd1);
            this.tabModCalib.Name = "tabModCalib";
            this.tabModCalib.Size = new System.Drawing.Size(866, 346);
            this.tabModCalib.Text = "Calibraciones";
            // 
            // ucCalibStd1
            // 
            this.ucCalibStd1.Date_end = new System.DateTime(((long)(0)));
            this.ucCalibStd1.Date_init = new System.DateTime(((long)(0)));
            this.ucCalibStd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCalibStd1.Enabled = false;
            cGroup_solution1.Cod_solution = null;
            cGroup_solution1.Date_end = null;
            cGroup_solution1.Date_ini = null;
            cGroup_solution1.Date_sign_calib = null;
            cGroup_solution1.Flag_close_calib = null;
            cGroup_solution1.Flag_selected_methods = null;
            cGroup_solution1.Flag_sign_calib = null;
            cGroup_solution1.Flag_sol_intermedia1 = null;
            cGroup_solution1.Flag_sol_intermedia2 = null;
            cGroup_solution1.Idelement = null;
            cGroup_solution1.Idgroup_solution = 0;
            cGroup_solution1.Idgroup_solution_previus = null;
            cGroup_solution1.Idmr_detail = null;
            cGroup_solution1.Idreactive_medium = null;
            cGroup_solution1.Idreactive_modif = null;
            cGroup_solution1.Idtemplate_method = null;
            cGroup_solution1.Type_pattern = null;
            cGroup_solution1.Type_solution = null;
            cGroup_solution1.User_sign_calib = null;
            this.ucCalibStd1.Group_solution = cGroup_solution1;
            this.ucCalibStd1.Location = new System.Drawing.Point(0, 0);
            this.ucCalibStd1.Name = "ucCalibStd1";
            this.ucCalibStd1.Size = new System.Drawing.Size(866, 346);
            this.ucCalibStd1.TabIndex = 0;
            this.ucCalibStd1.onSignCalibs += new LimsProject.signCalibs(this.ucCalibStd1_onSignCalibs);
            this.ucCalibStd1.onNewCalib += new LimsProject.newCalib(this.ucCalibStd1_onNewCalib);
            // 
            // tabMethodCalib
            // 
            this.tabMethodCalib.Controls.Add(this.ucMethodCalib);
            this.tabMethodCalib.Name = "tabMethodCalib";
            this.tabMethodCalib.Size = new System.Drawing.Size(96, 6);
            this.tabMethodCalib.Text = "Métodos Agrupables";
            // 
            // ucMethodCalib
            // 
            this.ucMethodCalib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMethodCalib.Location = new System.Drawing.Point(0, 0);
            this.ucMethodCalib.Name = "ucMethodCalib";
            this.ucMethodCalib.Size = new System.Drawing.Size(96, 6);
            this.ucMethodCalib.TabIndex = 0;
            this.ucMethodCalib.onConfirmSelection += new LimsProject.ConfirmSelection(this.ucMethodCalib_onConfirmSelection);
            // 
            // tabSupTitration
            // 
            this.tabSupTitration.Controls.Add(this.xtraTabControl2);
            this.tabSupTitration.Name = "tabSupTitration";
            this.tabSupTitration.Size = new System.Drawing.Size(105, 36);
            this.tabSupTitration.Text = "Titulación de Soluciones";
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl2.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage4;
            this.xtraTabControl2.Size = new System.Drawing.Size(105, 36);
            this.xtraTabControl2.TabIndex = 2;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage5,
            this.xtraTabPage4});
            this.xtraTabControl2.Text = "Métodos agrupables";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.ucTitration1);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.PageEnabled = false;
            this.xtraTabPage4.Size = new System.Drawing.Size(96, 6);
            this.xtraTabPage4.Text = "Titulacion";
            // 
            // ucTitration1
            // 
            this.ucTitration1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTitration1.Iduser = 0;
            this.ucTitration1.Location = new System.Drawing.Point(0, 0);
            this.ucTitration1.Name = "ucTitration1";
            this.ucTitration1.Size = new System.Drawing.Size(96, 6);
            this.ucTitration1.Solution = null;
            this.ucTitration1.TabIndex = 0;
            this.ucTitration1.Titration_main = null;
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.ucMethodTitration);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(96, 6);
            this.xtraTabPage5.Text = "Métodos Agrupables";
            // 
            // ucMethodTitration
            // 
            this.ucMethodTitration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMethodTitration.Location = new System.Drawing.Point(0, 0);
            this.ucMethodTitration.Name = "ucMethodTitration";
            this.ucMethodTitration.Size = new System.Drawing.Size(96, 6);
            this.ucMethodTitration.TabIndex = 0;
            // 
            // tabSupSolInterm
            // 
            this.tabSupSolInterm.Controls.Add(this.ucSolInterm1);
            this.tabSupSolInterm.Name = "tabSupSolInterm";
            this.tabSupSolInterm.Size = new System.Drawing.Size(105, 36);
            this.tabSupSolInterm.Text = "Soluciones Intermedias";
            // 
            // ucSolInterm1
            // 
            this.ucSolInterm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSolInterm1.Location = new System.Drawing.Point(0, 0);
            this.ucSolInterm1.Name = "ucSolInterm1";
            this.ucSolInterm1.Size = new System.Drawing.Size(105, 36);
            this.ucSolInterm1.TabIndex = 0;
            this.ucSolInterm1.onSignSolInterm += new LimsProject.signSolInterm(this.ucSolInterm1_onSignSolInterm);
            // 
            // gpTitle
            // 
            this.gpTitle.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 16F);
            this.gpTitle.AppearanceCaption.Options.UseFont = true;
            this.gpTitle.Controls.Add(this.cbMethod);
            this.gpTitle.Controls.Add(this.cbElement);
            this.gpTitle.Controls.Add(this.label2);
            this.gpTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpTitle.Location = new System.Drawing.Point(0, 0);
            this.gpTitle.Name = "gpTitle";
            this.gpTitle.Size = new System.Drawing.Size(884, 75);
            this.gpTitle.TabIndex = 34;
            this.gpTitle.Text = "Elegir método";
            // 
            // cbMethod
            // 
            this.cbMethod.Location = new System.Drawing.Point(109, 48);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbMethod.Properties.Appearance.Options.UseBackColor = true;
            this.cbMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMethod.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idtemplate_method", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cod_template_method", "", 19, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title")});
            this.cbMethod.Properties.NullText = "Seleccionar";
            this.cbMethod.Size = new System.Drawing.Size(769, 20);
            this.cbMethod.TabIndex = 26;
            this.cbMethod.EditValueChanged += new System.EventHandler(this.cbMethod_EditValueChanged);
            // 
            // cbElement
            // 
            this.cbElement.Location = new System.Drawing.Point(6, 48);
            this.cbElement.Name = "cbElement";
            this.cbElement.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbElement.Properties.Appearance.Options.UseBackColor = true;
            this.cbElement.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbElement.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idelement", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cod_element")});
            this.cbElement.Properties.NullText = "Seleccionar";
            this.cbElement.Properties.ShowFooter = false;
            this.cbElement.Properties.ShowHeader = false;
            this.cbElement.Size = new System.Drawing.Size(97, 20);
            this.cbElement.TabIndex = 25;
            this.cbElement.EditValueChanged += new System.EventHandler(this.cbElement_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Elemento:";
            // 
            // treeListColumn16
            // 
            this.treeListColumn16.Caption = "Estado";
            this.treeListColumn16.FieldName = "Estado";
            this.treeListColumn16.Name = "treeListColumn16";
            this.treeListColumn16.VisibleIndex = 11;
            // 
            // treeListColumn17
            // 
            this.treeListColumn17.Caption = "idtemplate_method";
            this.treeListColumn17.FieldName = "Idtemplate_method";
            this.treeListColumn17.Name = "treeListColumn17";
            this.treeListColumn17.VisibleIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabMain);
            this.panel1.Controls.Add(this.gpTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(168, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 481);
            this.panel1.TabIndex = 2;
            // 
            // FormSolutions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 602);
            this.Name = "FormSolutions";
            this.Text = "Preparación de Soluciones";
            this.Load += new System.EventHandler(this.FormStdCalibMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).EndInit();
            this.paTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeSolution)).EndInit();
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabSupCalib.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabProcessCalib)).EndInit();
            this.tabProcessCalib.ResumeLayout(false);
            this.tabModCalib.ResumeLayout(false);
            this.tabMethodCalib.ResumeLayout(false);
            this.tabSupTitration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage5.ResumeLayout(false);
            this.tabSupSolInterm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpTitle)).EndInit();
            this.gpTitle.ResumeLayout(false);
            this.gpTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbElement.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeSolution;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTab.XtraTabControl tabMain;
        private DevExpress.XtraEditors.LookUpEdit cbElement;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraTab.XtraTabPage tabSupCalib;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTab.XtraTabPage tabSupTitration;
        private UcCalibStd ucCalibStd1;
        private UcTitration ucTitration1;
        private DevExpress.XtraEditors.GroupControl gpTitle;
        private DevExpress.XtraEditors.LookUpEdit cbMethod;
        private DevExpress.XtraTab.XtraTabPage tabSupSolInterm;
        private DevExpress.XtraTab.XtraTabControl tabProcessCalib;
        private DevExpress.XtraTab.XtraTabPage tabModCalib;
        private DevExpress.XtraTab.XtraTabPage tabMethodCalib;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn16;
        private UcSelectMethods ucMethodCalib;
        private UcSelectMethods ucMethodTitration;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn17;
        private UcSolInterm ucSolInterm1;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
    }
}