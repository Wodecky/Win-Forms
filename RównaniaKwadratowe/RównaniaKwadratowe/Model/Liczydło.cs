using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RównaniaKwadratowe.Model
{
    class Liczydło
    {
        public void Calculate(double a, double b, double c, out double x1, out double x2)
        {
            x1 = 0;
            x2 = 0;
            double delta = b * b - 4 * a * c;
            if (delta >= 0)
            {
                double pierw_delta = Math.Sqrt(delta);
                x1 = (-b + pierw_delta) / (2 * a);
                x2 = (-b - pierw_delta) / (2 * a);
            }
        }
    }
}
