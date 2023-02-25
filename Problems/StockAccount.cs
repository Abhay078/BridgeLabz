using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class StockAccount
    {
        public void stock(int n3)
        {
            string[]s1= new string[n3+1];
            double[] price= new double[n3+1];
            double[] share= new double[n3+1];
            double sum = 0D;
            for (int i = 1; i <= n3; i++)
            {
                Console.WriteLine($"Enter the name of stock no {i}");
                s1[i] = Console.ReadLine();
                Console.WriteLine($"Enter the share price of {s1[i]} stock");
                price[i]=Convert.ToDouble( Console.ReadLine() );
                Console.WriteLine($"Enter the total shares of {s1[i]} stock");
                share[i]=Convert.ToDouble( Console.ReadLine() );

            }
            Console.WriteLine("The Stock Portfolio is:- ");
            for(int i=1; i <= n3; i++)
            {
                Console.Write($"Value of {s1[i]} Stock is:-  ");
                Console.WriteLine(price[i] * share[i]);
                sum += price[i] * share[i];

            }
            Console.Write("The Total Value of Stock Portfolio is:- "+sum+"\n");



        }
        
        

    }





}
        
    

