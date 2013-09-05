namespace LimsProject
{
    partial class FormConfigPath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigPath));
            this.btOk = new DevExpress.XtraEditors.SimpleButton();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btRootDirectory = new DevExpress.XtraEditors.ButtonEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gcDirectories = new DevExpress.XtraGrid.GridControl();
            this.gvDirectories = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCol_Idconfiguration_folder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Folder_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Path = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCol_Folder_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ofdFindRoot = new System.Windows.Forms.OpenFileDialog();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.fbdFindRoot = new System.Windows.Forms.FolderBrowserDialog();
            this.paInferior.SuspendLayout();
            this.paTitulo.SuspendLayout();
            this.paCentral.SuspendLayout();
            this.paSuperior.SuspendLayout();
            this.thePanelTab1.SuspendLayout();
            this.tpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btRootDirectory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDirectories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDirectories)).BeginInit();
            this.SuspendLayout();
            // 
            // paInferior
            // 
            this.paInferior.Controls.Add(this.btCancel);
            this.paInferior.Controls.Add(this.btOk);
            this.paInferior.Location = new System.Drawing.Point(3, 246);
            this.paInferior.Size = new System.Drawing.Size(580, 39);
            // 
            // paTitulo
            // 
            this.paTitulo.Size = new System.Drawing.Size(580, 37);
            // 
            // paCentral
            // 
            this.paCentral.Controls.Add(this.gcDirectories);
            this.paCentral.Location = new System.Drawing.Point(3, 83);
            this.paCentral.Size = new System.Drawing.Size(580, 163);
            // 
            // paSupBotones
            // 
            this.paSupBotones.Size = new System.Drawing.Size(594, 32);
            this.paSupBotones.Visible = false;
            // 
            // paSuperior
            // 
            this.paSuperior.Controls.Add(this.label1);
            this.paSuperior.Controls.Add(this.btRootDirectory);
            this.paSuperior.Size = new System.Drawing.Size(580, 43);
            // 
            // laTitulo
            // 
            this.laTitulo.Size = new System.Drawing.Size(580, 37);
            this.laTitulo.Text = "Configuración de Directorios";
            // 
            // thePanelTab1
            // 
            this.thePanelTab1.Size = new System.Drawing.Size(594, 317);
            // 
            // tpDatos
            // 
            this.tpDatos.Size = new System.Drawing.Size(586, 288);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(8, 8);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(36, 23);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "Ok";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(50, 8);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(69, 23);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Cancelar";
            // 
            // btRootDirectory
            // 
            this.btRootDirectory.Location = new System.Drawing.Point(101, 10);
            this.btRootDirectory.Name = "btRootDirectory";
            this.btRootDirectory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, global::LimsProject.Properties.Resources.folder12x12)});
            this.btRootDirectory.Size = new System.Drawing.Size(474, 20);
            this.btRootDirectory.TabIndex = 0;
            this.btRootDirectory.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btRootDirectory_ButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carpeta Principal:";
            // 
            // gcDirectories
            // 
            this.gcDirectories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDirectories.EmbeddedNavigator.Name = "";
            this.gcDirectories.Location = new System.Drawing.Point(0, 0);
            this.gcDirectories.MainView = this.gvDirectories;
            this.gcDirectories.Name = "gcDirectories";
            this.gcDirectories.Size = new System.Drawing.Size(580, 163);
            this.gcDirectories.TabIndex = 0;
            this.gcDirectories.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDirectories});
            // 
            // gvDirectories
            // 
            this.gvDirectories.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcCol_Idconfiguration_folder,
            this.gcCol_Folder_name,
            this.gcCol_Description,
            this.gcCol_Path,
            this.gcCol_Folder_type});
            this.gvDirectories.GridControl = this.gcDirectories;
            this.gvDirectories.Name = "gvDirectories";
            this.gvDirectories.OptionsView.ShowGroupPanel = false;
            // 
            // gcCol_Idconfiguration_folder
            // 
            this.gcCol_Idconfiguration_folder.Caption = "Idconfiguration_folder";
            this.gcCol_Idconfiguration_folder.FieldName = "Idconfiguration_folder";
            this.gcCol_Idconfiguration_folder.Name = "gcCol_Idconfiguration_folder";
            // 
            // gcCol_Folder_name
            // 
            this.gcCol_Folder_name.Caption = "Nombre";
            this.gcCol_Folder_name.FieldName = "Folder_name";
            this.gcCol_Folder_name.Name = "gcCol_Folder_name";
            this.gcCol_Folder_name.Visible = true;
            this.gcCol_Folder_name.VisibleIndex = 0;
            this.gcCol_Folder_name.Width = 124;
            // 
            // gcCol_Description
            // 
            this.gcCol_Description.Caption = "Descripción";
            this.gcCol_Description.FieldName = "Description";
            this.gcCol_Description.Name = "gcCol_Description";
            this.gcCol_Description.Visible = true;
            this.gcCol_Description.VisibleIndex = 1;
            this.gcCol_Description.Width = 144;
            // 
            // gcCol_Path
            // 
            this.gcCol_Path.Caption = "Nombre de directorio";
            this.gcCol_Path.FieldName = "Path";
            this.gcCol_Path.Name = "gcCol_Path";
            this.gcCol_Path.Visible = true;
            this.gcCol_Path.VisibleIndex = 2;
            this.gcCol_Path.Width = 147;
            // 
            // gcCol_Folder_type
            // 
            this.gcCol_Folder_type.Caption = "Folder_type";
            this.gcCol_Folder_type.FieldName = "Folder_type";
            this.gcCol_Folder_type.Name = "gcCol_Folder_type";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            // 
            // ofdFindRoot
            // 
            this.ofdFindRoot.FileName = "openFileDialog1";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // FormConfigPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 349);
            this.Name = "FormConfigPath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de Directorios";
            this.Load += new System.EventHandler(this.FormConfigPath_Load);
            this.paInferior.ResumeLayout(false);
            this.paTitulo.ResumeLayout(false);
            this.paCentral.ResumeLayout(false);
            this.paSuperior.ResumeLayout(false);
            this.paSuperior.PerformLayout();
            this.thePanelTab1.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btRootDirectory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDirectories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDirectories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.SimpleButton btOk;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ButtonEdit btRootDirectory;
        private DevExpress.XtraGrid.GridControl gcDirectories;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDirectories;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Idconfiguration_folder;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Folder_name;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Description;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Path;
        private DevExpress.XtraGrid.Columns.GridColumn gcCol_Folder_type;
        private System.Windows.Forms.OpenFileDialog ofdFindRoot;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.FolderBrowserDialog fbdFindRoot;
    }
}