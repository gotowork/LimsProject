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
    public partial class FormMatriz : Form
    {
        public FormMatriz()
        {
            InitializeComponent();
        }

        public void init()
        {
            List<CMatriz_grupo> LstMatriz_grupo = new List<CMatriz_grupo>();
            LstMatriz_grupo.Add(new CMatriz_grupo() { Id = 1, Nombre = "Agua natural subterranea", Sigla = "AN" });
            LstMatriz_grupo.Add(new CMatriz_grupo() { Id = 2, Nombre = "Agua natural superficial", Sigla = "AN" });
            LstMatriz_grupo.Add(new CMatriz_grupo() { Id = 3, Nombre = "Agua natural Agua residual", Sigla = "AR" });
            LstMatriz_grupo.Add(new CMatriz_grupo() { Id = 4, Nombre = "Agua para el uso de consumo humano", Sigla = "ACH" });
            LstMatriz_grupo.Add(new CMatriz_grupo() { Id = 5, Nombre = "Agua salina", Sigla = "AS" });
            LstMatriz_grupo.Add(new CMatriz_grupo() { Id = 6, Nombre = "Agua de proceso", Sigla = "Apr" });

            List<CMatriz_item> LstMatriz_item = new List<CMatriz_item>();
            LstMatriz_item.Add(new CMatriz_item() { Id = 1, Denominacion = "Agua de manantial", Descripcion = "Agua que emerge de la tierra o entre las rocas", Flag_acreditado = true, IDMatriz_grupo = 1, Matriz = "Agua Natura Subterranea - Agua de manantial", Sigla = "Amt" });
            LstMatriz_item.Add(new CMatriz_item() { Id = 2, Denominacion = "Agua termal", Descripcion = "bla, bla, bla", Flag_acreditado = true, IDMatriz_grupo = 1, Matriz = "Agua Natura Subterranea - Agua de manantial", Sigla = "AT" });
            LstMatriz_item.Add(new CMatriz_item() { Id = 3, Denominacion = "Agua de rio", Descripcion = "bla, bla, bla", Flag_acreditado = true, IDMatriz_grupo = 2, Matriz = "Agua Natura Superficial - Agua de rio", Sigla = "AR" });
            LstMatriz_item.Add(new CMatriz_item() { Id = 4, Denominacion = "Agua de laguna", Descripcion = "bla, bla, bla", Flag_acreditado = true, IDMatriz_grupo = 2, Matriz = "Agua Natura Superficial - Agua de laguna", Sigla = "AL" });

            var query =
                (from m in LstMatriz_grupo
                 from n in LstMatriz_item.Where(c => c.IDMatriz_grupo == m.Id)
                 select new
                 {
                     Sigla_grupo = m.Sigla,
                     Grupo = m.Nombre,
                     n.Sigla,
                     n.Matriz,
                     n.Denominacion,
                     n.Descripcion                     
                 }).ToList();


            gridControl1.DataSource = query;
            gridView1.BestFitColumns();
        }

        private void FormMatriz_Load(object sender, EventArgs e)
        {
            init();
        }
    }

    public class CMatriz_grupo
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Nombre { get; set; }
    }

    public class CMatriz_item
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Matriz { get; set; }        
        public string Denominacion { get; set; }
        public string Descripcion { get; set; }
        public bool Flag_acreditado { get; set; }
        public int IDMatriz_grupo { get; set; }
    }
}
