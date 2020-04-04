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
    public partial class MostrarConductores : Form
    {

        private ConductorController conductorController;

        public MostrarConductores()
        {
            InitializeComponent();

            conductorController = new ConductorController();
        }

        private async void MostrarConductores_Load(object sender, EventArgs e)
        {
            List<Conductor> conductores=await conductorController.mostrarConductores();

            for (int i = 0; i < conductores.Count; i++)
            {
              

                dataGridView1.Rows.Add(conductores[i].Identificacion, conductores[i].Nombre,
                    conductores[i].PrimerApellido, conductores[i].SegundoApellido,
                    conductores[i].RutaAsignada);

               

            }
        }

     

    }
}
