using AdventOfCode.Y2019.Puzzles.Generic;
using System;
using System.Diagnostics;
using System.IO;

namespace AdventOfCode.Y2019.Tests.Generic
{
    public abstract class PuzzleTest
    {
        public TOutput TestTimer<TOutput>(IPuzzle puzzle, Func<string[], TOutput> part)
        {
            var input = File.ReadAllLines(Path.Combine("Inputs", $"{puzzle.GetType().Name}.txt"));
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
