using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            base.Recuperar_Registro();
        }

        protected override bool Grabar_Registro()
        {
            return base.Grabar_Registro();
        }

        protected override bool Son_Datos_Correctos()
        {
            return base.Son_Datos_Correctos();
        }
    }
}
