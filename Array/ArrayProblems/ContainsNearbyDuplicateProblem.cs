namespace Problems.ArrayProblems;

internal class ContainsNearbyDuplicateProblem
{
	public static bool ContainsNearbyDuplicate(int[] nums, int k)
	{
		var result = false;

		var dic = new Dictionary<int, int>();

		for (int i = 0; i < nums.Length; i++)
		{

			if (dic.TryGetValue(nums[i], out int key))
			{

				var value2 = Math.Abs(i - key);

				if (value2 <= k)
				{
					result = true;
					break;
				}
			}

			dic[nums[i]] = i;
		}

		return result;
	}
}
