namespace LimsProject
{
    partial class FormEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpresa));
            this.tbClientRuc = new DevExpress.XtraEditors.TextEdit();
            this.tbClientPhone = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbClientEmail = new DevExpress.XtraEditors.TextEdit();
            this.tbClientDomicile = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIdCompany = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTypeCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.tbBusinessName = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.paTitleSearch.SuspendLayout();
            this.paTopBasicButtons.SuspendLayout();
            this.paTopSearch.SuspendLayout();
            this.paBottomSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.paSearchGen.SuspendLayout();
            this.paInferior.SuspendLayout();
            this.paTitulo.SuspendLayout();
            this.paCentral.SuspendLayout();
            this.paSuperior.SuspendLayout();
            this.thePanelTab1.SuspendLayout();
            this.tpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientRuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientDomicile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIdCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTypeCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBusinessName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "save.png");
            this.imageList1.Images.SetKeyName(1, "nuevo.png");
            this.imageList1.Images.SetKeyName(2, "eliminar.png");
            this.imageList1.Images.SetKeyName(3, "buscar.png");
            this.imageList1.Images.SetKeyName(4, "salir.png");
            this.imageList1.Images.SetKeyName(5, "cancelar.png");
            this.imageList1.Images.SetKeyName(6, "ok.png");
            this.imageList1.Images.SetKeyName(7, "deshacer.png");
            this.imageList1.Images.SetKeyName(8, "editar.png");
            // 
            // label1
            // 
            this.label1.Text = "Empresa - Búsqueda";
            // 
            // btSalir2
            // 
            this.btSalir2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btSalir2.FlatAppearance.BorderSize = 0;
            // 
            // btGuardar
            // 
            this.btGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btGuardar.FlatAppearance.BorderSize = 0;
            // 
            // btNuevo2
            // 
            this.btNuevo2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btNuevo2.FlatAppearance.BorderSize = 0;
            // 
            // btEliminar2
            // 
            this.btEliminar2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btEliminar2.FlatAppearance.BorderSize = 0;
            // 
            // btBuscar
            // 
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btBuscar.FlatAppearance.BorderSize = 0;
            // 
            // btEditar
            // 
            this.btEditar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btEditar.FlatAppearance.BorderSize = 0;
            // 
            // btCancel
            // 
            this.btCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btCancel.FlatAppearance.BorderSize = 0;
            // 
            // btOk
            // 
            this.btOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btOk.FlatAppearance.BorderSize = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(481, 0);
            // 
            // btFiltroBuscar
            // 
            this.btFiltroBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btFiltroBuscar.FlatAppearance.BorderSize = 0;
            // 
            // paInferior
            // 
            this.paInferior.Location = new System.Drawing.Point(3, 258);
            this.paInferior.Size = new System.Drawing.Size(553, 45);
            // 
            // paTitulo
            // 
            this.paTitulo.Size = new System.Drawing.Size(553, 36);
            // 
            // paCentral
            // 
            this.paCentral.Controls.Add(this.cbTypeCompany);
            this.paCentral.Controls.Add(this.tbClientRuc);
            this.paCentral.Controls.Add(this.tbBusinessName);
            this.paCentral.Controls.Add(this.tbClientDomicile);
            this.paCentral.Controls.Add(this.tbClientPhone);
            this.paCentral.Controls.Add(this.tbClientEmail);
            this.paCentral.Controls.Add(this.label10);
            this.paCentral.Controls.Add(this.label9);
            this.paCentral.Controls.Add(this.label11);
            this.paCentral.Controls.Add(this.label6);
            this.paCentral.Controls.Add(this.label8);
            this.paCentral.Controls.Add(this.label12);
            this.paCentral.Controls.Add(this.label7);
            this.paCentral.Location = new System.Drawing.Point(3, 79);
            this.paCentral.Size = new System.Drawing.Size(553, 179);
            // 
            // paSupBotones
            // 
            this.paSupBotones.Size = new System.Drawing.Size(567, 32);
            // 
            // paSuperior
            // 
            this.paSuperior.Controls.Add(this.tbIdCompany);
            this.paSuperior.Controls.Add(this.label5);
            this.paSuperior.Size = new System.Drawing.Size(553, 40);
            // 
            // laTitulo
            // 
            this.laTitulo.Size = new System.Drawing.Size(469, 36);
            this.laTitulo.Text = "Empresa";
            // 
            // thePanelTab1
            // 
            this.thePanelTab1.Size = new System.Drawing.Size(567, 335);
            // 
            // tpDatos
            // 
            this.tpDatos.Size = new System.Drawing.Size(559, 306);
            // 
            // tbClientRuc
            // 
            this.tbClientRuc.Location = new System.Drawing.Point(104, 104);
            this.tbClientRuc.Name = "tbClientRuc";
            this.tbClientRuc.Properties.Mask.BeepOnError = true;
            this.tbClientRuc.Properties.Mask.EditMask = "\\d{0,11}";
            this.tbClientRuc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tbClientRuc.Size = new System.Drawing.Size(109, 20);
            this.tbClientRuc.TabIndex = 5;
            // 
            // tbClientPhone
            // 
            this.tbClientPhone.Location = new System.Drawing.Point(104, 60);
            this.tbClientPhone.Name = "tbClientPhone";
            this.tbClientPhone.Properties.Mask.EditMask = "\\+\\d\\d(\\(\\d{1,3}\\))\\d{1,10}";
            this.tbClientPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tbClientPhone.Size = new System.Drawing.Size(85, 20);
            this.tbClientPhone.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ruc:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Domicilio:";
            // 
            // tbClientEmail
            // 
            this.tbClientEmail.Location = new System.Drawing.Point(104, 82);
            this.tbClientEmail.Name = "tbClientEmail";
            this.tbClientEmail.Size = new System.Drawing.Size(231, 20);
            this.tbClientEmail.TabIndex = 4;
            // 
            // tbClientDomicile
            // 
            this.tbClientDomicile.Location = new System.Drawing.Point(104, 38);
            this.tbClientDomicile.Name = "tbClientDomicile";
            this.tbClientDomicile.Size = new System.Drawing.Size(231, 20);
            this.tbClientDomicile.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo:";
            // 
            // tbIdCompany
            // 
            this.tbIdCompany.Location = new System.Drawing.Point(102, 8);
            this.tbIdCompany.Name = "tbIdCompany";
            this.tbIdCompany.Properties.ReadOnly = true;
            this.tbIdCompany.Size = new System.Drawing.Size(85, 20);
            this.tbIdCompany.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID Empresa:";
            // 
            // cbTypeCompany
            // 
            this.cbTypeCompany.Location = new System.Drawing.Point(104, 126);
            this.cbTypeCompany.Name = "cbTypeCompany";
            this.cbTypeCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTypeCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name")});
            this.cbTypeCompany.Properties.NullText = "";
            this.cbTypeCompany.Properties.ShowFooter = false;
            this.cbTypeCompany.Properties.ShowHeader = false;
            this.cbTypeCompany.Size = new System.Drawing.Size(100, 20);
            this.cbTypeCompany.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tipo:";
            // 
            // tbBusinessName
            // 
            this.tbBusinessName.Location = new System.Drawing.Point(104, 16);
            this.tbBusinessName.Name = "tbBusinessName";
            this.tbBusinessName.Size = new System.Drawing.Size(231, 20);
            this.tbBusinessName.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nombre:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(195, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ej: +51(01)354546";
            // 
            // FormEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 367);
            this.Name = "FormEmpresa";
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.paTitleSearch.ResumeLayout(false);
            this.paTopBasicButtons.ResumeLayout(false);
            this.paTopSearch.ResumeLayout(false);
            this.paBottomSearch.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.paSearchGen.ResumeLayout(false);
            this.paSearchGen.PerformLayout();
            this.paInferior.ResumeLayout(false);
            this.paTitulo.ResumeLayout(false);
            this.paCentral.ResumeLayout(false);
            this.paCentral.PerformLayout();
            this.paSuperior.ResumeLayout(false);
            this.paSuperior.PerformLayout();
            this.thePanelTab1.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbClientRuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientDomicile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIdCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTypeCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBusinessName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;        
        private DevExpress.XtraEditors.TextEdit tbIdCompany;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit tbClientDomicile;
        private DevExpress.XtraEditors.TextEdit tbClientPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit tbClientEmail;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit tbClientRuc;
        private DevExpress.XtraEditors.LookUpEdit cbTypeCompany;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit tbBusinessName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}