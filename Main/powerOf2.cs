using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class powerOf2
    {
        int n;
        public powerOf2()
        {
            Console.WriteLine("Enter the value of N ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0 && n < 31)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(Math.Pow(2, i) + " ");

                }
            }
            else
            {
                return;
            }
        }
    }
}

