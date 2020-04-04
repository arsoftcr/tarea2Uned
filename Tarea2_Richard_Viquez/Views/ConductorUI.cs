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
    public partial class ConductorUI : Form
    {
        private UIController controlUI;

        private ConductorController conductorController;

        public ConductorUI()
        {
            InitializeComponent();

            controlUI = new UIController();

            conductorController = new ConductorController();
        }

      

        private  async void button1_Click(object sender, EventArgs e)
        {
            bool creado = false;

            if (controlUI.validaciones(textBox1.Text,textBox5.Text,textBox2.Text,textBox3.Text,textBox4.Text))
            {
                using (Conductor conductor = new Conductor())
                {
                    conductor.Identificacion = textBox1.Text;
                    conductor.Nombre = textBox5.Text;
                    conductor.PrimerApellido = textBox2.Text;
                    conductor.RutaAsignada = textBox4.Text;
                    conductor.SegundoApellido = textBox3.Text;

                    creado =
                        await conductorController.crearConductor(conductor);
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

    

        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

      
    }
}
