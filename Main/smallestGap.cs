using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class smallestGap
    {
        int diff=int.MaxValue;
        public smallestGap() {
            Console.WriteLine("Enter number of elements you want in array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            
            Console.Write("Enter elements in array :- ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            if (n == 1)
            {
                Console.WriteLine("Array has only one element");
                return;
            }

            for(int i=0; i < n; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    if(Math.Abs(arr[i] - arr[j]) < diff)
                    {
                        diff=Math.Abs(arr[i] - arr[j]);
                    }
                    
                }
            }
            Console.WriteLine($"Minimum gap is :- {diff}");
        }
    }
}
