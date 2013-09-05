using System;
using System.Collections.ObjectModel;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LimsProject
{
    public delegate void SelectedIndex(int index);

    public partial class UcGenerar : UserControl
    {
        public event SelectedIndex onSelectedIndex;

        List<string> items = new List<string>();

        public string Title {
            get {
                return cbGenerar.Properties.Buttons[0].Caption;
            }
            set {
                cbGenerar.Properties.Buttons[0].Caption = value;
            }
        }

        public void InitItems(List<string> items)
        {
            cbGenerar.Properties.Items.Clear();

            foreach (string item in items)
            {
                cbGenerar.Properties.Items.Add(item);
            }
        }        

        public UcGenerar()
        {
            InitializeComponent();
        }

        private void cbGenerar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (onSelectedIndex != null)
            {
                onSelectedIndex(cbGenerar.SelectedIndex);
                cbGenerar.SelectedIndex = -1;
            }
        }
    }
}
