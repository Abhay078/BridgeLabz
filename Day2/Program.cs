using System;
using System.Diagnostics;

namespace Day2
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            while (b)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Hello User ! \n This is an interactive app that have 5 options :- \n " +
                "Press 1 for Factorial functions \n Press 2 for Printing number from 1 to 100 \n " +
                "Press 3 for Roots of Quadratic Equation \n Press 4 for Print conditional statements on String" +
                "\n Press 5 for Checking the presence of a,e and p \n Press 6 for exit ");
            
            
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Factorial factorial = new Factorial();
                        Console.Write("Enter the number you want the factorial of :- ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("factorial is " + factorial.Fact(n));
                        break;
                    case 2:
                        Print p = new Print();
                        break;
                    case 3:
                        Roots roots = new Roots();
                        break;
                    case 4:
                        factor f = new factor();
                        break;
                    case 5:
                        Presence presence = new Presence();
                        break;
                    case 6:
                        b = false;
                        break;
                    default:
                        Console.WriteLine("Thanks for Using the App");
                        break;
                }
            }

            
            


        }
    }
}

