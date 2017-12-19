using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        List<string> equation = new List<string> { "0" };

        public Form1()
        {
            InitializeComponent();             
        }       
        
        private void b_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
           if (LastOf(equation) == ")")
                equation.Add("*");
            else if (Regex.IsMatch(LastOf(equation), @"^[\/\+\-\*\^(]$"))
                equation.Add("");  
           
            if (LastOf(equation) == "0")
                equation[equation.Count - 1] = button.Text;
            else
                equation[equation.Count - 1] += button.Text;

            RefreshTextbox();
                            
        }

        private void operatorClick(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(LastOf(equation), @"^[\/\+\-\*\^(]$"))            
            {
                Button button = (Button)sender;
                equation.Add(button.Text);
                RefreshTextbox();
            }            
        }

        private void solve(object sender, EventArgs e)
        {
            if (BracketsEqual())
            {
                textBox1.Text = RPN.Calculate(equation);
                equation.Clear();
                equation.Add(textBox1.Text);
            }
        }

        private void period_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(LastOf(equation), @"^[0-9],[0-9]*$") 
                && !Regex.IsMatch(LastOf(equation), @"^[\/\+\-\*\(\)\^]$"))
            {
                Button button = (Button)sender;
                equation[equation.Count - 1] += ",";
                RefreshTextbox();
            }          
            
        }

        private void leftBracket_Click(object sender, EventArgs e)
        {
            if (LastOf(equation) == "0" && equation.Count - 1 == 0)
            {
                equation[0] = "(";                
            }
            else if (Regex.IsMatch(LastOf(equation), @"^[\)]$"))
            {
                equation.Add("*");
                equation.Add("(");
            }
            else equation.Add("(");

            RefreshTextbox();
        }

        private void rightBracket_Click(object sender, EventArgs e)
        {
            if (BracketsOk() && !Regex.IsMatch(LastOf(equation), @"^[\/\+\-\*(\^]$"))
            {
                equation.Add(")");
                RefreshTextbox();
            }
        }

        private bool BracketsOk()
        {
            int lB = 0;
            int rB = 0;
            foreach (string el in equation)
            {
                if (el == "(") lB += 1;
                else if (el == ")") rB += 1;
            }
            return lB > rB;
        }

        private bool BracketsEqual()
        {
            int lB = 0;
            int rB = 0;
            foreach (string el in equation)
            {
                if (el == "(") lB += 1;
                else if (el == ")") rB += 1;
            }

            return lB == rB;
        }

        private string LastOf(List<string> list)
        {
            return list[list.Count - 1];
        }     
        
        private void RefreshTextbox()
        {
            if (!equation.Any())
                equation.Add("0");
            textBox1.Text = String.Join(" ", equation.ToArray());
        }

        private void CE_Click(object sender, EventArgs e)
        {
            equation.RemoveAt(equation.Count -1);
            RefreshTextbox();
        }

        private void C_Click(object sender, EventArgs e)
        {
            equation.RemoveRange(0, equation.Count);
            RefreshTextbox();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                case Keys.D0:
                    b0.PerformClick();
                    break;

                case Keys.NumPad1:
                case Keys.D1:
                    b1.PerformClick();
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    b2.PerformClick();
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    b3.PerformClick();
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    b4.PerformClick();
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    b5.PerformClick();
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    b6.PerformClick();
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    b7.PerformClick();
                    break;
                case Keys.NumPad8:
                case Keys.D8:
                    b8.PerformClick();
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    b9.PerformClick();
                    break;
                case Keys.Add:
                    add.PerformClick();
                    break;
                case Keys.Subtract:
                    substract.PerformClick();
                    break;
                case Keys.Multiply:
                    multiply.PerformClick();
                    break;
                case Keys.Divide:
                    divide.PerformClick();
                    break;
                case Keys.Decimal:
                    point.PerformClick();
                    break;
                case Keys.Enter:
                    equals.PerformClick();
                    break;
                case Keys.C:
                    C.PerformClick();
                    break;


            }




        }
    }    
}
