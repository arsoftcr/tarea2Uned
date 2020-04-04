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
    public partial class MostrarCamiones : Form
    {

        private CamionController camionesController;

        public MostrarCamiones()
        {
            InitializeComponent();

            camionesController = new CamionController();
        }

        private void gradient1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void MostrarCamiones_Load(object sender, EventArgs e)
        {
            List<Camion> camiones = await camionesController.mostrarCamiones();

            for (int i = 0; i < camiones.Count; i++)
            {


                dataGridView1.Rows.Add(camiones[i].Placa, camiones[i].Modelo,
                    camiones[i].Marca, camiones[i].CapacidadKilogramos,
                    camiones[i].CapacidadVolumen);



            }
        }

     
    }
}
