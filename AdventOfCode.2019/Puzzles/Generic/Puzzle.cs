using System.IO;

namespace AdventOfCode.Y2019.Puzzles.Generic
{
    public abstract class Puzzle
    {
        public string[] Input { get; }

        public Puzzle()
        {
            Input = File.ReadAllLines(Path.Combine("Inputs", $"{GetType().Name}.txt"));
        }
    }
}
