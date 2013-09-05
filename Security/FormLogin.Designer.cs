namespace LimsProject
{
    partial class FormLogin
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
            this.paInferior = new System.Windows.Forms.Panel();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btOk = new DevExpress.XtraEditors.SimpleButton();
            this.paSuperior = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.paCenter = new System.Windows.Forms.Panel();
            this.laMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPwd = new DevExpress.XtraEditors.TextEdit();
            this.tbUser = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paInferior.SuspendLayout();
            this.paSuperior.SuspendLayout();
            this.paCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // paInferior
            // 
            this.paInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.paInferior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paInferior.Controls.Add(this.btCancel);
            this.paInferior.Controls.Add(this.btOk);
            this.paInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paInferior.Location = new System.Drawing.Point(0, 117);
            this.paInferior.Name = "paInferior";
            this.paInferior.Size = new System.Drawing.Size(309, 38);
            this.paInferior.TabIndex = 0;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(225, 6);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(65, 23);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "Cancelar";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(189, 6);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(30, 23);
            this.btOk.TabIndex = 3;
            this.btOk.Text = "Ok";
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            this.btOk.Enter += new System.EventHandler(this.btOk_Enter);
            // 
            // paSuperior
            // 
            this.paSuperior.BackColor = System.Drawing.Color.LightSteelBlue;
            this.paSuperior.Controls.Add(this.label3);
            this.paSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.paSuperior.Location = new System.Drawing.Point(0, 0);
            this.paSuperior.Name = "paSuperior";
            this.paSuperior.Size = new System.Drawing.Size(309, 39);
            this.paSuperior.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Autenticación";
            // 
            // paCenter
            // 
            this.paCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(238)))), ((int)(((byte)(229)))));
            this.paCenter.Controls.Add(this.pictureBox1);
            this.paCenter.Controls.Add(this.laMessage);
            this.paCenter.Controls.Add(this.label2);
            this.paCenter.Controls.Add(this.label1);
            this.paCenter.Controls.Add(this.tbPwd);
            this.paCenter.Controls.Add(this.tbUser);
            this.paCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paCenter.Location = new System.Drawing.Point(0, 39);
            this.paCenter.Name = "paCenter";
            this.paCenter.Size = new System.Drawing.Size(309, 78);
            this.paCenter.TabIndex = 2;
            // 
            // laMessage
            // 
            this.laMessage.AutoSize = true;
            this.laMessage.ForeColor = System.Drawing.Color.Red;
            this.laMessage.Location = new System.Drawing.Point(159, 61);
            this.laMessage.Name = "laMessage";
            this.laMessage.Size = new System.Drawing.Size(0, 13);
            this.laMessage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Tan;
            this.label2.Location = new System.Drawing.Point(89, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(89, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(159, 39);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Properties.PasswordChar = '*';
            this.tbPwd.Size = new System.Drawing.Size(138, 20);
            this.tbPwd.TabIndex = 2;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(159, 17);
            this.tbUser.Margin = new System.Windows.Forms.Padding(1);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(138, 20);
            this.tbUser.TabIndex = 1;
            this.tbUser.Leave += new System.EventHandler(this.tbUser_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LimsProject.Properties.Resources.users;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 69);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 155);
            this.Controls.Add(this.paCenter);
            this.Controls.Add(this.paSuperior);
            this.Controls.Add(this.paInferior);
            this.KeyPreview = true;
            this.Name = "FormLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Autenticación";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormLogin_KeyPress);
            this.paInferior.ResumeLayout(false);
            this.paSuperior.ResumeLayout(false);
            this.paSuperior.PerformLayout();
            this.paCenter.ResumeLayout(false);
            this.paCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paInferior;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.SimpleButton btOk;
        private System.Windows.Forms.Panel paSuperior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel paCenter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit tbPwd;
        private DevExpress.XtraEditors.TextEdit tbUser;
        private System.Windows.Forms.Label laMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}