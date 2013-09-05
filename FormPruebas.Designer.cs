namespace LimsProject
{
    partial class FormPruebas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPruebas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcDec_Idmetodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repMetodo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcDec_Parametro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDec_Unidad_medida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repUnidadMedida = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcDec_Criterio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCriterio = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcDec_Valor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDec_Valor2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGenerar1 = new LimsProject.UcGenerar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.memoEdit2 = new DevExpress.XtraEditors.MemoEdit();
            this.ucSign1 = new LimsProject.UcSign();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMetodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repUnidadMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCriterio)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.memoEdit1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textEdit2);
            this.panel1.Controls.Add(this.textEdit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 118);
            this.panel1.TabIndex = 0;
            // 
            // memoEdit1
            // 
            this.memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue");
            this.memoEdit1.Location = new System.Drawing.Point(93, 63);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(438, 49);
            this.memoEdit1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Denominación";
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "DEC-13-001";
            this.textEdit2.Location = new System.Drawing.Point(93, 17);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(107, 20);
            this.textEdit2.TabIndex = 0;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "NTP N° 214.003";
            this.textEdit1.Location = new System.Drawing.Point(93, 40);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(230, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 118);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCriterio,
            this.repUnidadMedida,
            this.repMetodo});
            this.gridControl1.Size = new System.Drawing.Size(811, 219);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcDec_Idmetodo,
            this.gcDec_Parametro,
            this.gcDec_Unidad_medida,
            this.gcDec_Criterio,
            this.gcDec_Valor1,
            this.gcDec_Valor2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gcDec_Idmetodo
            // 
            this.gcDec_Idmetodo.Caption = "Método";
            this.gcDec_Idmetodo.ColumnEdit = this.repMetodo;
            this.gcDec_Idmetodo.FieldName = "Idmetodo";
            this.gcDec_Idmetodo.Name = "gcDec_Idmetodo";
            this.gcDec_Idmetodo.Visible = true;
            this.gcDec_Idmetodo.VisibleIndex = 0;
            // 
            // repMetodo
            // 
            this.repMetodo.AutoHeight = false;
            this.repMetodo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repMetodo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idmetodo", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre")});
            this.repMetodo.Name = "repMetodo";
            this.repMetodo.NullText = "";
            this.repMetodo.ShowFooter = false;
            this.repMetodo.ShowHeader = false;
            // 
            // gcDec_Parametro
            // 
            this.gcDec_Parametro.Caption = "Parametro";
            this.gcDec_Parametro.FieldName = "Parametro";
            this.gcDec_Parametro.Name = "gcDec_Parametro";
            this.gcDec_Parametro.Visible = true;
            this.gcDec_Parametro.VisibleIndex = 1;
            // 
            // gcDec_Unidad_medida
            // 
            this.gcDec_Unidad_medida.Caption = "Unidad_medida";
            this.gcDec_Unidad_medida.ColumnEdit = this.repUnidadMedida;
            this.gcDec_Unidad_medida.FieldName = "Unidad_medida";
            this.gcDec_Unidad_medida.Name = "gcDec_Unidad_medida";
            this.gcDec_Unidad_medida.Visible = true;
            this.gcDec_Unidad_medida.VisibleIndex = 2;
            // 
            // repUnidadMedida
            // 
            this.repUnidadMedida.AutoHeight = false;
            this.repUnidadMedida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repUnidadMedida.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.repUnidadMedida.Name = "repUnidadMedida";
            this.repUnidadMedida.NullText = "";
            this.repUnidadMedida.ShowFooter = false;
            this.repUnidadMedida.ShowHeader = false;
            // 
            // gcDec_Criterio
            // 
            this.gcDec_Criterio.Caption = "Condición";
            this.gcDec_Criterio.ColumnEdit = this.repCriterio;
            this.gcDec_Criterio.FieldName = "Criterio";
            this.gcDec_Criterio.Name = "gcDec_Criterio";
            this.gcDec_Criterio.Visible = true;
            this.gcDec_Criterio.VisibleIndex = 3;
            // 
            // repCriterio
            // 
            this.repCriterio.AutoHeight = false;
            this.repCriterio.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCriterio.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idcriterio", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre_criterio")});
            this.repCriterio.Name = "repCriterio";
            this.repCriterio.NullText = "";
            this.repCriterio.ShowFooter = false;
            this.repCriterio.ShowHeader = false;
            // 
            // gcDec_Valor1
            // 
            this.gcDec_Valor1.Caption = "Valor1";
            this.gcDec_Valor1.FieldName = "Valor1";
            this.gcDec_Valor1.Name = "gcDec_Valor1";
            this.gcDec_Valor1.Visible = true;
            this.gcDec_Valor1.VisibleIndex = 4;
            // 
            // gcDec_Valor2
            // 
            this.gcDec_Valor2.Caption = "Valor2";
            this.gcDec_Valor2.FieldName = "Valor2";
            this.gcDec_Valor2.Name = "gcDec_Valor2";
            this.gcDec_Valor2.Visible = true;
            this.gcDec_Valor2.VisibleIndex = 5;
            // 
            // ucGenerar1
            // 
            this.ucGenerar1.Location = new System.Drawing.Point(339, 87);
            this.ucGenerar1.Margin = new System.Windows.Forms.Padding(0);
            this.ucGenerar1.Name = "ucGenerar1";
            this.ucGenerar1.Size = new System.Drawing.Size(90, 30);
            this.ucGenerar1.TabIndex = 2;
            this.ucGenerar1.Title = "Copiar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.memoEdit2);
            this.panel2.Controls.Add(this.ucSign1);
            this.panel2.Controls.Add(this.ucGenerar1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textEdit5);
            this.panel2.Controls.Add(this.textEdit4);
            this.panel2.Controls.Add(this.textEdit3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 126);
            this.panel2.TabIndex = 3;
            // 
            // memoEdit2
            // 
            this.memoEdit2.EditValue = "La muestra {MUESTRA}, {CONCLUSION} con los Parámetros indicados para la sub categ" +
    "oria A2 de los \"Estandares de Calidad Ambiental Para Agua\",  D.S. N° 002-20008-M" +
    "INAM.";
            this.memoEdit2.Location = new System.Drawing.Point(361, 16);
            this.memoEdit2.Name = "memoEdit2";
            this.memoEdit2.Size = new System.Drawing.Size(438, 49);
            this.memoEdit2.TabIndex = 2;
            // 
            // ucSign1
            // 
            this.ucSign1.Location = new System.Drawing.Point(9, 87);
            this.ucSign1.Margin = new System.Windows.Forms.Padding(0);
            this.ucSign1.Name = "ucSign1";
            this.ucSign1.Pwd = null;
            this.ucSign1.Size = new System.Drawing.Size(158, 40);
            this.ucSign1.TabIndex = 3;
            this.ucSign1.Title = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cumple(solo ensayados)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "nO Cumple";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cumple";
            // 
            // textEdit5
            // 
            this.textEdit5.EditValue = "CUMPLE";
            this.textEdit5.Location = new System.Drawing.Point(93, 73);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(140, 20);
            this.textEdit5.TabIndex = 0;
            // 
            // textEdit4
            // 
            this.textEdit4.EditValue = "CUMPLE";
            this.textEdit4.Location = new System.Drawing.Point(93, 44);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(140, 20);
            this.textEdit4.TabIndex = 0;
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "CUMPLE";
            this.textEdit3.Location = new System.Drawing.Point(93, 15);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(140, 20);
            this.textEdit3.TabIndex = 0;
            // 
            // FormPruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 463);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPruebas";
            this.Text = "FormDecretos";
            this.Load += new System.EventHandler(this.FormDecretos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMetodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repUnidadMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCriterio)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gcDec_Parametro;
        private DevExpress.XtraGrid.Columns.GridColumn gcDec_Unidad_medida;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn gcDec_Criterio;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCriterio;
        private DevExpress.XtraGrid.Columns.GridColumn gcDec_Valor1;
        private DevExpress.XtraGrid.Columns.GridColumn gcDec_Valor2;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gcDec_Idmetodo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repMetodo;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private UcGenerar ucGenerar1;
        private System.Windows.Forms.Panel panel2;
        private UcSign ucSign1;
        private DevExpress.XtraEditors.MemoEdit memoEdit2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
    }
}