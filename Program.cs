using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimsProject
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            //Application.Run(new FormQaQcAguas());
            //Application.Run(new FormMultiElement());
            //Application.Run(new FormCausasRechazo());
            //Application.Run(new FormConditions());
            //Application.Run(new FormPrepSamples());
            //Application.Run(new FormPrincipal());
            Application.Run(new FormElemWavelength());
            //Application.Run(new FormTestControlSample());

        }
    }
}
