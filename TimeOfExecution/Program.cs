using System;
using System.Diagnostics;
namespace Program9
{

    class Program
    {

        static public void Main()
        {
            var watch = Stopwatch.StartNew();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Abhay");
                Console.WriteLine("Srivastava");
            }
            watch.Stop();
            Console.WriteLine("The Execution time of the program is " + watch.ElapsedMilliseconds + "ms");
        }
    }
}
