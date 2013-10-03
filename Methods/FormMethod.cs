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

namespace LimsProject
{
    public partial class FormMethod : LibraryBasicForm.FormMantBase
    {
        #region attributs

        UcAA oucAA = new UcAA();
        UcICP oucICP = new UcICP();
        UcGR oucGravimetria = new UcGR();
        UcHumidityAnalysis oucHA = new UcHumidityAnalysis();
        UcVC oucVC = new UcVC();

        #endregion

        #region properties

        public int IDTemplate_Method { get; set; }
        public short IDElement { get; set; }
        public string Cod_template_method_const {
            set {
                gluCod_method.EditValue = value;
                gluCod_method.Focus();
                SendKeys.Send("{ENTER}");
                SendKeys.Send("{ENTER}");
                SendKeys.Send("{ENTER}");
            }
        }
        public short Num_version { get; set; }

        #endregion

        #region enumerators

        public enum eInit
        {
            Constant,
            Variable,
            ConstAndVar,
            Function,
            Tree,
            Condition
        }

        public enum eTypeAnalysis
        {
            AA,
            VOL,
            ICP,
            UV,
            GRAV,
            GH,
            PH,
            PQT
        }

        #endregion

        #region constructor

        public FormMethod()
        {
            InitializeComponent();
            
        }

        #endregion

        #region methods initialization



        public void InitData()
        {
            #region init combos

            try
            {
                // --- init: type of sample
                CType_sampleFactory faType_Sample = new CType_sampleFactory();                
                cbTypeSample.Properties.DataSource = faType_Sample.GetAll();
                cbTypeSample.Properties.ValueMember = "Cod_type_sample";
                cbTypeSample.Properties.DisplayMember = "Name_type_sample";

                repTypeSample.DataSource = faType_Sample.GetAll();
                repTypeSample.ValueMember = "Cod_type_sample";
                repTypeSample.DisplayMember = "Name_type_sample";

                // --- init: type of analysis
                cbTypeAnalysis.Properties.DataSource = Comun.ListTypeAnalysis;
                cbTypeAnalysis.Properties.ValueMember = "Type_analisys";
                cbTypeAnalysis.Properties.DisplayMember = "Den_Type_Analysis";

                repTypeAnalysis.DataSource = Comun.ListTypeAnalysis;
                repTypeAnalysis.ValueMember = "Type_analisys";
                repTypeAnalysis.DisplayMember = "Den_Type_Analysis";

                // --- init: digestation
                CDigestion_methodFactory faDigestation_Method = new CDigestion_methodFactory();                
                cbDigestion.Properties.DataSource = faDigestation_Method.GetAll();
                cbDigestion.Properties.ValueMember = "Cod_digestion_method";
                cbDigestion.Properties.DisplayMember = "Name_digestion_method";

                // --- init: element
                CElementFactory faElement = new CElementFactory();
                cbElement.Properties.DataSource = faElement.GetAll();
                cbElement.Properties.ValueMember = "Idelement";
                cbElement.Properties.DisplayMember = "Cod_element";

                repElement.DataSource = faElement.GetAll();
                repElement.ValueMember = "Idelement";
                repElement.DisplayMember = "Cod_element";

                // --- init: measurement unit number 1                
                cbRepetition.Properties.DataSource = Comun.ListTypeRepetition;
                cbRepetition.Properties.DisplayMember = "Name_repetition";
                cbRepetition.Properties.ValueMember = "Cod_repetition";

                Methods oMethods = new Methods();
                gluCod_method.Properties.DataSource = oMethods.GetAllLastVersionMethods();
                gluCod_method.Properties.DisplayMember = "Cod_template_method";
                gluCod_method.Properties.ValueMember = "Cod_template_method";

                CReactiveFactory faReactive = new CReactiveFactory();
                List<CReactive> lstReactive = faReactive.GetAll();

                lstReactive.Add(new CReactive() { Idreactive = 0, Reactive_name = "---", Chemical_formula = "---" });                

                gluCod_method.Properties.View.BestFitColumns();
                             
            }
            catch (Exception ex)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, ex.Message);
            }
            #endregion 
        }

        #endregion

        #region methods inherits

        protected override bool Son_Datos_Correctos()
        {
            if (gluCod_method.EditValue == null)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: no se admite el código de método vacio.");
                return false;
            }
            if (tbAbreviation.Text == "")
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: no se admite una abreviatura de método vacia.");
                return false;
            }            
            if (cbDigestion.EditValue == null)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: no se ha seleccionado el campo digestion.");
                return false;
            }
            if (cbElement.EditValue == null)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: no se ha seleccionado el campo elemento.");
                return false;
            }
            if (cbTypeSample.EditValue == null)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: no se ha seleccionado el campo tipo de muestra.");
                return false;
            }
            if (!Son_Datos_Correctos_TypeAnalysis())
            {
                return false;
            }            
            return true;
        }

        protected override void Recuperar_Registro()
        {
            try
            {
                // --- recuperate head 
                if (IDTemplate_Method > 0)
                {
                    // --- recuperate head

                    CTemplate_methodFactory faTemplate_Method = new CTemplate_methodFactory();
                    CTemplate_method oTemplate_Method = faTemplate_Method.GetByPrimaryKey(new CTemplate_methodKeys(IDTemplate_Method));
                    gluCod_method.EditValue = oTemplate_Method.Cod_template_method;
                    Num_version = Convert.ToInt16(oTemplate_Method.Num_version);
                    tbTitle.Text = oTemplate_Method.Title;
                    laTitulo.Text = string.Format("Metodo ({0}-{1})", oTemplate_Method.Num_version, oTemplate_Method.Useredit);
                    cbDigestion.EditValue = oTemplate_Method.Cod_digestion_method;
                    tbCost_Method.Value = Convert.ToDecimal(oTemplate_Method.Cost_method);
                    tbAbreviation.Text = oTemplate_Method.Abbreviation;
                    ckRecognized.Checked = Convert.ToBoolean(oTemplate_Method.Recognized);
                    cbTypeSample.EditValue = oTemplate_Method.Cod_type_sample;
                    cbElement.EditValue = Convert.ToInt16(oTemplate_Method.Idelement);
                    cbTypeAnalysis.EditValue = null;
                    cbTypeAnalysis.EditValue = oTemplate_Method.Type_analisys; //recupera el tipo de analisis
                    cbRepetition.EditValue = oTemplate_Method.Cod_repetition;                    
                }               
            }
            catch (Exception ex)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, ex.Message);
            }
        }

        protected override void Accion_Despues_Grabar()
        {
            Methods oMethods = new Methods();
            gluCod_method.Properties.DataSource = oMethods.GetAllLastVersionMethods();
            gluCod_method.Properties.DisplayMember = "Cod_template_method";
            gluCod_method.Properties.ValueMember = "Cod_template_method";
            gluCod_method.Properties.View.BestFitColumns();
        }

        protected override bool Grabar_Registro()
        {
            try
            {
                return SaveAA();
            }
            catch(Exception ex)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, ex.Message);
                return false;
            }            
        }

        protected override void Eliminar_Registro()
        {
            base.Eliminar_Registro();
        }

        protected override bool Grabar()
        {

            if (Son_Datos_Correctos())
                //&& (MessageBox.Show("Desea grabar el documento actual?", "Grabar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                if (Grabar_Registro())
                {                    
                    Accion_Despues_Grabar();                    
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        protected override void Limpiar_Campos()
        {
            // --- clear head
            IDTemplate_Method = 0;
            cbElement.EditValue = null;
            cbTypeSample.EditValue = null;
            gluCod_method.EditValue = null;
            tbTitle.Text = "";
            tbAbreviation.Text = "";            
            ckRecognized.Checked = false;
            tbCost_Method.Value = 0;            
            cbDigestion.EditValue = null;
            cbTypeAnalysis.EditValue = null;
            cbRepetition.EditValue = null;            
            laTitulo.Text = "Métodos";                       
        }        

        #endregion

        #region methods
        
        public void RecuperateAA()
        {            
            
        }

        bool SaveAA()
        {
            try
            {
                string Cod_method = gluCod_method.Text;
                string Title = tbTitle.Text;
                string messageOk = "";

                Methods oMethods = new Methods();
                Comun.MethodSaveProperty InspectionChanges = RequireNewVersionOrMethod(Comun.GetTypeAnalysis(Convert.ToChar(cbTypeAnalysis.EditValue)));

                if (InspectionChanges == Comun.MethodSaveProperty.NewMethod)
                {
                    Num_version = 1;
                    messageOk = "Se guardó un nuevo método con código " + Cod_method +
                                    "\ncon título " + Title;
                }
                if (InspectionChanges == Comun.MethodSaveProperty.InspectionNewVersion)
                {
                    // --- save as new version or overwrite
                    FormConfirmSaveMethod fmConfirmSaveMethod = new FormConfirmSaveMethod(true);
                    if (fmConfirmSaveMethod.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (fmConfirmSaveMethod.SaveType == Comun.Save_type.SaveAs)
                        {
                            FormMethodSaveAs fmMethodSaveAs = new FormMethodSaveAs();
                            fmMethodSaveAs.ListTemplate =
                                oMethods.GetAllLastVersionMethods(
                                Convert.ToInt32(cbElement.EditValue),
                                cbTypeSample.EditValue.ToString(),
                                Convert.ToChar(cbTypeAnalysis.EditValue));

                            if (fmMethodSaveAs.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                Num_version = 1;
                                IDTemplate_Method = 0;
                                Cod_method = fmMethodSaveAs.Cod_method;
                                Title = fmMethodSaveAs.Title;
                                messageOk = "Se guardó un nuevo método con código " + fmMethodSaveAs.Cod_method +
                                    "\n con título '" + fmMethodSaveAs.Title + "'";
                            }
                            else
                            {
                                return false;
                            }
                        }
                        if (fmConfirmSaveMethod.SaveType == Comun.Save_type.Save)
                        {
                            Num_version = oMethods.GetNumNewVersion(IDTemplate_Method);
                            IDTemplate_Method = 0;
                            messageOk = "Se guardó una nueva versión [" + Num_version.ToString() + "] del método " + Cod_method;
                        }
                    }
                    else
                        return false;
                }
                if (InspectionChanges == Comun.MethodSaveProperty.InspectionNewMethod)
                {
                    FormMethodSaveAs fmMethodSaveAs = new FormMethodSaveAs();
                    fmMethodSaveAs.ListTemplate =
                        oMethods.GetAllLastVersionMethods(
                        Convert.ToInt32(cbElement.EditValue),
                        cbTypeSample.EditValue.ToString(),
                        Convert.ToChar(cbTypeAnalysis.EditValue));

                    if (fmMethodSaveAs.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Num_version = 1;
                        IDTemplate_Method = 0;
                        Cod_method = fmMethodSaveAs.Cod_method;
                        Title = fmMethodSaveAs.Title;
                        messageOk = "Se guardó un nuevo método con código " + fmMethodSaveAs.Cod_method +
                                    "\n con título " + fmMethodSaveAs.Title;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (InspectionChanges == Comun.MethodSaveProperty.Nothing)
                {
                    messageOk = "Se guardó correctamente";
                }
                // --- save head
                CTemplate_methodFactory faTemplate_Method = new CTemplate_methodFactory();
                CTemplate_method oTemplate_Method = new CTemplate_method();
                oTemplate_Method.Idtemplate_method = IDTemplate_Method;
                oTemplate_Method.Num_version = Num_version;
                oTemplate_Method.Idelement = Convert.ToInt32(cbElement.EditValue);
                oTemplate_Method.Cod_template_method = Cod_method;
                oTemplate_Method.Title = Title;
                oTemplate_Method.Cod_digestion_method = cbDigestion.EditValue.ToString();
                oTemplate_Method.Cod_repetition = Convert.ToInt16(cbRepetition.EditValue);
                oTemplate_Method.Abbreviation = tbAbreviation.Text;
                oTemplate_Method.Recognized = ckRecognized.Checked;
                oTemplate_Method.Cod_type_sample = cbTypeSample.EditValue.ToString();
                oTemplate_Method.Cost_method = tbCost_Method.Value;
                oTemplate_Method.Type_analisys = Convert.ToChar(cbTypeAnalysis.EditValue);
                oTemplate_Method.Status = true;

                if (IDTemplate_Method == 0)
                {
                    oTemplate_Method.Usernew = Comun.GetUser();
                    oTemplate_Method.Datenew = Comun.GetDate();
                    oTemplate_Method.Useredit = Comun.GetUser();
                    oTemplate_Method.Dateedit = Comun.GetDate();
                }
                else
                {
                    oTemplate_Method.Useredit = Comun.GetUser();
                    oTemplate_Method.Dateedit = Comun.GetDate();
                }
                
                bool result_template_method = false;

                if (!(result_template_method = faTemplate_Method.Update(oTemplate_Method)))
                    result_template_method = faTemplate_Method.Insert(oTemplate_Method);

                if (result_template_method)
                {
                    IDTemplate_Method = oTemplate_Method.Idtemplate_method;
                    SaveTypeAnalysis();
                }

                FormResult fmResult = new FormResult();
                fmResult.Message = messageOk;
                fmResult.ShowDialog();
                gluCod_method.Text = Cod_method;
                return true;
            }
            catch (Exception ex)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, ex.Message);
                return false;
            }
        }        
        
        #endregion

        #region events

        private void FormMethod_Load(object sender, EventArgs e)
        {
            InitData();
            Num_version = 1;            
        }
       
        #endregion                

        private void cbElement_EditValueChanged(object sender, EventArgs e)
        {
            if (cbElement.ItemIndex >= 0)
            {
                // --- recuperate id of element selected
                IDElement = Convert.ToInt16(cbElement.EditValue);
            }
        }

        void FilterByCodMethod()
        {
            CTemplate_methodFactory faTemplate_Method = new CTemplate_methodFactory();
            IDTemplate_Method = Convert.ToInt32(gluCod_method.EditValue);
            CTemplate_method oTemplate_Method = faTemplate_Method.GetByPrimaryKey(new CTemplate_methodKeys(IDTemplate_Method));
            if (oTemplate_Method != null)
            {
                cbElement.EditValue = Convert.ToInt16(oTemplate_Method.Idelement);
                cbTypeSample.EditValue = oTemplate_Method.Cod_type_sample;
                cbTypeAnalysis.EditValue = oTemplate_Method.Type_analisys;
            }
        }

        private void paSuperior_Leave(object sender, EventArgs e)
        {
            // --- filterig by element, type_sample and type_analysis         
            Methods oMethods = new Methods();
            int index = Convert.ToInt32(gluCod_method.Properties.GetIndexByKeyValue(gluCod_method.EditValue));

            if (index != -1)
            {
                IDTemplate_Method = Convert.ToInt32(gluCod_method.Properties.View.GetRowCellValue(index, gcMet_Idtemplate_method));

                Recuperar_Registro();
            }            
        }

        bool Son_Datos_Correctos_TypeAnalysis()
        {
            if (cbTypeAnalysis.EditValue != null)
            {
                switch (Convert.ToChar(cbTypeAnalysis.EditValue))
                {
                    case '1':
                        if (!oucAA.Son_Datos_Correctos())
                            return false;
                        break;
                    case '2':
                        if (!oucVC.Son_Datos_Correctos())
                            return false;
                        break;
                    case '3':
                        if (!oucGravimetria.Son_Datos_Correctos())
                            return false;
                        break;
                    case '4':
                        if (!oucICP.Son_Datos_Correctos())
                            return false;
                        break;
                    case '5':
                        break;
                    case '6':
                        if (!oucHA.Son_Datos_Correctos())
                            return false;
                        break;
                }
            }
            return true;
        }

        void SaveTypeAnalysis()
        {            
            if (cbTypeAnalysis.EditValue != null)
            {
                switch (Convert.ToChar(cbTypeAnalysis.EditValue))
                {
                    case '1':
                        oucAA.SaveTypeAnalysis(IDTemplate_Method);
                        break;
                    case '2':
                        oucVC.SaveTypeAnalysis(IDTemplate_Method);
                        break;
                    case '3':
                        oucGravimetria.SaveTypeAnalysis(IDTemplate_Method);
                        break;
                    case '4':
                        oucICP.SaveTypeAnalysis(IDTemplate_Method);
                        break;
                    case '5':
                        break;
                    case '6':
                        oucHA.SaveTypeAnalysis(IDTemplate_Method);
                        break;
                }
            }
        }

        void RetrieveTypeAnalysis()
        {
            /*
             1 absorción atómica    
             2 volumetría           
             3 gravimetría          
             4 ipc           
             5 newmont-grav  
             */
            paSpecificMethod.Controls.Clear();

            if (cbTypeAnalysis.EditValue != null)
            {
                switch (Convert.ToChar(cbTypeAnalysis.EditValue))
                {
                    case '1':                        
                        paSpecificMethod.Controls.Add(oucAA);
                        oucAA.Dock = DockStyle.Fill;
                        oucAA.IDElement = cbElement.EditValue == null ? Convert.ToInt16(null) : Convert.ToInt16(cbElement.EditValue);
                        oucAA.IDTemplate_Method = IDTemplate_Method;
                        oucAA.RetrieveTypeAnalysis();

                        cbElement.Enabled = true;
                        break;
                    case '2':    
                        paSpecificMethod.Controls.Add(oucVC);
                        oucVC.Dock = DockStyle.Fill;
                        oucVC.IDElement = cbElement.EditValue == null ? Convert.ToInt16(null) : Convert.ToInt16(cbElement.EditValue);
                        oucVC.IDTemplate_Method = IDTemplate_Method;
                        oucVC.RetrieveTypeAnalysis();

                        cbElement.Enabled = true;
                        break;
                    case '3':                    
                        paSpecificMethod.Controls.Add(oucGravimetria);
                        oucGravimetria.Dock = DockStyle.Fill;
                        oucGravimetria.IDElement = cbElement.EditValue == null ? Convert.ToInt16(null) : Convert.ToInt16(cbElement.EditValue);
                        oucGravimetria.IDTemplate_Method = IDTemplate_Method;
                        oucGravimetria.RetrieveTypeAnalysis();

                        cbElement.Enabled = true;
                        break;
                    case '4':                        
                        paSpecificMethod.Controls.Add(oucICP);
                        oucICP.Dock = DockStyle.Fill;
                        oucICP.Idtemplate_method = IDTemplate_Method;
                        oucICP.Type_analisys = 4;
                        oucICP.RetrieveTypeAnalysis();

                        cbElement.Enabled = false;
                        cbElement.EditValue = null;                                                
                        break;
                    case '5':                        
                        break;
                    case '6':
                        paSpecificMethod.Controls.Add(oucHA);
                        oucHA.Dock = DockStyle.Fill;
                        oucHA.IDTemplate_Method = IDTemplate_Method;
                        oucHA.RetrieveTypeAnalysis();
                        cbElement.Enabled = true;                                                
                        break;
                }
            }
        }               
        
        private void gluCod_method_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {                
                try
                {                    
                    List<CTemplate_method> lstTemplateMethod = new Methods().GetAllLastVersionMethods();
                    int next_cod_template_method = lstTemplateMethod.Max(c => Convert.ToInt32(c.Cod_template_method))+1;
                    lstTemplateMethod.Add(new CTemplate_method()
                    {
                        Cod_template_method = next_cod_template_method.ToString(),
                        Idtemplate_method = 0
                    });
                    gluCod_method.Properties.DataSource = lstTemplateMethod;
                    gluCod_method.EditValue = next_cod_template_method;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void gluCod_method_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                List<CTemplate_method> lstTemplateMethod = new Methods().GetAllLastVersionMethods();
                if (lstTemplateMethod.Exists(c => Convert.ToInt32(gluCod_method.EditValue) == 0 && c.Cod_template_method == gluCod_method.Text.Trim()))
                    e.Cancel = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gluCod_method_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            try
            {
                List<CTemplate_method> lstTemplateMethod = new Methods().GetAllLastVersionMethods();
                CTemplate_method oTemplate_method = lstTemplateMethod.Single(c => c.Cod_template_method == gluCod_method.Text);
                if (oTemplate_method == null)
                    e.ErrorText = "el código de método ya se encuentra asignado";
                else
                    e.ErrorText = "el código de método ya se encuentra asignado al método " + oTemplate_method.Abbreviation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gluCod_method_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit Edit;
                Edit = ((DevExpress.XtraEditors.GridLookUpEdit)sender).Properties;

                if (e.DisplayValue == null || Edit.NullText.Equals(e.DisplayValue) || string.Empty.Equals(e.DisplayValue))
                    return;

                List<CTemplate_method> lstCtm = (List<CTemplate_method>)gluCod_method.Properties.DataSource;

                // --- allways keeping one record how new value
                if (lstCtm.Exists(c => c.Idtemplate_method == 0))
                {
                    CTemplate_method oTemplate_method = lstCtm.Single(c => c.Idtemplate_method == 0);
                    oTemplate_method.Cod_template_method = e.DisplayValue.ToString();                    
                    gluCod_method.Properties.DataSource = lstCtm;
                }
                else
                {
                    List<CTemplate_method> lstTemplateMethod = new Methods().GetAllLastVersionMethods();
                    if (!lstTemplateMethod.Exists(c => c.Cod_template_method == gluCod_method.Text.Trim()))
                    {
                        lstCtm.Add(new CTemplate_method()
                        {
                            Cod_template_method = e.DisplayValue.ToString(),
                            Idtemplate_method = 0
                        });
                        gluCod_method.Properties.DataSource = lstCtm;
                    }
                }

                e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTypeAnalysis_EditValueChanged(object sender, EventArgs e)
        {
            if (cbTypeAnalysis.EditValue != null)
                RetrieveTypeAnalysis();
        }

        private void cbElement_EditValueChanged_1(object sender, EventArgs e)
        {
            Methods oMethods = new Methods();
            
            //refresh type method detail
            if (cbElement.EditValue != null && cbTypeAnalysis.EditValue != null)
            {
                IDElement = Convert.ToInt16(cbElement.EditValue);

                switch (Convert.ToChar(cbTypeAnalysis.EditValue))
                {
                    case '1':
                        if (paSpecificMethod.Controls.Count > 0)
                            oucAA.RefreshByElement(IDElement);                        
                        break;
                    case '2':
                        if (paSpecificMethod.Controls.Count > 0)
                            oucVC.RefreshByElement(IDElement);
                        break;
                    case '3':
                        if (paSpecificMethod.Controls.Count > 0)
                            oucGravimetria.RefreshByElement(IDElement);
                        break;                    
                    case '5':
                        break;
                }
            }
        }               
    }    

    public class CPerfil
    {
        public int IDPerfil { get; set; }
        public string NomPerfil { get; set; }
        public string GrupoVariable { get; set; }
        public string AliasVariable { get; set; }
        public bool Lectura { get; set; }
        public bool Visible { get; set; }
    }

    public class CItemGenericCombo
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
    }

    public class CItemStageProcess
    {
        public int OrderProcess { get; set; }
        public int OrderStageProcess { get; set; }
        public string NameProcess { get; set; }
        public string NameStageProcess { get; set; }
    }

    public class CListProcess : List<CItemStageProcess>
    {
        List<CItemStageProcess> lstItemStageProcess = new List<CItemStageProcess>();

        public void mov_up(int index)
        {
            
        }
    }
}
