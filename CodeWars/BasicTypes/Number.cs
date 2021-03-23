using System;
using System.Collections.Generic;

namespace CodeWars.BasicTypes
{
	public static class Number
	{
		/// <summary>
		/// Method accepts 3 integer values a, b, c. The method should return true if a triangle can be built with the sides of given length and false in any other case.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <returns></returns>
		public static bool IsTriangle(int a, int b, int c) => a + b > c && a + c > b && b + c > a;

		/// <summary>
		/// The function takes the parameter: n (n is always strictly greater than 0) and returns an array or a string (depending on the language) of the form: [(a, b), ...] or [[a, b], ...] or {{a, b}, ...} or or [{a, b}, ...] with all (a, b) which are the possible removed numbers in the sequence 1 to n. [(a, b), ...] or [[a, b], ...] or {{a, b}, ...} or ... will be sorted in increasing order of the "a".
		/// </summary>
		/// <returns></returns>
		public static List<long[]> removNb(long n)
		{
			// sum of first n numbers
			long sum = n * (n + 1) / 2;

			List<long[]> pairs = new List<long[]>();
			
			// start searching from half
			long startPoint = (long)(n/2);

			for (long i = startPoint; i <= n; i++)
			{
				if ((sum - i) % (i + 1) == 0)
				{
					pairs.Add(new long[] { i, (sum - i) / (i + 1) });
				}
			}

			return pairs;
		}
	}
}
