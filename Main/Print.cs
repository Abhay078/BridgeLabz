using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main 
{   
    internal class Print
    {
        public Print()
        {
            int i = 0;
        begin:
            i += 1;
            Console.Write(i + " ");
            if (i < 100)
            {
                goto begin;
            }
        }
    }
}
