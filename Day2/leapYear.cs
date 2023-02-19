using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class leapYear
    {
        public int year;
        public leapYear()
        {
            Console.WriteLine("Please Enter year ");
            year=Convert.ToInt32(Console.ReadLine());
            if(year%4==0 && year%100 !=0 || year%400==0)
            {
                Console.WriteLine($"{year} is a leap year");

            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");

            }
        }
    }
}
