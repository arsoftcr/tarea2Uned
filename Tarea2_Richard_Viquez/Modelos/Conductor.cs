using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_Richard_Viquez.Modelos
{
    /// <summary>
    /// Implementa IDisposable para liberar recursos
    /// https://docs.microsoft.com/en-us/dotnet/api/system.idisposable?view=netframework-4.8
    /// </summary>
    public class Conductor:IDisposable
    {
        private string identificacion;

        private string primerApellido;

        private string nombre;

        private string segundoApellido;

        private string rutaAsignada;

        private List<Camion> camiones;

        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public string RutaAsignada { get => rutaAsignada; set => rutaAsignada = value; }
        public List<Camion> Camiones { get => camiones; set => camiones = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public void Dispose()
        {
            Identificacion = null;
            PrimerApellido = null;
            SegundoApellido = null;
            RutaAsignada = null;
            Camiones = null;
            Nombre = null;

            GC.Collect();
        }
    }
}
