using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2_Richard_Viquez.Views.MessageBoxes;

namespace Tarea2_Richard_Viquez.Controllers
{
    /// <summary>
    /// Crea instancias de los forms creados para mostrar mensajes a los usuarios en sustitución de los 
    /// MessageBox de windows forms
    /// </summary>
    public class MensajeController
    {

        public static void mostrarInfo()
        {
            Succes succes = new Succes();


            succes.ShowDialog();
        }

        public static void  mostrarWarning(string mensaje)
        {
            Warning warning = new Warning(mensaje);

            warning.ShowDialog();
        }

        public static void mostrarError(string mensaje)
        {
            Error error = new Error(mensaje);

            error.ShowDialog();
        }
    }
}
