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
    public partial class FormElement : LibraryBasicForm.FormMantBase
    {
        short Idelement = 0;

        public FormElement()
        {
            InitializeComponent();
        }

        protected override bool Grabar_Registro()
        {
            CElement oElement = new CElement();
            oElement.Idelement = Idelement;
            oElement.Cod_element = tbCodElement.Text;
            oElement.Name_element = tbDenomination.Text;
            oElement.Description = tbDescription.Text;
            oElement.Native_element = tbGroup.Text;
            oElement.Type_element = 'C';

            if (Idelement == 0)
            {
                oElement.Usernew = Comun.GetUser();
                oElement.Useredit = Comun.GetUser();
                oElement.Datenew = Comun.GetDate();
                oElement.Dateedit = Comun.GetDate();
            }
            else
            {
                oElement.Datenew = Comun.GetDate();
                oElement.Dateedit = Comun.GetDate();
            }

            CElementFactory faElement = new CElementFactory();
            if (!faElement.Update(oElement))
                faElement.Insert(oElement);
            ComunForm.Send_message(this.Text, TypeMsg.ok, "");
            return true;
        }

        protected override bool Son_Datos_Correctos()
        {
            List<CElement> lstElement = new CElementFactory().GetAll();
            if (tbCodElement.Text.Trim().Length == 0)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: el código de elemento no fue ingresado.");
                return false;
            }
            if (lstElement
                .Exists(c => c.Cod_element == tbCodElement.Text.Trim()
                    && c.Idelement != Idelement))
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: el código de elemento ya esta registrado.");
                return false;
            }
            return true;
        }

        protected override void Recuperar_Registro()
        {
            CElementFactory faElement = new CElementFactory();
            CElement oElement = faElement.GetByPrimaryKey(new CElementKeys(Idelement));

            tbCodElement.Text = oElement.Cod_element;
            tbDenomination.Text = oElement.Name_element;
            tbDescription.Text = oElement.Description;
            tbGroup.Text = oElement.Native_element;
        }

        protected override void Asignar_Codigo_Seleccionado()
        {
            Idelement = Convert.ToInt16(dgvMasterSearch["Idelement", dgvMasterSearch.CurrentCell.RowIndex].Value);
        }

        protected override void Load_Finder()
        {
            dgvMasterSearch.Columns["Idelement"].Visible = false;
            dgvMasterSearch.Columns["Native_element"].Visible = false;
            dgvMasterSearch.Columns["Type_element"].Visible = false;
            dgvMasterSearch.Columns["Usernew"].Visible = false;
            dgvMasterSearch.Columns["Datenew"].Visible = false;
            dgvMasterSearch.Columns["Useredit"].Visible = false;
            dgvMasterSearch.Columns["Dateedit"].Visible = false;
            dgvMasterSearch.Columns["Status"].Visible = false;

            dgvMasterSearch.Columns["Cod_element"].HeaderText = "Símbolo";
            dgvMasterSearch.Columns["Name_element"].HeaderText = "Nombre de elemento";
            dgvMasterSearch.Columns["Description"].HeaderText = "Descripción";
        }

        protected override void Limpiar_Campos()
        {
            Idelement = 0;
            tbCodElement.Text = "";
            tbDenomination.Text = "";
            tbDescription.Text = "";
            tbGroup.Text = "";
        }

        private void FormElemento_Load(object sender, EventArgs e)
        {
            LoadDataMasterSearh(new CElementFactory().GetAllDataTable());
        }
                
    }
}
