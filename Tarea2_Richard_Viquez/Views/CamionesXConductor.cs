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
    public partial class CamionesXConductor : Form
    {

        private List<Camion> camiones;

        private List<Conductor> conductores;


        private List<CamionConductor> camionConductores;

        private ConductorController conductoresController;

        private CamionConductorController camionConductorController;

        public CamionesXConductor()
        {
            InitializeComponent();

            camiones = new List<Camion>();

            conductores = new List<Conductor>();

            conductoresController = new ConductorController();

            camionConductorController = new CamionConductorController();

            camionConductores = new List<CamionConductor>();
        }

       
        /// <summary>
        /// Evento que se ejecuta cuando se selecciona un item de un listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;

                var seleccionado = listBox1.SelectedItem.ToString();

                foreach (var item in conductores)
                {
                    if (item.Identificacion == seleccionado)
                    {
                        textBox1.Text = item.Nombre;
                        textBox2.Text = item.SegundoApellido;
                        textBox3.Text = item.PrimerApellido;
                        textBox4.Text = item.RutaAsignada;

                        int camiones = item.Camiones != null ? item.Camiones.Count : 0;

                        if (camiones>0)
                        {
                            dataGridView1.DataSource = item.Camiones;
                        }
                    }
                }

               
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        /// <summary>
        /// Evento load se ejecuta inmediatamente despues de lo que esta dentro del constructor 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CamionesXConductor_Load(object sender, EventArgs e)
        {
            conductores = await conductoresController.mostrarConductores();

            for (int i = 0; i < conductores.Count; i++)
            {
                listBox1.Items.Add(conductores[i].Identificacion);

            }

            camionConductores = await camionConductorController.mostrarCamionesConductores();

           await camionConductorController.asignarCamionesAConductores(conductores,camionConductores);
        }
    }
}
