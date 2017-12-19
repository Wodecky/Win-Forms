using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorVAT
{
    using Model;
    public partial class Form1 : Form
    {
        Kalkulator model;
        public Form1()
        {
            InitializeComponent();

            model = new Kalkulator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.ChangeVats(decimal.Parse(textBox1.Text), decimal.Parse(textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal kwota = decimal.Parse(textBox3.Text);
            decimal kwotaVat1, kwotaVat2;

            model.ObliczVat(kwota, out kwotaVat1, out kwotaVat2);

            label1.Text = kwotaVat1.ToString();
            label2.Text = kwotaVat2.ToString();

        }
    }
}
