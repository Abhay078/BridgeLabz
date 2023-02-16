using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Average
    {
        double sum = 0D;
        public Average() {
            
            Console.WriteLine("How many numbers you want to enter");
            int n=Convert.ToInt32(Console.ReadLine());
            double [] f= new double[n];
            Console.WriteLine("Enter decimal numbers");
            for(int i=0; i<n; i++)
            {
                f[i]=Convert.ToDouble(Console.ReadLine());
                sum+= f[i];
                
            }
            double avg=sum/n;
            Console.Write($"Average of these numbers are :- {avg} ");
            
        }

    }
}
