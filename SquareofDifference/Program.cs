using System;
namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two Numbers ");
            double n = float.Parse(Console.ReadLine());
            double m= float.Parse(Console.ReadLine());
            double square1 = (n+m) * (n+m);
            double square2 = (n - m) * (n - m);
            Console.WriteLine("Square of sum of two number is " + square1);
            Console.WriteLine("Square of difference of two number is " + square2);
        }
    }
}
