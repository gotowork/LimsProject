namespace LimsProject
{
    partial class UcHumidityAnalysis
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.deStdSolDatePrep = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.tbSymbol = new DevExpress.XtraEditors.TextEdit();
            this.cbUnit_result = new DevExpress.XtraEditors.LookUpEdit();
            this.label119 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deStdSolDatePrep)).BeginInit();
            this.deStdSolDatePrep.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSymbol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnit_result.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // deStdSolDatePrep
            // 
            this.deStdSolDatePrep.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.deStdSolDatePrep.Appearance.Options.UseBackColor = true;
            this.deStdSolDatePrep.AppearancePage.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(222)))), ((int)(((byte)(243)))));
            this.deStdSolDatePrep.AppearancePage.Header.BorderColor = System.Drawing.Color.White;
            this.deStdSolDatePrep.AppearancePage.Header.Options.UseBackColor = true;
            this.deStdSolDatePrep.AppearancePage.Header.Options.UseBorderColor = true;
            this.deStdSolDatePrep.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.LightSteelBlue;
            this.deStdSolDatePrep.AppearancePage.HeaderActive.BorderColor = System.Drawing.Color.Gainsboro;
            this.deStdSolDatePrep.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.deStdSolDatePrep.AppearancePage.HeaderActive.Options.UseBorderColor = true;
            this.deStdSolDatePrep.AppearancePage.PageClient.BorderColor = System.Drawing.Color.Gainsboro;
            this.deStdSolDatePrep.AppearancePage.PageClient.Options.UseBorderColor = true;
            this.deStdSolDatePrep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deStdSolDatePrep.Location = new System.Drawing.Point(0, 0);
            this.deStdSolDatePrep.Name = "deStdSolDatePrep";
            this.deStdSolDatePrep.PaintStyleName = "PropertyView";
            this.deStdSolDatePrep.SelectedTabPage = this.xtraTabPage5;
            this.deStdSolDatePrep.Size = new System.Drawing.Size(694, 331);
            this.deStdSolDatePrep.TabIndex = 2;
            this.deStdSolDatePrep.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage5});
            this.deStdSolDatePrep.Text = "Material de Referenci";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.tbSymbol);
            this.xtraTabPage5.Controls.Add(this.cbUnit_result);
            this.xtraTabPage5.Controls.Add(this.label119);
            this.xtraTabPage5.Controls.Add(this.label35);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(692, 310);
            this.xtraTabPage5.Text = "Resultado";
            // 
            // tbSymbol
            // 
            this.tbSymbol.Location = new System.Drawing.Point(91, 21);
            this.tbSymbol.Name = "tbSymbol";
            this.tbSymbol.Size = new System.Drawing.Size(120, 20);
            this.tbSymbol.TabIndex = 29;
            // 
            // cbUnit_result
            // 
            this.cbUnit_result.Location = new System.Drawing.Point(91, 43);
            this.cbUnit_result.Name = "cbUnit_result";
            this.cbUnit_result.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUnit_result.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Idunit", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name_unit")});
            this.cbUnit_result.Properties.NullText = "Seleccionar";
            this.cbUnit_result.Properties.ShowFooter = false;
            this.cbUnit_result.Properties.ShowHeader = false;
            this.cbUnit_result.Size = new System.Drawing.Size(120, 20);
            this.cbUnit_result.TabIndex = 11;
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label119.Location = new System.Drawing.Point(16, 24);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(49, 13);
            this.label119.TabIndex = 2;
            this.label119.Text = "Símbolo:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(16, 46);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(56, 13);
            this.label35.TabIndex = 2;
            this.label35.Text = "U.Medida:";
            // 
            // UcHumidityAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deStdSolDatePrep);
            this.Name = "UcHumidityAnalysis";
            this.Size = new System.Drawing.Size(694, 331);
            ((System.ComponentModel.ISupportInitialize)(this.deStdSolDatePrep)).EndInit();
            this.deStdSolDatePrep.ResumeLayout(false);
            this.xtraTabPage5.ResumeLayout(false);
            this.xtraTabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSymbol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnit_result.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl deStdSolDatePrep;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraEditors.TextEdit tbSymbol;
        private DevExpress.XtraEditors.LookUpEdit cbUnit_result;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.Label label35;
    }
}
