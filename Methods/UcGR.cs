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
    public partial class UcGR : UserControl
    {
        public int? IDTemplate_Method { get; set; }
        CTemplate_method oTemplate_Method = new CTemplate_method();
        public short? IDElement { get; set; }        

        public UcGR()
        {
            InitializeComponent();
        }        

        public void RefreshByElement(short? idelement)
        {
            var query =
                (from m in new CCompoundFactory().GetAll()
                 join n in new CFactor_estequiometricoFactory().GetAll() on m.Idcompound equals n.Idcompound
                 where n.Idelement == Convert.ToInt16(idelement)
                 select new
                 {
                     Idfactor_estequiometrico = Convert.ToInt32(n.Idfactor_estequiometrico),
                     m.Name_compound,
                     Factor = Convert.ToDecimal(n.Factor)
                 }).ToList();

            cbPrecipitado.Properties.DataSource = query;
            cbPrecipitado.Properties.ValueMember = "Idfactor_estequiometrico";
            cbPrecipitado.Properties.DisplayMember = "Name_compound";
        }

        public void InitData()
        {
            #region init combos

            try
            {
                cbUnit_result.Bind();
                cbMaterialRef.Bind(Convert.ToInt16(IDElement));

                paMaterialReference.Enabled = false;
                paSampleFortification.Enabled = false;
                paBlkFortification.Enabled = false;

                rbMR.Checked = true;
                rbBlkFortification.Checked = false;
                rbSamplesFortification.Checked = false;

                RefreshByElement(IDElement);
            }
            catch (Exception ex)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, ex.Message);
            }
            #endregion
        }

        public bool Son_Datos_Correctos()
        {
            if (tbSymbol.Text == "")
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: no se admite un simbolo de método vacio.");
                return false;
            }
            if (cbUnit_result.EditValue == null)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: no se ha seleccionado una unidad de medida.");
                return false;
            }            
            if (cbMaterialRef.EditValue == null)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: no se ha seleccionado un material de referencia.");
                return false;
            }            
            if (Convert.ToInt32(tbLimit_samples.EditValue) <= 0)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error:El valor del límite de muestras debe ser mayor a 0.");
                return false;
            }
            if (Convert.ToInt32(tbNum_days.EditValue) <= 0)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: El valor del 'Número de días debe ser mayor a 0'.");
                return false;
            }
            if (Convert.ToInt32(tbNum_samples.EditValue) <= 0)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: El valor del 'Número de muestras debe ser mayor a 0'.");
                return false;
            }
            if (paMaterialReference.Enabled)
            {
                if (cbMaterialRef.EditValue == null)
                {
                    ComunForm.Send_message("Métodos", TypeMsg.error, "Error: No se seleccionó el material de referencia");
                    return false;
                }
                if (tbBlk_max.Value == 0)
                {
                    ComunForm.Send_message("Métodos", TypeMsg.error, "Error: No se ingreso un valor al campo LRB.");
                    return false;
                }
                if (tbReproducibility.Value == 0)
                {
                    ComunForm.Send_message("Métodos", TypeMsg.error, "Error: No se ingreso un valor al campo LRB.");
                    return false;
                }
            }
            if (paBlkFortification.Enabled)
            {
                if (tbBlkFortiSolution.Value == 0)
                {
                    ComunForm.Send_message("Métodos", TypeMsg.error, "Error: No se ingreso un valor al campo Solucion en el blanco fortificado.");
                    return false;
                }
                if (tbBlkFortiAliquot.Value == 0)
                {
                    ComunForm.Send_message("Métodos", TypeMsg.error, "Error: No se ingreso la alicuota en el blanco fortificado.");
                    return false;
                }
                if (tbBlkFortiReproducibility.Value == 0)
                {
                    ComunForm.Send_message("Métodos", TypeMsg.error, "Error: No se ingreso el factor de reproducibilidad en el blanco de fortificación.");
                    return false;
                }
            }
            if (paSampleFortification.Enabled)
            {
                if (tbSamFortiSolution.Value == 0)
                {
                    ComunForm.Send_message("Métodos", TypeMsg.error, "Error: No se ingreso un valor al campo solucion en la muestra fortificada.");
                    return false;
                }
                if (tbSamFortiAliquot.Value == 0)
                {
                    ComunForm.Send_message("Métodos", TypeMsg.error, "Error: No se ingreso un valor al campo alicuota en la muestra fortificada.");
                    return false;
                }
                if (tbSamFortiReproducibility.Value == 0)
                {
                    ComunForm.Send_message("Métodos", TypeMsg.error, "Error: No se ingreso un valor al campo reproducibilidad en la muestra fortificada.");
                    return false;
                }
            }
            if (cbPrecipitado.EditValue == null)
            {
                ComunForm.Send_message("Métodos", TypeMsg.error, "Error: No se ingreso el precipitado.");
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
                    CTemplate_method_gr oTemplate_method_gr = new CTemplate_method_gr();
                    CTemplate_method_grFactory faTemplate_method_aa = new CTemplate_method_grFactory();
                    oTemplate_method_gr = faTemplate_method_aa.GetByPrimaryKey(new CTemplate_method_grKeys(Convert.ToInt32(IDTemplate_Method)));

                    if (oTemplate_method_gr != null)
                    {
                        oTemplate_method_gr.Idtemplate_method = Convert.ToInt32(IDTemplate_Method);
                        cbUnit_result.EditValue = oTemplate_method_gr.Idunit_result;
                        tbNum_samples.Value = Convert.ToDecimal(oTemplate_method_gr.Num_samples);
                        tbNum_days.Value = Convert.ToDecimal(oTemplate_method_gr.Num_days);
                        tbLimit_samples.Value = Convert.ToInt16(oTemplate_method_gr.Limit_samples);
                        tbWeight.Value = Convert.ToDecimal(oTemplate_method_gr.Weight);
                        tbWeight_incertitude.Value = Convert.ToDecimal(oTemplate_method_gr.Weight_incertitude);
                        tbReading_min.Value = Convert.ToDecimal(oTemplate_method_gr.Reading_min);
                        tbReading_max.Value = Convert.ToDecimal(oTemplate_method_gr.Reading_max);
                        tbReason_rep.Value = Convert.ToDecimal(oTemplate_method_gr.Reason_rep);
                        tbError_allowed.Value = Convert.ToDecimal(oTemplate_method_gr.Error_allowed);
                        tbSymbol.Text = oTemplate_method_gr.Symbol;
                        tbLaw_limit_bottom.Value = Convert.ToDecimal(oTemplate_method_gr.Law_limit_bottom);
                        tbLaw_limit_top.Value = Convert.ToDecimal(oTemplate_method_gr.Law_limit_top);
                        tbNum_decimal.Value = Convert.ToDecimal(oTemplate_method_gr.Num_decimal);
                        deDate_allowed_error.DateTime = Convert.ToDateTime(oTemplate_method_gr.Date_allowed_error);

                        tbNum_days.Value = Convert.ToInt16(oTemplate_method_gr.Num_days);
                        tbNum_samples.Value = Convert.ToInt16(oTemplate_method_gr.Num_samples);
                        cbUnit_result.EditValue = oTemplate_method_gr.Idunit_result;
                        tbLimit_samples.EditValue = oTemplate_method_gr.Limit_samples;

                        rbMR.Checked = false;
                        rbSamplesFortification.Checked = false;
                        rbBlkFortification.Checked = false;

                        rbMR.Checked = Convert.ToBoolean(oTemplate_method_gr.Flag_mr);
                        rbSamplesFortification.Checked = Convert.ToBoolean(oTemplate_method_gr.Flagsamfortify);
                        rbBlkFortification.Checked = Convert.ToBoolean(oTemplate_method_gr.Flagblkfortify);

                        //paMaterialReference.Enabled = Convert.ToBoolean(oTemplate_method_gr.Flag_mr);
                        //paBlkFortification.Enabled = Convert.ToBoolean(oTemplate_method_gr.Flagblkfortify);
                        //paSampleFortification.Enabled = Convert.ToBoolean(oTemplate_method_gr.Flagsamfortify);

                        if (paMaterialReference.Enabled)
                        {
                            tbReproducibility.Value = Convert.ToDecimal(oTemplate_method_gr.Reproducibility);
                            cbMaterialRef.EditValue = oTemplate_method_gr.Idmr_detail;
                            tbBlk_max.Value = Convert.ToDecimal(oTemplate_method_gr.Blk_max);
                        }

                        if (paBlkFortification.Enabled)
                        {
                            tbBlkFortiSolution.Value = Convert.ToDecimal(oTemplate_method_gr.Blkfortisol);
                            tbBlkFortiAliquot.Value = Convert.ToDecimal(oTemplate_method_gr.Blkfortialiquot);
                            tbBlkFortiReproducibility.Value = Convert.ToDecimal(oTemplate_method_gr.Blkfortireproducibility);
                        }

                        if (paSampleFortification.Enabled)
                        {
                            tbSamFortiSolution.Value = Convert.ToDecimal(oTemplate_method_gr.Samfortisol);
                            tbSamFortiAliquot.Value = Convert.ToDecimal(oTemplate_method_gr.Samfortialiquot);
                            tbSamFortiReproducibility.Value = Convert.ToDecimal(oTemplate_method_gr.Samfortireproducibility);
                        }

                        cbPrecipitado.EditValue = oTemplate_method_gr.Idfactor_estequiometrico;
                    }
                    else
                    {
                        // limpiar campos
                        Limpiar_Campos();
                    }
                }                
            }
            catch (Exception ex)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, ex.Message);
            }
        }

        public bool SaveTypeAnalysis(int? pIdtemplate_method)
        {
            CTemplate_method_grFactory faTemplate_method_gr = new CTemplate_method_grFactory();
            IDTemplate_Method = pIdtemplate_method;

            if (IDTemplate_Method != null && IDTemplate_Method > 0)
            {
                bool result_template_method_aa = false;
                CTemplate_method_gr oTemplate_method_gr = new CTemplate_method_gr();

                oTemplate_method_gr.Idtemplate_method = Convert.ToInt32(IDTemplate_Method);
                oTemplate_method_gr.Weight = tbWeight.Value;
                oTemplate_method_gr.Weight_incertitude = tbWeight_incertitude.Value;                
                oTemplate_method_gr.Reading_min = tbReading_min.Value;
                oTemplate_method_gr.Reading_max = tbReading_max.Value;                
                oTemplate_method_gr.Reason_rep = tbReason_rep.Value;
                oTemplate_method_gr.Error_allowed = tbError_allowed.Value;
                oTemplate_method_gr.Symbol = tbSymbol.Text;
                oTemplate_method_gr.Law_limit_bottom = tbLaw_limit_bottom.Value;
                oTemplate_method_gr.Law_limit_top = tbLaw_limit_top.Value;
                
                oTemplate_method_gr.Num_decimal = Convert.ToInt16(tbNum_decimal.Value);
                oTemplate_method_gr.Date_allowed_error = Convert.ToDateTime(deDate_allowed_error.EditValue);

                oTemplate_method_gr.Idunit_result = Convert.ToInt16(cbUnit_result.EditValue);
                oTemplate_method_gr.Num_days = Convert.ToInt16(tbNum_days.Value);
                oTemplate_method_gr.Num_samples = Convert.ToInt16(tbNum_samples.Value);
                oTemplate_method_gr.Limit_samples = Convert.ToInt16(tbLimit_samples.Value);

                oTemplate_method_gr.Idfactor_estequiometrico = Convert.ToInt32(cbPrecipitado.EditValue);

                oTemplate_method_gr.Flag_mr = paMaterialReference.Enabled;
                if (paMaterialReference.Enabled)
                {                    
                    oTemplate_method_gr.Idmr_detail = Convert.ToInt16(cbMaterialRef.EditValue);
                    oTemplate_method_gr.Blk_max = tbBlk_max.Value;
                    oTemplate_method_gr.Reason_rep = tbReason_rep.Value;
                    oTemplate_method_gr.Reproducibility = tbReproducibility.Value;
                }

                oTemplate_method_gr.Flagblkfortify = paBlkFortification.Enabled;
                if (paBlkFortification.Enabled)
                {                    
                    oTemplate_method_gr.Blkfortisol = tbBlkFortiSolution.Value;
                    oTemplate_method_gr.Blkfortialiquot = tbBlkFortiAliquot.Value;
                    oTemplate_method_gr.Blkfortireproducibility = tbBlkFortiReproducibility.Value;
                }

                oTemplate_method_gr.Flagsamfortify = paSampleFortification.Enabled;
                if (paSampleFortification.Enabled)
                {                    
                    oTemplate_method_gr.Samfortisol = tbSamFortiSolution.Value;
                    oTemplate_method_gr.Samfortialiquot = tbSamFortiAliquot.Value;
                    oTemplate_method_gr.Samfortireproducibility = tbSamFortiReproducibility.Value;
                }

                if (!(result_template_method_aa = faTemplate_method_gr.Update(oTemplate_method_gr)))
                {
                    oTemplate_method_gr.Date_allowed_error = DateTime.Now;
                    result_template_method_aa = faTemplate_method_gr.Insert(oTemplate_method_gr);
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

            tbBlkFortiSolution.Value = 0;
            tbBlkFortiAliquot.Value = 0;
            tbBlkFortiReproducibility.Value = 0;

            tbSamFortiSolution.Value = 0;
            tbSamFortiAliquot.Value = 0;
            tbSamFortiReproducibility.Value = 0;
            cbPrecipitado.EditValue = null;

            rbMR.Checked = false;
            rbSamplesFortification.Checked = false;
            rbBlkFortification.Checked = false;

            rbMR.Checked = true;
        }

        private void rbMR_CheckedChanged(object sender, EventArgs e)
        {
            paMaterialReference.Enabled = rbMR.Checked;
            if (!paMaterialReference.Enabled)
            {
                cbMaterialRef.EditValue = null;
                tbBlk_max.Value = 0;
                tbReproducibility.Value = 0;
            }
        }

        private void rbSamplesFortification_CheckedChanged(object sender, EventArgs e)
        {
            paSampleFortification.Enabled = rbSamplesFortification.Checked;
            if (!paSampleFortification.Enabled)
            {
                tbSamFortiSolution.Value = 0;
                tbSamFortiReproducibility.Value = 0;
                tbSamFortiAliquot.Value = 0;
            }
        }

        private void rbBlkFortification_CheckedChanged(object sender, EventArgs e)
        {
            paBlkFortification.Enabled = rbBlkFortification.Checked;
            if (!paBlkFortification.Enabled)
            {
                tbBlkFortiSolution.Value = 0;
                tbBlkFortiReproducibility.Value = 0;
                tbBlkFortiAliquot.Value = 0;
            }
        }

        private void cbPrecipitado_EditValueChanged(object sender, EventArgs e)
        {
            int idFactorEsteq = Convert.ToInt32(cbPrecipitado.EditValue);
            tbPrecipitadoFactor.Text = 
                new CFactor_estequiometricoFactory()
                .GetByPrimaryKey(new CFactor_estequiometricoKeys(idFactorEsteq))
                .Factor.ToString();
        }
    }
}
