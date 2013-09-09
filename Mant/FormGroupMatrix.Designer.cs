namespace LimsProject
{
    partial class FormGroupMatrix
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
            this.gcGroupMatrix = new DevExpress.XtraGrid.GridControl();
            this.gvGroupMatrix = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcGM_Idmatrix_group = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcGM_Sigla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcGM_Name_group = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcGM_Status = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gcGroupMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Size = new System.Drawing.Size(448, 39);
            // 
            // paTitle
            // 
            this.paTitle.Size = new System.Drawing.Size(452, 43);
            this.paTitle.Visible = false;
            // 
            // paBottom
            // 
            this.paBottom.Controls.Add(this.btCancel);
            this.paBottom.Controls.Add(this.btSave);
            this.paBottom.Location = new System.Drawing.Point(0, 281);
            this.paBottom.Size = new System.Drawing.Size(452, 46);
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.gcGroupMatrix);
            this.paCenter.Size = new System.Drawing.Size(452, 173);
            // 
            // paTop
            // 
            this.paTop.Size = new System.Drawing.Size(452, 51);
            this.paTop.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(452, 14);
            this.panelControl1.Visible = false;
            // 
            // gcGroupMatrix
            // 
            this.gcGroupMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGroupMatrix.EmbeddedNavigator.Name = "";
            this.gcGroupMatrix.Location = new System.Drawing.Point(2, 2);
            this.gcGroupMatrix.MainView = this.gvGroupMatrix;
            this.gcGroupMatrix.Name = "gcGroupMatrix";
            this.gcGroupMatrix.Size = new System.Drawing.Size(448, 169);
            this.gcGroupMatrix.TabIndex = 0;
            this.gcGroupMatrix.UseEmbeddedNavigator = true;
            this.gcGroupMatrix.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGroupMatrix});
            // 
            // gvGroupMatrix
            // 
            this.gvGroupMatrix.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcGM_Idmatrix_group,
            this.gcGM_Sigla,
            this.gcGM_Name_group,
            this.gcGM_Status});
            this.gvGroupMatrix.GridControl = this.gcGroupMatrix;
            this.gvGroupMatrix.Name = "gvGroupMatrix";
            this.gvGroupMatrix.OptionsView.ShowGroupPanel = false;
            // 
            // gcGM_Idmatrix_group
            // 
            this.gcGM_Idmatrix_group.Caption = "Idmatrix_group";
            this.gcGM_Idmatrix_group.FieldName = "Idmatrix_group";
            this.gcGM_Idmatrix_group.Name = "gcGM_Idmatrix_group";
            // 
            // gcGM_Sigla
            // 
            this.gcGM_Sigla.Caption = "Sigla";
            this.gcGM_Sigla.FieldName = "Sigla";
            this.gcGM_Sigla.Name = "gcGM_Sigla";
            this.gcGM_Sigla.Visible = true;
            this.gcGM_Sigla.VisibleIndex = 0;
            this.gcGM_Sigla.Width = 92;
            // 
            // gcGM_Name_group
            // 
            this.gcGM_Name_group.Caption = "Nombre";
            this.gcGM_Name_group.FieldName = "Name_group";
            this.gcGM_Name_group.Name = "gcGM_Name_group";
            this.gcGM_Name_group.Visible = true;
            this.gcGM_Name_group.VisibleIndex = 1;
            this.gcGM_Name_group.Width = 335;
            // 
            // gcGM_Status
            // 
            this.gcGM_Status.Caption = "Status";
            this.gcGM_Status.FieldName = "Status";
            this.gcGM_Status.Name = "gcGM_Status";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(12, 11);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(59, 23);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Guardar";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(77, 11);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(59, 23);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Cancelar";
            // 
            // FormGroupMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 327);
            this.Name = "FormGroupMatrix";
            this.Text = "Agrupaciones de matriz";
            this.Load += new System.EventHandler(this.FormGroupMatrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).EndInit();
            this.paTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            this.paBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGroupMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGroupMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcGroupMatrix;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGroupMatrix;
        private DevExpress.XtraGrid.Columns.GridColumn gcGM_Idmatrix_group;
        private DevExpress.XtraGrid.Columns.GridColumn gcGM_Sigla;
        private DevExpress.XtraGrid.Columns.GridColumn gcGM_Name_group;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.SimpleButton btSave;
        private DevExpress.XtraGrid.Columns.GridColumn gcGM_Status;
    }
}