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
    public partial class UcVC : UserControl
    {
        public int? IDTemplate_Method { get; set; }
        CTemplate_method oTemplate_Method = new CTemplate_method();
        public short? IDElement { get; set; }

        public UcVC()
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
                    CTemplate_method_vc oTemplate_method_vc = new CTemplate_method_vc();
                    CTemplate_method_vcFactory faTemplate_method_aa = new CTemplate_method_vcFactory();
                    oTemplate_method_vc = faTemplate_method_aa.GetByPrimaryKey(new CTemplate_method_vcKeys(Convert.ToInt32(IDTemplate_Method)));

                    if (oTemplate_method_vc != null)
                    {
                        oTemplate_method_vc.Idtemplate_method = Convert.ToInt32(IDTemplate_Method);
                        cbUnit_result.EditValue = oTemplate_method_vc.Idunit_result;
                        tbNum_samples.Value = Convert.ToDecimal(oTemplate_method_vc.Num_samples);
                        tbNum_days.Value = Convert.ToDecimal(oTemplate_method_vc.Num_days);
                        tbLimit_samples.Value = Convert.ToInt16(oTemplate_method_vc.Limit_samples);
                        tbWeight.Value = Convert.ToDecimal(oTemplate_method_vc.Weight);
                        tbWeight_incertitude.Value = Convert.ToDecimal(oTemplate_method_vc.Weight_incertitude);
                        tbReading_min.Value = Convert.ToDecimal(oTemplate_method_vc.Reading_min);
                        tbReading_max.Value = Convert.ToDecimal(oTemplate_method_vc.Reading_max);
                        tbReason_rep.Value = Convert.ToDecimal(oTemplate_method_vc.Reason_rep);
                        tbError_allowed.Value = Convert.ToDecimal(oTemplate_method_vc.Error_allowed);
                        tbSymbol.Text = oTemplate_method_vc.Symbol;
                        tbLaw_limit_bottom.Value = Convert.ToDecimal(oTemplate_method_vc.Law_limit_bottom);
                        tbLaw_limit_top.Value = Convert.ToDecimal(oTemplate_method_vc.Law_limit_top);
                        tbNum_decimal.Value = Convert.ToDecimal(oTemplate_method_vc.Num_decimal);
                        deDate_allowed_error.DateTime = Convert.ToDateTime(oTemplate_method_vc.Date_allowed_error);

                        tbNum_days.Value = Convert.ToInt16(oTemplate_method_vc.Num_days);
                        tbNum_samples.Value = Convert.ToInt16(oTemplate_method_vc.Num_samples);
                        cbUnit_result.EditValue = oTemplate_method_vc.Idunit_result;
                        tbLimit_samples.EditValue = oTemplate_method_vc.Limit_samples;

                        rbMR.Checked = false;
                        rbSamplesFortification.Checked = false;
                        rbBlkFortification.Checked = false;

                        rbMR.Checked = Convert.ToBoolean(oTemplate_method_vc.Flag_mr);
                        rbSamplesFortification.Checked = Convert.ToBoolean(oTemplate_method_vc.Flagsamfortify);
                        rbBlkFortification.Checked = Convert.ToBoolean(oTemplate_method_vc.Flagblkfortify);

                        //paMaterialReference.Enabled = Convert.ToBoolean(oTemplate_method_vc.Flag_mr);
                        //paBlkFortification.Enabled = Convert.ToBoolean(oTemplate_method_vc.Flagblkfortify);
                        //paSampleFortification.Enabled = Convert.ToBoolean(oTemplate_method_vc.Flagsamfortify);

                        if (paMaterialReference.Enabled)
                        {
                            tbReproducibility.Value = Convert.ToDecimal(oTemplate_method_vc.Reproducibility);
                            cbMaterialRef.EditValue = oTemplate_method_vc.Idmr_detail;
                            tbBlk_max.Value = Convert.ToDecimal(oTemplate_method_vc.Blk_max);
                        }

                        if (paBlkFortification.Enabled)
                        {
                            tbBlkFortiSolution.Value = Convert.ToDecimal(oTemplate_method_vc.Blkfortisol);
                            tbBlkFortiAliquot.Value = Convert.ToDecimal(oTemplate_method_vc.Blkfortialiquot);
                            tbBlkFortiReproducibility.Value = Convert.ToDecimal(oTemplate_method_vc.Blkfortireproducibility);
                        }

                        if (paSampleFortification.Enabled)
                        {
                            tbSamFortiSolution.Value = Convert.ToDecimal(oTemplate_method_vc.Samfortisol);
                            tbSamFortiAliquot.Value = Convert.ToDecimal(oTemplate_method_vc.Samfortialiquot);
                            tbSamFortiReproducibility.Value = Convert.ToDecimal(oTemplate_method_vc.Samfortireproducibility);
                        }                        
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
            CTemplate_method_vcFactory faTemplate_method_gr = new CTemplate_method_vcFactory();
            IDTemplate_Method = pIdtemplate_method;

            if (IDTemplate_Method != null && IDTemplate_Method > 0)
            {
                bool result_template_method_aa = false;
                CTemplate_method_vc oTemplate_method_vc = new CTemplate_method_vc();

                oTemplate_method_vc.Idtemplate_method = Convert.ToInt32(IDTemplate_Method);
                oTemplate_method_vc.Weight = tbWeight.Value;
                oTemplate_method_vc.Weight_incertitude = tbWeight_incertitude.Value;                
                oTemplate_method_vc.Reading_min = tbReading_min.Value;
                oTemplate_method_vc.Reading_max = tbReading_max.Value;                
                oTemplate_method_vc.Reason_rep = tbReason_rep.Value;
                oTemplate_method_vc.Error_allowed = tbError_allowed.Value;
                oTemplate_method_vc.Symbol = tbSymbol.Text;
                oTemplate_method_vc.Law_limit_bottom = tbLaw_limit_bottom.Value;
                oTemplate_method_vc.Law_limit_top = tbLaw_limit_top.Value;
                
                oTemplate_method_vc.Num_decimal = Convert.ToInt16(tbNum_decimal.Value);
                oTemplate_method_vc.Date_allowed_error = Convert.ToDateTime(deDate_allowed_error.EditValue);

                oTemplate_method_vc.Idunit_result = Convert.ToInt16(cbUnit_result.EditValue);
                oTemplate_method_vc.Num_days = Convert.ToInt16(tbNum_days.Value);
                oTemplate_method_vc.Num_samples = Convert.ToInt16(tbNum_samples.Value);
                oTemplate_method_vc.Limit_samples = Convert.ToInt16(tbLimit_samples.Value);                

                oTemplate_method_vc.Flag_mr = paMaterialReference.Enabled;
                if (paMaterialReference.Enabled)
                {                    
                    oTemplate_method_vc.Idmr_detail = Convert.ToInt16(cbMaterialRef.EditValue);
                    oTemplate_method_vc.Blk_max = tbBlk_max.Value;
                    oTemplate_method_vc.Reason_rep = tbReason_rep.Value;
                    oTemplate_method_vc.Reproducibility = tbReproducibility.Value;
                }

                oTemplate_method_vc.Flagblkfortify = paBlkFortification.Enabled;
                if (paBlkFortification.Enabled)
                {                    
                    oTemplate_method_vc.Blkfortisol = tbBlkFortiSolution.Value;
                    oTemplate_method_vc.Blkfortialiquot = tbBlkFortiAliquot.Value;
                    oTemplate_method_vc.Blkfortireproducibility = tbBlkFortiReproducibility.Value;
                }

                oTemplate_method_vc.Flagsamfortify = paSampleFortification.Enabled;
                if (paSampleFortification.Enabled)
                {                    
                    oTemplate_method_vc.Samfortisol = tbSamFortiSolution.Value;
                    oTemplate_method_vc.Samfortialiquot = tbSamFortiAliquot.Value;
                    oTemplate_method_vc.Samfortireproducibility = tbSamFortiReproducibility.Value;
                }

                if (!(result_template_method_aa = faTemplate_method_gr.Update(oTemplate_method_vc)))
                {
                    oTemplate_method_vc.Date_allowed_error = DateTime.Now;
                    result_template_method_aa = faTemplate_method_gr.Insert(oTemplate_method_vc);
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
    }
}
