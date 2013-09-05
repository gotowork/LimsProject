namespace LimsProject
{
    partial class ctTreeProcessStage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctTreeProcessStage));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeProcessStage = new DevExpress.XtraTreeList.TreeList();
            this.trID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trParentID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trOrder = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trIdprocess = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trIdprocess_stage = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trIdtray = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trFlag_ticket = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trIdtemplate_method_process_stage = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.cbProcess = new LimsProject.ctComboBoxLike();
            this.cbStage = new LimsProject.ctComboBoxLike();
            this.btUpProcess = new DevExpress.XtraEditors.SimpleButton();
            this.btUpStage = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.treeProcessStage)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "down.png");
            this.imageList1.Images.SetKeyName(1, "up.png");
            this.imageList1.Images.SetKeyName(2, "process.png");
            this.imageList1.Images.SetKeyName(3, "stage.png");
            this.imageList1.Images.SetKeyName(4, "select.png");
            // 
            // treeProcessStage
            // 
            this.treeProcessStage.AllowDrop = true;
            this.treeProcessStage.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.trID,
            this.trParentID,
            this.trName,
            this.trOrder,
            this.trIdprocess,
            this.trIdprocess_stage,
            this.trIdtray,
            this.trFlag_ticket,
            this.trIdtemplate_method_process_stage});
            this.treeProcessStage.KeyFieldName = "Id";
            this.treeProcessStage.Location = new System.Drawing.Point(39, 8);
            this.treeProcessStage.Name = "treeProcessStage";
            this.treeProcessStage.OptionsBehavior.DragNodes = true;
            this.treeProcessStage.ParentFieldName = "Parentid";
            this.treeProcessStage.SelectImageList = this.imageList1;
            this.treeProcessStage.Size = new System.Drawing.Size(478, 274);
            this.treeProcessStage.TabIndex = 10;
            this.treeProcessStage.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeProcessStage_DragDrop);
            // 
            // trID
            // 
            this.trID.Caption = "ID";
            this.trID.FieldName = "Id";
            this.trID.MinWidth = 27;
            this.trID.Name = "trID";
            this.trID.OptionsColumn.AllowEdit = false;
            this.trID.OptionsColumn.ReadOnly = true;
            this.trID.VisibleIndex = 0;
            this.trID.Width = 115;
            // 
            // trParentID
            // 
            this.trParentID.Caption = "ParentID";
            this.trParentID.FieldName = "Parentid";
            this.trParentID.Name = "trParentID";
            this.trParentID.VisibleIndex = 1;
            this.trParentID.Width = 114;
            // 
            // trName
            // 
            this.trName.Caption = "Proceso";
            this.trName.FieldName = "Name_process_stage";
            this.trName.Name = "trName";
            this.trName.VisibleIndex = 2;
            this.trName.Width = 175;
            // 
            // trOrder
            // 
            this.trOrder.Caption = "Orden";
            this.trOrder.FieldName = "Order_process_stage";
            this.trOrder.Name = "trOrder";
            this.trOrder.VisibleIndex = 3;
            this.trOrder.Width = 53;
            // 
            // trIdprocess
            // 
            this.trIdprocess.Caption = "Idprocess";
            this.trIdprocess.FieldName = "Idprocess";
            this.trIdprocess.Name = "trIdprocess";
            this.trIdprocess.VisibleIndex = 4;
            // 
            // trIdprocess_stage
            // 
            this.trIdprocess_stage.Caption = "Idprocess_stage";
            this.trIdprocess_stage.FieldName = "Idprocess_stage";
            this.trIdprocess_stage.Name = "trIdprocess_stage";
            this.trIdprocess_stage.VisibleIndex = 5;
            // 
            // trIdtray
            // 
            this.trIdtray.Caption = "Idtray";
            this.trIdtray.FieldName = "Idtray";
            this.trIdtray.Name = "trIdtray";
            this.trIdtray.VisibleIndex = 6;
            // 
            // trFlag_ticket
            // 
            this.trFlag_ticket.Caption = "Flag_ticket";
            this.trFlag_ticket.FieldName = "Flag_ticket";
            this.trFlag_ticket.Name = "trFlag_ticket";
            this.trFlag_ticket.VisibleIndex = 7;
            // 
            // trIdtemplate_method_process_stage
            // 
            this.trIdtemplate_method_process_stage.Caption = "Idtemplate_method_process_stage";
            this.trIdtemplate_method_process_stage.FieldName = "Idtemplate_method_process_stage";
            this.trIdtemplate_method_process_stage.Name = "trIdtemplate_method_process_stage";
            this.trIdtemplate_method_process_stage.VisibleIndex = 8;
            // 
            // cbProcess
            // 
            this.cbProcess.BackColor = System.Drawing.Color.Transparent;
            this.cbProcess.EditText = "Seleccionar";
            this.cbProcess.EditValue = null;
            this.cbProcess.FocusColor = System.Drawing.Color.Khaki;
            this.cbProcess.FormAbout = LimsProject.Comun.Formulario.fmElement;
            this.cbProcess.FormFinder = LimsProject.Comun.Formulario.fmElement;
            this.cbProcess.LabelText = "Proceso:";
            this.cbProcess.LabelWidth = 50;
            this.cbProcess.Location = new System.Drawing.Point(39, 289);
            this.cbProcess.Margin = new System.Windows.Forms.Padding(1);
            this.cbProcess.Name = "cbProcess";
            this.cbProcess.Size = new System.Drawing.Size(164, 21);
            this.cbProcess.TabIndex = 11;
            this.cbProcess.TextWidth = 114;
            this.cbProcess.UnFocusColor = System.Drawing.Color.White;
            // 
            // cbStage
            // 
            this.cbStage.BackColor = System.Drawing.Color.Transparent;
            this.cbStage.EditText = "Seleccionar";
            this.cbStage.EditValue = null;
            this.cbStage.FocusColor = System.Drawing.Color.Khaki;
            this.cbStage.FormAbout = LimsProject.Comun.Formulario.fmElement;
            this.cbStage.FormFinder = LimsProject.Comun.Formulario.fmElement;
            this.cbStage.LabelText = "Etapa:";
            this.cbStage.LabelWidth = 40;
            this.cbStage.Location = new System.Drawing.Point(327, 289);
            this.cbStage.Margin = new System.Windows.Forms.Padding(1);
            this.cbStage.Name = "cbStage";
            this.cbStage.Size = new System.Drawing.Size(150, 21);
            this.cbStage.TabIndex = 11;
            this.cbStage.TextWidth = 110;
            this.cbStage.UnFocusColor = System.Drawing.Color.White;
            // 
            // btUpProcess
            // 
            this.btUpProcess.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btUpProcess.ImageIndex = 1;
            this.btUpProcess.ImageList = this.imageList1;
            this.btUpProcess.Location = new System.Drawing.Point(207, 287);
            this.btUpProcess.Name = "btUpProcess";
            this.btUpProcess.Size = new System.Drawing.Size(27, 23);
            this.btUpProcess.TabIndex = 12;
            this.btUpProcess.Click += new System.EventHandler(this.btUpProcess_Click);
            // 
            // btUpStage
            // 
            this.btUpStage.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btUpStage.ImageIndex = 1;
            this.btUpStage.ImageList = this.imageList1;
            this.btUpStage.Location = new System.Drawing.Point(481, 288);
            this.btUpStage.Name = "btUpStage";
            this.btUpStage.Size = new System.Drawing.Size(27, 23);
            this.btUpStage.TabIndex = 12;
            this.btUpStage.Click += new System.EventHandler(this.btUpStage_Click);
            // 
            // ctTreeProcessStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btUpStage);
            this.Controls.Add(this.btUpProcess);
            this.Controls.Add(this.cbStage);
            this.Controls.Add(this.cbProcess);
            this.Controls.Add(this.treeProcessStage);
            this.Name = "ctTreeProcessStage";
            this.Size = new System.Drawing.Size(526, 325);
            ((System.ComponentModel.ISupportInitialize)(this.treeProcessStage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraTreeList.TreeList treeProcessStage;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trParentID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trOrder;
        private ctComboBoxLike cbProcess;
        private ctComboBoxLike cbStage;
        private DevExpress.XtraEditors.SimpleButton btUpProcess;
        private DevExpress.XtraEditors.SimpleButton btUpStage;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trIdprocess;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trIdprocess_stage;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trIdtray;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trFlag_ticket;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trIdtemplate_method_process_stage;
    }
}
