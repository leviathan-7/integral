using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integral
{
    public class Methodrectangle
    {
        public static double Rectangle(double a, double b, int n, Func<double, double> f)
        {
            var h = (b - a) / n;
            var x = a + h/2;
            double s = 0;
            for (int i = 1; i < (2*n-1); i++)
            {
                if (i %2 !=0)
                {
                    s += f(x);
                }
                x += h/2;
            }
            s *= h;
            return s;
        }
    }
}
