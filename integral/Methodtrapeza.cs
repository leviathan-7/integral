using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integral
{
    public class Methodtrapeza
    {
        public static double Trapeza(double a, double b, int n, Func<double, double> f)
        {
            var h = (b - a) / n;
            var x = a+h;
            double s = 0;
            for (int i = 1; i < n - 1; i++)
            {
                s += f(x);
                x += h;
            }
            s *= 2;
            s += f(b);
            s += f(a);
            s *= h;
            s /= 2;
            return s;
        }
    }
}
