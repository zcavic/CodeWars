using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}
