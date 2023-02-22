using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Distance
    {
        public Distance() {
            Console.WriteLine("Enter the value of x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y");
            int y = Convert.ToInt32(Console.ReadLine());
            double res=Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));
            Console.WriteLine($"The Euclidian Distance is {res}");
            Console.ReadLine();
        }
    }
}
