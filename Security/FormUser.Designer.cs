namespace LimsProject
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.tbPwd = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRepPwd = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPersonName = new DevExpress.XtraEditors.TextEdit();
            this.tbUserName = new DevExpress.XtraEditors.TextEdit();
            this.cbPerson = new LimsProject.MyLookUpEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.tbPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRepPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPersonName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPerson.Properties)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(376, 0);
            // 
            // btFiltroBuscar
            // 
            this.btFiltroBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btFiltroBuscar.FlatAppearance.BorderSize = 0;
            // 
            // paInferior
            // 
            this.paInferior.Location = new System.Drawing.Point(3, 179);
            this.paInferior.Size = new System.Drawing.Size(448, 45);
            // 
            // paTitulo
            // 
            this.paTitulo.Size = new System.Drawing.Size(448, 36);
            // 
            // paCentral
            // 
            this.paCentral.Controls.Add(this.tbUserName);
            this.paCentral.Controls.Add(this.label4);
            this.paCentral.Controls.Add(this.tbRepPwd);
            this.paCentral.Controls.Add(this.label6);
            this.paCentral.Controls.Add(this.tbPwd);
            this.paCentral.Controls.Add(this.label5);
            this.paCentral.Size = new System.Drawing.Size(448, 103);
            // 
            // paSupBotones
            // 
            this.paSupBotones.Size = new System.Drawing.Size(462, 32);
            // 
            // paSuperior
            // 
            this.paSuperior.Controls.Add(this.cbPerson);
            this.paSuperior.Controls.Add(this.label7);
            this.paSuperior.Controls.Add(this.tbPersonName);
            this.paSuperior.Size = new System.Drawing.Size(448, 37);
            this.paSuperior.Leave += new System.EventHandler(this.paSuperior_Leave);
            // 
            // laTitulo
            // 
            this.laTitulo.Size = new System.Drawing.Size(364, 36);
            this.laTitulo.Text = "Usuarios";
            // 
            // thePanelTab1
            // 
            this.thePanelTab1.Size = new System.Drawing.Size(462, 256);
            // 
            // tpDatos
            // 
            this.tpDatos.Size = new System.Drawing.Size(454, 227);
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(111, 37);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Properties.PasswordChar = '*';
            this.tbPwd.Size = new System.Drawing.Size(120, 20);
            this.tbPwd.TabIndex = 4;
            this.tbPwd.EditValueChanged += new System.EventHandler(this.tbPwd_EditValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Repetir contraseña:";
            // 
            // tbRepPwd
            // 
            this.tbRepPwd.Location = new System.Drawing.Point(111, 59);
            this.tbRepPwd.Name = "tbRepPwd";
            this.tbRepPwd.Properties.PasswordChar = '*';
            this.tbRepPwd.Size = new System.Drawing.Size(120, 20);
            this.tbRepPwd.TabIndex = 5;
            this.tbRepPwd.EditValueChanged += new System.EventHandler(this.tbRepPwd_EditValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cod. Persona:";
            // 
            // tbPersonName
            // 
            this.tbPersonName.Location = new System.Drawing.Point(208, 9);
            this.tbPersonName.Name = "tbPersonName";
            this.tbPersonName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbPersonName.Properties.Appearance.Options.UseBackColor = true;
            this.tbPersonName.Properties.ReadOnly = true;
            this.tbPersonName.Size = new System.Drawing.Size(222, 20);
            this.tbPersonName.TabIndex = 3;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(111, 15);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(81, 20);
            this.tbUserName.TabIndex = 6;
            // 
            // cbPerson
            // 
            this.cbPerson.Location = new System.Drawing.Point(109, 9);
            this.cbPerson.Name = "cbPerson";
            this.cbPerson.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPerson.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idperson", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Allname")});
            this.cbPerson.Properties.NullText = "";
            this.cbPerson.Properties.PopupWidth = 250;
            this.cbPerson.Properties.ShowFooter = false;
            this.cbPerson.Properties.ShowHeader = false;
            this.cbPerson.Size = new System.Drawing.Size(93, 20);
            this.cbPerson.TabIndex = 2;
            this.cbPerson.EditValueChanged += new System.EventHandler(this.cbPerson_EditValueChanged);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 288);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.FormUser_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.tbPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRepPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPersonName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPerson.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tbPwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit tbRepPwd;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit tbPersonName;
        private MyLookUpEdit cbPerson;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit tbUserName;
    }
}