using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Algorithms
{
	/// <summary>
	/// https://www.codewars.com/kata/529bf0e9bdf7657179000008/train/csharp
	/// </summary>
	public class SudokuValidator
	{
		public static bool ValidateSolution(int[][] board)
		{
			for (int i = 0; i < 9; i++)
			{
				HashSet<int> horisontal = new HashSet<int>();
				HashSet<int> vertical = new HashSet<int>();
				for (int j = 0; j < 9; j++)
				{
					horisontal.Add(board[i][j]);
					vertical.Add(board[j][i]);
					if (i % 3 == 0 && j % 3 == 0 && BuildSubmatrix(board, i, j).Count != 9)
						return false;
				}
				if (horisontal.Count != 9 || vertical.Count != 9)
					return false;
			}
			return true;
		}

		private static HashSet<int> BuildSubmatrix(int[][] board, int startI, int startJ)
		{
			HashSet<int> submatrix = new HashSet<int>(9);
			for (int i = 0; i < 3; i++)
				for (int j = 0; j < 3; j++)
					submatrix.Add(board[i + startI][j + startJ]);
			return submatrix;
		}

		public static bool ValidateSolution2(int[][] board)
		{
			if (board.SelectMany(row => row).Any(x => x == 0))
				return false;

			return Enumerable.Range(0, 9).All(i =>
			   CellsInRow(board, i).Distinct().Count() == 9
			   && CellsInCol(board, i).Distinct().Count() == 9
			   && CellsInBox(board, i).Distinct().Count() == 9
			);
		}

		static IEnumerable<int> CellsInRow(int[][] board, int row) => board[row];
		static IEnumerable<int> CellsInCol(int[][] board, int col) => board.Select(row => row[col]);
		static IEnumerable<int> CellsInBox(int[][] board, int box) => Enumerable.Range(0, 9)
		  .SelectMany(i => CellsInRow(board, (box - box % 3) + i / 3).Skip(3 * (box % 3)).Take(3));
	}
}
}
