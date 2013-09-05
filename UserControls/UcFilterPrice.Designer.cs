namespace LimsProject
{
    partial class UcFilterPrice
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
            this.cbStatusPrice = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.deDateIni = new DevExpress.XtraEditors.DateEdit();
            this.deDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btSearch = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCompany = new DevExpress.XtraEditors.TextEdit();
            this.tbAttention = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatusPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAttention.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStatusPrice
            // 
            this.cbStatusPrice.EditValue = 0;
            this.cbStatusPrice.Location = new System.Drawing.Point(493, 2);
            this.cbStatusPrice.Name = "cbStatusPrice";
            this.cbStatusPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatusPrice.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Todos", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Espera", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Relegado", 2, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Enviados", 3, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Facturados", 4, -1)});
            this.cbStatusPrice.Size = new System.Drawing.Size(100, 20);
            this.cbStatusPrice.TabIndex = 0;
            // 
            // deDateIni
            // 
            this.deDateIni.EditValue = null;
            this.deDateIni.Location = new System.Drawing.Point(328, 2);
            this.deDateIni.Name = "deDateIni";
            this.deDateIni.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateIni.Size = new System.Drawing.Size(100, 20);
            this.deDateIni.TabIndex = 1;
            // 
            // deDateEnd
            // 
            this.deDateEnd.EditValue = null;
            this.deDateEnd.Location = new System.Drawing.Point(328, 24);
            this.deDateEnd.Name = "deDateEnd";
            this.deDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateEnd.Size = new System.Drawing.Size(100, 20);
            this.deDateEnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado:";
            // 
            // btSearch
            // 
            this.btSearch.Image = global::LimsProject.Properties.Resources.find;
            this.btSearch.Location = new System.Drawing.Point(599, 1);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(68, 23);
            this.btSearch.TabIndex = 3;
            this.btSearch.Text = "Buscar";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Empresa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Contacto:";
            // 
            // tbCompany
            // 
            this.tbCompany.Location = new System.Drawing.Point(66, 1);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(203, 20);
            this.tbCompany.TabIndex = 4;
            // 
            // tbAttention
            // 
            this.tbAttention.Location = new System.Drawing.Point(66, 23);
            this.tbAttention.Name = "tbAttention";
            this.tbAttention.Size = new System.Drawing.Size(203, 20);
            this.tbAttention.TabIndex = 4;
            // 
            // UcFilterPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbAttention);
            this.Controls.Add(this.tbCompany);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deDateEnd);
            this.Controls.Add(this.deDateIni);
            this.Controls.Add(this.cbStatusPrice);
            this.Name = "UcFilterPrice";
            this.Size = new System.Drawing.Size(675, 49);
            ((System.ComponentModel.ISupportInitialize)(this.cbStatusPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAttention.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ImageComboBoxEdit cbStatusPrice;
        private DevExpress.XtraEditors.DateEdit deDateIni;
        private DevExpress.XtraEditors.DateEdit deDateEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit tbCompany;
        private DevExpress.XtraEditors.TextEdit tbAttention;
    }
}
