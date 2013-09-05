namespace LimsProject
{
    partial class FormMethodSaveAs
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
            this.tbCod_method = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTitle = new DevExpress.XtraEditors.TextEdit();
            this.gcMethods = new DevExpress.XtraGrid.GridControl();
            this.gvMethods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMet_Cod_template_method = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMet_Abbreviation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMet_Title = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            this.paTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.paCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCod_method.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMethods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMethods)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(0, 256);
            this.panelControl1.Size = new System.Drawing.Size(478, 34);
            this.panelControl1.TabIndex = 2;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(47, 5);
            this.btCancel.Size = new System.Drawing.Size(62, 23);
            // 
            // btOk
            // 
            this.btOk.Size = new System.Drawing.Size(36, 23);
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // paTop
            // 
            this.paTop.Size = new System.Drawing.Size(478, 44);
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.gcMethods);
            this.paCenter.Controls.Add(this.label2);
            this.paCenter.Controls.Add(this.label1);
            this.paCenter.Controls.Add(this.tbTitle);
            this.paCenter.Controls.Add(this.tbCod_method);
            this.paCenter.Size = new System.Drawing.Size(478, 212);
            this.paCenter.TabIndex = 1;
            // 
            // laTitle
            // 
            this.laTitle.Size = new System.Drawing.Size(474, 40);
            this.laTitle.Text = "Ingresar Nombre del Método";
            // 
            // tbCod_method
            // 
            this.tbCod_method.Location = new System.Drawing.Point(61, 8);
            this.tbCod_method.Name = "tbCod_method";
            this.tbCod_method.Size = new System.Drawing.Size(76, 20);
            this.tbCod_method.TabIndex = 0;
            this.tbCod_method.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.tbCod_method_InvalidValue);
            this.tbCod_method.Validating += new System.ComponentModel.CancelEventHandler(this.tbCod_method_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(61, 29);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(405, 20);
            this.tbTitle.TabIndex = 1;
            // 
            // gcMethods
            // 
            this.gcMethods.EmbeddedNavigator.Name = "";
            this.gcMethods.Location = new System.Drawing.Point(12, 55);
            this.gcMethods.MainView = this.gvMethods;
            this.gcMethods.Name = "gcMethods";
            this.gcMethods.Size = new System.Drawing.Size(454, 151);
            this.gcMethods.TabIndex = 2;
            this.gcMethods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMethods});
            // 
            // gvMethods
            // 
            this.gvMethods.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMet_Cod_template_method,
            this.gcMet_Abbreviation,
            this.gcMet_Title});
            this.gvMethods.GridControl = this.gcMethods;
            this.gvMethods.Name = "gvMethods";
            this.gvMethods.OptionsView.ShowGroupPanel = false;
            // 
            // gcMet_Cod_template_method
            // 
            this.gcMet_Cod_template_method.Caption = "Código";
            this.gcMet_Cod_template_method.FieldName = "Cod_template_method";
            this.gcMet_Cod_template_method.Name = "gcMet_Cod_template_method";
            this.gcMet_Cod_template_method.Visible = true;
            this.gcMet_Cod_template_method.VisibleIndex = 0;
            this.gcMet_Cod_template_method.Width = 48;
            // 
            // gcMet_Abbreviation
            // 
            this.gcMet_Abbreviation.Caption = "Abreviatura";
            this.gcMet_Abbreviation.FieldName = "Abbreviation";
            this.gcMet_Abbreviation.Name = "gcMet_Abbreviation";
            this.gcMet_Abbreviation.Visible = true;
            this.gcMet_Abbreviation.VisibleIndex = 1;
            this.gcMet_Abbreviation.Width = 69;
            // 
            // gcMet_Title
            // 
            this.gcMet_Title.Caption = "Título";
            this.gcMet_Title.FieldName = "Title";
            this.gcMet_Title.Name = "gcMet_Title";
            this.gcMet_Title.Visible = true;
            this.gcMet_Title.VisibleIndex = 2;
            this.gcMet_Title.Width = 316;
            // 
            // FormMethodSaveAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 290);
            this.Name = "FormMethodSaveAs";
            this.ShowInTaskbar = false;
            this.Text = "Ingresar Nombre del Método";
            this.Load += new System.EventHandler(this.FormMethodSaveAs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            this.paTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            this.paCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCod_method.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMethods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMethods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tbCod_method;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcMethods;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMethods;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit tbTitle;
        private DevExpress.XtraGrid.Columns.GridColumn gcMet_Cod_template_method;
        private DevExpress.XtraGrid.Columns.GridColumn gcMet_Title;
        private DevExpress.XtraGrid.Columns.GridColumn gcMet_Abbreviation;
    }
}