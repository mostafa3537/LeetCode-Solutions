using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.PriorityQueueProblems
{
    internal class MaxPerformanceProblem
    {
        public static int MaxPerformance(int n, int[] speed, int[] efficiency, int k)
        {
            long result = 0;

            // Create a list of tuples to store speed and efficiency together

            var engineers = new List<(int Speed, int Efficiency)>();

            for (int i = 0; i < n; i++)
            {
                engineers.Add((speed[i], efficiency[i]));
            }

            // Sort engineers by efficiency in descending order

            engineers.Sort((a, b) => b.Efficiency.CompareTo(a.Efficiency));

            // Use a min-heap to keep track of the k highest speeds

            var minHeap = new PriorityQueue<int, int>();

            long speedSum = 0;

            foreach (var engineer in engineers)
            {
                // Add the current engineer's speed to the heap and update the speed sum
                minHeap.Enqueue(engineer.Speed, engineer.Speed);
                speedSum += engineer.Speed;
                // If we have more than k engineers, remove the one with the lowest speed
                if (minHeap.Count > k)
                {
                    int lowestSpeed = minHeap.Dequeue();

                    speedSum -= lowestSpeed;
                }
                // Calculate the performance with the current efficiency and speed sum
                long performance = speedSum * engineer.Efficiency;
                result = Math.Max(result, performance);
            }

            return (int)(result % 1_000_000_007);
        }


    }
}
