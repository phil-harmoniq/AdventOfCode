using AdventOfCode.Y2019.Puzzles;
using AdventOfCode.Y2019.Tests.Generic;
using Xunit;

namespace AdventOfCode.Y2019.Tests
{
    public class Puzzle03Tests : PuzzleTest
    {
        public readonly Puzzle03 Puzzle = new Puzzle03();

        [Fact]
        public void Part1()
        {
            var answer = TestTimer(Puzzle, Puzzle.Part1);
            Assert.Equal(280, answer);
        }

        [Fact]
        public void Part2()
        {
            var answer = TestTimer(Puzzle, Puzzle.Part2);
            Assert.Equal(10554, answer);
        }
    }
}
