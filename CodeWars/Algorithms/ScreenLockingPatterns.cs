using System;
using System.Collections.Generic;

namespace CodeWars.Algorithms
{
	class ScreenLockingPatterns
	{
		public static int CountPatternsFrom(char firstDot, int length)
		{
			int countOfPatterns = 0;
			FindPattern(firstDot, length, new HashSet<char>() { firstDot }, ref countOfPatterns);

			return countOfPatterns;
		}

		private static void FindPattern(char firstDot, int lenght, HashSet<char> visited, ref int countOfPatterns)
		{
			if (visited.Count == lenght)
			{
				visited.Remove(firstDot);
				countOfPatterns++;
				return;
			}

			foreach (char dot in GetPossibilities(visited, firstDot))
			{
				visited.Add(dot);
				FindPattern(dot, lenght, visited, ref countOfPatterns);
			}

			visited.Remove(firstDot);
		}

		private static HashSet<char> GetPossibilities(HashSet<char> visited, char firstDot)
		{
			HashSet<char> allDots = new HashSet<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
			HashSet<char> possibleDots = new HashSet<char>();
			allDots.Remove(firstDot);

			foreach (char dot in allDots)
				if (IsPossible(firstDot, dot, visited))
					possibleDots.Add(dot);

			return possibleDots;
		}

		private static bool IsPossible(char startDot, char endDot, HashSet<char> visited)
		{
			if (startDot == 'A')
			{
				if (visited.Contains(endDot))
					return false;
				else if (endDot == 'C' && !visited.Contains('B'))
					return false;
				else if (endDot == 'I' && !visited.Contains('E'))
					return false;
				else if (endDot == 'G' && !visited.Contains('D'))
					return false;
				else
					return true;
			}
			else if (startDot == 'B')
			{
				if (visited.Contains(endDot))
					return false;
				else if (endDot == 'H' && !visited.Contains('E'))
					return false;
				else
					return true;
			}
			else if (startDot == 'C')
			{
				if (visited.Contains(endDot))
					return false;
				else if (endDot == 'A' && !visited.Contains('B'))
					return false;
				else if (endDot == 'G' && !visited.Contains('E'))
					return false;
				else if (endDot == 'I' && !visited.Contains('F'))
					return false;
				else
					return true;
			}
			else if (startDot == 'D')
			{
				if (visited.Contains(endDot))
					return false;
				else if (endDot == 'F' && !visited.Contains('E'))
					return false;
				else
					return true;
			}
			else if (startDot == 'E')
			{
				if (visited.Contains(endDot))
					return false;
				else
					return true;
			}
			else if (startDot == 'F')
			{
				if (visited.Contains(endDot))
					return false;
				else if (endDot == 'D' && !visited.Contains('E'))
					return false;
				else
					return true;

			}
			else if (startDot == 'G')
			{
				if (visited.Contains(endDot))
					return false;
				else if (endDot == 'A' && !visited.Contains('D'))
					return false;
				else if (endDot == 'I' && !visited.Contains('H'))
					return false;
				else if (endDot == 'C' && !visited.Contains('E'))
					return false;
				else
					return true;

			}
			else if (startDot == 'H')
			{
				if (visited.Contains(endDot))
					return false;
				else if (endDot == 'B' && !visited.Contains('E'))
					return false;
				else
					return true;
			}
			else if (startDot == 'I')
			{
				if (visited.Contains(endDot))
					return false;
				else if (endDot == 'A' && !visited.Contains('E'))
					return false;
				else if (endDot == 'C' && !visited.Contains('F'))
					return false;
				else if (endDot == 'G' && !visited.Contains('H'))
					return false;
				else
					return true;
			}
			else
				throw new ArgumentException($"Invalid char {startDot} or {endDot}.");
		}
	}
}
