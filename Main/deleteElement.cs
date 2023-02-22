using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class deleteElement
    {
        public deleteElement()
        {
            Console.WriteLine("Enter number of elements you want in array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.Write("Enter elements in array :- ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Which position element you want to delete");
            int p = Convert.ToInt32(Console.ReadLine());
            for (int i = p - 1; i < n-1; i++)
            {
                arr[i] = arr[i + 1];
            }
            for (int i = 0; i < n-1; i++)
            {
                Console.Write(arr[i] + " ");

            }
        }
    }
}
