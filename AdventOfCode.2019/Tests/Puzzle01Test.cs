using AdventOfCode.Y2019.Tests.Generic;
using AdventOfCode2019.Puzzles;
using Xunit;

namespace AdventOfCode2019.Tests
{
    public class Puzzle01Test : PuzzleTest
    {
        public readonly Puzzle01 Puzzle = new Puzzle01();

        [Fact]
        public void Puzzle01Part1Test()
        {
            var fuel = TestTimer(Puzzle, Puzzle.Part1, Puzzle.Input);
            Assert.Equal(3538016, fuel);
        }

        [Fact]
        public void Puzzle01Part2Test()
        {
            var fuel = TestTimer(Puzzle, Puzzle.Part2, Puzzle.Input);
            Assert.Equal(5304147, fuel);
        }
    }
}