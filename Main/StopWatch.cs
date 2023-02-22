using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class StopWatch
    {
        public StopWatch() {
            Stopwatch stopwatch= new Stopwatch();
            Console.WriteLine("Please enter yes or no for starting the stopwatch ");
            string s=Console.ReadLine();
            if (s.Equals("yes"))
            {
                stopwatch.Start();
                Console.WriteLine("Please enter no for stoping stopwatch");
                string s1 = Console.ReadLine();
                if (s1.Equals("no"))
                {
                    stopwatch.Stop();
                    Console.WriteLine($"The Elapsed time is {stopwatch.ElapsedMilliseconds} ms");
                }

            }
            Console.ReadLine();
            
            
        }
    }
}
