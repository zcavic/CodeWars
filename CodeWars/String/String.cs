using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.String
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
	}
}
