using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LimsProject.BusinessLayer;

namespace LimsProject
{
    public partial class FormMethod
    {

        Comun.MethodSaveProperty RequireNewVersionOrMethod(Comun.TypeAnalysis type_analysis)
        {
            Comun.MethodSaveProperty result = Comun.MethodSaveProperty.Nothing;
            switch (type_analysis)
            {
                case Comun.TypeAnalysis.AbsorcionAtomica:
                    result = GetResultTestHeader();
                    break;
            }
            return result;
        }

        Comun.MethodSaveProperty GetResultTestHeader()
        {
            // --- registro anterior
            if (IDTemplate_Method <= 0)
            {
                return Comun.MethodSaveProperty.NewMethod;
            }
            else
            {
                CTemplate_methodFactory faTemplate_method = new CTemplate_methodFactory();
                CTemplate_method oTemplate_method = new CTemplate_method();
                oTemplate_method = faTemplate_method.GetByPrimaryKey(new CTemplate_methodKeys(IDTemplate_Method));

                CTemplate_method_aa oTemplate_method_aa = new CTemplate_method_aa();
                CTemplate_method_aaFactory faTemplate_method_aa = new CTemplate_method_aaFactory();
                oTemplate_method_aa = faTemplate_method_aa.GetByPrimaryKey(new CTemplate_method_aaKeys(IDTemplate_Method));

                // --- change inside head, require new method
                if (oTemplate_method.Idelement != Convert.ToInt16(cbElement.EditValue))
                    return Comun.MethodSaveProperty.InspectionNewMethod;
                if (oTemplate_method.Cod_type_sample != cbTypeSample.EditValue.ToString())
                    return Comun.MethodSaveProperty.InspectionNewMethod;
                if (oTemplate_method.Type_analisys != Convert.ToChar(cbTypeAnalysis.EditValue))
                    return Comun.MethodSaveProperty.InspectionNewMethod;
                if (oTemplate_method.Cod_template_method != gluCod_method.Text)
                    return Comun.MethodSaveProperty.InspectionNewMethod;
                //if (oTemplate_method.Abbreviation != tbAbreviation.Text)
                //    return Comun.MethodSaveProperty.InspectionNewMethod;
                //if (oTemplate_method.Title != tbTitle.Text)
                //    return Comun.MethodSaveProperty.InspectionNewMethod;
                //if (oTemplate_method.Recognized != ckRecognized.Checked)
                //    return Comun.MethodSaveProperty.InspectionNewMethod;
                if (oTemplate_method.Cod_digestion_method != cbDigestion.EditValue.ToString())
                    return Comun.MethodSaveProperty.InspectionNewMethod;
                //if (Convert.ToDecimal(oTemplate_method.Cost_method) != tbCost_Method.Value)
                //    return Comun.MethodSaveProperty.InspectionNewMethod;
                if (Convert.ToInt16(oTemplate_method.Cod_repetition) != Convert.ToInt16(cbRepetition.EditValue))
                    return Comun.MethodSaveProperty.InspectionNewMethod;                
                
                return Comun.MethodSaveProperty.Nothing;
            }
        }
    }
}
