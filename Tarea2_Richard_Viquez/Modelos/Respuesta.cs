using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_Richard_Viquez.Modelos
{
    /// <summary>
    /// Objeto que recibe los valores de una celda de un registro de una tabla Sql Server
    /// </summary>
    public class Respuesta
    {
        public object Columna { get; set; }

        public object Valor { get; set; }
    }
}
