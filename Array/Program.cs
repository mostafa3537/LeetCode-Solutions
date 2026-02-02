using System.Linq;

namespace Problems;

internal class Program
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

	static void Main(string[] args)
	{
		var path = new int[] { 1, 2, 3, 4, 3 };

		var res = NextGreaterElements(path);

		Console.WriteLine(res);
	}
}
