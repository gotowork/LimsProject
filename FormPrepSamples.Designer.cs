namespace LimsProject
{
    partial class FormPrepSamples
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
            this.gcPrepSample = new DevExpress.XtraGrid.GridControl();
            this.gvPrepSample = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btOk = new DevExpress.XtraEditors.SimpleButton();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.tbBarCode = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gcHumidityAnalysis = new DevExpress.XtraGrid.GridControl();
            this.gvHumidityAnalysis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).BeginInit();
            this.paTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).BeginInit();
            this.paBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.paCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            this.paTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrepSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrepSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBarCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHumidityAnalysis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHumidityAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Size = new System.Drawing.Size(654, 39);
            // 
            // paTitle
            // 
            this.paTitle.Size = new System.Drawing.Size(658, 43);
            this.paTitle.Visible = false;
            // 
            // paBottom
            // 
            this.paBottom.Controls.Add(this.simpleButton1);
            this.paBottom.Controls.Add(this.btCancel);
            this.paBottom.Controls.Add(this.btOk);
            this.paBottom.Location = new System.Drawing.Point(0, 363);
            this.paBottom.Size = new System.Drawing.Size(658, 39);
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.xtraTabControl1);
            this.paCenter.Location = new System.Drawing.Point(0, 84);
            this.paCenter.Size = new System.Drawing.Size(658, 279);
            // 
            // paTop
            // 
            this.paTop.Controls.Add(this.tbBarCode);
            this.paTop.Size = new System.Drawing.Size(658, 27);
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(658, 14);
            this.panelControl1.Visible = false;
            // 
            // gcPrepSample
            // 
            this.gcPrepSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPrepSample.EmbeddedNavigator.Name = "";
            this.gcPrepSample.Location = new System.Drawing.Point(0, 0);
            this.gcPrepSample.MainView = this.gvPrepSample;
            this.gcPrepSample.Name = "gcPrepSample";
            this.gcPrepSample.Size = new System.Drawing.Size(645, 245);
            this.gcPrepSample.TabIndex = 0;
            this.gcPrepSample.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPrepSample});
            // 
            // gvPrepSample
            // 
            this.gvPrepSample.GridControl = this.gcPrepSample;
            this.gvPrepSample.Name = "gvPrepSample";
            this.gvPrepSample.OptionsView.ShowGroupPanel = false;
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(12, 8);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(43, 23);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "Ok";
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(61, 8);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(71, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancelar";
            // 
            // tbBarCode
            // 
            this.tbBarCode.Location = new System.Drawing.Point(32, 2);
            this.tbBarCode.Name = "tbBarCode";
            this.tbBarCode.Size = new System.Drawing.Size(100, 20);
            this.tbBarCode.TabIndex = 0;
            this.tbBarCode.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(401, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "temp";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(654, 275);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.Text = "Analisis de humedad";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcPrepSample);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(645, 245);
            this.xtraTabPage1.Text = "Pendientes";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gcHumidityAnalysis);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(645, 245);
            this.xtraTabPage2.Text = "Analisis de humedad";
            // 
            // gcHumidityAnalysis
            // 
            this.gcHumidityAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHumidityAnalysis.EmbeddedNavigator.Name = "";
            this.gcHumidityAnalysis.Location = new System.Drawing.Point(0, 0);
            this.gcHumidityAnalysis.MainView = this.gvHumidityAnalysis;
            this.gcHumidityAnalysis.Name = "gcHumidityAnalysis";
            this.gcHumidityAnalysis.Size = new System.Drawing.Size(645, 245);
            this.gcHumidityAnalysis.TabIndex = 1;
            this.gcHumidityAnalysis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHumidityAnalysis});
            // 
            // gvHumidityAnalysis
            // 
            this.gvHumidityAnalysis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvHumidityAnalysis.GridControl = this.gcHumidityAnalysis;
            this.gvHumidityAnalysis.Name = "gvHumidityAnalysis";
            this.gvHumidityAnalysis.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn4";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Peso Humedo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Peso Seco";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "%Humedad";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // FormPrepSamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 402);
            this.Name = "FormPrepSamples";
            this.Text = "Preparación de Muestras";
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).EndInit();
            this.paTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            this.paBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            this.paTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrepSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrepSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBarCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHumidityAnalysis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHumidityAnalysis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPrepSample;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrepSample;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.SimpleButton btOk;
        private DevExpress.XtraEditors.TextEdit tbBarCode;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gcHumidityAnalysis;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHumidityAnalysis;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}