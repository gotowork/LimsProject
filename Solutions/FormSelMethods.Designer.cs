namespace LimsProject
{
    partial class FormSelMethods
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
            this.btOk = new DevExpress.XtraEditors.SimpleButton();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.gvMethods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gmet_Sel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSel = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gmet_Idtemplate_method = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gmet_Cod_template_method = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gmet_Title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMethods = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).BeginInit();
            this.paTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).BeginInit();
            this.paBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.paCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMethods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMethods)).BeginInit();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Size = new System.Drawing.Size(763, 33);
            this.laTitle.Text = "Seleccionar métodos";
            // 
            // paTitle
            // 
            this.paTitle.Size = new System.Drawing.Size(767, 37);
            // 
            // paBottom
            // 
            this.paBottom.Controls.Add(this.btCancel);
            this.paBottom.Controls.Add(this.btOk);
            this.paBottom.Location = new System.Drawing.Point(0, 308);
            this.paBottom.Size = new System.Drawing.Size(767, 34);
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.gcMethods);
            this.paCenter.Location = new System.Drawing.Point(0, 57);
            this.paCenter.Size = new System.Drawing.Size(767, 251);
            // 
            // paTop
            // 
            this.paTop.Location = new System.Drawing.Point(0, 37);
            this.paTop.Size = new System.Drawing.Size(767, 20);
            this.paTop.Visible = false;
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(12, 6);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(34, 23);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "Ok";
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(52, 6);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(59, 23);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Cancelar";
            // 
            // gvMethods
            // 
            this.gvMethods.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gmet_Sel,
            this.gmet_Idtemplate_method,
            this.gmet_Cod_template_method,
            this.gmet_Title});
            this.gvMethods.GridControl = this.gcMethods;
            this.gvMethods.Name = "gvMethods";
            this.gvMethods.OptionsView.ShowGroupPanel = false;
            // 
            // gmet_Sel
            // 
            this.gmet_Sel.Caption = "#";
            this.gmet_Sel.ColumnEdit = this.repSel;
            this.gmet_Sel.FieldName = "Sel";
            this.gmet_Sel.Name = "gmet_Sel";
            this.gmet_Sel.OptionsColumn.FixedWidth = true;
            this.gmet_Sel.Visible = true;
            this.gmet_Sel.VisibleIndex = 0;
            this.gmet_Sel.Width = 53;
            // 
            // repSel
            // 
            this.repSel.AutoHeight = false;
            this.repSel.Name = "repSel";
            this.repSel.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repSel_EditValueChanging);
            // 
            // gmet_Idtemplate_method
            // 
            this.gmet_Idtemplate_method.Caption = "Idtemplate_method";
            this.gmet_Idtemplate_method.FieldName = "Idtemplate_method";
            this.gmet_Idtemplate_method.Name = "gmet_Idtemplate_method";
            this.gmet_Idtemplate_method.Width = 86;
            // 
            // gmet_Cod_template_method
            // 
            this.gmet_Cod_template_method.Caption = "Código";
            this.gmet_Cod_template_method.FieldName = "Cod_template_method";
            this.gmet_Cod_template_method.Name = "gmet_Cod_template_method";
            this.gmet_Cod_template_method.OptionsColumn.FixedWidth = true;
            this.gmet_Cod_template_method.Visible = true;
            this.gmet_Cod_template_method.VisibleIndex = 1;
            this.gmet_Cod_template_method.Width = 71;
            // 
            // gmet_Title
            // 
            this.gmet_Title.Caption = "Título";
            this.gmet_Title.FieldName = "Title";
            this.gmet_Title.Name = "gmet_Title";
            this.gmet_Title.Visible = true;
            this.gmet_Title.VisibleIndex = 2;
            this.gmet_Title.Width = 618;
            // 
            // gcMethods
            // 
            this.gcMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMethods.EmbeddedNavigator.Name = "";
            this.gcMethods.Location = new System.Drawing.Point(2, 2);
            this.gcMethods.MainView = this.gvMethods;
            this.gcMethods.Name = "gcMethods";
            this.gcMethods.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSel});
            this.gcMethods.Size = new System.Drawing.Size(763, 247);
            this.gcMethods.TabIndex = 0;
            this.gcMethods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMethods});
            // 
            // FormSelMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 342);
            this.Name = "FormSelMethods";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar métodos";
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).EndInit();
            this.paTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            this.paBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMethods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMethods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.SimpleButton btOk;
        private DevExpress.XtraGrid.GridControl gcMethods;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMethods;
        private DevExpress.XtraGrid.Columns.GridColumn gmet_Sel;
        private DevExpress.XtraGrid.Columns.GridColumn gmet_Idtemplate_method;
        private DevExpress.XtraGrid.Columns.GridColumn gmet_Cod_template_method;
        private DevExpress.XtraGrid.Columns.GridColumn gmet_Title;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repSel;
    }
}