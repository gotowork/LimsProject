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
    public partial class FormEmpresa : LibraryBasicForm.FormMantBase
    {
        #region constructors

        public FormEmpresa()
        {
            InitializeComponent();
        }

        #endregion

        #region properties
        short idCompany = -1;

        short IDCompany
        {
            get {
                return idCompany;
            }
            set {
                idCompany = value;
            }
        }

        #endregion

        #region inherit methods

        protected override void Limpiar_Campos()
        {
            IDCompany = 0;
            tbIdCompany.Text = "";
            tbBusinessName.Text = "";
            tbClientDomicile.Text = "";
            tbClientEmail.Text = "";
            tbClientPhone.Text = "";
            tbClientRuc.Text = "";
            cbTypeCompany.EditValue = null;
        }

        protected override bool Son_Datos_Correctos()
        {            
            if (cbTypeCompany.EditValue == null)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: falta especificar el tipo de empresa.");
                return false;
            }
            if (tbClientRuc.Text.Trim().Length > 0 && tbClientRuc.Text.Length != 11)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: No se especificó el ruc del cliente correctamente.");
                return false;
            }
            if (tbClientEmail.Text.Trim().Length > 0 && !Comun.ValidateMail(tbClientEmail.Text))
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: Al ingresar el correo electrónico.");
                return false;
            }
            return true;
        }

        protected override bool Grabar_Registro()
        {
            CCompanyFactory faCompany = new CCompanyFactory();
            CCompany oCompany;
            if ((oCompany = faCompany.GetByPrimaryKey(new CCompanyKeys(IDCompany))) == null)
                oCompany = new CCompany();
            
            oCompany.Idcompany = IDCompany;
            oCompany.Business_name = tbBusinessName.Text;
            oCompany.Domicile = tbClientDomicile.Text;
            oCompany.Mail = tbClientEmail.Text;
            oCompany.Phone_client = tbClientPhone.Text;
            oCompany.Ruc = tbClientRuc.Text;
            oCompany.Type_company = Convert.ToChar(cbTypeCompany.EditValue);

            if (IDCompany == 0)
            {
                oCompany.Usernew = Comun.GetUser();
                oCompany.Useredit = Comun.GetUser();
                oCompany.Datenew = Comun.GetDate();
                oCompany.Dateedit = Comun.GetDate();
            }
            else
            {
                oCompany.Useredit = Comun.GetUser();
                oCompany.Dateedit = Comun.GetDate();
            }

            bool result = false;

            if (!(result = faCompany.Update(oCompany)))
            {
                if (!result)
                {
                    result = faCompany.Insert(oCompany);
                }
            }

            if (result)
                LoadDataMasterSearh(new CCompanyFactory().GetAllDataTable());

            return result;
        }

        protected override void Recuperar_Registro()
        {            
            CCompanyFactory faCompany = new CCompanyFactory();
            CCompany oCompany = faCompany.GetByPrimaryKey(new CCompanyKeys(IDCompany));

            if (oCompany != null)
            {                
                tbBusinessName.Text = oCompany.Business_name;
                tbClientRuc.Text = oCompany.Ruc;
                tbClientDomicile.Text = oCompany.Domicile;
                tbClientEmail.Text = oCompany.Mail;
                tbClientPhone.Text = oCompany.Phone_client;
                cbTypeCompany.EditValue = Convert.ToChar(oCompany.Type_company);
            }
        }

        protected override void Asignar_Codigo_Seleccionado()
        {            
            IDCompany = Convert.ToInt16(dgvMasterSearch["Idcompany", dgvMasterSearch.CurrentCell.RowIndex].Value);
            tbIdCompany.Text = IDCompany.ToString();            
        }

        protected override void Load_Finder()
        {
            dgvMasterSearch.Columns["Cod_company"].Visible = false;
            dgvMasterSearch.Columns["Idcontact1"].Visible = false;
            dgvMasterSearch.Columns["Idcontact2"].Visible = false;
            dgvMasterSearch.Columns["Usernew"].Visible = false;
            dgvMasterSearch.Columns["Datenew"].Visible = false;
            dgvMasterSearch.Columns["Useredit"].Visible = false;
            dgvMasterSearch.Columns["Dateedit"].Visible = false;
            dgvMasterSearch.Columns["Status"].Visible = false;
            dgvMasterSearch.Columns["Idcompany"].HeaderText = "Id";
            dgvMasterSearch.Columns["Business_name"].HeaderText = "Nombre";
            dgvMasterSearch.Columns["Type_company"].HeaderText = "Tipo";
            dgvMasterSearch.Columns["Domicile"].HeaderText = "Domicilio";
            dgvMasterSearch.Columns["Mail"].HeaderText = "Email";
            dgvMasterSearch.Columns["Phone_client"].HeaderText = "Teléfono";

            
        }

        #endregion

        #region methods

        void Init_combos()
        {
            cbTypeCompany.Properties.DataSource = Comun.ListTypeCompany();
            cbTypeCompany.Properties.DisplayMember = "Name";
            cbTypeCompany.Properties.ValueMember = "Id";
        }

        #endregion

        #region events

        private void FormClient_Load(object sender, EventArgs e)
        {            
            // --- init combos
            Init_combos();

            // --- set datatable for the search
            LoadDataMasterSearh(new CCompanyFactory().GetAllDataTable());
        }

        #endregion        

    }
    
}
