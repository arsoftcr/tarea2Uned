using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2_Richard_Viquez.Views.MessageBoxes
{

    /// <summary>
    /// Creado con el fin de mostrar un mensaje al usuario
    /// </summary>
    public partial class Warning : Form
    {
        public Warning(string mensaje)
        {
            InitializeComponent();

            label1.Text = mensaje;
        }

        private void Warning_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
