namespace LimsProject
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.grProcess = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiPrueba = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiSolution = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiMethod = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiReception = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiModuloQaQc = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiAuthorizations = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiPrice = new DevExpress.XtraNavBar.NavBarItem();
            this.grMant = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiDecrees = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiItemMatrix = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiGroupMatrix = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiElement = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiMaterialReference = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTypeSample = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTypeSolution = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiDigestion = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiDescSample = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiClient = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiMeasurement_unit = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiConvertUM = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiCorrelative = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiReactive = new DevExpress.XtraNavBar.NavBarItem();
            this.grSecurity = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiUsers = new DevExpress.XtraNavBar.NavBarItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barBottom = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barUsuario = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barHora = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.baritemModulo = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.baritemBoton = new DevExpress.XtraBars.BarButtonItem();
            this.baritemAccion = new DevExpress.XtraBars.BarStaticItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btFind = new DevExpress.XtraBars.BarButtonItem();
            this.btPrevius = new DevExpress.XtraBars.BarButtonItem();
            this.btNext = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.expandablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.grProcess;
            this.navBarControl1.BackColor = System.Drawing.Color.Transparent;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.grProcess,
            this.grMant,
            this.grSecurity});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiMethod,
            this.nbiDigestion,
            this.nbiTypeSample,
            this.nbiElement,
            this.nbiReception,
            this.nbiDescSample,
            this.nbiClient,
            this.nbiMeasurement_unit,
            this.nbiConvertUM,
            this.nbiCorrelative,
            this.nbiMaterialReference,
            this.nbiModuloQaQc,
            this.nbiUsers,
            this.nbiSolution,
            this.nbiTypeSolution,
            this.nbiAuthorizations,
            this.nbiReactive,
            this.nbiPrice,
            this.nbiGroupMatrix,
            this.nbiItemMatrix,
            this.nbiDecrees,
            this.nbiPrueba});
            this.navBarControl1.Location = new System.Drawing.Point(0, 26);
            this.navBarControl1.LookAndFeel.SkinName = "Money Twins";
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.navBarControl1.Size = new System.Drawing.Size(166, 423);
            this.navBarControl1.TabIndex = 14;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Money Twins");
            // 
            // grProcess
            // 
            this.grProcess.Caption = "Procesos";
            this.grProcess.Expanded = true;
            this.grProcess.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiPrueba),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiSolution),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiMethod),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReception),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiModuloQaQc),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiAuthorizations),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiPrice)});
            this.grProcess.Name = "grProcess";
            // 
            // nbiPrueba
            // 
            this.nbiPrueba.Caption = "Preparación de Muestras";
            this.nbiPrueba.Name = "nbiPrueba";
            this.nbiPrueba.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiPrueba_LinkClicked);
            // 
            // nbiSolution
            // 
            this.nbiSolution.Caption = "Preparación de soluciones";
            this.nbiSolution.Name = "nbiSolution";
            this.nbiSolution.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiSolution_LinkClicked);
            // 
            // nbiMethod
            // 
            this.nbiMethod.Caption = "Métodos";
            this.nbiMethod.Name = "nbiMethod";
            this.nbiMethod.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiMethod_LinkClicked);
            // 
            // nbiReception
            // 
            this.nbiReception.Caption = "Registro de Recepción";
            this.nbiReception.Name = "nbiReception";
            this.nbiReception.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiReception_LinkClicked);
            // 
            // nbiModuloQaQc
            // 
            this.nbiModuloQaQc.Caption = "Módulo QaQc";
            this.nbiModuloQaQc.Name = "nbiModuloQaQc";
            this.nbiModuloQaQc.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiModuloQaQc_LinkClicked);
            // 
            // nbiAuthorizations
            // 
            this.nbiAuthorizations.Caption = "Autorizaciones";
            this.nbiAuthorizations.Name = "nbiAuthorizations";
            this.nbiAuthorizations.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiAuthorizations_LinkClicked);
            // 
            // nbiPrice
            // 
            this.nbiPrice.Caption = "Cotizaciones";
            this.nbiPrice.Name = "nbiPrice";
            this.nbiPrice.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiPrice_LinkClicked);
            // 
            // grMant
            // 
            this.grMant.Caption = "Mantenimientos";
            this.grMant.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDecrees),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiItemMatrix),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiGroupMatrix),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiElement),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiMaterialReference),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTypeSample),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTypeSolution),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDigestion),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDescSample),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiClient),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiMeasurement_unit),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiConvertUM),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiCorrelative),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReactive)});
            this.grMant.Name = "grMant";
            // 
            // nbiDecrees
            // 
            this.nbiDecrees.Caption = "Decretos";
            this.nbiDecrees.Name = "nbiDecrees";
            this.nbiDecrees.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiDecrees_LinkClicked);
            // 
            // nbiItemMatrix
            // 
            this.nbiItemMatrix.Caption = "Matriz";
            this.nbiItemMatrix.Name = "nbiItemMatrix";
            this.nbiItemMatrix.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiItemMatrix_LinkClicked);
            // 
            // nbiGroupMatrix
            // 
            this.nbiGroupMatrix.Caption = "Grupo de Matriz";
            this.nbiGroupMatrix.Name = "nbiGroupMatrix";
            this.nbiGroupMatrix.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiGroupMatrix_LinkClicked);
            // 
            // nbiElement
            // 
            this.nbiElement.Caption = "Elemento";
            this.nbiElement.Name = "nbiElement";
            this.nbiElement.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiElement_LinkClicked);
            // 
            // nbiMaterialReference
            // 
            this.nbiMaterialReference.Appearance.Options.UseTextOptions = true;
            this.nbiMaterialReference.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.nbiMaterialReference.Caption = "Material de Referencia y Sales";
            this.nbiMaterialReference.Name = "nbiMaterialReference";
            this.nbiMaterialReference.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiMaterialReference_LinkClicked);
            // 
            // nbiTypeSample
            // 
            this.nbiTypeSample.Caption = "Tipo de muestra";
            this.nbiTypeSample.Name = "nbiTypeSample";
            this.nbiTypeSample.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTypeSample_LinkClicked);
            // 
            // nbiTypeSolution
            // 
            this.nbiTypeSolution.Caption = "Tipo de Soluciones";
            this.nbiTypeSolution.Name = "nbiTypeSolution";
            this.nbiTypeSolution.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTypeSolution_LinkClicked);
            // 
            // nbiDigestion
            // 
            this.nbiDigestion.Caption = "Digestion";
            this.nbiDigestion.Name = "nbiDigestion";
            this.nbiDigestion.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiDigestion_LinkClicked);
            // 
            // nbiDescSample
            // 
            this.nbiDescSample.Caption = "Descripción de Muestra";
            this.nbiDescSample.Name = "nbiDescSample";
            this.nbiDescSample.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiDescSample_LinkClicked);
            // 
            // nbiClient
            // 
            this.nbiClient.Caption = "Empresa";
            this.nbiClient.Name = "nbiClient";
            this.nbiClient.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiClient_LinkClicked);
            // 
            // nbiMeasurement_unit
            // 
            this.nbiMeasurement_unit.Caption = "Unidad de Medida";
            this.nbiMeasurement_unit.Name = "nbiMeasurement_unit";
            this.nbiMeasurement_unit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiMeasurement_unit_LinkClicked);
            // 
            // nbiConvertUM
            // 
            this.nbiConvertUM.Caption = "Conversion UM";
            this.nbiConvertUM.Name = "nbiConvertUM";
            this.nbiConvertUM.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiConvertUM_LinkClicked);
            // 
            // nbiCorrelative
            // 
            this.nbiCorrelative.Caption = "Correlativos";
            this.nbiCorrelative.Name = "nbiCorrelative";
            this.nbiCorrelative.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiCorrelative_LinkClicked);
            // 
            // nbiReactive
            // 
            this.nbiReactive.Caption = "Reactivos";
            this.nbiReactive.Name = "nbiReactive";
            this.nbiReactive.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiReactive_LinkClicked);
            // 
            // grSecurity
            // 
            this.grSecurity.Caption = "Seguridad";
            this.grSecurity.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiUsers)});
            this.grSecurity.Name = "grSecurity";
            // 
            // nbiUsers
            // 
            this.nbiUsers.Caption = "Crear Usuarios";
            this.nbiUsers.Name = "nbiUsers";
            this.nbiUsers.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiUsers_LinkClicked);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.barBottom,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageList1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barUsuario,
            this.barSubItem1,
            this.barButtonItem1,
            this.barStaticItem2,
            this.barHora,
            this.barStaticItem3,
            this.baritemModulo,
            this.barStaticItem4,
            this.baritemBoton,
            this.baritemAccion,
            this.btFind,
            this.barSubItem2,
            this.barToolbarsListItem1,
            this.barMdiChildrenListItem1,
            this.btPrevius,
            this.btNext});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 21;
            this.barManager1.StatusBar = this.barBottom;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 1";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Menú";
            this.barSubItem1.Id = 2;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barBottom
            // 
            this.barBottom.BarName = "Custom 2";
            this.barBottom.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barBottom.DockCol = 0;
            this.barBottom.DockRow = 0;
            this.barBottom.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barBottom.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barUsuario),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barHora),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.baritemModulo),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.baritemBoton),
            new DevExpress.XtraBars.LinkPersistInfo(this.baritemAccion)});
            this.barBottom.OptionsBar.AllowQuickCustomization = false;
            this.barBottom.OptionsBar.DrawDragBorder = false;
            this.barBottom.OptionsBar.UseWholeRow = true;
            this.barBottom.Text = "Custom 2";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Usuario:";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.OwnFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.barStaticItem1.UseOwnFont = true;
            // 
            // barUsuario
            // 
            this.barUsuario.Id = 1;
            this.barUsuario.Name = "barUsuario";
            this.barUsuario.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Hora:";
            this.barStaticItem2.Id = 4;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.OwnFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            this.barStaticItem2.UseOwnFont = true;
            // 
            // barHora
            // 
            this.barHora.Id = 5;
            this.barHora.Name = "barHora";
            this.barHora.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "Módulo:";
            this.barStaticItem3.Id = 6;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.OwnFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            this.barStaticItem3.UseOwnFont = true;
            // 
            // baritemModulo
            // 
            this.baritemModulo.Id = 7;
            this.baritemModulo.Name = "baritemModulo";
            this.baritemModulo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Caption = "Accion:";
            this.barStaticItem4.Id = 8;
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.OwnFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.barStaticItem4.TextAlignment = System.Drawing.StringAlignment.Near;
            this.barStaticItem4.UseOwnFont = true;
            // 
            // baritemBoton
            // 
            this.baritemBoton.Id = 10;
            this.baritemBoton.Name = "baritemBoton";
            // 
            // baritemAccion
            // 
            this.baritemAccion.Id = 11;
            this.baritemAccion.Name = "baritemAccion";
            this.baritemAccion.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bar3
            // 
            this.bar3.BarName = "Custom 3";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 1;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btFind),
            new DevExpress.XtraBars.LinkPersistInfo(this.btPrevius),
            new DevExpress.XtraBars.LinkPersistInfo(this.btNext)});
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Custom 3";
            this.bar3.Visible = false;
            // 
            // btFind
            // 
            this.btFind.Caption = "Buscar";
            this.btFind.Id = 12;
            this.btFind.ImageIndex = 2;
            this.btFind.Name = "btFind";
            this.btFind.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btFind_ItemClick);
            // 
            // btPrevius
            // 
            this.btPrevius.Caption = "barButtonItem2";
            this.btPrevius.Id = 18;
            this.btPrevius.ImageIndex = 4;
            this.btPrevius.Name = "btPrevius";
            this.btPrevius.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btPrevius_ItemClick);
            // 
            // btNext
            // 
            this.btNext.Caption = "barButtonItem2";
            this.btNext.Id = 19;
            this.btNext.ImageIndex = 3;
            this.btNext.Name = "btNext";
            this.btNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btNext_ItemClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "confirmacion.png");
            this.imageList1.Images.SetKeyName(1, "error.png");
            this.imageList1.Images.SetKeyName(2, "find.png");
            this.imageList1.Images.SetKeyName(3, "next.png");
            this.imageList1.Images.SetKeyName(4, "previus.png");
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "prueba";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "barSubItem2";
            this.barSubItem2.Id = 13;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barToolbarsListItem1
            // 
            this.barToolbarsListItem1.Caption = "barToolbarsListItem1";
            this.barToolbarsListItem1.Id = 15;
            this.barToolbarsListItem1.Name = "barToolbarsListItem1";
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
            this.barMdiChildrenListItem1.Id = 16;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.LeftToRight;
            this.expandablePanel1.Controls.Add(this.navBarControl1);
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 24);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(166, 449);
            this.expandablePanel1.TabIndex = 16;
            this.expandablePanel1.Text = "expandablePanel1";
            this.expandablePanel1.TitleText = "Lista de Módulos";
            this.expandablePanel1.Visible = false;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Lilian";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(643, 499);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.Text = "LimsProject";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.expandablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup grProcess;
        private DevExpress.XtraNavBar.NavBarItem nbiMethod;
        private DevExpress.XtraNavBar.NavBarGroup grMant;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.Bar barBottom;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barUsuario;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem barHora;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarStaticItem baritemModulo;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
        private DevExpress.XtraNavBar.NavBarItem nbiDigestion;
        private DevExpress.XtraNavBar.NavBarItem nbiElement;
        private DevExpress.XtraNavBar.NavBarItem nbiTypeSample;
        private DevExpress.XtraBars.BarButtonItem baritemBoton;
        private DevExpress.XtraBars.BarStaticItem baritemAccion;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraNavBar.NavBarItem nbiReception;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevExpress.XtraNavBar.NavBarItem nbiDescSample;
        private DevExpress.XtraNavBar.NavBarItem nbiClient;
        private DevExpress.XtraNavBar.NavBarItem nbiMeasurement_unit;
        private DevExpress.XtraNavBar.NavBarItem nbiConvertUM;
        private DevExpress.XtraNavBar.NavBarItem nbiCorrelative;
        private DevExpress.XtraNavBar.NavBarItem nbiMaterialReference;
        private DevExpress.XtraNavBar.NavBarItem nbiModuloQaQc;
        private DevExpress.XtraNavBar.NavBarGroup grSecurity;
        private DevExpress.XtraNavBar.NavBarItem nbiUsers;
        private DevExpress.XtraNavBar.NavBarItem nbiSolution;
        private DevExpress.XtraNavBar.NavBarItem nbiTypeSolution;
        private DevExpress.XtraNavBar.NavBarItem nbiAuthorizations;
        private DevExpress.XtraNavBar.NavBarItem nbiReactive;
        private DevExpress.XtraNavBar.NavBarItem nbiPrice;
        private DevExpress.XtraBars.BarButtonItem btFind;
        private DevExpress.XtraBars.BarButtonItem btPrevius;
        private DevExpress.XtraBars.BarButtonItem btNext;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraNavBar.NavBarItem nbiItemMatrix;
        private DevExpress.XtraNavBar.NavBarItem nbiGroupMatrix;
        private DevExpress.XtraNavBar.NavBarItem nbiDecrees;
        private DevExpress.XtraNavBar.NavBarItem nbiPrueba;

    }
}