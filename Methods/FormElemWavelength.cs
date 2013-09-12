using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimsProject
{
    public partial class FormElemWavelength : LibraryBasicForm.FormBaseEmpty
    {
        public FormElemWavelength()
        {
            InitializeComponent();
        }

        private void FormElemWavelength_Load(object sender, EventArgs e)
        {
            cbElement1.Bind();
        }

        private void ckElement_CheckedChanged(object sender, EventArgs e)
        {
            cbElement1.Enabled = ckElement.Checked;
        }

        private void cbElement1_EditValueChanged(object sender, EventArgs e)
        {
            //conectar con icp según filtro de elemento

        }
    }
}
