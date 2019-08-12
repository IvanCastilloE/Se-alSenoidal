using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeñalSenoidal
{
    class Program
    {
        static void Main(string[] args)
        {
            SeñalSenoidal señalSenoidal;
            señalSenoidal = new SeñalSenoidal();
            Console.WriteLine(señalSenoidal.evaluar(0));
            Console.WriteLine(señalSenoidal.evaluar(0.05));
            Console.WriteLine(señalSenoidal.evaluar(0.1));
            Console.WriteLine(señalSenoidal.evaluar(0.15));
            Console.WriteLine(señalSenoidal.evaluar(0.2));
            Console.WriteLine(señalSenoidal.evaluar(0.25));
            Console.WriteLine(señalSenoidal.evaluar(0.3));
            Console.WriteLine(señalSenoidal.evaluar(0.35));
            Console.WriteLine(señalSenoidal.evaluar(0.4));
            Console.WriteLine(señalSenoidal.evaluar(0.45));
            Console.WriteLine(señalSenoidal.evaluar(0.5));



            Console.Read();
        }
    }
}
