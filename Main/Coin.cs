using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Coin
    {
        int tcount=0;
        int hcount=0;
        public Coin() { 
            int n=Convert.ToInt32(Console.ReadLine());
            int temp = n;
            
            if (n > 0)
            {
                while (temp > 0)
                {
                    Random random = new Random();
                    double d = random.NextDouble();
                    if (d > 0.5)
                    {
                        tcount++;

                    }
                    else
                    {
                        hcount++;
                    }
                    temp--;
                }
                Console.WriteLine($"Percentage of head is {hcount * 100 / n}");
                Console.WriteLine($"Percentage of tail is {tcount * 100 / n}");


            }
            else
            {
                Console.WriteLine("Please provide valid numbers");
                return;
            }
        }
    }
}
