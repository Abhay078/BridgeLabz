using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class SwapNibbles
    {
        public string ToBinary(int x)
        {
            char[] b=new char[8];
            for(int i = 7; i >= 0; i--)
            {
                int mask = 1 << i;
                if ((x & mask) != 0)
                {
                    b[7-i]= '1';
                }
                else
                {
                    b[7 - i] = '0';
                }
            }
            return new string(b);
        }
        public SwapNibbles() {
            Console.WriteLine("enter the value of integer");
            int num=Convert.ToInt32(Console.ReadLine());
            string binary=ToBinary(num);
            //Console.WriteLine(binary);
            string s1 = binary.Substring(0, 4);
            string s2=binary.Substring(4);
            string n = s2 + s1;
            double p = 0D;
            double sum = 0;
            for(int i=n.Length-1;i>=0;i--)
            {
                if (n[i]== '1')
                {
                    sum += Math.Pow(2, p);
                    p++;
                }
                else
                {
                    p++;
                }

            }
            Console.WriteLine($"The value after swapping the nibbles is {sum}");



            
        }
    }
}
