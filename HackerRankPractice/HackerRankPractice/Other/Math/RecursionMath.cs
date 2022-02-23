using System;

namespace HackerRankPractice.Other
{
	public class RecursionMath
	{
		public static int GetFactorialOf(int number)
		{
			return number switch
			{
				< 0 => throw new ArgumentOutOfRangeException(nameof(number)),
				0 => 1,
				_ => number * GetFactorialOf(number - 1)
			};
		}

		public static int GetTermOfFibonacci(int term)
		{
			if (term < 0) throw new ArgumentOutOfRangeException(nameof(term));
			if (term < 3) return 1;

			return GetTermOfFibonacci(term - 2) + GetTermOfFibonacci(term - 1);
		}
	}
}