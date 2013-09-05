namespace LimsProject
{
    partial class FormAssignMassive
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
            this.tbNamePart1 = new DevExpress.XtraEditors.TextEdit();
            this.tbNamePart2 = new DevExpress.XtraEditors.TextEdit();
            this.tbNamePart3 = new DevExpress.XtraEditors.TextEdit();
            this.ckSamplePart1 = new DevExpress.XtraEditors.CheckEdit();
            this.tbNdPart1 = new DevExpress.XtraEditors.SpinEdit();
            this.tbNdPart2 = new DevExpress.XtraEditors.SpinEdit();
            this.tbNdPart3 = new DevExpress.XtraEditors.SpinEdit();
            this.ckSamplePart2 = new DevExpress.XtraEditors.CheckEdit();
            this.ckSamplePart3 = new DevExpress.XtraEditors.CheckEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.laPreviewName = new System.Windows.Forms.Label();
            this.ckAddSamples = new DevExpress.XtraEditors.CheckEdit();
            this.tbNumSamples = new DevExpress.XtraEditors.SpinEdit();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            this.paTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.paCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNamePart1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNamePart2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNamePart3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckSamplePart1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNdPart1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNdPart2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNdPart3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckSamplePart2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckSamplePart3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckAddSamples.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumSamples.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 226);
            this.panelControl1.Size = new System.Drawing.Size(310, 34);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(56, 5);
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btOk.Location = new System.Drawing.Point(9, 5);
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // paTop
            // 
            this.paTop.Size = new System.Drawing.Size(310, 37);
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.tbNumSamples);
            this.paCenter.Controls.Add(this.ckAddSamples);
            this.paCenter.Controls.Add(this.label3);
            this.paCenter.Controls.Add(this.laPreviewName);
            this.paCenter.Controls.Add(this.label4);
            this.paCenter.Controls.Add(this.label2);
            this.paCenter.Controls.Add(this.label1);
            this.paCenter.Controls.Add(this.tbNdPart3);
            this.paCenter.Controls.Add(this.tbNdPart2);
            this.paCenter.Controls.Add(this.tbNdPart1);
            this.paCenter.Controls.Add(this.ckSamplePart3);
            this.paCenter.Controls.Add(this.ckSamplePart2);
            this.paCenter.Controls.Add(this.ckSamplePart1);
            this.paCenter.Controls.Add(this.tbNamePart3);
            this.paCenter.Controls.Add(this.tbNamePart2);
            this.paCenter.Controls.Add(this.tbNamePart1);
            this.paCenter.Location = new System.Drawing.Point(0, 37);
            this.paCenter.Size = new System.Drawing.Size(310, 189);
            // 
            // laTitle
            // 
            this.laTitle.Padding = new System.Windows.Forms.Padding(6, 5, 0, 0);
            this.laTitle.Size = new System.Drawing.Size(306, 33);
            this.laTitle.Text = "Autogenerar Nombre de Muestra";
            // 
            // tbNamePart1
            // 
            this.tbNamePart1.EditValue = "";
            this.tbNamePart1.Location = new System.Drawing.Point(89, 40);
            this.tbNamePart1.Name = "tbNamePart1";
            this.tbNamePart1.Properties.Appearance.Options.UseTextOptions = true;
            this.tbNamePart1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tbNamePart1.Size = new System.Drawing.Size(61, 20);
            this.tbNamePart1.TabIndex = 0;
            this.tbNamePart1.EditValueChanged += new System.EventHandler(this.tbNamePart1_EditValueChanged);
            // 
            // tbNamePart2
            // 
            this.tbNamePart2.Location = new System.Drawing.Point(156, 40);
            this.tbNamePart2.Name = "tbNamePart2";
            this.tbNamePart2.Properties.Appearance.Options.UseTextOptions = true;
            this.tbNamePart2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tbNamePart2.Size = new System.Drawing.Size(61, 20);
            this.tbNamePart2.TabIndex = 0;
            this.tbNamePart2.EditValueChanged += new System.EventHandler(this.tbNamePart2_EditValueChanged);
            // 
            // tbNamePart3
            // 
            this.tbNamePart3.EditValue = "01";
            this.tbNamePart3.Enabled = false;
            this.tbNamePart3.Location = new System.Drawing.Point(223, 40);
            this.tbNamePart3.Name = "tbNamePart3";
            this.tbNamePart3.Properties.Appearance.Options.UseTextOptions = true;
            this.tbNamePart3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tbNamePart3.Size = new System.Drawing.Size(61, 20);
            this.tbNamePart3.TabIndex = 0;
            this.tbNamePart3.EditValueChanged += new System.EventHandler(this.tbNamePart3_EditValueChanged);
            // 
            // ckSamplePart1
            // 
            this.ckSamplePart1.Location = new System.Drawing.Point(111, 64);
            this.ckSamplePart1.Name = "ckSamplePart1";
            this.ckSamplePart1.Properties.Caption = "";
            this.ckSamplePart1.Size = new System.Drawing.Size(26, 19);
            this.ckSamplePart1.TabIndex = 1;
            this.ckSamplePart1.CheckedChanged += new System.EventHandler(this.ckSamplePart1_CheckedChanged);
            // 
            // tbNdPart1
            // 
            this.tbNdPart1.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.tbNdPart1.Enabled = false;
            this.tbNdPart1.Location = new System.Drawing.Point(89, 89);
            this.tbNdPart1.Name = "tbNdPart1";
            this.tbNdPart1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbNdPart1.Properties.IsFloatValue = false;
            this.tbNdPart1.Properties.Mask.EditMask = "N00";
            this.tbNdPart1.Properties.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbNdPart1.Properties.MinValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.tbNdPart1.Size = new System.Drawing.Size(61, 20);
            this.tbNdPart1.TabIndex = 2;
            this.tbNdPart1.EditValueChanged += new System.EventHandler(this.tbNdPart1_EditValueChanged);
            // 
            // tbNdPart2
            // 
            this.tbNdPart2.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.tbNdPart2.Enabled = false;
            this.tbNdPart2.Location = new System.Drawing.Point(156, 89);
            this.tbNdPart2.Name = "tbNdPart2";
            this.tbNdPart2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbNdPart2.Properties.IsFloatValue = false;
            this.tbNdPart2.Properties.Mask.EditMask = "N00";
            this.tbNdPart2.Properties.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbNdPart2.Properties.MinValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.tbNdPart2.Size = new System.Drawing.Size(61, 20);
            this.tbNdPart2.TabIndex = 2;
            this.tbNdPart2.EditValueChanged += new System.EventHandler(this.tbNdPart2_EditValueChanged);
            // 
            // tbNdPart3
            // 
            this.tbNdPart3.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.tbNdPart3.Location = new System.Drawing.Point(223, 89);
            this.tbNdPart3.Name = "tbNdPart3";
            this.tbNdPart3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbNdPart3.Properties.IsFloatValue = false;
            this.tbNdPart3.Properties.Mask.EditMask = "N00";
            this.tbNdPart3.Properties.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbNdPart3.Properties.MinValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.tbNdPart3.Size = new System.Drawing.Size(61, 20);
            this.tbNdPart3.TabIndex = 2;
            this.tbNdPart3.EditValueChanged += new System.EventHandler(this.tbNdPart3_EditValueChanged);
            // 
            // ckSamplePart2
            // 
            this.ckSamplePart2.Location = new System.Drawing.Point(177, 64);
            this.ckSamplePart2.Name = "ckSamplePart2";
            this.ckSamplePart2.Properties.Caption = "";
            this.ckSamplePart2.Size = new System.Drawing.Size(26, 19);
            this.ckSamplePart2.TabIndex = 1;
            this.ckSamplePart2.CheckedChanged += new System.EventHandler(this.ckSamplePart2_CheckedChanged);
            // 
            // ckSamplePart3
            // 
            this.ckSamplePart3.EditValue = true;
            this.ckSamplePart3.Location = new System.Drawing.Point(243, 64);
            this.ckSamplePart3.Name = "ckSamplePart3";
            this.ckSamplePart3.Properties.Caption = "";
            this.ckSamplePart3.Size = new System.Drawing.Size(26, 19);
            this.ckSamplePart3.TabIndex = 1;
            this.ckSamplePart3.CheckedChanged += new System.EventHandler(this.ckSamplePart3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Correlativo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "N°Dígitos";
            // 
            // laPreviewName
            // 
            this.laPreviewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPreviewName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laPreviewName.Location = new System.Drawing.Point(24, 9);
            this.laPreviewName.Name = "laPreviewName";
            this.laPreviewName.Size = new System.Drawing.Size(260, 24);
            this.laPreviewName.TabIndex = 3;
            this.laPreviewName.Text = "01";
            this.laPreviewName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckAddSamples
            // 
            this.ckAddSamples.EditValue = true;
            this.ckAddSamples.Location = new System.Drawing.Point(24, 115);
            this.ckAddSamples.Name = "ckAddSamples";
            this.ckAddSamples.Properties.Caption = "Agregar a las muestras existentes.";
            this.ckAddSamples.Size = new System.Drawing.Size(203, 19);
            this.ckAddSamples.TabIndex = 4;
            // 
            // tbNumSamples
            // 
            this.tbNumSamples.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbNumSamples.Location = new System.Drawing.Point(111, 155);
            this.tbNumSamples.Name = "tbNumSamples";
            this.tbNumSamples.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tbNumSamples.Properties.Appearance.Options.UseFont = true;
            this.tbNumSamples.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbNumSamples.Properties.IsFloatValue = false;
            this.tbNumSamples.Properties.Mask.EditMask = "N00";
            this.tbNumSamples.Size = new System.Drawing.Size(61, 20);
            this.tbNumSamples.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "N° Muestras:";
            // 
            // FormAssignMassive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 260);
            this.Name = "FormAssignMassive";
            this.ShowInTaskbar = false;
            this.Text = "Autogenerar Nombre de Muestra";
            this.Load += new System.EventHandler(this.FormAssignMassive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            this.paTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            this.paCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNamePart1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNamePart2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNamePart3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckSamplePart1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNdPart1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNdPart2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNdPart3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckSamplePart2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckSamplePart3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckAddSamples.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumSamples.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit tbNdPart3;
        private DevExpress.XtraEditors.SpinEdit tbNdPart2;
        private DevExpress.XtraEditors.SpinEdit tbNdPart1;
        private DevExpress.XtraEditors.CheckEdit ckSamplePart3;
        private DevExpress.XtraEditors.CheckEdit ckSamplePart2;
        private DevExpress.XtraEditors.CheckEdit ckSamplePart1;
        private DevExpress.XtraEditors.TextEdit tbNamePart3;
        private DevExpress.XtraEditors.TextEdit tbNamePart2;
        private DevExpress.XtraEditors.TextEdit tbNamePart1;
        private System.Windows.Forms.Label laPreviewName;
        private DevExpress.XtraEditors.CheckEdit ckAddSamples;
        private DevExpress.XtraEditors.SpinEdit tbNumSamples;
        private System.Windows.Forms.Label label4;


    }
}