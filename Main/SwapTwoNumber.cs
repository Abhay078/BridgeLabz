using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class SwapTwoNumber
    {
        public SwapTwoNumber(int a, int b) {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After Swapping the Numbers are :- {a} and {b}");
        }
    }
}
