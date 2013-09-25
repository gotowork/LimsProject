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
    public partial class cbElement : DevExpress.XtraEditors.LookUpEdit
    {
        public short Idelement
        {
            get {
                if (this.EditValue != null)
                    return Convert.ToInt16(this.EditValue);
                return 0;
            }
        }

        public cbElement()
        {
            InitializeComponent();            
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        void Init()
        {
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "Idelement", Visible = false });
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "Cod_element", Visible = true });
            this.Properties.ShowHeader = false;
            this.Properties.ShowFooter = false;
            if (this.Properties.NullText.Trim().Length == 0)
                this.Properties.NullText = "Seleccionar";
        }

        public void Bind()
        {
            Init();
            this.Properties.DataSource = new CElementFactory().GetAll();
            this.Properties.ValueMember = "Idelement";
            this.Properties.DisplayMember = "Cod_element";
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            this.BackColor = Color.LightYellow;
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            this.BackColor = Color.White;
        }
    }
}
