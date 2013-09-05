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
    public partial class FormConditions : LibraryBasicForm.FormBaseEmpty
    {
        int Idtemplate_method = 59;

        public FormConditions()
        {
            InitializeComponent();
            Init();
        }

        public FormConditions(int pIdtemplate_method)
        {
            InitializeComponent();
            Idtemplate_method = pIdtemplate_method;
            Init();
        }

        protected override bool Son_Datos_Correctos()
        {
            return base.Son_Datos_Correctos();
        }

        protected override void Recuperar_Registro()
        {
            gcConditions.DataSource = new BindingList<CControl_sample>(new CControl_sampleFactory().GetAll().Where(x => x.Idtemplate_method == Idtemplate_method).ToList());
        }

        protected override bool Grabar_Registro()
        {
            //eliminar filas
            foreach (CControl_sample item in new CControl_sampleFactory().GetAll().Where(x => x.Idtemplate_method == Idtemplate_method))
            {
                item.Status = false;
                new CControl_sampleFactory().Update(item);
            }

            //guardar cambios
            foreach (CControl_sample item in gcConditions.DataSource as BindingList<CControl_sample>)
            {                
                item.Status = true;
                if (!new CControl_sampleFactory().Update(item))
                    new CControl_sampleFactory().Insert(item);
            }
            return true;
        }

        protected override void Limpiar_Campos()
        {
            Idtemplate_method = 0;
            gcConditions.DataSource = new BindingList<CControl_sample>(new CControl_sampleFactory().GetAll().Where(x => x.Idtemplate_method == Idtemplate_method).ToList());
        }

        public void Init()
        {
            repCondition.DataSource = Comun.GetLstCriterio();
            gcConditions.DataSource = new BindingList<CControl_sample>(new CControl_sampleFactory().GetAll().Where(x => x.Idtemplate_method == Idtemplate_method).ToList());
        }
    }
}
