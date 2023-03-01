using System;
namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number as a String");
            string str=Console.ReadLine();
            int num = Int32.Parse(str);
            num = 10 * num;

            string str1 = num.ToString();
            Console.WriteLine(str1);

        }
    }
}
