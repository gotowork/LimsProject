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
    public partial class FormMatrixItems : LibraryBasicForm.FormBaseEmpty
    {
        public FormMatrixItems()
        {
            InitializeComponent();
        }

        void Init()
        {
            repGroupMatrix.DataSource =
                new LimsProject.BusinessLayer.Modules.Reception()
                .GetAllMatrixGroup();

            repGroupMatrix.DisplayMember = "Name";
            repGroupMatrix.ValueMember = "Code";

            gcMatrixItems.DataSource = new BindingList<CMatrix_item>(new CMatrix_itemFactory().GetAll().Where(x => x.Status == true).ToList());
        }

        protected override bool Son_Datos_Correctos()
        {
            foreach (CMatrix_item item in gcMatrixItems.DataSource as BindingList<CMatrix_item>)
            {
                if (item.Description.Trim().Length == 0)
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "Error al ingresar la descripción de un item.");
                    return false;
                }
                if (item.Name_item.Trim().Length == 0)
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "Error al ingresar el nombre de la matriz.");
                    return false;
                }
                if (item.Idmatrix_group == null)
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "Error al ingresar el grupo de la matriz");
                    return false;
                }
            }
            return true;
        }

        protected override void Limpiar_Campos()
        {
            gcMatrixItems.DataSource = new BindingList<CMatrix_item>(new CMatrix_itemFactory().GetAll().Where(x => x.Status == true).ToList());
        }

        protected override void Recuperar_Registro()
        {
            gcMatrixItems.DataSource = new BindingList<CMatrix_item>(new CMatrix_itemFactory().GetAll().Where(x => x.Status == true).ToList());
        }

        protected override bool Grabar_Registro()
        {
            try
            {         
                //eliminar items                
                foreach (CMatrix_item item in new CMatrix_itemFactory().GetAll())
                {
                    item.Status = false;
                    new CMatrix_itemFactory().Update(item);
                }

                //grabar items
                BindingList<CMatrix_item> lstGrid = gcMatrixItems.DataSource as BindingList<CMatrix_item>;
                foreach (CMatrix_item item in lstGrid)                
                {
                    item.Status = true;
                    if (!new CMatrix_itemFactory().Update(item))
                        new CMatrix_itemFactory().Insert(item);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al guardar: "+ex.Message);
                return false;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Limpiar_Campos();
        }

        private void FormMatrixItems_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}
