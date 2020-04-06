using DailyCodingProblem;
using NUnit.Framework;
using Shouldly;

namespace DailyCodingProblemTests
{
    [TestFixture]
    public class ArrayProductCreator_Calculate_Should
    {
        [TestCase(new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 })]
        [TestCase(new int[] { 3, 2, 1 }, new int[] { 2, 3, 6 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 6, 3, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 120, 60, 40, 30, 24 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, new int[] { 24, 30, 40, 60, 120 })]
        public void ReturnCorrectResult(int[] input, int[] expected)
        {
            int[] actual = ArrayProductCreator.Calculate(input);

            actual.ShouldBe(expected);
        }
    }
}
