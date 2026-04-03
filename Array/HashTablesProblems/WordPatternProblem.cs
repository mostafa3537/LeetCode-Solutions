using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.HashTablesProblems
{
	internal class WordPatternProblem
	{
		public static bool WordPattern(string pattern, string s)
		{
			var wordToChar = new Dictionary<string, char>();
			var charToWord = new Dictionary<char, string>();

			var words = s.Split(' ');
			if (words.Length != pattern.Length)
			{
				return false;
			}
			for (int i = 0; i < pattern.Length; i++)
			{
				var word = words[i];

				var patt = pattern[i];

				if (wordToChar.TryGetValue(words[i], out char val))
				{
					if (val != pattern[i])
					{
						return false;
					}
				}

				if (charToWord.TryGetValue(pattern[i], out string cha))
				{
					if (cha != words[i])
					{
						return false;
					}
				}

				wordToChar[words[i]] = pattern[i];
				charToWord[pattern[i]] = words[i];
			}


			return true;
		}
	}
}
