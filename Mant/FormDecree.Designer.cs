namespace LimsProject
{
    partial class FormDecree
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
            this.gcDecree = new DevExpress.XtraGrid.GridControl();
            this.gvDecree = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcDec_Idmetodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repMetodo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcDec_Parametro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDec_Unidad_medida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repUnidadMedida = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcDec_Criterio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCriterio = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcDec_Valor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDec_Valor2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.meDescription = new DevExpress.XtraEditors.MemoEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCode = new DevExpress.XtraEditors.TextEdit();
            this.tbName = new DevExpress.XtraEditors.TextEdit();
            this.meConclusion = new DevExpress.XtraEditors.MemoEdit();
            this.ucSign1 = new LimsProject.UcSign();
            this.ucGenerar1 = new LimsProject.UcGenerar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCumpleOnlytest = new DevExpress.XtraEditors.TextEdit();
            this.tbNoCumple = new DevExpress.XtraEditors.TextEdit();
            this.tbCumple = new DevExpress.XtraEditors.TextEdit();
            this.ucToolStrip1 = new LimsProject.UcToolStrip();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).BeginInit();
            this.paTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).BeginInit();
            this.paBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.paCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            this.paTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDecree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDecree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMetodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repUnidadMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCriterio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meConclusion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCumpleOnlytest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNoCumple.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCumple.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.Size = new System.Drawing.Size(895, 39);
            // 
            // paTitle
            // 
            this.paTitle.Location = new System.Drawing.Point(0, 28);
            this.paTitle.Size = new System.Drawing.Size(899, 43);
            this.paTitle.Visible = false;
            // 
            // paBottom
            // 
            this.paBottom.Controls.Add(this.btCancel);
            this.paBottom.Controls.Add(this.meConclusion);
            this.paBottom.Controls.Add(this.ucSign1);
            this.paBottom.Controls.Add(this.ucGenerar1);
            this.paBottom.Controls.Add(this.label6);
            this.paBottom.Controls.Add(this.label5);
            this.paBottom.Controls.Add(this.label4);
            this.paBottom.Controls.Add(this.tbCumpleOnlytest);
            this.paBottom.Controls.Add(this.tbNoCumple);
            this.paBottom.Controls.Add(this.tbCumple);
            this.paBottom.Location = new System.Drawing.Point(0, 368);
            this.paBottom.Size = new System.Drawing.Size(899, 127);
            // 
            // paCenter
            // 
            this.paCenter.Controls.Add(this.gcDecree);
            this.paCenter.Location = new System.Drawing.Point(0, 182);
            this.paCenter.Size = new System.Drawing.Size(899, 186);
            // 
            // paTop
            // 
            this.paTop.Controls.Add(this.meDescription);
            this.paTop.Controls.Add(this.label2);
            this.paTop.Controls.Add(this.label3);
            this.paTop.Controls.Add(this.label1);
            this.paTop.Controls.Add(this.tbCode);
            this.paTop.Controls.Add(this.tbName);
            this.paTop.Location = new System.Drawing.Point(0, 71);
            this.paTop.Size = new System.Drawing.Size(899, 111);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ucToolStrip1);
            this.panelControl1.Size = new System.Drawing.Size(899, 28);
            // 
            // gcDecree
            // 
            this.gcDecree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDecree.EmbeddedNavigator.Name = "";
            this.gcDecree.Location = new System.Drawing.Point(2, 2);
            this.gcDecree.MainView = this.gvDecree;
            this.gcDecree.Name = "gcDecree";
            this.gcDecree.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCriterio,
            this.repUnidadMedida,
            this.repMetodo});
            this.gcDecree.Size = new System.Drawing.Size(895, 182);
            this.gcDecree.TabIndex = 2;
            this.gcDecree.UseEmbeddedNavigator = true;
            this.gcDecree.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDecree});
            // 
            // gvDecree
            // 
            this.gvDecree.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcDec_Idmetodo,
            this.gcDec_Parametro,
            this.gcDec_Unidad_medida,
            this.gcDec_Criterio,
            this.gcDec_Valor1,
            this.gcDec_Valor2});
            this.gvDecree.GridControl = this.gcDecree;
            this.gvDecree.Name = "gvDecree";
            this.gvDecree.OptionsView.RowAutoHeight = true;
            this.gvDecree.OptionsView.ShowGroupPanel = false;
            // 
            // gcDec_Idmetodo
            // 
            this.gcDec_Idmetodo.Caption = "Método";
            this.gcDec_Idmetodo.ColumnEdit = this.repMetodo;
            this.gcDec_Idmetodo.FieldName = "Idtemplate_method";
            this.gcDec_Idmetodo.Name = "gcDec_Idmetodo";
            this.gcDec_Idmetodo.Visible = true;
            this.gcDec_Idmetodo.VisibleIndex = 0;
            this.gcDec_Idmetodo.Width = 369;
            // 
            // repMetodo
            // 
            this.repMetodo.Appearance.Options.UseTextOptions = true;
            this.repMetodo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repMetodo.AutoHeight = false;
            this.repMetodo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repMetodo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name")});
            this.repMetodo.Name = "repMetodo";
            this.repMetodo.NullText = "";
            this.repMetodo.ShowFooter = false;
            this.repMetodo.ShowHeader = false;
            // 
            // gcDec_Parametro
            // 
            this.gcDec_Parametro.Caption = "Parametro";
            this.gcDec_Parametro.FieldName = "Parameter";
            this.gcDec_Parametro.Name = "gcDec_Parametro";
            this.gcDec_Parametro.Visible = true;
            this.gcDec_Parametro.VisibleIndex = 1;
            this.gcDec_Parametro.Width = 107;
            // 
            // gcDec_Unidad_medida
            // 
            this.gcDec_Unidad_medida.Caption = "Unidad_medida";
            this.gcDec_Unidad_medida.ColumnEdit = this.repUnidadMedida;
            this.gcDec_Unidad_medida.FieldName = "Idunit";
            this.gcDec_Unidad_medida.Name = "gcDec_Unidad_medida";
            this.gcDec_Unidad_medida.Visible = true;
            this.gcDec_Unidad_medida.VisibleIndex = 2;
            this.gcDec_Unidad_medida.Width = 117;
            // 
            // repUnidadMedida
            // 
            this.repUnidadMedida.AutoHeight = false;
            this.repUnidadMedida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repUnidadMedida.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name_unit"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idunit", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.repUnidadMedida.Name = "repUnidadMedida";
            this.repUnidadMedida.NullText = "";
            this.repUnidadMedida.ShowFooter = false;
            this.repUnidadMedida.ShowHeader = false;
            // 
            // gcDec_Criterio
            // 
            this.gcDec_Criterio.Caption = "Condición";
            this.gcDec_Criterio.ColumnEdit = this.repCriterio;
            this.gcDec_Criterio.FieldName = "Idcondition";
            this.gcDec_Criterio.Name = "gcDec_Criterio";
            this.gcDec_Criterio.Visible = true;
            this.gcDec_Criterio.VisibleIndex = 3;
            this.gcDec_Criterio.Width = 96;
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
            this.gcDec_Valor1.Width = 107;
            // 
            // gcDec_Valor2
            // 
            this.gcDec_Valor2.Caption = "Valor2";
            this.gcDec_Valor2.FieldName = "Valor2";
            this.gcDec_Valor2.Name = "gcDec_Valor2";
            this.gcDec_Valor2.Visible = true;
            this.gcDec_Valor2.VisibleIndex = 5;
            this.gcDec_Valor2.Width = 110;
            // 
            // meDescription
            // 
            this.meDescription.EditValue = "";
            this.meDescription.Location = new System.Drawing.Point(98, 54);
            this.meDescription.Name = "meDescription";
            this.meDescription.Size = new System.Drawing.Size(438, 49);
            this.meDescription.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Denominación";
            // 
            // tbCode
            // 
            this.tbCode.EditValue = "";
            this.tbCode.Location = new System.Drawing.Point(98, 8);
            this.tbCode.Name = "tbCode";
            this.tbCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(222)))), ((int)(((byte)(243)))));
            this.tbCode.Properties.Appearance.Options.UseBackColor = true;
            this.tbCode.Properties.ReadOnly = true;
            this.tbCode.Size = new System.Drawing.Size(107, 20);
            this.tbCode.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.EditValue = "";
            this.tbName.Location = new System.Drawing.Point(98, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(230, 20);
            this.tbName.TabIndex = 4;
            // 
            // meConclusion
            // 
            this.meConclusion.EditValue = "La muestra {MUESTRA}, {CONCLUSION} con los Parámetros indicados para ";
            this.meConclusion.Location = new System.Drawing.Point(358, 12);
            this.meConclusion.Name = "meConclusion";
            this.meConclusion.Size = new System.Drawing.Size(438, 49);
            this.meConclusion.TabIndex = 10;
            // 
            // ucSign1
            // 
            this.ucSign1.Location = new System.Drawing.Point(9, 80);
            this.ucSign1.Margin = new System.Windows.Forms.Padding(0);
            this.ucSign1.Name = "ucSign1";
            this.ucSign1.Pwd = null;
            this.ucSign1.Size = new System.Drawing.Size(158, 40);
            this.ucSign1.TabIndex = 12;
            this.ucSign1.Title = "";
            this.ucSign1.OnSign += new LimsProject.sign(this.ucSign1_OnSign);
            // 
            // ucGenerar1
            // 
            this.ucGenerar1.Location = new System.Drawing.Point(358, 97);
            this.ucGenerar1.Margin = new System.Windows.Forms.Padding(0);
            this.ucGenerar1.Name = "ucGenerar1";
            this.ucGenerar1.Size = new System.Drawing.Size(90, 23);
            this.ucGenerar1.TabIndex = 11;
            this.ucGenerar1.Title = "Copiar";
            this.ucGenerar1.onSelectedIndex += new LimsProject.SelectedIndex(this.ucGenerar1_onSelectedIndex);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cumple(solo ensayados)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "No cumple";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cumple";
            // 
            // tbCumpleOnlytest
            // 
            this.tbCumpleOnlytest.EditValue = "CUMPLE";
            this.tbCumpleOnlytest.Location = new System.Drawing.Point(152, 55);
            this.tbCumpleOnlytest.Name = "tbCumpleOnlytest";
            this.tbCumpleOnlytest.Size = new System.Drawing.Size(140, 20);
            this.tbCumpleOnlytest.TabIndex = 4;
            // 
            // tbNoCumple
            // 
            this.tbNoCumple.EditValue = "CUMPLE";
            this.tbNoCumple.Location = new System.Drawing.Point(152, 33);
            this.tbNoCumple.Name = "tbNoCumple";
            this.tbNoCumple.Size = new System.Drawing.Size(140, 20);
            this.tbNoCumple.TabIndex = 5;
            // 
            // tbCumple
            // 
            this.tbCumple.EditValue = "CUMPLE";
            this.tbCumple.Location = new System.Drawing.Point(152, 11);
            this.tbCumple.Name = "tbCumple";
            this.tbCumple.Size = new System.Drawing.Size(140, 20);
            this.tbCumple.TabIndex = 6;
            // 
            // ucToolStrip1
            // 
            this.ucToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucToolStrip1.Location = new System.Drawing.Point(2, 2);
            this.ucToolStrip1.Name = "ucToolStrip1";
            this.ucToolStrip1.Size = new System.Drawing.Size(895, 24);
            this.ucToolStrip1.TabIndex = 0;
            this.ucToolStrip1.onFind += new LimsProject.Find(this.ucToolStrip1_onFind);
            this.ucToolStrip1.onNew += new LimsProject.New(this.ucToolStrip1_onNew);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(200, 97);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 13;
            this.btCancel.Text = "Cancelar";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FormDecree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 495);
            this.Name = "FormDecree";
            this.Text = "Decretos";
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).EndInit();
            this.paTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            this.paBottom.ResumeLayout(false);
            this.paBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.paCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            this.paTop.ResumeLayout(false);
            this.paTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDecree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDecree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMetodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repUnidadMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCriterio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meConclusion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCumpleOnlytest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNoCumple.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCumple.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDecree;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDecree;
        private DevExpress.XtraGrid.Columns.GridColumn gcDec_Idmetodo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repMetodo;
        private DevExpress.XtraGrid.Columns.GridColumn gcDec_Parametro;
        private DevExpress.XtraGrid.Columns.GridColumn gcDec_Unidad_medida;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn gcDec_Criterio;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCriterio;
        private DevExpress.XtraGrid.Columns.GridColumn gcDec_Valor1;
        private DevExpress.XtraGrid.Columns.GridColumn gcDec_Valor2;
        private DevExpress.XtraEditors.MemoEdit meDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit tbCode;
        private DevExpress.XtraEditors.TextEdit tbName;
        private DevExpress.XtraEditors.MemoEdit meConclusion;
        private UcSign ucSign1;
        private UcGenerar ucGenerar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit tbCumpleOnlytest;
        private DevExpress.XtraEditors.TextEdit tbNoCumple;
        private DevExpress.XtraEditors.TextEdit tbCumple;
        private UcToolStrip ucToolStrip1;
        private DevExpress.XtraEditors.SimpleButton btCancel;
    }
}