namespace LimsProject
{
    partial class FormConditions
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
            this.gcConditions = new DevExpress.XtraGrid.GridControl();
            this.gvConditions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCol_Idcs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Idtemplate_method = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Idtsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Name_cs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Matchsample = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Test = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Idcondition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Value1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Value2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Msgok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Msgerror = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Frec_by_batch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Frec_by_samples = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCondition = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btOk = new DevExpress.XtraEditors.SimpleButton();
            this.btCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.tbMsgIntervalo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMsgFrecuencia = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).BeginInit();
            this.paTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).BeginInit();
            this.paBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.paCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            this.paTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcConditions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConditions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMsgIntervalo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMsgFrecuencia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Size = new System.Drawing.Size(1011, 39);
            // 
            // paTitle
            // 
            this.paTitle.Size = new System.Drawing.Size(1015, 43);
            this.paTitle.Visible = false;
            // 
            // paBottom
            // 
            this.paBottom.Controls.Add(this.btCancelar);
            this.paBottom.Controls.Add(this.btOk);
            this.paBottom.Location = new System.Drawing.Point(0, 406);
            this.paBottom.Size = new System.Drawing.Size(1015, 40);
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.gcConditions);
            this.paCenter.Location = new System.Drawing.Point(0, 112);
            this.paCenter.Size = new System.Drawing.Size(1015, 294);
            // 
            // paTop
            // 
            this.paTop.Controls.Add(this.label2);
            this.paTop.Controls.Add(this.label1);
            this.paTop.Controls.Add(this.tbMsgFrecuencia);
            this.paTop.Controls.Add(this.tbMsgIntervalo);
            this.paTop.Size = new System.Drawing.Size(1015, 55);
            this.paTop.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(1015, 14);
            this.panelControl1.Visible = false;
            // 
            // gcConditions
            // 
            this.gcConditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcConditions.EmbeddedNavigator.Name = "";
            this.gcConditions.Location = new System.Drawing.Point(2, 2);
            this.gcConditions.MainView = this.gvConditions;
            this.gcConditions.Margin = new System.Windows.Forms.Padding(10);
            this.gcConditions.Name = "gcConditions";
            this.gcConditions.Padding = new System.Windows.Forms.Padding(10);
            this.gcConditions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCondition});
            this.gcConditions.Size = new System.Drawing.Size(1011, 290);
            this.gcConditions.TabIndex = 0;
            this.gcConditions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvConditions});
            // 
            // gvConditions
            // 
            this.gvConditions.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvConditions.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvConditions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcCol_Idcs,
            this.gcCol_Idtemplate_method,
            this.gcCol_Idtsc,
            this.gcCol_Name_cs,
            this.gcCol_Description,
            this.gcCol_Matchsample,
            this.gcCol_Test,
            this.gcCol_Idcondition,
            this.gcCol_Value1,
            this.gcCol_Value2,
            this.gcCol_Msgok,
            this.gcCol_Msgerror,
            this.gcCol_Frec_by_batch,
            this.gcCol_Frec_by_samples});
            this.gvConditions.GridControl = this.gcConditions;
            this.gvConditions.Name = "gvConditions";
            this.gvConditions.OptionsView.ColumnAutoWidth = false;
            this.gvConditions.OptionsView.RowAutoHeight = true;
            this.gvConditions.OptionsView.ShowGroupPanel = false;
            // 
            // gcCol_Idcs
            // 
            this.gcCol_Idcs.Caption = "Idcs";
            this.gcCol_Idcs.FieldName = "Idcs";
            this.gcCol_Idcs.Name = "gcCol_Idcs";
            // 
            // gcCol_Idtemplate_method
            // 
            this.gcCol_Idtemplate_method.Caption = "Idtemplate_method";
            this.gcCol_Idtemplate_method.FieldName = "Idtemplate_method";
            this.gcCol_Idtemplate_method.Name = "gcCol_Idtemplate_method";
            // 
            // gcCol_Idtsc
            // 
            this.gcCol_Idtsc.Caption = "Idtsc";
            this.gcCol_Idtsc.FieldName = "Idtsc";
            this.gcCol_Idtsc.Name = "gcCol_Idtsc";
            // 
            // gcCol_Name_cs
            // 
            this.gcCol_Name_cs.Caption = "Name_cs";
            this.gcCol_Name_cs.FieldName = "Name_cs";
            this.gcCol_Name_cs.Name = "gcCol_Name_cs";
            // 
            // gcCol_Description
            // 
            this.gcCol_Description.Caption = "Description";
            this.gcCol_Description.FieldName = "Description";
            this.gcCol_Description.Name = "gcCol_Description";
            // 
            // gcCol_Matchsample
            // 
            this.gcCol_Matchsample.Caption = "Filtrar por";
            this.gcCol_Matchsample.FieldName = "Matchsample";
            this.gcCol_Matchsample.Name = "gcCol_Matchsample";
            this.gcCol_Matchsample.Visible = true;
            this.gcCol_Matchsample.VisibleIndex = 0;
            this.gcCol_Matchsample.Width = 134;
            // 
            // gcCol_Test
            // 
            this.gcCol_Test.Caption = "Prueba de lectura";
            this.gcCol_Test.FieldName = "Test";
            this.gcCol_Test.Name = "gcCol_Test";
            this.gcCol_Test.Visible = true;
            this.gcCol_Test.VisibleIndex = 1;
            this.gcCol_Test.Width = 174;
            // 
            // gcCol_Idcondition
            // 
            this.gcCol_Idcondition.Caption = "Condición";
            this.gcCol_Idcondition.FieldName = "Idcondition";
            this.gcCol_Idcondition.Name = "gcCol_Idcondition";
            this.gcCol_Idcondition.Visible = true;
            this.gcCol_Idcondition.VisibleIndex = 2;
            // 
            // gcCol_Value1
            // 
            this.gcCol_Value1.Caption = "Value1";
            this.gcCol_Value1.FieldName = "Value1";
            this.gcCol_Value1.Name = "gcCol_Value1";
            this.gcCol_Value1.Visible = true;
            this.gcCol_Value1.VisibleIndex = 3;
            this.gcCol_Value1.Width = 73;
            // 
            // gcCol_Value2
            // 
            this.gcCol_Value2.Caption = "Value2";
            this.gcCol_Value2.FieldName = "Value2";
            this.gcCol_Value2.Name = "gcCol_Value2";
            this.gcCol_Value2.Visible = true;
            this.gcCol_Value2.VisibleIndex = 4;
            this.gcCol_Value2.Width = 73;
            // 
            // gcCol_Msgok
            // 
            this.gcCol_Msgok.AppearanceHeader.Options.UseTextOptions = true;
            this.gcCol_Msgok.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcCol_Msgok.Caption = "Mensaje - Ok";
            this.gcCol_Msgok.FieldName = "Msgok";
            this.gcCol_Msgok.Name = "gcCol_Msgok";
            this.gcCol_Msgok.Visible = true;
            this.gcCol_Msgok.VisibleIndex = 6;
            this.gcCol_Msgok.Width = 73;
            // 
            // gcCol_Msgerror
            // 
            this.gcCol_Msgerror.Caption = "Mensaje - Error";
            this.gcCol_Msgerror.FieldName = "Msgerror";
            this.gcCol_Msgerror.Name = "gcCol_Msgerror";
            this.gcCol_Msgerror.Visible = true;
            this.gcCol_Msgerror.VisibleIndex = 7;
            this.gcCol_Msgerror.Width = 73;
            // 
            // gcCol_Frec_by_batch
            // 
            this.gcCol_Frec_by_batch.AppearanceHeader.Options.UseTextOptions = true;
            this.gcCol_Frec_by_batch.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gcCol_Frec_by_batch.Caption = "Frec. por Bandeja";
            this.gcCol_Frec_by_batch.FieldName = "Frec_by_batch";
            this.gcCol_Frec_by_batch.Name = "gcCol_Frec_by_batch";
            this.gcCol_Frec_by_batch.Visible = true;
            this.gcCol_Frec_by_batch.VisibleIndex = 8;
            this.gcCol_Frec_by_batch.Width = 73;
            // 
            // gcCol_Frec_by_samples
            // 
            this.gcCol_Frec_by_samples.Caption = "Frec. por Muestra";
            this.gcCol_Frec_by_samples.FieldName = "Frec_by_samples";
            this.gcCol_Frec_by_samples.Name = "gcCol_Frec_by_samples";
            this.gcCol_Frec_by_samples.Visible = true;
            this.gcCol_Frec_by_samples.VisibleIndex = 9;
            this.gcCol_Frec_by_samples.Width = 85;
            // 
            // repCondition
            // 
            this.repCondition.AutoHeight = false;
            this.repCondition.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCondition.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idcriterio", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre_criterio")});
            this.repCondition.Name = "repCondition";
            this.repCondition.ShowFooter = false;
            this.repCondition.ShowHeader = false;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(6, 7);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(44, 23);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "Ok";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(56, 7);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(77, 23);
            this.btCancelar.TabIndex = 0;
            this.btCancelar.Text = "Cancelar";
            // 
            // tbMsgIntervalo
            // 
            this.tbMsgIntervalo.Location = new System.Drawing.Point(141, 5);
            this.tbMsgIntervalo.Name = "tbMsgIntervalo";
            this.tbMsgIntervalo.Size = new System.Drawing.Size(282, 20);
            this.tbMsgIntervalo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mensaje de Intervalo:";
            // 
            // tbMsgFrecuencia
            // 
            this.tbMsgFrecuencia.Location = new System.Drawing.Point(141, 28);
            this.tbMsgFrecuencia.Name = "tbMsgFrecuencia";
            this.tbMsgFrecuencia.Size = new System.Drawing.Size(282, 20);
            this.tbMsgFrecuencia.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mensaje de Frecuencia:";
            // 
            // FormConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 446);
            this.Name = "FormConditions";
            this.Text = "FormConditions";
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).EndInit();
            this.paTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            this.paBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            this.paTop.ResumeLayout(false);
            this.paTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcConditions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConditions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMsgIntervalo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMsgFrecuencia.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcConditions;
        private DevExpress.XtraGrid.Views.Grid.GridView gvConditions;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Idcs;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Idtemplate_method;
        private DevExpress.XtraEditors.SimpleButton btCancelar;
        private DevExpress.XtraEditors.SimpleButton btOk;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Name_cs;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Description;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Matchsample;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Test;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Value1;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Value2;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Msgok;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Msgerror;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Frec_by_batch;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Frec_by_samples;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Idtsc;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Idcondition;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCondition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit tbMsgFrecuencia;
        private DevExpress.XtraEditors.TextEdit tbMsgIntervalo;
    }
}