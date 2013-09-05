using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LimsProject
{
    public partial class FormCausasRechazo : Form
    {
        public FormCausasRechazo()
        {
            InitializeComponent();
        }

        public void Init()
        {
            List<CRechazo> lstRechazo = new List<CRechazo>();
            lstRechazo.Add(new CRechazo() { Idrechazo = 1, Nombre = "Muestra en envase inadecuado" });
            lstRechazo.Add(new CRechazo() { Idrechazo = 2, Nombre = "Envase roto de la muestra" });
            lstRechazo.Add(new CRechazo() { Idrechazo = 3, Nombre = "Muestra contaminada" });
            lstRechazo.Add(new CRechazo() { Idrechazo = 4, Nombre = "Cantida de muestra inadecuada" });
            lstRechazo.Add(new CRechazo() { Idrechazo = 5, Nombre = "Muestra sin identificacion" });
            lstRechazo.Add(new CRechazo() { Idrechazo = 6, Nombre = "Muestra sin preservante o mal preservada" });
            lstRechazo.Add(new CRechazo() { Idrechazo = 7, Nombre = "Temperatura de transporte inadecuada" });
            lstRechazo.Add(new CRechazo() { Idrechazo = 8, Nombre = "Muestra fuera del periodo de analisis" });
            lstRechazo.Add(new CRechazo() { Idrechazo = 9, Nombre = "No concuerda los datos de la muestra" });
            lstRechazo.Add(new CRechazo() { Idrechazo = 10, Nombre = "Otra causa (especifique)" });

            gridControl1.DataSource = lstRechazo;
        }

        private void FormCausasRechazo_Load(object sender, EventArgs e)
        {
            Init();
        }
    }

    public class CRechazo
    {
        public int Idrechazo { get; set; }
        public string Nombre { get; set; }
    }
}
