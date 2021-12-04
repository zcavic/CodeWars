using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Algorithms
{
	class TheGreatestCommonDivisor
	{
        // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
        public static int generalizedGCD(int num, int[] arr)
        {
            for (int divisor = GetLowest(arr); divisor >= 0; divisor--)
            {
                bool isDivisor = true;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % divisor != 0)
                    {
                        isDivisor = false;
                        break;
                    }
                }
                if (isDivisor)
                    return divisor;
            }
            return 0;
        
        }

        private static int GetLowest(int[] arr)
        {
            int lowest = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < lowest)
                    lowest = arr[i];
            }
            return lowest;
        }
        // METHOD SIGNATURE ENDS
    }
}
