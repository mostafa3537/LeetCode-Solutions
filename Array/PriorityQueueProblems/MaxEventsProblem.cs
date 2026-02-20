using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.PriorityQueueProblems
{
    internal class MaxEventsProblem
    {
        public static int MaxEvents(int[][] events)
        {
            var result = 0;

            Array.Sort(events, (a, b) => a[0].CompareTo(b[0]));

            var priority = new PriorityQueue<int[], int>();

            int i = 0;
            int n = events.Length;

            // get last day
            int lastDay = 0;

            for (int j = 0; j < n; j++)
            {
                lastDay = Math.Max(lastDay, events[j][1]);
            }


            for (int day = 0; day <= lastDay; day++)
            {
                //attend all events start today

                while (i < n && events[i][0] == day)
                {
                    priority.Enqueue(events[i], events[i][1]);
                    i++;
                }

                //remove expired events
                while (priority.Count > 0 && priority.Peek()[1] < day)
                {
                    priority.Dequeue();
                }
                //attend event with earliest end day

                if (priority.Count > 0)
                {
                    priority.Dequeue();
                    result++;
                }
            }

            return result;
        }

    }
}
