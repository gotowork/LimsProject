namespace LimsProject
{
    partial class FormDocument
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
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocument));
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeAuthorization = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn8 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn9 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gcDoc_Filename = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repGetCopyFileName = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcDoc_Allowed = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gcDoc_ExtensionFile = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gcDoc_date_ini = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repDate_ini = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gcDoc_date_end = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repDate_end = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gcDoc_Order_file = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gcDoc_Prev_authorized = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gcDoc_Rank_valid_inmonth = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repRankValid = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gcDoc_Error_valid = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gcDoc_Iddocumentation_user = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbExpiration = new DevExpress.XtraEditors.SpinEdit();
            this.cbUser = new DevExpress.XtraEditors.LookUpEdit();
            this.ckAssignUser = new DevExpress.XtraEditors.CheckEdit();
            this.btAttach = new DevExpress.XtraEditors.SimpleButton();
            this.btAddParent = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProcedure = new DevExpress.XtraEditors.LookUpEdit();
            this.cbDocument = new DevExpress.XtraEditors.LookUpEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucSignAuthorization = new LimsProject.UcSign();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ofdDocument = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeAuthorization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repGetCopyFileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate_ini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repRankValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbExpiration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckAssignUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProcedure.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDocument.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeAuthorization);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 278);
            this.panel1.TabIndex = 9;
            // 
            // treeAuthorization
            // 
            this.treeAuthorization.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn6,
            this.treeListColumn7,
            this.treeListColumn8,
            this.treeListColumn9,
            this.gcDoc_Filename,
            this.gcDoc_Allowed,
            this.gcDoc_ExtensionFile,
            this.gcDoc_date_ini,
            this.gcDoc_date_end,
            this.gcDoc_Order_file,
            this.gcDoc_Prev_authorized,
            this.gcDoc_Rank_valid_inmonth,
            this.gcDoc_Error_valid,
            this.gcDoc_Iddocumentation_user});
            this.treeAuthorization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeAuthorization.ImageIndexFieldName = "Image_index";
            this.treeAuthorization.KeyFieldName = "Id";
            this.treeAuthorization.Location = new System.Drawing.Point(0, 62);
            this.treeAuthorization.Name = "treeAuthorization";
            this.treeAuthorization.ParentFieldName = "Parentid";
            this.treeAuthorization.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repGetCopyFileName,
            this.repDate_ini,
            this.repDate_end,
            this.repRankValid,
            this.repositoryItemImageComboBox1});
            this.treeAuthorization.SelectImageList = this.imageList1;
            this.treeAuthorization.Size = new System.Drawing.Size(737, 216);
            this.treeAuthorization.TabIndex = 0;
            this.treeAuthorization.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.treeAuthorization_CellValueChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "iddocumentation";
            this.treeListColumn1.FieldName = "Iddocumentation";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Width = 85;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "idconfiguration_folder";
            this.treeListColumn2.FieldName = "Idconfiguration_folder";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Width = 110;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "idtemplate_method";
            this.treeListColumn3.FieldName = "Idtemplate_method";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Width = 86;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "procedure_type";
            this.treeListColumn4.FieldName = "Procedure_type";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Width = 85;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Nombre";
            this.treeListColumn5.FieldName = "Name_doc";
            this.treeListColumn5.MinWidth = 27;
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.VisibleIndex = 0;
            this.treeListColumn5.Width = 282;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "type_doc";
            this.treeListColumn6.FieldName = "Type_doc";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.Width = 110;
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "Habilitar";
            this.treeListColumn7.FieldName = "Flag_enabled";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.Width = 109;
            // 
            // treeListColumn8
            // 
            this.treeListColumn8.Caption = "Id";
            this.treeListColumn8.FieldName = "Id";
            this.treeListColumn8.Name = "treeListColumn8";
            this.treeListColumn8.Width = 109;
            // 
            // treeListColumn9
            // 
            this.treeListColumn9.Caption = "Parentid";
            this.treeListColumn9.FieldName = "Parentid";
            this.treeListColumn9.Name = "treeListColumn9";
            this.treeListColumn9.Width = 109;
            // 
            // gcDoc_Filename
            // 
            this.gcDoc_Filename.Caption = "Archivo";
            this.gcDoc_Filename.ColumnEdit = this.repGetCopyFileName;
            this.gcDoc_Filename.FieldName = "Name_file";
            this.gcDoc_Filename.Name = "gcDoc_Filename";
            this.gcDoc_Filename.OptionsColumn.ReadOnly = true;
            this.gcDoc_Filename.VisibleIndex = 4;
            this.gcDoc_Filename.Width = 130;
            // 
            // repGetCopyFileName
            // 
            this.repGetCopyFileName.AutoHeight = false;
            serializableAppearanceObject1.Font = new System.Drawing.Font("Tahoma", 7.5F);
            serializableAppearanceObject1.Options.UseFont = true;
            serializableAppearanceObject2.Font = new System.Drawing.Font("Tahoma", 7.5F);
            serializableAppearanceObject2.Options.UseFont = true;
            this.repGetCopyFileName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Cargar", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Abrir", -1, true, true, true, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2)});
            this.repGetCopyFileName.Name = "repGetCopyFileName";
            this.repGetCopyFileName.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repGetCopyFileName_ButtonClick);
            // 
            // gcDoc_Allowed
            // 
            this.gcDoc_Allowed.Caption = "#";
            this.gcDoc_Allowed.FieldName = "Allowed";
            this.gcDoc_Allowed.Name = "gcDoc_Allowed";
            this.gcDoc_Allowed.OptionsColumn.ReadOnly = true;
            this.gcDoc_Allowed.VisibleIndex = 5;
            this.gcDoc_Allowed.Width = 21;
            // 
            // gcDoc_ExtensionFile
            // 
            this.gcDoc_ExtensionFile.Caption = ".";
            this.gcDoc_ExtensionFile.FieldName = "Extension_file";
            this.gcDoc_ExtensionFile.Name = "gcDoc_ExtensionFile";
            this.gcDoc_ExtensionFile.OptionsColumn.ReadOnly = true;
            this.gcDoc_ExtensionFile.Width = 58;
            // 
            // gcDoc_date_ini
            // 
            this.gcDoc_date_ini.Caption = "Fecha Ini";
            this.gcDoc_date_ini.ColumnEdit = this.repDate_ini;
            this.gcDoc_date_ini.FieldName = "Date_ini";
            this.gcDoc_date_ini.Name = "gcDoc_date_ini";
            this.gcDoc_date_ini.VisibleIndex = 1;
            this.gcDoc_date_ini.Width = 54;
            // 
            // repDate_ini
            // 
            this.repDate_ini.AutoHeight = false;
            this.repDate_ini.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDate_ini.Name = "repDate_ini";
            // 
            // gcDoc_date_end
            // 
            this.gcDoc_date_end.Caption = "Fecha Fin";
            this.gcDoc_date_end.ColumnEdit = this.repDate_end;
            this.gcDoc_date_end.FieldName = "Date_end";
            this.gcDoc_date_end.Name = "gcDoc_date_end";
            this.gcDoc_date_end.OptionsColumn.ReadOnly = true;
            this.gcDoc_date_end.VisibleIndex = 3;
            this.gcDoc_date_end.Width = 53;
            // 
            // repDate_end
            // 
            this.repDate_end.AutoHeight = false;
            this.repDate_end.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDate_end.Name = "repDate_end";
            // 
            // gcDoc_Order_file
            // 
            this.gcDoc_Order_file.Caption = "Order_file";
            this.gcDoc_Order_file.FieldName = "Order_file";
            this.gcDoc_Order_file.Name = "gcDoc_Order_file";
            // 
            // gcDoc_Prev_authorized
            // 
            this.gcDoc_Prev_authorized.Caption = "Autorizado";
            this.gcDoc_Prev_authorized.FieldName = "Prev_authorized";
            this.gcDoc_Prev_authorized.Name = "gcDoc_Prev_authorized";
            this.gcDoc_Prev_authorized.VisibleIndex = 6;
            this.gcDoc_Prev_authorized.Width = 64;
            // 
            // gcDoc_Rank_valid_inmonth
            // 
            this.gcDoc_Rank_valid_inmonth.Caption = "Validez(mes)";
            this.gcDoc_Rank_valid_inmonth.ColumnEdit = this.repRankValid;
            this.gcDoc_Rank_valid_inmonth.FieldName = "Rank_valid_inmonth";
            this.gcDoc_Rank_valid_inmonth.Name = "gcDoc_Rank_valid_inmonth";
            this.gcDoc_Rank_valid_inmonth.VisibleIndex = 2;
            this.gcDoc_Rank_valid_inmonth.Width = 60;
            // 
            // repRankValid
            // 
            this.repRankValid.AutoHeight = false;
            this.repRankValid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repRankValid.IsFloatValue = false;
            this.repRankValid.Mask.EditMask = "N00";
            this.repRankValid.Name = "repRankValid";
            // 
            // gcDoc_Error_valid
            // 
            this.gcDoc_Error_valid.Caption = "Expirado";
            this.gcDoc_Error_valid.ColumnEdit = this.repositoryItemImageComboBox1;
            this.gcDoc_Error_valid.FieldName = "Error_valid";
            this.gcDoc_Error_valid.Name = "gcDoc_Error_valid";
            this.gcDoc_Error_valid.OptionsColumn.AllowEdit = false;
            this.gcDoc_Error_valid.VisibleIndex = 7;
            this.gcDoc_Error_valid.Width = 52;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 2, 2)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageList1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "certificado.png");
            this.imageList1.Images.SetKeyName(1, "adjunto.png");
            this.imageList1.Images.SetKeyName(2, "green.png");
            this.imageList1.Images.SetKeyName(3, "red.png");
            // 
            // gcDoc_Iddocumentation_user
            // 
            this.gcDoc_Iddocumentation_user.Caption = "Iddocumentation_user";
            this.gcDoc_Iddocumentation_user.FieldName = "Iddocumentation_user";
            this.gcDoc_Iddocumentation_user.Name = "gcDoc_Iddocumentation_user";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbExpiration);
            this.panel4.Controls.Add(this.cbUser);
            this.panel4.Controls.Add(this.ckAssignUser);
            this.panel4.Controls.Add(this.btAttach);
            this.panel4.Controls.Add(this.btAddParent);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cbProcedure);
            this.panel4.Controls.Add(this.cbDocument);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(737, 62);
            this.panel4.TabIndex = 4;
            // 
            // tbExpiration
            // 
            this.tbExpiration.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.tbExpiration.Location = new System.Drawing.Point(430, 32);
            this.tbExpiration.Name = "tbExpiration";
            this.tbExpiration.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbExpiration.Size = new System.Drawing.Size(39, 20);
            this.tbExpiration.TabIndex = 6;
            // 
            // cbUser
            // 
            this.cbUser.Location = new System.Drawing.Point(535, 6);
            this.cbUser.Name = "cbUser";
            this.cbUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUser.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Iduser", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cod_user")});
            this.cbUser.Properties.NullText = "Seleccionar";
            this.cbUser.Properties.ShowFooter = false;
            this.cbUser.Properties.ShowHeader = false;
            this.cbUser.Size = new System.Drawing.Size(113, 20);
            this.cbUser.TabIndex = 5;
            this.cbUser.EditValueChanged += new System.EventHandler(this.cbUser_EditValueChanged);
            // 
            // ckAssignUser
            // 
            this.ckAssignUser.Location = new System.Drawing.Point(522, 32);
            this.ckAssignUser.Name = "ckAssignUser";
            this.ckAssignUser.Properties.Caption = "Adjuntar Documentos a un Usuario";
            this.ckAssignUser.Size = new System.Drawing.Size(197, 18);
            this.ckAssignUser.TabIndex = 4;
            this.ckAssignUser.Visible = false;
            this.ckAssignUser.CheckedChanged += new System.EventHandler(this.ckAssignUser_CheckedChanged);
            // 
            // btAttach
            // 
            this.btAttach.ImageIndex = 1;
            this.btAttach.ImageList = this.imageList1;
            this.btAttach.Location = new System.Drawing.Point(149, 32);
            this.btAttach.Name = "btAttach";
            this.btAttach.Size = new System.Drawing.Size(123, 23);
            this.btAttach.TabIndex = 1;
            this.btAttach.Text = "Agregar Adjuntos";
            this.btAttach.Click += new System.EventHandler(this.btAttach_Click);
            // 
            // btAddParent
            // 
            this.btAddParent.ImageIndex = 0;
            this.btAddParent.ImageList = this.imageList1;
            this.btAddParent.Location = new System.Drawing.Point(11, 32);
            this.btAddParent.Name = "btAddParent";
            this.btAddParent.Size = new System.Drawing.Size(132, 23);
            this.btAddParent.TabIndex = 1;
            this.btAddParent.Text = "Agregar Certificado";
            this.btAddParent.Click += new System.EventHandler(this.btAddParent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Alertar expiración (meses):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Procedimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Documento:";
            // 
            // cbProcedure
            // 
            this.cbProcedure.Location = new System.Drawing.Point(362, 6);
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
            // cbDocument
            // 
            this.cbDocument.Location = new System.Drawing.Point(79, 6);
            this.cbDocument.Name = "cbDocument";
            this.cbDocument.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, true, DevExpress.Utils.HorzAlignment.Center, null)});
            this.cbDocument.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idconfiguration_folder", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Folder_name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Path", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.cbDocument.Properties.NullText = "Seleccionar";
            this.cbDocument.Properties.ShowFooter = false;
            this.cbDocument.Properties.ShowHeader = false;
            this.cbDocument.Size = new System.Drawing.Size(181, 20);
            this.cbDocument.TabIndex = 2;
            this.cbDocument.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbDocument_ButtonClick);
            this.cbDocument.EditValueChanged += new System.EventHandler(this.cbDocument_EditValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucSignAuthorization);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 50);
            this.panel2.TabIndex = 10;
            this.panel2.Visible = false;
            // 
            // ucSignAuthorization
            // 
            this.ucSignAuthorization.Location = new System.Drawing.Point(11, 5);
            this.ucSignAuthorization.Margin = new System.Windows.Forms.Padding(0);
            this.ucSignAuthorization.Name = "ucSignAuthorization";
            this.ucSignAuthorization.Pwd = null;
            this.ucSignAuthorization.Size = new System.Drawing.Size(164, 40);
            this.ucSignAuthorization.TabIndex = 0;
            this.ucSignAuthorization.Title = "Firmar Autorizaciones";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(737, 38);
            this.panel3.TabIndex = 11;
            this.panel3.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // ofdDocument
            // 
            this.ofdDocument.FileName = "documento";
            // 
            // FormDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormDocument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormDocument_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeAuthorization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repGetCopyFileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate_ini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repRankValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbExpiration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckAssignUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProcedure.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDocument.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btAttach;
        private DevExpress.XtraEditors.LookUpEdit cbDocument;
        private DevExpress.XtraTreeList.TreeList treeAuthorization;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn8;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn9;
        private DevExpress.XtraEditors.LookUpEdit cbProcedure;
        private DevExpress.XtraEditors.SimpleButton btAddParent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LookUpEdit cbUser;
        private DevExpress.XtraEditors.CheckEdit ckAssignUser;
        private DevExpress.XtraTreeList.Columns.TreeListColumn gcDoc_Filename;
        private DevExpress.XtraTreeList.Columns.TreeListColumn gcDoc_Allowed;
        private DevExpress.XtraTreeList.Columns.TreeListColumn gcDoc_ExtensionFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repGetCopyFileName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn gcDoc_date_ini;
        private DevExpress.XtraTreeList.Columns.TreeListColumn gcDoc_date_end;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDate_ini;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDate_end;
        private System.Windows.Forms.OpenFileDialog ofdDocument;
        private DevExpress.XtraEditors.SpinEdit tbExpiration;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn gcDoc_Order_file;
        private DevExpress.XtraTreeList.Columns.TreeListColumn gcDoc_Prev_authorized;
        private DevExpress.XtraTreeList.Columns.TreeListColumn gcDoc_Rank_valid_inmonth;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repRankValid;
        private DevExpress.XtraTreeList.Columns.TreeListColumn gcDoc_Error_valid;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private UcSign ucSignAuthorization;
        private DevExpress.XtraTreeList.Columns.TreeListColumn gcDoc_Iddocumentation_user;
    }
}