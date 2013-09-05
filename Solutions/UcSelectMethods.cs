using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LimsProject.BusinessLayer;
using LimsProject.BusinessLayer.Modules;

namespace LimsProject
{
    public delegate void ConfirmSelection();

    public partial class UcSelectMethods : UserControl
    {
        CGroup_solution group_solution = null;
        CTemplate_method_aa template_method_aa = null;
        ModSolution modSolution = new ModSolution();
        BindingList<CCustom_method_solution> lstTemplate = new BindingList<CCustom_method_solution>();

        public event ConfirmSelection onConfirmSelection;

        public CGroup_solution Group_solution
        {
            get {
                return group_solution;
            }            
        }

        public BindingList<CCustom_method_solution> LstTemplate_method
        {
            get {
                return lstTemplate;
            }
        }

        public UcSelectMethods()
        {
            InitializeComponent();
        }
        
        /*        
        1:Standar de Calibracion, 2:Solución Intermedia, 3:Estandar de Verificacion, 4:Soluciones titulantes
        */

        public void Init(CGroup_solution p_group_solution, CTemplate_method_aa p_template_method_aa)
        {
            template_method_aa = p_template_method_aa;
            Init(p_group_solution);
        }

        public void Init(CGroup_solution p_group_solution)
        {
            #region inicializar metodos

            group_solution = p_group_solution;
            // --- si existe el agrupador, hacer no editable la selección de métodos
            if (group_solution.Idgroup_solution == 0)
            {
                // --- no existe agrupador
                group_solution.Flag_selected_methods = false;
                gvMethods.OptionsBehavior.Editable = true;
                btConfirmSelMethods.Enabled = true;
            }
            else
            {
                // --- existe agrupador
                group_solution.Flag_selected_methods = true;
                gvMethods.OptionsBehavior.Editable = false;                
                btConfirmSelMethods.Enabled = false;
            }

            // --- show grids
            ShowGrids();

            #endregion

            #region inicializar combos
            // --- Inititalize list statusMr
            CReactiveFactory faReactive = new CReactiveFactory();
            List<CReactive> lstReactive = faReactive.GetAll();
            lstReactive.Add(new CReactive() { Idreactive = 0, Reactive_name = "---", Chemical_formula = "---" });

            cbMediumHead.Properties.DataSource = lstReactive;
            cbMediumHead.Properties.ValueMember = "Idreactive";
            cbMediumHead.Properties.DisplayMember = "Reactive_name";

            cbModifHead.Properties.DataSource = lstReactive;
            cbModifHead.Properties.ValueMember = "Idreactive";
            cbModifHead.Properties.DisplayMember = "Reactive_name";

            #endregion

            #region inicializar datos según el filtro seleccionado

            // Estandares de calibración.
            if (group_solution.Type_solution == 1)
            {
                // --- recuperar cajas de textos no editables
                cbTypePattern.EditValue = group_solution.Type_pattern;
                cbMrcOrPatternHeader.EditValue = group_solution.Idmr_detail;
                cbMediumHead.EditValue = group_solution.Idreactive_medium;
                cbModifHead.EditValue = group_solution.Idreactive_modif;

                // --- elemento, mr pattern, medio y modif
                // getLstMethods(group_solution)
                lstTemplate = modSolution.GetMethodsByMrcPattern(group_solution);
                gcMethods.DataSource = lstTemplate;
            }
            // Soluciones intermedias 1 y 2 y estandares de verificación.
            //else if (group_solution.Type_solution == 2 
            //    || group_solution.Type_solution == 3)
            //{
            //    // recuperar cajas de textos no editables
            //    cbTypePattern.EditValue = group_solution.Type_pattern;
            //    cbMrcOrPatternHeader.EditValue = group_solution.Idmr_detail;

            //    // elemento, mr pattern, sol intermedia (1 ó 2 implicito)
            //    // getLstMethods(group_solution, type_solution_intermedia)
            //    lstTemplate = modSolution.GetMethodsBySolInterm(group_solution, );
            //    gcMethods.DataSource = lstTemplate;
            //}

            #endregion
        }        

        public void ShowGrids()
        {
            // --- Apariencia
            // --- Estandar de Calibración
            if (group_solution.Type_solution == 1)
            {
                // --- mostrar metodos
                gcMethods.Visible = true;

                // --- mostrar calibraciones
                gcStd.Visible = true;
            }
            // --- Solución Intermedia, Estandar de Verificación, Solución Titulante
            if (group_solution.Type_solution >= 2 && group_solution.Type_solution <= 4)
            {
                // --- mostrar solo métodos
                gcMethods.Visible = true;

                // --- mostrar calibraciones
                gcStd.Visible = false;
            }
        }

        private void btConfirmSelMethods_Click(object sender, EventArgs e)
        {
            // --- confirmar selección de métodos
            group_solution.Flag_selected_methods = true;
            gvMethods.OptionsBehavior.Editable = false;
            gvStd.OptionsBehavior.Editable = false;

            if (onConfirmSelection != null)
                onConfirmSelection();
        }

        private void gvMethods_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvMethods.GetFocusedRowCellValue(gcTM_Idtemplate_met) != null)
            {
                ModSolution oModSolution = new ModSolution();

                int idtemplate_method = Convert.ToInt32(gvMethods.GetFocusedRowCellValue(gcTM_Idtemplate_met));
                gcStd.DataSource = oModSolution.GetStdByMethod(idtemplate_method);
            }
        }

        #region Methods

                
        //void CalcDateExpiration()
        //{
        //    // --- tomar como pivot el primer metodo para determinar el tiempo de expiración
        //    if (gvMethods.GetRowCellValue(0, gcTM_Idtemplate_met) != null)
        //    {
        //        int idtemplate_method = Convert.ToInt32(gvMethods.GetRowCellValue(0, gcTM_Idtemplate_met));

        //        CTemplate_method_aa oTemplate_method = new CTemplate_method_aaFactory().GetByPrimaryKey(new CTemplate_method_aaKeys(idtemplate_method));

        //        if (oGroup_solution.Date_ini == null && oGroup_solution.Date_end == null)
        //        {
        //            //    deDateIni.DateTime = Comun.GetDate();
        //            //    deDateEnd.DateTime = Comun.GetDate().AddMonths(Convert.ToInt32(oTemplate_method.Validity_calib));
        //        }
        //        else
        //        {
        //            //deDateIni.DateTime = Convert.ToDateTime(oGroup_solution.Date_ini);
        //            //deDateEnd.DateTime = Convert.ToDateTime(oGroup_solution.Date_end);
        //        }
        //    }
        //}

        bool IsSomeMethodSelected()
        {
            for (int i = 0; i < gvMethods.RowCount; i++)
            {
                if (Convert.ToBoolean(gvMethods.GetRowCellValue(i, gcTM_Sel)))
                {
                    return true;
                }
            }
            return false;
        }

        private void cbTypePattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            // --- mostrar mrc o patron de soluciones
            if (cbTypePattern.SelectedIndex == 0)
            {
                ModSolution oModSolution = new ModSolution();

                cbMrcOrPatternHeader.Properties.DataSource = oModSolution.GetLstMrc(Convert.ToInt16(group_solution.Idelement));
                cbMrcOrPatternHeader.Properties.DisplayMember = "Name";
                cbMrcOrPatternHeader.Properties.ValueMember = "Idmr_detail";
                cbMrcOrPatternHeader.EditValue = null;


                tbConcentPatternHeader.Text = "";
            }
            if (cbTypePattern.SelectedIndex == 1)
            {
                ModSolution oModSolution = new ModSolution();

                cbMrcOrPatternHeader.Properties.DataSource = oModSolution.GetLstPatron(Convert.ToInt16(group_solution.Idelement));
                cbMrcOrPatternHeader.Properties.DisplayMember = "Name";
                cbMrcOrPatternHeader.Properties.ValueMember = "Idmr_detail";
                cbMrcOrPatternHeader.EditValue = null;

                tbConcentPatternHeader.Text = "";
            }
            if (cbTypePattern.SelectedIndex == 2)
            {
                ModSolution oModSolution = new ModSolution();

                cbMrcOrPatternHeader.Properties.DataSource = oModSolution.GetLstSolutions(Convert.ToInt16(group_solution.Idelement));
                cbMrcOrPatternHeader.Properties.DisplayMember = "Name";
                cbMrcOrPatternHeader.Properties.ValueMember = "Idsolution";
                cbMrcOrPatternHeader.EditValue = null;

                tbConcentPatternHeader.Text = "";
            }
        }

        #endregion

        private void cbMrcOrPatternHeader_EditValueChanged(object sender, EventArgs e)
        {
            // --- recuperar concentración

            if (cbMrcOrPatternHeader.EditValue != null && cbMrcOrPatternHeader.EditValue != null
                && (Convert.ToInt16(cbMrcOrPatternHeader.EditValue) == 1 || Convert.ToInt16(cbMrcOrPatternHeader.EditValue) == 2))
            {
                ModSolution oModSolution = new ModSolution();
                tbConcentPatternHeader.Text = oModSolution.GetConcentrationPPM(Convert.ToInt16(cbMrcOrPatternHeader.EditValue)).ToString();
            }
        }

        public void Clear()
        {
            cbTypePattern.EditValue = null;
            cbMrcOrPatternHeader.EditValue = null;
            tbConcentPatternHeader.Text = "";
            tbUnd.Text = "";
            cbMediumHead.EditValue = null;
            cbModifHead.EditValue = null;
            gcMethods.DataSource = null;
            gcStd.DataSource = null;
        }

    }
}
