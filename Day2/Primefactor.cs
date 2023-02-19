using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Primefactor
    {
        public Primefactor() {
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 2;
            while (n > 1)
            {
                if (n % c == 0)
                {
                    Console.Write(c + " ");
                    n /= c;
                }
                else
                {
                    c++;
                }
            }

        }
    }
}
