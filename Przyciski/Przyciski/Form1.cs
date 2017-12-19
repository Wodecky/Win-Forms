using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przyciski
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool pole = false;

        Form2 f;

        private void button1_Click(object sender, EventArgs e)
        {
            if (f==null)
            {
                f = new Form2();
            }
            try
            {
                f.Show();
            }
            catch 
            {
                f = null;
                this.Text = "Brak obiektu okna";
            }

            button1.Text = "Hello World!";
            pole = !pole;

            button1.BackColor = pole ? Color.Red : Color.Lime;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Button b; //zmienna b typu Button
            b = new Button();
            b.Width = 100;
            b.Height = 50;
            b.Left = e.X - b.Width / 2;
            b.Top = e.Y - b.Height / 2;
            b.BackColor = Color.Yellow;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    b.Text = "Lewy";
                    break;
                case MouseButtons.Right:
                    b.Text = "Prawy";
                    break;
                default:
                    b.Text = "Inny";
                    break;
            }
            b.Parent = this; //przycisk umieszczany w oknie
            b.BringToFront();

            b.Click += kliknięciePrzyciskuB;
        }

        private void kliknięciePrzyciskuB(object sender, EventArgs e)
        {
            //this.Text = sender.GetType().Name;
            Button c = sender as Button;
            c.Parent = null;
            c = null;

            this.Text = this.Controls.Count.ToString();
        }
    }
}
