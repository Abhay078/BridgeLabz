using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Roots
    {
        public Roots()
        {
            Console.WriteLine("Calculating roots of ax^2+bx+c equation");
            Console.WriteLine("Please Enter Value of a :- ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Value of b :-");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Value of c :-");
            int c = Int32.Parse(Console.ReadLine());
            int d = b * b - 4 * a * c;
            double x1, x2;
            if (d == 0)
            {
                Console.WriteLine("Both roots are equals");
                x1 = -b / 2 * a;
                x2 = x1;
                Console.WriteLine("Roots are :- " + x1 + " and " + x2);
            }
            else if (d > 0)
            {
                Console.WriteLine("Both roots are real and different");
                x1 = -b + Math.Sqrt(d) / 2 * a;
                x2 = -b - Math.Sqrt(d) / 2 * a;
                Console.WriteLine("Roots are :- " + x1 + " and " + x2);
            }
            else
            {
                Console.WriteLine("Both roots are imaginary\n No answer");
            }
        }
    }
}
