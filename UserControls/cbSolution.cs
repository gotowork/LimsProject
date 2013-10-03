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

namespace LimsProject
{
    public partial class cbSolution : DevExpress.XtraEditors.LookUpEdit
    {
        public cbSolution()
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
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "Idsolution_interm", Visible = false });
            this.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "Cod_solution", Visible = true });
            this.Properties.ShowHeader = false;
            this.Properties.ShowFooter = false;
            this.Properties.NullText = "---";
        }

        public void BindSolInt1()
        {
            Init();
            List<CSolution_interm> lstReactive =
                new CSolution_intermFactory()
                .GetAll()
                .Where(x => x.Type_sol == 1).ToList();

            this.Properties.DataSource = lstReactive;
            this.Properties.ValueMember = "Idsolution_interm";
            this.Properties.DisplayMember = "Cod_solution";
        }

        public void BindSolInt2()
        {
            Init();
            List<CSolution_interm> lstReactive =
                new CSolution_intermFactory()
                .GetAll()
                .Where(x => x.Type_sol == 2).ToList();

            this.Properties.DataSource = lstReactive;
            this.Properties.ValueMember = "Idsolution_interm";
            this.Properties.DisplayMember = "Cod_solution";
        }

        public void BindSolInt1And2()
        {
            Init();
            List<CSolution_interm> lstReactive = 
                new CSolution_intermFactory()
                .GetAll()
                .Where(x => x.Type_sol == 1 
                    || x.Type_sol == 2).ToList();

            this.Properties.DataSource = lstReactive;
            this.Properties.ValueMember = "Idsolution_interm";
            this.Properties.DisplayMember = "Cod_solution";
        }

        public void BindSolCalib()
        {
            Init();
            List<CSolution_interm> lstSolCalib =
                new CSolution_intermFactory()
                .GetAll()
                .Where(x => x.Type_sol == 4).ToList();

            this.Properties.DataSource = lstSolCalib;
            this.Properties.ValueMember = "Idsolution_interm";
            this.Properties.DisplayMember = "Cod_solution";
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
