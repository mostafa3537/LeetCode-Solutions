using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Matrix
{
    internal class SearchMatrixProblem
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
                int mid = (left + right) / 2;

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
    }
}
