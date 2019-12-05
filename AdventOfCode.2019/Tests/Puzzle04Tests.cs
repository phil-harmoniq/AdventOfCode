using AdventOfCode.Y2019.Puzzles;
using AdventOfCode.Y2019.Tests.Generic;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AdventOfCode.Y2019.Tests
{
    public class Puzzle04Tests : PuzzleTest
    {
        public readonly Puzzle04 Puzzle = new Puzzle04();

        [Fact]
        public void Part1()
        {
            var answer = TestTimer(Puzzle, Puzzle.Part1);
            Assert.Equal(1169, answer);
        }

        [Fact]
        public void Part2()
        {
            var answer = TestTimer(Puzzle, Puzzle.Part2);
            Assert.Equal(0, answer);
        }
    }
}
