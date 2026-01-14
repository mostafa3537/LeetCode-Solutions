using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.ArrayProblems
{
	internal class MissingNumberProblem
	{
		public int MissingNumber(int[] nums)
		{
			if (nums.Length == 1)
				return nums[0] == 0 ? 1 : 0;

			Array.Sort(nums);

			// If the first number is not 0, then 0 is missing
			if (nums[0] != 0)
				return 0;

			for (int i = 0; i < nums.Length - 1; i++)
			{
				if (nums[i + 1] != nums[i] + 1)
					return nums[i] + 1;
			}

			// Missing number is after the last element
			return nums[^1] + 1;
		}
	}
}
