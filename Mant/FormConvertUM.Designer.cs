namespace LimsProject
{
    partial class FormConvertUM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConvertUM));
            this.gcConvertionUM = new DevExpress.XtraGrid.GridControl();
            this.gvConvertionUM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcUmc_den_unit1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repUm1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcUmc_factor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcUmc_den_unit2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repUm2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcUmc_idunit1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcUmc_idunit2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcUmc_idconvert = new DevExpress.XtraGrid.Columns.GridColumn();
            this.paTitleSearch.SuspendLayout();
            this.paTopBasicButtons.SuspendLayout();
            this.paBottomSearch.SuspendLayout();
            this.paInferior.SuspendLayout();
            this.paTitulo.SuspendLayout();
            this.paCentral.SuspendLayout();
            this.thePanelTab1.SuspendLayout();
            this.tpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcConvertionUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConvertionUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repUm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repUm2)).BeginInit();
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
            this.label1.Text = "Conversión de Unidad de Medida - Búsqueda";
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
            // paInferior
            // 
            this.paInferior.Location = new System.Drawing.Point(3, 254);
            this.paInferior.Size = new System.Drawing.Size(545, 45);
            // 
            // paTitulo
            // 
            this.paTitulo.Size = new System.Drawing.Size(545, 36);
            // 
            // paCentral
            // 
            this.paCentral.Controls.Add(this.gcConvertionUM);
            this.paCentral.Location = new System.Drawing.Point(3, 70);
            this.paCentral.Size = new System.Drawing.Size(545, 184);
            // 
            // paSupBotones
            // 
            this.paSupBotones.Size = new System.Drawing.Size(559, 32);
            // 
            // paSuperior
            // 
            this.paSuperior.Size = new System.Drawing.Size(545, 31);
            // 
            // laTitulo
            // 
            this.laTitulo.Size = new System.Drawing.Size(461, 36);
            this.laTitulo.Text = "Conversion de Unidad de Medida";
            // 
            // thePanelTab1
            // 
            this.thePanelTab1.Size = new System.Drawing.Size(559, 331);
            // 
            // tpDatos
            // 
            this.tpDatos.Size = new System.Drawing.Size(551, 302);
            // 
            // gcConvertionUM
            // 
            this.gcConvertionUM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcConvertionUM.EmbeddedNavigator.Name = "";
            this.gcConvertionUM.Location = new System.Drawing.Point(0, 0);
            this.gcConvertionUM.MainView = this.gvConvertionUM;
            this.gcConvertionUM.Name = "gcConvertionUM";
            this.gcConvertionUM.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repUm1,
            this.repUm2});
            this.gcConvertionUM.Size = new System.Drawing.Size(545, 184);
            this.gcConvertionUM.TabIndex = 0;
            this.gcConvertionUM.UseEmbeddedNavigator = true;
            this.gcConvertionUM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvConvertionUM});
            // 
            // gvConvertionUM
            // 
            this.gvConvertionUM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcUmc_den_unit1,
            this.gcUmc_factor,
            this.gcUmc_den_unit2,
            this.gcUmc_idunit1,
            this.gcUmc_idunit2,
            this.gcUmc_idconvert});
            this.gvConvertionUM.GridControl = this.gcConvertionUM;
            this.gvConvertionUM.Name = "gvConvertionUM";
            this.gvConvertionUM.OptionsView.ShowGroupPanel = false;
            this.gvConvertionUM.PaintStyleName = "Flat";
            this.gvConvertionUM.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvConvertionUM_InitNewRow);
            // 
            // gcUmc_den_unit1
            // 
            this.gcUmc_den_unit1.Caption = "Unidad Medida1";
            this.gcUmc_den_unit1.ColumnEdit = this.repUm1;
            this.gcUmc_den_unit1.FieldName = "Den_unit1";
            this.gcUmc_den_unit1.Name = "gcUmc_den_unit1";
            this.gcUmc_den_unit1.Visible = true;
            this.gcUmc_den_unit1.VisibleIndex = 0;
            // 
            // repUm1
            // 
            this.repUm1.AutoHeight = false;
            this.repUm1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repUm1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idunit", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name_unit")});
            this.repUm1.Name = "repUm1";
            this.repUm1.NullText = "Seleccionar";
            this.repUm1.ShowHeader = false;
            this.repUm1.EditValueChanged += new System.EventHandler(this.repUm1_EditValueChanged);
            // 
            // gcUmc_factor
            // 
            this.gcUmc_factor.Caption = "|--- Factor -->";
            this.gcUmc_factor.FieldName = "Factor";
            this.gcUmc_factor.Name = "gcUmc_factor";
            this.gcUmc_factor.Visible = true;
            this.gcUmc_factor.VisibleIndex = 1;
            // 
            // gcUmc_den_unit2
            // 
            this.gcUmc_den_unit2.Caption = "Unidad Medida2";
            this.gcUmc_den_unit2.ColumnEdit = this.repUm2;
            this.gcUmc_den_unit2.FieldName = "Den_unit2";
            this.gcUmc_den_unit2.Name = "gcUmc_den_unit2";
            this.gcUmc_den_unit2.Visible = true;
            this.gcUmc_den_unit2.VisibleIndex = 2;
            // 
            // repUm2
            // 
            this.repUm2.AutoHeight = false;
            this.repUm2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repUm2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idunit", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name_unit")});
            this.repUm2.Name = "repUm2";
            this.repUm2.NullText = "Seleccionar";
            this.repUm2.ShowHeader = false;
            this.repUm2.EditValueChanged += new System.EventHandler(this.repUm2_EditValueChanged);
            // 
            // gcUmc_idunit1
            // 
            this.gcUmc_idunit1.Caption = "idunit1";
            this.gcUmc_idunit1.FieldName = "Idunit1";
            this.gcUmc_idunit1.Name = "gcUmc_idunit1";
            // 
            // gcUmc_idunit2
            // 
            this.gcUmc_idunit2.Caption = "idunit2";
            this.gcUmc_idunit2.FieldName = "Idunit2";
            this.gcUmc_idunit2.Name = "gcUmc_idunit2";
            // 
            // gcUmc_idconvert
            // 
            this.gcUmc_idconvert.Caption = "idconvert";
            this.gcUmc_idconvert.FieldName = "Idconvert";
            this.gcUmc_idconvert.Name = "gcUmc_idconvert";
            // 
            // FormConvertUM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 363);
            this.Name = "FormConvertUM";
            this.Text = "Conversión de Unidad de Medida";
            this.Load += new System.EventHandler(this.FormConvertUM_Load);
            this.paTitleSearch.ResumeLayout(false);
            this.paTopBasicButtons.ResumeLayout(false);
            this.paBottomSearch.ResumeLayout(false);
            this.paInferior.ResumeLayout(false);
            this.paTitulo.ResumeLayout(false);
            this.paCentral.ResumeLayout(false);
            this.thePanelTab1.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcConvertionUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConvertionUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repUm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repUm2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcConvertionUM;
        private DevExpress.XtraGrid.Views.Grid.GridView gvConvertionUM;
        private DevExpress.XtraGrid.Columns.GridColumn gcUmc_den_unit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repUm1;
        private DevExpress.XtraGrid.Columns.GridColumn gcUmc_factor;
        private DevExpress.XtraGrid.Columns.GridColumn gcUmc_den_unit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repUm2;
        private DevExpress.XtraGrid.Columns.GridColumn gcUmc_idunit1;
        private DevExpress.XtraGrid.Columns.GridColumn gcUmc_idunit2;
        private DevExpress.XtraGrid.Columns.GridColumn gcUmc_idconvert;
    }
}