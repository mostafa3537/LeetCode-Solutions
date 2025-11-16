namespace Array;

internal class RemoveDuplicatesProb
{
	public static int RemoveDuplicates(int[] nums)
	{
		// loop over array and create another array insert in the new one

		var uniqueDic = new Dictionary<int, int>();

		for (int i = 0; i < nums.Length; i++)
		{
			uniqueDic.TryAdd(nums[i], nums[i]);
		}
		var uniqueArray = new int[uniqueDic.Count];

		for (int j = 0; j < uniqueDic.Count; j++)
		{
			nums[j] = uniqueDic.ElementAt(j).Value;
		}

		return uniqueArray.Length;
	}
	public static int RemoveDuplicatesOptimize(int[] nums)
	{
		if (nums.Length == 0)
			return 0;

		int k = 1;

		for (int i = 1; i < nums.Length; i++)
		{
			if (nums[i] != nums[i - 1])
			{
				nums[k] = nums[i];
				k++;
			}
		}

		return k;
	}
}
