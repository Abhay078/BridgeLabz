using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace main
{
    internal class harmonicNumber
    {
        double sum = 0D;
        public harmonicNumber()
        {
            Console.WriteLine("Enter the value of n");

            int n=Convert.ToInt32(Console.ReadLine());
            if (n != 0)
            {
                for(int i=1; i <= n; i++)
                {
                    sum += (float) 1 / i; 
                }
                Console.WriteLine("The Nth harmonic Number is " + sum);
            }
        }
    }
}
