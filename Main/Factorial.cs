using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main  
{
    
     class Factorial
    {
          public int Fact(int n)
        {
            int f = 1;
            if (n == 0)
            {
                return 1;
            }
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }

         
    }

}

