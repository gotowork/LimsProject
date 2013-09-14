namespace LimsProject
{
    partial class FormFactorEstequiometrico
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
            this.gcFactorEstequ = new DevExpress.XtraGrid.GridControl();
            this.gvFactorEstequ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcol_Idfactor_estequiometrico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcol_Idcompound = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCompound = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcol_Idelement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repElement = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcol_Factor = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gcFactorEstequ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFactorEstequ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCompound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repElement)).BeginInit();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Size = new System.Drawing.Size(419, 33);
            // 
            // paTitle
            // 
            this.paTitle.Size = new System.Drawing.Size(423, 37);
            this.paTitle.Visible = false;
            // 
            // paBottom
            // 
            this.paBottom.Controls.Add(this.btCancel);
            this.paBottom.Controls.Add(this.btSave);
            this.paBottom.Location = new System.Drawing.Point(0, 276);
            this.paBottom.Size = new System.Drawing.Size(423, 42);
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.gcFactorEstequ);
            this.paCenter.Location = new System.Drawing.Point(0, 78);
            this.paCenter.Size = new System.Drawing.Size(423, 198);
            // 
            // paTop
            // 
            this.paTop.Location = new System.Drawing.Point(0, 51);
            this.paTop.Size = new System.Drawing.Size(423, 27);
            this.paTop.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(423, 14);
            this.panelControl1.Visible = false;
            // 
            // gcFactorEstequ
            // 
            this.gcFactorEstequ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFactorEstequ.EmbeddedNavigator.Name = "";
            this.gcFactorEstequ.Location = new System.Drawing.Point(2, 2);
            this.gcFactorEstequ.MainView = this.gvFactorEstequ;
            this.gcFactorEstequ.Name = "gcFactorEstequ";
            this.gcFactorEstequ.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repElement,
            this.repCompound});
            this.gcFactorEstequ.Size = new System.Drawing.Size(419, 194);
            this.gcFactorEstequ.TabIndex = 0;
            this.gcFactorEstequ.UseEmbeddedNavigator = true;
            this.gcFactorEstequ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFactorEstequ});
            // 
            // gvFactorEstequ
            // 
            this.gvFactorEstequ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcol_Idfactor_estequiometrico,
            this.gcol_Idcompound,
            this.gcol_Idelement,
            this.gcol_Factor});
            this.gvFactorEstequ.GridControl = this.gcFactorEstequ;
            this.gvFactorEstequ.Name = "gvFactorEstequ";
            this.gvFactorEstequ.OptionsView.ShowGroupPanel = false;
            // 
            // gcol_Idfactor_estequiometrico
            // 
            this.gcol_Idfactor_estequiometrico.Caption = "gridColumn1";
            this.gcol_Idfactor_estequiometrico.FieldName = "Idfactor_estequiometrico";
            this.gcol_Idfactor_estequiometrico.Name = "gcol_Idfactor_estequiometrico";
            // 
            // gcol_Idcompound
            // 
            this.gcol_Idcompound.Caption = "Compuesto";
            this.gcol_Idcompound.ColumnEdit = this.repCompound;
            this.gcol_Idcompound.FieldName = "Idcompound";
            this.gcol_Idcompound.Name = "gcol_Idcompound";
            this.gcol_Idcompound.Visible = true;
            this.gcol_Idcompound.VisibleIndex = 0;
            // 
            // repCompound
            // 
            this.repCompound.AutoHeight = false;
            this.repCompound.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCompound.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idcompound", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name_compound")});
            this.repCompound.Name = "repCompound";
            this.repCompound.NullText = "Seleccionar";
            this.repCompound.ShowFooter = false;
            this.repCompound.ShowHeader = false;
            // 
            // gcol_Idelement
            // 
            this.gcol_Idelement.Caption = "Compuesto";
            this.gcol_Idelement.ColumnEdit = this.repElement;
            this.gcol_Idelement.FieldName = "Idelement";
            this.gcol_Idelement.Name = "gcol_Idelement";
            this.gcol_Idelement.Visible = true;
            this.gcol_Idelement.VisibleIndex = 2;
            // 
            // repElement
            // 
            this.repElement.AutoHeight = false;
            this.repElement.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repElement.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idelement", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cod_element")});
            this.repElement.Name = "repElement";
            this.repElement.NullText = "Seleccionar";
            this.repElement.ShowFooter = false;
            this.repElement.ShowHeader = false;
            // 
            // gcol_Factor
            // 
            this.gcol_Factor.Caption = ">------- Factor ------->";
            this.gcol_Factor.FieldName = "Factor";
            this.gcol_Factor.Name = "gcol_Factor";
            this.gcol_Factor.Visible = true;
            this.gcol_Factor.VisibleIndex = 1;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(12, 7);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(65, 23);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Guardar";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(83, 7);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(65, 23);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Cancelar";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FormFactorEstequiometrico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 318);
            this.Name = "FormFactorEstequiometrico";
            this.Text = "Factor Estequiométrico";
            this.Load += new System.EventHandler(this.FormFactorEstequiometrico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).EndInit();
            this.paTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            this.paBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFactorEstequ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFactorEstequ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCompound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repElement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcFactorEstequ;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFactorEstequ;
        private DevExpress.XtraGrid.Columns.GridColumn gcol_Idfactor_estequiometrico;
        private DevExpress.XtraGrid.Columns.GridColumn gcol_Idcompound;
        private DevExpress.XtraGrid.Columns.GridColumn gcol_Idelement;
        private DevExpress.XtraGrid.Columns.GridColumn gcol_Factor;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repElement;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCompound;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.SimpleButton btSave;
    }
}