using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class BubbleGenerics
    {
        public void sort<T>(T[] list )where T : IComparable
        {
            int n=list.Length;
            for(int i=0; i<n-1; i++) {
                
                    for(int j=0;j<n-i-1;j++) {
                        if (list[j].CompareTo(list[j + 1]) > 0)
                        {
                            T temp = list[j];
                            list[j]= list[j + 1];
                            list[j+1]= temp;
                        }
                    }
                }
                for(int i = 0; i < n; i++)
                {
                Console.WriteLine(list[i]);

                }
            }
        }

        
}
            
            
    

