using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class factor
    {
        public factor() {
            Console.Write("Please enter a number that you want to check :- ");
            string s=Console.ReadLine();
            int n= Convert.ToInt32(s);
            if(n%3==0 && n%5==0 && n%7==0)
            {
                Console.WriteLine("PlingPlangPlong");
            
            }
            else if(n%3==0 && n%5==0){
                Console.WriteLine("PlingPlang");

            }
            else if(n%3==0 && n%7==0){
                Console.WriteLine("PlingPlong");
            }

            else if (n % 5 == 0 && n % 7 == 0)
            {
                Console.WriteLine("PlangPlong");
            }

            else if (n % 3==0)
            {
                Console.WriteLine("Pling");
            }
            else if ( n % 7 == 0)
            {
                Console.WriteLine("Plong");
            }
            else if (n % 5 == 0)
            {
                Console.WriteLine("Plang");
            }
            else
            {
                Console.WriteLine(n);
            }



        }
               
            }

        }
    

