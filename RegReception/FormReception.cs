using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LimsProject.BusinessLayer;
using LimsProject.BusinessLayer.Modules;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using LibraryBasicForm;
using System.Text.RegularExpressions;
using DevExpress.Utils;

namespace LimsProject
{
    public partial class FormReception : LibraryBasicForm.FormMantBase
    {

        #region enumerators

        public enum typeColumn
        {
            unique,
            duplicate
        }

        public enum StatusRegRecep
        {
            reg_recep_new,
            reg_recep_saved
        }

        public enum typeModule
        {
            RegisterReception,
            ReceptionAguas
        }        

        public enum LoadData
        {
            Nothing,            // solo se ha aperturado el módulo
            MasterSearchRR,     // cuando se cargan datos desde un buscador en el registro de recepción            
            FromRR_ToExtendRR    // cuando se cargan datos desde un registro de recepción a otro registro de recepción (ampliación de ensayo).            
        }

        #endregion

        #region attributes

        LoadData loadData = LoadData.Nothing;    // para inicialización a partir del botón generar

        StatusRegRecep statusRegReception = StatusRegRecep.reg_recep_new;        

        CFastReportMethods oFastReportMethods = new CFastReportMethods();
        
        DataTable DTReceptionDetail;
        DataTable DTReceptionDetailElem;        
        List<CElement> lstElement = new List<CElement>();
        Dictionary<DevExpress.XtraGrid.Columns.GridColumn, bool> DicShowColumns = new Dictionary<DevExpress.XtraGrid.Columns.GridColumn, bool>();
        
        short IDCompany = 0;        
        Color Partial_report_color = Color.YellowGreen;
        Color Final_report_color = Color.SlateBlue;
        
        List<GridCell[]> lstItemsSelReport = new List<GridCell[]>();        
        Dictionary<short, List<CPositionValue>> DicCellsSavedReport = new Dictionary<short, List<CPositionValue>>();
        List<CPositionValue> LstUnreportData = new List<CPositionValue>();

        List<GridCell[]> lstItemsSelAttach = new List<GridCell[]>();
        Dictionary<int, List<CpositionValueAttach>> DicCellsSavedAttach = new Dictionary<int, List<CpositionValueAttach>>();

        List<GridCell[]> lstItemsSelProgram = new List<GridCell[]>();
        Dictionary<int, List<CPositionValueProgram>> DicCellsSaveProgram = new Dictionary<int, List<CPositionValueProgram>>();
        
        // --- dictionary status report colors --- 1:en creacion, 2:parcial, 3:final
        Dictionary<short, Color> dicColorReport = new Dictionary<short, Color>() { 
            {1, System.Drawing.Color.Orange},
            {2, System.Drawing.Color.YellowGreen},
            {3, System.Drawing.Color.SlateBlue}
        };

        // --- dictionary status attach colors --- 1:en creacion, 2:adjuntado
        Dictionary<short, Color> dicColorAttach = new Dictionary<short, Color>() {
            {1, System.Drawing.Color.Orange},
            {2, System.Drawing.Color.CadetBlue}
        };

        // --- status register
        bool Readonly = false;
        bool FlagRegRecepCopy = false;

        double totalAmount = 0;

        string Path_file_methods = @"E:\Compartido-LAS\2013\procedimientos de ensayo externos";

        typeModule typeModuleOpen;

        CRecep_sample oRecep_sample = null;
        CPrice oPrice = null;
        CPrice_version oPrice_version = null;

        CPrice_versionFactory faPrice_version = new CPrice_versionFactory();
        CRecep_sampleFactory faRecep_sample = new CRecep_sampleFactory();
        CPriceFactory faPrice = new CPriceFactory();


        Dictionary<short, Color> dicStatusReportColor = new Dictionary<short, Color>();


        #endregion

        #region properties

        #endregion

        #region constructor

        public FormReception()
        {
            InitializeComponent();

            Init();
        }

        /// <summary>
        /// inicializa el módulo según el argumento (recepción ó cotización), desde la lista de módulos
        /// </summary>
        /// <param name="p_typeModule"></param>
        public FormReception(typeModule p_typeModule)
        {
            InitializeComponent();

            loadData = LoadData.Nothing;

            typeModuleOpen = p_typeModule;

            Init();
            
            ChangeStatusControls();
                       
        }

        /// <summary>
        /// inicializa un nuevo registro de recepción a partir de otro
        /// </summary>
        /// <param name="pRecep_sample"></param>
        public FormReception(CRecep_sample pRecep_sample, LoadData generic)
        {
            InitializeComponent();

            oRecep_sample = pRecep_sample;            

            loadData = generic;

            // --- crear a un nuevo registro de recepción
            if (loadData == LoadData.FromRR_ToExtendRR)
                FlagRegRecepCopy = true;

            typeModuleOpen = typeModule.RegisterReception;

            Init();            
           
            Recuperar_Registro();

            ChangeStatusControls();

            statusRegReception = StatusRegRecep.reg_recep_saved;
        }

        /// <summary>
        /// inicializa un nuevo registro de recepción desde una cotización
        /// </summary>
        /// <param name="pPrice_version"></param>
        public FormReception(CPrice_version pPrice_version, LoadData generic)
        {
            InitializeComponent();

            loadData = generic;            

            Init();
            
            Recuperar_Registro();

            ChangeStatusControls();
            
            statusRegReception = StatusRegRecep.reg_recep_saved;
        }

        void InitAppareance()
        {
            if (typeModuleOpen == typeModule.RegisterReception)
            {
                //botones
                ucGenerarA.InitItems(new List<string> { "Ampliación de ensayo" });

                ucGenerarDesde.InitItems(new List<string> { "Cotización" });

                for (int i = 0; i < gvReception.Columns.Count; i++)
                    gvReception.Columns[i].Visible = false;

                //título y códigos
                this.Text = "Registro de Recepción";
                ucTitleRegisterRecep.Title = "Registro de Recepción";
                ucTitleRegisterRecep.SetColor(UcTitle.ColorTitle.BlueSky);                
                paCodRegisterRecep.Visible = true;

                tpAnexos.PageVisible = false;

                tpReject.PageVisible = false;

                tpDecree.PageVisible = false;

                gcRec_Description.VisibleIndex = gvReception.Columns.Count;
                gcRec_Type_Sample.VisibleIndex = gvReception.Columns.Count;
                gcRec_Procedence.Visible = true;
                gcRec_Code.VisibleIndex = gvReception.Columns.Count;
                gcRec_NameSample.VisibleIndex = gvReception.Columns.Count;
                gcRec_Flag_envelope_sealed.VisibleIndex = gvReception.Columns.Count;
                gcRec_CantKg.VisibleIndex = gvReception.Columns.Count;
                gcRec_Reject.VisibleIndex = gvReception.Columns.Count;
                gcRec_Counter_Sample.VisibleIndex = gvReception.Columns.Count;
                gcRec_Days.VisibleIndex = gvReception.Columns.Count;
                gcRec_Cost.VisibleIndex = gvReception.Columns.Count;

                gcAgua_Cod_campo.Visible = false;                
                gcAgua_Cod_matrix.Visible = false;
                gcAgua_Code.Visible = false;
                gcAgua_Date.Visible = false;
                gcAgua_Hour.Visible = false;
                gcAgua_NameSample.Visible = false;
                gcAgua_Num_bottle_glass.Visible = false;
                gcAgua_Num_bottle_plastic.Visible = false;
                gcAgua_Ubigeo.Visible = false;
                gcAgua_UTM.Visible = false;
                gcAgua_Volumen.Visible = false;                
            }
            else if (typeModuleOpen == typeModule.ReceptionAguas)
            {
                //botones
                ucGenerarA.InitItems(new List<string> { "Ampliación de ensayo" });

                ucGenerarDesde.InitItems(new List<string> { "Cotización" });

                for (int i = 0; i < gvReception.Columns.Count; i++)
                    gvReception.Columns[i].Visible = false;

                //título y códigos
                this.Text = "Registro de Recepción";
                ucTitleRegisterRecep.Title = "Registro de Recepción";
                ucTitleRegisterRecep.SetColor(UcTitle.ColorTitle.BlueSky);
                paCodRegisterRecep.Visible = true;

                tpAnexos.PageVisible = true;

                tpReject.PageVisible = true;

                tpDecree.PageVisible = true;

                gcRec_Description.Visible = false;
                gcRec_Type_Sample.Visible = false;
                gcRec_Procedence.Visible = false;
                gcRec_Code.Visible = false;                
                gcRec_NameSample.Visible = false;
                gcRec_CantKg.Visible = false;
                gcRec_Reject.Visible = false;
                gcRec_Counter_Sample.Visible = false;
                gcRec_Days.Visible = false;
                gcRec_Cost.Visible = false;

                gcAgua_Cod_campo.VisibleIndex = gvReception.Columns.Count;
                gcAgua_Cod_matrix.VisibleIndex = gvReception.Columns.Count;
                gcAgua_Code.VisibleIndex = gvReception.Columns.Count;
                gcAgua_Date.VisibleIndex = gvReception.Columns.Count;
                gcAgua_Hour.VisibleIndex = gvReception.Columns.Count;
                gcAgua_NameSample.VisibleIndex = gvReception.Columns.Count;
                gcAgua_Num_bottle_glass.VisibleIndex = gvReception.Columns.Count;
                gcAgua_Num_bottle_plastic.VisibleIndex = gvReception.Columns.Count;
                gcAgua_Ubigeo.VisibleIndex = gvReception.Columns.Count;
                gcAgua_UTM.VisibleIndex = gvReception.Columns.Count;
                gcAgua_Volumen.VisibleIndex = gvReception.Columns.Count;

                initDecretos();
            }
        }

        void ChangeStatusControls()
        {            
            if (loadData == LoadData.Nothing) // apertura del módulo desde el menú
            {
                ucSignReception.Enabled = true;

                //tabs opciones
                tpRightMethods.PageVisible = true;
                tpRightReports.PageVisible = false;
                tpRightAttach.PageVisible = false;
                tpRightProgram.PageVisible = false;

                // --- el módulo ha sido abierto desde el menú 
                if (typeModuleOpen == typeModule.RegisterReception)
                {
                    ucGenerarA.Enabled = false;
                    ucGenerarDesde.Enabled = true;
                    tabDateRegRecep.PageVisible = true;                    
                }
            }
            else if (loadData == LoadData.FromRR_ToExtendRR)
            {
                ucSignReception.Enabled = true;

                //tabs opciones
                tpRightMethods.PageVisible = true;
                tpRightReports.PageVisible = false;
                tpRightAttach.PageVisible = false;
                tpRightProgram.PageVisible = false;

                // --- el módulo ha sido abierto desde otro módulo (registro de recepción o cotización)
                if (typeModuleOpen == typeModule.RegisterReception)
                {
                    ucGenerarA.Enabled = false;
                    ucGenerarDesde.Enabled = false;
                    tabDateRegRecep.PageVisible = true;
                    
                }                
                else if (loadData == LoadData.FromRR_ToExtendRR) //en el registro de recepción abierto copia los datos a un nuevo registro para hacer una ampliación.
                {                    
                    //resetear algunos campos como nuevo registro
                    oRecep_sample.Idrecep_sample = 0;
                    deReception.EditValue = DateTime.Now;
                    tbNumDays.EditValue = 0;
                    deResult.EditValue = null;

                    tbCod_recep_sample.Text = "";                    

                    cbTypeSample.Properties.ReadOnly = true;
                    cbCompany.Properties.ReadOnly = true;

                    tbSubTotalAmount.Value = 0;
                    tbTotalAmount.Value = 0;
                    tbTotalIgv.Value = 0;

                    tbAmortization.Value = 0;
                    tbResidue.Value = 0;

                    for (int i = 0; i < gvReception.RowCount; i++)
                        gvReception.SetRowCellValue(i, gcRec_Cost, 0);
                    
                }                
            }
            else if (loadData == LoadData.MasterSearchRR)
            {                
                SetReadOnly(true);

                // --- los datos han sido cargados desde un buscador
                if (typeModuleOpen == typeModule.RegisterReception)
                {
                    ucGenerarA.Enabled = true;
                    ucGenerarDesde.Enabled = false;

                    //tabs opciones
                    tpRightMethods.PageVisible = true;
                    tpRightReports.PageVisible = true;
                    tpRightAttach.PageVisible = true;
                    tpRightProgram.PageVisible = true;
                    
                    tabDateRegRecep.PageVisible = true;                    
                }                
            }
        }

        #endregion

        #region inherit methods

        protected override void Limpiar_Campos()
        {
            txIdrecep_sample.Text = "";
            IDCompany = 0;
            cbCompany.EditValue = null;
            tbClientRuc.Text = "";
            tbClientDomicile.Text = "";            
            tbClientPhone.Text = "";
            ckDispatchPerson.Checked = false;
            ckDispatchCurier.Checked = false;
            ckDispatchTransport.Checked = false;
            ckDispatchFax.Checked = false;
            tbSubTotalAmount.Text = "";
            tbTotalIgv.Text = "";
            tbTotalAmount.Text = "";
            totalAmount = 0;
            tbAmortization.Text = "";
            tbResidue.Text = "";
            deReception.DateTime = DateTime.Now;
            deHourReception.EditValue = DateTime.Now;
            deResult.Text = "";
            deHourResult.Text = "";
            tbCod_recep_sample.Text = "";
            
            deHourResult.Time = DateTime.Now;
            tbNumDays.Value = 0;
            deResult.EditValue = null;
            deHourResult.EditValue = null;

            tpRightReports.PageVisible = false;
            tpRightAttach.PageVisible = false;
            tpRightProgram.PageVisible = false;
            
            lstItemsSelAttach.Clear();
            lstItemsSelReport.Clear();
            lstItemsSelProgram.Clear();

            InitDatatable();
            InitDataControls();
            
            gcContact.DataSource = null;
            gcReport.DataSource = null;
            gcAttachFile.DataSource = null;
            gcProgram.DataSource = null;
            ClearElemColumns();

            ucSignReception.Clear();

            oRecep_sample = null;
            oPrice = null;
            oPrice_version = null;
        }

        void Limpiar_SelectPage()
        {
            txIdrecep_sample.Text = "";
            IDCompany = 0;
            cbCompany.EditValue = null;
            tbClientRuc.Text = "";
            tbClientDomicile.Text = "";            
            tbClientPhone.Text = "";
            ckDispatchPerson.Checked = false;
            ckDispatchCurier.Checked = false;
            ckDispatchTransport.Checked = false;
            ckDispatchFax.Checked = false;
            
            tbSubTotalAmount.Text = "";
            tbTotalIgv.Text = "";
            tbTotalAmount.Text = "";
            tbAmortization.Text = "";
            tbResidue.Text = "";
            deReception.DateTime = DateTime.Now;
            deHourReception.EditValue = DateTime.Now;
            deResult.Text = "";
            deHourResult.Text = "";

            gcReception.DataSource = null;
            gcContact.DataSource = null;
            gcReport.DataSource = null;
            gcAttachFile.DataSource = null;
            ClearElemColumns();
        }
        
        void Refresh_combo_company()
        {
            // --- init client combo                       
            CCompanyFactory faCompany = new CCompanyFactory();
            cbCompany.Properties.DataSource = faCompany.GetAll();
            cbCompany.Properties.ValueMember = "Idcompany";
            cbCompany.Properties.DisplayMember = "Business_name";
        }

        protected override void Load_Finder()
        {
            btFiltroBuscar.PerformClick();
        }

        protected override bool Grabar()
        {
            if (Son_Datos_Correctos() &&
               (MessageBox.Show("Desea grabar el documento actual?", "Grabar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {

                if (Grabar_Registro())
                {
                    // --- show tappages
                    tpRightReports.PageVisible = true;
                    tpRightAttach.PageVisible = true;
                    tpRightProgram.PageVisible = true;

                    // --- show dialog, print tickets
                    MessageBox.Show("Guardado exitosamente.");
                    
                    ///recuperar registro como estado de busqueda
                    ///
                    long idrecep_sample = oRecep_sample != null ? oRecep_sample.Idrecep_sample : 0;
                    int idprice_version = oPrice_version != null ? oPrice_version.Idprice_version : 0;
                    
                    Limpiar_Campos();

                    if (typeModuleOpen == typeModule.RegisterReception)
                    {
                        oRecep_sample = new CRecep_sampleFactory().GetByPrimaryKey(new CRecep_sampleKeys(idrecep_sample));
                    }                    

                    loadData = LoadData.MasterSearchRR;

                    Recuperar_Registro();

                    ChangeStatusControls();

                    ComunForm.Send_message(this.Text, TypeMsg.ok, "");

                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        protected override void Accion_Despues_Grabar()
        {            
            Refresh_combo_company();            
        }

        bool SaveRegisterReception()
        {
            bool result = false;
            object obj = deHourReception.EditValue;

            try
            {
                #region save head

                if (oRecep_sample == null)
                    oRecep_sample = new CRecep_sample();
                else
                {
                    if (loadData == LoadData.FromRR_ToExtendRR)
                        oRecep_sample.Idrecep_sample = 0;
                }

                CPersonFactory faPerson = new CPersonFactory();
                Reception oReception = new BusinessLayer.Modules.Reception();

                // --- save company
                bool result_company = false;

                CCompany oCompany = new CCompany();

                if (cbCompany.EditValue != null)
                {
                    CCorr_modulesFactory faCorr_modules = new CCorr_modulesFactory();
                    CCompanyFactory faCompany = new CCompanyFactory();

                    oCompany.Idcompany = Convert.ToInt16(cbCompany.EditValue);
                    //oCompany.Cod_company = faCorr_modules.GetCorrModule(Comun.Formulario.fmEmpresa.ToString());
                    oCompany.Ruc = tbClientRuc.Text;
                    oCompany.Business_name = cbCompany.Text;
                    oCompany.Domicile = tbClientDomicile.Text;
                    oCompany.Type_company = 'C'; // --- client
                    oCompany.Phone_client = tbClientPhone.Text;

                    if (!(result_company = faCompany.Update(oCompany)))
                        result_company = faCompany.Insert(oCompany);
                }

                // --- save head      
                if (!result_company)
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "Error al guardar cliente, no se pudo completar la operación.");
                    return false;
                }
                                
                bool result_recep_sample = false;                

                oReception.GetNewCodReception();

                oRecep_sample.Cod_recep_sample = oReception.GetFormatCodReception();
                oRecep_sample.Idcompany = oCompany.Idcompany;
                oRecep_sample.Date_reception = deReception.DateTime;

                DateTime Hour_reception = Convert.ToDateTime(deHourReception.EditValue);

                oRecep_sample.Date_reception = new DateTime(
                    deReception.DateTime.Year, deReception.DateTime.Month, deReception.DateTime.Day,
                    Hour_reception.Hour, Hour_reception.Minute, Hour_reception.Second);

                DateTime Hour_result = Convert.ToDateTime(deHourResult.EditValue);

                oRecep_sample.Date_result = new DateTime(
                    deResult.DateTime.Year, deResult.DateTime.Month, deResult.DateTime.Day,
                    Hour_result.Hour, Hour_result.Minute, Hour_result.Second);

                oRecep_sample.Cod_type_sample = cbTypeSample.EditValue.ToString();
                oRecep_sample.Total_amount = Convert.ToDecimal(tbSubTotalAmount.Text);
                oRecep_sample.Total_igv = Convert.ToDecimal(tbTotalIgv.Text);
                oRecep_sample.Total_amount_igv = Convert.ToDecimal(tbTotalAmount.Text);
                oRecep_sample.Amortization = Convert.ToDecimal(tbAmortization.Text);
                oRecep_sample.Flag_isprice = false;
                //oRecep_sample.Discount = ckDiscount.Checked == true ? tbDiscount.Value : 0;

                if (oRecep_sample.Idrecep_sample == 0)
                {
                    oRecep_sample.Usernew = Comun.GetUser();
                    oRecep_sample.Datenew = Comun.GetDate();
                }
                oRecep_sample.Useredit = Comun.GetUser();
                oRecep_sample.Dateedit = Comun.GetDate();

                if (!(result_recep_sample = faRecep_sample.Update(oRecep_sample)))
                    result_recep_sample = faRecep_sample.Insert(oRecep_sample);

                if (!result_recep_sample)
                {                
                    ComunForm.Send_message(this.Text, TypeMsg.error, "Error al guardar datos en recepción, no se pudo completar la operación.");
                    return false;
                }

                #endregion

                #region update price

                if (result_recep_sample && oPrice_version != null && oPrice_version.Idprice_version > 0)
                {
                    oPrice_version.Status_price = 4;
                    faPrice_version.Update(oPrice_version);
                }

                #endregion 

                #region save detail

                // --- contacts and detail
                if (result_recep_sample)
                {
                    // --- save contacts
                    CPerson oContact = new CPerson();
                    CRecep_company_person oRecep_company_person = new CRecep_company_person();
                    CRecep_company_personFactory faRecep_company_person = new CRecep_company_personFactory();

                    // --- delete all
                    tbCod_recep_sample.Text = oReception.GetFormatCodReception();

                    oReception.SetDisabledContact(oRecep_sample.Idrecep_sample);

                    for (int i = 0; i < gvContact.RowCount; i++)
                    {
                        oContact.Idperson = Convert.ToInt16(gvContact.GetRowCellValue(i, gcCon_Idperson));
                        oContact.Phone = gvContact.GetRowCellValue(i, gcCon_Phone).ToString();
                        oContact.Cellphone = gvContact.GetRowCellValue(i, gcCon_Cellphone).ToString();
                        oContact.Mail = gvContact.GetRowCellValue(i, gcCon_Mail).ToString();
                        oContact.Allname = gvContact.GetRowCellValue(i, gcCon_Allname).ToString();

                        bool result_contact = false;
                        if (!(result_contact = faPerson.Update(oContact)))
                            result_contact = faPerson.Insert(oContact);

                        if (result_contact)
                        {
                            oRecep_company_person = new CRecep_company_person();

                            oRecep_company_person.Idrecep_company_person = 0;
                            oRecep_company_person.Idcompany = oCompany.Idcompany;
                            oRecep_company_person.Idrecep_sample = oRecep_sample.Idrecep_sample;
                            oRecep_company_person.Idperson = oContact.Idperson;
                            oRecep_company_person.Person_type = Convert.ToInt16(gvContact.GetRowCellValue(i, gcCon_Person_type));
                            oRecep_company_person.Enabled_show = true;

                            if (!faRecep_company_person.Update(oRecep_company_person))
                                faRecep_company_person.Insert(oRecep_company_person);
                        }
                    }

                    // --- save dispatch
                    CRecep_sample_dispatchFactory faRecep_sample_dispatch = new CRecep_sample_dispatchFactory();
                    CRecep_sample_dispatch oRecep_sample_dispatch = new CRecep_sample_dispatch();
                    oRecep_sample_dispatch.Idrecep_sample = oRecep_sample.Idrecep_sample;
                    // --- person
                    if (ckDispatchPerson.Checked)
                        oRecep_sample_dispatch.Dispatch_person = 1;
                    else
                        oRecep_sample_dispatch.Dispatch_person = 0;
                    // --- curier
                    if (ckDispatchCurier.Checked)
                        oRecep_sample_dispatch.Dispatch_curier = 1;
                    else
                        oRecep_sample_dispatch.Dispatch_curier = 0;
                    // --- transport
                    if (ckDispatchTransport.Checked)
                        oRecep_sample_dispatch.Dispatch_transport = 1;
                    else
                        oRecep_sample_dispatch.Dispatch_transport = 0;
                    // --- fax
                    if (ckDispatchFax.Checked)
                        oRecep_sample_dispatch.Dispatch_fax = 1;
                    else
                        oRecep_sample_dispatch.Dispatch_fax = 0;
                    // --- save 
                    if (!faRecep_sample_dispatch.Update(oRecep_sample_dispatch))
                        faRecep_sample_dispatch.Insert(oRecep_sample_dispatch);

                    // ---------------------------------------------------------------------------
                    // --- save detail -----------------------------------------------------------
                    // ---------------------------------------------------------------------------
                    CRecep_sample_detail oRecep_sample_detail = new CRecep_sample_detail();
                    CRecep_sample_detailFactory faRecep_sample_detail = new CRecep_sample_detailFactory();

                    CRecep_elem oRecep_elem = new CRecep_elem();
                    CRecep_elemFactory faRecep_elem = new CRecep_elemFactory();

                    CRecep_sample_detail_elem oRecep_sample_detail_elem = new CRecep_sample_detail_elem();
                    CRecep_sample_detail_elemFactory faRecep_sample_detail_elem = new CRecep_sample_detail_elemFactory();

                    CCorrelative oCorrelative = new CCorrelativeFactory().GetByPrimaryKey(new CCorrelativeKeys(oRecep_sample.Cod_type_sample));

                    if (oRecep_sample.Idrecep_sample > 0)
                    {
                        int i = 0;
                        while (i < gvReception.RowCount)
                        {
                            oRecep_sample_detail = new CRecep_sample_detail();
                            oRecep_sample_detail.Idrecep_sample = oRecep_sample.Idrecep_sample;
                            //if (gvReception.GetRowCellValue(i, gcRec_idrecep_sample_detail) != DBNull.Value)
                                //oRecep_sample_detail.Idrecep_sample_detail = Convert.ToInt64(gvReception.GetRowCellValue(i, gcRec_idrecep_sample_detail));
                            oRecep_sample_detail.Idrecep_sample_detail = 0;
                            oRecep_sample_detail.Order_sample = Convert.ToInt16(gvReception.GetRowCellValue(i, gcRec_OrderSample));
                            oRecep_sample_detail.Name_sample = gvReception.GetRowCellValue(i, gcRec_NameSample).ToString();
                            oRecep_sample_detail.Procedence = gvReception.GetRowCellValue(i, gcRec_Procedence).ToString();
                            oRecep_sample_detail.Cod_des_sample = gvReception.GetRowCellValue(i, gcRec_Description).ToString();
                            oRecep_sample_detail.Cod_type_sample = gvReception.GetRowCellValue(i, gcRec_Type_Sample).ToString();
                            oRecep_sample_detail.Cod_sample = gvReception.GetRowCellValue(i, gcRec_Code).ToString();
                            oRecep_sample_detail.Amount_weight = Convert.ToDecimal(gvReception.GetRowCellValue(i, gcRec_CantKg));
                            oRecep_sample_detail.Cost_sample = Convert.ToDecimal(gvReception.GetRowCellValue(i, gcRec_Cost));
                            oRecep_sample_detail.Flag_envelope_sealed = Convert.ToBoolean(gvReception.GetRowCellValue(i, gcRec_Flag_envelope_sealed));
                            oRecep_sample_detail.Flag_reject = Convert.ToBoolean(gvReception.GetRowCellValue(i, gcRec_Reject));
                            oRecep_sample_detail.Flag_counter_sample = Convert.ToInt16(gvReception.GetRowCellValue(i, gcRec_Counter_Sample));
                            oRecep_sample_detail.Analisys_time = Convert.ToInt16(gvReception.GetRowCellValue(i, gcRec_Days));

                            bool result_detail_elem = false;

                            bool result_recep_sample_detail = false;

                            if (!(result_recep_sample_detail = faRecep_sample_detail.Update(oRecep_sample_detail)))
                                result_recep_sample_detail = faRecep_sample_detail.Insert(oRecep_sample_detail);

                            if (result_recep_sample_detail)
                            {
                                if (FlagRegRecepCopy)
                                {
                                    oRecep_sample_detail.Cod_interno = Convert.ToInt64(gvReception.GetRowCellValue(i, gcRec_Cod_interno));
                                    oRecep_sample_detail.Cod_sample = gvReception.GetRowCellValue(i, gcRec_Code).ToString();
                                    oRecep_sample_detail.Flag_control_sample = false;
                                }
                                else
                                {
                                    // assign correlative code
                                    long Cod_interno = oReception.GetNewCodInternoSample(gvReception.GetRowCellValue(i, gcRec_Type_Sample).ToString());
                                    string Format_cod_interno = oReception.GetFormatCodInternoSample(gvReception.GetRowCellValue(i, gcRec_Type_Sample).ToString());

                                    oRecep_sample_detail.Cod_interno = Cod_interno;
                                    oRecep_sample_detail.Cod_sample = Format_cod_interno;
                                    oRecep_sample_detail.Flag_control_sample = false;
                                }

                                faRecep_sample_detail.Update(oRecep_sample_detail);

                                

                                #region save element cell repetition

                                CRecep_sample_detail oRecep_sample_aux = faRecep_sample_detail.GetByPrimaryKey(new CRecep_sample_detailKeys(oRecep_sample_detail.Idrecep_sample_detail));
                                CSettings oSettings = new CSettings();
                                bool HasHumidityAnalysis = false;
                                bool Has60GradesElement = false;

                                // --- retrieve code sample and assign
                                if (!Convert.ToBoolean(oRecep_sample_detail.Flag_control_sample))
                                    gvReception.SetRowCellValue(i, gcRec_Code, oRecep_sample_aux.Cod_sample);

                                // --- save element cell
                                foreach (KeyValuePair<DevExpress.XtraGrid.Columns.GridColumn, bool> kvp in DicShowColumns)
                                {
                                    if (kvp.Value)
                                    {
                                        bool value_check = Convert.ToBoolean(gvReception.GetRowCellValue(i, kvp.Key));
                                        bool flag_control_sample = Convert.ToBoolean(oRecep_sample_detail.Flag_control_sample);

                                        if ((!flag_control_sample && value_check)
                                            || flag_control_sample)
                                        {
                                            oRecep_sample_detail_elem = new CRecep_sample_detail_elem();

                                            CTagInfoMethod tagMethod = (CTagInfoMethod)kvp.Key.Tag;
                                            oRecep_sample_detail_elem.Idelement = tagMethod.IDElement;
                                            oRecep_sample_detail_elem.Idrecep_sample = oRecep_sample.Idrecep_sample;
                                            oRecep_sample_detail_elem.Idrecep_sample_detail = oRecep_sample_detail.Idrecep_sample_detail;
                                            oRecep_sample_detail_elem.Idtemplate_method = tagMethod.IDTemplate_method;
                                            oRecep_sample_detail_elem.Idcompany = oRecep_sample.Idcompany;
                                            oRecep_sample_detail_elem.Idunit = tagMethod.IDMeasurement_Unit;
                                            oRecep_sample_detail_elem.Cost_method = tagMethod.Cost_Method;

                                            if (!(result_detail_elem = faRecep_sample_detail_elem.Update(oRecep_sample_detail_elem)))
                                                result_detail_elem = faRecep_sample_detail_elem.Insert(oRecep_sample_detail_elem);

                                            if (result_detail_elem)
                                            {
                                                // crear bandejas
                                                CBatchManager oBatchManager = new CBatchManager();
                                                oBatchManager.CallSaveSampleBatch(
                                                    Convert.ToInt32(oRecep_sample_detail_elem.Idtemplate_method),
                                                    Convert.ToInt64(oRecep_sample_detail_elem.Idrecep_sample),
                                                    Convert.ToInt64(oRecep_sample_detail_elem.Idrecep_sample_detail),
                                                    oRecep_sample_detail_elem.Idrecep_sample_detail_elem,
                                                    Convert.ToInt64(oRecep_sample_detail.Cod_interno),
                                                    oRecep_sample_detail.Cod_sample,
                                                    Comun.GetUser(),
                                                    oCorrelative);

                                                // enviar a preparación de muestras

                                            }

                                            //verificar si tiene análisis por humedad
                                            if (oSettings.GetIdHumidityAnalysis().Contains(tagMethod.IDElement.ToString()))
                                                HasHumidityAnalysis = true;

                                            //verificar si tiene que elementos para ser analizados a 60°
                                            if (oSettings.GetIDElements60Grades().Contains(tagMethod.IDElement.ToString()))
                                                Has60GradesElement = true;
                                        }
                                    }
                                }
                                #endregion

                                #region save sample preparation

                                CPrep_samples oPrep_samples = new CPrep_samples();
                                oPrep_samples.Idrecep_sample_detail = oRecep_sample_detail.Idrecep_sample_detail;
                                oPrep_samples.Flag_counter_sample = oRecep_sample_detail.Flag_counter_sample;
                                oPrep_samples.Flag_reject = oRecep_sample_detail.Flag_reject;
                                oPrep_samples.Flag_humidity_analysis = HasHumidityAnalysis;
                                oPrep_samples.Flag_60celsius = Has60GradesElement;
                                oPrep_samples.Date_creation = Comun.GetDate();
                                oPrep_samples.Moisture_reject = false;
                                oPrep_samples.Final_moisture = 0;
                                oPrep_samples.Final_reject = 0;
                                oPrep_samples.Final_sample_prepared = 0;
                                oPrep_samples.Final_weight_gross = 0;
                                oPrep_samples.Output_flag_sample = false;
                                oPrep_samples.Output_flag_cs = false;
                                oPrep_samples.Output_flag_re = false;

                                CPrep_samplesFactory faPrep_samples = new CPrep_samplesFactory();
                                if (!faPrep_samples.Update(oPrep_samples))
                                    faPrep_samples.Insert(oPrep_samples);

                                #endregion
                            }

                            if (!Convert.ToBoolean(oRecep_sample_detail.Flag_control_sample))
                                i++;
                        }
                    }

                    #region save tag infor method

                    // --- save tag info method (mr or blk)
                    foreach (KeyValuePair<DevExpress.XtraGrid.Columns.GridColumn, bool> kvp in DicShowColumns)
                    {
                        if (kvp.Value)
                        {
                            CTagInfoMethod tagMethod = (CTagInfoMethod)kvp.Key.Tag;
                            oRecep_elem = new CRecep_elem();
                            oRecep_elem.Idelement = tagMethod.IDElement;
                            oRecep_elem.Idrecep_sample = oRecep_sample.Idrecep_sample;
                            oRecep_elem.Idtemplate_method = tagMethod.IDTemplate_method;
                            oRecep_elem.Name_unit = tagMethod.Name_Measurement_Unit;
                            oRecep_elem.Idunit = tagMethod.IDMeasurement_Unit;
                            oRecep_elem.Percent_repetition = tagMethod.Percent_repetition;

                            if (!faRecep_elem.Update(oRecep_elem))
                                faRecep_elem.Insert(oRecep_elem);
                        }
                    }

                    #endregion
                }

                #endregion
                
                result = true;
            }
            catch (Exception ex)
            {
                Comun.Save_log(ex.Message);
                if (ex.InnerException != null)
                    Comun.Save_log(ex.InnerException.ToString());
                return false;
            }
            return result;
        }
        
        protected override bool Grabar_Registro()
        {
            if (typeModuleOpen == typeModule.RegisterReception)
                return SaveRegisterReception();            
            return false;
        }

        void RetrieveRegisterReception()
        {
            // --- return date of recep_sample
            DicCellsSavedReport.Clear();
            DicCellsSaveProgram.Clear();
            
            Reception oReception = new Reception();            

            if (oRecep_sample != null)
            {                
                tpRightReports.PageVisible = true;
                tpRightAttach.PageVisible = true;
                tpRightProgram.PageVisible = true;

                txIdrecep_sample.Text = oRecep_sample.Idrecep_sample.ToString();
                statusRegReception = StatusRegRecep.reg_recep_saved;
                tbCod_recep_sample.Text = oRecep_sample.Cod_recep_sample;
                deReception.DateTime = Convert.ToDateTime(oRecep_sample.Date_reception);
                deHourReception.EditValue = Convert.ToDateTime(oRecep_sample.Date_reception);
                deResult.DateTime = Convert.ToDateTime(oRecep_sample.Date_result);
                deHourResult.EditValue = Convert.ToDateTime(oRecep_sample.Date_result);
                cbTypeSample.EditValue = oRecep_sample.Cod_type_sample;

                tbNumDays.Value = Convert.ToDecimal(Convert.ToDateTime(oRecep_sample.Date_result).Subtract(Convert.ToDateTime(oRecep_sample.Date_reception)).TotalDays);

                tbSubTotalAmount.Text = oRecep_sample.Total_amount.ToString();
                tbTotalIgv.Text = oRecep_sample.Total_igv.ToString();
                tbTotalAmount.Text = oRecep_sample.Total_amount_igv.ToString();
                tbAmortization.Text = oRecep_sample.Amortization.ToString();                                               

                if (oRecep_sample.Amortization.Value == 0)
                    tbResidue.BackColor = Color.Coral;

                CCompany oCompany = new CCompanyFactory().GetByPrimaryKey(new CCompanyKeys(Convert.ToInt16(oRecep_sample.Idcompany)));

                // --- retrieve dispatch                
                CRecep_sample_dispatch oRecep_sample_dispatch = new CRecep_sample_dispatchFactory().GetByPrimaryKey(new CRecep_sample_dispatchKeys(oRecep_sample.Idrecep_sample));
                if (oRecep_sample_dispatch != null)
                {
                    // --- person
                    if (oRecep_sample_dispatch.Dispatch_person > 0)
                        ckDispatchPerson.Checked = true;
                    else
                        ckDispatchPerson.Checked = false;
                    // --- curier
                    if (oRecep_sample_dispatch.Dispatch_curier > 0)
                        ckDispatchCurier.Checked = true;
                    else
                        ckDispatchCurier.Checked = false;
                    // --- transport
                    if (oRecep_sample_dispatch.Dispatch_transport > 0)
                        ckDispatchTransport.Checked = true;
                    else
                        ckDispatchTransport.Checked = false;
                    // --- fax
                    if (oRecep_sample_dispatch.Dispatch_fax > 0)
                        ckDispatchFax.Checked = true;
                    else
                        ckDispatchFax.Checked = false;
                }
                else
                {
                    ckDispatchPerson.Checked = false;
                    ckDispatchCurier.Checked = true;
                    ckDispatchTransport.Checked = false;
                    ckDispatchFax.Checked = false;
                }

                // --- return date of client    
                if (oCompany != null)
                {
                    IDCompany = oCompany.Idcompany;
                    cbCompany.EditValue = oCompany.Idcompany;
                    tbClientRuc.Text = oCompany.Ruc;
                    tbClientPhone.Text = oCompany.Phone_client;
                    tbClientDomicile.Text = oCompany.Domicile;

                    // --- get contacts
                    gcContact.DataSource = new BindingList<CContact>(oReception.GetLstContactsByRecep(oRecep_sample.Idrecep_sample));

                    // --- return recep_sample_detail
                    CRecep_sample_detail oRecep_sample_detail = new CRecep_sample_detail();
                    CRecep_sample_detailFactory faRecep_sample_detail = new CRecep_sample_detailFactory();

                    DTReceptionDetail = oReception.GetReceptionDetail(oRecep_sample.Idrecep_sample);
                    gcReception.DataSource = DTReceptionDetail;

                    // --- return columns                    
                    List<CTemplate_method> lstTemplate_method = oReception.GetReceptionElem(oRecep_sample.Idrecep_sample);

                    // --- modify the dictionary show columns

                    if (loadData != LoadData.FromRR_ToExtendRR)
                    {
                        foreach (CTemplate_method oTemplate_method in lstTemplate_method)
                            AddColumn(oTemplate_method.Cod_template_method);

                        // --- get columns and value cells
                        GetSampleByElems();
                    }

                    // ==================< Retrieve report groups >==============================================
                    gcReport.DataSource = oReception.GetRecep_sample_report(oRecep_sample.Idrecep_sample);
                    CCells_reportedFactory faCells_reported = new CCells_reportedFactory();
                    for (int i = 0; i < gvReport.RowCount; i++)
                    {
                        long idrecep_sample_report = Convert.ToInt64(gvReport.GetRowCellValue(i, gcRep_idrecep_sample_report));
                        short order = Convert.ToInt16(gvReport.GetRowCellValue(i, gcRep_order_report));

                        Color color = dicColorReport[Convert.ToInt16(gvReport.GetRowCellValue(i, gcRep_report_status))];

                        List<CCells_reported> lstRsder = faCells_reported.GetAll().Where(x=> x.Idrecep_sample_report == idrecep_sample_report).ToList();
                        List<CPositionValue> lstPositionValue = new List<CPositionValue>();

                        foreach (CCells_reported item in lstRsder)
                        {
                            if (item.Idrecep_sample_report == idrecep_sample_report)
                            {
                                CPositionValue oPosition = new CPositionValue();
                                oPosition = GetObjectPosition(Convert.ToInt64(item.Idrecep_sample_detail_elem), Convert.ToInt32(item.Idtemplate_method));

                                oPosition.idtemplate_method = Convert.ToInt32(item.Idtemplate_method);
                                oPosition.idrecep_sample_report = Convert.ToInt64(item.Idrecep_sample_report);
                                oPosition.idrecep_sample_detail = Convert.ToInt64(item.Idrecep_sample_detail);
                                oPosition.idrecep_sample_detail_elem = Convert.ToInt64(item.Idrecep_sample_detail_elem);
                                oPosition.idcell_reported = Convert.ToInt64(item.Idcell_reported);

                                if (Convert.ToInt16(gvReport.GetRowCellValue(i, gcRep_type_report)) == 1)
                                    oPosition.color = Partial_report_color;
                                else
                                    oPosition.color = Final_report_color;

                                lstPositionValue.Add(oPosition);
                            }
                        }

                        DicCellsSavedReport.Add(order, lstPositionValue);
                    }

                    // ==================< Unreport data >======================================================
                    GetUnreportData(oRecep_sample.Idrecep_sample);

                    // ==================< Retrieve attach files >==============================================                    
                    gcAttachFile.DataSource = new BindingList<CDocAttach>(oReception.GetLstDocAttach(oRecep_sample.Idrecep_sample));
                    CCells_attach_fileFactory faCells_attach_file = new CCells_attach_fileFactory();
                    for (int i = 0; i < gvAttachFile.RowCount; i++)
                    {
                        long idrecep_sample_attach = Convert.ToInt64(gvAttachFile.GetRowCellValue(i, gcAtt_Idrecep_sample_attach));
                        short order = Convert.ToInt16(gvAttachFile.GetRowCellValue(i, gcAtt_Order_file));

                        Color color = dicColorAttach[Convert.ToInt16(gvAttachFile.GetRowCellValue(i, gcAtt_Attach_status))];

                        List<CCells_attach_file> lstRsder = oReception.GetLstCellsAttachFile(idrecep_sample_attach);
                        List<CpositionValueAttach> lstPositionValue = new List<CpositionValueAttach>();

                        foreach (CCells_attach_file item in lstRsder)
                        {
                            if (item.Idrecep_sample_attach == idrecep_sample_attach)
                            {
                                CpositionValueAttach oPosition = new CpositionValueAttach();
                                oPosition = GetObjectPositionAttach(Convert.ToInt64(item.Idrecep_sample_detail_elem), Convert.ToInt32(item.Idtemplate_method));
                                oPosition.idrecep_sample_detail_elem = Convert.ToInt64(item.Idrecep_sample_detail_elem);
                                oPosition.idtemplate_method = Convert.ToInt32(item.Idtemplate_method);
                                oPosition.color = color;

                                lstPositionValue.Add(oPosition);
                            }
                        }

                        DicCellsSavedAttach.Add(order, lstPositionValue);
                    }

                    // ==================< Retrieve program >==============================================                    
                    gcProgram.DataSource = oReception.GetRecep_sample_program(oRecep_sample.Idrecep_sample);
                    CCells_programFactory faCells_program = new CCells_programFactory();

                    for (int i = 0; i < gvProgram.RowCount; i++)
                    {
                        long idrecep_sample_program = Convert.ToInt64(gvProgram.GetRowCellValue(i, gcProg_Idrecep_sample_program));
                        short order = Convert.ToInt16(gvProgram.GetRowCellValue(i, gcProg_Order_report));

                        Color color = Comun.ColorRojo;

                        List<CCells_program> lstProgram = oReception.GetLstCellsProgram(idrecep_sample_program);
                        List<CPositionValueProgram> lstPositionValueProgram = new List<CPositionValueProgram>();

                        foreach (CCells_program item in lstProgram)
                        {
                            if (item.Idrecep_sample_program == idrecep_sample_program)
                            {
                                CPositionValueProgram oPosition = new CPositionValueProgram();
                                oPosition = GetObjectPositionProgram(Convert.ToInt64(item.Idrecep_sample_detail_elem), Convert.ToInt32(item.Idtemplate_method));

                                oPosition.idrecep_sample_program = Convert.ToInt64(item.Idrecep_sample_program);
                                oPosition.idrecep_sample_detail_elem = Convert.ToInt64(item.Idrecep_sample_detail_elem);
                                oPosition.idrecep_sample_detail = Convert.ToInt64(item.Idrecep_sample_detail);
                                oPosition.idtemplate_method = Convert.ToInt32(item.Idtemplate_method);
                                oPosition.color = color;

                                lstPositionValueProgram.Add(oPosition);
                            }
                        }

                        DicCellsSaveProgram.Add(order, lstPositionValueProgram);
                    }

                }
                SortColumnsByCodTemplate();
            }
            else
            {
                ///No existe un registro de recepción, entonces recuperar todo vacio
                // --- hide tappages
                tpRightReports.PageVisible = false;
                tpRightAttach.PageVisible = false;
                tpRightProgram.PageVisible = false;

                // --- return empty report
                CRecep_sample_reportFactory faRecep_sample_report = new CRecep_sample_reportFactory();
                gcReport.DataSource = oReception.GetRecep_sample_report(0);

                // --- return empty attach files                
                gcAttachFile.DataSource = new BindingList<CDocAttach>(oReception.GetLstDocAttach(0));

                // --- recuperar contactos
                if (cbCompany.EditValue != null)
                    gcContact.DataSource = new BindingList<CContact>(oReception.GetLstContactsByCompany(Convert.ToInt16(cbCompany.EditValue)));
            }
        }        

        protected override void Recuperar_Registro()
        {
            if (typeModuleOpen == typeModule.RegisterReception)
                RetrieveRegisterReception();            
        }

        string GetContactAttention(long idrecep_sample)
        {
            for (int i = 0; i < gvContact.RowCount; i++)
            {
                if (Convert.ToInt32(gvContact.GetRowCellValue(i, gcCon_Person_type)) == 3)
                {
                    return gvContact.GetRowCellValue(i, gcCon_Allname).ToString();
                }
            }
            return "";
        }

        void GetUnreportData(long idrecep_sample)
        {
            /*
            CREATE TEMP TABLE tmp_data_report ON COMMIT DROP AS 
	        SELECT t1.*
	        FROM public.cells_reported t1, recep_sample_report t2
	        WHERE t2.idrecep_sample = p_idrecep_sample
		        AND t2.report_status = 2;
	
	        return query
	        SELECT t1.idrecep_sample_detail_elem, t1.idrecep_sample, t1.idrecep_sample_detail, t1.idelement, t1.idtemplate_method
	        FROM recep_sample_detail_elem t1, recep_sample_report t2
	        WHERE t1.idrecep_sample = t2.idrecep_sample
		        AND t1.idrecep_sample = p_idrecep_sample		        
		        AND idrecep_sample_detail_elem NOT IN (SELECT idrecep_sample_detail_elem
							        FROM tmp_data_report);
            */

            var query =
                (from m in new CCells_reportedFactory().GetAll()
                 from n in new CRecep_sample_reportFactory().GetAll()
                    .Where(x => x.Idrecep_sample_report == m.Idrecep_sample_report && x.Idrecep_sample == idrecep_sample && x.Report_status == 2)
                 select m).ToList();

            var dtUnreportData =
                (from m in new CRecep_sample_detail_elemFactory().GetAll().Where(x => x.Idrecep_sample == idrecep_sample)
                 from n in new CRecep_sample_reportFactory().GetAll().Where(x => x.Idrecep_sample == m.Idrecep_sample)
                 from p in query
                 where m.Idrecep_sample_detail_elem != p.Idrecep_sample_detail_elem
                 select new
                 {
                     m.Idrecep_sample_detail_elem,
                     m.Idrecep_sample,
                     m.Idrecep_sample_detail,
                     m.Idelement,
                     m.Idtemplate_method
                 }).ToList();
            
            LstUnreportData.Clear();

            for (int i = 0; i < dtUnreportData.Count; i++)
            {
                long idrecep_sample_detail = Convert.ToInt64(dtUnreportData[i].Idrecep_sample_detail);
                int idtemplate_method = Convert.ToInt32(dtUnreportData[i].Idtemplate_method);
                long idrecep_sample_detail_elem = Convert.ToInt32(dtUnreportData[i].Idrecep_sample_detail_elem);

                Color colorUnreported = Color.LightBlue;

                CPositionValue oPosition = new CPositionValue();

                oPosition.idtemplate_method = idtemplate_method;
                oPosition.idrecep_sample_report = 0;
                oPosition.idrecep_sample_detail = idrecep_sample_detail;
                oPosition.idrecep_sample_detail_elem = idrecep_sample_detail_elem;
                oPosition.idcell_reported = 0;
                oPosition.color = colorUnreported;

                LstUnreportData.Add(oPosition);
            }
        }

        protected override bool Son_Datos_Correctos()
        {
            // --- master: validate combos and textbox
            if (cbTypeSample.EditValue == null)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: El tipo de muestra no puede ser vacio.");
                return false;
            }
            //if (cbCompany.EditValue == null)
            //{
            //    ComunForm.Send_message(this.Text, TypeMsg.error, "Error: El nombre del cliente no puede ser vacio.");
            //    return false;
            //}            
            if (!AreRightContacts())
            {
                return false;
            }
            
            //if (!AreRightExistMail())
            //{
            //    return false;
            //}
            //if (!AreRightAllMail())
            //{
            //    return false;
            //}
            if (gvContact.RowCount == 0)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: no agregó ningún solicitante o contacto.");
                return false;
            }
            // --- details: validate the grid of samples
            if (!isDetail_correct())
            {
                return false;
            }

            if (typeModuleOpen == typeModule.RegisterReception)
            {
                if (deResult.Text.Trim() == "")
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "Error: la fecha de resultado no puede ser vacía.");
                    return false;
                }
                if (deHourResult.Text.Trim() == "")
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "Error: la hora de resultado no puede ser vacía.");
                    return false;
                }
                if (!AreRightDispatch())
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "Error: debe seleccionar al menos un tipo de envío.");
                    return false;
                }
            }            
            return true;
        }


        bool AreRightDispatch()
        {
            if (ckDispatchPerson.Checked)
                return true;
            if (ckDispatchCurier.Checked)
                return true;
            if (ckDispatchTransport.Checked)
                return true;
            if (ckDispatchFax.Checked)
                return true;

            return false;
        }

        bool AreRightContacts()
        {
            // --- pettioner valid
            bool ExistPetitioner = false;            
            for (int i = 0; i < gvContact.RowCount; i++)
            {
                // --- solicitante
                if (Convert.ToInt16(gvContact.GetRowCellValue(i, gcCon_Person_type)) == 1)
                    ExistPetitioner = true;
            }
            if (!ExistPetitioner)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error:no se incluyó al solicitante.");
                return false;
            }

            // --- complete dates
            for (int i = 0; i < gvContact.RowCount; i++)
            {
                if (gvContact.GetRowCellValue(i, gcCon_Allname) == DBNull.Value || gvContact.GetRowCellValue(i, gcCon_Allname) == null)
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "Error:no se ingreso el nombre del contacto.");
                    return false;
                }

                if (gvContact.GetRowCellValue(i, gcCon_Allname).ToString().Trim() == "")
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "Error:no se ingreso el nombre del contacto.");
                    return false;
                }
                bool mail = false;
                bool phone = false;
                bool cellphone = false;                

                /*
                if (gvContact.GetRowCellValue(i, gcCon_Phone) != null)
                    phone = gvContact.GetRowCellValue(i, gcCon_Phone).ToString().Trim().Length > 0 ? true : false;
                else
                    phone = false;

                if (gvContact.GetRowCellValue(i, gcCon_Cellphone) != null)
                    cellphone = gvContact.GetRowCellValue(i, gcCon_Cellphone).ToString().Trim().Length > 0 ? true : false;
                else
                    cellphone = false;

                if (!mail && !phone && !cellphone)
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "Error:no se ingreso, datos de comunicación con el contacto.");
                    return false;
                } */               
            }
            return true;
        }

        bool AreRightExistMail()
        {
            for (int i = 0; i < gvContact.RowCount; i++)
                if (gvContact.GetRowCellValue(i, gcCon_Mail).ToString().Trim().Length > 0)
                    return true;
            ComunForm.Send_message(this.Text, TypeMsg.error, "Error:no se encontró ningún correo electrónico.");
            return false;
        }

        bool AreRightAllMail()
        {
            bool company_mail = true;
            bool contact_mail = true;

            for (int i = 0; i < gvContact.RowCount; i++)
            {
                if (!Comun.ValidateMail(gvContact.GetRowCellValue(i, gcCon_Mail).ToString()))
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "Error: error de escritura en el email [" + gvContact.GetRowCellValue(i, gcCon_Mail).ToString() + "]");
                    contact_mail = false;
                    break;
                }
            }            

            if (company_mail && contact_mail)
                return true;

            return false;
        }

        void SortColumnsByCodTemplate()
        {
            Dictionary<DevExpress.XtraGrid.Columns.GridColumn, int> dic = new Dictionary<DevExpress.XtraGrid.Columns.GridColumn, int>();            

            foreach (KeyValuePair<DevExpress.XtraGrid.Columns.GridColumn, bool> kvp in DicShowColumns)
            {
                if (kvp.Value)
                {
                    CTagInfoMethod oTagInfoMethod = (CTagInfoMethod)kvp.Key.Tag;
                    dic.Add(kvp.Key, Convert.ToInt32(oTagInfoMethod.Cod_template_method));
                }
            }

            var Sort = (from t in dic orderby t.Value ascending select t).ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (KeyValuePair<DevExpress.XtraGrid.Columns.GridColumn, int> kvp in Sort)
            {
                kvp.Key.VisibleIndex = 500;
            }
        }

        void Init()
        {
            InitAppareance();
            InitDataControls();
            InitDatatable();
            InitDicColumns();
        }

        #endregion

        #region methods

        void InitMod(typeModule p_typeModule)
        {
            typeModuleOpen = p_typeModule;

            // Se apertura el módulo para registrar el ingreso de muestras
            if (typeModuleOpen == typeModule.RegisterReception)
            {
                ucTitleRegisterRecep.Title = "Registro de Recepción";
                ucTitleRegisterRecep.SetColor(UcTitle.ColorTitle.BlueSky);
                paCodRegisterRecep.Visible = true;
            }            
        }

        void UnCheckAllCells()
        {
            // --- reset samples
            for (int i = 0; i < gvReception.RowCount; i++)
                gvReception.SetRowCellValue(i, gcRec_idrecep_sample_detail, 0);


            // --- reset cells
            for (int i = 0; i < gvReception.RowCount; i++)
            {
                foreach (KeyValuePair<DevExpress.XtraGrid.Columns.GridColumn, bool> kvp in DicShowColumns)
                {
                    if (kvp.Value)
                        gvReception.SetRowCellValue(i, kvp.Key, false);
                }
            }
        }

        void SetReadOnly(bool flag)
        {
            Readonly = flag;

            cbTypeSample.Properties.ReadOnly = flag;
            cbCompany.Properties.ReadOnly = flag;
            tbClientDomicile.Properties.ReadOnly = flag;
            tbClientPhone.Properties.ReadOnly = flag;
            tbClientRuc.Properties.ReadOnly = flag;
            tbFax.Properties.ReadOnly = Readonly;
            ckDispatchPerson.Properties.ReadOnly = flag;
            ckDispatchCurier.Properties.ReadOnly = flag;
            ckDispatchFax.Properties.ReadOnly = flag;
            ckDispatchTransport.Properties.ReadOnly = flag;

            gvContact.OptionsBehavior.Editable = !flag;
            gcContact.EmbeddedNavigator.Enabled = !flag;

            deReception.Properties.ReadOnly = flag;
            deHourReception.Properties.ReadOnly = flag;
            tbNumDays.Properties.ReadOnly = flag;
            deResult.Properties.ReadOnly = flag;
            deHourResult.Properties.ReadOnly = flag;

            tbAmortization.Properties.ReadOnly = flag;
            tbResidue.Properties.ReadOnly = flag;
            
            gvReception.OptionsBehavior.Editable = !flag;
            gcReception.EmbeddedNavigator.Enabled = !flag;
            ucSignReception.Enabled = !flag;
        }

        void SetReadOnly(typeColumn pTypecolumn, bool flag)
        {
            Readonly = flag;
            if (Readonly)
            {
                gvReception.OptionsBehavior.Editable = false;
                cbTypeSample.Enabled = false;
                ucSignReception.Enabled = false;
            }
            else
            {
                gvReception.OptionsBehavior.Editable = true;
                cbTypeSample.Enabled = true;
                ucSignReception.Enabled = true;
            }
        }

        void OpenFormMasterSearch(typeModule tm)
        {
            if (tm == typeModule.RegisterReception)
            {
                ///attributes
                short? p_year = null;
                short? p_idcompany = null;
                DateTime? p_date_begin = null;
                DateTime? p_date_end = null;

                FormMasterSearch fmBusqueda = new FormMasterSearch();
                fmBusqueda.BindGrid(new ModMasterSearch().GetRegReception(p_year, p_idcompany, p_date_begin, p_date_end));

                fmBusqueda.ShowDialog();

                Dictionary<string, string> keys = fmBusqueda.getKeyValues();

                if (keys != null)
                {
                    ///get recep sample
                    oRecep_sample = faRecep_sample.GetByPrimaryKey(new CRecep_sampleKeys(Convert.ToInt64(keys["Idrecep_sample"])));
                    oPrice_version = faPrice_version.GetByPrimaryKey(new CPrice_versionKeys(Convert.ToInt32(keys["Idprice_version"])));
                    Limpiar_Campos();
                    Recuperar_Registro();
                    thePanelTab1.SelectedIndex = 0;
                    statusRegReception = StatusRegRecep.reg_recep_saved;
                }
            }            
        }

        short GetNextOrderReport()
        {
            short max = 0;
            for (int i = 0; i < gvReport.RowCount; i++)
            {
                if (gvReport.GetRowCellValue(i, gcRep_order_report) != null)
                {
                    if (max < Convert.ToInt16(gvReport.GetRowCellValue(i, gcRep_order_report)))
                        max = Convert.ToInt16(gvReport.GetRowCellValue(i, gcRep_order_report));
                }
            }
            return max;
        }

        short GetNextOrderProgram()
        {
            short max = 0;
            for (int i = 0; i < gvProgram.RowCount; i++)
            {
                if (gvProgram.GetRowCellValue(i, gcProg_Order_report) != null)
                {
                    if (max < Convert.ToInt16(gvProgram.GetRowCellValue(i, gcProg_Order_report)))
                        max = Convert.ToInt16(gvProgram.GetRowCellValue(i, gcProg_Order_report));
                }
            }
            return max;
        }

        private void Show_exist_files()
        {
            if (cbTypeSample.EditValue != null && cbCompany.EditValue != null)
            {
                Reception oReception = new Reception();
                repAttach_file.DataSource = oReception.GetLstExistFiles(Convert.ToInt16(cbCompany.EditValue), cbTypeSample.EditValue.ToString());
                repAttach_file.DisplayMember = "Name_file";
                repAttach_file.ValueMember = "Idrecep_sample_attach";
            }
        }

        int? GetCurrentRowAttachFile()
        {
            for (int i = 0; i < gvAttachFile.RowCount; i++)
            {
                if (Convert.ToInt16(gvAttachFile.GetRowCellValue(i, gcRep_type_report)) == 1
                    && Convert.ToInt16(gvAttachFile.GetRowCellValue(i, gcRep_report_status)) == 1)
                    return i;
            }
            return null;
        }

        void CopyAndSaveFile(string source_file_name)
        {
            try
            {
                BusinessLayer.Modules.Authorization oAuthorization = new Authorization();
                Reception oReception = new Reception();

                System.IO.FileInfo fInfo = new System.IO.FileInfo(source_file_name);
                string next_file_name = "";
                int next_file_order = 0;
                oReception.GetNextFileName(ref next_file_name, ref next_file_order);
                string name_file = String.Format("{0}{1}", next_file_name, fInfo.Extension);

                string destiny_file = System.IO.Path.Combine(Path_file_methods, name_file);

                if (!System.IO.Directory.Exists(Path_file_methods))
                    System.IO.Directory.CreateDirectory(Path_file_methods);

                // To copy a file to another location and
                // overwrite the destination file if it already exists.
                System.IO.File.Copy(source_file_name, destiny_file, true);

            }
            catch (Exception ex)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, ex.Message);
            }
        }

        bool HasInterceptionPartialReport(GridCell[] lst)
        {
            var lstInt = (from t in lst select Convert.ToInt32(gvReception.GetRowCellValue(t.RowHandle, gcRec_idrecep_sample_detail).ToString() + ((CTagInfoMethod)t.Column.Tag).IDTemplate_method)).ToList<int>();

            for (int i = 0; i < gvReport.RowCount; i++)
            {
                if (Convert.ToInt16(gvReport.GetRowCellValue(i, gcRep_type_report)) == 1)
                {
                    List<CPositionValue> lstAux = DicCellsSavedReport[Convert.ToInt16(gvReport.GetRowCellValue(i, gcRep_order_report))];
                    List<int> lstSavedAux = GetLstSavedReport(lstAux);
                    var lstResult = lstInt.Intersect(lstSavedAux);

                    if (lstResult.Count() > 0)
                    {
                        ComunForm.Send_message(this.Text, TypeMsg.error, "Error. Alguna de las celdas seleccionadas ya fue reportado en un informe parcial.");
                        return true;
                    }
                }
            }
            return false;
        }

        bool HasEmptyCells(GridCell[] lst)
        {
            foreach (GridCell cell in lst)
            {
                if (gvReception.GetRowCellValue(cell.RowHandle, cell.Column).ToString().Trim() == ""
                    || gvReception.GetRowCellValue(cell.RowHandle, cell.Column).ToString().Contains('-'))
                {
                    if (gvReception.GetRowCellValue(cell.RowHandle, cell.Column).ToString().Trim() == "")
                        ComunForm.Send_message(this.Text, TypeMsg.error, "Error. Se seleccionó una celda que aún no tiene resultado.");
                    if (gvReception.GetRowCellValue(cell.RowHandle, cell.Column).ToString().Contains('-'))
                        ComunForm.Send_message(this.Text, TypeMsg.error, "Error. Se seleccionó una celda que no tiene ensayo.");
                    return true;

                }
            }
            return false;
        }

        List<int> GetLstSavedReport(List<CPositionValue> lst)
        {
            List<int> lstTemp = new List<int>();
            foreach (CPositionValue item in lst)
            {
                lstTemp.Add(Convert.ToInt32(item.idrecep_sample_detail.ToString() + item.idtemplate_method.ToString()));
            }
            return lstTemp;
        }

        bool AreCellsWithResults(List<CPositionValue> lstCells)
        {
            bool result = true;
            foreach (CPositionValue item in lstCells)
            {
                if (gvReception.GetRowCellValue(item.row, item.col).ToString().Trim() == "")
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "No es posible reportar, los resultados no estan completos.");
                    result = false;
                    break;
                }
            }
            return result;
        }

        public CPositionValue GetObjectPosition(long idrecep_sample_detail, int idtemplate_method)
        {
            CPositionValue positionValue = new CPositionValue();
            for (int i = 0; i < DTReceptionDetailElem.Rows.Count; i++)
            {
                if (Convert.ToInt64(DTReceptionDetailElem.Rows[i]["idrecep_sample_detail"]) == idrecep_sample_detail
                    && Convert.ToInt32(DTReceptionDetailElem.Rows[i]["idtemplate_method"]) == idtemplate_method)
                {
                    positionValue.idtemplate_method = idtemplate_method;
                    positionValue.idrecep_sample_detail = idrecep_sample_detail;
                    positionValue.idrecep_sample_detail_elem = Convert.ToInt64(DTReceptionDetailElem.Rows[i]["idrecep_sample_detail_elem"]);
                }
            }
            return positionValue;
        }

        public CpositionValueAttach GetObjectPositionAttach(long idrecep_sample_detail, int idtemplate_method)
        {
            CpositionValueAttach positionValueAttach = new CpositionValueAttach();
            for (int i = 0; i < DTReceptionDetailElem.Rows.Count; i++)
            {
                if (Convert.ToInt64(DTReceptionDetailElem.Rows[i]["idrecep_sample_detail"]) == idrecep_sample_detail
                    && Convert.ToInt32(DTReceptionDetailElem.Rows[i]["idtemplate_method"]) == idtemplate_method)
                {
                    positionValueAttach.idtemplate_method = idtemplate_method;
                    positionValueAttach.idrecep_sample_detail = idrecep_sample_detail;
                    positionValueAttach.idrecep_sample_detail_elem = Convert.ToInt64(DTReceptionDetailElem.Rows[i]["idrecep_sample_detail_elem"]);
                }
            }
            return positionValueAttach;
        }

        public CPositionValueProgram GetObjectPositionProgram(long idrecep_sample_detail, int idtemplate_method)
        {
            CPositionValueProgram positionValueProgram = new CPositionValueProgram();
            for (int i = 0; i < DTReceptionDetailElem.Rows.Count; i++)
            {
                if (Convert.ToInt64(DTReceptionDetailElem.Rows[i]["idrecep_sample_detail"]) == idrecep_sample_detail
                    && Convert.ToInt32(DTReceptionDetailElem.Rows[i]["idtemplate_method"]) == idtemplate_method)
                {
                    positionValueProgram.idtemplate_method = idtemplate_method;
                    positionValueProgram.idrecep_sample_detail = idrecep_sample_detail;
                    positionValueProgram.idrecep_sample_detail_elem = Convert.ToInt64(DTReceptionDetailElem.Rows[i]["idrecep_sample_detail_elem"]);
                }
            }
            return positionValueProgram;
        }

        int? GetCurrentRowPartialReport()
        {
            for (int i = 0; i < gvReport.RowCount; i++)
            {
                if (Convert.ToInt16(gvReport.GetRowCellValue(i, gcRep_type_report)) == 1
                    && Convert.ToInt16(gvReport.GetRowCellValue(i, gcRep_report_status)) == 0)
                    return i;
            }
            return null;
        }

        int? GetCurrentRowFinalReport()
        {
            for (int i = 0; i < gvReport.RowCount; i++)
            {
                if (Convert.ToInt16(gvReport.GetRowCellValue(i, gcRep_type_report)) == 2
                    && Convert.ToInt16(gvReport.GetRowCellValue(i, gcRep_report_status)) == 1)
                    return i;
            }
            return null;
        }

        int? GetCurrentRowProgram()
        {
            for (int i = 0; i < gvProgram.RowCount; i++)
            {
                if (Convert.ToInt16(gvProgram.GetRowCellValue(i, gcRep_report_status)) == 1) // en creación
                    return i;
            }
            return null;
        }

        private CPositionValue findUnreport(int row, DevExpress.XtraGrid.Columns.GridColumn col)
        {
            CTagInfoMethod tagMethod = col.Tag as CTagInfoMethod;
            long idrecep_sample_detail = Convert.ToInt64(gvReception.GetRowCellValue(row, gcRec_idrecep_sample_detail));

            foreach (CPositionValue oPositionValue in LstUnreportData)
            {
                if (oPositionValue.idrecep_sample_detail == idrecep_sample_detail &&
                    oPositionValue.idtemplate_method == tagMethod.IDTemplate_method)
                    return oPositionValue;
            }
            return null;
        }

        private CPositionValue findReport(int row, DevExpress.XtraGrid.Columns.GridColumn col)
        {
            if (lstItemsSelReport.Count > 0)
            {
                // se está seleccionando celdas
                foreach (GridCell[] gridcells in lstItemsSelReport)
                {
                    foreach (GridCell gridcell in gridcells)
                    {
                        CPositionValue oPosition = new CPositionValue();
                        oPosition.col = col;
                        oPosition.row = row;
                        oPosition.color = dicColorReport[1];

                        if (gridcell.RowHandle == row &&
                            gridcell.Column == col)
                            return oPosition;
                    }
                }
            }

            if (DicCellsSavedReport.ContainsKey(Convert.ToInt16(gvReport.GetFocusedRowCellValue(gcRep_order_report))))
            {
                // --- pasó la etapa de selección de celdas, mostrar solo el reporte seleccionado
                List<CPositionValue> lstPosition = DicCellsSavedReport[Convert.ToInt16(gvReport.GetFocusedRowCellValue(gcRep_order_report))];

                foreach (CPositionValue oPosition in lstPosition)
                {
                    oPosition.col = col;
                    oPosition.row = row;

                    CTagInfoMethod tagMethod = col.Tag as CTagInfoMethod;
                    long idrecep_sample_detail = Convert.ToInt64(gvReception.GetRowCellValue(row, gcRec_idrecep_sample_detail));

                    if (oPosition.idrecep_sample_detail == idrecep_sample_detail && oPosition.idtemplate_method == tagMethod.IDTemplate_method)
                        return oPosition;
                }
            }
            return null;
        }

        private CPositionValueProgram findProgram(int row, DevExpress.XtraGrid.Columns.GridColumn col)
        {
            if (lstItemsSelProgram.Count > 0)
            {
                // se está seleccionando celdas
                foreach (GridCell[] gridcells in lstItemsSelProgram)
                {
                    foreach (GridCell gridcell in gridcells)
                    {
                        CPositionValueProgram oPosition = new CPositionValueProgram();
                        oPosition.col = col;
                        oPosition.row = row;
                        oPosition.color = Color.Orange;

                        if (gridcell.RowHandle == row &&
                            gridcell.Column == col)
                            return oPosition;
                    }
                }
            }

            if (DicCellsSaveProgram.ContainsKey(Convert.ToInt16(gvProgram.GetFocusedRowCellValue(gcProg_Order_report))))
            {
                // --- pasó la etapa de selección de celdas, mostrar solo el reporte seleccionado
                List<CPositionValueProgram> lstPosition = DicCellsSaveProgram[Convert.ToInt16(gvProgram.GetFocusedRowCellValue(gcProg_Order_report))];

                foreach (CPositionValueProgram oPosition in lstPosition)
                {
                    oPosition.col = col;
                    oPosition.row = row;

                    CTagInfoMethod tagMethod = col.Tag as CTagInfoMethod;
                    long idrecep_sample_detail = Convert.ToInt64(gvReception.GetRowCellValue(row, gcRec_idrecep_sample_detail));

                    if (oPosition.idrecep_sample_detail == idrecep_sample_detail && oPosition.idtemplate_method == tagMethod.IDTemplate_method)
                        return oPosition;
                }
            }
            return null;
        }

        short GetMaxOrderReport()
        {
            short max = 0;
            for (int i = 0; i < gvReport.RowCount; i++)
            {
                object obj = gvReport.GetRowCellValue(i, gcRep_order_report);

                if (obj != null)
                {
                    if (max < Convert.ToInt16(gvReport.GetRowCellValue(i, gcRep_order_report)))
                        max = Convert.ToInt16(gvReport.GetRowCellValue(i, gcRep_order_report));
                }
            }
            return max;
        }

        short GetMaxOrderProgram()
        {
            short max = 0;
            for (int i = 0; i < gvProgram.RowCount; i++)
            {
                object obj = gvProgram.GetRowCellValue(i, gcProg_Order_report);

                if (obj != null)
                {
                    if (max < Convert.ToInt16(gvProgram.GetRowCellValue(i, gcProg_Order_report)))
                        max = Convert.ToInt16(gvProgram.GetRowCellValue(i, gcProg_Order_report));
                }
            }
            return max;
        }

        void Set_order_sample()
        {
            for (int i = 0; i < gvReception.RowCount; i++)
                gvReception.SetRowCellValue(i, gcRec_OrderSample, i + 1);

        }   

        void Config_cell()
        {
            gvReception.OptionsSelection.MultiSelect = true;
            gvReception.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;

            foreach (KeyValuePair<DevExpress.XtraGrid.Columns.GridColumn, bool> kvp in DicShowColumns)
                kvp.Key.OptionsColumn.AllowEdit = false;
        }

        void GetSampleByElems()
        {
            //if (ckVistaResults.Checked)
            if (tabOptionRight.SelectedTabPageIndex == 1
                || tabOptionRight.SelectedTabPageIndex == 2
                || tabOptionRight.SelectedTabPageIndex == 3)
            {
                // --- config cells
                Config_cell();

                // --- show results
                for (int i = 0; i < gvReception.Columns.Count; i++)
                {
                    if (gvReception.Columns[i].Name.Contains("Dyn"))
                    {
                        gvReception.Columns[i].ColumnEdit = repResult;
                        gvReception.Columns[i].Width = 50;
                    }
                }

                // --- return pivot elements
                CRecep_sample_detail_elemFactory faRecep_sample_detail_elem = new CRecep_sample_detail_elemFactory();
                DTReceptionDetailElem = new Reception().GetReceptionDetailElem(oRecep_sample.Idrecep_sample);

                // --- set values in cells
                for (int i = 0; i < gvReception.RowCount; i++)
                {
                    foreach (KeyValuePair<DevExpress.XtraGrid.Columns.GridColumn, bool> kvp in DicShowColumns)
                    {
                        if (kvp.Value)
                        {
                            string valueCell = GetValueCellElem(Convert.ToInt64(gvReception.GetRowCellValue(i, gcRec_idrecep_sample_detail)), kvp.Key.FieldName);

                            //if (valueCell != null)
                            gvReception.SetRowCellValue(i, kvp.Key, valueCell);
                            //else
                            //    gvReception.SetRowCellValue(i, kvp.Key, "--");
                        }
                    }
                }
            }
            else if (tabOptionRight.SelectedTabPageIndex == 0)
            {
                // --- show checkeds
                // --- show results
                for (int i = 0; i < gvReception.Columns.Count; i++)
                {
                    if (gvReception.Columns[i].Name.Contains("Dyn"))
                    {
                        gvReception.Columns[i].ColumnEdit = repSelect;
                        gvReception.Columns[i].Width = 50;
                    }
                }

                // --- return pivot elements
                CRecep_sample_detail_elemFactory faRecep_sample_detail_elem = new CRecep_sample_detail_elemFactory();
                DTReceptionDetailElem = new Reception().GetReceptionDetailElem(oRecep_sample.Idrecep_sample);

                // --- set values in cells
                for (int i = 0; i < gvReception.RowCount; i++)
                {
                    foreach (KeyValuePair<DevExpress.XtraGrid.Columns.GridColumn, bool> kvp in DicShowColumns)
                    {
                        if (kvp.Value)
                        {
                            bool valueCell = GetCheckCellElem(Convert.ToInt64(gvReception.GetRowCellValue(i, gcRec_idrecep_sample_detail)), kvp.Key.FieldName);
                            gvReception.SetRowCellValue(i, kvp.Key, valueCell);
                        }
                    }
                }
            }
        }

        void AddColumn(string cod_template_method)
        {
            // --- create a new column 
            if (tabOptionRight.SelectedTabPage == tpRightReports
                || tabOptionRight.SelectedTabPage == tpRightAttach
                || tabOptionRight.SelectedTabPage == tpRightProgram)
            {
                DataColumn newcol = new DataColumn();
                newcol.Caption = cod_template_method;
                newcol.ColumnName = cod_template_method;
                newcol.DataType = Type.GetType("System.String");
                newcol.DefaultValue = "";
                if (!DTReceptionDetail.Columns.Contains(newcol.ColumnName))
                {
                    DTReceptionDetail.Columns.Add(newcol);
                    ShowColumn(newcol.ColumnName);
                }
            }
            if (tabOptionRight.SelectedTabPage == tpRightMethods)
            {
                DataColumn newcol = new DataColumn();
                newcol.Caption = cod_template_method;
                newcol.ColumnName = cod_template_method;
                newcol.DataType = Type.GetType("System.Boolean");
                newcol.DefaultValue = false;
                if (!DTReceptionDetail.Columns.Contains(newcol.ColumnName))
                {
                    DTReceptionDetail.Columns.Add(newcol);
                    ShowColumn(newcol.ColumnName);
                }
            }
        }

        void ClearElemColumns()
        {
            Dictionary<DevExpress.XtraGrid.Columns.GridColumn, bool> dic = new Dictionary<DevExpress.XtraGrid.Columns.GridColumn, bool>(DicShowColumns);

            foreach (KeyValuePair<DevExpress.XtraGrid.Columns.GridColumn, bool> kvp in dic)
            {
                DicShowColumns[kvp.Key] = false;
                kvp.Key.Visible = false;
            }
        }

        void RetrieveDataCompany()
        {
            // --- recuperate the clients
            if (cbCompany.EditValue != null)
            {

                if (cbCompany.EditValue.ToString().Trim() != "" && cbCompany.EditValue.ToString().Trim() != "0")
                {
                    CCompany oCompany = new CCompany();
                    CCompanyFactory faCompany = new CCompanyFactory();
                    oCompany = faCompany.GetByPrimaryKey(new CCompanyKeys(Convert.ToInt16(cbCompany.EditValue)));

                    tbClientDomicile.Text = oCompany.Domicile;
                    tbClientPhone.Text = oCompany.Phone_client;
                    tbClientRuc.Text = oCompany.Ruc;

                    // --- get/show contacts
                    Reception oReception = new BusinessLayer.Modules.Reception();
                    gcContact.DataSource = new BindingList<CContact>(oReception.GetLstContactsByCompany(oCompany.Idcompany));
                }

                // --- get/show attached files
                Show_exist_files();
            }
        }

        bool isDetail_correct()
        {
            for (int i = 0; i < gvReception.RowCount; i++)
            {
                object ob = gvReception.GetRowCellValue(i, gcRec_Description);
                if (gvReception.GetRowCellValue(i, gcRec_Description) == null
                    || gvReception.GetRowCellValue(i, gcRec_Description).ToString().Trim().Length == 0)
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "No se seleccionó una descripción en la fila "+(i+1).ToString());
                    return false;
                }
                if (typeModuleOpen == typeModule.RegisterReception)
                {
                    if (gvReception.GetRowCellValue(i, gcRec_Procedence) == null
                        || gvReception.GetRowCellValue(i, gcRec_Procedence).ToString().Trim().Length == 0)
                    {
                        ComunForm.Send_message(this.Text, TypeMsg.error, "No se ingresó nombre de procedencia en la fila " + (i + 1).ToString());
                        return false;
                    }
                }
                if (gvReception.GetRowCellValue(i, gcRec_Type_Sample) == null)
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "No se seleccionó una tipo de muestra en la fila "+(i+1).ToString());
                    return false;
                }
                if (gvReception.GetRowCellValue(i, gcRec_NameSample) == null 
                    || gvReception.GetRowCellValue(i, gcRec_NameSample).ToString().Length == 0)
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "No se asignó un nombre de muestra a la fila " + (i+1).ToString());
                    return false;
                }
                if (gvReception.GetRowCellValue(i, gcRec_CantKg).ToString().Trim().Length == 0)
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "No se ingresó correctamente la cantidad de kilogramos en la fila " + (i+1).ToString());
                    return false;
                }
            }
            return true;
        }

        void InitDicColumns()
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gvReception.Columns)
            {
                if (column.Name.Contains("Dyn"))
                    DicShowColumns.Add(column, false);
            }
        }

        bool GetCheckCellElem(long IdrowRecep, string cod_template_method)
        {            
            foreach (DataRow dr in DTReceptionDetailElem.Rows)
            {
                if (Convert.ToInt64(dr["idrecep_sample_detail"]) == IdrowRecep
                    && Convert.ToString(dr["Cod_template_method"].ToString()) == cod_template_method)
                {
                    return true;
                }
            }
            return false;
        }

        string GetValueCellElem(long IdrowRecep, string cod_template_method)
        {
            string value = "---";
            foreach (DataRow dr in DTReceptionDetailElem.Rows)
            {
                if (Convert.ToInt64(dr["idrecep_sample_detail"]) == IdrowRecep
                    && Convert.ToString(dr["Cod_template_method"].ToString()) == cod_template_method)
                {
                    value = dr["Str_result_analysis"].ToString();
                }
            }
            return value;
        }

        void InitDatatable()
        {
            CRecep_sample_detailFactory faRecep_Sample_Detail = new CRecep_sample_detailFactory();
            Reception oReception = new Reception();
            DTReceptionDetail = oReception.GetReceptionDetail(-1);
            gcReception.DataSource = DTReceptionDetail;

            CRecep_sample_detail_elemFactory faRecep_Sample_Detail_Elem = new CRecep_sample_detail_elemFactory();
            DTReceptionDetailElem = oReception.GetReceptionDetailElem(-1);
        }              
        
        void InitDataControls()
        {
            deReception.DateTime = DateTime.Now;
            deHourReception.EditValue = DateTime.Now;            

            // --- init client combo
            CCompanyFactory faCompany = new CCompanyFactory();
            cbCompany.Properties.DataSource = faCompany.GetAll();
            cbCompany.Properties.ValueMember = "Idcompany";
            cbCompany.Properties.DisplayMember = "Business_name";
            
            // --- init element combo
            CElementFactory faElement = new CElementFactory();
            lstElement = faElement.GetAll();
            lstElement.Insert(0, new CElement { Idelement = -1, Cod_element = "Seleccionar" });
            var elementQuery = from table in lstElement
                               select new CItemGenericCombo
                               {
                                   codigo = table.Idelement.ToString(),
                                   descripcion = table.Cod_element
                               };                     


            // --- init type sample combo
            CType_sampleFactory faType_Sample = new CType_sampleFactory();
            cbTypeSample.Properties.DataSource = faType_Sample.GetAll();
            cbTypeSample.Properties.ValueMember = "Cod_type_sample";
            cbTypeSample.Properties.DisplayMember = "Name_type_sample";

            // --- init description combo
            CDescription_sampleFactory faDescrition_Sample = new CDescription_sampleFactory();
            repDescription.DataSource = faDescrition_Sample.GetAll();
            repDescription.ValueMember = "Cod_des_sample";
            repDescription.DisplayMember = "Description";

            

            // --- init anio
            CSerieFactory faSerie = new CSerieFactory();
            Reception oReception = new Reception();

            // --- init status report
            repStatusReport.DataSource = Comun.ListStatusReport;
            repStatusReport.ValueMember = "IdStatus";
            repStatusReport.DisplayMember = "Den_Status";

            // --- init status attach            
            repAttach_status.DataSource = oReception.GetAttachStatus();
            repAttach_status.DisplayMember = "Name_status";
            repAttach_status.ValueMember = "Id";

            repPerson_type.DataSource = oReception.GetLstPersonType();
            repPerson_type.DisplayMember = "Name";
            repPerson_type.ValueMember = "Id";            
        }

        void filteringMethods()
        {
            // --- filtering the list of methods
            string codTypeSample = "";            

            if (cbTypeSample.EditValue != null)
                codTypeSample = cbTypeSample.EditValue.ToString(); //gvReception.GetFocusedRowCellValue(gcRec_Type_Sample).ToString();

            List<CTemplate_method> lstTemplate_method = gcMethods.DataSource as List<CTemplate_method>;
            Reception oReception = new Reception();
            gcMethods.DataSource = oReception.GetMethodsDenominations(codTypeSample);

            gvMethods.BestFitColumns();
        }

        int GetPositionMethod(string cod_template_method)
        {

            for (int i = 0; i < gvMethods.RowCount; i++)
            {
                string s = gvMethods.GetRowCellValue(i, gcMet_Cod_template_method).ToString();
                if (gvMethods.GetRowCellValue(i, gcMet_Cod_template_method).ToString() == cod_template_method)
                    return i;
            }
            return 0;
        }

        void UnShowColumn(DevExpress.XtraGrid.Columns.GridColumn column)
        {
            DicShowColumns[column] = false;
            column.Visible = false;
            DTReceptionDetail.Columns.Remove(column.FieldName);            
        }

        void ShowColumn(string cod_template_method)
        {
            // --- if nameElement not exists in the dictionary, 
            // then show column and assign a reservation for the element
            foreach (KeyValuePair<DevExpress.XtraGrid.Columns.GridColumn, bool> kvp in DicShowColumns)
            {
                if (!kvp.Value)
                {
                    kvp.Key.Visible = true;
                    kvp.Key.Caption = cod_template_method;
                    kvp.Key.FieldName = cod_template_method;
                    kvp.Key.ImageIndex = 9;
                    kvp.Key.Width = 50;
                    DicShowColumns[kvp.Key] = true;

                    // --- the cost of method described here in TagInfoMethod class
                    CTagInfoMethod tagInfoMethod = new CTagInfoMethod();

                    int positionMethod = GetPositionMethod(cod_template_method);

                    tagInfoMethod.IDMeasurement_Unit = Convert.ToInt16(gvMethods.GetRowCellValue(positionMethod, gcMet_Unit1));
                    tagInfoMethod.Name_Measurement_Unit = Convert.ToString(gvMethods.GetRowCellValue(positionMethod, gcMet_Unit_Name));
                    tagInfoMethod.IDElement = Convert.ToInt16(gvMethods.GetRowCellValue(positionMethod, gcMet_Idelement));
                    tagInfoMethod.IDTemplate_method = Convert.ToInt32(gvMethods.GetRowCellValue(positionMethod, gcMet_Idtemplate_method));
                    tagInfoMethod.Cost_Method = Convert.ToDecimal(gvMethods.GetRowCellValue(positionMethod, gcMet_Cost));
                    tagInfoMethod.Cod_template_method = Convert.ToString(gvMethods.GetRowCellValue(positionMethod, gcMet_Cod_template_method));
                    tagInfoMethod.Analysis_Time = Convert.ToDecimal(gvMethods.GetRowCellValue(positionMethod, gcMet_Analisys_time));
                    kvp.Key.Caption = cod_template_method + " - " + gvMethods.GetRowCellValue(positionMethod, gcMet_Abbreviation) + " (" + tagInfoMethod.Name_Measurement_Unit + ")";

                    kvp.Key.Tag = tagInfoMethod;

                    break;
                }
            }
        }

        decimal EstimationAnalisysTime(decimal num_days_method)
        {
            // --- determine the max of number of days
            // --- recorring columns and get the max
            decimal sum_days = num_days_method;
            foreach (KeyValuePair<DevExpress.XtraGrid.Columns.GridColumn, bool> kvp in DicShowColumns)
            {
                if (kvp.Value)
                {
                    string algo = Convert.ToString(gvReception.GetFocusedRowCellValue(kvp.Key));

                    bool selected = Convert.ToBoolean(gvReception.GetFocusedRowCellValue(kvp.Key));

                    if (selected)
                    {
                        if (gvReception.GetFocusedRowCellValue(kvp.Key) != null && gvReception.GetFocusedRowCellValue(kvp.Key).ToString() != "")
                        {
                            CTagInfoMethod oTagInfoMethod = (CTagInfoMethod)kvp.Key.Tag;
                            decimal num_day = oTagInfoMethod.Analysis_Time;

                            sum_days = sum_days + oTagInfoMethod.Analysis_Time;                            
                        }
                    }
                }
            }
            return sum_days;
        }

        void GetAndAssignTotals()
        {
            totalAmount = 0;
            double tmpTotalAmount = 0;
            double totalWithoutIgv = 0;
            double igv = 0;
            decimal Sum_days = 0;

            for (int i = 0; i < gvReception.RowCount; i++)
            {
                if (gvReception.GetRowCellValue(i, gcRec_Cost) != DBNull.Value)
                    totalAmount += Convert.ToDouble(gvReception.GetRowCellValue(i, gcRec_Cost));
                if (gvReception.GetRowCellValue(i, gcRec_Days) != DBNull.Value)
                    Sum_days += Convert.ToDecimal(gvReception.GetRowCellValue(i, gcRec_Days));
            }

            // --- calculate totals in foot            


            totalWithoutIgv = tmpTotalAmount / (1 + 0.18);
            igv = tmpTotalAmount - totalWithoutIgv;

            // --- assign to texbox
            tbTotalAmount.Text = Math.Round(tmpTotalAmount, 2).ToString();
            tbSubTotalAmount.Text = Math.Round(totalWithoutIgv, 2).ToString();
            tbTotalIgv.Text = Math.Round(igv, 2).ToString();

            // --- assign sumdays
            tbNumDays.Value = Sum_days;            
        }

        public void ChangeCellValue()
        {
            decimal TotalCostColumns = 0;
            DevExpress.XtraGrid.Columns.GridColumn column = gvReception.FocusedColumn;

            // --- recalculate the cost value, in base to columns checkered
            if (column.Name.Contains("Dyn"))
            {
                // --- get columns checkered
                foreach (KeyValuePair<DevExpress.XtraGrid.Columns.GridColumn, bool> kvp in DicShowColumns)
                {
                    if (kvp.Value)
                    {
                        CTagInfoMethod tagInfoMethod = (CTagInfoMethod)kvp.Key.Tag;

                        if (kvp.Key == column)
                        {
                            if (Convert.ToBoolean(gvReception.GetFocusedRowCellValue(column)))
                            {
                                string algo = Convert.ToString(gvReception.GetFocusedRowCellValue(column));
                                string algo2 = Convert.ToString(gvReception.GetFocusedRowCellDisplayText(column));                                
                                TotalCostColumns += tagInfoMethod.Cost_Method;
                                gvReception.SetFocusedRowCellValue(gcRec_Cost, TotalCostColumns);
                                gvReception.SetFocusedRowCellValue(gcRec_Days, EstimationAnalisysTime(tagInfoMethod.Analysis_Time));
                                gvReception.UpdateCurrentRow();
                                // --- update total amount of document
                                GetAndAssignTotals();                                
                            }
                        }
                        else
                        {
                            if (Convert.ToBoolean(gvReception.GetFocusedRowCellValue(kvp.Key)))
                            {
                                // --- set the cost of columns                                
                                TotalCostColumns += tagInfoMethod.Cost_Method;
                                gvReception.SetFocusedRowCellValue(gcRec_Cost, TotalCostColumns);
                                gvReception.SetFocusedRowCellValue(gcRec_Days, EstimationAnalisysTime(tagInfoMethod.Analysis_Time));
                                gvReception.UpdateCurrentRow();
                                // --- update total amount of document
                                GetAndAssignTotals();                                
                            }
                        }
                    }
                }
            }
        }

        
        
        #endregion     

        #region events

        private void ucGenerarA_onSelectedIndex(int index)
        {
            if (typeModuleOpen == typeModule.RegisterReception)
            {
                if (index == 0)
                {
                    // --- ampliación de ensayo
                    FormMessage fmMessage = new FormMessage();
                    fmMessage.Title = "Ampliación de Ensayo";
                    fmMessage.Message = "Esta acción copia la estructura y datos del registro en uno nuevo.";

                    if (fmMessage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        // --- registro de recepción
                        FormReception fmReception = new FormReception(oRecep_sample, LoadData.FromRR_ToExtendRR);
                        fmReception.ShowDialog();
                        
                        
                    }
                }
            }            
        }

        private void ucGenerarDesde_onSelectedIndex(int index)
        {
            if (typeModuleOpen == typeModule.RegisterReception)
            {                
            }
        }

        private void ucToolStrip1_onFind()
        {
            if (typeModuleOpen == typeModule.RegisterReception)
            {
                ///attributes
                short? p_year = null;
                short? p_idcompany = null;
                DateTime? p_date_begin = null;
                DateTime? p_date_end = null;

                FormMasterSearch fmBusqueda = new FormMasterSearch();
                fmBusqueda.BindGrid(new ModMasterSearch().GetRegReception(p_year, p_idcompany, p_date_begin, p_date_end));

                fmBusqueda.ShowDialog();

                Dictionary<string, string> keys = fmBusqueda.getKeyValues();

                if (keys != null)
                {
                    Limpiar_Campos();

                    ///get recep sample                                
                    oRecep_sample = faRecep_sample.GetByPrimaryKey(new CRecep_sampleKeys(Convert.ToInt64(keys["Idrecep_sample"])));
                    Recuperar_Registro();
                    loadData = LoadData.MasterSearchRR;
                    thePanelTab1.SelectedIndex = 0;
                    statusRegReception = StatusRegRecep.reg_recep_saved;
                }
            }            

            ChangeStatusControls();
        }

        private void ucToolStrip1_onNew()
        {
            Limpiar_Campos();
        } 

        private void ckDispatchPerson_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDispatchPerson.Checked)
            {
                ckDispatchCurier.Checked = false;
                ckDispatchTransport.Checked = false;
            }
        }

        private void ckDispatchCurier_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDispatchCurier.Checked)
            {
                ckDispatchPerson.Checked = false;
                ckDispatchTransport.Checked = false;
            }
        }

        private void ckDispatchTransport_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDispatchTransport.Checked)
            {
                ckDispatchPerson.Checked = false;
                ckDispatchCurier.Checked = false;
            }
        }

        GridHitInfo hitInfo = null;
        private void gcReception_MouseDown(object sender, MouseEventArgs e)
        {
            hitInfo = gvReception.CalcHitInfo(new Point(e.X, e.Y));
        }

        private void gcReception_MouseMove(object sender, MouseEventArgs e)
        {
            if (hitInfo == null) return;
            if (e.Button != MouseButtons.Left) return;
            Rectangle dragRect = new Rectangle(new Point(
                hitInfo.HitPoint.X - SystemInformation.DragSize.Width / 2,
                hitInfo.HitPoint.Y - SystemInformation.DragSize.Height / 2), SystemInformation.DragSize);
            if (!dragRect.Contains(new Point(e.X, e.Y)))
            {
                if (hitInfo.InColumn)
                {
                    gcReception.DoDragDrop(hitInfo.Column, DragDropEffects.Move);
                }
            }
        }

        private void paDelete_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void paDelete_DragDrop(object sender, DragEventArgs e)
        {
            if (!Readonly)
            {
                // --- get object column
                DevExpress.XtraGrid.Columns.GridColumn drag_column = (DevExpress.XtraGrid.Columns.GridColumn)e.Data.GetData(typeof(DevExpress.XtraGrid.Columns.GridColumn));

                // --- si no tiene datos guardados quitar columna
                UnShowColumn(drag_column);
            }
        }

        private void ucSign1_OnSign(bool login)
        {
            if (login)
            {
                Grabar();
            }
        }

        private void btProgramSelection_Click(object sender, EventArgs e)
        {
            // --- create the program report
            object currentRow = GetCurrentRowProgram();
            if (currentRow == null)
            {
                DataTable dtGroupProgram = gcProgram.DataSource as DataTable;
                DataRow dr = dtGroupProgram.NewRow();
                dr["sel"] = false;
                dr["order_report"] = GetMaxOrderProgram() + 1;
                dr["idrecep_sample_program"] = 0;
                dr["idrecep_sample"] = oRecep_sample.Idrecep_sample;
                dr["Program_status"] = 0;
                dr["Date_report"] = DateTime.Now;
                dr["Time_report"] = DateTime.Now;
                dtGroupProgram.Rows.Add(dr);

                gcProgram.DataSource = dtGroupProgram;
            }
            lstItemsSelProgram.Add(gvReception.GetSelectedCells());
            gvReception.ClearSelection();
        }

        private void repProgramButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // --- save partial or final report
            if (e.Button.Index == 0)
            {
                #region save program

                bool result_insert_program = false;

                CRecep_sample_program oRecep_sample_program = new CRecep_sample_program();
                CRecep_sample_programFactory faRecep_sample_program = new CRecep_sample_programFactory();
                Reception oReception = new Reception();

                oRecep_sample_program = faRecep_sample_program.GetByPrimaryKey(
                    new CRecep_sample_programKeys(Convert.ToInt64(gvProgram.GetFocusedRowCellValue(gcRep_idrecep_sample_report))));

                short report_status = Convert.ToInt16(gvReport.GetFocusedRowCellValue(gcRep_report_status));

                // si es un reporte en creación poner como reservado
                if (report_status == Convert.ToInt16(Comun.ReportStatus.EnCreacion)) // --- creacion
                {
                    oRecep_sample_program = new CRecep_sample_program();
                    gvReport.SetFocusedRowCellValue(gcProg_Program_status, Convert.ToInt16(Comun.ReportStatus.Reportado));
                    oRecep_sample_program.Idrecep_sample = oRecep_sample.Idrecep_sample;
                    oRecep_sample_program.Idrecep_sample_program = Convert.ToInt64(gvProgram.GetFocusedRowCellValue(gcProg_Idrecep_sample_program));
                    oRecep_sample_program.Order_report = Convert.ToInt16(gvProgram.GetFocusedRowCellValue(gcProg_Order_report));
                    oRecep_sample_program.Program_status = Convert.ToInt16(Comun.ReportStatus.Reportado);
                    oRecep_sample_program.Cod_recep_sample_program = oReception.GetNewCodProgram();
                    oRecep_sample_program.Date_report = Convert.ToDateTime(gvProgram.GetFocusedRowCellValue(gcProg_Date_report));
                    oRecep_sample_program.Time_report = Convert.ToDateTime(gvProgram.GetFocusedRowCellValue(gcProg_Time_report));

                    result_insert_program = faRecep_sample_program.Insert(oRecep_sample_program);

                    gvProgram.SetFocusedRowCellValue(gcProg_Program_status, oRecep_sample_program.Program_status);
                    gvProgram.SetFocusedRowCellValue(gcProg_Idrecep_sample_program, oRecep_sample_program.Idrecep_sample_program);
                    gvProgram.SetFocusedRowCellValue(gcProg_Cod_recep_sample_program, oRecep_sample_program.Cod_recep_sample_program);
                    gvProgram.SetFocusedRowCellValue(gcProg_Str_cod_recep_sample_program, oReception.GetFormatProgramCode(oRecep_sample_program.Cod_recep_sample_program));

                    if (result_insert_program)
                    {
                        // --- create the partial report
                        List<CPositionValueProgram> lstPositionValueProgram = new List<CPositionValueProgram>();

                        foreach (GridCell[] cells in lstItemsSelProgram)
                        {
                            foreach (GridCell cell in cells)
                            {
                                CTagInfoMethod tagMethod = (CTagInfoMethod)cell.Column.Tag;

                                int idtemplate_method = tagMethod.IDTemplate_method;
                                long idrecep_sample_detail = Convert.ToInt64(gvReception.GetRowCellValue(cell.RowHandle, gcRec_idrecep_sample_detail));
                                long idrecep_sample_program = oRecep_sample_program.Idrecep_sample_program;

                                CPositionValueProgram position = GetObjectPositionProgram(idrecep_sample_detail, tagMethod.IDTemplate_method);
                                CCells_programFactory faCells_reported = new CCells_programFactory();
                                CCells_program oCell_program = new CCells_program();

                                oCell_program.Idtemplate_method = idtemplate_method;
                                oCell_program.Idrecep_sample_detail = idrecep_sample_detail;
                                oCell_program.Idrecep_sample_program = idrecep_sample_program;
                                oCell_program.Idrecep_sample_detail_elem = position.idrecep_sample_detail_elem;

                                bool result_cell_reported = false;

                                if (!(result_cell_reported = faCells_reported.Update(oCell_program)))
                                    result_cell_reported = faCells_reported.Insert(oCell_program);

                                if (result_cell_reported)
                                {
                                    position.idrecep_sample_program = idrecep_sample_program;
                                    position.row = cell.RowHandle;
                                    position.col = cell.Column;
                                    position.idcell_program = oCell_program.Idcell_reported;
                                    position.color = Comun.ColorRojo;

                                    if (!lstPositionValueProgram.Exists(c => c.idrecep_sample_detail_elem == position.idrecep_sample_detail_elem))
                                        lstPositionValueProgram.Add(position);
                                }
                            }
                        }
                        lstItemsSelProgram.Clear();
                        DicCellsSaveProgram.Add(Convert.ToInt32(oRecep_sample_program.Order_report), lstPositionValueProgram);
                    }
                }

                #endregion

                lstItemsSelProgram.Clear();
                gvReception.Focus();
            }
        }

        private void gvProgram_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.Column == gcProg_Program_status
                || e.Column == gcProg_Order_report || e.Column == gcProg_Date_report
                || e.Column == gcProg_Time_report || e.Column == gcProg_Str_cod_recep_sample_program)
            {
                if (Convert.ToInt32(gvProgram.GetRowCellValue(e.RowHandle, gcProg_Program_status)) == 0)
                    e.Appearance.BackColor = Color.Orange;
                else
                {
                    e.Appearance.BackColor = Comun.ColorRojo;
                }
            }
        }

        private void gvProgram_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            // --- repaint grid
            gvReception.RestoreDefaultStyles();
        }

        private void gvProgram_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gvReception.SetRowCellValue(e.RowHandle, gcProg_Order_report, GetNextOrderReport());
        } 

        private void btNewFile_Click(object sender, EventArgs e)
        {
            BindingList<CDocAttach> ListGroupAttachFile = gcAttachFile.DataSource as BindingList<CDocAttach>;

            // --- add a new file to list
            string next_filename = "";
            int next_file_order = 0;
            Reception oReception = new Reception();

            //oReception.GetNextFileName(ref next_filename, ref next_file_order);

            CDocAttach oDocAttach = new CDocAttach();
            oDocAttach.Iddocument_recep = 0;
            oDocAttach.Idrecep_sample_attach = 0;
            oDocAttach.Idrecep_sample = oRecep_sample.Idrecep_sample;
            oDocAttach.Name_file = next_filename;
            oDocAttach.Order_file = next_file_order;
            oDocAttach.Source_path = ofdRecepFileAttach.FileName;
            oDocAttach.Attach_status = 1;      // C:en creacion, A:adjuntado(bd)
            ListGroupAttachFile.Add(oDocAttach);
            gcAttachFile.DataSource = ListGroupAttachFile;

            lstItemsSelAttach.Add(gvReception.GetSelectedCells());
            gvReception.ClearSelection();
        }

        private void repButtons_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                // tasks
                // 1. guardar archivo en dirección del disco
                // 2. cambiar de estado de creación a guardado
                // 3. vincular celdas a archivos adjuntos
                short attach_status = Convert.ToInt16(gvAttachFile.GetFocusedRowCellValue(gcAtt_Attach_status));
                CRecep_sample_attach oRecep_sample_attach = new CRecep_sample_attach();
                CRecep_sample_attachFactory faRecep_sample_attach = new CRecep_sample_attachFactory();

                if (attach_status == Convert.ToInt16(Comun.AttachStatus.EnCreacion)) // --- creacion
                {
                    oRecep_sample_attach = new CRecep_sample_attach();
                    gvAttachFile.SetFocusedRowCellValue(gcAtt_Attach_status, Convert.ToInt16(Comun.AttachStatus.Adjuntado));
                    oRecep_sample_attach.Idrecep_sample = oRecep_sample.Idrecep_sample;
                    oRecep_sample_attach.Idrecep_sample_attach = Convert.ToInt64(gvAttachFile.GetFocusedRowCellValue(gcAtt_Idrecep_sample_attach));
                    oRecep_sample_attach.Iddocument_recep = Convert.ToInt32(gvAttachFile.GetFocusedRowCellValue(gcAtt_Iddocument_recep));

                    bool result_attach = faRecep_sample_attach.Insert(oRecep_sample_attach);

                    if (result_attach)
                    {
                        // --- create the partial report
                        List<CpositionValueAttach> lstPositionAttachValue = new List<CpositionValueAttach>();

                        foreach (GridCell[] cells in lstItemsSelAttach)
                        {
                            foreach (GridCell cell in cells)
                            {
                                CTagInfoMethod tagMethod = (CTagInfoMethod)cell.Column.Tag;

                                int idtempladte_method = tagMethod.IDTemplate_method;
                                long idrecep_sample_detail = Convert.ToInt64(gvReception.GetRowCellValue(cell.RowHandle, gcRec_idrecep_sample_detail));
                                long idrecep_sample_attach = oRecep_sample_attach.Idrecep_sample_attach;

                                CpositionValueAttach position = GetObjectPositionAttach(idrecep_sample_detail, tagMethod.IDTemplate_method);
                                CCells_attach_fileFactory faCells_attach = new CCells_attach_fileFactory();
                                CCells_attach_file oCell_attach_file = new CCells_attach_file();

                                oCell_attach_file.Idtemplate_method = idtempladte_method;
                                oCell_attach_file.Idrecep_sample_attach = idrecep_sample_attach;
                                oCell_attach_file.Idrecep_sample_detail_elem = position.idrecep_sample_detail_elem;

                                bool result_cell_attached = false;

                                if (!(result_cell_attached = faCells_attach.Update(oCell_attach_file)))
                                    result_cell_attached = faCells_attach.Insert(oCell_attach_file);

                                if (result_cell_attached)
                                {
                                    position.idrecep_sample_attach = idrecep_sample_attach;
                                    position.row = cell.RowHandle;
                                    position.col = cell.Column;
                                    position.idcell_attach_file = oCell_attach_file.Idcells_attach_file;
                                    position.color = Color.YellowGreen;

                                    if (!lstPositionAttachValue.Exists(c => c.idrecep_sample_detail_elem == position.idrecep_sample_detail_elem))
                                        lstPositionAttachValue.Add(position);
                                }
                            }
                        }
                        DicCellsSavedAttach.Add(Convert.ToInt16(oRecep_sample_attach.Order_file), lstPositionAttachValue);
                    }

                }

            }
        }

        private void gvAttachFile_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (statusRegReception == StatusRegRecep.reg_recep_saved)
            {
                if (e.Column == gcAtt_Attach_status)
                    e.Appearance.BackColor = dicColorAttach[Convert.ToInt16(gvAttachFile.GetRowCellValue(e.RowHandle, gcAtt_Attach_status))];
            }
        }

        private void tabOptionRight_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            Limpiar_SelectPage();
            Recuperar_Registro();
        }

        private void tbNumDays_EditValueChanged(object sender, EventArgs e)
        {
            deResult.DateTime = deReception.DateTime.AddDays(Convert.ToDouble(tbNumDays.Value));
        }

        private void gvContact_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gvContact.SetRowCellValue(e.RowHandle, gcCon_Person_type, 1);
            //gvContact.SetRowCellValue(e.RowHandle, gcCon_Idrecep_sample, Idrecep_sample);
            gvContact.SetRowCellValue(e.RowHandle, gcCon_Allname, "");
            gvContact.SetRowCellValue(e.RowHandle, gcCon_Mail, "");
            gvContact.SetRowCellValue(e.RowHandle, gcCon_Phone, "");
            gvContact.SetRowCellValue(e.RowHandle, gcCon_Cellphone, "");

            if (cbCompany.EditValue != null)
                gvContact.SetRowCellValue(e.RowHandle, gcCon_Idcompany, Convert.ToInt16(cbCompany.EditValue));

            gvContact.SetRowCellValue(e.RowHandle, gcCon_Idrecep_company_person, 0);
        }

        private void tbAmortization_EditValueChanged(object sender, EventArgs e)
        {
            if (tbTotalAmount.Value > 0 && tbAmortization.Value <= tbTotalAmount.Value)
            {
                tbResidue.Value = tbTotalAmount.Value - tbAmortization.Value;
                tbResidue.BackColor = Color.Coral;
            }
            else if (tbTotalAmount.Value == tbAmortization.Value)
            {
                tbResidue.BackColor = Color.LemonChiffon;
            }
            else
                toolTipController1.ShowHint("Cantidad amortizada no válida.");
        }

        private void gvReport_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            // --- repaint grid
            gvReception.RestoreDefaultStyles();
        }

        private void gvReport_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gvReception.SetRowCellValue(e.RowHandle, gcRep_order_report, GetNextOrderReport());
        }

        private void btReportClient_Click(object sender, EventArgs e)
        {
            CReportTestClientFactory faReportClientTest = new CReportTestClientFactory();
            DataTable dtResults = faReportClientTest.GetResultByClient();
            DataTable dtClients = faReportClientTest.GetClient();

            oFastReportMethods.ReportName = "ReportTestClient.frx";

            oFastReportMethods.RegisterDataTable(dtResults, "Results");
            oFastReportMethods.RegisterDataTable(dtClients, "Clients");

            oFastReportMethods.DesignReport();
        }

        private void cbClientName_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            // clear fields
            cbCompany.Text = "";
            tbClientRuc.Text = "";
            tbClientDomicile.Text = "";
            tbClientPhone.Text = "";
            tbFax.Text = "";
            gcContact.DataSource = null;

            DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Edit;
            Edit = ((DevExpress.XtraEditors.LookUpEdit)sender).Properties;

            if (e.DisplayValue == null || Edit.NullText.Equals(e.DisplayValue) || string.Empty.Equals(e.DisplayValue))
                return;

            List<CCompany> ListCompanies = (List<CCompany>)cbCompany.Properties.DataSource;

            ListCompanies.Add(new CCompany { Idcompany = 0, Business_name = e.DisplayValue.ToString() });
            cbCompany.Properties.DataSource = ListCompanies;

            // --- add contacts
            Reception oReception = new BusinessLayer.Modules.Reception();
            gcContact.DataSource = new BindingList<CContact>(oReception.GetLstContactsByCompany(0));

            e.Handled = true;
        }

        private void gvReception_RowCountChanged(object sender, EventArgs e)
        {
            Set_order_sample();
        }

        private void btPrintTicket_Click_1(object sender, EventArgs e)
        {
            CFastReportMethods oFastReportEtiq = new CFastReportMethods();
            CReportEtiqFactory faReportEtiq = new CReportEtiqFactory();
            DataTable dtSamples = faReportEtiq.GetReportSamples(oRecep_sample.Idrecep_sample);
            DataTable dtMethodsBySample = faReportEtiq.GetReportMethodsBySamples(oRecep_sample.Idrecep_sample);
            oFastReportEtiq.ReportName = "ReportPrintEtiq.frx";
            oFastReportEtiq.RegisterDataTable(dtSamples, "Samples");
            oFastReportEtiq.RegisterDataTable(dtMethodsBySample, "Methods");
            oFastReportEtiq.ShowPreviewReport();
        }

        private void btDesignPrint_Click(object sender, EventArgs e)
        {
            CFastReportMethods oFastReportEtiq = new CFastReportMethods();
            CReportEtiqFactory faReportEtiq = new CReportEtiqFactory();
            DataTable dtSamples = faReportEtiq.GetReportSamples(oRecep_sample.Idrecep_sample);
            DataTable dtMethodsBySample = faReportEtiq.GetReportMethodsBySamples(oRecep_sample.Idrecep_sample);
            oFastReportEtiq.ReportName = "ReportPrintEtiq.frx";
            oFastReportEtiq.RegisterDataTable(dtSamples, "Samples");
            oFastReportEtiq.RegisterDataTable(dtMethodsBySample, "Methods");
            oFastReportEtiq.DesignReport();
        }

        private void repLink_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //FormAttach ofmAttach = new FormAttach();
        }

        private void repDescription_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit cbDescription = sender as DevExpress.XtraEditors.LookUpEdit;
            if (e.Button.Index == 1)
            {
                for (int i = 0; i < gvReception.RowCount; i++)
                    gvReception.SetRowCellValue(i, gcRec_Description, cbDescription.EditValue);
            }
        }

        private void repProcedence_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.ButtonEdit tbProcedence = sender as DevExpress.XtraEditors.ButtonEdit;
            if (e.Button.Index == 0)
            {
                for (int i = 0; i < gvReception.RowCount; i++)
                    gvReception.SetRowCellValue(i, gcRec_Procedence, tbProcedence.Text);
            }
        }

        private void cbTypeSample_EditValueChanged(object sender, EventArgs e)
        {
            gcReception.EmbeddedNavigator.Enabled = true;

            // --- filtering the list of methods
            filteringMethods();

            Show_exist_files();

            if (cbTypeSample.EditValue.ToString() == "AG")
                typeModuleOpen = typeModule.ReceptionAguas;
            else
                typeModuleOpen = typeModule.RegisterReception;

            InitAppareance();
        }

        private void btMakePartialReport_Click(object sender, EventArgs e)
        {
            // --- create the partial report
            if (!HasEmptyCells(gvReception.GetSelectedCells()))
            {
                if (!HasInterceptionPartialReport(gvReception.GetSelectedCells()))
                {
                    object currentRow = GetCurrentRowPartialReport();
                    if (currentRow == null)
                    {
                        DataTable dtGroupReport = gcReport.DataSource as DataTable;
                        DataRow dr = dtGroupReport.NewRow();
                        dr["sel"] = false;
                        dr["order_report"] = GetMaxOrderReport() + 1;
                        dr["idrecep_sample_report"] = 0;
                        dr["report_status"] = 0;
                        dr["type_report"] = 1;
                        dr["idrecep_sample"] = oRecep_sample.Idrecep_sample;
                        dr["Date_report"] = DateTime.Now;
                        dr["Time_report"] = DateTime.Now;
                        dtGroupReport.Rows.Add(dr);

                        gcReport.DataSource = dtGroupReport;
                    }
                    lstItemsSelReport.Add(gvReception.GetSelectedCells());
                    gvReception.ClearSelection();
                }
            }
        }

        private void btMakeFinalReport_Click(object sender, EventArgs e)
        {
            // --- create the final report
            object currentRow = GetCurrentRowFinalReport();
            if (currentRow == null)
            {
                DataTable dtGroupReport = gcReport.DataSource as DataTable;
                DataRow dr = dtGroupReport.NewRow();
                dr["sel"] = false;
                dr["order_report"] = GetMaxOrderReport() + 1;
                dr["idrecep_sample_report"] = 0;
                dr["report_status"] = 0;
                dr["type_report"] = 2;
                dr["idrecep_sample"] = oRecep_sample.Idrecep_sample;
                dr["Date_report"] = DateTime.Now;
                dr["Time_report"] = DateTime.Now;
                dtGroupReport.Rows.Add(dr);

                gcReport.DataSource = dtGroupReport;

            }

            lstItemsSelReport.Add(gvReception.GetSelectedCells());
            gvReception.ClearSelection();
        }

        private void repReportOption_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // --- save partial or final report
            if (e.Button.Index == 0)
            {
                // --- report data
                #region save report

                bool result_report = false;

                CRecep_sample_report oRecep_sample_report = new CRecep_sample_report();
                CRecep_sample_reportFactory faRecep_sample_report = new CRecep_sample_reportFactory();
                Reception oReception = new Reception();

                oRecep_sample_report = faRecep_sample_report.GetByPrimaryKey(
                    new CRecep_sample_reportKeys(Convert.ToInt64(gvReport.GetFocusedRowCellValue(gcRep_idrecep_sample_report))));

                short report_status = Convert.ToInt16(gvReport.GetFocusedRowCellValue(gcRep_report_status));

                // si es un reporte en creación poner como reservado
                if (report_status == Convert.ToInt16(Comun.ReportStatus.EnCreacion)) // --- creacion
                {
                    oRecep_sample_report = new CRecep_sample_report();
                    gvReport.SetFocusedRowCellValue(gcRep_report_status, Convert.ToInt16(Comun.ReportStatus.Reportado));
                    oRecep_sample_report.Idrecep_sample = oRecep_sample.Idrecep_sample;
                    oRecep_sample_report.Idrecep_sample_report = Convert.ToInt64(gvReport.GetFocusedRowCellValue(gcRep_idrecep_sample_report));
                    oRecep_sample_report.Order_report = Convert.ToInt16(gvReport.GetFocusedRowCellValue(gcRep_order_report));
                    oRecep_sample_report.Report_status = Convert.ToInt16(Comun.ReportStatus.Reportado);
                    oRecep_sample_report.Type_report = Convert.ToInt16(gvReport.GetFocusedRowCellValue(gcRep_type_report));      // --- 1:parcial, 2:final
                    oRecep_sample_report.Cod_recep_sample_report = oReception.GetNewCodReport(Convert.ToInt16(gvReport.GetFocusedRowCellValue(gcRep_type_report)));
                    oRecep_sample_report.Date_report = DateTime.Now;
                    oRecep_sample_report.Time_report = DateTime.Now;

                    result_report = faRecep_sample_report.Insert(oRecep_sample_report);

                    gvReport.SetFocusedRowCellValue(gcRep_idrecep_sample_report, oRecep_sample_report.Idrecep_sample_report);
                    gvReport.SetFocusedRowCellValue(gcRep_cod_recep_sample_report, oRecep_sample_report.Cod_recep_sample_report);
                    gvReport.SetFocusedRowCellValue(gcRep_Str_cod_recep_sample_report, oReception.GetFormatReportCode(oRecep_sample_report.Type_report, oRecep_sample_report.Cod_recep_sample_report));

                    if (result_report)
                    {
                        // --- create the partial report
                        List<CPositionValue> lstPositionValue = new List<CPositionValue>();

                        foreach (GridCell[] cells in lstItemsSelReport)
                        {
                            foreach (GridCell cell in cells)
                            {
                                CTagInfoMethod tagMethod = (CTagInfoMethod)cell.Column.Tag;

                                int idtemplate_method = tagMethod.IDTemplate_method;
                                long idrecep_sample_detail = Convert.ToInt64(gvReception.GetRowCellValue(cell.RowHandle, gcRec_idrecep_sample_detail));
                                long idrecep_sample_report = oRecep_sample_report.Idrecep_sample_report;

                                CPositionValue position = GetObjectPosition(idrecep_sample_detail, tagMethod.IDTemplate_method);
                                CCells_reportedFactory faCells_reported = new CCells_reportedFactory();
                                CCells_reported oCell_reported = new CCells_reported();

                                oCell_reported.Idtemplate_method = idtemplate_method;
                                oCell_reported.Idrecep_sample_detail = idrecep_sample_detail;
                                oCell_reported.Idrecep_sample_report = idrecep_sample_report;
                                oCell_reported.Idrecep_sample_detail_elem = position.idrecep_sample_detail_elem;

                                bool result_cell_reported = false;

                                if (!(result_cell_reported = faCells_reported.Update(oCell_reported)))
                                    result_cell_reported = faCells_reported.Insert(oCell_reported);

                                if (result_cell_reported)
                                {
                                    position.idrecep_sample_report = idrecep_sample_report;
                                    position.row = cell.RowHandle;
                                    position.col = cell.Column;
                                    position.idcell_reported = oCell_reported.Idcell_reported;
                                    if (oRecep_sample_report.Type_report == 1)
                                        position.color = Partial_report_color;
                                    else
                                        position.color = Final_report_color;

                                    if (!lstPositionValue.Exists(c => c.idrecep_sample_detail_elem == position.idrecep_sample_detail_elem))
                                        lstPositionValue.Add(position);
                                }
                            }
                        }
                        lstItemsSelReport.Clear();
                        DicCellsSavedReport.Add(Convert.ToInt16(oRecep_sample_report.Order_report), lstPositionValue);
                        GetUnreportData(oRecep_sample.Idrecep_sample);
                    }
                }

                #endregion

                lstItemsSelReport.Clear();
                gvReception.Focus();
            }
            else if (e.Button.Index == 1)
            {
                // --- INFORME DE ENSAYO LAS-13-01299
                CReportTestFactory faReportTest = new CReportTestFactory();

                DataTable dtResults = faReportTest.GetReportResults(Convert.ToInt64(gvReport.GetFocusedRowCellValue(gcRep_idrecep_sample_report)));
                DataTable dtHead = faReportTest.GetReportHead(Convert.ToInt64(gvReport.GetFocusedRowCellValue(gcRep_idrecep_sample_report)));
                DataTable dtMethods = faReportTest.GetReportMethods(Convert.ToInt64(gvReport.GetFocusedRowCellValue(gcRep_idrecep_sample_report)));

                oFastReportMethods.AddParameter("Attention", GetContactAttention(oRecep_sample.Idrecep_sample));
                oFastReportMethods.AddParameter("Cod_report", gvReport.GetFocusedRowCellValue(gcRep_Str_cod_recep_sample_report).ToString());
                oFastReportMethods.AddParameter("Date_report", Convert.ToDateTime(gvReport.GetFocusedRowCellValue(gcRep_Date_report)));
                oFastReportMethods.ReportName = "ReportTest.frx";
                oFastReportMethods.RegisterDataTable(dtHead, "Head");
                oFastReportMethods.RegisterDataTable(dtMethods, "Methods");
                oFastReportMethods.RegisterDataTable(dtResults, "Results");

                oFastReportMethods.ShowPreviewReport();
            }
            else if (e.Button.Index == 2)
            {
                CReportTestFactory faReportTest = new CReportTestFactory();
                DataTable dtResults = faReportTest.GetReportResults(Convert.ToInt64(gvReport.GetFocusedRowCellValue(gcRep_idrecep_sample_report)));
                DataTable dtHead = faReportTest.GetReportHead(Convert.ToInt64(gvReport.GetFocusedRowCellValue(gcRep_idrecep_sample_report)));
                DataTable dtMethods = faReportTest.GetReportMethods(Convert.ToInt64(gvReport.GetFocusedRowCellValue(gcRep_idrecep_sample_report)));

                oFastReportMethods.AddParameter("Attention", GetContactAttention(oRecep_sample.Idrecep_sample));
                oFastReportMethods.AddParameter("Cod_report", gvReport.GetFocusedRowCellValue(gcRep_Str_cod_recep_sample_report).ToString());
                oFastReportMethods.AddParameter("Date_report", Convert.ToDateTime(gvReport.GetFocusedRowCellValue(gcRep_Date_report)));
                oFastReportMethods.ReportName = "ReportTest.frx";
                oFastReportMethods.RegisterDataTable(dtHead, "Head");
                oFastReportMethods.RegisterDataTable(dtMethods, "Methods");
                oFastReportMethods.RegisterDataTable(dtResults, "Results");

                oFastReportMethods.DesignReport();
            }
        }

        private void gvReport_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.Column == gcRep_report_status)
            {
                if (Convert.ToInt32(gvReport.GetRowCellValue(e.RowHandle, gcRep_report_status)) == 0)
                    e.Appearance.BackColor = Color.Orange;
                else
                {
                    if (Convert.ToInt16(gvReport.GetRowCellValue(e.RowHandle, gcRep_type_report)) == 1)
                        e.Appearance.BackColor = Partial_report_color;
                    else
                        e.Appearance.BackColor = Final_report_color;
                }
            }
        }

        private void gvReception_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (statusRegReception == StatusRegRecep.reg_recep_saved)
            {
                switch (tabOptionRight.SelectedTabPageIndex)
                {
                    case 0:

                        break;
                    case 1:
                        if (e.Column.Name.Contains("Dyn"))
                        {
                            // --- draw color style cell without result
                            AppearanceObject styleRed = new AppearanceObject();
                            styleRed.BackColor = Color.Blue;
                            styleRed.BackColor2 = Color.Blue;
                            styleRed.ForeColor = Color.White;
                            styleRed.Font = new Font(styleRed.Font, FontStyle.Bold);
                            styleRed.Options.UseTextOptions = true;
                            gvReception.Appearance.SelectedRow.Assign(styleRed);

                            // --- draw color style cell report or enCreacion report
                            CPositionValue cell = findReport(e.RowHandle, e.Column);

                            if (cell != null)
                            {
                                e.Appearance.BackColor = cell.color;
                                e.Appearance.Options.UseBorderColor = true;
                                e.Appearance.BorderColor = Color.Red;
                            }
                        }
                        break;
                    case 3:
                        if (e.Column.Name.Contains("Dyn"))
                        {
                            // --- draw color style cell without result
                            AppearanceObject styleRed = new AppearanceObject();
                            styleRed.BackColor = Color.Blue;
                            styleRed.BackColor2 = Color.Blue;
                            styleRed.ForeColor = Color.White;
                            styleRed.Font = new Font(styleRed.Font, FontStyle.Bold);
                            styleRed.Options.UseTextOptions = true;
                            gvReception.Appearance.SelectedRow.Assign(styleRed);

                            // --- draw color style cell report or enCreacion report
                            CPositionValueProgram cell = findProgram(e.RowHandle, e.Column);

                            if (cell != null)
                            {
                                e.Appearance.BackColor = cell.color;
                                e.Appearance.Options.UseBorderColor = true;
                                e.Appearance.BorderColor = Color.Red;
                            }
                        }
                        break;
                }
            }
        }

        private void cbClientName_EditValueChanged(object sender, EventArgs e)
        {
            RetrieveDataCompany();
        }

        private void gvGroupReport_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            //gvGroupReport.SetRowCellValue(e.RowHandle, gcRep_Order_report, GetMaxOrderReport() + 1);
            //gvGroupReport.SetRowCellValue(e.RowHandle, gcRep_Report_status, Convert.ToInt16(Comun.ReportStatus.Process));
            //gvGroupReport.SetRowCellValue(e.RowHandle, gcRep_Sel, false);
        }

        private void repDescription_EditValueChanged(object sender, EventArgs e)
        {
            // --- assign the code description at the column grid
            DevExpress.XtraEditors.LookUpEdit combo = (DevExpress.XtraEditors.LookUpEdit)sender;
            gvReception.SetFocusedRowCellValue(gcRec_Description, combo.EditValue);
        }

        private void gvReception_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {            
            gvReception.SetRowCellValue(e.RowHandle, "Flag_reject", false);
            gvReception.SetRowCellValue(e.RowHandle, "Flag_counter_sample", 0);
            gvReception.SetRowCellValue(e.RowHandle, "Amount_weight", 0.1);
            gvReception.SetRowCellValue(e.RowHandle, "Cod_type_sample", cbTypeSample.EditValue.ToString());
            gvReception.SetRowCellValue(e.RowHandle, "Analisys_time", 0);
            gvReception.SetRowCellValue(e.RowHandle, "gcRec_Flag_envelope_sealed", false);
            gvReception.UpdateCurrentRow();
            Set_order_sample();
        }

        private void cbElement_ChangeItem()
        {
            filteringMethods();
        }

        private void gvReception_KeyDown(object sender, KeyEventArgs e)
        {
            // --- add a new row when the focus is in the last row
            if (e.KeyCode == Keys.Down && gvReception.FocusedRowHandle == gvReception.RowCount - 1)
                gvReception.AddNewRow();            
        }

        private void gvReception_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // --- filtering methods when change the focus row
            filteringMethods();
        }

        private void repAddColumn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!Readonly)
            {
                // --- create a new column             
                AddColumn(gvMethods.GetFocusedRowCellValue(gcMet_Cod_template_method).ToString());
                SortColumnsByCodTemplate();
            }
        }        

        private void gvReception_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {            
            if (e.Column.Name.Contains("Dyn"))
            {
                // --- set totalCostColumns in 0
                decimal TotalCostColumns = 0;
                decimal TotalDaysColumns = 0;

                gvReception.SetFocusedRowCellValue(gcRec_Cost, TotalCostColumns);
                gvReception.SetFocusedRowCellValue(gcRec_Days, TotalDaysColumns);

                // --- get columns checkered
                foreach (KeyValuePair<DevExpress.XtraGrid.Columns.GridColumn, bool> kvp in DicShowColumns)
                {
                    if (kvp.Value)
                    {
                        CTagInfoMethod tagInfoMethod = (CTagInfoMethod)kvp.Key.Tag;

                        if (kvp.Key == e.Column)
                        {
                            if (Convert.ToBoolean(e.Value))
                            {                                
                                TotalCostColumns += tagInfoMethod.Cost_Method;
                                
                                if (TotalDaysColumns < tagInfoMethod.Analysis_Time)
                                    TotalDaysColumns = tagInfoMethod.Analysis_Time;
                                
                                gvReception.SetFocusedRowCellValue(gcRec_Cost, TotalCostColumns);
                                gvReception.SetFocusedRowCellValue(gcRec_Days, TotalDaysColumns);                                
                                                                                                
                                // --- update total amount of document
                                GetAndAssignTotals();
                            }
                        }
                        else
                        {
                            if (Convert.ToBoolean(gvReception.GetFocusedRowCellValue(kvp.Key)))
                            {
                                // --- set the cost of columns                              
                                TotalCostColumns += tagInfoMethod.Cost_Method;
                                TotalDaysColumns += tagInfoMethod.Analysis_Time;
                                
                                gvReception.SetFocusedRowCellValue(gcRec_Cost, TotalCostColumns);
                                gvReception.SetFocusedRowCellValue(gcRec_Days, TotalDaysColumns);

                                // --- update total amount of document
                                GetAndAssignTotals();
                            }
                        }
                    }
                }
            }
        }

        private void gvReception_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column != null && (e.Column.Name.Contains("Dyn")
                || e.Column.Name.Contains("gcRec_Days") || e.Column.Name.Contains("gcRec_CantKg")
                || e.Column.Name.Contains("gcRec_Reject") || e.Column.Name.Contains("gcRec_Counter_Sample")
                || e.Column.Name.Contains("gcRec_Flag_envelope_sealed")))
            {
                Rectangle rectangle = e.Info.CaptionRect;
                e.Info.Caption = string.Empty;
                e.Painter.DrawObject(e.Info);

                System.Drawing.Drawing2D.GraphicsState state = e.Graphics.Save();
                var stringFormat = new StringFormat();
                stringFormat.Trimming = StringTrimming.EllipsisCharacter;
                stringFormat.FormatFlags |= StringFormatFlags.NoWrap;
                stringFormat.FormatFlags |= StringFormatFlags.DirectionVertical;
                stringFormat.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
                e.Graphics.DrawString(e.Column.Caption, e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), rectangle, stringFormat);
                e.Graphics.Restore(state);

                e.Handled = true;
            }
        }

        private void cbClientName_ChangeItem()
        {
            // --- assign idClient to private variable
            IDCompany = Convert.ToInt16(cbCompany.EditValue);

            CCompany oCompany = new CCompanyFactory().GetByPrimaryKey(new CCompanyKeys(IDCompany));

            if (oCompany != null)
            {
                tbClientDomicile.Text = oCompany.Domicile;
                tbClientRuc.Text = oCompany.Ruc;
                tbClientPhone.Text = oCompany.Phone_client;                
            }
        }        

        private void gvReception_Click(object sender, EventArgs e)
        {
            if (!Readonly)
            {
                if (cbTypeSample.EditValue != null)
                {
                    DevExpress.XtraGrid.Columns.GridColumn column = ((DevExpress.XtraGrid.Views.Grid.GridView)sender).PressedColumn;

                    if (column != null)
                    {
                        if (column == gcRec_NameSample)
                        {
                            FormAssignMassive fmAssignMassive = new FormAssignMassive();

                            if (fmAssignMassive.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                // --- create samples
                                DataTable dt = gcReception.DataSource as DataTable;
                                if (fmAssignMassive.Flag_clear_and_add)
                                    dt.Rows.Clear();

                                for (int i = 0; i < fmAssignMassive.Num_samples; i++)
                                {
                                    DataRow dr = dt.NewRow();

                                    string num = (i + 1).ToString();
                                    string pattern = fmAssignMassive.GetPattern();
                                    string Name_sample = pattern.Replace("NUM", num.PadLeft(fmAssignMassive.Num_digits, '0'));
                                    dr["Name_sample"] = Name_sample;
                                    dr["Flag_reject"] = false;
                                    dr["Flag_counter_sample"] = false;
                                    dr["Amount_weight"] = 0.1;
                                    dr["Cod_type_sample"] = cbTypeSample.EditValue;

                                    dt.Rows.Add(dr);
                                }
                                gcReception.DataSource = dt;
                            }
                        }
                        if (column == gcRec_CantKg)
                        {
                            FormConfirmKg fmConfirmKlg = new FormConfirmKg();

                            if (fmConfirmKlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                for (int i = 0; i < gvReception.RowCount; i++)
                                {
                                    gvReception.SetRowCellValue(i, column, fmConfirmKlg.Amount);
                                    gvReception.UpdateCurrentRow();
                                }
                            }
                        }
                        if (column == gcRec_Reject)
                        {
                            if (column.ImageIndex == 9)
                            {
                                for (int i = 0; i < gvReception.RowCount; i++)
                                {
                                    gvReception.SetRowCellValue(i, column, true);
                                    gvReception.UpdateCurrentRow();
                                }
                                column.ImageIndex = 10;
                            }
                            else
                            {
                                for (int i = 0; i < gvReception.RowCount; i++)
                                {
                                    gvReception.SetRowCellValue(i, column, false);
                                    gvReception.UpdateCurrentRow();
                                }
                                column.ImageIndex = 9;
                            }
                        }
                        if (column == gcRec_Counter_Sample)
                        {
                            FormConfirmCounterSample fmConfirmCounterSample = new FormConfirmCounterSample();

                            if (fmConfirmCounterSample.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                for (int i = 0; i < gvReception.RowCount; i++)
                                {
                                    gvReception.SetRowCellValue(i, column, fmConfirmCounterSample.Amount);
                                    gvReception.UpdateCurrentRow();
                                }
                            }
                        }
                        if (column.Name.Contains("Dyn"))
                        {
                            CTagInfoMethod tagInfoMethod = null;
                            decimal TotalCostColumns = 0;
                            decimal TotalDaysColumns = 0;


                            if (column.ImageIndex == 9)
                            {
                                // --- assing check along clicked value and clear total cost and total days
                                for (int i = 0; i < gvReception.RowCount; i++)
                                {
                                    gvReception.SetRowCellValue(i, column, true);
                                    gvReception.SetRowCellValue(i, gcRec_Cost, TotalCostColumns);
                                    gvReception.SetRowCellValue(i, gcRec_Days, TotalDaysColumns);
                                    gvReception.UpdateCurrentRow();
                                }
                                // set values
                                for (int i = 0; i < gvReception.RowCount; i++)
                                {
                                    TotalCostColumns = 0;
                                    TotalDaysColumns = 0;

                                    foreach (KeyValuePair<DevExpress.XtraGrid.Columns.GridColumn, bool> kvp in DicShowColumns)
                                    {
                                        tagInfoMethod = (CTagInfoMethod)kvp.Key.Tag;

                                        if (kvp.Value)
                                        {
                                            if (Convert.ToBoolean(gvReception.GetRowCellValue(i, kvp.Key)))
                                            {
                                                TotalCostColumns += tagInfoMethod.Cost_Method;

                                                if (TotalDaysColumns < tagInfoMethod.Analysis_Time)
                                                    TotalDaysColumns = tagInfoMethod.Analysis_Time;

                                                //TotalDaysColumns += tagInfoMethod.Analysis_Time;

                                                gvReception.SetRowCellValue(i, gcRec_Cost, TotalCostColumns);
                                                gvReception.SetRowCellValue(i, gcRec_Days, TotalDaysColumns);
                                            }
                                        }
                                    }
                                }


                                GetAndAssignTotals();
                                column.ImageIndex = 10;
                            }
                            else
                            {
                                // --- assing check along clicked value and clear total cost and total days
                                for (int i = 0; i < gvReception.RowCount; i++)
                                {
                                    gvReception.SetRowCellValue(i, column, false);
                                    gvReception.SetRowCellValue(i, gcRec_Cost, TotalCostColumns);
                                    gvReception.SetRowCellValue(i, gcRec_Days, TotalDaysColumns);
                                    gvReception.UpdateCurrentRow();
                                }
                                // --- set values
                                for (int i = 0; i < gvReception.RowCount; i++)
                                {
                                    TotalCostColumns = 0;
                                    TotalDaysColumns = 0;

                                    foreach (KeyValuePair<DevExpress.XtraGrid.Columns.GridColumn, bool> kvp in DicShowColumns)
                                    {
                                        if (kvp.Value)
                                        {
                                            tagInfoMethod = (CTagInfoMethod)kvp.Key.Tag;

                                            if (Convert.ToBoolean(gvReception.GetRowCellValue(i, kvp.Key)))
                                            {
                                                TotalCostColumns += tagInfoMethod.Cost_Method;
                                                TotalDaysColumns += tagInfoMethod.Analysis_Time;
                                                gvReception.SetRowCellValue(i, gcRec_Cost, TotalCostColumns);
                                                gvReception.SetRowCellValue(i, gcRec_Days, TotalDaysColumns);
                                            }
                                        }
                                    }
                                }
                                GetAndAssignTotals();
                                column.ImageIndex = 9;
                            }
                        }
                    }
                }
            }
        }

        #endregion                                                   

        public void initDecretos()
        {
            List<CCriterio> lstCriterio = new List<CCriterio>();
            lstCriterio.Add(new CCriterio() { Idcriterio = 1, Nombre_criterio = "igual" });
            lstCriterio.Add(new CCriterio() { Idcriterio = 2, Nombre_criterio = "diferente" });
            lstCriterio.Add(new CCriterio() { Idcriterio = 3, Nombre_criterio = "menor" });
            lstCriterio.Add(new CCriterio() { Idcriterio = 4, Nombre_criterio = "mayor" });
            lstCriterio.Add(new CCriterio() { Idcriterio = 5, Nombre_criterio = "mayor o igual" });
            lstCriterio.Add(new CCriterio() { Idcriterio = 6, Nombre_criterio = "menor o igual" });
            lstCriterio.Add(new CCriterio() { Idcriterio = 7, Nombre_criterio = "Entre" });

            List<CUnidad_medida> lstUnidadMedida = new List<CUnidad_medida>();
            lstUnidadMedida.Add(new CUnidad_medida() { Nombre = "mg/L" });
            lstUnidadMedida.Add(new CUnidad_medida() { Nombre = "UCV escala pt Co" });
            lstUnidadMedida.Add(new CUnidad_medida() { Nombre = "uS/cm" });
            lstUnidadMedida.Add(new CUnidad_medida() { Nombre = "UNT" });
            lstUnidadMedida.Add(new CUnidad_medida() { Nombre = "NMP / 100 mL" });
            lstUnidadMedida.Add(new CUnidad_medida() { Nombre = "Presencia/100 mL" });

            List<CDecreto_detail_result> lstDecreto_detail_check = new List<CDecreto_detail_result>();
            lstDecreto_detail_check.Add(new CDecreto_detail_result() { Conclusion = "CUMPLE", Result = 0.10M, Criterio = 3, Parametro = "Plata - Ag", Unidad_medida = "mg/L", Valor1 = "0.01", Idmetodo = 1 });
            lstDecreto_detail_check.Add(new CDecreto_detail_result() { Conclusion = "CUMPLE", Result = 0.10M, Criterio = 7, Parametro = "Ph", Unidad_medida = "mg/L", Valor1 = "6.5", Valor2 = "8.5", Idmetodo = 6 });
            lstDecreto_detail_check.Add(new CDecreto_detail_result() { Conclusion = "CUMPLE", Result = 0.10M, Criterio = 5, Parametro = "Oxigeno Disuelto", Unidad_medida = "mg/L", Valor1 = "6", Idmetodo = 7 });
            lstDecreto_detail_check.Add(new CDecreto_detail_result() { Conclusion = "CUMPLE", Result = 0.10M, Criterio = 1, Parametro = "Olor ", Valor1 = "Aceptable", Idmetodo = 8 });
            lstDecreto_detail_check.Add(new CDecreto_detail_result() { Conclusion = "CUMPLE", Result = 0.10M, Criterio = 1, Parametro = "Salmonella sp.", Unidad_medida = "NMP / 100 mL", Valor1 = "Ausencia", Idmetodo = 9 });

            List<CMetodoDecreto> lstMetodoDecreto = new List<CMetodoDecreto>();
            lstMetodoDecreto.Add(new CMetodoDecreto() { Idmetodo = 1, Nombre = "802 - Ag" });
            lstMetodoDecreto.Add(new CMetodoDecreto() { Idmetodo = 2, Nombre = "802 - Al" });
            lstMetodoDecreto.Add(new CMetodoDecreto() { Idmetodo = 3, Nombre = "802 - Arsenico" });
            lstMetodoDecreto.Add(new CMetodoDecreto() { Idmetodo = 4, Nombre = "802 - Ba" });
            lstMetodoDecreto.Add(new CMetodoDecreto() { Idmetodo = 5, Nombre = "802 - B" });
            lstMetodoDecreto.Add(new CMetodoDecreto() { Idmetodo = 6, Nombre = "808 - pH" });
            lstMetodoDecreto.Add(new CMetodoDecreto() { Idmetodo = 7, Nombre = "841 - Oxigeno" });
            lstMetodoDecreto.Add(new CMetodoDecreto() { Idmetodo = 8, Nombre = "804 - Olor" });
            lstMetodoDecreto.Add(new CMetodoDecreto() { Idmetodo = 9, Nombre = "878 - Salmonela" });

            List<CDecreto> lstDecreto = new List<CDecreto>();
            lstDecreto.Add(new CDecreto() { Codigo = "DEC-13-001", Denominacion = "NTP N° 214.003", Descripcion = "" });
            lstDecreto.Add(new CDecreto() { Codigo = "DEC-13-002", Denominacion = "D.S. N° 031-2010", Descripcion = "" });
            lstDecreto.Add(new CDecreto() { Codigo = "DEC-13-003", Denominacion = "D.S. N° 002-2008-ECA A1", Descripcion = "" });
            lstDecreto.Add(new CDecreto() { Codigo = "DEC-13-004", Denominacion = "D.S. N° 002-2008-ECA A2", Descripcion = "" });
            lstDecreto.Add(new CDecreto() { Codigo = "DEC-13-005", Denominacion = "D.S. N° 002-2008-ECA Vegetales", Descripcion = "" });

            repUnidadMedida.DataSource = lstUnidadMedida;
            repUnidadMedida.DisplayMember = "Nombre";
            repUnidadMedida.ValueMember = "Nombre";

            repCriterio.DataSource = lstCriterio;
            repCriterio.DisplayMember = "Nombre_criterio";
            repCriterio.ValueMember = "Idcriterio";

            repMetodo.DataSource = lstMetodoDecreto;
            repMetodo.DisplayMember = "Nombre";
            repMetodo.ValueMember = "Idmetodo";

            gridDecretos.DataSource = new BindingList<CDecreto_detail_result>(lstDecreto_detail_check);

        }


    }

    #region clases

    public class CpositionValueAttach
    {
        public int idtemplate_method { get; set; }
        public long idrecep_sample_detail_elem { get; set; }
        public long idrecep_sample_detail { get; set; }
        public long idrecep_sample_attach { get; set; }
        public long idcell_attach_file { get; set; }
        public Color color { get; set; }
        public int row { get; set; }
        public DevExpress.XtraGrid.Columns.GridColumn col { get; set; }
    }

    public class CPositionValue
    {
        public int idtemplate_method { get; set; }
        public long idrecep_sample_detail_elem { get; set; }
        public long idrecep_sample_detail { get; set; }
        public long idrecep_sample_report { get; set; }
        public long idcell_reported { get; set; }
        public Color color { get; set; }
        public int row { get; set; }        
        public DevExpress.XtraGrid.Columns.GridColumn col { get; set; }
        public bool flag_confirm_report { get; set; }
    }

    public class CPositionValueProgram
    {
        public int idtemplate_method { get; set; }
        public long idrecep_sample_detail_elem { get; set; }
        public long idrecep_sample_detail { get; set; }
        public long idrecep_sample_program { get; set; }
        public long idcell_program { get; set; }
        public Color color { get; set; }
        public int row { get; set; }
        public DevExpress.XtraGrid.Columns.GridColumn col { get; set; }
    }

    #endregion
}
