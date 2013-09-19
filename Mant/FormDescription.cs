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
    public partial class FormDescription : LibraryBasicForm.FormMantBase
    {
        #region attributes

        string Cod_des_sample = "";

        #endregion

        #region constructor

        public FormDescription()
        {
            InitializeComponent();
        }

        #endregion         

        #region methods inherit

        protected override bool Grabar_Registro()
        {
            CDescription_sampleFactory faDescrption_Sample = new CDescription_sampleFactory();
            CDescription_sample oDescription_Sample = faDescrption_Sample.GetByPrimaryKey(new CDescription_sampleKeys(tbCode.Text));
            
            if (oDescription_Sample == null)
                tbCode.Text = GetNextCorrelative().ToString();

            oDescription_Sample.Cod_des_sample = tbCode.Text;
            oDescription_Sample.Description = tbDescription.Text;
            oDescription_Sample.Priority_order = Convert.ToInt16(tbOrderPriority.Value);

            bool result = false;

            if (!(result = faDescrption_Sample.Update(oDescription_Sample)))
            {
                result = faDescrption_Sample.Insert(oDescription_Sample);
            }
            return result;
        }

        protected override void Accion_Despues_Grabar()
        {
            LoadDataMasterSearh(new CDescription_sampleFactory().GetAllDataTable());
        }

        protected override void Recuperar_Registro()
        {
            CDescription_sampleFactory faDescrption_Sample = new CDescription_sampleFactory();
            CDescription_sample oDescription_sample = faDescrption_Sample.GetByPrimaryKey(new CDescription_sampleKeys(tbCode.Text));

            if (oDescription_sample != null)
            {
                tbCode.Text = oDescription_sample.Cod_des_sample;
                tbDescription.Text = oDescription_sample.Description;
                tbOrderPriority.Value = Convert.ToDecimal(oDescription_sample.Priority_order);
            }
        }

        protected override void Limpiar_Campos()
        {            
            tbCode.Text = "";
            tbDescription.Text = "";
            tbOrderPriority.Value = 0;
        }

        protected override bool Son_Datos_Correctos()
        {
            if (tbCode.Text.Trim() == "")
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: No se admite el campo código vacio.");
                return false;
            }
            if (tbDescription.Text.Trim() == "")
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: No se admite el campo descripción vacio.");
                return false;
            }
            return true;
        }

        protected override void Asignar_Codigo_Seleccionado()
        {
            tbCode.Text = dgvMasterSearch["Cod_des_sample", dgvMasterSearch.CurrentCell.RowIndex].Value.ToString();
        }

        protected override void Load_Finder()
        {
            dgvMasterSearch.Columns["Cod_des_sample"].Visible = true;
            dgvMasterSearch.Columns["Description"].Visible = true;
            dgvMasterSearch.Columns["Usernew"].Visible = false;
            dgvMasterSearch.Columns["Datenew"].Visible = false;
            dgvMasterSearch.Columns["Useredit"].Visible = false;
            dgvMasterSearch.Columns["Dateedit"].Visible = false;
            dgvMasterSearch.Columns["Priority_order"].Visible = true;
            dgvMasterSearch.Columns["Status"].Visible = false;

            dgvMasterSearch.Columns["Cod_des_sample"].HeaderText = "Código";
            dgvMasterSearch.Columns["Description"].HeaderText = "Descripción";
            dgvMasterSearch.Columns["Priority_order"].HeaderText = "Prioridad";

            dgvMasterSearch.ReadOnly = true;
        }

        #endregion        

        #region properties



        #endregion

        #region events

        private void FormDescription_Load(object sender, EventArgs e)
        {
            LoadDataMasterSearh(new CDescription_sampleFactory().GetAllDataTable());
        }

        #endregion

        #region methods

        public int GetNextCorrelative()
        {
            List<CDescription_sample> lst = new CDescription_sampleFactory().GetAll();
            int max = new CDescription_sampleFactory().GetAll().Max(c => Convert.ToInt32(c.Cod_des_sample));
            if (lst.Count == 0)
                max = 1;
            else 
                max++;

            return max;
        }

        #endregion

    }
}
