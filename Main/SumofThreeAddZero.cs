using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main 
{
    internal class SumofThreeAddZero
    {
        public SumofThreeAddZero() {
            Console.WriteLine("Enter the value of number of elements in array");
            int n=Convert.ToInt32(Console.ReadLine());
            int []arr=new int[n];
            int count = 0;
            for(int i=0; i<n; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n - 1; j++)
                {
                    for(int k = j + 1; k < n - 2; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            count++;
                            Console.WriteLine($"{arr[i]},{arr[j]},{arr[k] }");
                        }
                      
                    }
                }
            }
            Console.WriteLine($"the number of distinct triplet that sum to zero is {count}");
            Console.ReadLine();
        }
    }
}
