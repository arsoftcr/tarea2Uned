using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2_Richard_Viquez.Views;

namespace Tarea2_Richard_Viquez
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
            Application.Run(new Principal());

            //Establecer la cultura de la aplicación para que a la hora de guardar los datos decimales en la base
            //de datos los datos sean consistentes
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");


        }
    }
}
