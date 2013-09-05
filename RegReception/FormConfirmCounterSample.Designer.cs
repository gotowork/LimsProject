namespace LimsProject
{
    partial class FormConfirmCounterSample
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAmount = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            this.paTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.paCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 111);
            this.panelControl1.Size = new System.Drawing.Size(247, 34);
            // 
            // paTop
            // 
            this.paTop.Size = new System.Drawing.Size(247, 44);
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.label1);
            this.paCenter.Controls.Add(this.tbAmount);
            this.paCenter.Size = new System.Drawing.Size(247, 67);
            // 
            // laTitle
            // 
            this.laTitle.Size = new System.Drawing.Size(243, 40);
            this.laTitle.Text = "Asignar a todas las filas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad:";
            // 
            // tbAmount
            // 
            this.tbAmount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbAmount.Location = new System.Drawing.Point(84, 26);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbAmount.Properties.IsFloatValue = false;
            this.tbAmount.Properties.Mask.EditMask = "N00";
            this.tbAmount.Properties.MaxValue = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.tbAmount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbAmount.Size = new System.Drawing.Size(100, 20);
            this.tbAmount.TabIndex = 2;
            // 
            // FormConfirmCounterSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 145);
            this.Name = "FormConfirmCounterSample";
            this.ShowInTaskbar = false;
            this.Text = "Contra Muestras";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            this.paTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            this.paCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit tbAmount;
    }
}