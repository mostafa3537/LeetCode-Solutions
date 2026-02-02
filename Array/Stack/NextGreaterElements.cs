using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Stack
{
	internal class NextGreaterElementsProblem
	{
		public int[] NextGreaterElements(int[] nums)
		{
			int length = nums.Length;
			int[] result = new int[length];
			Array.Fill(result, -1);

			Stack<int> stack = new Stack<int>(); // stores indices

			for (int i = 0; i < length * 2; i++)
			{
				int index = i % length;

				while (stack.Count > 0 && nums[stack.Peek()] < nums[index])
				{
					int previousIndex = stack.Pop();
					result[previousIndex] = nums[index];
				}

				if (i < length)
				{
					stack.Push(index);
				}
			}

			return result;
		}

	}
}
