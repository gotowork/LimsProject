namespace LimsProject
{
    partial class FormQaqcHU
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
            this.gcHumidityAnalysis = new DevExpress.XtraGrid.GridControl();
            this.gvHumidityAnalysis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).BeginInit();
            this.paTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.paCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHumidityAnalysis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHumidityAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Size = new System.Drawing.Size(642, 39);
            // 
            // paTitle
            // 
            this.paTitle.Size = new System.Drawing.Size(646, 43);
            // 
            // paBottom
            // 
            this.paBottom.Location = new System.Drawing.Point(0, 371);
            this.paBottom.Size = new System.Drawing.Size(646, 46);
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.gcHumidityAnalysis);
            this.paCenter.Size = new System.Drawing.Size(646, 263);
            // 
            // paTop
            // 
            this.paTop.Size = new System.Drawing.Size(646, 51);
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(646, 14);
            // 
            // gcHumidityAnalysis
            // 
            this.gcHumidityAnalysis.EmbeddedNavigator.Name = "";
            this.gcHumidityAnalysis.Location = new System.Drawing.Point(21, 6);
            this.gcHumidityAnalysis.MainView = this.gvHumidityAnalysis;
            this.gcHumidityAnalysis.Name = "gcHumidityAnalysis";
            this.gcHumidityAnalysis.Size = new System.Drawing.Size(400, 200);
            this.gcHumidityAnalysis.TabIndex = 0;
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
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn4";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // FormQaqcHU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 417);
            this.Name = "FormQaqcHU";
            this.Text = "Análisis de Humedad";
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).EndInit();
            this.paTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHumidityAnalysis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHumidityAnalysis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcHumidityAnalysis;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHumidityAnalysis;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;

    }
}