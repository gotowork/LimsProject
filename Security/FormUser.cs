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
    public partial class FormUser : LibraryBasicForm.FormMantBase
    {
        CUser_system oUser_system = new CUser_system();

        bool Flag_new_user = false;

        public FormUser()
        {
            InitializeComponent();
        }

        #region methods

        protected override void Recuperar_Registro()
        {
            if (cbPerson.EditValue != null)
            {
                short idperson = Convert.ToInt16(cbPerson.EditValue);
                CUser_systemFactory faUser_system = new CUser_systemFactory();
                List<CUser_system> lstUserSystem = faUser_system.GetAll().Where(c => c.Idperson == idperson).ToList();

                if (lstUserSystem.Exists(c => c.Idperson == idperson))
                {
                    oUser_system =
                        faUser_system
                        .GetAll()
                        .Where(c => c.Idperson == idperson).Single();

                    tbUserName.Text = oUser_system.Cod_user;

                    Flag_new_user = false;
                }
                else
                    Flag_new_user = true;
            }
        }

        protected override bool Grabar_Registro()
        {
            CUser_systemFactory faUser_name = new CUser_systemFactory();                                                
            if (tbPwd.Text.Trim().Length > 0 && tbRepPwd.Text.Trim().Length > 0)
                oUser_system.Pwd = Comun.EncriptarMD5(tbPwd.Text);

            oUser_system.Cod_user = tbUserName.Text;
            oUser_system.Idperson = Convert.ToInt16(cbPerson.EditValue);            

            bool result = false;
            if (!(result = faUser_name.Update(oUser_system)))
                result = faUser_name.Insert(oUser_system);

            if (result)
                InitCombos();

            return result;
        }

        protected override bool Son_Datos_Correctos()
        {
            if (Flag_new_user && (tbPwd.Text.Trim().Length == 0 || tbRepPwd.Text.Trim().Length == 0))
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: no ha ingresado una contraseña.");
                return false;
            }
            if(!ConfirmPwdRight())
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: las contraseñas no son iguales");
                return false;
            }
            if (cbPerson.EditValue == null)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Error: el código de persona es diferente.");
                return false;
            }
            return true;
        }

        bool ConfirmPwdRight()
        {
            if (tbPwd.Text == tbRepPwd.Text)
                return true;
            return false;
        }

        protected override void Accion_Despues_Grabar()
        {
            cbPerson.Focus();
            cbPerson.Select();
        }

        protected override void Limpiar_Campos()
        {
            tbUserName.Text = "";
            tbPwd.Text = "";
            tbRepPwd.Text = "";
            cbPerson.EditValue = null;
            tbPersonName.Text = "";
        }

        #endregion         

        void InitCombos()
        {            

            CPersonFactory faPerson = new CPersonFactory();
            cbPerson.Properties.DataSource = faPerson.GetAll().Where(c=> c.Person_type == 1).ToList();
            cbPerson.Properties.ValueMember = "Idperson";
            cbPerson.Properties.DisplayMember = "Cod_person";
        }
        
        private void FormUser_Load(object sender, EventArgs e)
        {
            InitCombos();
        }

        private void paSuperior_Leave(object sender, EventArgs e)
        {
            Recuperar_Registro();
        }

        private void cbPerson_EditValueChanged(object sender, EventArgs e)
        {
            if (cbPerson.EditValue != null)
                tbPersonName.Text = cbPerson.GetColumnValue("Allname").ToString();
        }

        private void tbPwd_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tbRepPwd_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
