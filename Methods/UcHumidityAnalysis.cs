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

namespace LimsProject
{
    public partial class UcHumidityAnalysis : UserControl
    {
        public int? IDTemplate_Method { get; set; }
        CTemplate_method oTemplate_Method = new CTemplate_method();
        public short? IDElement { get; set; }    

        public UcHumidityAnalysis()
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
            }
            catch (Exception ex)
            {
                Comun.Send_message(this.Text, TypeMsg.error, ex.Message);
            }
            #endregion
        }

        public bool Son_Datos_Correctos()
        {
            if (tbSymbol.Text.Trim().Length == 0)
            {
                Comun.Send_message("Analisis de Humedad", TypeMsg.error, "No se ingreso el simbolo del análisis");
                return false;
            }
            if (cbUnit_result.EditValue == null)
            {
                Comun.Send_message("Analisis de Humedad", TypeMsg.error, "No se ingresó la unidad de medida.");
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
                    CTemplate_method_ah oTemplate_method_ah = new CTemplate_method_ah();
                    CTemplate_method_ahFactory faTemplate_method_aa = new CTemplate_method_ahFactory();
                    oTemplate_method_ah = faTemplate_method_aa.GetByPrimaryKey(new CTemplate_method_ahKeys(Convert.ToInt32(IDTemplate_Method)));

                    if (oTemplate_method_ah != null)
                    {
                        oTemplate_method_ah.Idtemplate_method = oTemplate_Method.Idtemplate_method;
                        cbUnit_result.EditValue = oTemplate_method_ah.Idunit_result;
                        tbSymbol.Text = oTemplate_method_ah.Symbol;
                        cbUnit_result.EditValue = oTemplate_method_ah.Idunit_result;
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
            IDTemplate_Method = pIdtemplate_method;

            if (IDTemplate_Method != null && IDTemplate_Method > 0)
            {
                CTemplate_method_ah template_method_ah = new CTemplate_method_ah();
                template_method_ah.Idtemplate_method = Convert.ToInt32(IDTemplate_Method);
                template_method_ah.Idunit_result = Convert.ToInt16(cbUnit_result.EditValue);
                template_method_ah.Symbol = tbSymbol.Text;

                bool result;
                if (!(result = new CTemplate_method_ahFactory().Update(template_method_ah)))
                    result = new CTemplate_method_ahFactory().Insert(template_method_ah);

                return result;
            }
            return false;
        }

        public void Limpiar_Campos()
        {
            tbSymbol.Text = "";
            cbUnit_result.EditValue = null;
        }
    }
}
