using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class _2dArray { 
    
       public _2dArray()
    {
            Console.WriteLine("Enter the value of element outer array ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of element inner array ");
            int m=Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n,m];
            for(int i = 0; i < n; i++)
            {
                for(int j=0;j < m; j++)
                {
                    array[i,j]=Convert.ToInt32(Console.ReadLine());

                }
                
            }
            //for printing
            Console.WriteLine("Elements in array are:- ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write( array[i,j]+" ");

                }
                Console.WriteLine(" ");

            }
            Console.ReadLine();


        }

    }
}
