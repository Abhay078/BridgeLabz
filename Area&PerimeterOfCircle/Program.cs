using System;
namespace Program7
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, rad;
            double area;
            double Peri;
            Console.Write("Enter diameter of circle :- ");
            string s = Console.ReadLine();
            dia=Int32.Parse(s);
            rad = dia/2;
            double d = Math.PI;
            area = d * rad * rad;
            Peri = 2 * d * rad;


            Console.WriteLine();
            Console.WriteLine("The Perimeter of circle is " + Peri + " and area is " + area);
        }
    }
}
