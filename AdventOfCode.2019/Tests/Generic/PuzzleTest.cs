using AdventOfCode.Y2019.Puzzles.Generic;
using System;
using System.Diagnostics;

namespace AdventOfCode.Y2019.Tests.Generic
{
    public abstract class PuzzleTest
    {
        public T TestTimer<T>(Puzzle puzzle, Func<string[], T> part, string[] input)
        {
            var timer = new Stopwatch();
            timer.Start();
            var answer = part(input);
            timer.Stop();
            Console.WriteLine();
            Console.WriteLine($"The answer to puzzle {puzzle} part {part} is: {answer}");
            Console.WriteLine($"Time elapsed: {timer.Elapsed.ToString(@"mm\:ss\.ff")}");
            return answer;
        }
    }
}
