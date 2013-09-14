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
    public partial class cbMethod : DevExpress.XtraEditors.LookUpEdit
    {
        public cbMethod()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        void Init()
        {
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "Idtemplate_method", Visible = false });
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "Title", Visible = true });
            this.Properties.ShowHeader = false;
            this.Properties.ShowFooter = false;
            this.Properties.NullText = "Seleccionar";
        }

        public void Bind(short idelement)
        {
            Init();
            this.Properties.DataSource = new Methods().GetAllLastVersionMethods().Where(x=> x.Idelement == idelement).ToList();
            this.Properties.DisplayMember = "Title";
            this.Properties.ValueMember = "Idtemplate_method";
        }

        public void Bind()
        {
            Init();
            this.Properties.DataSource = new Methods().GetAllLastVersionMethods();
            this.Properties.DisplayMember = "Title";
            this.Properties.ValueMember = "Idtemplate_method";
        }
    }
}
