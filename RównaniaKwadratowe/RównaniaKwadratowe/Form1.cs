using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RównaniaKwadratowe
{
    using Model;

    public partial class Form1 : Form
    {
        Liczydło model;

        double x1, x2;

        public Form1()
        {
            InitializeComponent();

            model = new Liczydło();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool współczynnikiPoprawne = true;
            double a = 0, b = 0, c = 0;
            try
            {
                a = double.Parse(textBox1.Text);
                textBox1.BackColor = Color.White;
            }
            catch
            {
                współczynnikiPoprawne = false;
                textBox1.BackColor = Color.Pink;
            }

            try
            {
                b = double.Parse(textBox2.Text);
                textBox2.BackColor = Color.White;
            }
            catch
            {
                współczynnikiPoprawne = false;
                textBox2.BackColor = Color.Pink;
            }

            try
            {
                c = double.Parse(textBox3.Text);
                textBox3.BackColor = Color.White;
            }
            catch
            {
                współczynnikiPoprawne = false;
                textBox3.BackColor = Color.Pink;
            }

            if (!współczynnikiPoprawne) return;

            double delta = b * b - 4 * a * c;

           
           
            if (delta >= 0)
            {
                model.Calculate(a, b, c, out x1, out x2);

                MessageBox.Show("Wyniki: " + x1.ToString() + ", " + x2.ToString());
            }
            else MessageBox.Show("Brak wyników");            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            try
            {
                double.Parse(tb.Text);
                tb.BackColor = Color.White;
            }
            catch
            {
                tb.BackColor = Color.Pink;
            }
        }
    }
}
