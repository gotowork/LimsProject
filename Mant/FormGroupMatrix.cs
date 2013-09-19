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
    public partial class FormGroupMatrix : LibraryBasicForm.FormBaseEmpty
    {
        public FormGroupMatrix()
        {
            InitializeComponent();
        }

        void Init()
        {
            gcGroupMatrix.DataSource = new BindingList<CMatrix_group>(new CMatrix_groupFactory().GetAll().Where(x=> x.Status == true).ToList());
        }

        protected override bool Son_Datos_Correctos()
        {
            foreach (CMatrix_group item in gcGroupMatrix.DataSource as BindingList<CMatrix_group>)
            {
                if (item.Name_group.Trim().Length == 0)
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "Error al escribir nombre de grupo.");
                    return false;                    
                }
                if (item.Sigla.Trim().Length == 0)
                {
                    ComunForm.Send_message(this.Text, TypeMsg.error, "Error al escribir sigla.");
                    return false;
                }
            }
            return true;
        }

        protected override void Limpiar_Campos()
        {
            gcGroupMatrix.DataSource = new BindingList<CMatrix_group>(new CMatrix_groupFactory().GetAll().Where(x=> x.Status == true).ToList());
        }

        protected override void Recuperar_Registro()
        {
            gcGroupMatrix.DataSource = new BindingList<CMatrix_group>(new CMatrix_groupFactory().GetAll().Where(x => x.Status == true).ToList());
        }

        protected override bool Grabar_Registro()
        {
            try
            {
                BindingList<CMatrix_group> lstGrid = gcGroupMatrix.DataSource as BindingList<CMatrix_group>;
                //eliminar todo
                List<CMatrix_group> lstMg = new CMatrix_groupFactory().GetAll();
                foreach (CMatrix_group item in lstMg)
                {
                    item.Status = false;
                    new CMatrix_groupFactory().Update(item);
                }

                //grabar desde el grid
                foreach (CMatrix_group item in lstGrid)
                {
                    item.Status = true;
                    if (!new CMatrix_groupFactory().Update(item))
                        new CMatrix_groupFactory().Insert(item);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
                return false;
            }            
        }

        private void FormGroupMatrix_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Grabar();
        }


    }
}
