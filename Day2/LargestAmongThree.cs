using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class LargestAmongThree
    {
        public LargestAmongThree()
        {
            Console.WriteLine("Enter Three Numbers");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1>n3)
            {
                Console.WriteLine($"Largest number among three is {n1}");
            }
            else if (n2 > n3 && n2>n1)
            {
                Console.WriteLine($"Largest number among three is {n2}");
            }
            else if (n1 == n2 && n2== n3)
            {
                Console.WriteLine("All number are equals");
            }
            else
            {
                Console.WriteLine($"Largest number among three is {n3}");
            }
        }
    }
}
    