using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class primeNumber
    {
        public primeNumber() {
            
            Console.WriteLine("How many numbers you want to enter");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr= new int[n];

            for(int i = 0; i < n; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(arr[i]);

            }
            Console.WriteLine("The prime Numbers In array are :- ");
            for (int i = 0; i < n; i++)
            {
                bool F = false;
                for (int j = 2; j < arr[i]; j++)
                {
                    
                    if (arr[i] % j == 0)
                    {
                        F = true;
                    }
                    
                }
                if (F==false)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }


        }
    }
}
