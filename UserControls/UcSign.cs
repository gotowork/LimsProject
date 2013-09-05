using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LimsProject
{
    public delegate void sign(bool login);

    public partial class UcSign : UserControl
    {
        

        [Category("Evento")]
        public event sign OnSign;

        [Category("Properties Sign")]
        public string Title
        {
            set {
                laTitleSign.Text = value;
            }
            get { return laTitleSign.Text; }
        }

        [Category("Properties Sign")]
        public string Pwd { get; set; }

        public UcSign()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            tbPwd.EditValue = null;
            btLock.ImageIndex = 0;
        }

        protected virtual void OnSignPwd(bool value)
        {
            if (OnSign != null)
                OnSign(value);
        }

        private void tbPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbPwd.Text.Length == 0)
                    btLock.ImageIndex = 0;
                else
                {
                    if (Comun.AreUserAndPwdRight(Comun.GetUser(), tbPwd.Text))
                    {
                        btLock.ImageIndex = 1;
                        OnSignPwd(true);
                    }
                    else
                    {
                        btLock.ImageIndex = 2;
                        OnSignPwd(false);
                    }
                }
            }
        } 
       
        
    }
}
