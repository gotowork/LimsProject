namespace LimsProject
{
    partial class ucTreeSolution
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTreeSolution));
            this.treeSolution = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeSolution)).BeginInit();
            this.SuspendLayout();
            // 
            // treeSolution
            // 
            this.treeSolution.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4});
            this.treeSolution.Location = new System.Drawing.Point(3, 31);
            this.treeSolution.Name = "treeSolution";
            this.treeSolution.BeginUnboundLoad();
            this.treeSolution.AppendNode(new object[] {
            "Estandar de Calibración",
            null,
            null,
            null}, -1);
            this.treeSolution.AppendNode(new object[] {
            "Solución Intermedia 1",
            null,
            null,
            null}, -1);
            this.treeSolution.AppendNode(new object[] {
            "Solución Intermedia 2",
            null,
            null,
            null}, -1);
            this.treeSolution.AppendNode(new object[] {
            "Estandar de Verificación",
            null,
            null,
            null}, -1);
            this.treeSolution.AppendNode(new object[] {
            "Solución Titulante",
            null,
            null,
            null}, -1);
            this.treeSolution.EndUnboundLoad();
            this.treeSolution.OptionsBehavior.KeepSelectedOnClick = false;
            this.treeSolution.OptionsBehavior.PopulateServiceColumns = true;
            this.treeSolution.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeSolution.OptionsView.ShowFocusedFrame = false;
            this.treeSolution.OptionsView.ShowHorzLines = false;
            this.treeSolution.OptionsView.ShowIndicator = false;
            this.treeSolution.SelectImageList = this.imageList1;
            this.treeSolution.Size = new System.Drawing.Size(173, 351);
            this.treeSolution.TabIndex = 1;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Nombre";
            this.treeListColumn1.FieldName = "Nombre";
            this.treeListColumn1.MinWidth = 46;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 106;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Idgroup_solution";
            this.treeListColumn2.FieldName = "Idgroup_solution";
            this.treeListColumn2.Name = "treeListColumn2";
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Idmr_detail";
            this.treeListColumn3.FieldName = "Idmr_detail";
            this.treeListColumn3.Name = "treeListColumn3";
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Idsolution_pattern";
            this.treeListColumn4.FieldName = "Idsolution_pattern";
            this.treeListColumn4.Name = "treeListColumn4";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "fiola_group.png");
            this.imageList1.Images.SetKeyName(1, "fiola.png");
            this.imageList1.Images.SetKeyName(2, "fiola_ver.png");
            // 
            // ucTreeSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeSolution);
            this.Name = "ucTreeSolution";
            this.Size = new System.Drawing.Size(179, 405);
            ((System.ComponentModel.ISupportInitialize)(this.treeSolution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeSolution;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private System.Windows.Forms.ImageList imageList1;
    }
}
