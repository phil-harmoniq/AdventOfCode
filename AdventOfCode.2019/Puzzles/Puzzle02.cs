using AdventOfCode.Y2019.Models;
using AdventOfCode.Y2019.Puzzles.Generic;
using AdventOfCode2019;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Y2019.Puzzles
{
    public class Puzzle02 : Puzzle
    {
        private const int _minReplace = 0;
        private const int _maxReplace = 99;

        public int Part1(string[] input)
        {
            var data = input[0].Split(',').Select(x => int.Parse(x)).ToArray();

            Part1ReplaceData(data);
            Calculate(data);

            return data[0];
        }

        public Tuple<int, int> Part2(string[] input)
        {
            var rawData = input[0].Split(',').Select(x => int.Parse(x)).ToArray();

            for (var noun = _minReplace; noun <= _maxReplace; noun++)
            {
                for (var verb = _minReplace; verb <= _maxReplace; verb++)
                {
                    var data = new List<int>(rawData).ToArray();
                    Part2ReplaceData(data, noun, verb);
                    Calculate(data);

                    if (data[0] == 19690720)
                    {
                        return new Tuple<int, int>(noun, verb);
                    }
                }
            }

            return null;
        }

        private void Calculate(int[] data)
        {
            var index = 0;
            var currentIntCode = data.ToIntCode(index);

            while (index < data.Length - 4 && currentIntCode.IsValid && !currentIntCode.IsFinished)
            {
                currentIntCode = data.ToIntCode(index);
                ExecuteIntCode(currentIntCode, data);
                index += 4;
            }
        }

        private void Part1ReplaceData(int[] data)
        {
            data[1] = 12;
            data[2] = 2;
        }

        private void Part2ReplaceData(int[] data, int noun, int verb)
        {
            data[1] = noun;
            data[2] = verb;
        }

        private void ExecuteIntCode(IntCode intCode, int[] data)
        {
            switch (intCode.OpCode)
            {
                case (OpCode.Addition):
                    data[intCode.Position3] = data[intCode.Position1] + data[intCode.Position2];
                    break;
                case (OpCode.Multiplication):
                    data[intCode.Position3] = data[intCode.Position1] * data[intCode.Position2];
                    break;
                case (OpCode.Invalid):
                    throw new InvalidOperationException(
                        $"Invalid IntCode received: [{intCode.Position0},{intCode.Position1},{intCode.Position2},{intCode.Position3}]");
            }
        }
    }
}
