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
    public class Camion:IDisposable
    {
        private string placa;

        private Int64 modelo;

        private string marca;

        private decimal capacidadKilogramos;

        private decimal capacidadVolumen;

        public string Placa { get => placa; set => placa = value; }
        public long Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public decimal CapacidadKilogramos { get => capacidadKilogramos; set => capacidadKilogramos = value; }
        public decimal CapacidadVolumen { get => capacidadVolumen; set => capacidadVolumen = value; }

        public void Dispose()
        {
            Placa = null;
            Marca = null;

            GC.Collect();
        }
    }
}
