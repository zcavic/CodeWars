using System.Linq;

namespace CodeWars.Collections
{
	public static class Array
	{
		/// <summary>
		/// Find minimal number in array
		/// </summary>
		/// <param name="list">Array</param>
		/// <returns>Minimal number in array</returns>
		public static int Min(int[] list) => list.Min();

		/// <summary>
		/// Find maximal number in array
		/// </summary>
		/// <param name="list">Array</param>
		/// <returns>Maximal number in array</returns>
		public static int Max(int[] list) => list.Max();
	}
}
