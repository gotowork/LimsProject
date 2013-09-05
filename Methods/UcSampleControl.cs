using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LimsProject.BusinessLayer;

namespace LimsProject
{
    public partial class UcSampleControl : UserControl
    {
        int? idtemplate_method = null;
        int? type_analisys = null;

        public int? Idtemplate_method
        {
            get {
                return idtemplate_method;
            }
            set {
                idtemplate_method = value;
            }
        }

        public int? Type_analisys
        {
            get {
                return type_analisys;
            }
            set {
                type_analisys = value;
            }
        }

        public UcSampleControl()
        {
            InitializeComponent();
        }

        public void Init(int? pIdtemplat_method, int? pType_analisys)
        {
            idtemplate_method = pIdtemplat_method;
            type_analisys = pType_analisys;
            //get muestras de control
            BindingList<CControl_sample> query =
                new BindingList<CControl_sample>(new CControl_sampleFactory().GetAll().Where(x => x.Idtemplate_method == idtemplate_method && x.Type_analisys == type_analisys).ToList());

            gcSampleControl.DataSource = query;
            
            repType_sample_control.DataSource = new CType_sample_controlFactory().GetAll();
            repType_sample_control.DisplayMember = "Nametsc";
            repType_sample_control.ValueMember = "Idtype_sample_control";
        }

        public bool Son_Datos_Correctos()
        {
            return true;
        }

        public bool Grabar_Registro()
        {
            if (idtemplate_method != null && type_analisys != null)
            {
                // --- borrar sample control
                foreach (CControl_sample item in new CControl_sampleFactory().GetAll().Where(x => x.Idtemplate_method == idtemplate_method && x.Type_analisys == type_analisys && x.Status == true).ToList())
                {
                    item.Status = false;
                    new CControl_sampleFactory().Update(item);
                }

                // --- actualizar o insertar
                foreach (CControl_sample item in gcSampleControl.DataSource as BindingList<CControl_sample>)
                {
                    item.Status = true;
                    if (!new CControl_sampleFactory().Update(item))
                        new CControl_sampleFactory().Insert(item);
                }
            }
            return false;
        }

        public void Recuperar_Registro()
        {            
            BindingList<CControl_sample> query =
                new BindingList<CControl_sample>(new CControl_sampleFactory().GetAll().Where(x => x.Idtemplate_method == idtemplate_method && x.Type_analisys == type_analisys).ToList());

            gcSampleControl.DataSource = query;
        }

        public void Limpiar_Campos()
        {
            idtemplate_method = null;
            type_analisys = null;
            BindingList<CControl_sample> query =
                new BindingList<CControl_sample>(
                    new CControl_sampleFactory()
                    .GetAll()
                    .Where(x => x.Idtemplate_method == idtemplate_method && x.Type_analisys == type_analisys).ToList());

            gcSampleControl.DataSource = query;
        }
    }
}
