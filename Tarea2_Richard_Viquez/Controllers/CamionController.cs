using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2_Richard_Viquez.Modelos;

namespace Tarea2_Richard_Viquez.Controllers
{
    /// <summary>
    /// Controla las operaciones para un camión
    /// </summary>
    public class CamionController
    {
        private SQLController sQLController;

        public CamionController()
        {
            sQLController = new SQLController();
        }

        /// <summary>
        /// Inserta un camión en la base de datos
        /// </summary>
        /// <param name="camion"></param>
        /// <returns></returns>
        public async Task<bool> crearCamion(Camion camion)
        {
            bool result = false;

            try
            {

                result = await sQLController.insertarRegistro(camion);
            }
            catch (FormatException f)
            {
                ExcepcionesController.mostrarError(f);
            }
            catch (IndexOutOfRangeException i)
            {
                ExcepcionesController.mostrarError(i);
            }
            catch (ArgumentException a)
            {
                ExcepcionesController.mostrarError(a);
            }
            catch (NullReferenceException n)
            {
                ExcepcionesController.mostrarError(n);
            }
            catch (Exception eb)
            {
                ExcepcionesController.mostrarError(eb);

            }

            return result;
        }



        /// <summary>
        /// Devuelve una lista de camiones
        /// </summary>
        /// <returns></returns>
        public async Task<List<Camion>> mostrarCamiones()
        {
            List<List<Respuesta>> respuestas = new List<List<Respuesta>>();

            List<Camion> camiones = new List<Camion>();

            try
            {
                respuestas = await sQLController.selectRegistro(new Camion());

                camiones = convertirRespuestasACamiones(respuestas);
            }
            catch (FormatException f)
            {
                ExcepcionesController.mostrarError(f);
            }
            catch (IndexOutOfRangeException i)
            {
                ExcepcionesController.mostrarError(i);
            }
            catch (ArgumentException a)
            {
                ExcepcionesController.mostrarError(a);
            }
            catch (NullReferenceException n)
            {
                ExcepcionesController.mostrarError(n);
            }
            catch (Exception eb)
            {
                ExcepcionesController.mostrarError(eb);

            }


            return camiones;
        }


        /// <summary>
        /// Convierte un List<List<Respuesta>> en List<Camion>
        /// </summary>
        /// <param name="respuestas"></param>
        /// <returns></returns>
        private List<Camion> convertirRespuestasACamiones(List<List<Respuesta>> respuestas)
        {
            List<Camion> camiones = new List<Camion>();

            try
            {
                if (respuestas.Count > 0)
                {

                    foreach (var item in respuestas)
                    {
                        Camion camion = new Camion();

                        foreach (var resp in item)
                        {
                            object val = resp.Valor != null ? resp.Valor : "null";

                            string columna = resp.Columna.ToString().ToUpperInvariant();

                            switch (columna)
                            {

                                case "PLACA":
                                    camion.Placa = val != null ? val.ToString() : "null";
                                    break;
                                case "ANNOMODELO":
                                    camion.Modelo =Convert.ToInt64(val != null ? val.ToString() : "0");
                                    break;
                                case "MARCA":
                                    camion.Marca = val != null ? val.ToString() : "null";
                                    break;
                                case "CAPACIDADKG":
                                    camion.CapacidadKilogramos =Convert.ToDecimal(val != null ? val.ToString() : "0");
                                    break;
                                case "CAPACIDADVL":
                                    camion.CapacidadVolumen =Convert.ToDecimal(val != null ? val.ToString() : "0");
                                    break;
                                default:
                                    break;
                            }

                        }

                        camiones.Add(camion);

                    }



                }

            }
            catch (FormatException f)
            {
                ExcepcionesController.mostrarError(f);
            }
            catch (IndexOutOfRangeException i)
            {
                ExcepcionesController.mostrarError(i);
            }
            catch (ArgumentException a)
            {
                ExcepcionesController.mostrarError(a);
            }
            catch (NullReferenceException n)
            {
                ExcepcionesController.mostrarError(n);
            }
            catch (Exception eb)
            {
                ExcepcionesController.mostrarError(eb);

            }


            return camiones;



        }


    }
}
