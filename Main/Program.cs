using System;
using System.Diagnostics;

namespace main
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
                "\n Press 5 for Checking the presence of a,e and p\n Press 6 for Average of float array elements\n" +
                " Press 7 for Prime Numbers in array \n Press 8 For Shifting all zero to end of array \n Press 9 for finding first repeated element in array \n " +
                "Press 10 for Checking valid operator and solve the expression \n Press 11 for longest substring without repeating characters \n " +
                "Press 12 for deleting element in array from desired position \n Press 13 for second largest element in array" +
                "\n Press 14 for removing duplicates from array and store distinct elements in new array"+
                 "\n Press 15 for Calculating smallest gap between array elements \n Press 16 for finding probability of head vs tail" +
                 "\n Press 17 for Finding leap year \n Press 18 for Finding table of power of two \n Press 19 for Find nth Harmonic Number" +
                 "\n Press 20 for Find Prime factors of a gievn number \n Press 21 for finding Qoutient and Remainder" +
                 "\n Press 22 for Swapping two numbers \n Press 23 for Identifying Given number is even or odd " +
                 "\n Press 24 for Idetifying given character is vowel or consonent \n Press 25 for Finding Largest among three " +
                 "\n Press 26 for input and printing 2d array \n Press 27 for finding triplet that sums to zero" +
                 "\n Press 28 for finding Euclidian Distance \n Press 29 for solving the quadratic equation" +
                 "\n Press 30 for finding WindChill from temp and wind speed \n Press 31 for simulating gambling" +
                 "\n Press 32 for simulating stopwatch \n Press 33 for Tic-Tac-Toe Game \n Press 34 for Random Number count" +
                 "\n Press 35 for Exit  ");
            
            
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
                        Average average= new Average();
                        break;
                    case 7:
                        primeNumber prime= new primeNumber();
                        break;
                    case 8:
                        shiftZeros s = new shiftZeros();
                        break;
                    case 9:
                        repeatedElement r=new repeatedElement();
                        break;
                    case 10:
                        validateArithmetic v=new validateArithmetic();
                        break;
                    case 11:
                        longestSubstring l=new longestSubstring();
                        break;
                    case 12:
                        deleteElement delete=new deleteElement();
                        break;
                    case 13:
                        SecondLargest second=new SecondLargest();
                        break;
                    case 14:
                        removeDuplicate remove=new removeDuplicate();
                        break;
                    case 15:
                        smallestGap gap=new smallestGap();
                        break;
                    case 16:
                        Coin c=new Coin();  
                        break;
                    case 17:
                        leapYear leap =new leapYear();
                        break;
                    case 18:
                        powerOf2 power= new powerOf2();
                        break;
                    case 19:
                        harmonicNumber harmonic = new harmonicNumber();
                        break;
                    case 20:
                        Primefactor P= new Primefactor();   
                        break;
                    case 21:
                        QoutientRemainder q=new QoutientRemainder();
                        break;
                    case 22:
                        Console.WriteLine("Enter the value of both Number");
                        int x=Convert.ToInt32(Console.ReadLine());
                        int  y= Convert.ToInt32(Console.ReadLine());
                        SwapTwoNumber swap = new SwapTwoNumber(x, y);
                        break;
                    case 23:
                        EvenOdd e1= new EvenOdd();
                        break;
                    case 24:
                        VowelConsonent v1=new VowelConsonent();
                        break;
                    case 25:
                       LargestAmongThree largest=new LargestAmongThree();
                        break;
                    case 26:
                        _2dArray array=new _2dArray();
                        break;
                    case 27:
                        SumofThreeAddZero sumof=new SumofThreeAddZero();
                        break;
                    case 28:
                        Distance distance =new Distance();
                        break;
                    case 29:
                        Quadratic quadratic =new Quadratic();
                        break;
                    case 30:
                        WindChill windChill = new WindChill();
                        break;
                    case 31:
                        Gambler gambler = new Gambler();
                        break;
                    case 32:
                        StopWatch stopWatch= new StopWatch();
                        break;
                    case 33:
                        Cross Tic= new Cross();
                        break;
                    case 34:
                        CouponNumber cs= new CouponNumber();
                        break;
                    case 35:
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

