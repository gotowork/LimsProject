using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LimsProject.BusinessLayer;

namespace LimsProject
{
    public partial class FormMaterialReference : LibraryBasicForm.FormMantBase
    {
        #region attributes

        short IDMr = 0;
        BindingList<CMr_detail> lstMr_detail = new BindingList<CMr_detail>();
        BindingList<CStatusMr> lstStatusMr = new BindingList<CStatusMr>();

        #endregion

        #region constructor

        public FormMaterialReference()
        {
            InitializeComponent();
        }

        #endregion

        #region events

        private void FormMaterialReference_Load(object sender, EventArgs e)
        {
            // --- Initialize material of reference
            CMrFactory faMr = new CMrFactory();                        
            cbCodMR.Properties.DataSource = faMr.GetAll();
            cbCodMR.Properties.ValueMember = "Idmr";
            cbCodMR.Properties.DisplayMember = "Cod_mr";
            
            // --- Initialize description sample
            cbDescription.Properties.DataSource = Comun.ListTypeMaterial;
            cbDescription.Properties.ValueMember = "IdTypeMaterial";
            cbDescription.Properties.DisplayMember = "Description";

            // --- Initialize type of analysis
            CDigestion_methodFactory faDigestion_method = new CDigestion_methodFactory();
            repTypeDigestion.DataSource = faDigestion_method.GetAll();
            repTypeDigestion.ValueMember = "Cod_digestion_method";
            repTypeDigestion.DisplayMember = "Name_digestion_method";
                                      
            // --- Initialize the type of material reference
            cbTypeMr.Properties.DataSource = Comun.ListMr;
            cbTypeMr.Properties.DisplayMember = "Den_TypeMr";
            cbTypeMr.Properties.ValueMember = "IdTypeMr";

            // --- Initialize in container grid element
            CElementFactory faElement = new CElementFactory();
            repElement.DataSource = faElement.GetAll();
            repElement.DisplayMember = "Cod_element";
            repElement.ValueMember = "Idelement";
            
            // --- Initialize in container grid unit measurement
            CMeasurement_unitFactory faMeasurement_unit = new CMeasurement_unitFactory();
            repTypeUnit.DataSource = faMeasurement_unit.GetAll();
            repTypeUnit.DisplayMember = "Name_unit";
            repTypeUnit.ValueMember = "Idunit";

            // --- Inititalize list statusMr
            lstStatusMr = new BindingList<CStatusMr>();
            lstStatusMr.Add(new CStatusMr { IDStatusMr = true, Description = "Vigente" });
            lstStatusMr.Add(new CStatusMr { IDStatusMr = false, Description = "No vigente" });
            cbStatus.Properties.DataSource = lstStatusMr;
            cbStatus.Properties.DisplayMember = "Description";
            cbStatus.Properties.ValueMember = "IDStatusMr";

            // --- Initialize in container grid company
            CCompanyFactory faCompany = new CCompanyFactory();
            List<CCompany> lstCompany = faCompany.GetAll().Where(c=> c.Type_company == 'P').ToList();
            
            cbManufacturer.Properties.DataSource = lstCompany;
            cbManufacturer.Properties.DisplayMember = "Business_name";
            cbManufacturer.Properties.ValueMember = "Idcompany";

            cbCertifier.Properties.DataSource = lstCompany;
            cbCertifier.Properties.DisplayMember = "Business_name";
            cbCertifier.Properties.ValueMember = "Idcompany";

            // --- Initialize the grid
            GetDetailMaterialReference();
        }

        #endregion 

        #region inherit methods

        protected override bool Grabar_Registro()
        {
            bool result = false;
            try
            {
                CMrFactory faMr = new CMrFactory();
                CMr oMr = new CMr();

                oMr.Cod_mr = cbCodMR.Text;
                oMr.Idmr = IDMr;
                oMr.Lot = tbLot.Text;
                oMr.Type_material = Convert.ToChar(cbDescription.EditValue);
                oMr.Type_mr = Convert.ToChar(cbTypeMr.EditValue);
                oMr.Status_mr = Convert.ToBoolean(cbStatus.EditValue);
                oMr.Type_material = Convert.ToChar(cbDescription.EditValue);
                oMr.Manufaturer = Convert.ToInt16(cbManufacturer.EditValue);
                oMr.Certifier = Convert.ToInt16(cbCertifier.EditValue);
                oMr.Fbegin_validity = deBegin.DateTime;
                oMr.Fend_validity = deEnd.DateTime;

                
                if (!(result = faMr.Update(oMr)))
                    result = faMr.Insert(oMr);

                if (result)
                {
                    IDMr = oMr.Idmr;

                    // --- detail elements

                    CMr_detailFactory faMr_detail = new CMr_detailFactory();
                    CMr_detail oMr_detail = new CMr_detail();

                    for (int i = 0; i < gvMaterialReference.RowCount; i++)
                    {
                        oMr_detail = (CMr_detail)gvMaterialReference.GetRow(i);
                        oMr_detail.Idmr = IDMr;

                        if (!faMr_detail.Update(oMr_detail))
                            faMr_detail.Insert(oMr_detail);
                    }

                    // --- detail jars
                    CMr_jarFactory faMr_jar = new CMr_jarFactory();
                    CMr_jar oMr_jar = new CMr_jar();

                    for (int i = 0; i < gvOpenCloseJar.RowCount; i++)
                    {
                        oMr_jar = (CMr_jar)gvOpenCloseJar.GetRow(i);
                        oMr_jar.Idmr = IDMr;

                        if (!faMr_jar.Update(oMr_jar))
                            faMr_jar.Insert(oMr_jar);
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                Comun.Send_message(this.Text, TypeMsg.error, ex.Message);
            }
            return result;
        }

        protected override void Accion_Despues_Grabar()
        {
            // --- reference material
            CMrFactory faMr = new CMrFactory();
            cbCodMR.Properties.DataSource = faMr.GetAll();
            cbCodMR.Properties.ValueMember = "Idmr";
            cbCodMR.Properties.DisplayMember = "Cod_mr";
        }

        protected override void Recuperar_Registro()
        {            
            CMr oMr = new CMr();
            CMrFactory faMr = new CMrFactory();
            if ((oMr = faMr.GetByPrimaryKey(new CMrKeys(IDMr))) != null)
            {                
                tbLot.Text = oMr.Lot;
                cbTypeMr.EditValue = Convert.ToChar(oMr.Type_mr);
                cbDescription.EditValue = oMr.Type_material;                                
                cbManufacturer.EditValue = oMr.Manufaturer;
                cbCertifier.EditValue = oMr.Certifier;
                cbStatus.EditValue = oMr.Status_mr;
                deBegin.DateTime = Convert.ToDateTime(oMr.Fbegin_validity);
                deEnd.DateTime = Convert.ToDateTime(oMr.Fend_validity);

                CMr_detail oMr_detail = new CMr_detail();
                CMr_detailFactory faMr_detail = new CMr_detailFactory();
                BindingList<CMr_detail> lstMr_detail = new BindingList<CMr_detail>(new LimsProject.BusinessLayer.Modules.ModMaterialReference().SelectByMr(oMr.Idmr));
                gcMaterialReference.DataSource = lstMr_detail;

                CMr_jarFactory faMr_jar = new CMr_jarFactory();
                CMr_jar oMr_jar = new CMr_jar();
                BindingList<CMr_jar> lstMr_jar = new BindingList<CMr_jar>(new LimsProject.BusinessLayer.Modules.ModMaterialReference().GetJarByMr(IDMr));
                gcOpenCloseJar.DataSource = lstMr_jar;
            }
        }

        protected override void Limpiar_Campos()
        {
            cbCodMR.EditValue = null;
            tbLot.Text = "";
            cbTypeMr.EditValue = null;
            cbDescription.EditValue = null;
            cbCodMR.EditValue = null;
            cbStatus.EditValue = null;
            gcMaterialReference.DataSource = null;
            gcOpenCloseJar.DataSource = null;
            IDMr = 0;
            cbManufacturer.EditValue = null;
            cbCertifier.EditValue = null;
            deBegin.Text = "";
            deEnd.Text = "";
        }

        protected override bool Son_Datos_Correctos()
        {
            if (cbCodMR.EditValue == null)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: no se admite el código del mr vacio.");
                return false;
            }
            if (cbDescription.EditValue == null)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: no se admite la descripción vacia.");
                return false;
            }
            if (cbTypeMr.EditValue == null)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: no se admite el tipo de material de referencia.");
                return false;
            }
            if (cbStatus.EditValue == null)
            {
                Comun.Send_message(this.Text, TypeMsg.error, "Error: no se seleccionó el estado de vigencia.");
                return false;
            }
            if (!isDetailRight())
            {
                return false;
            }
            return true;
        }

        #endregion

        #region methods

        void GetDetailMaterialReference()
        {
            CMr_detailFactory faMr_detail = new CMr_detailFactory();
            lstMr_detail = new BindingList<CMr_detail>(new LimsProject.BusinessLayer.Modules.ModMaterialReference().SelectByMr(IDMr));
            gcMaterialReference.DataSource = lstMr_detail;
        }

        bool isDetailRight()
        {
            for (int i = 0; i < gvMaterialReference.RowCount; i++)
            {
                for (int j = 0; j < gvMaterialReference.VisibleColumns.Count; j++)
                {
                    if (!(gvMaterialReference.Columns[j].Name == "gcMr_Dev_Intern" ||
                        gvMaterialReference.Columns[j].Name == "gcMr_Dev_BetweenLab"))
                    {
                        if (gvMaterialReference.GetRowCellValue(i, gvMaterialReference.Columns[j]) == null)
                        {
                            string msg = "Error: No se seleccionó una opción en la fila {0}, columna {1}  ";
                            Comun.Send_message(this.Text, TypeMsg.error, string.Format(msg, i.ToString(), gvMaterialReference.Columns[j].Caption));
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        #endregion 

        private void paDetalleTop_Leave(object sender, EventArgs e)
        {
            IDMr = 0;
            if (cbCodMR.EditValue != null)
            {
                IDMr = Convert.ToInt16(cbCodMR.EditValue);

                // --- get detail IDMR = 0 (new)
                Recuperar_Registro();
            }
        }

        private void gvOpenCloseJar_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {            
            gvOpenCloseJar.SetRowCellValue(e.RowHandle, gcJar_Idcorrelative, GetMaxJar());
            gvOpenCloseJar.UpdateCurrentRow();            
        }

        short GetMaxJar()
        {
            if (gvOpenCloseJar.RowCount == 0)
                return 1;
            else
                return Convert.ToInt16(gvOpenCloseJar.RowCount);
        }        
                

        private void cbCod_method_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Edit;
            Edit = ((DevExpress.XtraEditors.LookUpEdit)sender).Properties;

            if (e.DisplayValue == null || Edit.NullText.Equals(e.DisplayValue) || string.Empty.Equals(e.DisplayValue))
            {
                return;
            }
            List<CMr> lstMr = (List<CMr>)cbCodMR.Properties.DataSource;
            CMr oMr = new CMr();
            oMr.Cod_mr = e.DisplayValue.ToString();
            oMr.Idmr = -100;

            lstMr.Add(oMr);

            cbCodMR.Properties.DataSource = lstMr;

            // --- referencia material detail
            CMr_detail oMr_detail = new CMr_detail();
            CMr_detailFactory faMr_detail = new CMr_detailFactory();
            BindingList<CMr_detail> lstMr_detail = new BindingList<CMr_detail>(new LimsProject.BusinessLayer.Modules.ModMaterialReference().SelectByMr(0));
            gcMaterialReference.DataSource = lstMr_detail;
            
            // --- jar detail
            CMr_jarFactory faMr_jar = new CMr_jarFactory();
            CMr_jar oMr_jar = new CMr_jar();
            BindingList<CMr_jar> lstMr_jar = new BindingList<CMr_jar>(new LimsProject.BusinessLayer.Modules.ModMaterialReference().GetJarByMr(0));
            gcOpenCloseJar.DataSource = lstMr_jar;

            e.Handled = true;
        }

        private void gvMaterialReference_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvMaterialReference.SetRowCellValue(e.RowHandle, gcMr_Provitional, false);
        }       

    }

    public class CStatusMr
    {
        public bool IDStatusMr { get; set; }
        public string Description { get; set; }
    }
}
