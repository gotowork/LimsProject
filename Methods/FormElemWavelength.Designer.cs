namespace LimsProject
{
    partial class FormElemWavelength
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
            this.gcElemWavelength = new DevExpress.XtraGrid.GridControl();
            this.gvElemWavelength = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gcol_Element_wavelength = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gcol_Idelement_wavelength = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gcol_Idelement = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gcol_Wavelength = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gcol_Idl_axial = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gcol_Idl_radial = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gcol_Lineality_axial = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gcol_Lineality_radial = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ckElement = new DevExpress.XtraEditors.CheckEdit();
            this.cbElement1 = new LimsProject.cbElement();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).BeginInit();
            this.paTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).BeginInit();
            this.paBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.paCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            this.paTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcElemWavelength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvElemWavelength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckElement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbElement1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Size = new System.Drawing.Size(799, 39);
            // 
            // paTitle
            // 
            this.paTitle.Size = new System.Drawing.Size(803, 43);
            this.paTitle.Visible = false;
            // 
            // paBottom
            // 
            this.paBottom.Controls.Add(this.textEdit1);
            this.paBottom.Location = new System.Drawing.Point(0, 312);
            this.paBottom.Size = new System.Drawing.Size(803, 46);
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.gcElemWavelength);
            this.paCenter.Location = new System.Drawing.Point(0, 92);
            this.paCenter.Size = new System.Drawing.Size(803, 220);
            // 
            // paTop
            // 
            this.paTop.Controls.Add(this.cbElement1);
            this.paTop.Controls.Add(this.ckElement);
            this.paTop.Size = new System.Drawing.Size(803, 35);
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(803, 14);
            // 
            // gcElemWavelength
            // 
            this.gcElemWavelength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcElemWavelength.EmbeddedNavigator.Name = "";
            this.gcElemWavelength.Location = new System.Drawing.Point(2, 2);
            this.gcElemWavelength.MainView = this.gvElemWavelength;
            this.gcElemWavelength.Name = "gcElemWavelength";
            this.gcElemWavelength.Size = new System.Drawing.Size(799, 216);
            this.gcElemWavelength.TabIndex = 0;
            this.gcElemWavelength.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvElemWavelength});
            // 
            // gvElemWavelength
            // 
            this.gvElemWavelength.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand4,
            this.gridBand3});
            this.gvElemWavelength.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.gcol_Idelement_wavelength,
            this.gcol_Idelement,
            this.gcol_Element_wavelength,
            this.gcol_Wavelength,
            this.gcol_Idl_axial,
            this.gcol_Idl_radial,
            this.gcol_Lineality_axial,
            this.gcol_Lineality_radial});
            this.gvElemWavelength.GridControl = this.gcElemWavelength;
            this.gvElemWavelength.Name = "gvElemWavelength";
            this.gvElemWavelength.OptionsView.ShowGroupPanel = false;
            this.gvElemWavelength.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvElemWavelength_RowCellStyle);
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.gcol_Element_wavelength);
            this.gridBand1.Columns.Add(this.gcol_Idelement_wavelength);
            this.gridBand1.Columns.Add(this.gcol_Idelement);
            this.gridBand1.Columns.Add(this.gcol_Wavelength);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 224;
            // 
            // gcol_Element_wavelength
            // 
            this.gcol_Element_wavelength.Caption = "Elem-Longitud";
            this.gcol_Element_wavelength.FieldName = "Element_wavelength";
            this.gcol_Element_wavelength.Name = "gcol_Element_wavelength";
            this.gcol_Element_wavelength.Visible = true;
            // 
            // gcol_Idelement_wavelength
            // 
            this.gcol_Idelement_wavelength.Caption = "Idelement_wavelength";
            this.gcol_Idelement_wavelength.FieldName = "Idelement_wavelength";
            this.gcol_Idelement_wavelength.Name = "gcol_Idelement_wavelength";
            this.gcol_Idelement_wavelength.Visible = true;
            // 
            // gcol_Idelement
            // 
            this.gcol_Idelement.Caption = "Elemento";
            this.gcol_Idelement.FieldName = "Idelement";
            this.gcol_Idelement.Name = "gcol_Idelement";
            this.gcol_Idelement.Visible = true;
            this.gcol_Idelement.Width = 74;
            // 
            // gcol_Wavelength
            // 
            this.gcol_Wavelength.Caption = "Long. Onda";
            this.gcol_Wavelength.FieldName = "Wavelength";
            this.gcol_Wavelength.Name = "gcol_Wavelength";
            this.gcol_Wavelength.Width = 98;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "IDL";
            this.gridBand4.Columns.Add(this.gcol_Idl_axial);
            this.gridBand4.Columns.Add(this.gcol_Idl_radial);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Width = 89;
            // 
            // gcol_Idl_axial
            // 
            this.gcol_Idl_axial.Caption = "Axial";
            this.gcol_Idl_axial.FieldName = "Idl_axial";
            this.gcol_Idl_axial.Name = "gcol_Idl_axial";
            this.gcol_Idl_axial.Visible = true;
            this.gcol_Idl_axial.Width = 44;
            // 
            // gcol_Idl_radial
            // 
            this.gcol_Idl_radial.Caption = "Radial";
            this.gcol_Idl_radial.FieldName = "Idl_radial";
            this.gcol_Idl_radial.Name = "gcol_Idl_radial";
            this.gcol_Idl_radial.Visible = true;
            this.gcol_Idl_radial.Width = 45;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Linealidad";
            this.gridBand3.Columns.Add(this.gcol_Lineality_axial);
            this.gridBand3.Columns.Add(this.gcol_Lineality_radial);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 89;
            // 
            // gcol_Lineality_axial
            // 
            this.gcol_Lineality_axial.Caption = "Axial";
            this.gcol_Lineality_axial.FieldName = "Lineality_axial";
            this.gcol_Lineality_axial.Name = "gcol_Lineality_axial";
            this.gcol_Lineality_axial.Visible = true;
            this.gcol_Lineality_axial.Width = 44;
            // 
            // gcol_Lineality_radial
            // 
            this.gcol_Lineality_radial.Caption = "Radial";
            this.gcol_Lineality_radial.FieldName = "Lineality_radial";
            this.gcol_Lineality_radial.Name = "gcol_Lineality_radial";
            this.gcol_Lineality_radial.Visible = true;
            this.gcol_Lineality_radial.Width = 45;
            // 
            // ckElement
            // 
            this.ckElement.Location = new System.Drawing.Point(13, 7);
            this.ckElement.Name = "ckElement";
            this.ckElement.Properties.Caption = "Elemento";
            this.ckElement.Size = new System.Drawing.Size(75, 18);
            this.ckElement.TabIndex = 3;
            this.ckElement.CheckedChanged += new System.EventHandler(this.ckElement_CheckedChanged);
            // 
            // cbElement1
            // 
            this.cbElement1.Enabled = false;
            this.cbElement1.Location = new System.Drawing.Point(94, 7);
            this.cbElement1.Name = "cbElement1";
            this.cbElement1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbElement1.Properties.NullText = "";
            this.cbElement1.Size = new System.Drawing.Size(133, 20);
            this.cbElement1.TabIndex = 4;
            this.cbElement1.EditValueChanged += new System.EventHandler(this.cbElement1_EditValueChanged);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(35, 14);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // FormElemWavelength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 358);
            this.Name = "FormElemWavelength";
            this.Text = "Longitudes de Onda";
            this.Load += new System.EventHandler(this.FormElemWavelength_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).EndInit();
            this.paTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            this.paBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            this.paTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcElemWavelength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvElemWavelength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckElement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbElement1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcElemWavelength;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gvElemWavelength;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gcol_Idelement_wavelength;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gcol_Idelement;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gcol_Wavelength;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gcol_Lineality_axial;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gcol_Lineality_radial;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gcol_Idl_axial;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gcol_Idl_radial;
        private DevExpress.XtraEditors.CheckEdit ckElement;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gcol_Element_wavelength;
        private cbElement cbElement1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}