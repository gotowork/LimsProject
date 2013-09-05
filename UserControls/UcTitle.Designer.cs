namespace LimsProject
{
    partial class UcTitle
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
            this.laTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.laTitle.Location = new System.Drawing.Point(0, 0);
            this.laTitle.Name = "laTitle";
            this.laTitle.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.laTitle.Size = new System.Drawing.Size(397, 54);
            this.laTitle.TabIndex = 0;
            this.laTitle.Text = "Title";
            this.laTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UcTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.laTitle);
            this.Name = "UcTitle";
            this.Size = new System.Drawing.Size(397, 54);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label laTitle;
    }
}
