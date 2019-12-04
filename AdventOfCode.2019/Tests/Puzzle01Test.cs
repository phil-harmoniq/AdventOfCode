using AdventOfCode.Y2019.Tests.Generic;
using AdventOfCode2019.Puzzles;
using Xunit;

namespace AdventOfCode2019.Tests
{
    public class Puzzle01Tests : PuzzleTest
    {
        public readonly Puzzle01 Puzzle = new Puzzle01();

        [Fact]
        public void Part1Test()
        {
            var fuel = TestTimer(Puzzle, Puzzle.Part1);
            Assert.Equal(3538016, fuel);
        }

        [Fact]
        public void Part2Test()
        {
            var fuel = TestTimer(Puzzle, Puzzle.Part2);
            Assert.Equal(5304147, fuel);
        }
    }
}