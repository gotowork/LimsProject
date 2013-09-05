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
    public partial class FormMatrizGrupo : Form
    {
        public FormMatrizGrupo()
        {
            InitializeComponent();
        }

        private void FormMatrizGrupo_Load(object sender, EventArgs e)
        {
            Init();
        }

        void Init()
        {
            List<CMatriz_grupo> LstMatriz_grupo = new List<CMatriz_grupo>();
            LstMatriz_grupo.Add(new CMatriz_grupo() { Id = 1, Nombre = "Agua natural subterranea", Sigla = "AN" });
            LstMatriz_grupo.Add(new CMatriz_grupo() { Id = 2, Nombre = "Agua natural superficial", Sigla = "AN" });
            LstMatriz_grupo.Add(new CMatriz_grupo() { Id = 3, Nombre = "Agua natural Agua residual", Sigla = "AR" });
            LstMatriz_grupo.Add(new CMatriz_grupo() { Id = 4, Nombre = "Agua para el uso de consumo humano", Sigla = "ACH" });
            LstMatriz_grupo.Add(new CMatriz_grupo() { Id = 5, Nombre = "Agua salina", Sigla = "AS" });
            LstMatriz_grupo.Add(new CMatriz_grupo() { Id = 6, Nombre = "Agua de proceso", Sigla = "Apr" });

            gridControl1.DataSource = LstMatriz_grupo;
        }
    }
}
