using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class SecondLargest
    {
        public SecondLargest() {
            Console.WriteLine("Enter number of elements you want in array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.Write("Enter elements in array :- ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            if (n < 2)
            {
                Console.WriteLine("Array has less than 2 elements");
                return;
            }
            Array.Sort(arr);
            for(int i = n - 2; i >= 0; i--)
            {
                if (arr[i] != arr[n-1]) {
                    Console.WriteLine($"Second Largest number is :-{arr[i]}");
                    return;
                }
            }
            Console.WriteLine("There is no Second largest elements");

        }
    }
}
