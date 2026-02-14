using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Stack
{
    internal class ValidParenthesesProblem
    {
        public bool IsValid(string s)
        {
            var result = true;

            var stack = new Stack<char>();

            foreach (var c in s)
            {
                switch (c)
                {
                    case '(':
                        stack.Push(c);
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(')
                        {
                            return false;
                        }
                        break;

                    case '[':
                        stack.Push(c);
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[')
                        {
                            return false;
                        }
                        break;

                    case '{':
                        stack.Push(c);
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{')
                        {
                            return false;
                        }
                        break;
                }
            }

            if (stack.Count > 0)
            {
                return false;
            }


            return result;
        }
    }
}
