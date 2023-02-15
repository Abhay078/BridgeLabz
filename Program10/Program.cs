using System;
namespace Program10
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 2000; i <= 3200; i++)
            {
                if(i%7==0 && i%5!=0)
                {
                    Console.Write(i + ",");
                }
            }
        }
    }
}
