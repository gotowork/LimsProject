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
    

    public partial class FormCheckContent : Form
    {
        #region attributes

        FormCheckAll fmPopupR = new FormCheckAll();
        public long Idbatch { get; set; }
        public int Idtemplate_method { get; set; }
        public long Idrecep_sample_detail_elem { get; set; }
        public int Idretest { get; set; }
        public Comun.TypeSample TypeSample { get; set; }
        
        public string Text_obs 
        { 
            get
            {
                return fmPopupR.Text_obs;
            }
            set 
            {
                fmPopupR.Text_obs = value;
            }
        }

        public bool EnableRetest
        {
            get 
            {
                return fmPopupR.EnableRetest;
            }
            set {
                fmPopupR.EnableRetest = value;
            }
        }

        #endregion

        public Comun.WindowsTray Windows_current { get; set; } 

        public FormCheckContent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            fmPopupR.Idbatch = Idbatch;
            fmPopupR.Idtemplate_method = Idtemplate_method;
            fmPopupR.Idrecep_sample_detail_elem = Idrecep_sample_detail_elem;
            fmPopupR.Idretest = Idretest;
            fmPopupR.TypeSample = TypeSample;

            fmPopupR.evenOpenBatch += fmPopupR_evenOpenBatch;
            fmPopupR.evenCloseParent += fmPopupR_evenCloseParent;
            fmPopupR.MdiParent = this;
            fmPopupR.Windows_current = Windows_current;
            fmPopupR.Show();
        }

        void fmPopupR_evenCloseParent(DialogResult dlg)
        {
            this.DialogResult = dlg;
        }

        void fmPopupR_evenOpenBatch(long idbatch, string nom_tray)
        {
            string Nom_tray = "B-" + nom_tray;

            FormShowBatch fmShowBatch = new FormShowBatch();
            fmShowBatch.Text = Nom_tray;
            fmShowBatch.MdiParent = this;
            fmShowBatch.Show();

            fmPopupR.Select();
        }
    }
}
