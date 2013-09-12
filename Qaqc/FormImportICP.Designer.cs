namespace LimsProject
{
    partial class FormImportICP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportICP));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCol_Sel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_MethodId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Version = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_StorageDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_CalibId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_SamplesId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbMethods = new DevExpress.XtraEditors.LookUpEdit();
            this.deDateIni = new DevExpress.XtraEditors.DateEdit();
            this.deDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btShowSamples = new DevExpress.XtraEditors.SimpleButton();
            this.btImportar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).BeginInit();
            this.paTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).BeginInit();
            this.paBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.paCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            this.paTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMethods.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateEnd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Size = new System.Drawing.Size(744, 39);
            // 
            // paTitle
            // 
            this.paTitle.Size = new System.Drawing.Size(748, 43);
            this.paTitle.Visible = false;
            // 
            // paBottom
            // 
            this.paBottom.Controls.Add(this.btImportar);
            this.paBottom.Location = new System.Drawing.Point(0, 367);
            this.paBottom.Size = new System.Drawing.Size(748, 46);
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.gridControl1);
            this.paCenter.Location = new System.Drawing.Point(0, 96);
            this.paCenter.Size = new System.Drawing.Size(748, 271);
            // 
            // paTop
            // 
            this.paTop.Controls.Add(this.btShowSamples);
            this.paTop.Controls.Add(this.label3);
            this.paTop.Controls.Add(this.label2);
            this.paTop.Controls.Add(this.label1);
            this.paTop.Controls.Add(this.deDateEnd);
            this.paTop.Controls.Add(this.deDateIni);
            this.paTop.Controls.Add(this.cbMethods);
            this.paTop.Size = new System.Drawing.Size(748, 39);
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(748, 14);
            this.panelControl1.Visible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(744, 267);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcCol_Sel,
            this.gcCol_MethodId,
            this.gcCol_Version,
            this.gcCol_StorageDate,
            this.gcCol_CalibId,
            this.gcCol_SamplesId,
            this.gcCol_Name});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Images = this.imageList1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFilterPanel = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // gcCol_Sel
            // 
            this.gcCol_Sel.FieldName = "Sel";
            this.gcCol_Sel.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gcCol_Sel.ImageIndex = 0;
            this.gcCol_Sel.Name = "gcCol_Sel";
            this.gcCol_Sel.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gcCol_Sel.OptionsFilter.AllowAutoFilter = false;
            this.gcCol_Sel.OptionsFilter.AllowFilter = false;
            this.gcCol_Sel.Visible = true;
            this.gcCol_Sel.VisibleIndex = 0;
            // 
            // gcCol_MethodId
            // 
            this.gcCol_MethodId.Caption = "MethodId";
            this.gcCol_MethodId.FieldName = "MethodId";
            this.gcCol_MethodId.Name = "gcCol_MethodId";
            // 
            // gcCol_Version
            // 
            this.gcCol_Version.Caption = "Version";
            this.gcCol_Version.FieldName = "Version";
            this.gcCol_Version.Name = "gcCol_Version";
            this.gcCol_Version.Visible = true;
            this.gcCol_Version.VisibleIndex = 1;
            // 
            // gcCol_StorageDate
            // 
            this.gcCol_StorageDate.Caption = "StorageDate";
            this.gcCol_StorageDate.FieldName = "StorageDate";
            this.gcCol_StorageDate.Name = "gcCol_StorageDate";
            this.gcCol_StorageDate.Visible = true;
            this.gcCol_StorageDate.VisibleIndex = 2;
            // 
            // gcCol_CalibId
            // 
            this.gcCol_CalibId.Caption = "CalibId";
            this.gcCol_CalibId.FieldName = "CalibId";
            this.gcCol_CalibId.Name = "gcCol_CalibId";
            // 
            // gcCol_SamplesId
            // 
            this.gcCol_SamplesId.Caption = "SamplesId";
            this.gcCol_SamplesId.FieldName = "SamplesId";
            this.gcCol_SamplesId.Name = "gcCol_SamplesId";
            // 
            // gcCol_Name
            // 
            this.gcCol_Name.Caption = "Name";
            this.gcCol_Name.FieldName = "Name";
            this.gcCol_Name.Name = "gcCol_Name";
            this.gcCol_Name.Visible = true;
            this.gcCol_Name.VisibleIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "uncheck16x16.png");
            this.imageList1.Images.SetKeyName(1, "check16x16.png");
            // 
            // cbMethods
            // 
            this.cbMethods.Location = new System.Drawing.Point(370, 9);
            this.cbMethods.Name = "cbMethods";
            this.cbMethods.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMethods.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MethodId", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name")});
            this.cbMethods.Properties.NullText = "Seleccionar";
            this.cbMethods.Size = new System.Drawing.Size(210, 20);
            this.cbMethods.TabIndex = 3;
            // 
            // deDateIni
            // 
            this.deDateIni.EditValue = null;
            this.deDateIni.Location = new System.Drawing.Point(62, 9);
            this.deDateIni.Name = "deDateIni";
            this.deDateIni.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateIni.Size = new System.Drawing.Size(100, 20);
            this.deDateIni.TabIndex = 1;
            // 
            // deDateEnd
            // 
            this.deDateEnd.EditValue = null;
            this.deDateEnd.Location = new System.Drawing.Point(212, 9);
            this.deDateEnd.Name = "deDateEnd";
            this.deDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateEnd.Size = new System.Drawing.Size(100, 20);
            this.deDateEnd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Método:";
            // 
            // btShowSamples
            // 
            this.btShowSamples.Location = new System.Drawing.Point(586, 8);
            this.btShowSamples.Name = "btShowSamples";
            this.btShowSamples.Size = new System.Drawing.Size(69, 23);
            this.btShowSamples.TabIndex = 4;
            this.btShowSamples.Text = "Recuperar";
            this.btShowSamples.Click += new System.EventHandler(this.btShowSamples_Click);
            // 
            // btImportar
            // 
            this.btImportar.Location = new System.Drawing.Point(18, 11);
            this.btImportar.Name = "btImportar";
            this.btImportar.Size = new System.Drawing.Size(69, 23);
            this.btImportar.TabIndex = 4;
            this.btImportar.Text = "Importar";
            this.btImportar.Click += new System.EventHandler(this.btImportar_Click);
            // 
            // FormImportICP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 413);
            this.Name = "FormImportICP";
            this.Text = "Importar desde Icp";
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMethods.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateEnd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btShowSamples;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit deDateEnd;
        private DevExpress.XtraEditors.DateEdit deDateIni;
        private DevExpress.XtraEditors.LookUpEdit cbMethods;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Sel;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_MethodId;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Version;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_StorageDate;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_CalibId;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_SamplesId;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Name;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton btImportar;

    }
}