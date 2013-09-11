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
    public partial class cbMethodIpc : DevExpress.XtraEditors.LookUpEdit
    {
        public cbMethodIpc()
        {
            InitializeComponent();
            Init();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        void Init()
        {
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "MethodId", Visible = false });
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "Name", Visible = true });
            this.Properties.ShowHeader = false;
            this.Properties.ShowFooter = false;
            this.Properties.NullText = "Seleccionar";
        }

        public void Bind()
        {
            //ModIcp modIcp = new ModIcp();
            //this.Properties.DataSource = modIcp.GetMethodsIcp();
            this.Properties.DisplayMember = "Name";
            this.Properties.ValueMember = "MethodId";
        }
    }
}
