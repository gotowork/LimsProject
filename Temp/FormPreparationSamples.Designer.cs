namespace LimsProject
{
    partial class FormPreparationSamples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreparationSamples));
            this.treePreparationSample = new DevExpress.XtraTreeList.TreeList();
            this.trCol_Idpreparation_sample = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trCol_Name_node = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trCol_Nro_view = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trCol_Title = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repAttach = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.trCol_Status_send_sample = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trCol_DH_input = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trCol_DH_output_reception = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trCol_Chek_send = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repCheckSend = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.repDHOutput = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.treePreparationSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repAttach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDHOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // treePreparationSample
            // 
            this.treePreparationSample.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.trCol_Idpreparation_sample,
            this.trCol_Name_node,
            this.trCol_Nro_view,
            this.trCol_Title,
            this.trCol_Status_send_sample,
            this.trCol_DH_input,
            this.trCol_DH_output_reception,
            this.treeListColumn1,
            this.treeListColumn2,
            this.trCol_Chek_send});
            this.treePreparationSample.KeyFieldName = "Id";
            this.treePreparationSample.Location = new System.Drawing.Point(13, 62);
            this.treePreparationSample.Name = "treePreparationSample";
            this.treePreparationSample.ParentFieldName = "Parentid";
            this.treePreparationSample.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repAttach,
            this.repCheckSend,
            this.repDHOutput});
            this.treePreparationSample.Size = new System.Drawing.Size(748, 367);
            this.treePreparationSample.TabIndex = 0;
            this.treePreparationSample.Click += new System.EventHandler(this.treePreparationSample_Click);
            // 
            // trCol_Idpreparation_sample
            // 
            this.trCol_Idpreparation_sample.Caption = "Idpreparation_sample";
            this.trCol_Idpreparation_sample.FieldName = "Idpreparation_sample";
            this.trCol_Idpreparation_sample.MinWidth = 64;
            this.trCol_Idpreparation_sample.Name = "trCol_Idpreparation_sample";
            this.trCol_Idpreparation_sample.Width = 129;
            // 
            // trCol_Name_node
            // 
            this.trCol_Name_node.Caption = "Nombre";
            this.trCol_Name_node.FieldName = "Name_node";
            this.trCol_Name_node.Name = "trCol_Name_node";
            this.trCol_Name_node.VisibleIndex = 0;
            this.trCol_Name_node.Width = 143;
            // 
            // trCol_Nro_view
            // 
            this.trCol_Nro_view.Caption = "Nro_view";
            this.trCol_Nro_view.FieldName = "Nro_view";
            this.trCol_Nro_view.Name = "trCol_Nro_view";
            this.trCol_Nro_view.Width = 72;
            // 
            // trCol_Title
            // 
            this.trCol_Title.Caption = "Título";
            this.trCol_Title.ColumnEdit = this.repAttach;
            this.trCol_Title.FieldName = "Title";
            this.trCol_Title.Name = "trCol_Title";
            this.trCol_Title.VisibleIndex = 1;
            this.trCol_Title.Width = 295;
            // 
            // repAttach
            // 
            this.repAttach.AutoHeight = false;
            serializableAppearanceObject1.Font = new System.Drawing.Font("Tahoma", 7.5F);
            serializableAppearanceObject1.Options.UseFont = true;
            serializableAppearanceObject2.Font = new System.Drawing.Font("Tahoma", 7.5F);
            serializableAppearanceObject2.Options.UseFont = true;
            this.repAttach.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Abrir", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Agregar", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2)});
            this.repAttach.Name = "repAttach";
            this.repAttach.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repAttach_ButtonClick);
            this.repAttach.Enter += new System.EventHandler(this.repAttach_Enter);
            // 
            // trCol_Status_send_sample
            // 
            this.trCol_Status_send_sample.Caption = "Envío";
            this.trCol_Status_send_sample.FieldName = "Status_send_sample";
            this.trCol_Status_send_sample.Name = "trCol_Status_send_sample";
            this.trCol_Status_send_sample.Width = 73;
            // 
            // trCol_DH_input
            // 
            this.trCol_DH_input.Caption = "FH Ingreso";
            this.trCol_DH_input.FieldName = "DH_input";
            this.trCol_DH_input.Name = "trCol_DH_input";
            this.trCol_DH_input.VisibleIndex = 3;
            this.trCol_DH_input.Width = 93;
            // 
            // trCol_DH_output_reception
            // 
            this.trCol_DH_output_reception.Caption = "FH Salida";
            this.trCol_DH_output_reception.FieldName = "DH_output_reception";
            this.trCol_DH_output_reception.Name = "trCol_DH_output_reception";
            this.trCol_DH_output_reception.OptionsColumn.AllowEdit = false;
            this.trCol_DH_output_reception.VisibleIndex = 4;
            this.trCol_DH_output_reception.Width = 91;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Id";
            this.treeListColumn1.FieldName = "Id";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Width = 73;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Parentid";
            this.treeListColumn2.FieldName = "Parentid";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Width = 73;
            // 
            // trCol_Chek_send
            // 
            this.trCol_Chek_send.Caption = "Enviar";
            this.trCol_Chek_send.ColumnEdit = this.repCheckSend;
            this.trCol_Chek_send.FieldName = "Chek_send";
            this.trCol_Chek_send.Name = "trCol_Chek_send";
            this.trCol_Chek_send.OptionsColumn.AllowEdit = false;
            this.trCol_Chek_send.VisibleIndex = 2;
            this.trCol_Chek_send.Width = 85;
            // 
            // repCheckSend
            // 
            this.repCheckSend.AutoHeight = false;
            this.repCheckSend.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.repCheckSend.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 2, 1)});
            this.repCheckSend.Name = "repCheckSend";
            this.repCheckSend.SmallImages = this.imageList1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "uncheck16x16.png");
            this.imageList1.Images.SetKeyName(1, "check16x16.png");
            // 
            // repDHOutput
            // 
            this.repDHOutput.AutoHeight = false;
            this.repDHOutput.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDHOutput.Name = "repDHOutput";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(41, 456);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Enviar";
            // 
            // FormPreparationSamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 513);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.treePreparationSample);
            this.Name = "FormPreparationSamples";
            this.Text = "Preparación de Muestras";
            this.Load += new System.EventHandler(this.FormPreparationSamples_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treePreparationSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repAttach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDHOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treePreparationSample;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trCol_Idpreparation_sample;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trCol_Name_node;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trCol_Nro_view;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trCol_Title;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trCol_Status_send_sample;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trCol_DH_input;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trCol_DH_output_reception;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repAttach;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trCol_Chek_send;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repCheckSend;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDHOutput;
    }
}