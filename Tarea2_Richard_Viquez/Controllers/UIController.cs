using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2_Richard_Viquez.Views;

namespace Tarea2_Richard_Viquez.Controllers
{
    public class UIController
    {
        /// <summary>
        /// Método para cargar dinámicamente un form en el panel del form principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="panel_"></param>
        /// <param name="tipo"></param>
        public  void establecerPanel(object sender,Panel panel_,string tipo)
        {

            try
            {
                if (panel_.Controls.Count > 0)
                {
                    switch (tipo)
                    {
                        case "ConductorUI":
                            panel_.Controls.RemoveAt(0);
                            ConductorUI conductor = sender as ConductorUI;

                            conductor.TopLevel = false;
                            conductor.Dock = DockStyle.Fill;
                            panel_.Controls.Add(conductor);
                            panel_.Tag = conductor;
                            conductor.Show();
                            break;
                        case "CamionUI":
                            panel_.Controls.RemoveAt(0);
                            CamionUI camion = sender as CamionUI;

                            camion.TopLevel = false;
                            camion.Dock = DockStyle.Fill;
                            panel_.Controls.Add(camion);
                            panel_.Tag = camion;
                            camion.Show();
                            break;
                        case "MostrarConductores":

                            panel_.Controls.RemoveAt(0);
                            
                            MostrarConductores conductores = sender as MostrarConductores;

                            conductores.TopLevel = false;
                            conductores.Dock = DockStyle.Fill;
                            panel_.Controls.Add(conductores);
                            panel_.Tag = conductores;
                            conductores.Show();
                            break;
                        case "MostrarCamiones":

                            panel_.Controls.RemoveAt(0);

                            MostrarCamiones camiones = sender as MostrarCamiones;

                            camiones.TopLevel = false;
                            camiones.Dock = DockStyle.Fill;
                            panel_.Controls.Add(camiones);
                            panel_.Tag = camiones;
                            camiones.Show();
                            break;
                        case "ConductorCamionUI":

                            panel_.Controls.RemoveAt(0);

                            ConductorCamionUI conductorCamion = sender as ConductorCamionUI;

                            conductorCamion.TopLevel = false;
                            conductorCamion.Dock = DockStyle.Fill;
                            panel_.Controls.Add(conductorCamion);
                            panel_.Tag = conductorCamion;
                            conductorCamion.Show();
                            break;
                        case "CamionesXConductor":

                            panel_.Controls.RemoveAt(0);

                            CamionesXConductor camionesXConductor = sender as CamionesXConductor;

                            camionesXConductor.TopLevel = false;
                            camionesXConductor.Dock = DockStyle.Fill;
                            panel_.Controls.Add(camionesXConductor);
                            panel_.Tag = camionesXConductor;
                            camionesXConductor.Show();
                            break;
                        default:
                            break;
                    }



                }
                else
                {
                    switch (tipo)
                    {
                        case "ConductorUI":
                           
                            ConductorUI conductor = sender as ConductorUI;

                            conductor.TopLevel = false;
                            conductor.Dock = DockStyle.Fill;
                            panel_.Controls.Add(conductor);
                            panel_.Tag = conductor;
                            conductor.Show();
                            break;
                        case "CamionUI":
                            CamionUI camion = sender as CamionUI;

                            camion.TopLevel = false;
                            camion.Dock = DockStyle.Fill;
                            panel_.Controls.Add(camion);
                            panel_.Tag = camion;
                            camion.Show();
                            break;

                        case "MostrarConductores":
                            MostrarConductores mostrarConductores = sender as MostrarConductores;

                            mostrarConductores.TopLevel = false;
                            mostrarConductores.Dock = DockStyle.Fill;
                            panel_.Controls.Add(mostrarConductores);
                            panel_.Tag = mostrarConductores;
                            mostrarConductores.Show();
                            break;
                        case "MostrarCamiones":

                            MostrarCamiones camiones = sender as MostrarCamiones;

                            camiones.TopLevel = false;
                            camiones.Dock = DockStyle.Fill;
                            panel_.Controls.Add(camiones);
                            panel_.Tag = camiones;
                            camiones.Show();
                            break;
                        case "ConductorCamionUI":


                            ConductorCamionUI conductorCamion = sender as ConductorCamionUI;

                            conductorCamion.TopLevel = false;
                            conductorCamion.Dock = DockStyle.Fill;
                            panel_.Controls.Add(conductorCamion);
                            panel_.Tag = conductorCamion;
                            conductorCamion.Show();
                            break;

                        case "CamionesXConductor":

                            CamionesXConductor camionesXConductor = sender as CamionesXConductor;

                            camionesXConductor.TopLevel = false;
                            camionesXConductor.Dock = DockStyle.Fill;
                            panel_.Controls.Add(camionesXConductor);
                            panel_.Tag = camionesXConductor;
                            camionesXConductor.Show();
                            break;
                        default:
                            break;
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


        /// <summary>
        /// Valida que los campos de texto cumplan con las reglas de base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="pApellido"></param>
        /// <param name="sApellido"></param>
        /// <param name="ruta"></param>
        /// <returns></returns>
        public  bool validaciones(string id, string nombre, string pApellido, string sApellido, string ruta)
        {
          
            //solo números de 9 o 10 de longitud
            var regexId = @"^[0-9]{9,10}$";

            var validarId = Regex.IsMatch(id,regexId);

            //solo letras de 1 a 50 de longitud
            var regexNombrepApellidosApellido = "^[a-zA-Z]{1,50}$";


            var validarNombre = Regex.IsMatch(nombre,regexNombrepApellidosApellido);

            var validarpApellido = Regex.IsMatch(pApellido,regexNombrepApellidosApellido);

            var validarsApellido = Regex.IsMatch(sApellido, regexNombrepApellidosApellido);

            //solo letras o números de 1 a 200 de longitud
            var regexRuta = "^[a-zA-Z0-9]{1,200}$";

            var validarRuta = Regex.IsMatch(ruta,regexRuta);

            if (validarId&&validarNombre&&validarpApellido&&validarsApellido&&validarRuta)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        /// <summary>
        /// Valida que los campos de texto cumplan con las reglas de base de datos
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="anio"></param>
        /// <param name="marca"></param>
        /// <returns></returns>
        public bool validaciones(string placa, string anio, string marca)
        {

            //solo números de 8 de longitud
            var regexId = @"^[a-zA-Z0-9]{8}$";

            var validarId = Regex.IsMatch(placa, regexId);

            //solo numeros de 4 de longitud
            var regexAnioModelo = "^[0-9]{4}$";

            var validarAnio = Regex.IsMatch(anio, regexAnioModelo);

            ////solo letras o numeros de 1 a 50 de longitud
            var regexMarca = "^[a-zA-Z0-9]{1,50}$";

            var validarMarca = Regex.IsMatch(marca, regexMarca);

            if (validarId &&validarAnio&&validarMarca)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}
