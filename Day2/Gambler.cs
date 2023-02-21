using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Gambler
    {
        public Gambler() {
            Console.WriteLine("Enter the value of Stake in $");
            int stake=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter te value of goal in $");
            int goal=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number of times you want to play");
            int n=Convert.ToInt32(Console.ReadLine());
            Random random=new Random();
            int win = 0;
            int loss = 0;

            Console.WriteLine("------------Game Starts------------");
            for(int i=1;i <= n; i++)
            {
                
                if (stake != goal || stake !=0)
                {
                    int rnd = random.Next(0, 2);
                    if (rnd == 1)
                    {
                        stake++;
                        win++;
                    }
                    else
                    {
                        stake--;
                        loss++;

                    }
                }

            }
            double pwin = (win * 100.0 / n);
            double ploss = (loss * 100.0 / n);
            Console.WriteLine($"The Number of wins is {win} and percentage of win is {pwin} " +
                $"while percentage of loss is {ploss}");
            Console.ReadLine();

        }
    }
}
