using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PamięćKolorów
{
    public partial class Form1 : Form
    {
        Color previousColor = new Color();
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void ColourSelection(object sender, EventArgs e)
        {
            previousColor = this.BackColor;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    this.BackColor = Color.Red;
                    break;
                case 1:
                    this.BackColor = Color.Green;
                    break;
                case 2:
                    this.BackColor = Color.Blue;
                    break;
                default:
                    break;
            }
        }

        private void PreviousColor(object sender, EventArgs e)
        {
            Color tmp = this.BackColor;
            this.BackColor = previousColor;
            previousColor = tmp;            
        }

        private void RandomColour(object sender, EventArgs e)
        {
            previousColor = this.BackColor;
            BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (; Opacity > 0; Opacity -= 0.01)
            {
                System.Threading.Thread.Sleep(10);
            }
        }
    }
}
