using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class removeDuplicate
    {
        public removeDuplicate() {
            Console.WriteLine("Enter number of elements you want in array");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[n];
            Console.Write("Enter elements in array :- ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }
            bool[] b= new bool[arr.Length];
            string[] s= new string[arr.Length];
            int Count = 1;
            for(int i = 0; i < n; i++)
            {
                if (b[i] == true)
                {
                    continue;
                }
                for(int j = i + 1; j < n - 1; j++)
                {
                    if (arr[i].Equals(arr[j]))
                    {
                        b[j] = true;
                        Count++;
                    }

                }
                s[i] = arr[i];
            }
            for(int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] +" ");
            }
            
        }
    }
}
