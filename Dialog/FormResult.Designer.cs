namespace LimsProject
{
    partial class FormResult
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
            this.laMsg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            this.paTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.paCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 105);
            this.panelControl1.Size = new System.Drawing.Size(325, 34);
            // 
            // btCancel
            // 
            this.btCancel.Visible = false;
            // 
            // paTop
            // 
            this.paTop.Controls.Add(this.pictureBox1);
            this.paTop.Size = new System.Drawing.Size(325, 44);
            this.paTop.Controls.SetChildIndex(this.laTitle, 0);
            this.paTop.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.laMsg);
            this.paCenter.Size = new System.Drawing.Size(325, 61);
            // 
            // laTitle
            // 
            this.laTitle.ForeColor = System.Drawing.Color.Green;
            this.laTitle.Padding = new System.Windows.Forms.Padding(60, 9, 0, 0);
            this.laTitle.Size = new System.Drawing.Size(321, 40);
            this.laTitle.Text = "Guardado";
            // 
            // laMsg
            // 
            this.laMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laMsg.ForeColor = System.Drawing.Color.Green;
            this.laMsg.Location = new System.Drawing.Point(7, 5);
            this.laMsg.Name = "laMsg";
            this.laMsg.Size = new System.Drawing.Size(313, 52);
            this.laMsg.TabIndex = 0;
            this.laMsg.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Image = global::LimsProject.Properties.Resources.ok;
            this.pictureBox1.Location = new System.Drawing.Point(15, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 33);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 139);
            this.Name = "FormResult";
            this.ShowInTaskbar = false;
            this.Text = "Guardado";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            this.paTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label laMsg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}