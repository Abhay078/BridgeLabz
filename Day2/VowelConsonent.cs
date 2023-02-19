using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class VowelConsonent
    {
        public VowelConsonent() {
            try
            {
                char c = Convert.ToChar(Console.ReadLine());
                if (c == 'a' || c == 'e' || c == 'o' || c == 'u' || c == 'i' || c == 'A' || c == 'E' || c == 'O' || c == 'U' || c == 'I')
                {
                    Console.WriteLine("Entered Character is vowel");

                }
                else
                {
                    Console.WriteLine("Entered Character is consonent");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }
    }
}
