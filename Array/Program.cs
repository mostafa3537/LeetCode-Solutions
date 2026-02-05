using System.Linq;

namespace Problems;

internal class Program
{
	public static int LargestRectangleArea(int[] nums)
	{
		// for each element calculate boundries (current > boundry) then stop
		// area = CurrentHeight * (rightBoundry - leftBoundry)
		// return max area
		// we need function to get the next small element and pervious small elemnt --> now u get the boundries 

		int length = nums.Length;
		int maxArea = 0;

		var nextSmaller = NextSmallerEle(nums);
		var prevSmaller = PreviousSmallerEle(nums);

		for (int i = 0; i < length; i++)
		{
			int width = nextSmaller[i] - prevSmaller[i] - 1;
			int area = nums[i] * width;
			maxArea = Math.Max(maxArea, area);
		}

		return maxArea;
	}

	public static int[] NextSmallerEle(int[] nums)
	{
		int length = nums.Length;
		int[] result = new int[length];
		Array.Fill(result, length);

		Stack<int> stack = new Stack<int>();

		for (int i = 0; i < length; i++)
		{
			while (stack.Count > 0 && nums[stack.Peek()] > nums[i])
			{
				int index = stack.Pop();
				result[index] = i;
			}
			stack.Push(i);
		}

		return result;
	}

	public static int[] PreviousSmallerEle(int[] nums)
	{
		int length = nums.Length;
		int[] result = new int[length];
		Array.Fill(result, -1);

		Stack<int> stack = new Stack<int>();

		for (int i = 0; i < length; i++)
		{
			while (stack.Count > 0 && nums[stack.Peek()] >= nums[i])
			{
				stack.Pop();
			}

			if (stack.Count > 0)
				result[i] = stack.Peek();

			stack.Push(i);
		}

		return result;
	}
	static void Main(string[] args)
	{
		var path = new int[] { 2, 1, 5, 6, 2, 3 };

		var res = LargestRectangleArea(path);

		Console.WriteLine(res);
	}
}
