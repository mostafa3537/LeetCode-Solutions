using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.HashTablesProblems
{
    internal class MinAreaRectProblem
    {
        public static int MinAreaRect(int[][] points)
        {
            var area = int.MaxValue;

            var xDict = new Dictionary<int, List<int[]>>();
            var yDict = new Dictionary<int, List<int[]>>();

            // Group points by x and y coordinates

            for (int i = 0; i < points.Length; i++)
            {
                if (xDict.TryGetValue(points[i][0], out List<int[]> val))
                {
                    val.Add(points[i]);
                }
                else
                {
                    xDict[points[i][0]] = new List<int[]> { points[i] };
                }

                if (yDict.TryGetValue(points[i][1], out List<int[]> val2))
                {
                    val2.Add(points[i]);
                }
                else
                {
                    yDict[points[i][1]] = new List<int[]> { points[i] };
                }
            }


            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (points[i][0] == points[j][0] || points[i][1] == points[j][1])
                    {
                        continue;
                    }

                    var currentpoint1 = points[i];
                    var currentpoint2 = points[j];
                    var point3Found = false;
                    var point4found = false;
                    if (xDict.TryGetValue(currentpoint1[0], out List<int[]> xList))
                    {
                        foreach (var point in xList)
                        {
                            if (point[1] == currentpoint2[1])
                            {
                                point3Found = true;
                                break;
                            }
                        }

                    }
                    if (yDict.TryGetValue(currentpoint1[1], out List<int[]> yList))
                    {
                        foreach (var point in yList)
                        {
                            if (point[0] == currentpoint2[0])
                            {
                                point4found = true;
                                break;
                            }
                        }

                    }

                    if (point3Found && point4found)
                    {
                        area = Math.Min(area, Math.Abs(currentpoint1[0] - currentpoint2[0]) * Math.Abs(currentpoint1[1] - currentpoint2[1]));
                    }
                }
            }

            if (area == int.MaxValue)
            {
                return 0;
            }
            return area;
        }
    }
}
