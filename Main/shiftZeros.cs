using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class shiftZeros
    {
        public shiftZeros() {
            Console.WriteLine("How many numbers you want to enter");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            int nonZero = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] == 0)
                {
                    continue;
                }
                arr[nonZero] = arr[i];
                nonZero++;


            }
            for(int i=nonZero;i<arr.Length;i++)
            {
                arr[i] = 0;
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
