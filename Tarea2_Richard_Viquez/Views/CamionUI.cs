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
    public partial class CamionUI : Form
    {
        private CamionController camionController;

        private UIController uIController;

        public CamionUI()
        {
            InitializeComponent();

            camionController = new CamionController();

            uIController = new UIController();
        }

       
        
        private async void button1_Click(object sender, EventArgs e)
        {
            bool creado = false;


            if (uIController.validaciones(textBox1.Text,textBox2.Text,textBox3.Text))
            {
                bool kg = !string.IsNullOrWhiteSpace(numericUpDown1.Text) ? true : false;
                bool vol = !string.IsNullOrWhiteSpace(numericUpDown2.Text) ? true : false;

                using (Camion camion = new Camion())
                {
                    camion.Placa = textBox1.Text;
                    camion.Modelo = Convert.ToInt32(textBox2.Text);
                    camion.Marca = textBox3.Text;
                    camion.CapacidadKilogramos = Convert.ToDecimal(numericUpDown1.Text);
                    camion.CapacidadVolumen = Convert.ToDecimal(numericUpDown2.Text);

                    creado = await camionController.crearCamion(camion);
                }

                if (creado)
                {
                    MensajeController.mostrarInfo();

                    limpiar();
                }
                else
                {
                    MensajeController.mostrarWarning("Los datos suministrados no son correctos");
                }
            }
            else
            {
                MensajeController.mostrarWarning("Los datos suministrados no son correctos");
            }
       
          
          
        }

        /// <summary>
        /// Limpia los datos de los cuadros de texto luego de insertar el registro en la base de datos
        /// </summary>
        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            numericUpDown1.Value = 0.00m;
            numericUpDown2.Value = 0.00m;
        }

  
    }
}
