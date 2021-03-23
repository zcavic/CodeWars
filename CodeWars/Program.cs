using CodeWars.BasicTypes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CodeWars
{
	class Program
	{
		static void Main(string[] args)
		{
			Stopwatch sp = new Stopwatch();

			Console.WriteLine("removNb");
			for (int i = 100000; i <= 100500; i++)
			{
				sp.Restart();
				List<long[]> temp = Number.removNb2(i);
				sp.Stop();
				if (temp.Count() > 0)
					Console.WriteLine($"{i} - {string.Join(" ", temp.Select(x => $"[{x[0]}:{x[1]}]"))} {sp.ElapsedMilliseconds} ms");
			}

			Console.WriteLine("removNb3");
			//for (int i = 1000000; i <= 1000010; i++)
			//{
			//	sp.Restart();
			//	List<long[]> temp = Number.removNb3(i);
			//	sp.Stop();
			//	if (temp.Count() > 0)
			//		Console.WriteLine($"{i} - {string.Join(" ", temp.Select(x => $"[{x[0]}:{x[1]}]"))} {sp.ElapsedMilliseconds} ms");
			//}

			Console.WriteLine("Press any button to continue.");
			Console.ReadLine();
		}
	}
}
