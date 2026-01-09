using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ArrayProblems;

internal class Program
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


    static void Main(string[] args)
    {
        var nums = new int[] { 0, 1, 0, 3, 12 };
        var target = 9;

        MoveZeroes(nums);

        Console.WriteLine();
    }
}

