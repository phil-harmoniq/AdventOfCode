using AdventOfCode.Y2019.Puzzles;
using AdventOfCode.Y2019.Tests.Generic;
using Xunit;

namespace AdventOfCode.Y2019.Tests
{
    public class Puzzle02Tests : PuzzleTest
    {
        public readonly Puzzle02 Puzzle = new Puzzle02();

        [Fact]
        public void Part1Test()
        {
            var answer = TestTimer(Puzzle, Puzzle.Part1);
            Assert.Equal(3306701, answer);
        }

        [Fact]
        public void Part2Test()
        {
            var answer = TestTimer(Puzzle, Puzzle.Part2);
            Assert.NotNull(answer);
        }
    }
}
