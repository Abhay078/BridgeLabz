using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class WindChill
    {
        public WindChill() {
            double w=0D;
            Console.WriteLine("Enter Temperature value in Fahrenhiet :-");
            double t=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Temperature value in speed of wind(in miles per hour) :-");
            double v=Convert.ToDouble(Console.ReadLine());
            if(t<=50 && v>=3 && v <= 120)
            {
                 w = 35.74 + 0.6215 * t + (0.4275 * t - 35.75) * Math.Pow(v, 0.16);
                Console.WriteLine($"The value of effective temperature (Wind chill) is {w}");
            }
            else
            {
                return;
            }
            
            Console.ReadLine();


        }
    }
}
