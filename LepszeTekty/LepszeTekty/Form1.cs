using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LepszeTekty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float max = 0;
        private void Marta(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            if (label1.Text.Length> max)
            {
                max = label1.Text.Length;
            }
            this.Text = (textBox1.Text.Length / max * 255).ToString();
            label1.ForeColor = Color.FromArgb(0, (int)(textBox1.Text.Length / max * 255), 0);
        }
    }
}
