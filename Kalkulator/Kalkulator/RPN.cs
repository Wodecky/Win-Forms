using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kalkulator
{
    static class RPN
    {
        public static string Calculate(List<string> equation)
        {
            return CalculateRPN(ShuntingYard(equation));
        }

        static private Dictionary<string, int> dict = new Dictionary<string, int>() {
            {"^", 4 },
            {"*", 3 },
            {"/", 3 },
            {"+", 2 },
            {"-", 2 } };

        static List<string> ShuntingYard(List<string> infix)
        {
            List<string> output = new List<string>();
            Stack<string> operators = new Stack<string>();
            double a;

            foreach (string token in infix)
            {
                if (Double.TryParse(token, out a))
                    output.Add(token);
                else if (Regex.IsMatch(token, @"^[\^\*\/\+\-]$"))
                {
                    while (operators.Count != 0 && operators.Peek() != "(" && dict[token] <= dict[operators.Peek()])
                    {
                        output.Add(operators.Pop());
                    }
                    operators.Push(token);
                }
                else if (token == "(")
                    operators.Push(token);
                else if (token == ")")
                {
                    while (operators.Peek() != "(")
                    {
                        output.Add(operators.Pop());
                    }
                    operators.Pop();
                }
                else
                    System.Windows.Forms.MessageBox.Show("Unknwn token :(");
            }
            while (operators.Count > 0)
            {
                output.Add(operators.Pop());
            }
            return output;
        }

        static string CalculateRPN(List<string> equationRPN)
        {
            while (equationRPN.Count > 1)
            {
                for (int i = 1; i < equationRPN.Count; i++)
                {
                    if (Regex.IsMatch(equationRPN[i], @"^[\/\*\-\+\^]$"))
                    {
                        string op = equationRPN[i];
                        double arg2 = Double.Parse(equationRPN[i - 1]);
                        double arg1 = Double.Parse(equationRPN[i - 2]);
                        string result = "";

                        switch (op)
                        {
                            case "+":
                                result = (arg1 + arg2).ToString();
                                break;
                            case "-":
                                result = (arg1 - arg2).ToString();
                                break;
                            case "*":
                                result = (arg1 * arg2).ToString();
                                break;
                            case "/":
                                result = (arg1 / arg2).ToString();
                                break;
                            case "^":
                                result = (Math.Pow(arg1, arg2)).ToString();
                                break;
                        }

                        equationRPN[i - 2] = result;
                        equationRPN.RemoveAt(i - 1);
                        equationRPN.RemoveAt(i - 1);
                        i -= 2;                        
                    }
                }
            }
            return equationRPN[0];
        }
    }
}
