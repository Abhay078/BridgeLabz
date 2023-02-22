using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace main
{
    internal class validateArithmetic
    {
        public validateArithmetic() {
            Console.WriteLine("Enter the Arithmatic expression");
            string s=Console.ReadLine();
            

            Regex rx=new Regex(@"([0-9]{1,}[\+,-,/,\*]{1}[0-9]{1,}$)");
            Match match=rx.Match(s);
            if (match.Success)
            {
                Console.WriteLine("Statement is valid");
                //calculating expression
                DataTable dt = new DataTable();
                double answer = (int)dt.Compute(s, "");
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("Statement is invalid");
            }

            
        }
    }
}
