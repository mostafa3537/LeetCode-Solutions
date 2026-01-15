using System.Linq;

namespace Problems;

internal class Program
{
	public static bool IsSubsequence(string s, string t)
	{
		// loop over add char in dic with freq
		// lopp 2nd [] check if the char in dic -- freq

		if (s.Length > t.Length)
		{
			return false;
		}

		var sPointer = 0;
		var tPointer = 0;

		while (sPointer < s.Length && tPointer < t.Length)
		{

			if (s[sPointer] == t[tPointer])
			{
				sPointer++;
				tPointer++;
			}
			else
			{
				tPointer++;

			}
		}

		if (sPointer != s.Length)
		{
			return false;

		}
		return true;

	}
	static void Main(string[] args)
	{
		var s = "acb"; var t = "ahbgdc";
		var result = IsSubsequence(s, t);

		Console.WriteLine(result);
	}



}
