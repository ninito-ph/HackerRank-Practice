using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace HackerRankPractice.Other
{
    public sealed class FrogJumpTests
    {
        [Theory]
        [MemberData(nameof(GetCrossableGaps))]
        public void CanCrossGapBruteForce_ACrossableGap_ShouldReturnTrue(params int[] stonePositions)
        {
            FrogJumps.CanCrossGapBruteForce(stonePositions, 0, 1).Should().BeTrue();
        }

        [Theory]
        [MemberData(nameof(GetUncrossableGaps))]
        public void CanCrossGapBruteForce_AnUncrossableGap_ShouldReturnTrue(params int[] stonePositions)
        {
            FrogJumps.CanCrossGapBruteForce(stonePositions, 0, 1).Should().BeFalse();
        }

        [Theory]
        [MemberData(nameof(GetCrossableGaps))]
        public void CanCrossGapMemorization_ACrossableGap_ShouldReturnTrue(params int[] stonePositions)
        {
            FrogJumps.CanCrossGapMemorization(stonePositions, 0, 1,
                    FrogJumps.GetMemorizationArray(stonePositions.Length))
                .Should().Be(1);
        }

        [Theory]
        [MemberData(nameof(GetUncrossableGaps))]
        public void CanCrossGapMemorization_AnUncrossableGap_ShouldReturnFalse(params int[] stonePositions)
        {
            FrogJumps.CanCrossGapMemorization(stonePositions, 0, 1,
                    FrogJumps.GetMemorizationArray(stonePositions.Length))
                .Should().NotBe(1);
        }

        public static IEnumerable<object[]> GetCrossableGaps()
        {
            yield return new object[] {0, 1, 2, 3, 4, 5};
            yield return new object[] {0, 1, 2, 4, 7, 11};
            yield return new object[] {0, 1, 2, 4, 7, 10};
        }

        public static IEnumerable<object[]> GetUncrossableGaps()
        {
            yield return new object[] {0, 1, 3, 5, 7, 22};
            yield return new object[] {0, 1, 2, 5, 10, 12};
            yield return new object[] {0, 1, 3, 4, 5, 10};
        }
    }
}