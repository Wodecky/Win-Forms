using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsystentZakupów
{
    using Model;

    public partial class Form1 : Form
    {
        Sumator model;
          
        public Form1()
        {
            InitializeComponent();

            model = new Sumator(1000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal kwota = decimal.Parse(textBox1.Text);
                if (model.Add(kwota))
                {
                    label1.Text = model.Sum.ToString();
                }
                else
                {
                    throw new Exception("Dodanie kwoty nie powiodło się");
                }
                

            }
            catch (Exception exc)
            {
                
                MessageBox.Show(
                exc.Message,
                Text,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
