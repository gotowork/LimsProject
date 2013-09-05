namespace LimsProject
{
    partial class FormConfirmSaveMethod
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
            this.btSaveAs = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            this.paTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btSaveAs);
            this.panelControl1.Location = new System.Drawing.Point(0, 53);
            this.panelControl1.Size = new System.Drawing.Size(292, 34);
            this.panelControl1.Controls.SetChildIndex(this.btOk, 0);
            this.panelControl1.Controls.SetChildIndex(this.btCancel, 0);
            this.panelControl1.Controls.SetChildIndex(this.btSaveAs, 0);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(219, 5);
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.Size = new System.Drawing.Size(63, 23);
            this.btOk.Text = "Guardar";
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // paTop
            // 
            this.paTop.Size = new System.Drawing.Size(292, 53);
            // 
            // paCenter
            // 
            this.paCenter.Location = new System.Drawing.Point(0, 53);
            this.paCenter.Size = new System.Drawing.Size(292, 0);
            this.paCenter.Visible = false;
            // 
            // laTitle
            // 
            this.laTitle.Padding = new System.Windows.Forms.Padding(20, 12, 0, 0);
            this.laTitle.Size = new System.Drawing.Size(288, 49);
            this.laTitle.Text = "Guardar Método";
            // 
            // btSaveAs
            // 
            this.btSaveAs.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSaveAs.Location = new System.Drawing.Point(74, 5);
            this.btSaveAs.Name = "btSaveAs";
            this.btSaveAs.Size = new System.Drawing.Size(86, 23);
            this.btSaveAs.TabIndex = 1;
            this.btSaveAs.Text = "Guardar como";
            this.btSaveAs.Click += new System.EventHandler(this.btSaveAs_Click);
            // 
            // FormConfirmSaveMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 87);
            this.Name = "FormConfirmSaveMethod";
            this.ShowInTaskbar = false;
            this.Text = "Guardar Método";
            this.Load += new System.EventHandler(this.FormConfirmSaveMethod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            this.paTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btSaveAs;
    }
}