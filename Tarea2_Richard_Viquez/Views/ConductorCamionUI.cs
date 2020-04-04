using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2_Richard_Viquez.Controllers;
using Tarea2_Richard_Viquez.Modelos;

namespace Tarea2_Richard_Viquez.Views
{
    public partial class ConductorCamionUI : Form
    {
        private CamionController camionesController;

        private ConductorController conductoresController;

        private CamionConductorController camionConductorController;

        private List<Camion> camiones;

        private List<Conductor> conductores;

        public ConductorCamionUI()
        {
            InitializeComponent();

            camionesController = new CamionController();

            conductoresController = new ConductorController();

            camiones = new List<Camion>();

            conductores = new List<Conductor>();

            camionConductorController = new CamionConductorController();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (listaCamiones.SelectedItem!=null
                &&listaConductores.SelectedItem!=null)
            {
                CamionConductor camionConductor = new CamionConductor
                {
                    Identificacion=listaConductores.SelectedItem.ToString(),
                    Placa=listaCamiones.SelectedItem.ToString()
                };

              bool resultado= await camionConductorController.asociarCamion(camionConductor);

                if (resultado)
                {
                    MensajeController.mostrarInfo();
                }
                else
                {
                    MensajeController.mostrarWarning("El proceso no se pudo realizar. Por favor intente de nuevo");
                }
            }
            else
            {
                MensajeController.mostrarWarning("Datos incorrectos. Por favor verifique los datos");
            }
        }

        private async void ConductorCamionUI_Load(object sender, EventArgs e)
        {
            camiones = await camionesController.mostrarCamiones();

             conductores = await conductoresController.mostrarConductores();

            for (int i = 0; i < conductores.Count; i++)
            {
                listaConductores.Items.Add(conductores[i].Identificacion);

            }

            for (int i = 0; i < camiones.Count; i++)
            {
                listaCamiones.Items.Add(camiones[i].Placa);

            }
        }

        private void listaConductores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var seleccionado = listaConductores.SelectedItem.ToString();

                foreach (var item in conductores)
                {
                    if (item.Identificacion == seleccionado)
                    {
                        textBox1.Text = $"{item.Nombre} {item.PrimerApellido} {item.SegundoApellido}";
                 
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

        private void listaCamiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var seleccionado = listaCamiones.SelectedItem.ToString();

                foreach (var item in camiones)
                {
                    if (item.Placa == seleccionado)
                    {
                        textBox2.Text = $"{item.Marca} {item.Modelo} {item.CapacidadKilogramos} {item.CapacidadVolumen}";

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
