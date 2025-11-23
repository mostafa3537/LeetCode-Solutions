using System;
using System.Linq;

namespace Array;

internal class Program
{
	public static int RemoveElement(int[] nums, int val)
	{
		int k = 0;

		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] != val)
			{
				nums[k] = nums[i];
				k++;
			}
		}

		return k;
	}

	static void Main(string[] args)
	{
		var nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
		var val = 2;

		var result = RemoveElement(nums, val);

		Console.WriteLine(result);
	}
}

