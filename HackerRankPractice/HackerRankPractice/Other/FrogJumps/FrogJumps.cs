using System.Collections.Generic;

namespace HackerRankPractice.Other
{
	public static class FrogJumps
	{
		/// <summary>
		/// Checks whether the frog can cross the gap through bruteforce. Fairly slow.
		/// </summary>
		/// <param name="stonePositions">The positions of each stone</param>
		/// <param name="currentStoneIndex">The index of the stone to start jumping from</param>
		/// <param name="lastJumpLenght">The lenght of the previous jump</param>
		/// <returns>Whether a gap can be crossed</returns>
		public static bool CanCrossGapBruteForce(IReadOnlyList<int> stonePositions, int currentStoneIndex, int lastJumpLenght)
		{
			// For every gap ahead of the current stone
			for (int i = currentStoneIndex + 1; i < stonePositions.Count; i++)
			{
				// Calculate the gap the frog will jump over
				int gap = stonePositions[i] - stonePositions[currentStoneIndex];
				// Check the jump lenght is equal to, exceeds or is lesser than the last jump by 1
				if (gap != lastJumpLenght && gap != lastJumpLenght + 1 && gap != lastJumpLenght - 1) continue;
				// Check if the frog can cross every other gap from this position
				if (CanCrossGapBruteForce(stonePositions, i, gap)) return true;
			}

			// Return true if this is the last stone. If not, all options have been exhausted, and the gap can't be crossed.
			return currentStoneIndex == stonePositions.Count - 1;
		}

		public static int CanCrossGapMemorization(IReadOnlyList<int> stonePositions, int currentStoneIndex,
			int lastJumpLenght, int[][] memorization)
		{
			if (memorization[currentStoneIndex][lastJumpLenght] >= 0)
			{
				return memorization[currentStoneIndex][lastJumpLenght];
			}

			for (var i = currentStoneIndex + 1; i < stonePositions.Count; i++)
			{
				int gap = stonePositions[i] - stonePositions[currentStoneIndex];
				if (gap < lastJumpLenght - 1 || gap > lastJumpLenght + 1) continue;
				memorization[currentStoneIndex][gap] = 1;
				return 1;
			}

			memorization[currentStoneIndex][lastJumpLenght] = currentStoneIndex == stonePositions.Count - 1 ? 1 : 0;
			return memorization[currentStoneIndex][lastJumpLenght];
		}

		/// <summary>
		/// Gets a memorization array large enough to fit all stones. All values initialized to -1.
		/// </summary>
		/// <param name="stoneCount">The lenght of the array, or the amount of stones it must fit</param>
		/// <returns>An array with all values initialized to -1</returns>
		public static int[][] GetMemorizationArray(int stoneCount)
		{
			int[][] memorization = new int[stoneCount][];
			
			for (int i = 0; i < memorization.Length; i++)
			{
				memorization[i] = new int[stoneCount];
				
				for (int j = 0; j < memorization[i].Length; j++)
				{
					memorization[i][j] = -1;
				}
			}

			return memorization;
		}
	}
}