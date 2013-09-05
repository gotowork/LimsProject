namespace LimsProject
{
    partial class UcSign
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcSign));
            this.tbPwd = new DevExpress.XtraEditors.TextEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btLock = new DevExpress.XtraEditors.SimpleButton();
            this.laTitleSign = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbPwd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(36, 19);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.tbPwd.Properties.NullText = "Password";
            this.tbPwd.Properties.PasswordChar = '*';
            this.tbPwd.Size = new System.Drawing.Size(118, 20);
            this.tbPwd.TabIndex = 11;
            this.tbPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPwd_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sign-grey.png");
            this.imageList1.Images.SetKeyName(1, "sign-green.png");
            this.imageList1.Images.SetKeyName(2, "sign-red.png");
            // 
            // btLock
            // 
            this.btLock.AllowFocus = false;
            this.btLock.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btLock.Appearance.Options.UseBackColor = true;
            this.btLock.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btLock.CausesValidation = false;
            this.btLock.ImageIndex = 0;
            this.btLock.ImageList = this.imageList1;
            this.btLock.Location = new System.Drawing.Point(2, 7);
            this.btLock.Name = "btLock";
            this.btLock.Size = new System.Drawing.Size(32, 32);
            this.btLock.TabIndex = 12;
            // 
            // laTitleSign
            // 
            this.laTitleSign.AutoSize = true;
            this.laTitleSign.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitleSign.ForeColor = System.Drawing.Color.Blue;
            this.laTitleSign.Location = new System.Drawing.Point(39, 3);
            this.laTitleSign.Name = "laTitleSign";
            this.laTitleSign.Size = new System.Drawing.Size(0, 15);
            this.laTitleSign.TabIndex = 13;
            // 
            // UcSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.laTitleSign);
            this.Controls.Add(this.btLock);
            this.Controls.Add(this.tbPwd);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcSign";
            this.Size = new System.Drawing.Size(158, 40);
            ((System.ComponentModel.ISupportInitialize)(this.tbPwd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tbPwd;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton btLock;
        private System.Windows.Forms.Label laTitleSign;
    }
}
