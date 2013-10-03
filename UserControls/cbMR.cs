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
    public partial class cbMR : DevExpress.XtraEditors.LookUpEdit
    {
        public cbMR()
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
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "Idmr_detail", Visible = false });
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "Cod_mr", Visible = true });
            this.Properties.ShowHeader = false;
            this.Properties.ShowFooter = false;
            if (this.Properties.NullText.Trim().Length == 0)
                this.Properties.NullText = "Seleccionar";
        }

        public void Bind(short idelement)
        {
            Init();
            this.Properties.DataSource = new ModMaterialReference().GetBy_Element(idelement);
            this.Properties.ValueMember = "Idmr_detail";
            this.Properties.DisplayMember = "Cod_mr";
        }

        public void Bind(Comun.TypeMr typemr, short idelement)
        {
            Init();
            this.Properties.DataSource = new ModMaterialReference().GetBy_TypeMr_And_Element(typemr, idelement);
            this.Properties.ValueMember = "Idmr_detail";
            this.Properties.DisplayMember = "Cod_mr";
        }

        public void BindConcen(Comun.TypeMr typemr, short idelement)
        {
            this.Properties.Columns.Clear();            
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "Nominal_value", Visible = true });
            this.Properties.ShowHeader = false;
            this.Properties.ShowFooter = false;

            this.Properties.DataSource = new ModMaterialReference().GetConcentration_By_TypeMr(typemr, idelement);
            this.Properties.ValueMember = "Nominal_value";
            this.Properties.DisplayMember = "Nominal_value";
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
