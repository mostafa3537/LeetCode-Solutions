using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.HashTablesProblems
{
    internal class IsHappyProblem
    {
        public static bool IsHappy(int n)
        {
            var dict = new Dictionary<string, int>();

            string resultNumber = n.ToString();

            if (resultNumber == "1")
            {
                return true;
            }

            while (true)
            {
                resultNumber = Happy(resultNumber);

                if (resultNumber == "1")
                {
                    return true;
                }
                else
                {
                    if (dict.ContainsKey(resultNumber))
                    {
                        return false;

                    }
                    else
                    {
                        dict.Add(resultNumber, 1);
                    }

                }
            }
        }

        private static string Happy(string num)
        {
            var res = 0;

            for (int i = 0; i < num.Length; i++)
            {
                var number = int.Parse(num[i].ToString());

                res += number * number;
            }

            return res.ToString();
        }
    }
}
