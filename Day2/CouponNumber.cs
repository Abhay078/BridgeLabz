using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class CouponNumber
    {
        public CouponNumber() {
            Console.WriteLine("Enter Value of distinct randoom number you want to Generate");
            int n=Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int [] num=new int[n];
            Random random= new Random();
            int i = 0;
            while (n > 0)
            {
                num[i] =random.Next(1,100);
                count++;
                for(int k = 0; k < i; k++)
                {
                    for(int j = k + 1; j < i - 1; j++)
                    {
                        if (num[i] == num[j])
                        {
                            num[j]=random.Next(1,100);
                            count++;

                        }
                    }
                }
                i++;
                n--;

            }
            Console.WriteLine($"The random number generated for N distinct numbers are {count}");
            Console.ReadLine();
        
        }
    }
}
