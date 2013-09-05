namespace LimsProject
{
    partial class FormCfgRepetition
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
            this.tbRepetitions = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.paInferior.SuspendLayout();
            this.paTitulo.SuspendLayout();
            this.paCentral.SuspendLayout();
            this.thePanelTab1.SuspendLayout();
            this.tpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRepetitions.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // paInferior
            // 
            this.paInferior.Controls.Add(this.button2);
            this.paInferior.Controls.Add(this.button1);
            this.paInferior.Location = new System.Drawing.Point(3, 150);
            this.paInferior.Size = new System.Drawing.Size(253, 39);
            // 
            // paTitulo
            // 
            this.paTitulo.Size = new System.Drawing.Size(253, 37);
            // 
            // paCentral
            // 
            this.paCentral.Controls.Add(this.label1);
            this.paCentral.Controls.Add(this.tbRepetitions);
            this.paCentral.Size = new System.Drawing.Size(253, 76);
            // 
            // paSupBotones
            // 
            this.paSupBotones.Size = new System.Drawing.Size(267, 25);
            this.paSupBotones.Visible = false;
            // 
            // paSuperior
            // 
            this.paSuperior.Size = new System.Drawing.Size(253, 34);
            this.paSuperior.Visible = false;
            // 
            // laTitulo
            // 
            this.laTitulo.Size = new System.Drawing.Size(253, 37);
            this.laTitulo.Text = "Configurar % de Repeticiones";
            // 
            // thePanelTab1
            // 
            this.thePanelTab1.Size = new System.Drawing.Size(267, 221);
            // 
            // tpDatos
            // 
            this.tpDatos.Size = new System.Drawing.Size(259, 192);
            // 
            // tbRepetitions
            // 
            this.tbRepetitions.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbRepetitions.Location = new System.Drawing.Point(116, 26);
            this.tbRepetitions.Name = "tbRepetitions";
            this.tbRepetitions.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbRepetitions.Size = new System.Drawing.Size(100, 20);
            this.tbRepetitions.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Repeticiones:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(15, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(96, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormCfgRepetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 246);
            this.Name = "FormCfgRepetition";
            this.Text = "% de Repeticiones";
            this.paInferior.ResumeLayout(false);
            this.paTitulo.ResumeLayout(false);
            this.paCentral.ResumeLayout(false);
            this.paCentral.PerformLayout();
            this.thePanelTab1.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbRepetitions.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit tbRepetitions;
    }
}