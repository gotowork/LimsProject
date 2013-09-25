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
                 where (element == null || n.Cod_element == element)
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

            var queryIcpElement =
                (from p in queryIcp.AsEnumerable()
                 join q in new CElementFactory().GetAll() on p.Field<string>("elementSymbol") equals q.Cod_element                 
                 select new
                 {
                     Wavelength = p.Field<string>("wavelength"),
                     elementSymbol = q.Cod_element,
                     Idelement = q.Idelement,
                     Element_wavelength = p.Field<string>("ElementName"),
                     Idl_radial = SetValueView(p.Field<int>("Radial")),
                     Idl_axial = SetValueView(p.Field<int>("Axial")),
                     Lineality_radial = SetValueView(p.Field<int>("Radial")),
                     Lineality_axial = SetValueView(p.Field<int>("Axial"))
                 }).ToList();

            List<CElement_wavelength> lst =
                (from t in queryIcpElement
                 join p in query on t.Element_wavelength equals p.Element_wavelength into tp
                 from q in tp.DefaultIfEmpty()
                 select new CElement_wavelength
                 {
                     Idelement_wavelength = q == null ? 0 : q.Idelement_wavelength,
                     Idelement = t.Idelement,
                     Wavelength = t.Wavelength,
                     Element_wavelength = t.Element_wavelength,
                     Idl_radial = t.Idl_radial,
                     Idl_axial = t.Idl_axial,
                     Lineality_radial = t.Lineality_radial,
                     Lineality_axial = t.Lineality_axial
                 }).ToList();

            gcElemWavelength.DataSource = new BindingList<CElement_wavelength>(lst);
            
            SaveData();
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

                RetrieveData();
            }
        }

        void SaveData()
        {
            //guardar las filas cuyo valor de idelement_wavelength sea igual a 0
            foreach(CElement_wavelength item in gcElemWavelength.DataSource as BindingList<CElement_wavelength>)
            {
                if (item.Idelement_wavelength == 0)
                {
                    item.Status = true;
                    item.Dateedit = Comun.GetDate();
                    item.Useredit = Comun.GetUser();

                    new CElement_wavelengthFactory().Insert(item);
                }
            }
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
