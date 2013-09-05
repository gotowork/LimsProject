using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LimsProject
{
    public partial class FormConfirmCounterSample : LibraryBasicForm.FormConfirm
    {
        public short Amount
        {
            get {
                return Convert.ToInt16(tbAmount.EditValue);
            }
        }

        public FormConfirmCounterSample()
        {
            InitializeComponent();
        }
    }
}
