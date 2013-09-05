namespace LimsProject
{
    partial class UcGenerar
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cbGenerar = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenerar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGenerar
            // 
            this.cbGenerar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbGenerar.Location = new System.Drawing.Point(0, 0);
            this.cbGenerar.Margin = new System.Windows.Forms.Padding(0);
            this.cbGenerar.Name = "cbGenerar";
            this.cbGenerar.Properties.AutoHeight = false;
            this.cbGenerar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            serializableAppearanceObject1.ForeColor = System.Drawing.Color.Black;
            serializableAppearanceObject1.Options.UseForeColor = true;
            this.cbGenerar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Generar", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1)});
            this.cbGenerar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cbGenerar.Size = new System.Drawing.Size(90, 30);
            this.cbGenerar.TabIndex = 20;
            this.cbGenerar.SelectedIndexChanged += new System.EventHandler(this.cbGenerar_SelectedIndexChanged);
            // 
            // UcGenerar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbGenerar);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcGenerar";
            this.Size = new System.Drawing.Size(90, 30);
            ((System.ComponentModel.ISupportInitialize)(this.cbGenerar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbGenerar;
    }
}
