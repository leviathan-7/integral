using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integral
{
    class Program
    {
        static void Main()
        {
            start:
            Input.Inputfun(out double a, out double b, out int n, out string s);
            var f = String_to_function.Matfun(s);
            var r = Methodrectangle.Rectangle(a, b, n, f);
            var t = Methodtrapeza.Trapeza(a, b, n, f);
            var p = Methodparabola.Parabola(a, b, n, f);
            Console.WriteLine($"rectangle method: {r}");
            Console.WriteLine($"trapeza method: {t}");
            Console.WriteLine($"parabola method: {p}");
            Console.WriteLine($"To restart, press Enter");
            Console.ReadKey();
            goto start;
        }
    }
}
