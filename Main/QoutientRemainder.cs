using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class QoutientRemainder
    {
        internal QoutientRemainder() {
            Console.WriteLine("Enter the value of dividend");
            int d=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of divisor");
            int divi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qoutient is :-  "+d/divi);
            Console.WriteLine("Remainder is:-  "+d%divi);


        }

    }
}
