using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LimsProject.BusinessLayer;
using LimsProject.BusinessLayer.Modules;

namespace LimsProject
{
    public partial class cbReactive : DevExpress.XtraEditors.LookUpEdit
    {
        public cbReactive()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        void Init()
        {
            this.Properties.Columns.Clear();
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "Idreactive", Visible = false });
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "Reactive_name", Visible = true });
            this.Properties.ShowHeader = false;
            this.Properties.ShowFooter = false;
            this.Properties.NullText = "---";
        }

        public void Bind()
        {
            Init();
            List<CReactive> lstReactive = new CReactiveFactory().GetAll();
            this.Properties.DataSource = lstReactive;
            this.Properties.ValueMember = "Idreactive";
            this.Properties.DisplayMember = "Reactive_name";
        }
        
    }
}
