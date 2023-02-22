using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class repeatedElement
    {
        public repeatedElement()
        {
            Console.WriteLine("How many numbers you want to enter");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            bool f = false;
            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine($"First repeated element is {arr[i]}");
                  
                        f = true;
                    }
                    
                }
                if (f == true)
                {
                    break;
                }
            }
        }
    }
}
