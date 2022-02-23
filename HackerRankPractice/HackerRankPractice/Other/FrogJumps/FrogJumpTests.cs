using System.Threading.Tasks;
using Xunit;

namespace HackerRankPractice.Other
{
	public sealed class FrogJumpTests
	{
		[Theory]
		[InlineData(0, 0, 0)]
		public void CanCrossGapBruteForce_AnUncrossableGap_ShouldReturnFalse(
			int[] stonePositions, int currentStoneIndex, int lastJumpLenght)
		{
		}
	}
}