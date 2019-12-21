# HackerRankHelper
Visual Studio solution for doing HackerRank tests in C#

Inspired by the GitHub project https://github.com/roufamatic/HackerRankTemplate. Credit to @roufamatic.
I made it xUnit-testable and upgrade to use the .Net Core.

The program has one stub method called *SolvePuzzle* which takes an IReaderWriter parameter. Use the IReaderWriter methods to interact with the console and save method results. 
Copy the method from the HackerRank page into the partial class Solution and call it from *SolvePuzzle* (see the FizzBuzz sample).

When running, the boilerplate will detect whether a debugger is attached. If not, a ConsoleReaderWriter will be used to manage interactions with the console. If a debugger is attached, a TextFileReaderWriter will be used instead. 

The TextFileReaderWriter:
* Reads input from a file called *input.txt* and
* Compares your outputs line-by-line to a file called *expected.txt*
* Allows to use multiple test files, in that case use the TextFileReaderWriter constructor with two parameters
* Code of your method completely testable with unit tests

This makes it easy to debug test cases from HackerRank.
As an examlpe, the following unit test uses input and expected result files from the folder *fizzbuzz*
 
    public class FizzBuzzTest
    {
        [Fact]
        public void Test1()
        {
            using var readerWriter = new TestFileReaderWriter("fizzbuzz\\input.txt", "fizzbuzz\\expected.txt");
            Solution.SolvePuzzle(readerWriter);
        }
    }

When everything looks good, copy your code into the HackerRank text box. 