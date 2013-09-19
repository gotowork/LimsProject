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
    public partial class FormSerie : LibraryBasicForm.FormMantBase
    {
        public string Cod_Serie
        {
            set {
                tbCodSerie.Text = value;
            }
            get {
                return tbCodSerie.Text;
            }
        }

        public string Nom_Serie
        {
            set {
                cbNomSerie.Text = value;
            }
            get {
                return cbNomSerie.Text;
            }
        }

        public FormSerie()
        {
            InitializeComponent();
        }

        #region inherit methods

        protected override void Accion_Despues_Grabar()
        {
            base.Accion_Despues_Grabar();
        }

        protected override bool Grabar_Registro()
        {
            CSerieFactory faSerie = new CSerieFactory();
            List<CSerie> lstCorr_modules = faSerie.GetAll();
            
            foreach (CSerie item in lstCorr_modules)
            {
                item.Status_serie = false;
                faSerie.Update(item);                
            }
            
            CSerie oSerie = new CSerie();
            oSerie.Cod_serie = tbCodSerie.Text;
            oSerie.Nom_serie = cbNomSerie.Text;
            oSerie.Dateinit = deDateIni.DateTime;
            oSerie.Dateend = deDateEnd.DateTime;
            oSerie.Status_serie = true;

            bool result = false;
            if (!(result = faSerie.Update(oSerie)))
                result = faSerie.Insert(oSerie);

            return result;
        }

        protected override void Recuperar_Registro()
        {
            CSerie oSerie = new CSerieFactory().GetByPrimaryKey(new CSerieKeys(Cod_Serie));
            if (oSerie != null)
            {
                tbCodSerie.Text = oSerie.Cod_serie;
                cbNomSerie.Text = oSerie.Nom_serie;
                deDateIni.DateTime = Convert.ToDateTime(oSerie.Dateinit);
                deDateEnd.DateTime = Convert.ToDateTime(oSerie.Dateend);
            }
        }

        protected override bool Son_Datos_Correctos()
        {
            if (tbCodSerie.Text.Trim().Length == 0)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Falta ingresar el código de periodo.");
                return false;
            }
            if (cbNomSerie.Text.Trim().Length == 0)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Falta ingresar el nombre del periodo.");
                return false;
            }
            if (deDateIni.Text.Length == 0)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Falta ingresar la fecha inicial");
                return false;
            }
            if (deDateEnd.Text.Length == 0)
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Falta ingresar la fecha final.");
                return false;
            }
            if (new CSerieFactory().GetAll().Exists(c => c.Nom_serie == cbNomSerie.Text && c.Cod_serie != tbCodSerie.Text))
            {
                ComunForm.Send_message(this.Text, TypeMsg.error, "Ya existe un periodo asignado a este código");
                return false;
            }
            return true;
        }

        protected override void Limpiar_Campos()
        {
            tbCodSerie.Text = "";
            cbNomSerie.Text = "";
            deDateIni.Text = "";
            deDateEnd.Text = "";
        }
        
        #endregion 


        private void FormSerie_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year - 1;
            for (int i = year; i < year + 10; i++)
            {
                cbNomSerie.Properties.Items.Add(i.ToString());
            }
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNomSerie.Text.Trim().Length != 0)
            {
                tbCodSerie.Text = cbNomSerie.Text.Substring(2);
                deDateIni.DateTime = new DateTime(Convert.ToInt32(cbNomSerie.Text), 1, 1);
                deDateEnd.DateTime = new DateTime(Convert.ToInt32(cbNomSerie.Text), 12, 31);
            }
        }
    }
}
