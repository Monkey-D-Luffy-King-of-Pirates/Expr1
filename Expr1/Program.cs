using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 43;
            int c = a;

            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);

            int d = 76;
            int e = 51;

            e = e + d;
            d = e - d;
            e = e - d;

            Console.WriteLine(e);
            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}
