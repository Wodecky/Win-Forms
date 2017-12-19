using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogoUMK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color b = Color.White;

            int w = ClientSize.Width;
            int h = ClientSize.Height;
            BackColor = b;
            float a = 3F;
            float c = 2.25F * a;

            g.FillEllipse(Brushes.Blue, 0, 0, w, h * 9 / 10);            
            g.FillEllipse(Brushes.White, w/2 - w/(2*a), h*10/11 - h*1/(2*a), w * 1 / a, h * 1/a*10/11);
            g.FillEllipse(Brushes.Blue, w / 2 - w / (2 * c), h * 10 / 11 - h * 1 / (2 * c), w * 1 / c, h * 1 / c * 10 / 11);
            g.FillEllipse(Brushes.Yellow, w/2 - w/(2*a), h*5/11 - h*1/(2*a), w * 1 / a, h * 1/a*10/11);


        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
