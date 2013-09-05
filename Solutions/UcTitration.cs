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
    public partial class UcTitration : UserControl
    {
        #region Attributes

        bool Flag_Date_Modified = false;
        public int Iduser { get; set; }

        public CSolution Solution { get; set; }
        public CTitration_main Titration_main { get; set; }
        CTitration_mainFactory faTitration_main = new CTitration_mainFactory();
        CSolution_titrationFactory faSolution_titration = new CSolution_titrationFactory();
        Authorization oAuthorization = new Authorization();

        #endregion

        #region properties

        BindingList<CSolution_titration> ListSolutionTitration
        {
            get
            {
                if (gcSolTitration.DataSource != null)
                    return gcSolTitration.DataSource as BindingList<CSolution_titration>;
                return null;
            }
        }

        #endregion

        public UcTitration()
        {
            InitializeComponent();
        }

        #region inherit methods

        void Recuperar_Registro()
        {
            // --- recuperar principal
            Titration_main =
                faTitration_main.GetByPrimaryKey(
                new CTitration_mainKeys(Solution.Idsolution));

            if (Titration_main != null)
            {
                // --- en la cabecera
                tbMainForAliquot.Value = Convert.ToDecimal(Titration_main.Concentration_value);
                cbMainMasaVolumen.EditValue = Convert.ToInt32(Titration_main.Concentration_unit);
                tbMainNumAnalyst.Value = Convert.ToInt32(Titration_main.Num_analyst);
                tbMainNumTest.Value = Convert.ToInt32(Titration_main.Num_test);
                cbMainAverageType.EditValue = Convert.ToInt32(Titration_main.Type_average);

                CUser_system oUserSign =
                    new CUser_systemFactory()
                    .GetByPrimaryKey(new CUser_systemKeys(Convert.ToInt16(Titration_main.Analyst4)));

                if (Titration_main.Analyst4 != null)
                {
                    ucTraceTitration.UserSign = oUserSign.Cod_user;
                    ucTraceTitration.DateSign = Convert.ToDateTime(Titration_main.Date_analyst4);
                }

                // --- en la base
                tbFactorEnd.Value = Convert.ToDecimal(Titration_main.Factor);
                cbFactorUnitMeasure.EditValue = Titration_main.Idunit_measure_factor;
            }

            // --- recuperar detalle
            gcSolTitration.DataSource =
                new BindingList<CSolution_titration>(
                new CSolution_titrationFactory()
                .GetAll()
                .Where(c => c.Idsolution == Solution.Idsolution).ToList());
        }

        bool Son_Datos_Correctos()
        {
            return true;
        }

        void Limpiar_Campos()
        {
            gcSolTitration.DataSource = null;
        }

        #endregion

        #region Events

        private void FormTitration_Load(object sender, EventArgs e)
        {
            InitCombos();
            Recuperar_Registro();
            EnabledControls();

        }

        private void gvSolTitration_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvSolTitration.SetFocusedRowCellValue(gcCol_Idsolution, Solution.Idsolution);
            gvSolTitration.SetFocusedRowCellValue(gcCol_Status_titration, false);
            gvSolTitration.SetFocusedRowCellValue(gcCol_Prepared_by, Comun.User_system.Iduser);
        }

        private void gvSolTitration_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == gcCol_Practice_reading || e.Column == gcCol_Theorical_reading)
            {
                if (gvSolTitration.GetFocusedRowCellValue(gcCol_Theorical_reading) != null)
                {
                    CSolution_titration oSolution_titration = gvSolTitration.GetRow(gvSolTitration.FocusedRowHandle) as CSolution_titration;
                    oSolution_titration.Date_prepared = Comun.GetDate();
                    if (!faSolution_titration.Update(oSolution_titration))
                        faSolution_titration.Insert(oSolution_titration);
                }

                if (gvSolTitration.GetFocusedRowCellValue(gcCol_Practice_reading) != null)
                {
                    CSolution_titration oSolution_titration = gvSolTitration.GetRow(gvSolTitration.FocusedRowHandle) as CSolution_titration;
                    oSolution_titration.Date_prepared = Comun.GetDate();
                    if (!faSolution_titration.Update(oSolution_titration))
                        faSolution_titration.Insert(oSolution_titration);
                }

                if (gvSolTitration.GetFocusedRowCellValue(gcCol_Theorical_reading) != null
                    && gvSolTitration.GetFocusedRowCellValue(gcCol_Practice_reading) != null)
                {
                    decimal theorical_reading = Convert.ToDecimal(gvSolTitration.GetFocusedRowCellValue(gcCol_Theorical_reading));
                    decimal practice_reading = Convert.ToDecimal(gvSolTitration.GetFocusedRowCellValue(gcCol_Practice_reading));
                    decimal factor = 0;

                    if (practice_reading > 0)
                        factor = Math.Round(theorical_reading / practice_reading, 4);

                    gvSolTitration.SetFocusedRowCellValue(gcCol_Factor, factor);

                    CSolution_titration oSolution_titration = gvSolTitration.GetRow(gvSolTitration.FocusedRowHandle) as CSolution_titration;
                    oSolution_titration.Date_prepared = Comun.GetDate();
                    if (!faSolution_titration.Update(oSolution_titration))
                        faSolution_titration.Insert(oSolution_titration);
                }

                // --- habilitar la firma del analista
                Flag_Date_Modified = true;

                EnabledSignData();
            }
            if (e.Column == gcCol_Factor)
            {
                Assign_average();
            }
        }

        private void ucSignTitration_OnSign(bool login)
        {

        }

        private void btEnterReadings_Click(object sender, EventArgs e)
        {
            Titration_main = new CTitration_main();
            Titration_main.Idtitration_main = Solution.Idsolution;
            Titration_main.Status_process = 1;
            Titration_main.Concentration_value = tbMainForAliquot.Value;
            Titration_main.Concentration_unit = Convert.ToInt32(cbMainMasaVolumen.EditValue);
            Titration_main.Num_analyst = Convert.ToInt32(tbMainNumAnalyst.Value);
            Titration_main.Num_test = Convert.ToInt32(tbMainNumTest.Value);
            Titration_main.Type_average = Convert.ToInt32(cbMainAverageType.EditValue);

            if (faTitration_main.Insert(Titration_main))
            {
                paTop.Enabled = false;
                gvSolTitration.OptionsBehavior.Editable = true;
                ucSignFactor.Title = "Analista 1";
            }
            else
                Comun.Send_message(this.Text, TypeMsg.error, "No se pudo completar la operación.");
        }

        private void cbShowPanel_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbShowPanel.SelectedIndex == 0)
            {
                paBottom.Visible = false;
                ucSignData.Enabled = SignDataAuthorized();
                EnabledSignFactor();
            }
            else
            {
                paBottom.Visible = true;
                ucSignData.Enabled = false;
                EnabledSignFactor();
            }
        }

        public bool SignDataAuthorized()
        {
            return oAuthorization.IsAuthorized(Authorization.ListAuthorization.CanSignDataTitration, Comun.User_system.Iduser);
        }

        public bool SignFactorAuthorized()
        {
            return oAuthorization.IsAuthorized(Authorization.ListAuthorization.CanSignFactorTitration, Comun.User_system.Iduser);
        }

        private void ucSignFactor_OnSign(bool login)
        {
            // --- firmar jefe de guardia
            if (login)
            {
                // --- guardar trazabilidad y aceptar el factor.
                Titration_main.Analyst4 = Comun.User_system.Iduser;
                Titration_main.Date_analyst4 = Comun.GetDate();
                Titration_main.Factor = tbFactorEnd.Value;
                Titration_main.Idunit_measure_factor = Convert.ToInt16(cbFactorUnitMeasure.EditValue);

                //if (faTitration_main.Update(Titration_main))
                //    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                //else
                //{
                //    Comun.Send_message(this.Text, TypeMsg.error, "Error de conexión.");
                //    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                //}
            }
        }

        private void tbFactorEnd_EditValueChanged(object sender, EventArgs e)
        {
            EnabledSignFactor();
        }

        private void cbFactorUnitMeasure_EditValueChanged(object sender, EventArgs e)
        {
            EnabledSignFactor();
        }

        private void repSelect_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            // --- edit if user row is equal to current user
            // --- guardar check 
            bool sign_factor_authorized = SignFactorAuthorized();

            CSolution_titration oSolution_titration = gvSolTitration.GetRow(gvSolTitration.FocusedRowHandle) as CSolution_titration;
            if (oSolution_titration.Prepared_by == Comun.User_system.Iduser
                || sign_factor_authorized)
            {
                oSolution_titration.Status_titration = Convert.ToBoolean(e.NewValue);
                oSolution_titration.Date_prepared = Comun.GetDate();
                faSolution_titration.Update(oSolution_titration);
                gvSolTitration.UpdateCurrentRow();

                // --- recalcular promedio                
                Assign_average();

                // --- habilitar para firmar
                EnabledSignData();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void repValue_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            // --- get user of current row            
            CSolution_titration oSolution_titration = gvSolTitration.GetRow(gvSolTitration.FocusedRowHandle) as CSolution_titration;

            // --- edit if user row is equal to current user
            if (oSolution_titration.Prepared_by != Comun.User_system.Iduser)
                e.Cancel = true;
        }

        #endregion

        #region methods

        public void InitCombos()
        {
            repUser.DataSource = new CUser_systemFactory().GetAll();
            repUser.DisplayMember = "Cod_user";
            repUser.ValueMember = "Iduser";

            cbFactorUnitMeasure.Properties.DataSource = new CMeasurement_unitFactory().GetAll();
            cbFactorUnitMeasure.Properties.DisplayMember = "Name_unit";
            cbFactorUnitMeasure.Properties.ValueMember = "Idunit";
        }

        public decimal GetFactor()
        {
            return tbFactorEnd.Value;
        }

        void EnabledControls()
        {
            bool sign_data_authorized = SignDataAuthorized();
            bool sign_factor_authorized = SignFactorAuthorized();

            if (Titration_main == null) // es registro nuevo
            {
                gvSolTitration.OptionsBehavior.Editable = true;

                paTop.Enabled = true;
                gvSolTitration.OptionsBehavior.Editable = false;
            }
            else if (Titration_main.Status_process > 0)
            {
                paTop.Enabled = false;
                gvSolTitration.ExpandAllGroups();

                // --- check authorization of data
                gvSolTitration.OptionsBehavior.Editable = sign_data_authorized;
                paSignData.Enabled = sign_data_authorized;

                // --- check authorization of factor                
                paSignFactor.Enabled = sign_factor_authorized;
            }
        }

        void Assign_average()
        {
            if (!CanShowAverage())
            {
                foreach (CSolution_titration item in ListSolutionTitration)
                {
                    if (item.Prepared_by == Comun.User_system.Iduser)
                    {
                        item.Average = null;
                        faSolution_titration.Update(item);
                    }
                }

                GetData();
            }
            else
            {
                if (gvSolTitration.GetFocusedRowCellValue(gcCol_Theorical_reading) != null
                        && gvSolTitration.GetFocusedRowCellValue(gcCol_Practice_reading) != null)
                {
                    // --- recorrer todas las muestras chekeadas y promediarlas
                    var query =
                        (from t in ListSolutionTitration
                         where t.Status_titration == true
                         group t by new { t.Prepared_by }
                             into g
                             select new
                             {
                                 g.Key.Prepared_by,
                                 Average = g.Average(c => c.Factor)
                             }).ToList();

                    if (query.Count > 0)
                    {
                        if (query.Exists(c => c.Prepared_by == Comun.User_system.Iduser))
                        {
                            // --- asignar promedios
                            BindingList<CSolution_titration> lst_tmp = new BindingList<CSolution_titration>(ListSolutionTitration);
                            foreach (CSolution_titration item in lst_tmp)
                            {
                                if (item.Prepared_by == Comun.User_system.Iduser)
                                {
                                    item.Average = query.Single(c => c.Prepared_by == item.Prepared_by).Average;
                                    // --- insertar/actualizar en la base de datos
                                    if (!faSolution_titration.Update(item))
                                        faSolution_titration.Insert(item);
                                }
                            }

                            // --- asignar promedio según combo                    
                            if (cbMainAverageType.SelectedIndex == 0) // global                    
                            {
                                tbFactorEnd.Value = Convert.ToDecimal(ListSolutionTitration.Average(c => c.Factor));
                                Titration_main.Factor = tbFactorEnd.Value;
                                faTitration_main.Update(Titration_main);
                            }
                            else // por usuario                    
                            {
                                tbFactorEnd.Value = Convert.ToDecimal(query.Average(c => c.Average));
                                Titration_main.Factor = tbFactorEnd.Value;
                                faTitration_main.Update(Titration_main);
                            }
                        }
                    }
                }

                GetData();
            }
        }

        /// <summary>
        /// Este método sirve para mostrar el promedio en las filas agrupadas 
        /// por un usuario solo si esta seleccionado alguna fila.
        /// </summary>
        /// <returns></returns>
        bool CanShowAverage()
        {
            foreach (CSolution_titration item in ListSolutionTitration)
            {
                if (item.Prepared_by == Comun.User_system.Iduser && Convert.ToBoolean(item.Status_titration))
                    return true;
            }
            return false;
        }

        void GetData()
        {
            int index_row = gvSolTitration.FocusedRowHandle;
            DevExpress.XtraGrid.Columns.GridColumn column = gvSolTitration.FocusedColumn;

            gcSolTitration.DataSource =
            new BindingList<CSolution_titration>(
            new CSolution_titrationFactory()
            .GetAll()
            .Where(c => c.Idsolution == Solution.Idsolution)
            .ToList());

            gvSolTitration.ExpandAllGroups();
            gvSolTitration.FocusedColumn = column;
            gvSolTitration.FocusedRowHandle = index_row;
        }

        void EnabledSignData()
        {
            if (SignDataAuthorized())
            {
                //this.ControlBox = false;
                ucSignData.Enabled = true;
            }
        }

        void EnabledSignFactor()
        {
            if (SignFactorAuthorized())
            {
                paSignFactor.Enabled = true;

                if (tbFactorEnd.Value > 0 && cbFactorUnitMeasure.EditValue != null)
                    ucSignFactor.Enabled = true;
                else
                    ucSignFactor.Enabled = false;
            }
            else
            {
                paSignFactor.Enabled = false;
            }
        }

        #endregion

        public void Clear()
        {

        }
    }
}
