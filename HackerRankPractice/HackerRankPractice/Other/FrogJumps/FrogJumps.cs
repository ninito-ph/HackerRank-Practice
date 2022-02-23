using System.Collections.Generic;

namespace HackerRankPractice.Other
{
	public class FrogJumps
	{
		/// <summary>
		/// Checks whether the frog can cross the gap through bruteforce. Fairly slow.
		/// </summary>
		/// <param name="stonePositions"></param>
		/// <param name="currentStoneIndex"></param>
		/// <param name="lastJumpLenght"></param>
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
	}
}