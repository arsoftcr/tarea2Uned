using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2_Richard_Viquez.Modelos;

namespace Tarea2_Richard_Viquez.Controllers
{
    /// <summary>
    /// Controlador para asociar y mostrar camniones de un conductor
    /// </summary>
    public class CamionConductorController
    {
        private SQLController sQLController;

        public CamionConductorController()
        {
            sQLController = new SQLController();
        }

        /// <summary>
        /// Asocia un camión a un conductor
        /// </summary>
        /// <param name="camionConductor"></param>
        /// <returns></returns>
        public async Task<bool> asociarCamion(CamionConductor camionConductor)
        {
            bool result = false;

            try
            {

                result = await sQLController.insertarRegistro(camionConductor);
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
        /// Devuelve una lista de objetos CamionConductor 
        /// </summary>
        /// <returns></returns>
        public async Task<List<CamionConductor>> mostrarCamionesConductores()
        {
            List<List<Respuesta>> respuestas = new List<List<Respuesta>>();

            List<CamionConductor> camionesConductores = new List<CamionConductor>();

            try
            {
                respuestas = await sQLController.selectRegistro(new CamionConductor());

                camionesConductores = convertirRespuestasACamionesConductores(respuestas);
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


            return camionesConductores;
        }


        /// <summary>
        /// Convierte una lista de List<List<Respuesta>> en un List<CamionConductor>
        /// </summary>
        /// <param name="respuestas"></param>
        /// <returns></returns>
        private List<CamionConductor> convertirRespuestasACamionesConductores(List<List<Respuesta>> respuestas)
        {
            List<CamionConductor> camionesConductores = new List<CamionConductor>();

            try
            {
                if (respuestas.Count > 0)
                {

                    foreach (var item in respuestas)
                    {
                        CamionConductor camionConductor = new CamionConductor();

                        foreach (var resp in item)
                        {
                            object val = resp.Valor != null ? resp.Valor : "null";

                            string columna = resp.Columna.ToString().ToUpperInvariant();

                            switch (columna)
                            {
                                case "IDENTIFICACION":
                                    camionConductor.Identificacion= val != null ? val.ToString() : "null";
                                    break;
                                case "PLACA":
                                    camionConductor.Placa = val != null ? val.ToString() : "null";
                                    break;
                               
                                default:
                                    break;
                            }

                        }

                        camionesConductores.Add(camionConductor);

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


            return camionesConductores;



        }


        /// <summary>
        /// Asigna los camiones asociados a cada conductor  a la propiedad Camiones de cada conductor
        /// </summary>
        /// <param name="conductors"></param>
        /// <param name="camionConductors"></param>
        /// <returns></returns>
        public async Task asignarCamionesAConductores(List<Conductor> conductors,
            List<CamionConductor> camionConductors)
        {
            CamionController camionController = new CamionController();

            //se obtienen los camiones
            List<Camion> camiones =await camionController.mostrarCamiones();



            try
            {
                //se inicializan las listas de camiones para cada conductor
                foreach (var item in conductors)
                {
                    item.Camiones = new List<Camion>();
                }
                // se asignan los camiones a los conductores recorriendo las listas
                foreach (var item in conductors)
                {

                    foreach (var items in camionConductors)
                    {
                        if (item.Identificacion==items.Identificacion)
                        {
                            var placa = items.Placa;

                            foreach (var camion in camiones)
                            {
                                if (placa==camion.Placa)
                                {
                                   
                                    item.Camiones.Add(camion);
                                }
                            }
                        }
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
        }


    }
}
