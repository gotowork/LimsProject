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
    public partial class FormLogin : Form
    {
        List<CUser_system> LstUser = new List<CUser_system>();

        public FormLogin()
        {
            InitializeComponent();
        }

        bool IsUserRight()
        {
            List<CUser_system> lstUser = new CUser_systemFactory().GetAll();
            foreach (CUser_system oUsuario in lstUser)
            {
                if (tbUser.Text.Trim().ToUpper() == oUsuario.Cod_user.Trim().ToUpper())
                {
                    Comun.User_system = oUsuario;
                    return true;
                }
            }
            return false;
        }

        bool AreUserAndPwdRight()
        {            
            foreach (CUser_system oUsuario in LstUser)
            {
                if (tbUser.Text.Trim().ToUpper() == oUsuario.Cod_user.Trim().ToUpper())
                {
                    if (oUsuario.Pwd == Comun.EncriptarMD5(tbPwd.Text))
                    {
                        Comun.User_system = oUsuario;
                        return true;
                    }
                }
            }
            return false;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (AreUserAndPwdRight())
            {
                this.DialogResult = DialogResult.OK;
                Comun.Send_user();
            }
            else
            {
                tbPwd.Text = "";
                tbUser.Focus();
                laMessage.Text = "Nombre o contraseña no válidos";
                this.DialogResult = DialogResult.None;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            LstUser = new CUser_systemFactory().GetAll();
            if (Comun.User_system != null)
            {
                tbUser.Text = Comun.User_system.Cod_user;
                tbPwd.Select();
                tbPwd.Focus();
            }
            else
                tbUser.Select();

            tbPwd.Text = "";
            laMessage.Text = "";
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            // valid if the user name is right
            if (IsUserRight())
            {
                tbPwd.Focus();
                laMessage.Text = "";
            }
            else
            {
                tbUser.Text = "";
                tbUser.Focus();
                laMessage.Text = "El nombre de usuario no existe";
            }
        }

        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btOk_Enter(object sender, EventArgs e)
        {
            btOk.PerformClick();
        }
    }
}
