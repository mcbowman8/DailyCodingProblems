using DailyCodingProblem;
using NUnit.Framework;
using Shouldly;

namespace DailyCodingProblemTests
{
    [TestFixture]
    public class ArrayProductCreator_Calculate_Should
    {
        [TestCase(new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 })]
        public void ReturnCorrectResult(int[] input, int[] expected)
        {
            int[] actual = ArrayProductCreator.Calculate(input);

            actual.ShouldBe(expected);
        }
    }
}
