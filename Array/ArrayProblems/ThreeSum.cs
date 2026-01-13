namespace Problems.ArrayProblems;

internal class ThreeSum
{
	public static IList<IList<int>> ThreeSumProb(int[] nums)
	{
		var result = new List<IList<int>>();
		var sorted = nums.OrderBy(x => x).ToArray();

		for (int i = 0; i < sorted.Length - 2; i++)
		{
			if (i > 0 && sorted[i] == sorted[i - 1])
				continue;

			var left = i + 1;
			var right = sorted.Length - 1;

			while (left < right)
			{
				var sum = sorted[i] + sorted[left] + sorted[right];

				if (sum == 0)
				{
					result.Add(new List<int>() { sorted[i], sorted[left], sorted[right] });

					while (left < right && sorted[left] == sorted[left + 1])
						left++;

					while (left < right && sorted[right] == sorted[right - 1])
						right--;

					left++;
					right--;
				}
				else if (sum > 0)
				{
					right--;
				}
				else
				{
					left++;
				}
			}
		}

		return result;
	}
}
