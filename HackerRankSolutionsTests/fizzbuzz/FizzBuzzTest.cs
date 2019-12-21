using HackerRankHelper;
using Xunit;

namespace HackerRankSolutionTests.Fizzbuzz
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Test1()
        {
            using var readerWriter = new TestFileReaderWriter("fizzbuzz\\input.txt", "fizzbuzz\\expected.txt");
            Program.SolvePuzzle(readerWriter);
        }
    }
}
