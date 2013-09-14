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
    public partial class FormFactorEstequiometrico : LibraryBasicForm.FormBaseEmpty
    {
        public FormFactorEstequiometrico()
        {
            InitializeComponent();
        }

        protected override void Limpiar_Campos()
        {
            base.Limpiar_Campos();
        }

        protected override void Recuperar_Registro()
        {
            gcFactorEstequ.DataSource = 
                new BindingList<CFactor_estequiometrico>(new CFactor_estequiometricoFactory()
                    .GetAll()
                    .Where(x => x.Status == true)
                    .ToList());            
        }

        protected override bool Grabar_Registro()
        {
            try
            {
                // eliminar todo
                foreach (CFactor_estequiometrico item in new CFactor_estequiometricoFactory().GetAll())
                {
                    item.Status = false;
                    new CFactor_estequiometricoFactory().Update(item);
                }

                // guardar
                foreach (CFactor_estequiometrico item in gcFactorEstequ.DataSource as BindingList<CFactor_estequiometrico>)
                {
                    item.Status = true;
                    item.Dateedit = Comun.GetDate();
                    item.Useredit = Comun.GetUser();
                    if (!new CFactor_estequiometricoFactory().Update(item))
                    {
                        item.Useredit = Comun.GetUser();
                        item.Datenew = Comun.GetDate();
                        new CFactor_estequiometricoFactory().Insert(item);
                    }
                }                
                return true;
            }
            catch (Exception ex)
            {
                Comun.Send_message("Factores estequiométricos", TypeMsg.error, ex.Message);
                return true;
            }
        }

        protected override bool Son_Datos_Correctos()
        {
            int i = 0;
            foreach (CFactor_estequiometrico item in gcFactorEstequ.DataSource as BindingList<CFactor_estequiometrico>)
            {
                i++;
                if (item.Idelement == null)
                {
                    Comun.Send_message("Factores estequiométricos", TypeMsg.error, "No se seleccionó el elemento en la fila "+ i.ToString());
                    return false;
                }
                if (item.Idcompound == null)
                {
                    Comun.Send_message("Factores estequiométricos", TypeMsg.error, "No se seleccionó el compuesto en la fila " + i.ToString());
                    return false;
                }
                if (item.Factor == 0)
                {
                    Comun.Send_message("Factores estequiométricos", TypeMsg.error, "No se ingresó el factor en la fila " + i.ToString());
                    return false;
                }
            }
            return true;
        }

        private void FormFactorEstequiometrico_Load(object sender, EventArgs e)
        {
            // inicializar combos
            repElement.DataSource = new CElementFactory().GetAll().OrderBy(x=> x.Cod_element).ToList();
            repElement.ValueMember = "Idelement";
            repElement.DisplayMember = "Cod_element";

            repCompound.DataSource = new CCompoundFactory().GetAll().OrderBy(x => x.Name_compound).ToList();
            repCompound.ValueMember = "Idcompound";
            repCompound.DisplayMember = "Name_compound";

            Recuperar_Registro();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (Son_Datos_Correctos())
            {
                if (Grabar_Registro())
                    MessageBox.Show("Guardado correctamente.");                
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Recuperar_Registro();
        }
    }
}
