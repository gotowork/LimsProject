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
    public partial class UcTraceUser : UserControl
    {
        DateTime dtSign;
        

        public string UserSign
        {
            get {
                return laUserName.Text;
            }
            set {
                laUserName.Text = value;
            }
        }

        public DateTime DateSign
        {
            set {
                dtSign = value;
                laDate.Text = String.Format("{0:g}", dtSign);
            }
        }

        public UcTraceUser()
        {
            InitializeComponent();
        }
    }
}
