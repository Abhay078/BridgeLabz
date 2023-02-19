using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class EvenOdd
    {
        public EvenOdd() {
            Console.WriteLine("Please Enter The number");
            int n=Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Given Number is Even.");
            }
            else
            {
                Console.WriteLine("Given Number is odd.");
            }
        }
    }
}
