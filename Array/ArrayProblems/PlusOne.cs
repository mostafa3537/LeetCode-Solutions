using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.StringProblems
{
    internal class PlusOne
    {
        public static int[] PlusOneProb(int[] digits)
        {
            var length = digits.Length;

            var right = length - 1;


            while (right >= 0 && digits[right] == 9)
            {
                digits[right] = 0;
                right--;
            }
            if (right < 0)
            {

                var newDigits = new int[length + 1];

                newDigits[0] = 1;

                return newDigits;
            }

            else
            {
                digits[right]++;
                return digits;
            }

        }
    }
}
