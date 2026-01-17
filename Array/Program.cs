using System.Linq;

namespace Problems;

internal class Program
{
    public static int Trap(int[] nums)
    {
        var result = 0;

        if (nums.Length <= 2)
        {
            return result;
        }

        var leftMaxArray = new int[nums.Length];
        var maxLeft = 0;



        for (int i = 0; i < leftMaxArray.Length; i++)
        {

            maxLeft = Math.Max(maxLeft, nums[i]);

            leftMaxArray[i] = maxLeft;
        }

        /////--------------------------------------------------------------------------------------------//////
        var rightMaxArray = new int[nums.Length];
        var maxRight = nums[nums.Length - 1];

        for (int i = rightMaxArray.Length - 2; i >= 0; i--)
        {

            maxRight = Math.Max(maxRight, nums[i]);

            rightMaxArray[i] = maxRight;
        }


        for (int i = 0; i < nums.Length; i++)
        {
            var leftMax = leftMaxArray[i];
            var rightMax = rightMaxArray[i];


            var minHeight = Math.Min(leftMax, rightMax);

            // If current height is less than minHeight, water can be trapped

            if (nums[i] < minHeight)
            {
                result += minHeight - nums[i];
            }

        }
        return result;
    }

    static void Main(string[] args)
    {
        var nums = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

        var result = Trap(nums);

        Console.WriteLine(result);
    }
}
