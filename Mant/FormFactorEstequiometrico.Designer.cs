namespace LimsProject
{
    partial class FormFactorEstequiometrico
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
            this.gcFactorEstequ = new DevExpress.XtraGrid.GridControl();
            this.gvFactorEstequ = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).BeginInit();
            this.paTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.paCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFactorEstequ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFactorEstequ)).BeginInit();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Size = new System.Drawing.Size(615, 39);
            // 
            // paTitle
            // 
            this.paTitle.Size = new System.Drawing.Size(619, 43);
            this.paTitle.Visible = false;
            // 
            // paBottom
            // 
            this.paBottom.Location = new System.Drawing.Point(0, 321);
            this.paBottom.Size = new System.Drawing.Size(619, 46);
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.gcFactorEstequ);
            this.paCenter.Size = new System.Drawing.Size(619, 213);
            // 
            // paTop
            // 
            this.paTop.Size = new System.Drawing.Size(619, 51);
            this.paTop.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(619, 14);
            this.panelControl1.Visible = false;
            // 
            // gcFactorEstequ
            // 
            this.gcFactorEstequ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFactorEstequ.EmbeddedNavigator.Name = "";
            this.gcFactorEstequ.Location = new System.Drawing.Point(2, 2);
            this.gcFactorEstequ.MainView = this.gvFactorEstequ;
            this.gcFactorEstequ.Name = "gcFactorEstequ";
            this.gcFactorEstequ.Size = new System.Drawing.Size(615, 209);
            this.gcFactorEstequ.TabIndex = 0;
            this.gcFactorEstequ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFactorEstequ});
            // 
            // gvFactorEstequ
            // 
            this.gvFactorEstequ.GridControl = this.gcFactorEstequ;
            this.gvFactorEstequ.Name = "gvFactorEstequ";
            this.gvFactorEstequ.OptionsView.ShowGroupPanel = false;
            // 
            // FormFactorEstequiometrico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 367);
            this.Name = "FormFactorEstequiometrico";
            this.Text = "Factor Estequiométrico";
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).EndInit();
            this.paTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFactorEstequ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFactorEstequ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcFactorEstequ;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFactorEstequ;
    }
}