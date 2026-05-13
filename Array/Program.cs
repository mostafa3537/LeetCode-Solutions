namespace Problems;

using System;
using System.Collections.Generic;


internal class Program
{
	public static int[] BuildArray(int[] nums)
	{
		var result = new int[nums.Length];

		for (int i = 0; i < nums.Length; i++)
		{
			var itemToPush = nums[nums[i]];

			result[i] = itemToPush;
		}

		return result;
	}

	static void Main(string[] args)
	{
		var input = new int[] { 0, 2, 1, 5, 3, 4 };
		var result = BuildArray(input);
 
		Console.WriteLine(result);
	}
}
