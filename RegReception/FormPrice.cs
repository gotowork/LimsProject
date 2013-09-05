using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LimsProject.BusinessLayer;
using LimsProject.BusinessLayer.Modules;
using LibraryBasicForm;
using System.IO;
using System.Diagnostics;
using System.Collections;

namespace LimsProject
{
    public partial class FormPrice : LibraryBasicForm.FormBaseEmpty
    {
        public enum LoadData
        {
            Nothing,            // solo se ha aperturado el módulo            
            MasterSearchPrice,  // cuando se cargan datos desde un buscador en el registro de cotización            
            FromPrice_ToPrice,    // cuando se cargan datos desde una cotización a nueva versión de cotización                          
            FromPrice_ToNewVersion
        }

        LoadData loadData = LoadData.Nothing;
        CPrice oPrice = null;
        CPrice_version oPrice_version = null;
        BindingList<CPrice_version_detail> LstPrice_version_detail = null;

        DataTable dtPrice_version_detail = new DataTable();
        DataTable dtHistoryPrice = new DataTable();                

        DataTable dtParams = new DataTable();

        LibraryBasicForm.CFastReportMethods freport = new LibraryBasicForm.CFastReportMethods();

        CSettings oSettings = new CSettings();

        DevExpress.XtraGrid.Views.Grid.GridView grid_view = new DevExpress.XtraGrid.Views.Grid.GridView();

        double totalAmount = 0;        

        public FormPrice()
        {
            InitializeComponent();

            Init();
        }

        public FormPrice(CPrice_version pPrice_version, LoadData pLoadData)
        {
            InitializeComponent();

            Init();

            oPrice_version = pPrice_version;
            loadData = pLoadData;

            if (pPrice_version != null)
                oPrice = new CPriceFactory().GetByPrimaryKey(new CPriceKeys(Convert.ToInt32(oPrice_version.Idprice)));

            Recuperar_Registro();

            ShowStatusControl();
        }

        private void ucCopyTo_onSelectedIndex(int index)
        {
            if (index == 0)
            {
                // nueva versión
                FormPrice fmPrice = new FormPrice(oPrice_version, LoadData.FromPrice_ToNewVersion);
                fmPrice.ShowDialog();
            }
            else if (index == 1)
            {
                // nueva cotización
                FormPrice fmPrice = new FormPrice(oPrice_version, LoadData.FromPrice_ToPrice);
                fmPrice.ShowDialog();
            }
        }

        void Init()
        {
            InitTables();
            InitAppareance();
            InitDataControls();            
        }        

        void InitTables()
        {
            dtParams.Columns.Add(new DataColumn("Saludo"));
            dtParams.Columns.Add(new DataColumn("Despedida"));
            dtParams.Columns.Add(new DataColumn("Cod_cotizacion"));
            dtParams.Columns.Add(new DataColumn("Empresa"));
            dtParams.Columns.Add(new DataColumn("Atencion"));
            dtParams.Columns.Add(new DataColumn("Total_sin_igv"));
            dtParams.Columns.Add(new DataColumn("Igv"));
            dtParams.Columns.Add(new DataColumn("Total"));

            DataRow dr = dtParams.NewRow();

            dr["Saludo"] = "";
            dr["Despedida"] = "";
            dr["Cod_cotizacion"] = "";
            dr["Atencion"] = "";
            dr["Total_sin_igv"] = "";
            dr["Igv"] = "";
            dr["Total"] = "";

            dtParams.Rows.Add(dr);
        }

        void InitAppareance()
        {
            //botones
            ucCopyTo.InitItems(new List<string> { "Nueva versión", "Nueva cotización" });            
        }

        void InitDataControls()
        {
            deDateCreation.DateTime = Comun.GetDate();
            tbNumDaysValid.Value = new CSettings().GetNumDaysPriceDefault();

            // --- init company
            cbCompany.Properties.DataSource = new CCompanyFactory().GetAll();
            cbCompany.Properties.DisplayMember = "Business_name";
            cbCompany.Properties.ValueMember = "Idcompany";

            // --- init type sample combo
            CType_sampleFactory faType_Sample = new CType_sampleFactory();
            cbTypeSample.Properties.DataSource = faType_Sample.GetAll();
            cbTypeSample.Properties.ValueMember = "Cod_type_sample";
            cbTypeSample.Properties.DisplayMember = "Name_type_sample";
            
            Reception oReception = new Reception();

            // --- init type person
            repPerson_type.DataSource = oReception.GetLstPersonType();
            repPerson_type.DisplayMember = "Name";
            repPerson_type.ValueMember = "Id";             

            // --- init methods
            gcPrice.DataSource = new BindingList<PriceMethod>(new ModPrice().GetPriceMethod(null));

            // --- init plantillas
            CMemo_templateFactory faMemo_template = new CMemo_templateFactory();
            gcParagraphHistoryIni.DataSource = faMemo_template.GetAll().Where(c => c.Memo_type == 1).ToList();

            gcParagraphHistoryEnd.DataSource = faMemo_template.GetAll().Where(c => c.Memo_type == 2).ToList();

            // --- init adjuntos
            List<Anexos> list = new ModPrice().GetLstAnexos(null);
            gcAnexos.DataSource = new BindingList<Anexos>(list);
        }

        void ShowStatusControl()
        {
            if (loadData == LoadData.MasterSearchPrice)
            {                
                SetReadOnly(true);
            }
            else if (loadData == LoadData.FromPrice_ToNewVersion)
            {
                tbNumVersion.Text = "";

                SetReadOnly(false);
            }
            else if (loadData == LoadData.FromPrice_ToPrice)
            {
                SetReadOnly(false);
            }
            else if (loadData == LoadData.Nothing)
            {
                SetReadOnly(false);
            }
        }

        void SetReadOnly(bool flag)
        {
            ucSign1.Enabled = !flag;
            cbTypeSample.Properties.ReadOnly = flag;
            cbCompany.Properties.ReadOnly = flag;
            tbClientDomicile.Properties.ReadOnly = flag;
            tbClientPhone.Properties.ReadOnly = flag;
            tbClientRuc.Properties.ReadOnly = flag;
            tbFax.Properties.ReadOnly = flag;

            ckDispatchCurier.Properties.ReadOnly = flag;
            ckDispatchFax.Properties.ReadOnly = flag;
            ckDispatchPerson.Properties.ReadOnly = flag;
            ckDispatchTransport.Properties.ReadOnly = flag;
            ckSaveHistoryEnd.Properties.ReadOnly = flag;
            ckSaveHistoryIni.Properties.ReadOnly = flag;
            tbObservation.Properties.ReadOnly = flag;
            
            gvContact.OptionsBehavior.Editable = !flag;
            gcContact.EmbeddedNavigator.Enabled = !flag;

            repText.ReadOnly = flag;
            repOpenFile.ReadOnly = flag;
            repOpenFile.Buttons[0].Enabled = !flag;

            gcolHis_Cod_price.OptionsColumn.AllowEdit = false;
            gcolHis_Date_creation.OptionsColumn.AllowEdit = false;
            gcolHis_Num_version.OptionsColumn.AllowEdit = false;
            gcolHis_Unit_price.OptionsColumn.AllowEdit = false;
            gcolHis_Amount_item.OptionsColumn.AllowEdit = false;

            gcAnexos.EmbeddedNavigator.Enabled = !flag;
            
            tbNumDaysValid.Properties.ReadOnly = flag;
            gvPrice.OptionsBehavior.Editable = !flag;
            gcPrice.EmbeddedNavigator.Enabled = !flag;

            cbMethodAdd.Properties.ReadOnly = flag;
        }

        protected override bool Son_Datos_Correctos()
        {
            if (cbTypeSample.EditValue == null)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "No se especificó ningún tipo de muestra.");
                return false;
            }
            if (LstPrice_version_detail.Count == 0)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "No se agregó ningún item.");
                return false;
            }
            if (tbNumDaysValid.Value == 0)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "No se especificó el número de días de validez.");
                return false;
            }
            if (dtParams.Rows[0]["Saludo"].ToString().Trim().Length == 0)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "No se especificó el párrafo inicial en el documento.");
                return false;
            }
            if (dtParams.Rows[0]["Despedida"].ToString().Trim().Length == 0)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "No se especificó el párrafo final en el documento.");
                return false;
            }
            if (dtParams.Rows[0]["Empresa"].ToString().Trim().Length == 0
                || dtParams.Rows[0]["Atencion"].ToString().Trim().Length == 0)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "No se especificó la empresa o atención en el documento.");
                return false;
            }
            if (AreContactRight())
            {
                Comun.Send_message(this.Text, TypeMsg.error, "No se permite agregar más de un contacto de atención.");
                return false;
            }
            return true;
        }

        bool AreContactRight()
        {
            int sumAtencion = 0;

            for (int i = 0; i < gvContact.RowCount; i++)
            { 
                if (Convert.ToInt32(gvContact.GetRowCellValue(i, gcCon_Person_type)) == 3)
                    sumAtencion++;
            }
            if (sumAtencion > 1)
                return false;
            return true;
        }

        protected override void Limpiar_Campos()
        {
            oPrice = null;
            oPrice_version = null;
            LstPrice_version_detail = null;
            totalAmount = 0;

            cbTypeSample.EditValue = null;
            cbCompany.EditValue = null;
            deDateCreation.DateTime = Comun.GetDate();
            tbNumDaysValid.Value = new CSettings().GetNumDaysPriceDefault();

            tbClientDomicile.Text = "";
            tbClientPhone.Text = "";
            tbClientRuc.Text = "";
            tabHead.Text = "Datos";
            tbCodPrice.Text = "";
            tbNumVersion.Text = "";
            ckDispatchCurier.Checked = false;
            ckDispatchFax.Checked = false;
            ckDispatchPerson.Checked = false;
            ckDispatchTransport.Checked = false;
            ckSaveHistoryEnd.Checked = false;
            ckSaveHistoryIni.Checked = false;
            tbObservation.Text = "";

            tbSubTotalAmount.Value = 0;
            tbTotalAmount.Value = 0;
            tbTotalIgv.Value = 0;

            gcPrice.DataSource = new BindingList<PriceMethod>(new ModPrice().GetPriceMethod(null));
            gcContact.DataSource = null;            

            richTextIni.RichTextBox.Clear();
            richTextEnd.RichTextBox.Clear();

            gcAnexos.DataSource = new BindingList<Anexos>(new ModPrice().GetLstAnexos(null));

            previewControl1.Clear();

            loadData = LoadData.Nothing;

            ShowStatusControl();
        }

        protected override bool Grabar_Registro()
        {
            // --- save company
            bool result_company = false;

            CCompany oCompany = new CCompany();

            if (cbCompany.EditValue != null)
            {
                CCorr_modulesFactory faCorr_modules = new CCorr_modulesFactory();
                CCompanyFactory faCompany = new CCompanyFactory();

                oCompany.Idcompany = Convert.ToInt16(cbCompany.EditValue);
                //oCompany.Cod_company =  faCorr_modules.GetCorrModule(Comun.Formulario.fmEmpresa.ToString());
                oCompany.Ruc = tbClientRuc.Text;
                oCompany.Business_name = cbCompany.Text;
                oCompany.Domicile = tbClientDomicile.Text;
                oCompany.Type_company = 'C'; // --- client
                oCompany.Phone_client = tbClientPhone.Text;

                if (!(result_company = faCompany.Update(oCompany)))
                    result_company = faCompany.Insert(oCompany);
            }

            bool result_price = false;
            if (oPrice == null)
                oPrice = new CPrice();

            CPriceFactory faPrice = new CPriceFactory();
            if (!(loadData == LoadData.FromPrice_ToNewVersion))
                oPrice.Cod_price = new ModCorrelatives().GetCorrelative(ModCorrelatives.Correlative.Price);

            // --- person
            if (ckDispatchPerson.Checked)
                oPrice.Dispatch_person = 1;
            else
                oPrice.Dispatch_person = 0;
            // --- curier
            if (ckDispatchCurier.Checked)
                oPrice.Dispatch_curier = 1;
            else
                oPrice.Dispatch_curier = 0;
            // --- transport
            if (ckDispatchTransport.Checked)
                oPrice.Dispatch_transport = 1;
            else
                oPrice.Dispatch_transport = 0;
            // --- fax
            if (ckDispatchFax.Checked)
                oPrice.Dispatch_fax = 1;
            else
                oPrice.Dispatch_fax = 0;

            if (!(result_price = faPrice.Update(oPrice)))
                result_price = faPrice.Insert(oPrice);

            // --- save contacts
            CPerson oContact = new CPerson();
            CPersonFactory faPerson = new CPersonFactory();
            CPrice_company_person oPrice_company_person = new CPrice_company_person();
            CPrice_company_personFactory faPrice_company_person = new CPrice_company_personFactory();           
            
            // --- delete all
            if (result_price)
            {
                oPrice_version = new CPrice_version();
                CPrice_versionFactory faPrice_version = new CPrice_versionFactory();

                oPrice_version.Idprice = oPrice.Idprice;
                
                oPrice_version.Idcompany = null;
                if (cbCompany.EditValue != null)
                    oPrice_version.Idcompany = Convert.ToInt16(cbCompany.EditValue);                

                oPrice_version.Cod_type_sample = cbTypeSample.EditValue.ToString();
                oPrice_version.Num_version = new ModPrice().GetNextNumVersion(oPrice.Idprice);
                oPrice_version.Date_creation = deDateCreation.DateTime;
                oPrice_version.Num_days_valid = Convert.ToInt16(tbNumDaysValid.Value);

                oPrice_version.Observation = tbObservation.Text;
                
                oPrice_version.Iduser = Comun.User_system.Iduser;
                oPrice_version.Status_price = 1;

                bool result_price_version = false;
                if (!(result_price_version = faPrice_version.Update(oPrice_version)))
                    result_price_version = faPrice_version.Insert(oPrice_version);                

                if (result_price_version)
                {
                    //guardar párrafos iniciales
                    CMemo_price oMemoPrice;
                    CMemo_priceFactory faMemo_price = new CMemo_priceFactory();

                    //guardando el parrafo inicial
                    oMemoPrice = new CMemo_price();
                    oMemoPrice.Idprice_version = oPrice_version.Idprice_version;
                    oMemoPrice.Paragraph = richTextIni.RichTextBox.Rtf;
                    oMemoPrice.Memo_type = 1;
                    faMemo_price.Insert(oMemoPrice);

                    //guardando el parrafo final
                    oMemoPrice = new CMemo_price();
                    oMemoPrice.Idprice_version = oPrice_version.Idprice_version;
                    oMemoPrice.Paragraph = richTextEnd.RichTextBox.Rtf;
                    oMemoPrice.Memo_type = 2;
                    faMemo_price.Insert(oMemoPrice);

                    if (ckSaveHistoryIni.Checked)
                    {
                        CMemo_template oMemo_template = new CMemo_template();
                        CMemo_templateFactory faMemo_template = new CMemo_templateFactory();

                        oMemo_template.Paragraph = richTextIni.RichTextBox.Text;
                        oMemo_template.Paragraph_rtf = richTextIni.RichTextBox.Rtf.ToString();
                        oMemo_template.Memo_type = 1;
                        faMemo_template.Insert(oMemo_template);
                    }

                    //guardar párrafos finales
                    if (ckSaveHistoryEnd.Checked)
                    {
                        CMemo_template oMemo_template = new CMemo_template();
                        CMemo_templateFactory faMemo_template = new CMemo_templateFactory();

                        oMemo_template.Paragraph_rtf = richTextEnd.RichTextBox.Rtf;
                        oMemo_template.Paragraph = richTextEnd.RichTextBox.Text.ToString();
                        oMemo_template.Memo_type = 2;
                        faMemo_template.Insert(oMemo_template);
                    }
                }
                
                if (result_price)
                {                    
                    CCompany_person oCompany_person = new CCompany_person();
                    CCompany_personFactory faCompany_person = new CCompany_personFactory();

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
                            oPrice_company_person = new CPrice_company_person();

                            oPrice_company_person.Idprice_company_person = 0;
                            oPrice_company_person.Idcompany = oCompany.Idcompany;
                            oPrice_company_person.Idprice = oPrice.Idprice;
                            oPrice_company_person.Idperson = oContact.Idperson;
                            oPrice_company_person.Idprice_version = oPrice_version.Idprice_version;
                            oPrice_company_person.Person_type = Convert.ToInt16(gvContact.GetRowCellValue(i, gcCon_Person_type));

                            if (!faPrice_company_person.Update(oPrice_company_person))
                                faPrice_company_person.Insert(oPrice_company_person);
                        }

                        // --- save history company person           
                        if (!faCompany_person.GetAll().Exists(c => c.Idcompany == oCompany.Idcompany && c.Idperson == oContact.Idperson))
                        {
                            oCompany_person = new CCompany_person();
                            oCompany_person.Idcompany = oCompany.Idcompany;
                            oCompany_person.Idperson = oContact.Idperson;

                            if (!faCompany_person.Update(oCompany_person))
                                faCompany_person.Insert(oCompany_person);
                        }
                    }
                }

                if (result_price_version)
                {
                    // guardar detalle
                    CPrice_version_detail oPrice_version_detail = new CPrice_version_detail();
                    CPrice_version_detailFactory faPrice_version_detail = new CPrice_version_detailFactory();

                    for (int i = 0; i < gvPrice.RowCount; i++)
                    {
                        oPrice_version_detail = new CPrice_version_detail();
                        oPrice_version_detail.Idprice_version = oPrice_version.Idprice_version;
                        oPrice_version_detail.Idtemplate_method = Convert.ToInt32(gvPrice.GetRowCellValue(i, gcolItem_Idtemplate_method));
                        oPrice_version_detail.Num_item = Convert.ToInt32(gvPrice.GetRowCellValue(i, gcolItem_Num_item));
                        oPrice_version_detail.Amount_item = Convert.ToInt32(gvPrice.GetRowCellValue(i, gcolItem_Amount_item));
                        oPrice_version_detail.Sale_price = Convert.ToDecimal(gvPrice.GetRowCellValue(i, gcolItem_Sale_price));
                        oPrice_version_detail.Unit_price = Convert.ToDecimal(gvPrice.GetRowCellValue(i, gcolItem_Unit_price));

                        if (!faPrice_version_detail.Update(oPrice_version_detail))
                            faPrice_version_detail.Insert(oPrice_version_detail);
                    }
                }

                if (result_price_version)
                {
                    if (gvAnexos.RowCount > 0)
                    {
                        // guardar adjuntos 
                        ListCopy lstCopySave = new ListCopy();

                        List<Anexos> lstAnexos = (gcAnexos.DataSource as BindingList<Anexos>).ToList();

                        if (lstAnexos != null && lstAnexos.Count > 0)
                        {
                            foreach (Anexos item in lstAnexos)
                            {
                                if (item.Source_filename.Trim().Length > 0)
                                {
                                    string destiny_directory = oSettings.GetPathAttachPrice();

                                    lstCopySave.Add(
                                        new CItemCopy()
                                        {
                                            Filename = item.Filename,
                                            Source_file = item.Source_filename,
                                            Destiny_directory = destiny_directory
                                        });
                                }
                            }

                            lstCopySave.Save(oPrice, oPrice_version);
                        }
                    }
                }
            }
            
            return true;
        }

        protected override void Recuperar_Registro()
        {
            if (oPrice != null && oPrice_version != null)
            {
                tabHead.Text = oPrice.Cod_price;
                tbCodPrice.Text = oPrice.Cod_price;
                tbNumVersion.Text = oPrice_version.Num_version.ToString();
                cbTypeSample.EditValue = oPrice_version.Cod_type_sample;
                cbCompany.EditValue = oPrice_version.Idcompany;
                deDateCreation.EditValue = oPrice_version.Date_creation;
                tbNumDaysValid.Value = Convert.ToInt32(oPrice_version.Num_days_valid);
                tbObservation.Text = oPrice_version.Observation;

                // --- person
                if (oPrice.Dispatch_person > 0)
                    ckDispatchPerson.Checked = true;
                else
                    ckDispatchPerson.Checked = false;
                // --- curier
                if (oPrice.Dispatch_curier > 0)
                    ckDispatchCurier.Checked = true;
                else
                    ckDispatchCurier.Checked = false;
                // --- transport
                if (oPrice.Dispatch_transport > 0)
                    ckDispatchTransport.Checked = true;
                else
                    ckDispatchTransport.Checked = false;
                // --- fax
                if (oPrice.Dispatch_fax > 0)
                    ckDispatchFax.Checked = true;
                else
                    ckDispatchFax.Checked = false;

                // --- get contacts
                gcContact.DataSource = new BindingList<CContact_price>(new ModPrice().GetLstContactsByPrice(oPrice.Idprice, oPrice_version.Idprice_version));
                
                // --- recuperando métodos                                
                List<PriceMethod> myLstPriceMethod = new ModPrice().GetPriceMethod(oPrice_version);                
                
                gcPrice.DataSource = new BindingList<PriceMethod>(myLstPriceMethod);

                // --- recuperando parrafos
                var lstmemo =
                    (from m in new CMemo_priceFactory().GetAll()
                     where m.Idprice_version == oPrice_version.Idprice_version
                     select new
                     {
                         m.Paragraph,
                         m.Memo_type
                     }).ToList();

                foreach (var item in lstmemo)
                {
                    if (item.Memo_type == 1)
                        richTextIni.RichTextBox.Rtf = item.Paragraph;
                    else if (item.Memo_type == 2)
                        richTextEnd.RichTextBox.Rtf = item.Paragraph;
                }

                // --- recuperar memo template
                var lsttemplate_memo = new CMemo_templateFactory().GetAll();

                gcParagraphHistoryIni.DataSource = lsttemplate_memo.Where(c => c.Memo_type == 1).ToList();

                gcParagraphHistoryEnd.DataSource = lsttemplate_memo.Where(c => c.Memo_type == 2).ToList();

                // --- recalcular tamaño de celdas de texto amplio
                gvPrice.OptionsView.RowAutoHeight = true;
                gvPrice.LayoutChanged();

                gvParagraphHistoryIni.OptionsView.RowAutoHeight = true;
                gvParagraphHistoryIni.LayoutChanged();

                gvParagraphHistoryEnd.OptionsView.RowAutoHeight = true;
                gvParagraphHistoryEnd.LayoutChanged();

                // --- recuperar suma totales
                SumTotals();

                // --- recuperar reporte de cotización
                ShowPreviewReport();

                // --- recuperar archivos adjuntos
                gcAnexos.DataSource = new BindingList<Anexos>(new ModPrice().GetLstAnexos(oPrice_version));
            }
            else
            {
                ckDispatchPerson.Checked = false;
                ckDispatchCurier.Checked = true;
                ckDispatchTransport.Checked = false;
                ckDispatchFax.Checked = false;
            }
        }

        private void tbNumDaysValid_EditValueChanged(object sender, EventArgs e)
        {
            deDateExpiration.DateTime = deDateCreation.DateTime.AddDays(Convert.ToInt32(tbNumDaysValid.Value));
        }   

        void SumTotals()
        {            
            double SubTotal = 0;
            double Igv = 0;
            double Total = 0;
            
            for (int i = 0; i < gvPrice.RowCount; i++)            
                SubTotal = SubTotal + Convert.ToDouble(gvPrice.GetRowCellValue(i, gcolItem_Sale_price));            
            
            Igv = SubTotal * 0.18;
            Total = SubTotal + Igv;            

            // --- assign to texbox
            tbSubTotalAmount.Text = Math.Round(SubTotal, 2).ToString();
            tbTotalIgv.Text = Math.Round(Igv, 2).ToString();
            tbTotalAmount.Text = Math.Round(Total, 2).ToString();                        
        }

        private void cbTypeSample_EditValueChanged(object sender, EventArgs e)
        {
            // --- init methods
            if (cbTypeSample.EditValue != null)
            {
                Reception oReception = new Reception();

                var query =
                    (from m in oReception.GetMethodsDenominations(cbTypeSample.EditValue.ToString())
                     select new
                     {
                         Idtemplate_method = Convert.ToInt32(m.Idtemplate_method),
                         Title = m.Cod_template_method + " - " + m.Abbreviation + " - " + m.Title
                     }).ToList();

                cbMethodAdd.Properties.DataSource = query;
                cbMethodAdd.Properties.DisplayMember = "Title";
                cbMethodAdd.Properties.ValueMember = "Idtemplate_method";                

                if (cbTypeSample.EditValue != null)
                    tabItems.PageVisible = true;
            }
        }

        private void gvPrice_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Value != null)
            {                
                if (e.Column == gcolItem_Amount_item)
                {                    
                    decimal unit_price = Convert.ToDecimal(gvPrice.GetFocusedRowCellValue(gcolItem_Unit_price));
                    int amount_item = Convert.ToInt32(gvPrice.GetFocusedRowCellValue(gcolItem_Amount_item));

                    gvPrice.SetFocusedRowCellValue(gcolItem_Sale_price, unit_price * amount_item);

                    SumTotals();

                    ShowPreviewReport();
                }
                else if (e.Column == gcolItem_Unit_price)
                {
                    decimal unit_price = Convert.ToDecimal(gvPrice.GetFocusedRowCellValue(gcolItem_Unit_price));
                    int amount_item = Convert.ToInt32(gvPrice.GetFocusedRowCellValue(gcolItem_Amount_item));

                    gvPrice.SetFocusedRowCellValue(gcolItem_Sale_price, unit_price * amount_item);

                    SumTotals();

                    ShowPreviewReport();
                }
            }
        }

        private string GetAttention()
        {
            for (int i = 0; i < gvContact.RowCount; i++)
            {
                if (Convert.ToInt32(gvContact.GetRowCellValue(i, gcCon_Person_type)) == 3)
                    return gvContact.GetRowCellValue(i, gcCon_Allname).ToString();
            }
            return "";
        }

        private void OpenDesignReport()
        {
            DataTable dtMethodsPrice = new ModPrice().getDTPriceMethod(gvPrice.DataSource as List<PriceMethod>);

            if (dtMethodsPrice == null)
                dtMethodsPrice = new ModPrice().getDTPriceMethod(null);

            if (dtMethodsPrice != null)
            {
                dtParams.Rows[0]["Cod_cotizacion"] = tbCodPrice.Text;
                dtParams.Rows[0]["Empresa"] = cbCompany.Text;
                dtParams.Rows[0]["Atencion"] = GetAttention();
                dtParams.Rows[0]["Total_sin_igv"] = tbSubTotalAmount.Text;
                dtParams.Rows[0]["Igv"] = tbTotalIgv.Text;
                dtParams.Rows[0]["Total"] = tbTotalAmount.Text;

                freport.ReportName = "ReportPrice.frx";

                freport.RegisterDataTable(dtParams, "Parametros");
                freport.RegisterDataTable(dtMethodsPrice, "MethodsPrice");

                freport.DesignReport();
            }
        }

        private void ShowPreviewReport()
        {
            BindingList<PriceMethod> lst = gvPrice.DataSource as BindingList<PriceMethod>;

            DataTable dtMethodsPrice = new ModPrice().getDTPriceMethod(lst.ToList());

            if (dtMethodsPrice == null)
                dtMethodsPrice = new ModPrice().getDTPriceMethod(null);

            if (dtMethodsPrice != null)
            {
                dtParams.Rows[0]["Cod_cotizacion"] = tbCodPrice.Text;
                dtParams.Rows[0]["Empresa"] = cbCompany.Text;
                dtParams.Rows[0]["Atencion"] = GetAttention();
                dtParams.Rows[0]["Saludo"] = richTextIni.RichTextBox.Rtf;
                dtParams.Rows[0]["Despedida"] = richTextEnd.RichTextBox.Rtf;
                dtParams.Rows[0]["Total_sin_igv"] = tbSubTotalAmount.Text;
                dtParams.Rows[0]["Igv"] = tbTotalIgv.Text;
                dtParams.Rows[0]["Total"] = tbTotalAmount.Text;

                freport.ReportName = "ReportPrice.frx";

                freport.RegisterDataTable(dtParams, "Parametros");
                freport.RegisterDataTable(dtMethodsPrice, "MethodsPrice");

                freport.ShowReport(previewControl1);
            }
        }

        private void btDesign_Click(object sender, EventArgs e)
        {                                    
            OpenDesignReport();
        }

        private void btRefreshParagraphIni_Click(object sender, EventArgs e)
        {            
            ShowPreviewReport();            
        }

        private void gvParagraphHistoryIni_DoubleClick(object sender, EventArgs e)
        {
            if (gvParagraphHistoryIni.RowCount > 0)
                richTextIni.RichTextBox.Rtf = gvParagraphHistoryIni.GetFocusedRowCellValue(gcolphi_Paragraph_rtf).ToString(); 
        }

        private void gvParagraphHistoryEnd_DoubleClick(object sender, EventArgs e)
        {
            if (gvParagraphHistoryEnd.RowCount > 0)
                richTextEnd.RichTextBox.Rtf = gvParagraphHistoryEnd.GetFocusedRowCellValue(gcolPhe_Paragraph_rtf).ToString(); 
        }

        private void gvPrice_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //ShowPreviewReport();
        }

        private void repAmount_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (gvPrice.GetFocusedRowCellDisplayText(gcolItem_Idtemplate_method).Trim().Length == 0)
                e.Cancel = true;
        }

        private void ucSign1_OnSign(bool login)
        {
            if (login)
            {
                Grabar_Registro();
                ucSign1.Clear();

                FormMessage fmMessage = new FormMessage();
                fmMessage.Title = "Guardado correctamente";
                fmMessage.ShowDialog();

                loadData = LoadData.MasterSearchPrice;

                Recuperar_Registro();

                ShowStatusControl();
            }
            else
            {
                ucSign1.Clear();
            }
        }

        private void ucToolButtons_onFind()
        {
            // --- 
            FormMasterSearch fmBusqueda = new FormMasterSearch();
            UcFilterPrice filter = new UcFilterPrice();
            filter.onSearch += delegate(ModMasterSearch.KeyFilterPrice key)
            {
                fmBusqueda.BindGrid(new ModMasterSearch().GetPrices(key));
            };

            fmBusqueda.BindGrid(filter, filter.Size, new ModMasterSearch().GetPrices(filter.keyDefault));
            fmBusqueda.ShowDialog();

            Dictionary<string, string> keys = fmBusqueda.getKeyValues();

            if (keys != null)
            {
                Limpiar_Campos();

                loadData = LoadData.MasterSearchPrice;

                /// recuperar cotización seleccionada
                oPrice_version =
                    new CPrice_versionFactory()
                    .GetByPrimaryKey(new CPrice_versionKeys(Convert.ToInt32(keys["Idprice_version"])));

                oPrice =
                    new CPriceFactory()
                    .GetByPrimaryKey(new CPriceKeys(Convert.ToInt32(oPrice_version.Idprice)));

                Recuperar_Registro();

                ShowStatusControl();
            }
        }

        private void cbCompany_EditValueChanged(object sender, EventArgs e)
        {
            RetrieveDataCompany();
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
                    ModPrice oModPrice = new ModPrice();
                    gcContact.DataSource = new BindingList<CContact_price>(oModPrice.GetLstContactsByCompany(oCompany.Idcompany));
                }
            }
        }

        private void cbCompany_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
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

        private void gvContact_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            BindingList<CContact_price> lst = gcContact.DataSource as BindingList<CContact_price>;            

            if (lst.ToList().Count(c=> c.Person_type == 3) >= 1)
                gvContact.SetRowCellValue(e.RowHandle, gcCon_Person_type, 1); // atención
            else
                gvContact.SetRowCellValue(e.RowHandle, gcCon_Person_type, 3);
            
            gvContact.SetRowCellValue(e.RowHandle, gcCon_Allname, "");
            gvContact.SetRowCellValue(e.RowHandle, gcCon_Mail, "");
            gvContact.SetRowCellValue(e.RowHandle, gcCon_Phone, "");
            gvContact.SetRowCellValue(e.RowHandle, gcCon_Cellphone, "");

            if (cbCompany.EditValue != null)
                gvContact.SetRowCellValue(e.RowHandle, gcCon_Idcompany, Convert.ToInt16(cbCompany.EditValue));
        }

        private void ucToolButtons_onNew()
        {
            Limpiar_Campos();
        }

        private void repBuOpenPrice_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // abrir cotización
            int idprice_version = Convert.ToInt32(grid_view.GetFocusedRowCellValue(gcolHis_Idprice_version));             
            CPrice_version price_version = new CPrice_versionFactory().GetByPrimaryKey(new CPrice_versionKeys(idprice_version));
            FormPrice fmPrice = new FormPrice(price_version, LoadData.MasterSearchPrice);
            fmPrice.Show();
        }        

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cbCompany.EditValue != null && cbMethodAdd.EditValue != null)
            {
                BindingList<PriceMethod> lst = gcPrice.DataSource as BindingList<PriceMethod>;
                List<PriceMethod>  myLstPriceMethod = lst.ToList();

                // agregar un método a la lista
                int idtemplate_method = Convert.ToInt32(cbMethodAdd.EditValue);
                CTemplate_method oTemplate_method = new CTemplate_methodFactory().GetByPrimaryKey(new CTemplate_methodKeys(idtemplate_method));
                
                CPrice_version price_version = new CPrice_version();
                price_version.Idprice_version = 0;
                price_version.Idcompany = Convert.ToInt16(cbCompany.EditValue);
                price_version.Date_creation = Comun.GetDate();

                CPrice_version_detail price_version_detail = new CPrice_version_detail();
                price_version_detail.Num_item = myLstPriceMethod.Count+1;
                price_version_detail.Amount_item = 1;
                price_version_detail.Idtemplate_method = idtemplate_method;
                price_version_detail.Unit_price = oTemplate_method.Cost_method;
                price_version_detail.Sale_price = oTemplate_method.Cost_method * price_version_detail.Amount_item;

                myLstPriceMethod.Add(
                    new PriceMethod(price_version_detail, new ModPrice().GetPriceMethodHistory(price_version, price_version_detail.Idtemplate_method)));                

                gcPrice.DataSource = new BindingList<PriceMethod>(myLstPriceMethod);
                gvPrice.LayoutChanged();

                cbMethodAdd.EditValue = null;

                SumTotals();

                ShowPreviewReport();
            }
        }

        private void repOpenFile_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                // --- copiar la ruta del archivo para luego ser guardado
                if (ofdPrice.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    gvAnexos.SetFocusedRowCellValue(gcolAt_Filename, ofdPrice.SafeFileName);
                    gvAnexos.SetFocusedRowCellValue(gcolAt_Source_filename, ofdPrice.FileName);
                }
            }
            else if (e.Button.Index == 1)
            {
                if (gvAnexos.GetFocusedRowCellValue(gcolAt_Num_version) != null)
                {
                    try
                    {
                        // --- abrir documento
                        string path_filename =
                            System.IO.Path.Combine(
                            new CSettings().GetPathAttachPrice(),
                            gvAnexos.GetFocusedRowCellValue(gcolAt_Filename).ToString());

                        Process.Start(path_filename);
                    }
                    catch
                    {
                        Comun.Send_message(this.Text, TypeMsg.error, "Error: el archivo no existe");
                    }
                }
            }
        }        
 
        private void gcPrice_ViewRegistered(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e)
        {
            grid_view = e.View as DevExpress.XtraGrid.Views.Grid.GridView;            
        }

    }
    
    public class CItemCopy
    {
        public string Filename { get; set; }
        public string Source_file { get; set; }
        public string Destiny_directory { get; set; }        
    }

    public class ListCopy : List<CItemCopy>
    {    
        public void Save(CPrice price, CPrice_version price_version)
        {            
            foreach (CItemCopy item in this)
            {
                //copiar item
                if (Comun.CopyAndSaveFile(item.Source_file, item.Destiny_directory, item.Filename))
                {
                    CPrice_attach price_attach = new CPrice_attach();
                    price_attach.Idprice = price_version.Idprice;
                    price_attach.Idprice_version = price_version.Idprice_version;
                    price_attach.Name_document = item.Filename;

                    //guardar adjunto
                    if (!new CPrice_attachFactory().Update(price_attach))
                        new CPrice_attachFactory().Insert(price_attach);
                }
            }
        }
    }
}
