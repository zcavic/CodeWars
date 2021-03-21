using System;
using System.Numerics;

namespace CodeWars.Algorithms
{
	class Fibonacci
	{
		/// <summary>
		/// Method calculate n-th Fibonacci number with complexity O(log(n))
		/// </summary>
		/// <param name="n">n-th Fibonacci number</param>
		/// <returns>Value of n-th Fibonacci number</returns>
		static BigInteger fib(int n)
		{
			if (n < 0)
				return (int)Math.Pow(-1, n + 1) * fib(Math.Abs(n));

			BigInteger[,] F = new BigInteger[,]{{1, 1},
					  {1, 0}};
			if (n == 0)
				return 0;
			power(F, n - 1);

			return F[0, 0];
		}

		static void multiply(BigInteger[,] F, BigInteger[,] M)
		{
			BigInteger x = F[0, 0] * M[0, 0] + F[0, 1] * M[1, 0];
			BigInteger y = F[0, 0] * M[0, 1] + F[0, 1] * M[1, 1];
			BigInteger z = F[1, 0] * M[0, 0] + F[1, 1] * M[1, 0];
			BigInteger w = F[1, 0] * M[0, 1] + F[1, 1] * M[1, 1];

			F[0, 0] = x;
			F[0, 1] = y;
			F[1, 0] = z;
			F[1, 1] = w;
		}

		/* Optimized version of 
		power() in method 4 */
		static void power(BigInteger[,] F, BigInteger n)
		{
			if (n == 0 || n == 1)
				return;
			BigInteger[,] M = new BigInteger[,] { { 1, 1 }, { 1, 0 } };

			power(F, n / 2);
			multiply(F, F);

			if (n % 2 != 0)
				multiply(F, M);
		}
	}
}
