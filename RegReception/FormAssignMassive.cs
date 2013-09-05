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
    public partial class FormAssignMassive : LibraryBasicForm.FormConfirm
    {

        #region attributes

        // {PART1}{PART2}{PART3}
        // Ej: {FWEI}{0001}{FEAWG}

        private int Part_numeric { get; set; }
        public bool Flag_clear_and_add {
            get {
                return !ckAddSamples.Checked;
            }
        }

        public int Num_digits
        {
            get 
            {
                if (ckSamplePart1.Checked)
                    return Convert.ToInt32(tbNdPart1.Value);
                if (ckSamplePart2.Checked)
                    return Convert.ToInt32(tbNdPart2.Value);
                if (ckSamplePart3.Checked)
                    return Convert.ToInt32(tbNdPart3.Value);
                return 2;
            }
        }

        public int Num_samples
        {
            get {
                return Convert.ToInt32(tbNumSamples.Value);
            }
        }

        #endregion

        public FormAssignMassive()
        {
            InitializeComponent();
        }        

        private void FormAssignMassive_Load(object sender, EventArgs e)
        {
            Part_numeric = 3;            
        }

        public void EnabledControls(DevExpress.XtraEditors.TextEdit edittext, DevExpress.XtraEditors.SpinEdit spinedit, bool status)
        {
            edittext.Enabled = !status;
            spinedit.Enabled = status;
        }

        private void ckSamplePart1_CheckedChanged(object sender, EventArgs e)
        {
            EnabledControls(tbNamePart1, tbNdPart1, ckSamplePart1.Checked);
            if (ckSamplePart1.Checked)
            {
                ckSamplePart2.Checked = false;
                ckSamplePart3.Checked = false;
                PreviewCorrelative(tbNamePart1, tbNdPart1);
                Part_numeric = 1;
            }
            else            
                tbNamePart1.Text = "";
            
        }

        private void ckSamplePart2_CheckedChanged(object sender, EventArgs e)
        {
            EnabledControls(tbNamePart2, tbNdPart2, ckSamplePart2.Checked);
            if (ckSamplePart2.Checked)
            {
                ckSamplePart1.Checked = false;
                ckSamplePart3.Checked = false;
                PreviewCorrelative(tbNamePart2, tbNdPart2);
                Part_numeric = 2;
            }
            else
                tbNamePart2.Text = "";
        }

        private void ckSamplePart3_CheckedChanged(object sender, EventArgs e)
        {
            EnabledControls(tbNamePart3, tbNdPart3, ckSamplePart3.Checked);
            if (ckSamplePart3.Checked)
            {                
                ckSamplePart1.Checked = false;
                ckSamplePart2.Checked = false;
                PreviewCorrelative(tbNamePart3, tbNdPart3);
                Part_numeric = 3;
            }
            else
                tbNamePart3.Text = "";
        }

        public void PreviewCorrelative(DevExpress.XtraEditors.TextEdit edittext, DevExpress.XtraEditors.SpinEdit spinedit)
        {
            string num = "1";
            edittext.Text = num.PadLeft(Convert.ToInt32(spinedit.Value), '0');
        }

        public void ShowPreviewName()
        {
            laPreviewName.Text = String.Format("{0}{1}{2}", tbNamePart1.Text, tbNamePart2.Text, tbNamePart3.Text);
        }

        private void tbNdPart1_EditValueChanged(object sender, EventArgs e)
        {
            PreviewCorrelative(tbNamePart1, tbNdPart1);
        }

        private void tbNdPart2_EditValueChanged(object sender, EventArgs e)
        {
            PreviewCorrelative(tbNamePart2, tbNdPart2);
        }

        private void tbNdPart3_EditValueChanged(object sender, EventArgs e)
        {
            PreviewCorrelative(tbNamePart3, tbNdPart3);
        }

        private void tbNamePart1_EditValueChanged(object sender, EventArgs e)
        {
            ShowPreviewName();
        }

        private void tbNamePart2_EditValueChanged(object sender, EventArgs e)
        {
            ShowPreviewName();
        }

        private void tbNamePart3_EditValueChanged(object sender, EventArgs e)
        {
            ShowPreviewName();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string GetPattern()
        {
            string pattern = "";
            if (Part_numeric == 1)
                pattern = String.Format("{0}{1}{2}", "NUM", tbNamePart2.Text, tbNamePart3.Text);
            if (Part_numeric == 2)
                pattern = String.Format("{0}{1}{2}", tbNamePart1.Text, "NUM", tbNamePart3.Text);
            if (Part_numeric == 3)
                pattern = String.Format("{0}{1}{2}", tbNamePart1.Text, tbNamePart2.Text, "NUM");
            return pattern;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbNumSamples.Value) <= 0)
            {
                MessageBox.Show("Debe ingresar un número de muestras.");
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }    
}
