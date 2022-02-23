namespace HackerRankPractice.Other
{
    public sealed class FrogJump
    {
        public static bool CanJump(int[] stonePositions)
        {
            
        }

        public static bool CanCrossGap(int[] stonePositions, int startingStone, int jumpSize)
        {
            for (int index = startingStone + 1; index < stonePositions.Length; index++)
            {
                int gap = stonePositions[index] - stonePositions[startingStone];

                if (gap < jumpSize - 1 || gap > jumpSize) continue;
                if (CanCrossGap(stonePositions, index, gap)) return true;

                return startingStone == stonePositions.Length - 1;
            }
        }
    }
}