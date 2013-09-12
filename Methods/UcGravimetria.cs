using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LimsProject.BusinessLayer;
using LimsProject.BusinessLayer.Modules;

namespace LimsProject
{
    public partial class UcGravimetria : UserControl
    {
        public int? IDTemplate_Method { get; set; }
        CTemplate_method oTemplate_Method = new CTemplate_method();
        public short? IDElement { get; set; } 

        public UcGravimetria()
        {
            InitializeComponent();
        }

        public void InitData()
        {
            #region init combos

            try
            {
                CMeasurement_unitFactory faMeasurement_unit = new CMeasurement_unitFactory();
                cbUnit_result.Properties.DataSource = faMeasurement_unit.GetAll();
                cbUnit_result.Properties.DisplayMember = "Name_unit";
                cbUnit_result.Properties.ValueMember = "Idunit";                

                CReactiveFactory faReactive = new CReactiveFactory();
                List<CReactive> lstReactive = faReactive.GetAll();

                lstReactive.Add(new CReactive() { Idreactive = 0, Reactive_name = "---", Chemical_formula = "---" });
                
                // --- init combo material reference
                Methods oMethods = new Methods();
                cbMaterialRef.Properties.DataSource = oMethods.GetByElement(Convert.ToInt16(IDElement));
                cbMaterialRef.Properties.DisplayMember = "Cod_mr";
                cbMaterialRef.Properties.ValueMember = "Idmr_detail";
            }
            catch (Exception ex)
            {
                Comun.Send_message(this.Text, TypeMsg.error, ex.Message);
            }
            #endregion
        }

        public bool Son_Datos_Correctos()
        {
            if (tbSymbol.Text == "")
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: no se admite un simbolo de método vacio.");
                return false;
            }
            if (cbUnit_result.EditValue == null)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: no se ha seleccionado una unidad de medida.");
                return false;
            }            
            if (cbMaterialRef.EditValue == null)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: no se ha seleccionado un material de referencia.");
                return false;
            }            
            if (Convert.ToInt32(tbLimit_samples.EditValue) <= 0)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error:El valor del límite de muestras debe ser mayor a 0.");
                return false;
            }
            if (Convert.ToInt32(tbNum_days.EditValue) <= 0)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: El valor del 'Número de días debe ser mayor a 0'.");
                return false;
            }
            if (Convert.ToInt32(tbNum_samples.EditValue) <= 0)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: El valor del 'Número de muestras debe ser mayor a 0'.");
                return false;
            }            
            return true;
        }

        public void RetrieveTypeAnalysis()
        {
            try
            {
                InitData();

                // --- recuperate head 
                if (IDTemplate_Method != null && IDTemplate_Method > 0)
                {
                    CTemplate_method_aa oTemplate_method_aa = new CTemplate_method_aa();
                    CTemplate_method_aaFactory faTemplate_method_aa = new CTemplate_method_aaFactory();
                    oTemplate_method_aa = faTemplate_method_aa.GetByPrimaryKey(new CTemplate_method_aaKeys(Convert.ToInt32(IDTemplate_Method)));

                    if (oTemplate_method_aa != null)
                    {
                        oTemplate_method_aa.Idtemplate_method = oTemplate_Method.Idtemplate_method;
                        cbUnit_result.EditValue = oTemplate_method_aa.Idunit_result;
                        tbNum_samples.Value = Convert.ToDecimal(oTemplate_method_aa.Num_samples);
                        tbNum_days.Value = Convert.ToDecimal(oTemplate_method_aa.Num_days);
                        tbLimit_samples.Value = Convert.ToInt16(oTemplate_method_aa.Limit_samples);
                        tbWeight.Value = Convert.ToDecimal(oTemplate_method_aa.Weight);
                        tbWeight_incertitude.Value = Convert.ToDecimal(oTemplate_method_aa.Weight_incertitude);                        
                        tbReading_min.Value = Convert.ToDecimal(oTemplate_method_aa.Reading_min);
                        tbReading_max.Value = Convert.ToDecimal(oTemplate_method_aa.Reading_max);                                                
                        tbReason_rep.Value = Convert.ToDecimal(oTemplate_method_aa.Reason_rep);
                        tbError_allowed.Value = Convert.ToDecimal(oTemplate_method_aa.Error_allowed);
                        tbSymbol.Text = oTemplate_method_aa.Symbol;
                        tbLaw_limit_bottom.Value = Convert.ToDecimal(oTemplate_method_aa.Law_limit_bottom);
                        tbLaw_limit_top.Value = Convert.ToDecimal(oTemplate_method_aa.Law_limit_top);                        
                        tbReproducibility.Value = Convert.ToDecimal(oTemplate_method_aa.Reproducibility);
                        tbNum_decimal.Value = Convert.ToDecimal(oTemplate_method_aa.Num_decimal);
                        tbBlk_max.Value = Convert.ToDecimal(oTemplate_method_aa.Blk_max);
                        deDate_allowed_error.DateTime = Convert.ToDateTime(oTemplate_method_aa.Date_allowed_error);

                        cbMaterialRef.EditValue = oTemplate_method_aa.Idmr_detail;                        
                        
                        tbNum_days.Value = Convert.ToInt16(oTemplate_method_aa.Num_days);
                        tbNum_samples.Value = Convert.ToInt16(oTemplate_method_aa.Num_samples);
                        cbUnit_result.EditValue = oTemplate_method_aa.Idunit_result;
                        tbLimit_samples.EditValue = oTemplate_method_aa.Limit_samples;                        

                    }
                }
                else
                {
                                        
                }
            }
            catch (Exception ex)
            {
                Comun.Send_message(this.Text, TypeMsg.error, ex.Message);
            }
        }

        public bool SaveTypeAnalysis(int? pIdtemplate_method)
        {
            CTemplate_method_aaFactory faTemplate_method_aa = new CTemplate_method_aaFactory();
            IDTemplate_Method = pIdtemplate_method;

            if (IDTemplate_Method != null && IDTemplate_Method > 0)
            {
                bool result_template_method_aa = false;
                CTemplate_method_aa oTemplate_method_aa = new CTemplate_method_aa();

                oTemplate_method_aa.Idtemplate_method = Convert.ToInt32(IDTemplate_Method);
                oTemplate_method_aa.Weight = tbWeight.Value;
                oTemplate_method_aa.Weight_incertitude = tbWeight_incertitude.Value;                
                oTemplate_method_aa.Reading_min = tbReading_min.Value;
                oTemplate_method_aa.Reading_max = tbReading_max.Value;                
                oTemplate_method_aa.Reason_rep = tbReason_rep.Value;
                oTemplate_method_aa.Error_allowed = tbError_allowed.Value;
                oTemplate_method_aa.Symbol = tbSymbol.Text;
                oTemplate_method_aa.Law_limit_bottom = tbLaw_limit_bottom.Value;
                oTemplate_method_aa.Law_limit_top = tbLaw_limit_top.Value;

                oTemplate_method_aa.Idmr_detail = Convert.ToInt16(cbMaterialRef.EditValue);
                oTemplate_method_aa.Blk_max = tbBlk_max.Value;
                oTemplate_method_aa.Reason_rep = tbReason_rep.Value;
                oTemplate_method_aa.Reproducibility = tbReproducibility.Value;
                oTemplate_method_aa.Num_decimal = Convert.ToInt16(tbNum_decimal.Value);
                oTemplate_method_aa.Date_allowed_error = Convert.ToDateTime(deDate_allowed_error.EditValue);

                oTemplate_method_aa.Idunit_result = Convert.ToInt16(cbUnit_result.EditValue);
                oTemplate_method_aa.Num_days = Convert.ToInt16(tbNum_days.Value);
                oTemplate_method_aa.Num_samples = Convert.ToInt16(tbNum_samples.Value);
                oTemplate_method_aa.Limit_samples = Convert.ToInt16(tbLimit_samples.Value);

                if (!(result_template_method_aa = faTemplate_method_aa.Update(oTemplate_method_aa)))
                {
                    oTemplate_method_aa.Date_allowed_error = DateTime.Now;
                    result_template_method_aa = faTemplate_method_aa.Insert(oTemplate_method_aa);
                }                
            }
            return true;
        }

        public void Limpiar_Campos()
        {
            // --- clear head
            IDTemplate_Method = 0;
            tbSymbol.Text = "";
            cbMaterialRef.EditValue = null;
            cbUnit_result.EditValue = null;            
            tbWeight.Value = 0;
            tbWeight_incertitude.Value = 0;            
            tbReading_min.Value = 0;
            tbReading_max.Value = 0;
            tbReason_rep.Value = 0;
            tbError_allowed.Value = 0;
            tbLaw_limit_bottom.Value = 0;
            tbLaw_limit_top.Value = 0;            
            tbBlk_max.Value = 0;
            tbReproducibility.Value = 0;
            tbNum_decimal.Value = 0;
            tbLawMri.EditValue = null;
            tbLimit_samples.Value = 12;
            deDate_allowed_error.DateTime = DateTime.Now;
            tbNum_days.EditValue = null;
            tbNum_samples.EditValue = null;            
        }
    }
}
