using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class BalancedParenthesis<T>
    {
        
        public  bool IsBalanced(string expression)
        {
            Stack<T> stack =new Stack<T> ();
            foreach(char c in expression)
            {
                if (c.Equals('('))
                {
                    stack.Push((T)(object)c);
                }
                else if(c == ')')
                {
                    if(stack.Count==0 || !stack.Peek().Equals((T)(object)'('))
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }
            return stack.Count == 0;
        }
       
    }
}
