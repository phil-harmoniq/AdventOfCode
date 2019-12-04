using System;
using System.Diagnostics;
using Xunit;

namespace AdventOfCode2019.Tests
{
    public class PuzzleTests
    {
        #region Puzzle01
        [Fact]
        public void Puzzle01Part1Test()
        {
        }

        [Fact]
        public void Puzzle01Part2Test()
        {
        }
        #endregion

        private static T TestTimer<T>(string puzzle, string part, Func<T> test)
        {
            var timer = new Stopwatch();
            timer.Start();
            var answer = test();
            timer.Stop();
            Console.WriteLine();
            Console.WriteLine($"The answer to puzzle {puzzle} part {part} is: {answer}");
            Console.WriteLine($"Time elapsed: {timer.Elapsed.ToString(@"mm\:ss\.ff")}");
            return answer;
        }
    }
}