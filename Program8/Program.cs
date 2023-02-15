using System;

namespace Program8 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a Year :- ");
            int year, date, month;
            year = Int32.Parse(Console.ReadLine());
            Console.Write("Input a month :- ");
            month=Int32.Parse(Console.ReadLine());
            Console.Write("Input a date :- ");
            date=Int32.Parse(Console.ReadLine());
            date++;
            if(date>31)
            {
                month++;
                if (month > 12)
                {
                    year++;
                    date = 1;
                    month = 1;
                }
                
            }
            else if(date>28 && month == 2)
            {
                month++;
                date = 1;
            }
            else if(date>30 && month==4 || month==6 || month==9 || month==11){
                month++;
                date = 1;

            }
            Console.WriteLine("");
            Console.WriteLine(year+"-"+month+"-"+date);
        }
    }
}
