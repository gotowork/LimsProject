using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LimsProject.BusinessLayer;

namespace LimsProject
{
    public partial class FormReactives : LibraryBasicForm.FormMantBase
    {
        CReactive oReactive = new CReactive();

        public FormReactives()
        {
            InitializeComponent();
        }

        #region inherit methods

        protected override void Accion_Despues_Grabar()
        {
            InitData();
        }

        protected override bool Grabar_Registro()
        {
            CReactiveFactory faReactive = new CReactiveFactory();            

            if (oReactive == null)
            {
                oReactive = new CReactive();
                oReactive.Idreactive = 0;
            }

            oReactive.Reactive_name = tbName.Text;
            oReactive.Chemical_formula = cbFormula.Text;
            oReactive.Weight_molecular = tbWeightMolecular.Value;

            bool result = false;

            if (!(result= faReactive.Update(oReactive)))
                result = faReactive.Insert(oReactive);

            return result;
        }

        protected override void Recuperar_Registro()
        {
            CReactiveFactory faReactive = new CReactiveFactory();
            oReactive = faReactive.GetByPrimaryKey(new CReactiveKeys(Convert.ToInt32(cbFormula.EditValue)));

            if (oReactive != null)
            {
                tbName.Text = oReactive.Reactive_name;
                tbWeightMolecular.Value = Convert.ToDecimal(oReactive.Weight_molecular);
            }
        }

        protected override bool Son_Datos_Correctos()
        {
            if (tbName.Text.Trim().Length == 0)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: no ingreso una fórmula correctamente.");
                return false;
            }
            if (tbWeightMolecular.Value == 0)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: no ingreso el valor molecular.");
                return false;
            }
            return true;
        }

        protected override void Limpiar_Campos()
        {
            oReactive = null;
            cbFormula.EditValue = null;
            tbName.Text = "";
            tbWeightMolecular.Value = 0;
            cbFormula.Focus();
            cbFormula.Select();
        }

        #endregion

        private void paSuperior_Leave(object sender, EventArgs e)
        {
            Recuperar_Registro();
        }

        private void cbNomReactives_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Edit;
            Edit = ((DevExpress.XtraEditors.LookUpEdit)sender).Properties;

            if (e.DisplayValue == null || Edit.NullText.Equals(e.DisplayValue) || string.Empty.Equals(e.DisplayValue))
            {
                return;
            }
            List<CReactive> lstReactives = (List<CReactive>)cbFormula.Properties.DataSource;
            CReactive oReactive = new CReactive();
            oReactive.Idreactive = 0;
            oReactive.Chemical_formula = cbFormula.Text;
            lstReactives.Add(oReactive);

            cbFormula.Properties.DataSource = lstReactives;            

            e.Handled = true;
        }

        private void FormReactives_Load(object sender, EventArgs e)
        {
            InitData();
        }

        void InitData()
        {
            CReactiveFactory faReactive = new CReactiveFactory();
            cbFormula.Properties.DataSource = faReactive.GetAll();
            cbFormula.Properties.DisplayMember = "Chemical_formula";
            cbFormula.Properties.ValueMember = "Idreactive";
        }
    }
}
