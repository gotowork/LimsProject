namespace LimsProject
{
    partial class FormMessage
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
            this.laMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            this.paTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.paCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 119);
            this.panelControl1.Size = new System.Drawing.Size(304, 29);
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btCancel.Location = new System.Drawing.Point(43, 2);
            this.btCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btCancel.Size = new System.Drawing.Size(68, 25);
            // 
            // btOk
            // 
            this.btOk.Dock = System.Windows.Forms.DockStyle.Left;
            this.btOk.Location = new System.Drawing.Point(2, 2);
            this.btOk.Margin = new System.Windows.Forms.Padding(20);
            this.btOk.Padding = new System.Windows.Forms.Padding(20);
            this.btOk.Size = new System.Drawing.Size(41, 25);
            // 
            // paTop
            // 
            this.paTop.Size = new System.Drawing.Size(304, 37);
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.laMessage);
            this.paCenter.Location = new System.Drawing.Point(0, 37);
            this.paCenter.Size = new System.Drawing.Size(304, 82);
            // 
            // laTitle
            // 
            this.laTitle.Size = new System.Drawing.Size(300, 33);
            // 
            // laMessage
            // 
            this.laMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laMessage.Location = new System.Drawing.Point(6, 5);
            this.laMessage.Name = "laMessage";
            this.laMessage.Size = new System.Drawing.Size(293, 68);
            this.laMessage.TabIndex = 0;
            this.laMessage.Text = "label1";
            // 
            // FormMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 148);
            this.Name = "FormMessage";
            this.ShowInTaskbar = false;
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            this.paTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label laMessage;

    }
}