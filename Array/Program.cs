using System.Linq;

namespace Problems;

internal class Program
{
	public static bool IsIsomorphic(string s, string t)
	{
		var sdictionay = new Dictionary<char,int>();
		var tdictionay = new Dictionary<char,int>();
		var sList = new List<int>();
		var tList = new List<int>();

		var start = 0;
		var tstart = 0;
		for (int i = 0; i < s.Length; i++)
		{
			if (sdictionay.TryGetValue(s[i], out int val))
			{
                sList.Add(val);

            }
            else
			{
				sdictionay.Add(s[i], start);
                sList.Add(start);
                start++;
            }
		}

        for (int i = 0; i < t.Length; i++)
        {
            if (tdictionay.TryGetValue(t[i], out int val))
            {
                tList.Add(val);

            }
            else
            {
                tdictionay.Add(t[i], tstart);
                tList.Add(tstart);
                tstart++;
            }
        }

		for (int i = 0; i < s.Length; i++)
		{
			if (sList[i] != tList[i])
			{
				return false;
			}
		}

        return true;
	}

	static void Main(string[] args)
	{
		var s = "egg";
		var t = "add";

		var result = IsIsomorphic(s, t);

		Console.WriteLine(result);
	}
}
