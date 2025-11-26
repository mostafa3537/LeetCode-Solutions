using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayprob;

internal class MaxAreaProblem
{
    public static int MaxArea(int[] height)
    {

        if (2 > height.Length || height.Length > Math.Pow(10, 5))
        {
            return 0;
        }
        var maxArea = 0;

        for (int i = 0; i < height.Length; i++)
        {
            if (height[i] < 0 || height[i] > Math.Pow(10, 4))
            {
                return 0;
            }
            for (int j = 0; j < height.Length; j++)
            {
                int currentArea;
                if (i == j)
                {
                    continue;
                }
                if (height[i] < height[j])
                {
                    currentArea = height[i] * Math.Abs(i - j);
                }
                else
                {
                    currentArea = height[j] * Math.Abs(i - j);
                }

                if (currentArea > maxArea)
                {
                    maxArea = currentArea;
                }
            }
        }
        return maxArea;
    }



    public static int MaxAreaOptimized(int[] height)
    {

        if (2 > height.Length || height.Length > Math.Pow(10, 5))
        {
            return 0;
        }
        var maxArea = 0;

        var left = 0;

        var right = height.Length - 1;

        while (left < right)
        {
            // will move the pointer which has the smaller height

            int currentArea;
            if (height[left] < height[right])
            {
                currentArea = height[left] * (right - left);
                if (currentArea > maxArea)
                {
                    maxArea = currentArea;
                }
                left++;
            }
            else
            {
                currentArea = height[right] * (right - left);
                if (currentArea > maxArea)
                {
                    maxArea = currentArea;
                }
                right--;
            }
        }

        return maxArea;
    }
}
