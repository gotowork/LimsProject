using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LimsProject.BusinessLayer.Modules;

namespace LimsProject
{
    public delegate void Search(ModMasterSearch.KeyFilterPrice key);

    public partial class UcFilterPrice : UserControl
    {
        ModMasterSearch.KeyFilterPrice key;
        public ModMasterSearch.KeyFilterPrice keyDefault;

        public event Search onSearch;

        public UcFilterPrice()
        {
            InitializeComponent();

            keyDefault.Company = "";
            keyDefault.Nombre = "";
            keyDefault.DateIni = deDateIni.EditValue == null ? keyDefault.DateIni : deDateIni.DateTime;
            keyDefault.DateEnd = deDateEnd.EditValue == null ? keyDefault.DateEnd : deDateEnd.DateTime;
            keyDefault.Status = Convert.ToInt32(cbStatusPrice.EditValue);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            key.Company = tbCompany.Text;

            key.Nombre = tbAttention.Text;

            if (deDateIni.EditValue != null)
                key.DateIni = deDateIni.DateTime;

            if (deDateEnd.EditValue != null)
                key.DateEnd = deDateEnd.DateTime;

            if (cbStatusPrice.EditValue != null)
                key.Status = Convert.ToInt32(cbStatusPrice.EditValue);
            
            if (onSearch != null)
                onSearch(key);
        }
        
    }
}
