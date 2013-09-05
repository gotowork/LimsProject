namespace LimsProject
{
    partial class FormAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            this.ofdLinkDocument = new System.Windows.Forms.OpenFileDialog();
            this.treeAuthorization = new DevExpress.XtraTreeList.TreeList();
            this.col_iddocumentation = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_idconfiguration_folder = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_idtemplate_method = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_procedure_type = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_name_doc = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_type_doc = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_flag_enabled = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_id = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_Parentid = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btAddParent = new DevExpress.XtraEditors.SimpleButton();
            this.btAttach = new DevExpress.XtraEditors.SimpleButton();
            this.cbDocument = new DevExpress.XtraEditors.LookUpEdit();
            this.cbProcedure = new DevExpress.XtraEditors.LookUpEdit();
            this.paDocument = new System.Windows.Forms.Panel();
            this.paTopBasicButtons.SuspendLayout();
            this.paTopSearch.SuspendLayout();
            this.paBottomSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.paSearchGen.SuspendLayout();
            this.paInferior.SuspendLayout();
            this.paTitulo.SuspendLayout();
            this.paCentral.SuspendLayout();
            this.thePanelTab1.SuspendLayout();
            this.tpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeAuthorization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDocument.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProcedure.Properties)).BeginInit();
            this.paDocument.SuspendLayout();
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
            // paTitleSearch
            // 
            this.paTitleSearch.Size = new System.Drawing.Size(959, 37);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(549, 154);
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
            // paTopSearch
            // 
            this.paTopSearch.Size = new System.Drawing.Size(959, 57);
            // 
            // paBottomSearch
            // 
            this.paBottomSearch.Location = new System.Drawing.Point(3, 267);
            this.paBottomSearch.Size = new System.Drawing.Size(959, 43);
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
            this.panel1.Location = new System.Drawing.Point(887, 0);
            // 
            // btFiltroBuscar
            // 
            this.btFiltroBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btFiltroBuscar.FlatAppearance.BorderSize = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 41);
            // 
            // paMiddleFind
            // 
            this.paMiddleFind.Size = new System.Drawing.Size(959, 170);
            // 
            // paInferior
            // 
            this.paInferior.Location = new System.Drawing.Point(3, 265);
            this.paInferior.Size = new System.Drawing.Size(959, 45);
            // 
            // paTitulo
            // 
            this.paTitulo.Size = new System.Drawing.Size(959, 36);
            // 
            // paCentral
            // 
            this.paCentral.Controls.Add(this.paDocument);
            this.paCentral.Size = new System.Drawing.Size(959, 189);
            // 
            // paSupBotones
            // 
            this.paSupBotones.Size = new System.Drawing.Size(973, 32);
            // 
            // paSuperior
            // 
            this.paSuperior.Size = new System.Drawing.Size(959, 37);
            // 
            // laTitulo
            // 
            this.laTitulo.Size = new System.Drawing.Size(875, 36);
            // 
            // thePanelTab1
            // 
            this.thePanelTab1.Size = new System.Drawing.Size(973, 342);
            // 
            // tpDatos
            // 
            this.tpDatos.Size = new System.Drawing.Size(965, 313);
            // 
            // ofdLinkDocument
            // 
            this.ofdLinkDocument.FileName = "openFileDialog1";
            // 
            // treeAuthorization
            // 
            this.treeAuthorization.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.col_iddocumentation,
            this.col_idconfiguration_folder,
            this.col_idtemplate_method,
            this.col_procedure_type,
            this.col_name_doc,
            this.col_type_doc,
            this.col_flag_enabled,
            this.col_id,
            this.col_Parentid});
            this.treeAuthorization.ImageIndexFieldName = "Image_index";
            this.treeAuthorization.KeyFieldName = "Id";
            this.treeAuthorization.Location = new System.Drawing.Point(7, 64);
            this.treeAuthorization.Name = "treeAuthorization";
            this.treeAuthorization.ParentFieldName = "Parentid";
            this.treeAuthorization.SelectImageList = this.imageList1;
            this.treeAuthorization.Size = new System.Drawing.Size(454, 211);
            this.treeAuthorization.TabIndex = 0;
            // 
            // col_iddocumentation
            // 
            this.col_iddocumentation.Caption = "iddocumentation";
            this.col_iddocumentation.FieldName = "Iddocumentation";
            this.col_iddocumentation.Name = "col_iddocumentation";
            this.col_iddocumentation.Width = 85;
            // 
            // col_idconfiguration_folder
            // 
            this.col_idconfiguration_folder.Caption = "idconfiguration_folder";
            this.col_idconfiguration_folder.FieldName = "Idconfiguration_folder";
            this.col_idconfiguration_folder.Name = "col_idconfiguration_folder";
            this.col_idconfiguration_folder.Width = 110;
            // 
            // col_idtemplate_method
            // 
            this.col_idtemplate_method.Caption = "idtemplate_method";
            this.col_idtemplate_method.FieldName = "Idtemplate_method";
            this.col_idtemplate_method.Name = "col_idtemplate_method";
            this.col_idtemplate_method.Width = 86;
            // 
            // col_procedure_type
            // 
            this.col_procedure_type.Caption = "procedure_type";
            this.col_procedure_type.FieldName = "Procedure_type";
            this.col_procedure_type.Name = "col_procedure_type";
            this.col_procedure_type.Width = 85;
            // 
            // col_name_doc
            // 
            this.col_name_doc.Caption = "Nombre";
            this.col_name_doc.FieldName = "Name_doc";
            this.col_name_doc.MinWidth = 27;
            this.col_name_doc.Name = "col_name_doc";
            this.col_name_doc.VisibleIndex = 0;
            this.col_name_doc.Width = 110;
            // 
            // col_type_doc
            // 
            this.col_type_doc.Caption = "type_doc";
            this.col_type_doc.FieldName = "Type_doc";
            this.col_type_doc.Name = "col_type_doc";
            this.col_type_doc.Width = 110;
            // 
            // col_flag_enabled
            // 
            this.col_flag_enabled.Caption = "Habilitar";
            this.col_flag_enabled.FieldName = "Flag_enabled";
            this.col_flag_enabled.Name = "col_flag_enabled";
            this.col_flag_enabled.Width = 109;
            // 
            // col_id
            // 
            this.col_id.Caption = "Id";
            this.col_id.FieldName = "Id";
            this.col_id.Name = "col_id";
            this.col_id.Width = 109;
            // 
            // col_Parentid
            // 
            this.col_Parentid.Caption = "Parentid";
            this.col_Parentid.FieldName = "Parentid";
            this.col_Parentid.Name = "col_Parentid";
            this.col_Parentid.Width = 109;
            // 
            // btAddParent
            // 
            this.btAddParent.Location = new System.Drawing.Point(23, 8);
            this.btAddParent.Name = "btAddParent";
            this.btAddParent.Size = new System.Drawing.Size(110, 23);
            this.btAddParent.TabIndex = 1;
            this.btAddParent.Text = "Agregar Certificado";
            this.btAddParent.Click += new System.EventHandler(this.btAddParent_Click);
            // 
            // btAttach
            // 
            this.btAttach.Location = new System.Drawing.Point(139, 8);
            this.btAttach.Name = "btAttach";
            this.btAttach.Size = new System.Drawing.Size(110, 23);
            this.btAttach.TabIndex = 1;
            this.btAttach.Text = "Agregar Adjuntos";
            this.btAttach.Click += new System.EventHandler(this.btAttach_Click);
            // 
            // cbDocument
            // 
            this.cbDocument.Location = new System.Drawing.Point(91, 38);
            this.cbDocument.Name = "cbDocument";
            this.cbDocument.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDocument.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idconfiguration_folder", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Folder_name")});
            this.cbDocument.Properties.NullText = "Seleccionar";
            this.cbDocument.Properties.ShowFooter = false;
            this.cbDocument.Properties.ShowHeader = false;
            this.cbDocument.Size = new System.Drawing.Size(150, 20);
            this.cbDocument.TabIndex = 2;
            this.cbDocument.EditValueChanged += new System.EventHandler(this.cbDocument_EditValueChanged);
            // 
            // cbProcedure
            // 
            this.cbProcedure.Location = new System.Drawing.Point(348, 38);
            this.cbProcedure.Name = "cbProcedure";
            this.cbProcedure.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProcedure.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name")});
            this.cbProcedure.Properties.NullText = "Seleccionar";
            this.cbProcedure.Properties.ShowFooter = false;
            this.cbProcedure.Properties.ShowHeader = false;
            this.cbProcedure.Size = new System.Drawing.Size(100, 20);
            this.cbProcedure.TabIndex = 2;
            this.cbProcedure.EditValueChanged += new System.EventHandler(this.cbProcedure_EditValueChanged);
            // 
            // paDocument
            // 
            this.paDocument.Controls.Add(this.btAttach);
            this.paDocument.Controls.Add(this.label2);
            this.paDocument.Controls.Add(this.cbDocument);
            this.paDocument.Controls.Add(this.treeAuthorization);
            this.paDocument.Controls.Add(this.cbProcedure);
            this.paDocument.Controls.Add(this.label1);
            this.paDocument.Controls.Add(this.btAddParent);
            this.paDocument.Location = new System.Drawing.Point(128, 16);
            this.paDocument.Name = "paDocument";
            this.paDocument.Size = new System.Drawing.Size(549, 154);
            this.paDocument.TabIndex = 5;
            this.paDocument.Controls.SetChildIndex(this.btAddParent, 0);
            this.paDocument.Controls.SetChildIndex(this.label1, 0);
            this.paDocument.Controls.SetChildIndex(this.cbProcedure, 0);
            this.paDocument.Controls.SetChildIndex(this.treeAuthorization, 0);
            this.paDocument.Controls.SetChildIndex(this.cbDocument, 0);
            this.paDocument.Controls.SetChildIndex(this.label2, 0);
            this.paDocument.Controls.SetChildIndex(this.btAttach, 0);
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 374);
            this.Name = "FormAuthorization";
            this.Load += new System.EventHandler(this.FormAuthorization_Load);
            this.paTopBasicButtons.ResumeLayout(false);
            this.paTopSearch.ResumeLayout(false);
            this.paBottomSearch.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.paSearchGen.ResumeLayout(false);
            this.paSearchGen.PerformLayout();
            this.paInferior.ResumeLayout(false);
            this.paTitulo.ResumeLayout(false);
            this.paCentral.ResumeLayout(false);
            this.thePanelTab1.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeAuthorization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDocument.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProcedure.Properties)).EndInit();
            this.paDocument.ResumeLayout(false);
            this.paDocument.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdLinkDocument;
        private DevExpress.XtraTreeList.TreeList treeAuthorization;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_idconfiguration_folder;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_idtemplate_method;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_procedure_type;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_name_doc;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_type_doc;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_flag_enabled;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_iddocumentation;
        private DevExpress.XtraEditors.SimpleButton btAddParent;
        private DevExpress.XtraEditors.SimpleButton btAttach;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_id;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_Parentid;
        private DevExpress.XtraEditors.LookUpEdit cbDocument;
        private DevExpress.XtraEditors.LookUpEdit cbProcedure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel paDocument;
    }
}