namespace LimsProject
{
    partial class UcTraceUser
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.laDate = new System.Windows.Forms.Label();
            this.laUserName = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // laDate
            // 
            this.laDate.AutoSize = true;
            this.laDate.Location = new System.Drawing.Point(42, 22);
            this.laDate.Name = "laDate";
            this.laDate.Size = new System.Drawing.Size(34, 13);
            this.laDate.TabIndex = 6;
            this.laDate.Text = "---------";
            // 
            // laUserName
            // 
            this.laUserName.AutoSize = true;
            this.laUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(121)))), ((int)(((byte)(167)))));
            this.laUserName.Location = new System.Drawing.Point(42, 3);
            this.laUserName.Name = "laUserName";
            this.laUserName.Size = new System.Drawing.Size(34, 13);
            this.laUserName.TabIndex = 7;
            this.laUserName.Text = "---------";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit1.EditValue = global::LimsProject.Properties.Resources.avatar1;
            this.pictureEdit1.Location = new System.Drawing.Point(1, 1);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(35, 35);
            this.pictureEdit1.TabIndex = 8;
            // 
            // UcTraceUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.laDate);
            this.Controls.Add(this.laUserName);
            this.Name = "UcTraceUser";
            this.Size = new System.Drawing.Size(84, 37);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label laDate;
        private System.Windows.Forms.Label laUserName;
    }
}
