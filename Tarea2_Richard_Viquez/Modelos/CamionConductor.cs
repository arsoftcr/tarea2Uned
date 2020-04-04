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
    public class CamionConductor:IDisposable
    {
        private string identificacion;
        private string placa;

        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Placa { get => placa; set => placa = value; }

        public void Dispose()
        {
            Identificacion = null;

            Placa = null;

            GC.Collect();
        }
    }
}
