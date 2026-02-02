using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Stack
{
	internal class DailyTemperaturesProblem
	{
		public static int[] DailyTemperatures(int[] temperatures)
		{
			var result = new int[temperatures.Length];

			var length = temperatures.Length;

			var stack = new Stack<int>();


			for (int i = 0; i < length; i++)
			{
				// create stack that maintain indecies with no greater than
				// kkep check if the current stack index has greater temp if yes
				// remove it and update the pervious temp if no add it to stack

				while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i])
				{
					// update pervious temps
					var perviouseTemp = stack.Pop();

					result[perviouseTemp] = i - perviouseTemp;
				}
				stack.Push(i);
			}

			return result;
		}
	}
}
