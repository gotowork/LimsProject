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
    public partial class FormPruebas : Form
    {
        public FormPruebas()
        {
            InitializeComponent();
        }

        public void init()
        {
            List<CCriterio> lstCriterio = new List<CCriterio>();
            lstCriterio.Add(new CCriterio() { Idcriterio = 1, Nombre_criterio = "igual" });
            lstCriterio.Add(new CCriterio() { Idcriterio = 2, Nombre_criterio = "diferente" });
            lstCriterio.Add(new CCriterio() { Idcriterio = 3, Nombre_criterio = "menor" });
            lstCriterio.Add(new CCriterio() { Idcriterio = 4, Nombre_criterio = "mayor" });
            lstCriterio.Add(new CCriterio() { Idcriterio = 5, Nombre_criterio = "mayor o igual" });
            lstCriterio.Add(new CCriterio() { Idcriterio = 6, Nombre_criterio = "menor o igual" });
            lstCriterio.Add(new CCriterio() { Idcriterio = 7, Nombre_criterio = "Entre" });

            List<CUnidad_medida> lstUnidadMedida = new List<CUnidad_medida>();
            lstUnidadMedida.Add(new CUnidad_medida() { Nombre = "mg/L" });
            lstUnidadMedida.Add(new CUnidad_medida() { Nombre = "UCV escala pt Co" });
            lstUnidadMedida.Add(new CUnidad_medida() { Nombre = "uS/cm" });
            lstUnidadMedida.Add(new CUnidad_medida() { Nombre = "UNT" });
            lstUnidadMedida.Add(new CUnidad_medida() { Nombre = "NMP / 100 mL" });
            lstUnidadMedida.Add(new CUnidad_medida() { Nombre = "Presencia/100 mL" });            

            List<CDecreto_detail> lstDecreto = new List<CDecreto_detail>();
            lstDecreto.Add(new CDecreto_detail() { Criterio = 3, Parametro = "Plata - Ag", Unidad_medida = "mg/L", Valor1 = "0.01", Idmetodo = 1 });
            lstDecreto.Add(new CDecreto_detail() { Criterio = 7, Parametro = "Ph", Unidad_medida = "mg/L", Valor1 = "6.5", Valor2 = "8.5", Idmetodo = 6 });
            lstDecreto.Add(new CDecreto_detail() { Criterio = 5, Parametro = "Oxigeno Disuelto", Unidad_medida = "mg/L", Valor1 = "6", Idmetodo = 7 });
            lstDecreto.Add(new CDecreto_detail() { Criterio = 1, Parametro = "Olor ", Valor1 = "Aceptable", Idmetodo = 8 });
            lstDecreto.Add(new CDecreto_detail() { Criterio = 1, Parametro = "Salmonella sp.", Unidad_medida = "NMP / 100 mL", Valor1 = "Ausencia", Idmetodo = 9 });

            List<CMetodoDecreto> lstMetodoDecreto = new List<CMetodoDecreto>();
            lstMetodoDecreto.Add(new CMetodoDecreto() { Idmetodo = 1, Nombre = "802 - Ag" });
            lstMetodoDecreto.Add(new CMetodoDecreto() { Idmetodo = 2, Nombre = "802 - Al" });
            lstMetodoDecreto.Add(new CMetodoDecreto() { Idmetodo = 3, Nombre = "802 - Arsenico" });
            lstMetodoDecreto.Add(new CMetodoDecreto() { Idmetodo = 4, Nombre = "802 - Ba" });
            lstMetodoDecreto.Add(new CMetodoDecreto() { Idmetodo = 5, Nombre = "802 - B" });  
            lstMetodoDecreto.Add(new CMetodoDecreto() { Idmetodo = 6, Nombre = "808 - pH" });
            lstMetodoDecreto.Add(new CMetodoDecreto() { Idmetodo = 7, Nombre = "841 - Oxigeno" });
            lstMetodoDecreto.Add(new CMetodoDecreto() { Idmetodo = 8, Nombre = "804 - Olor" });
            lstMetodoDecreto.Add(new CMetodoDecreto() { Idmetodo = 9, Nombre = "878 - Salmonela" });            

            repUnidadMedida.DataSource = lstUnidadMedida;
            repUnidadMedida.DisplayMember = "Nombre";
            repUnidadMedida.ValueMember = "Nombre";

            repCriterio.DataSource = lstCriterio;
            repCriterio.DisplayMember = "Nombre_criterio";
            repCriterio.ValueMember = "Idcriterio";

            repMetodo.DataSource = lstMetodoDecreto;
            repMetodo.DisplayMember = "Nombre";
            repMetodo.ValueMember = "Idmetodo";

            gridControl1.DataSource = new BindingList<CDecreto_detail>(lstDecreto);

            principal("test", test1);
            
        }

        private void FormDecretos_Load(object sender, EventArgs e)
        {
            init();            
        }

        Dictionary<string, Delegate> dicFunction = new Dictionary<string, Delegate>();

        public void principal(string nombre, Func<CCriterio, CDecreto_detail, CMetodoDecreto, decimal> function)
        {
            dicFunction.Add(nombre, function);
        }

        public decimal test1(CCriterio criterio, CDecreto_detail decreto, CMetodoDecreto metodo)
        {
            return criterio.Idcriterio + decreto.Idmetodo + metodo.Idmetodo;
        }
    }

    

    public class CDecreto
    {
        public string Codigo { get; set; }
        public string Denominacion { get; set; }
        public string Descripcion { get; set; }
    }

    public class CDecreto_detail
    {        
        public string Parametro { get; set; }
        public string Unidad_medida { get; set; }        
        public int Criterio { get; set; } // 1:igual, 2:diferente, 3:menor, 4:mayor, 5:mayor o igual, 6:menor o igual 
        public string Valor1 { get; set; }
        public string Valor2 { get; set; }
        public int Idmetodo { get; set; }
    }

    public class CDecreto_detail_result
    {        
        public string Parametro { get; set; }
        public string Unidad_medida { get; set; }
        public int Criterio { get; set; } // 1:igual, 2:diferente, 3:menor, 4:mayor, 5:mayor o igual, 6:menor o igual 
        public decimal Result { get; set; }
        public string Conclusion { get; set; }
        public string Valor1 { get; set; }
        public string Valor2 { get; set; }
        public int Idmetodo { get; set; }
    }

    public class CMetodoDecreto
    {
        public int Idmetodo { get; set; }
        public string Nombre { get; set; }
    }
}
