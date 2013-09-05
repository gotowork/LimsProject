namespace LimsProject
{
    partial class UcSampleFrequency
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
            this.gcSampleControl = new DevExpress.XtraGrid.GridControl();
            this.gvSampleControl = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gcCol_Name_frec_prefijo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gcCol_Frecuency = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repAmount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gcCol_Name_frec_sufijo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gcCol_Idtemplate_method_icp_control = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gcCol_Idtype_sample_control = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repType_sample_control = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSampleControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSampleControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repType_sample_control)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSampleControl
            // 
            this.gcSampleControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSampleControl.EmbeddedNavigator.Name = "";
            this.gcSampleControl.Location = new System.Drawing.Point(0, 0);
            this.gcSampleControl.MainView = this.gvSampleControl;
            this.gcSampleControl.Name = "gcSampleControl";
            this.gcSampleControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repType_sample_control,
            this.repAmount});
            this.gcSampleControl.Size = new System.Drawing.Size(315, 203);
            this.gcSampleControl.TabIndex = 1;
            this.gcSampleControl.UseEmbeddedNavigator = true;
            this.gcSampleControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSampleControl});
            // 
            // gvSampleControl
            // 
            this.gvSampleControl.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2});
            this.gvSampleControl.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.gcCol_Idtemplate_method_icp_control,
            this.gcCol_Idtype_sample_control,
            this.gcCol_Name_frec_prefijo,
            this.gcCol_Frecuency,
            this.gcCol_Name_frec_sufijo});
            this.gvSampleControl.GridControl = this.gcSampleControl;
            this.gvSampleControl.Name = "gvSampleControl";
            this.gvSampleControl.OptionsView.ShowColumnHeaders = false;
            this.gvSampleControl.OptionsView.ShowGroupPanel = false;
            this.gvSampleControl.OptionsView.ShowHorzLines = false;
            this.gvSampleControl.OptionsView.ShowIndicator = false;
            this.gvSampleControl.OptionsView.ShowVertLines = false;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Frecuencia";
            this.gridBand2.Columns.Add(this.gcCol_Idtype_sample_control);
            this.gridBand2.Columns.Add(this.gcCol_Name_frec_prefijo);
            this.gridBand2.Columns.Add(this.gcCol_Frecuency);
            this.gridBand2.Columns.Add(this.gcCol_Name_frec_sufijo);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 293;
            // 
            // gcCol_Name_frec_prefijo
            // 
            this.gcCol_Name_frec_prefijo.Caption = "Name_frec_prefijo";
            this.gcCol_Name_frec_prefijo.FieldName = "Name_frec_prefijo";
            this.gcCol_Name_frec_prefijo.Name = "gcCol_Name_frec_prefijo";
            this.gcCol_Name_frec_prefijo.OptionsColumn.AllowEdit = false;
            this.gcCol_Name_frec_prefijo.Visible = true;
            this.gcCol_Name_frec_prefijo.Width = 62;
            // 
            // gcCol_Frecuency
            // 
            this.gcCol_Frecuency.Caption = "Control";
            this.gcCol_Frecuency.ColumnEdit = this.repAmount;
            this.gcCol_Frecuency.FieldName = "Frecuency";
            this.gcCol_Frecuency.Name = "gcCol_Frecuency";
            this.gcCol_Frecuency.OptionsFilter.AllowFilter = false;
            this.gcCol_Frecuency.Visible = true;
            this.gcCol_Frecuency.Width = 59;
            // 
            // repAmount
            // 
            this.repAmount.AutoHeight = false;
            this.repAmount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repAmount.Name = "repAmount";
            // 
            // gcCol_Name_frec_sufijo
            // 
            this.gcCol_Name_frec_sufijo.Caption = "name_frec_sufijo";
            this.gcCol_Name_frec_sufijo.FieldName = "Name_frec_sufijo";
            this.gcCol_Name_frec_sufijo.Name = "gcCol_Name_frec_sufijo";
            this.gcCol_Name_frec_sufijo.OptionsColumn.AllowEdit = false;
            this.gcCol_Name_frec_sufijo.Visible = true;
            this.gcCol_Name_frec_sufijo.Width = 107;
            // 
            // gcCol_Idtemplate_method_icp_control
            // 
            this.gcCol_Idtemplate_method_icp_control.Caption = "Idtemplate_method_icp_control";
            this.gcCol_Idtemplate_method_icp_control.FieldName = "Idcontrol_sample_frequency";
            this.gcCol_Idtemplate_method_icp_control.Name = "gcCol_Idtemplate_method_icp_control";
            this.gcCol_Idtemplate_method_icp_control.Width = 57;
            // 
            // gcCol_Idtype_sample_control
            // 
            this.gcCol_Idtype_sample_control.Caption = "Muestra";
            this.gcCol_Idtype_sample_control.ColumnEdit = this.repType_sample_control;
            this.gcCol_Idtype_sample_control.FieldName = "Idtype_sample_control";
            this.gcCol_Idtype_sample_control.Name = "gcCol_Idtype_sample_control";
            this.gcCol_Idtype_sample_control.OptionsColumn.AllowEdit = false;
            this.gcCol_Idtype_sample_control.Visible = true;
            this.gcCol_Idtype_sample_control.Width = 65;
            // 
            // repType_sample_control
            // 
            this.repType_sample_control.AutoHeight = false;
            this.repType_sample_control.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repType_sample_control.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idtype_sample_control", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nametsc")});
            this.repType_sample_control.Name = "repType_sample_control";
            this.repType_sample_control.NullText = "";
            this.repType_sample_control.ShowFooter = false;
            this.repType_sample_control.ShowHeader = false;
            // 
            // UcSampleFrequency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcSampleControl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcSampleFrequency";
            this.Size = new System.Drawing.Size(315, 203);
            ((System.ComponentModel.ISupportInitialize)(this.gcSampleControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSampleControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repType_sample_control)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcSampleControl;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gvSampleControl;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gcCol_Idtemplate_method_icp_control;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gcCol_Idtype_sample_control;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repType_sample_control;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gcCol_Name_frec_prefijo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gcCol_Frecuency;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gcCol_Name_frec_sufijo;
    }
}
