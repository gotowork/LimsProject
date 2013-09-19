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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabMain = new DevExpress.XtraTab.XtraTabControl();
            this.tabSupCalib = new DevExpress.XtraTab.XtraTabPage();
            this.tabProcessCalib = new DevExpress.XtraTab.XtraTabControl();
            this.tabModCalib = new DevExpress.XtraTab.XtraTabPage();
            this.ucCalibStd1 = new LimsProject.UcCalibStd();
            this.tabMethodCalib = new DevExpress.XtraTab.XtraTabPage();
            this.tabSupTitration = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.ucTitration1 = new LimsProject.UcTitration();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.tabSupSolInterm = new DevExpress.XtraTab.XtraTabPage();
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
            this.paTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabSupCalib.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabProcessCalib)).BeginInit();
            this.tabProcessCalib.SuspendLayout();
            this.tabModCalib.SuspendLayout();
            this.tabSupTitration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.tabSupSolInterm.SuspendLayout();
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
            this.paTitle.Visible = false;
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
            this.paCenter.Location = new System.Drawing.Point(0, 92);
            this.paCenter.Size = new System.Drawing.Size(1054, 464);
            // 
            // paTop
            // 
            this.paTop.Controls.Add(this.cbElement);
            this.paTop.Controls.Add(this.label2);
            this.paTop.Size = new System.Drawing.Size(1054, 35);
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(1054, 14);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "fiola_group.png");
            this.imageList1.Images.SetKeyName(1, "fiola.png");
            this.imageList1.Images.SetKeyName(2, "fiola_ver.png");
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedTabPage = this.tabSupCalib;
            this.tabMain.Size = new System.Drawing.Size(1050, 460);
            this.tabMain.TabIndex = 0;
            this.tabMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabSupCalib,
            this.tabSupTitration,
            this.tabSupSolInterm});
            this.tabMain.Text = "Metodos";
            // 
            // tabSupCalib
            // 
            this.tabSupCalib.Controls.Add(this.tabProcessCalib);
            this.tabSupCalib.Name = "tabSupCalib";
            this.tabSupCalib.Size = new System.Drawing.Size(1041, 430);
            this.tabSupCalib.Text = "Calibraciones";
            // 
            // tabProcessCalib
            // 
            this.tabProcessCalib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProcessCalib.Location = new System.Drawing.Point(0, 0);
            this.tabProcessCalib.Name = "tabProcessCalib";
            this.tabProcessCalib.SelectedTabPage = this.tabModCalib;
            this.tabProcessCalib.Size = new System.Drawing.Size(1041, 430);
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
            this.tabModCalib.Size = new System.Drawing.Size(1032, 400);
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
            cGroup_solution1.Idelement = null;
            cGroup_solution1.Idgroup_solution = 0;
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
            this.ucCalibStd1.Size = new System.Drawing.Size(1032, 400);
            this.ucCalibStd1.TabIndex = 0;
            // 
            // tabMethodCalib
            // 
            this.tabMethodCalib.Name = "tabMethodCalib";
            this.tabMethodCalib.Size = new System.Drawing.Size(262, 60);
            this.tabMethodCalib.Text = "Métodos Agrupables";
            // 
            // tabSupTitration
            // 
            this.tabSupTitration.Controls.Add(this.xtraTabControl2);
            this.tabSupTitration.Name = "tabSupTitration";
            this.tabSupTitration.Size = new System.Drawing.Size(271, 90);
            this.tabSupTitration.Text = "Titulación de Soluciones";
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl2.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage4;
            this.xtraTabControl2.Size = new System.Drawing.Size(271, 90);
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
            this.xtraTabPage4.Size = new System.Drawing.Size(262, 60);
            this.xtraTabPage4.Text = "Titulacion";
            // 
            // ucTitration1
            // 
            this.ucTitration1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTitration1.Iduser = 0;
            this.ucTitration1.Location = new System.Drawing.Point(0, 0);
            this.ucTitration1.Name = "ucTitration1";
            this.ucTitration1.Size = new System.Drawing.Size(262, 60);
            this.ucTitration1.Solution = null;
            this.ucTitration1.TabIndex = 0;
            this.ucTitration1.Titration_main = null;
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(262, 60);
            this.xtraTabPage5.Text = "Métodos Agrupables";
            // 
            // tabSupSolInterm
            // 
            this.tabSupSolInterm.Name = "tabSupSolInterm";
            this.tabSupSolInterm.Size = new System.Drawing.Size(271, 90);
            this.tabSupSolInterm.Text = "Soluciones Intermedias";
            // 
            // cbElement
            // 
            this.cbElement.Location = new System.Drawing.Point(102, 7);
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
            this.label2.Location = new System.Drawing.Point(42, 10);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 460);
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
            this.paTop.ResumeLayout(false);
            this.paTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabSupCalib.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabProcessCalib)).EndInit();
            this.tabProcessCalib.ResumeLayout(false);
            this.tabModCalib.ResumeLayout(false);
            this.tabSupTitration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            this.tabSupSolInterm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbElement.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabMain;
        private DevExpress.XtraEditors.LookUpEdit cbElement;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraTab.XtraTabPage tabSupCalib;
        private DevExpress.XtraTab.XtraTabPage tabSupTitration;
        private UcCalibStd ucCalibStd1;
        private UcTitration ucTitration1;
        private DevExpress.XtraTab.XtraTabPage tabSupSolInterm;
        private DevExpress.XtraTab.XtraTabControl tabProcessCalib;
        private DevExpress.XtraTab.XtraTabPage tabModCalib;
        private DevExpress.XtraTab.XtraTabPage tabMethodCalib;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn16;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn17;
        
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
    }
}