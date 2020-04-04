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

namespace Tarea2_Richard_Viquez.Views
{
    public partial class Principal : Form
    {
        private UIController UiControl;

        public Principal()
        {
            InitializeComponent();

            UiControl = new UIController();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UiControl.establecerPanel(new ConductorUI(),panel1,"ConductorUI");
        }


      

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UiControl.establecerPanel(new CamionUI(), panel1, "CamionUI");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UiControl.establecerPanel(new MostrarConductores(), panel1, "MostrarConductores");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UiControl.establecerPanel(new MostrarCamiones(), panel1, "MostrarCamiones");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UiControl.establecerPanel(new ConductorCamionUI(), panel1, "ConductorCamionUI");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UiControl.establecerPanel(new CamionesXConductor(), panel1, "CamionesXConductor");
        }
    }
}
