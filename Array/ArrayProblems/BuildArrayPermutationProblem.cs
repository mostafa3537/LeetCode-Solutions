using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.ArrayProblems
{
	internal class BuildArrayPermutationProblem
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
	}
}
