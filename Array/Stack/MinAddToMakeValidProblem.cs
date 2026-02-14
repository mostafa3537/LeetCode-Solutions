using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Stack
{
    internal class MinAddToMakeValidProblem
    {
        public int MinAddToMakeValid(string s)
        {
            var stack = new Stack<char>();

            foreach (var c in s)
            {
                switch (c)
                {
                    case '(':
                        stack.Push(c);
                        break;
                    case ')':
                        if (stack.TryPeek(out char res) && res == '(')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            stack.Push(c);

                        }
                        break;

                }
            }

            return stack.Count;
        }
    }
}
