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

    public delegate void Find();
    public delegate void New();

    public partial class UcToolStrip : UserControl
    {

        public event Find onFind;
        public event New onNew;

        public UcToolStrip()
        {
            InitializeComponent();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            if (onFind != null)
                onFind();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (onNew != null)
                onNew();
        }
    }
}
