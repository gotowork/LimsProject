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
    public partial class UcAA : UserControl
    {
        public int? IDTemplate_Method { get; set; }
        CTemplate_method oTemplate_Method = new CTemplate_method();
        public short? IDElement { get; set; }        

        public UcAA()
        {
            InitializeComponent();
            InitData();
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

                cbUnit_calib.Properties.DataSource = faMeasurement_unit.GetAll();
                cbUnit_calib.Properties.DisplayMember = "Name_unit";
                cbUnit_calib.Properties.ValueMember = "Idunit";                

                CReactiveFactory faReactive = new CReactiveFactory();
                List<CReactive> lstReactive = faReactive.GetAll();

                lstReactive.Add(new CReactive() { Idreactive = 0, Reactive_name = "---", Chemical_formula = "---" });

                cbMedium.Properties.DataSource = lstReactive;
                cbMedium.Properties.ValueMember = "Idreactive";
                cbMedium.Properties.DisplayMember = "Reactive_name";

                cbModif.Properties.DataSource = lstReactive;
                cbModif.Properties.ValueMember = "Idreactive";
                cbModif.Properties.DisplayMember = "Reactive_name";

                CGroup_solutionFactory faGroup_solution = new CGroup_solutionFactory();
                cbSolIntermType.Properties.DataSource = faGroup_solution.GetAll().Where(c => c.Type_solution == 2).ToList();
                cbSolIntermType.Properties.ValueMember = "Idgroup_solution";
                cbSolIntermType.Properties.DisplayMember = "Cod_solution";

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
            if (cbUnit_calib.EditValue == null)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: no se ha seleccionado una unidad de medida de calibración");
                return false;
            }
            if (cbMaterialRef.EditValue == null)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: no se ha seleccionado un material de referencia.");
                return false;
            }
            if (Convert.ToDecimal(tbDilution2.EditValue) <= 0 || Convert.ToDecimal(tbDilution3.EditValue) <= 0)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: No es posible asignar el botón '0' como valor de dilución.");
                return false;
            }
            if (Convert.ToDecimal(tbDilution2.EditValue) == 1
                && Convert.ToDecimal(tbDilution3.EditValue) >= 0
                && Convert.ToDecimal(tbDilution3.EditValue) != 1)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: Si tiene dilución 3 no puede obviar la dilución 2.");
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
            if (tbRexp2.Value <= 0)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: el valor de R2 debe ser mayor a 0.");
                return false;
            }
            if (cbTypePattern.EditValue == null)// && cbMrcOrPattern.EditValue == null)//if (cbTypePattern.EditValue != null && cbMrcOrPattern.EditValue == null)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: No ha seleccionado el valor del Mr o Patrón.");
                return false;
            }
            if (ckSolInterm.Checked && cbSolIntermType.EditValue == null)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: No ha seleccionado la solución intermedia.");
                return false;
            }
            if (ckSolInterm.Checked && cbSolIntermType.EditValue != null
                && (tbSolIntermConcen.Text.Trim().Length == 0 || tbSolIntermConcen.Value == 0))
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: No ingresado laconcentración para la solución intermedia.");
                return false;
            }
            if ((cbMedium.EditValue != null || Convert.ToInt32(cbMedium.EditValue) != 0) && tbMediumConc.Value == 0)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: No ha ingresado la concentración del medio.");
                return false;
            }
            if ((cbModif.EditValue != null || Convert.ToInt32(cbModif.EditValue) != 0) && tbModifConc.Value == 0)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: No ha ingresado la concentración del modificador.");
                return false;
            }
            if (tbValidity_calib.Value == 0)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: No ha ingresado la validez de calibración.");
                return false;
            }
            if (cbStdType_pattern.EditValue == null) //if (cbStdType_pattern.EditValue != null && cbStdMrcOrPattern.EditValue == null)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: No ha ingresado el patrón de solución.");
                return false;
            }
            if (ckStdSolIntermOne.Checked && Convert.ToInt32(tbStdConcenOne.EditValue) < 0)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: El valor de la solución intermedia 1 no es correcta.");
                return false;
            }
            if (ckStdSolIntermTwo.Checked && Convert.ToInt32(tbStdConcenTwo.EditValue) < 0)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: El valor de la solución intermedia 2 no es correcta.");
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
                        tbVolumen.Value = Convert.ToDecimal(oTemplate_method_aa.Volumen);
                        tbReading_min.Value = Convert.ToDecimal(oTemplate_method_aa.Reading_min);
                        tbReading_max.Value = Convert.ToDecimal(oTemplate_method_aa.Reading_max);
                        tbDilution2.Value = Convert.ToDecimal(oTemplate_method_aa.Dilution2);
                        tbDilution3.Value = Convert.ToDecimal(oTemplate_method_aa.Dilution3);
                        tbReason_rep.Value = Convert.ToDecimal(oTemplate_method_aa.Reason_rep);
                        tbError_allowed.Value = Convert.ToDecimal(oTemplate_method_aa.Error_allowed);
                        tbSymbol.Text = oTemplate_method_aa.Symbol;
                        tbLaw_limit_bottom.Value = Convert.ToDecimal(oTemplate_method_aa.Law_limit_bottom);
                        tbLaw_limit_top.Value = Convert.ToDecimal(oTemplate_method_aa.Law_limit_top);
                        tbAbs.Value = Convert.ToDecimal(oTemplate_method_aa.Absorvance);
                        tbAbs_incertitude.Value = Convert.ToDecimal(oTemplate_method_aa.Abs_incertitude);
                        tbStd_verif.Value = Convert.ToDecimal(oTemplate_method_aa.Std_verif);
                        tbStd_verif_incertitude.Value = Convert.ToDecimal(oTemplate_method_aa.Std_verif_incertitude);
                        tbWave_long.Value = Convert.ToDecimal(oTemplate_method_aa.Wave_long);
                        tbReproducibility.Value = Convert.ToDecimal(oTemplate_method_aa.Reproducibility);
                        tbNum_decimal.Value = Convert.ToDecimal(oTemplate_method_aa.Num_decimal);
                        tbBlk_max.Value = Convert.ToDecimal(oTemplate_method_aa.Blk_max);
                        deDate_allowed_error.DateTime = Convert.ToDateTime(oTemplate_method_aa.Date_allowed_error);

                        cbMaterialRef.EditValue = oTemplate_method_aa.Idmr_detail;
                        cbUnit_calib.EditValue = oTemplate_method_aa.Idunit_calib;

                        cbMrcOrPattern.EditValue = Convert.ToInt16(oTemplate_method_aa.Mrorpattern);
                        tbRexp2.Value = Convert.ToDecimal(oTemplate_method_aa.Rexp2);
                        tbNum_days.Value = Convert.ToInt16(oTemplate_method_aa.Num_days);
                        tbNum_samples.Value = Convert.ToInt16(oTemplate_method_aa.Num_samples);
                        cbUnit_result.EditValue = oTemplate_method_aa.Idunit_result;
                        tbLimit_samples.EditValue = oTemplate_method_aa.Limit_samples;

                        /// medio de matriz
                        cbMedium.EditValue = oTemplate_method_aa.Medium;
                        if (oTemplate_method_aa.Medium == null)
                        {
                            tbMediumConc.Enabled = false;
                            tbMediumConc.Value = 0;
                        }
                        else
                        {
                            tbMediumConc.Enabled = true;
                            tbMediumConc.Value = Convert.ToDecimal(oTemplate_method_aa.Medium_conc);
                        }

                        /// modificador de matriz
                        cbModif.EditValue = oTemplate_method_aa.Modif;
                        if (oTemplate_method_aa.Modif == null)
                        {
                            tbModifConc.Enabled = false;
                            tbModifConc.Value = Convert.ToDecimal(oTemplate_method_aa.Modif_conc);
                        }
                        else
                        {
                            tbModifConc.Enabled = true;
                            tbModifConc.Value = Convert.ToDecimal(oTemplate_method_aa.Modif_conc);
                        }

                        tbValidity_calib.Value = Convert.ToDecimal(oTemplate_method_aa.Validity_calib);

                        cbTypePattern.EditValue = oTemplate_method_aa.Type_pattern;
                        ckSolInterm.Checked = Convert.ToBoolean(oTemplate_method_aa.Flag_sol_intermedia);
                        //cbSolIntermType.EditValue = oTemplate_method_aa.Sol_intermedia;                        



                        if (oTemplate_method_aa.Flag_sol_intermedia == true
                            && oTemplate_method_aa.Sol_concentration != null)
                            tbSolIntermConcen.Value = Convert.ToInt32(oTemplate_method_aa.Sol_concentration);

                        if (oTemplate_method_aa.Type_pattern == 1 || oTemplate_method_aa.Type_pattern == 2)
                            cbMrcOrPattern.EditValue = oTemplate_method_aa.Mrorpattern;

                        cbSolStatus.EditValue = Convert.ToBoolean(oTemplate_method_aa.Std_status);
                        deDatePreparation.DateTime = Convert.ToDateTime(oTemplate_method_aa.Sol_date_preparation);
                        deDateExpiration.DateTime = Convert.ToDateTime(oTemplate_method_aa.Sol_date_expiration);
                        cbStdType_pattern.EditValue = oTemplate_method_aa.Std_type_pattern;
                        cbStdMrcOrPattern.EditValue = oTemplate_method_aa.Std_mrorpattern;
                        ckStdSolIntermOne.Checked = Convert.ToBoolean(oTemplate_method_aa.Std_flag_sol_intermedia1);
                        ckStdSolIntermTwo.Checked = Convert.ToBoolean(oTemplate_method_aa.Std_flag_sol_intermedia2);
                        tbStdConcentration.EditValue = oTemplate_method_aa.Std_concentration;
                        tbStdConcenOne.EditValue = oTemplate_method_aa.Std_concentration_sol1;
                        tbStdConcenTwo.EditValue = oTemplate_method_aa.Std_concentration_sol2;
                        tbStdValidity.Value = Convert.ToInt16(oTemplate_method_aa.Std_validity);
                        cbStdSolStatus.EditValue = Convert.ToBoolean(oTemplate_method_aa.Std_status);
                        deStdDatePreparation.DateTime = Convert.ToDateTime(oTemplate_method_aa.Std_date_preparation);
                        deStdDateExpiration.DateTime = Convert.ToDateTime(oTemplate_method_aa.Std_date_expiration);
                        tbMediumSol1.Value = Convert.ToDecimal(oTemplate_method_aa.Std_sol1_medium);
                        tbMediumSol2.Value = Convert.ToDecimal(oTemplate_method_aa.Std_sol2_medium);
                        tbMediumStdVerif.Value = Convert.ToDecimal(oTemplate_method_aa.Std_stdverif_medium);

                        // --- recuperate
                        CCalibFactory faCalib = new CCalibFactory();
                        gcCalibracion.DataSource = new BindingList<CCalib>(faCalib.GetAll().Where(x => x.Idtemplate_method == oTemplate_Method.Idtemplate_method).ToList());                        
                        
                    }
                }
                else
                {
                    // --- recuperate 
                    CCalibFactory faCalib = new CCalibFactory();
                    gcCalibracion.DataSource = new BindingList<CCalib>(faCalib.GetAll().Where(x => x.Idtemplate_method == 0).ToList());
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
                oTemplate_method_aa.Volumen = tbVolumen.Value;
                oTemplate_method_aa.Reading_min = tbReading_min.Value;
                oTemplate_method_aa.Reading_max = tbReading_max.Value;
                oTemplate_method_aa.Dilution2 = tbDilution2.Value;
                oTemplate_method_aa.Dilution3 = tbDilution3.Value;
                oTemplate_method_aa.Reason_rep = tbReason_rep.Value;
                oTemplate_method_aa.Error_allowed = tbError_allowed.Value;
                oTemplate_method_aa.Symbol = tbSymbol.Text;
                oTemplate_method_aa.Law_limit_bottom = tbLaw_limit_bottom.Value;
                oTemplate_method_aa.Law_limit_top = tbLaw_limit_top.Value;
                oTemplate_method_aa.Idunit_calib = Convert.ToInt16(cbUnit_calib.EditValue);
                oTemplate_method_aa.Absorvance = tbAbs.Value;
                oTemplate_method_aa.Abs_incertitude = tbAbs_incertitude.Value;
                oTemplate_method_aa.Std_verif = tbStd_verif.Value;
                oTemplate_method_aa.Std_verif_incertitude = tbStd_verif_incertitude.Value;
                oTemplate_method_aa.Wave_long = tbWave_long.Value;
                oTemplate_method_aa.Idmr_detail = Convert.ToInt16(cbMaterialRef.EditValue);
                oTemplate_method_aa.Blk_max = tbBlk_max.Value;
                oTemplate_method_aa.Reason_rep = tbReason_rep.Value;
                oTemplate_method_aa.Reproducibility = tbReproducibility.Value;
                oTemplate_method_aa.Num_decimal = Convert.ToInt16(tbNum_decimal.Value);
                oTemplate_method_aa.Date_allowed_error = Convert.ToDateTime(deDate_allowed_error.EditValue);
                oTemplate_method_aa.Rexp2 = tbRexp2.Value;
                oTemplate_method_aa.Validity_calib = Convert.ToInt16(tbValidity_calib.Value);

                if (cbTypePattern.EditValue != null)
                    oTemplate_method_aa.Type_pattern = Convert.ToInt32(cbTypePattern.EditValue);

                if (oTemplate_method_aa.Type_pattern == 1
                    || oTemplate_method_aa.Type_pattern == 2) // mrc                        
                    oTemplate_method_aa.Mrorpattern = Convert.ToInt16(cbMrcOrPattern.EditValue);

                if (oTemplate_method_aa.Type_pattern == 3) // solucion
                {
                    oTemplate_method_aa.Flag_sol_intermedia = ckSolInterm.Checked;
                    oTemplate_method_aa.Sol_concentration = tbSolIntermConcen.Value;
                }

                if (cbMedium.EditValue != null)
                {
                    oTemplate_method_aa.Medium = Convert.ToInt32(cbMedium.EditValue);
                    oTemplate_method_aa.Medium_conc = Convert.ToDecimal(tbMediumConc.Value);
                }

                if (cbModif.EditValue != null)
                {
                    oTemplate_method_aa.Modif = Convert.ToInt32(cbModif.EditValue);
                    oTemplate_method_aa.Modif_conc = Convert.ToDecimal(tbModifConc.Value);
                }

                oTemplate_method_aa.Sol_status = Convert.ToBoolean(cbSolStatus.EditValue);

                oTemplate_method_aa.Std_mrorpattern = Convert.ToInt32(cbStdMrcOrPattern.EditValue);
                oTemplate_method_aa.Std_type_pattern = Convert.ToInt32(cbStdType_pattern.EditValue);
                oTemplate_method_aa.Std_flag_sol_intermedia1 = ckStdSolIntermOne.Checked;
                oTemplate_method_aa.Std_flag_sol_intermedia2 = ckStdSolIntermTwo.Checked;
                oTemplate_method_aa.Std_concentration = Convert.ToDecimal(tbStdConcentration.EditValue);
                oTemplate_method_aa.Std_concentration_sol1 = Convert.ToDecimal(tbStdConcenOne.EditValue);
                oTemplate_method_aa.Std_concentration_sol2 = Convert.ToDecimal(tbStdConcenTwo.EditValue);
                oTemplate_method_aa.Std_validity = Convert.ToInt16(tbStdValidity.EditValue);
                oTemplate_method_aa.Std_status = Convert.ToBoolean(cbStdSolStatus.EditValue);
                oTemplate_method_aa.Std_sol1_medium = tbMediumSol1.Value;
                oTemplate_method_aa.Std_sol2_medium = tbMediumSol2.Value;
                oTemplate_method_aa.Std_stdverif_medium = tbMediumStdVerif.Value;
                oTemplate_method_aa.Idunit_result = Convert.ToInt16(cbUnit_result.EditValue);
                oTemplate_method_aa.Num_days = Convert.ToInt16(tbNum_days.Value);
                oTemplate_method_aa.Num_samples = Convert.ToInt16(tbNum_samples.Value);
                oTemplate_method_aa.Limit_samples = Convert.ToInt16(tbLimit_samples.Value);

                if (!(result_template_method_aa = faTemplate_method_aa.Update(oTemplate_method_aa)))
                {
                    oTemplate_method_aa.Date_allowed_error = DateTime.Now;
                    result_template_method_aa = faTemplate_method_aa.Insert(oTemplate_method_aa);
                }

                if (result_template_method_aa)
                {
                    for (int i = 0; i < gvCalibracion.RowCount; i++)
                    {
                        CCalibFactory faCalib = new CCalibFactory();
                        CCalib oCalib = gvCalibracion.GetRow(i) as CCalib;
                        oCalib.Idtemplate_method = oTemplate_Method.Idtemplate_method;

                        if (!faCalib.Update(oCalib))
                            faCalib.Insert(oCalib);
                    }
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
            cbUnit_calib.EditValue = null;            
            tbWeight.Value = 0;
            tbWeight_incertitude.Value = 0;
            tbVolumen.Value = 0;
            tbDilution2.Value = 1;
            tbDilution3.Value = 1;
            tbReading_min.Value = 0;
            tbReading_max.Value = 0;
            tbReason_rep.Value = 0;
            tbError_allowed.Value = 0;
            tbLaw_limit_bottom.Value = 0;
            tbLaw_limit_top.Value = 0;
            tbStd_verif.Value = 0;
            tbStd_verif_incertitude.Value = 0;
            tbAbs.Value = 0;
            tbAbs_incertitude.Value = 0;
            tbWave_long.Value = 0;
            tbBlk_max.Value = 0;
            tbReproducibility.Value = 0;
            tbNum_decimal.Value = 0;
            tbLawMri.EditValue = null;
            tbLimit_samples.Value = 12;           
            deDate_allowed_error.DateTime = DateTime.Now;
            tbNum_days.EditValue = null;
            tbNum_samples.EditValue = null;
            gcCalibracion.DataSource = null;
            gcCalibracion.DataSource =
                new BindingList<CCalib>(
                    new CCalibFactory().GetAll().Where(x => x.Idtemplate_method == 0).ToList());

            cbMrcOrPattern.EditValue = null;
            tbRexp2.Value = 0;

            cbMedium.EditValue = null;
            tbMediumConc.Value = 0;
            tbMediumConc.Enabled = false;

            cbModif.EditValue = null;
            tbModifConc.Value = 0;
            tbModifConc.Enabled = false;
            ckSolInterm.Checked = false;
            tbValidity_calib.Value = 0;
        }

        private void gvCalibracion_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvCalibracion.SetRowCellValue(e.RowHandle, gcCal_Order, getCorrelativeCalib() + 1);
            gvCalibracion.SetRowCellValue(e.RowHandle, gcCal_Nom_Calib, "Std" + (getCorrelativeCalib() + 1).ToString());
            gvCalibracion.SetRowCellValue(e.RowHandle, gcCal_Concentration, 0);
        }

        private void gvCalibracion_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == gcCal_Volumen)
            {
                if (tbConcentration.Text.Trim() != ""
                    && gvCalibracion.GetFocusedRowCellValue(gcCal_Concentration) != null
                    && gvCalibracion.GetFocusedRowCellValue(gcCal_Concentration).ToString().Trim() != ""
                    && gvCalibracion.GetFocusedRowCellValue(gcCal_Volumen) != null
                    && gvCalibracion.GetFocusedRowCellValue(gcCal_Volumen).ToString().Trim() != "")
                {
                    decimal volumen = Convert.ToDecimal(gvCalibracion.GetFocusedRowCellValue(gcCal_Volumen));
                    decimal concentration = Convert.ToDecimal(gvCalibracion.GetFocusedRowCellValue(gcCal_Concentration));

                    // --- selecciona una concentración patrón 
                    decimal concentration_pattern = 0;
                    if (ckSolInterm.Checked)
                        concentration_pattern = Convert.ToDecimal(tbSolIntermConcen.Value);
                    else
                        concentration_pattern = Convert.ToDecimal(tbConcentration.Text);


                    // --- calcular el volumen
                    if (Convert.ToInt32(cbTypePattern.EditValue) == 1)
                    {
                        // peso = volumen * concentracion pedida / concentracion total
                        decimal weight = volumen * concentration / concentration_pattern;
                        gvCalibracion.SetFocusedRowCellValue(gcCal_Aliquot, Math.Round(weight, 5));
                    }
                    if (Convert.ToInt32(cbTypePattern.EditValue) == 2
                        && Convert.ToInt32(cbTypePattern.EditValue) == 3)
                    {
                        // alicuota = volumen / (concentracion pedida / concentracion total)
                        decimal aliquot = volumen / (concentration / concentration_pattern);
                        gvCalibracion.SetFocusedRowCellValue(gcCal_Aliquot, Math.Round(aliquot, 5));
                    }
                }
            }
        }

        private void cbGroupSol_SelectedIndexChanged(object sender, EventArgs e)
        {
            // --- mostrar mrc o patron de soluciones
            if (cbTypePattern.SelectedIndex == 0)
            {
                if (IDElement != null)
                {
                    ModSolution oModSolution = new ModSolution();

                    cbMrcOrPattern.Properties.DataSource = oModSolution.GetLstMrc(Convert.ToInt16(IDElement));
                    cbMrcOrPattern.Properties.DisplayMember = "Name";
                    cbMrcOrPattern.Properties.ValueMember = "Idmr_detail";

                    cbMrcOrPattern.EditValue = null;

                    tbConcentration.Text = "";
                }
            }
            if (cbTypePattern.SelectedIndex == 1)
            {
                if (IDElement != null)
                {
                    ModSolution oModSolution = new ModSolution();

                    cbMrcOrPattern.Properties.DataSource = oModSolution.GetLstPatron(Convert.ToInt16(IDElement));
                    cbMrcOrPattern.Properties.DisplayMember = "Name";
                    cbMrcOrPattern.Properties.ValueMember = "Idmr_detail";

                    cbMrcOrPattern.EditValue = null;

                    tbConcentration.Text = "";
                }
            }
            if (cbTypePattern.SelectedIndex == 2)
            {
                if (IDElement != null)
                {
                    ModSolution oModSolution = new ModSolution();

                    cbMrcOrPattern.Properties.DataSource = oModSolution.GetLstSolutions(Convert.ToInt16(IDElement));
                    cbMrcOrPattern.Properties.DisplayMember = "Name";
                    cbMrcOrPattern.Properties.ValueMember = "Idsolution";

                    cbMrcOrPattern.EditValue = null;

                    tbConcentration.Text = "";
                }
            }
        }

        private void cbMrcOrPattern_EditValueChanged(object sender, EventArgs e)
        {
            // --- recuperar concentración

            if (cbMrcOrPattern.EditValue != null && cbTypePattern.EditValue != null
                && (Convert.ToInt16(cbTypePattern.EditValue) == 0 || Convert.ToInt16(cbTypePattern.EditValue) == 1))
            {
                ModSolution oModSolution = new ModSolution();
                tbConcentration.Text = oModSolution.GetConcentrationPPM(Convert.ToInt16(cbMrcOrPattern.EditValue)).ToString();
            }
        }        

        private void cbMedium_EditValueChanged(object sender, EventArgs e)
        {
            if (cbMedium.EditValue != null && Convert.ToInt32(cbMedium.EditValue) == 0)
            {
                cbMedium.EditValue = null;
                tbMediumConc.Enabled = false;
            }
            else if (cbMedium.EditValue != null && Convert.ToInt32(cbMedium.EditValue) > 0)
                tbMediumConc.Enabled = true;
        }

        private void cbModif_EditValueChanged(object sender, EventArgs e)
        {
            if (cbModif.EditValue != null && Convert.ToInt32(cbModif.EditValue) == 0)
            {
                cbModif.EditValue = null;
                tbModifConc.Enabled = false;
            }
            else if (cbModif.EditValue != null && Convert.ToInt32(cbModif.EditValue) > 0)
                tbModifConc.Enabled = true;
        }

        private void cbStdType_pattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            // --- mostrar mrc o patron de soluciones
            if (cbStdType_pattern.SelectedIndex == 0)
            {
                if (IDElement != null)
                {
                    ModSolution oModSolution = new ModSolution();

                    cbStdMrcOrPattern.Properties.DataSource = oModSolution.GetLstMrc(Convert.ToInt16(IDElement));
                    cbStdMrcOrPattern.Properties.DisplayMember = "Name";
                    cbStdMrcOrPattern.Properties.ValueMember = "Idmr_detail";
                    cbStdMrcOrPattern.EditValue = null;

                    tbStdConcentration.Text = "";
                }
            }
            if (cbStdType_pattern.SelectedIndex == 1)
            {
                if (IDElement != null)
                {
                    ModSolution oModSolution = new ModSolution();

                    cbStdMrcOrPattern.Properties.DataSource = oModSolution.GetLstPatron(Convert.ToInt16(IDElement));
                    cbStdMrcOrPattern.Properties.DisplayMember = "Name";
                    cbStdMrcOrPattern.Properties.ValueMember = "Idmr_detail";

                    cbStdMrcOrPattern.EditValue = null;

                    tbStdConcentration.Text = "";
                }
            }
            if (cbStdType_pattern.SelectedIndex == 2)
            {
                if (IDElement != null)
                {
                    ModSolution oModSolution = new ModSolution();

                    cbStdMrcOrPattern.Properties.DataSource = oModSolution.GetLstSolutions(Convert.ToInt16(IDElement));
                    cbStdMrcOrPattern.Properties.DisplayMember = "Name";
                    cbStdMrcOrPattern.Properties.ValueMember = "Idsolution";

                    cbStdMrcOrPattern.EditValue = null;

                    tbStdConcentration.Text = "";
                }
            }
        }

        private void cbStdMrcOrPattern_EditValueChanged(object sender, EventArgs e)
        {
            // --- recuperar concentración

            if (cbStdMrcOrPattern.EditValue != null && cbStdType_pattern.EditValue != null
                && (Convert.ToInt16(cbStdType_pattern.EditValue) == 1 || Convert.ToInt16(cbStdType_pattern.EditValue) == 2))
            {
                ModSolution oModSolution = new ModSolution();
                tbStdConcentration.Text = oModSolution.GetConcentrationPPM(Convert.ToInt16(cbStdMrcOrPattern.EditValue)).ToString();
            }
        }

        private void ckStdSolIntermOne_CheckedChanged(object sender, EventArgs e)
        {
            tbStdConcenOne.Enabled = ckStdSolIntermOne.Checked;
        }

        private void ckStdSolIntermTwo_CheckedChanged(object sender, EventArgs e)
        {
            tbStdConcenTwo.Enabled = ckStdSolIntermTwo.Checked;
        }

        private void tbStd_verif_EditValueChanged(object sender, EventArgs e)
        {
            tbStd_verif2.Text = tbStd_verif.Text;
        }

        private void cbTypePattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            // --- mostrar mrc o patron de soluciones
            if (cbTypePattern.SelectedIndex == 0)
            {
                if (IDElement != null)
                {
                    ModSolution oModSolution = new ModSolution();

                    cbMrcOrPattern.Properties.DataSource = oModSolution.GetLstMrc(Convert.ToInt16(IDElement));
                    cbMrcOrPattern.Properties.DisplayMember = "Name";
                    cbMrcOrPattern.Properties.ValueMember = "Idmr_detail";

                    cbMrcOrPattern.EditValue = null;

                    tbConcentration.Text = "";
                }
            }
            if (cbTypePattern.SelectedIndex == 1)
            {
                if (IDElement != null)
                {
                    ModSolution oModSolution = new ModSolution();

                    cbMrcOrPattern.Properties.DataSource = oModSolution.GetLstPatron(Convert.ToInt16(IDElement));
                    cbMrcOrPattern.Properties.DisplayMember = "Name";
                    cbMrcOrPattern.Properties.ValueMember = "Idmr_detail";

                    cbMrcOrPattern.EditValue = null;

                    tbConcentration.Text = "";
                }
            }
            if (cbTypePattern.SelectedIndex == 2)
            {
                if (IDElement != null)
                {
                    ModSolution oModSolution = new ModSolution();

                    cbMrcOrPattern.Properties.DataSource = oModSolution.GetLstSolutions(Convert.ToInt16(IDElement));
                    cbMrcOrPattern.Properties.DisplayMember = "Name";
                    cbMrcOrPattern.Properties.ValueMember = "Idsolution";

                    cbMrcOrPattern.EditValue = null;

                    tbConcentration.Text = "";
                }
            }
        }

        private void cbMaterialRef_EditValueChanged(object sender, EventArgs e)
        {
            CMr_detailFactory faMr_detail = new CMr_detailFactory();
            CMr_detail oMr_detail = faMr_detail.GetByPrimaryKey(
                new CMr_detailKeys(Convert.ToInt16(cbMaterialRef.EditValue)));
            if (oMr_detail != null)
                tbLawMri.Text = oMr_detail.Nominal_value.ToString();
        }

        private void ckSolInterm_CheckedChanged(object sender, EventArgs e)
        {
            tbSolIntermConcen.Enabled = ckSolInterm.Checked;
            cbSolIntermType.Enabled = ckSolInterm.Checked;
        }

        private void tbSolIntermConcen_EditValueChanged(object sender, EventArgs e)
        {
            if (tbConcentration.Text.Trim() != ""
                    && gvCalibracion.GetFocusedRowCellValue(gcCal_Concentration) != null
                    && gvCalibracion.GetFocusedRowCellValue(gcCal_Concentration).ToString().Trim() != ""
                    && gvCalibracion.GetFocusedRowCellValue(gcCal_Volumen) != null
                    && gvCalibracion.GetFocusedRowCellValue(gcCal_Volumen).ToString().Trim() != "")
            {
                decimal volumen = Convert.ToDecimal(gvCalibracion.GetFocusedRowCellValue(gcCal_Volumen));
                decimal concentration = Convert.ToDecimal(gvCalibracion.GetFocusedRowCellValue(gcCal_Concentration));
                decimal concentration_pattern;

                if ((ckSolInterm.Checked && cbSolIntermType.EditValue != null && tbSolIntermConcen.Text.Length > 0)
                    || cbTypePattern.EditValue != null && cbMrcOrPattern.EditValue != null)
                {
                    if (ckSolInterm.Checked && cbSolIntermType.EditValue != null)
                        concentration_pattern = Convert.ToDecimal(tbSolIntermConcen.Value);
                    else
                        concentration_pattern = Convert.ToDecimal(tbConcentration.Text);

                    // --- recorrer filas para actualizar datos
                    for (int i = 0; i < gvCalibracion.RowCount; i++)
                    {
                        // --- calcular el volumen
                        if (Convert.ToInt32(cbTypePattern.EditValue) == 1)
                        {
                            // peso = volumen * concentracion pedida / concentracion total
                            decimal weight = volumen * concentration / concentration_pattern;
                            gvCalibracion.SetRowCellValue(i, gcCal_Aliquot, Math.Round(weight, 5));
                        }
                        if (Convert.ToInt32(cbTypePattern.EditValue) == 2
                            && Convert.ToInt32(cbTypePattern.EditValue) == 3)
                        {
                            // alicuota = volumen / (concentracion pedida / concentracion total)
                            decimal aliquot = volumen / (concentration / concentration_pattern);
                            gvCalibracion.SetRowCellValue(i, gcCal_Aliquot, Math.Round(aliquot, 5));
                        }
                    }
                }
            }
        }
        
        private void tbConcentration_EditValueChanged(object sender, EventArgs e)
        {
            if (tbConcentration.Text.Trim() != ""
                    && gvCalibracion.GetFocusedRowCellValue(gcCal_Concentration) != null
                    && gvCalibracion.GetFocusedRowCellValue(gcCal_Concentration).ToString().Trim() != ""
                    && gvCalibracion.GetFocusedRowCellValue(gcCal_Volumen) != null
                    && gvCalibracion.GetFocusedRowCellValue(gcCal_Volumen).ToString().Trim() != "")
            {
                decimal volumen = Convert.ToDecimal(gvCalibracion.GetFocusedRowCellValue(gcCal_Volumen));
                decimal concentration = Convert.ToDecimal(gvCalibracion.GetFocusedRowCellValue(gcCal_Concentration));
                decimal concentration_pattern = Convert.ToDecimal(tbConcentration.Text);

                for (int i = 0; i < gvCalibracion.RowCount; i++)
                {
                    // --- calcular el volumen
                    if (Convert.ToInt32(cbTypePattern.EditValue) == 1)
                    {
                        // peso = volumen * concentracion pedida / concentracion total
                        decimal weight = volumen * concentration / concentration_pattern;
                        gvCalibracion.SetRowCellValue(i, gcCal_Aliquot, Math.Round(weight, 5));
                    }
                    if (Convert.ToInt32(cbTypePattern.EditValue) == 2
                        && Convert.ToInt32(cbTypePattern.EditValue) == 3)
                    {
                        // alicuota = volumen / (concentracion pedida / concentracion total)
                        decimal aliquot = volumen / (concentration / concentration_pattern);
                        gvCalibracion.SetRowCellValue(i, gcCal_Aliquot, Math.Round(aliquot, 5));
                    }
                }
            }
        }

        int getCorrelativeCalib()
        {
            int max = 0;
            for (int i = 0; i < gvCalibracion.RowCount; i++)
            {
                if (Convert.ToInt32(gvCalibracion.GetRowCellValue(i, gcCal_Order)) > max)
                {
                    max = Convert.ToInt32(gvCalibracion.GetRowCellValue(i, gcCal_Order));
                }
            }
            return max;
        }

        public void RefreshByElement(short pIdelement)
        {
            IDElement = pIdelement;
            Methods oMethods = new Methods();
            cbMaterialRef.Properties.DataSource = oMethods.GetByElement(Convert.ToInt16(IDElement));
            cbMaterialRef.Properties.DisplayMember = "Cod_mr";
            cbMaterialRef.Properties.ValueMember = "Idmr_detail";
        }

        public Comun.MethodSaveProperty GetResultTestAA()
        {
            // --- registro anterior
            if (IDTemplate_Method <= 0)
            {
                return Comun.MethodSaveProperty.NewMethod;
            }
            else
            {                
                CTemplate_method_aa oTemplate_method_aa = new CTemplate_method_aa();
                CTemplate_method_aaFactory faTemplate_method_aa = new CTemplate_method_aaFactory();
                oTemplate_method_aa = faTemplate_method_aa.GetByPrimaryKey(new CTemplate_method_aaKeys(Convert.ToInt32(IDTemplate_Method)));
                
                if (oTemplate_method_aa.Wave_long != tbWave_long.Value)
                    return Comun.MethodSaveProperty.InspectionNewMethod;

                // --- change inside details, require new version
                if (oTemplate_method_aa.Abs_incertitude != tbAbs_incertitude.Value)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Absorvance != tbAbs.Value)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Blk_max != tbBlk_max.Value)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Date_allowed_error != deDate_allowed_error.DateTime)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Dilution2 != tbDilution2.Value)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Dilution3 != tbDilution3.Value)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Idmr_detail != Convert.ToInt16(cbMaterialRef.EditValue))
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Idunit_calib != Convert.ToInt16(cbUnit_calib.EditValue))
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Idunit_result != Convert.ToInt16(cbUnit_result.EditValue))
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Law_limit_bottom != tbLaw_limit_bottom.Value)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Law_limit_top != tbLaw_limit_top.Value)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Reproducibility != tbReproducibility.Value)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Std_verif != tbStd_verif.Value)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Std_verif_incertitude != tbStd_verif_incertitude.Value)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Symbol != tbSymbol.Text)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Weight != tbWeight.Value)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Weight_incertitude != tbWeight_incertitude.Value)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Reason_rep != tbReason_rep.Value)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Reading_min != tbReading_min.Value)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Reading_max != tbReading_max.Value)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Volumen != tbVolumen.Value)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Num_decimal != tbNum_decimal.Value)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Num_days != tbNum_days.Value)
                    return Comun.MethodSaveProperty.InspectionNewVersion;
                if (oTemplate_method_aa.Num_samples != tbNum_samples.Value)
                    return Comun.MethodSaveProperty.InspectionNewVersion;

                return Comun.MethodSaveProperty.Nothing;
            }
        }
    }
}
