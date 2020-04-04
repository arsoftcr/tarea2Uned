using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2_Richard_Viquez.Modelos;

namespace Tarea2_Richard_Viquez.Controllers
{
    public class ConductorController
    {

		private SQLController SQLController;

		public ConductorController()
		{
			SQLController = new SQLController();
		}

        /// <summary>
        /// Crea un conductor en la base de datos
        /// </summary>
        /// <param name="conductor"></param>
        /// <returns></returns>
        public async Task<bool> crearConductor(Conductor conductor)
        {
            bool result = false;

            try
			{
				
               result= await SQLController.insertarRegistro(conductor);
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
        /// Devuelve una lista de conductores
        /// </summary>
        /// <returns></returns>
        public async Task<List<Conductor>> mostrarConductores()
        {
            List<List<Respuesta>> respuestas = new List<List<Respuesta>>();

            List<Conductor> conductores = null;

            try
            {
              respuestas= await SQLController.selectRegistro(new Conductor());

                conductores = convertirRespuestasAConductores(respuestas);
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


            return conductores;
        }


        /// <summary>
        /// Convierte un List<List<Respuesta>> a un List<Conductor>
        /// </summary>
        /// <param name="respuestas"></param>
        /// <returns></returns>
        private List<Conductor> convertirRespuestasAConductores(List<List<Respuesta>> respuestas)
        {
            List<Conductor> conductores = new List<Conductor>();

            try
            {
                if (respuestas.Count > 0)
                {

                    foreach (var item in respuestas)
                    {
                        Conductor conductor = new Conductor();

                        foreach (var resp in item)
                        {
                            object val = resp.Valor != null ? resp.Valor : "null";

                            string columna = resp.Columna.ToString().ToUpperInvariant();

                            switch (columna)
                            {

                                case "IDENTIFICACION":
                                    conductor.Identificacion = val !=null?val.ToString():"null"; 
                                    break;
                                case "NOMBRE":
                                    conductor.Nombre = val != null ? val.ToString() : "null";
                                    break;
                                case "PRIMERAPELIIDO":
                                    conductor.PrimerApellido = val != null ? val.ToString() : "null";
                                    break;
                                case "SEGUNDOAPELLIDO":
                                    conductor.SegundoApellido = val != null ? val.ToString() : "null";
                                    break;
                                case "RUTAASIGNADA":
                                    conductor.RutaAsignada = val != null ? val.ToString() : "null";
                                    break;
                                default:
                                    break;
                            }

                        }

                        conductores.Add(conductor);

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


            return conductores;
           
        
           
        }


    }
}

