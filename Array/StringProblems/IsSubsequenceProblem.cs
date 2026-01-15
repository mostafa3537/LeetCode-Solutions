using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.StringProblems
{
	internal class IsSubsequenceProblem
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
	}
}
