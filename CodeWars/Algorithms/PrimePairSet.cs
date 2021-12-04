using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Algorithms
{
	public class PrimePairSet
	{
		private static HashSet<int> primeNumbers = new HashSet<int>() { 2 };

		public static int GetLovestSumForPrimesPariSet(int numberOfPrimesInSet)
		{
			int sum = int.MaxValue;

			//if (GetNextPrime() != GetNextPrime2())
			//	throw new Exception();
			int nextPrime = GetNextPrime2();

			while (true)
			{
				List<int> perfectPrimes = new List<int>() { nextPrime };
				int newSume = FindSumOfPerfectPrimes(perfectPrimes, numberOfPrimesInSet);
				if (sum > newSume)
					sum = newSume;

				//if (GetNextPrime(nextPrime) != GetNextPrime2(nextPrime))
				//	throw new Exception();
				nextPrime = GetNextPrime2(nextPrime);

				Console.WriteLine(nextPrime);
				if (nextPrime == -1)
					break;
				else if (4 * nextPrime > sum)
					break;
			} 


			return sum;
		}

		private static int FindSumOfPerfectPrimes(List<int> perfectPrimes, int numberOfPerfestPrimes)
		{
			int nextPrime = perfectPrimes.LastOrDefault();
			List<int> sums = new List<int>() { int.MaxValue };
			while (true)
			{
				//if (GetNextPrime(nextPrime) != GetNextPrime2(nextPrime))
				//	throw new Exception();
				nextPrime = GetNextPrime2(nextPrime);

				if (nextPrime == -1)
					return sums.Min(x => x);
				bool isPerfect = true;
				foreach (int prime in perfectPrimes)
				{
					if (!IsPairPerfestPrime(nextPrime, prime))
					{
						isPerfect = false;
						break;
					}
				}
				if (isPerfect)
				{
					List<int> perfectPrimesExtended = new List<int>(perfectPrimes);
					perfectPrimesExtended.Add(nextPrime);
					if (perfectPrimesExtended.Count == numberOfPerfestPrimes)
						return perfectPrimesExtended.Sum();
					else
						sums.Add(FindSumOfPerfectPrimes(perfectPrimesExtended, numberOfPerfestPrimes));
				}
			}
		}


		private static int GetNextPrime(int startPrime = 1)
		{
			for (int i = startPrime + 1; i < 21474; i++)
			{
				if (IsPrime(i))
					return i;
			}
			return -1;
		}

		private static int GetNextPrime2(int primeNumber = 1)
		{
			int nextPrime = primeNumbers.OrderBy(x=> x).FirstOrDefault(x => x > primeNumber);
			if (nextPrime != 0 && nextPrime < 21474)
				return nextPrime;
			else if (nextPrime > 21474)
				return -1;
			else
				return GetNextPrime(primeNumber);
		}

		public static bool IsPrime2(int number)
		{
			if (primeNumbers.Contains(number))
				return true;
			else if (primeNumbers.Max() < number)
				return IsPrime(number);
			else
				return false;

		}

		public static bool IsPrime(int number)
		{
			if (number <= 1)
				return false;
			if (number == 2)
				return true;
			if (number % 2 == 0)
				return false;

			var boundary = (int)Math.Floor(Math.Sqrt(number));

			for (int i = 3; i <= boundary; i += 2)
				if (number % i == 0)
					return false;
			
			primeNumbers.Add(number);
			return true;
		}

		private static bool IsPairPerfestPrime(int first, int second)
		{
			int concatenate1 = int.Parse((first.ToString() + second.ToString()));
			int concatenate2 = int.Parse((second.ToString() + first.ToString()));

			//if ((IsPrime(concatenate1) && IsPrime(concatenate2)) != (IsPrime2(concatenate1) && IsPrime2(concatenate2)))
			//	throw new Exception();

			if (IsPrime2(concatenate1) && IsPrime2(concatenate2))
				return true;
			else
				return false;
		}
	}
}
