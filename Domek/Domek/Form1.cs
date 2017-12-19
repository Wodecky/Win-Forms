using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domek
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
            int w = ClientSize.Width;
            int h = ClientSize.Height;

            //Backgroung
            BackColor = Color.Blue;
            g.FillRectangle(Brushes.Green, 0, h / 2, w, h / 2);

            // sun
            g.FillEllipse(Brushes.Yellow, w * 7 / 10, h * 1 / 8, w * 2 / 10, h * 2 / 8);
            double angle = Math.PI / 4;
            for (int i = 0; i < 8; i++)
            {
                int cos = w * 8 / 10 + 2 * Convert.ToInt32(w / 10 * Math.Cos(i * angle));
                int sin = h * 2 / 8 + 2 * Convert.ToInt32(h / 8 * Math.Sin(i * angle));

                g.DrawLine(new Pen(Color.Yellow), w * 8 / 10, h * 2 / 8, cos, sin);
            }

            for (int i = 0; i < 20; i++)
            {
                int j = w/19*i;
                Point[] fence = { new Point(0+j, h/2),
                                  new Point(w/40 +j, h*9/20),
                                  new Point(w/20 +j, h/2),
                                  new Point(w/20 + j, h*5/6),
                                  new Point(0+j, h*5/6)};
                g.FillPolygon(Brushes.Brown, fence);
            }

            //house
            g.FillRectangle(Brushes.White, w * 1 / 10, h * 1 / 3, w * 1 / 2, h * 1 / 2);
            g.FillRectangle(Brushes.Brown, w * 3 / 10, h * 1 / 2, w * 1 / 10, h * 2 / 6);
            g.FillRectangle(Brushes.Cyan, w * 3 / 20, h * 1 / 2, w * 1 / 10, h * 1 / 6);
            g.FillRectangle(Brushes.Cyan, w * 9 / 20, h * 1 / 2, w * 1 / 10, h * 1 / 6);


            Point[] points = { new Point(w / 20, h / 3),
                               new Point(w * 2 / 10, h / 6),
                               new Point(w *5/10, h / 6),
                               new Point(w *13/20, h/3)};
            g.FillPolygon(Brushes.Red, points);

            
            
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
