using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace integral
{
    public class Input
    {
        public static void Inputfun(out double a, out double b, out int  n,out string s) 
        {
            Console.WriteLine("enter a:");
            a= double.Parse(Console.ReadLine()); 
            Console.WriteLine("enter b:");
            b = double.Parse(Console.ReadLine());
            Debug.Assert(a<=b);
            Console.WriteLine("enter f(x):");
            s = Console.ReadLine();
            Console.WriteLine("enter n (number of partitions in the interval):");
            n = int.Parse(Console.ReadLine());
            Debug.Assert(n>0);
        }
    }
}
