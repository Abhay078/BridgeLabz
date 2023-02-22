using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Quadratic
    {
        public Quadratic() {
            Console.WriteLine("Please Enter Value of a :- ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please Enter Value of b :-");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please Enter Value of c :-");
            int c = Convert.ToInt16(Console.ReadLine());
            int delta = b * b - 4 * a * c;
            double x1, x2;
            if (delta > 0)
            {
                x1 = -b + Math.Sqrt(delta) / (2 * a);
                x2 = -b - Math.Sqrt(delta) / (2 * a);
                Console.WriteLine("Roots are :- " + x1 + " and " + x2);
            }
            else
            {
                Console.WriteLine("Both roots are imaginary\n No answer");
            }
            Console.ReadLine();
        }
    }
}
