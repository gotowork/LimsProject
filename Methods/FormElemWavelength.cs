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
    public partial class FormElemWavelength : LibraryBasicForm.FormBaseEmpty
    {
        public FormElemWavelength()
        {
            InitializeComponent();
        }

        private void FormElemWavelength_Load(object sender, EventArgs e)
        {
            cbElement1.Bind();
            cbElement1.EditValue = null;
            RetrieveData();
        }

        private void ckElement_CheckedChanged(object sender, EventArgs e)
        {
            cbElement1.Enabled = ckElement.Checked;
            RetrieveData();
        }

        void RetrieveData()
        {
            string element = ckElement.Checked == true ? cbElement1.Text : null;

            var query =
                (from m in new CElement_wavelengthFactory().GetAll()
                 from n in new CElementFactory().GetAll().Where(x => x.Idelement == m.Idelement)
                 where (element != null || n.Cod_element == element)
                 select new
                 {
                     m.Idelement,
                     n.Cod_element,
                     m.Idelement_wavelength,
                     m.Element_wavelength,
                     m.Wavelength,
                     m.Idl_axial,
                     m.Idl_radial,
                     m.Lineality_axial,
                     m.Lineality_radial
                 });

            DataTable queryIcp = new ModIcp().GetElements(element);

            List<CElement_wavelength> lst =
                (from t in queryIcp.AsEnumerable()
                 join p in query on t.Field<string>("ElementName") equals p.Element_wavelength into tp
                 from q in tp.DefaultIfEmpty()
                 select new CElement_wavelength
                 {
                     Idelement_wavelength = q == null ? Convert.ToInt32(null) : q.Idelement_wavelength,
                     Idelement = q == null ? Convert.ToInt16(null) : q.Idelement,
                     Wavelength = t.Field<string>("wavelength"),
                     Element_wavelength = t.Field<string>("ElementName"),
                     Idl_radial = q == null ? SetValueView(t.Field<int>("Radial")) : q.Idl_radial,
                     Idl_axial = q == null ? SetValueView(t.Field<int>("Axial")) : q.Idl_axial,
                     Lineality_radial = q == null ? SetValueView(t.Field<int>("Radial")) : q.Lineality_radial,
                     Lineality_axial = q == null ? SetValueView(t.Field<int>("Axial")) : q.Lineality_axial
                 }).ToList();

            gcElemWavelength.DataSource = lst;
        }

        int? SetValueView(int value)
        {
            if (value == 1)
                return 0;
            else
                return null;
        }

        private void cbElement1_EditValueChanged(object sender, EventArgs e)
        {
            if (cbElement1.EditValue != null)
            {
                //conectar con icp según filtro de elemento
                ModIcp modIcp = new ModIcp();
                DataTable dtElements = modIcp.GetElements(cbElement1.Text);
            }
        }

        private void btSync_Click(object sender, EventArgs e)
        {
            //conectar con icp según filtro de elemento
            //ModIcp modIcp = new ModIcp();
            //string element = cbElement1.EditValue == null ? null : cbElement1.Text;
            //DataTable dtElements = modIcp.GetElements(element);
            RetrieveData();
        }

        private void gvElemWavelength_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column == gcol_Idl_axial || e.Column == gcol_Idl_radial
                || e.Column == gcol_Lineality_axial || e.Column == gcol_Lineality_radial)
            {
                if (gvElemWavelength.GetRowCellValue(e.RowHandle, e.Column) == null)
                    e.Appearance.BackColor = Color.NavajoWhite;
            }
            else
                e.Appearance.BackColor = Color.White;

            e.Appearance.ForeColor = Color.Black;
        }
    }
}
