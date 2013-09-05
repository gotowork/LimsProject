namespace LimsProject
{
    partial class FormMatrixItems
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
            this.gcMatrixItems = new DevExpress.XtraGrid.GridControl();
            this.gvMatrixItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcM_Idmatrix_item = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcM_Idmatrix_group = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcM_Sigla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcM_Name_item = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcM_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcM_Flag_acreditado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcM_Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repGroupMatrix = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btSave = new DevExpress.XtraEditors.SimpleButton();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).BeginInit();
            this.paTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).BeginInit();
            this.paBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.paCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMatrixItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMatrixItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repGroupMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Size = new System.Drawing.Size(808, 39);
            // 
            // paTitle
            // 
            this.paTitle.Location = new System.Drawing.Point(0, 28);
            this.paTitle.Size = new System.Drawing.Size(812, 43);
            this.paTitle.Visible = false;
            // 
            // paBottom
            // 
            this.paBottom.Controls.Add(this.btCancel);
            this.paBottom.Controls.Add(this.btSave);
            this.paBottom.Location = new System.Drawing.Point(0, 354);
            this.paBottom.Size = new System.Drawing.Size(812, 46);
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.gcMatrixItems);
            this.paCenter.Location = new System.Drawing.Point(0, 122);
            this.paCenter.Size = new System.Drawing.Size(812, 232);
            // 
            // paTop
            // 
            this.paTop.Location = new System.Drawing.Point(0, 71);
            this.paTop.Size = new System.Drawing.Size(812, 51);
            this.paTop.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(812, 28);
            this.panelControl1.Visible = false;
            // 
            // gcMatrixItems
            // 
            this.gcMatrixItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMatrixItems.EmbeddedNavigator.Name = "";
            this.gcMatrixItems.Location = new System.Drawing.Point(2, 2);
            this.gcMatrixItems.MainView = this.gvMatrixItems;
            this.gcMatrixItems.Name = "gcMatrixItems";
            this.gcMatrixItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repGroupMatrix});
            this.gcMatrixItems.Size = new System.Drawing.Size(808, 228);
            this.gcMatrixItems.TabIndex = 0;
            this.gcMatrixItems.UseEmbeddedNavigator = true;
            this.gcMatrixItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMatrixItems});
            // 
            // gvMatrixItems
            // 
            this.gvMatrixItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcM_Idmatrix_item,
            this.gcM_Idmatrix_group,
            this.gcM_Sigla,
            this.gcM_Name_item,
            this.gcM_Description,
            this.gcM_Flag_acreditado,
            this.gcM_Status});
            this.gvMatrixItems.GridControl = this.gcMatrixItems;
            this.gvMatrixItems.Name = "gvMatrixItems";
            this.gvMatrixItems.OptionsView.RowAutoHeight = true;
            this.gvMatrixItems.OptionsView.ShowGroupPanel = false;
            // 
            // gcM_Idmatrix_item
            // 
            this.gcM_Idmatrix_item.Caption = "Idmatrix_item";
            this.gcM_Idmatrix_item.FieldName = "Idmatrix_item";
            this.gcM_Idmatrix_item.Name = "gcM_Idmatrix_item";
            // 
            // gcM_Idmatrix_group
            // 
            this.gcM_Idmatrix_group.Caption = "Grupo";
            this.gcM_Idmatrix_group.ColumnEdit = this.repGroupMatrix;
            this.gcM_Idmatrix_group.FieldName = "Idmatrix_group";
            this.gcM_Idmatrix_group.Name = "gcM_Idmatrix_group";
            this.gcM_Idmatrix_group.Visible = true;
            this.gcM_Idmatrix_group.VisibleIndex = 0;
            this.gcM_Idmatrix_group.Width = 196;
            // 
            // gcM_Sigla
            // 
            this.gcM_Sigla.Caption = "Sigla";
            this.gcM_Sigla.FieldName = "Sigla";
            this.gcM_Sigla.Name = "gcM_Sigla";
            this.gcM_Sigla.Visible = true;
            this.gcM_Sigla.VisibleIndex = 1;
            this.gcM_Sigla.Width = 63;
            // 
            // gcM_Name_item
            // 
            this.gcM_Name_item.Caption = "Nombre";
            this.gcM_Name_item.FieldName = "Name_item";
            this.gcM_Name_item.Name = "gcM_Name_item";
            this.gcM_Name_item.Visible = true;
            this.gcM_Name_item.VisibleIndex = 2;
            this.gcM_Name_item.Width = 171;
            // 
            // gcM_Description
            // 
            this.gcM_Description.Caption = "Descripción";
            this.gcM_Description.FieldName = "Description";
            this.gcM_Description.Name = "gcM_Description";
            this.gcM_Description.Visible = true;
            this.gcM_Description.VisibleIndex = 3;
            this.gcM_Description.Width = 357;
            // 
            // gcM_Flag_acreditado
            // 
            this.gcM_Flag_acreditado.Caption = "gridColumn5";
            this.gcM_Flag_acreditado.FieldName = "Flag_acreditado";
            this.gcM_Flag_acreditado.Name = "gcM_Flag_acreditado";
            // 
            // gcM_Status
            // 
            this.gcM_Status.Caption = "Status";
            this.gcM_Status.FieldName = "Status";
            this.gcM_Status.Name = "gcM_Status";
            // 
            // repGroupMatrix
            // 
            this.repGroupMatrix.AutoHeight = false;
            this.repGroupMatrix.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repGroupMatrix.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name")});
            this.repGroupMatrix.Name = "repGroupMatrix";
            this.repGroupMatrix.NullText = "Seleccionar";
            this.repGroupMatrix.ShowFooter = false;
            this.repGroupMatrix.ShowHeader = false;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(12, 11);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Guardar";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(93, 11);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Cancelar";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FormMatrixItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 400);
            this.Name = "FormMatrixItems";
            this.Text = "Matriz";
            this.Load += new System.EventHandler(this.FormMatrixItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).EndInit();
            this.paTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            this.paBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMatrixItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMatrixItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repGroupMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcMatrixItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMatrixItems;
        private DevExpress.XtraGrid.Columns.GridColumn gcM_Idmatrix_group;
        private DevExpress.XtraGrid.Columns.GridColumn gcM_Sigla;
        private DevExpress.XtraGrid.Columns.GridColumn gcM_Name_item;
        private DevExpress.XtraGrid.Columns.GridColumn gcM_Description;
        private DevExpress.XtraGrid.Columns.GridColumn gcM_Flag_acreditado;
        private DevExpress.XtraGrid.Columns.GridColumn gcM_Status;
        private DevExpress.XtraGrid.Columns.GridColumn gcM_Idmatrix_item;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repGroupMatrix;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.SimpleButton btSave;
    }
}