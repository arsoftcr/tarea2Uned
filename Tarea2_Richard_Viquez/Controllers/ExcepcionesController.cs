using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2_Richard_Viquez.Controllers
{
    /// <summary>
    /// Contiene los mensajes que se muestran al usuario
    /// </summary>
    public class ExcepcionesController
    {
        public static void mostrarError(Exception e)
        {
            MensajeController.mostrarError(e.Message);
        }

        public static void mostrarError(FormatException e)
        {
            MensajeController.mostrarError(e.Message);
        }

        public static void mostrarError(IndexOutOfRangeException e)
        {
            MensajeController.mostrarError(e.Message);
        }

        public static void mostrarError(NullReferenceException e)
        {
            MensajeController.mostrarError(e.Message);
        }

        public static void mostrarError(ArgumentException e)
        {
            MensajeController.mostrarError(e.Message);
        }

        public static void mostrarError(SqlException s)
        {
            if (s.Message.Contains("PRIMARY"))
            {
                MensajeController.mostrarError("Lo sentimos, este objeto ya existe en la base de datos. No se permiten duplicados");
                
            }
            else
            {
                MensajeController.mostrarError(s.Message);
            }
        }
    }
}
