using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class longestSubstring
    {
        public longestSubstring()
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            int n = s.Length;
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (distinct(s, i, j))
                    {
                        res = Math.Max(res, j - i + 1);
                    }
                }
            }
            Console.WriteLine(res);


        }
        public bool distinct(string s,int i, int j)
        {
            bool[] v = new bool[26];
            for(int k = i; k <= j; k++)
            {
                if (v[s[k] - 'a'] == true)
                {
                    return false;
                }
                v[s[k] - 'a'] = true;
            }


            return true;
        }
       
        
    }
}
