namespace LimsProject
{
    partial class FormCompound
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
            this.gcCompound = new DevExpress.XtraGrid.GridControl();
            this.gvCompound = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcol_Idcompound = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcol_Name_compound = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gcCompound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCompound)).BeginInit();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Size = new System.Drawing.Size(403, 39);
            // 
            // paTitle
            // 
            this.paTitle.Size = new System.Drawing.Size(407, 43);
            this.paTitle.Visible = false;
            // 
            // paBottom
            // 
            this.paBottom.Controls.Add(this.btCancel);
            this.paBottom.Controls.Add(this.btSave);
            this.paBottom.Location = new System.Drawing.Point(0, 339);
            this.paBottom.Size = new System.Drawing.Size(407, 40);
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.gcCompound);
            this.paCenter.Location = new System.Drawing.Point(0, 80);
            this.paCenter.Size = new System.Drawing.Size(407, 259);
            // 
            // paTop
            // 
            this.paTop.Size = new System.Drawing.Size(407, 23);
            this.paTop.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(407, 14);
            this.panelControl1.Visible = false;
            // 
            // gcCompound
            // 
            this.gcCompound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCompound.EmbeddedNavigator.Name = "";
            this.gcCompound.Location = new System.Drawing.Point(2, 2);
            this.gcCompound.MainView = this.gvCompound;
            this.gcCompound.Name = "gcCompound";
            this.gcCompound.Size = new System.Drawing.Size(403, 255);
            this.gcCompound.TabIndex = 2;
            this.gcCompound.UseEmbeddedNavigator = true;
            this.gcCompound.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCompound});
            // 
            // gvCompound
            // 
            this.gvCompound.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcol_Idcompound,
            this.gcol_Name_compound});
            this.gvCompound.GridControl = this.gcCompound;
            this.gvCompound.Name = "gvCompound";
            this.gvCompound.OptionsView.ShowGroupPanel = false;
            // 
            // gcol_Idcompound
            // 
            this.gcol_Idcompound.Caption = "Idcompound";
            this.gcol_Idcompound.FieldName = "Idcompound";
            this.gcol_Idcompound.Name = "gcol_Idcompound";
            // 
            // gcol_Name_compound
            // 
            this.gcol_Name_compound.Caption = "Nombre de compuesto";
            this.gcol_Name_compound.FieldName = "Name_compound";
            this.gcol_Name_compound.Name = "gcol_Name_compound";
            this.gcol_Name_compound.Visible = true;
            this.gcol_Name_compound.VisibleIndex = 0;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(12, 6);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(60, 23);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Guardar";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(78, 6);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(60, 23);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Cancelar";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FormCompound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 379);
            this.Name = "FormCompound";
            this.Text = "Compuestos";
            this.Load += new System.EventHandler(this.FormCompound_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).EndInit();
            this.paTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            this.paBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCompound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCompound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btSave;
        private DevExpress.XtraGrid.GridControl gcCompound;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCompound;
        private DevExpress.XtraGrid.Columns.GridColumn gcol_Idcompound;
        private DevExpress.XtraGrid.Columns.GridColumn gcol_Name_compound;
        private DevExpress.XtraEditors.SimpleButton btCancel;
    }
}