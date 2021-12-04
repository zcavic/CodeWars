using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Algorithms
{
    public class BattleshipFieldValidator
    {
        public static bool ValidateBattlefield(int[,] field)
        {
            Console.WriteLine();
            // Write your magic here
            var ships = new List<int>();
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    if (field[i, j] == 1)
                        ships.Add(FindShip(field, i, j, 1));
            ships.Sort();
            return string.Join("", ships) == "1111222334";
        }

        private static int FindShip(int[,] field, int i, int j, int ship)
        {
            field[i, j] = 0;
            if (!IsValid(field, i, j))
                return 0;
            else if (j < 9 && field[i, j + 1] == 0)
                return FindShip(field, i, j + 1, ship + 1);
            else if (i < 9 && field[i + 1, j] == 0)
                return FindShip(field, i + 1, j, ship + 1);
            else
                return ship;
        }

        private static bool IsValid(int[,] field, int i, int j)
        {
            if (i > 0 && j > 0 && field[i - 1, j - 1] == 1)
                return false;
            else if (i < 9 && j < 9 && field[i + 1, j + 1] == 1)
                return false;
            else if (i > 0 && j < 9 && field[i - 1, j + 1] == 1)
                return false;
            else if (i < 9 && j > 0 && field[i + 1, j - 1] == 1)
                return false;
            else
                return true;
        }
    }
}
