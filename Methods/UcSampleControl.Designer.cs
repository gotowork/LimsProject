namespace LimsProject
{
    partial class UcSampleControl
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
            this.gcCSCol_Name_value_prefijo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gcCSCol_Value1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repAmount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gcCSCol_Name_value_sufijo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gcCSCol_Idtemplate_method_icp_control = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gcCSCol_Idtype_sample_control = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
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
            this.gcSampleControl.Size = new System.Drawing.Size(350, 203);
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
            this.gcCSCol_Idtemplate_method_icp_control,
            this.gcCSCol_Idtype_sample_control,
            this.gcCSCol_Name_value_prefijo,
            this.gcCSCol_Value1,
            this.gcCSCol_Name_value_sufijo});
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
            this.gridBand2.Caption = "Intervalo de Control";
            this.gridBand2.Columns.Add(this.gcCSCol_Idtype_sample_control);
            this.gridBand2.Columns.Add(this.gcCSCol_Name_value_prefijo);
            this.gridBand2.Columns.Add(this.gcCSCol_Value1);
            this.gridBand2.Columns.Add(this.gcCSCol_Name_value_sufijo);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 293;
            // 
            // gcCSCol_Name_value_prefijo
            // 
            this.gcCSCol_Name_value_prefijo.FieldName = "Name_value_prefijo";
            this.gcCSCol_Name_value_prefijo.Name = "gcCSCol_Name_value_prefijo";
            this.gcCSCol_Name_value_prefijo.OptionsColumn.AllowEdit = false;
            this.gcCSCol_Name_value_prefijo.Visible = true;
            this.gcCSCol_Name_value_prefijo.Width = 62;
            // 
            // gcCSCol_Value1
            // 
            this.gcCSCol_Value1.Caption = "Control";
            this.gcCSCol_Value1.ColumnEdit = this.repAmount;
            this.gcCSCol_Value1.FieldName = "Value1";
            this.gcCSCol_Value1.Name = "gcCSCol_Value1";
            this.gcCSCol_Value1.OptionsFilter.AllowFilter = false;
            this.gcCSCol_Value1.Visible = true;
            this.gcCSCol_Value1.Width = 59;
            // 
            // repAmount
            // 
            this.repAmount.AutoHeight = false;
            this.repAmount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repAmount.Name = "repAmount";
            // 
            // gcCSCol_Name_value_sufijo
            // 
            this.gcCSCol_Name_value_sufijo.FieldName = "Name_value_sufijo";
            this.gcCSCol_Name_value_sufijo.Name = "gcCSCol_Name_value_sufijo";
            this.gcCSCol_Name_value_sufijo.OptionsColumn.AllowEdit = false;
            this.gcCSCol_Name_value_sufijo.Visible = true;
            this.gcCSCol_Name_value_sufijo.Width = 107;
            // 
            // gcCSCol_Idtemplate_method_icp_control
            // 
            this.gcCSCol_Idtemplate_method_icp_control.Caption = "Idtemplate_method_icp_control";
            this.gcCSCol_Idtemplate_method_icp_control.FieldName = "Idcontrol_sample";
            this.gcCSCol_Idtemplate_method_icp_control.Name = "gcCSCol_Idtemplate_method_icp_control";
            this.gcCSCol_Idtemplate_method_icp_control.Width = 57;
            // 
            // gcCSCol_Idtype_sample_control
            // 
            this.gcCSCol_Idtype_sample_control.Caption = "Muestra";
            this.gcCSCol_Idtype_sample_control.ColumnEdit = this.repType_sample_control;
            this.gcCSCol_Idtype_sample_control.FieldName = "Idtype_sample_control";
            this.gcCSCol_Idtype_sample_control.Name = "gcCSCol_Idtype_sample_control";
            this.gcCSCol_Idtype_sample_control.OptionsColumn.AllowEdit = false;
            this.gcCSCol_Idtype_sample_control.Visible = true;
            this.gcCSCol_Idtype_sample_control.Width = 65;
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
            // UcSampleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcSampleControl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcSampleControl";
            this.Size = new System.Drawing.Size(350, 203);
            ((System.ComponentModel.ISupportInitialize)(this.gcSampleControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSampleControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repType_sample_control)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcSampleControl;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gvSampleControl;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gcCSCol_Idtemplate_method_icp_control;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gcCSCol_Idtype_sample_control;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repType_sample_control;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gcCSCol_Name_value_prefijo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gcCSCol_Value1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gcCSCol_Name_value_sufijo;
    }
}
