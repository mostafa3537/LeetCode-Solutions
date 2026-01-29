using System.Linq;

namespace Problems;

internal class Program
{
    public static bool SearchMatrix(int[][] matrix, int target)
    {
        for (int row = 0; row < matrix.Length; row++)
        {
            if (target > matrix[row][^1] || target < matrix[row][0])
            {
                continue;
            }

            var find = search(matrix[row], target);
            if (find == true)
            {
                return true;
            }
        }

        return false;
    }


    private static bool search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            int mid =  (left + right) / 2;

            if (nums[mid] == target)
            {
                return true;
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
        }

        return false;
    }

    static void Main(string[] args)
    {
        var matrix = new int[][] { [1, 4, 7, 11, 15], [2, 5, 8, 12, 19], [3, 6, 9, 16, 22], [10, 13, 14, 17, 24], [18, 21, 23, 26, 30] };
        var target = 5;

        var result = SearchMatrix(matrix, target);

        //var arr = new int[] { 2, 5, 8, 12, 19 };

        //var result2 = search(arr, target);

        Console.WriteLine(result);
    }
}
