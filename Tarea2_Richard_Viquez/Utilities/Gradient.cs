using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2_Richard_Viquez.Utilities
{
    /// <summary>
    /// Clase para crear gradientes en los paneles de los forms
    /// </summary>
    public class Gradient:Panel
    {
        public Color Inicial { get; set; }

        public Color Final { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(
                ClientRectangle,Inicial,Final,90f);

            Graphics g = e.Graphics;

            g.FillRectangle(brush,ClientRectangle);

            base.OnPaint(e);
        }
    }
}
