using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.BasicTypes
{
	public static class String
	{
		public static string[] StringToArray(string str) => str.Split(' ');

		/// <summary>
		/// An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.
		/// </summary>
		/// <param name="str">String to check</param>
		/// <returns>True if string is isogram, otherwise false</returns>
		public static bool IsIsogram(string str) => str.ToLower().ToArray().Distinct().Count() == str.Count();

		/// <summary>
		/// Method capitalize first letter of each word in sentence
		/// </summary>
		/// <param name="phrase">Sentence</param>
		/// <returns>Capitalized first letter of each word</returns>
		public static string ToJadenCase(this string phrase)
		{
			return string.Join(" ", phrase.Split(' ').Select(x => char.ToUpper(x[0]) + x.Substring(1)).ToString());
		}
	}
}
