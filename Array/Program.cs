namespace Problems;

internal class Program
{
	public static int IsAnagram(int[] nums)
	{

		// sort the []
		//loop over if the next element is missing or return the next number of the []

		if (nums.Length == 1)
		{
			if (nums[0] <= 0)
			{
				return nums[^1] + 1;
			}
			else {
				return nums[^1] - 1;
			}
		}

		Array.Sort(nums);

		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[0] > 0)
			{
				return nums[0] - 1;
			}
			if (i < nums.Length - 1)
			{
				if (nums[i + 1] != nums[i] + 1)
				{
					return nums[i] + 1;
				}
			}

		}


		return nums[^1] + 1;
	}
	static void Main(string[] args)
	{
		var s = new int[] { 1, 2 };

		var result = IsAnagram(s);

		Console.WriteLine(result);
	}
}
