using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day2
{
    internal class validateArithmetic
    {
        public validateArithmetic() {
            Console.WriteLine("Enter the Arithmatic expression");
            string s=Console.ReadLine();
            String ex = @"([0-9][+,-,/,*][0-9]$)";
            Regex rx=new Regex(ex);
            if (rx.IsMatch(s))
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
