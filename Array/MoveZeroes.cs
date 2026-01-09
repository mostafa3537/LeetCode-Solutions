using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal class MoveZeroesProblem
    {
        public static void MoveZeroes(int[] numbers)
        {
            var write = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    numbers[write] = numbers[i];
                    write++;
                }

            }

            for (int i = write; write < numbers.Length; write++)
            {
                numbers[write] = 0;
            }
        }
    }
}
