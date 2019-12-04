using AdventOfCode.Y2019.Models;
using AdventOfCode.Y2019.Puzzles.Generic;
using AdventOfCode2019;
using System;
using System.Linq;

namespace AdventOfCode.Y2019.Puzzles
{
    public class Puzzle02 : Puzzle
    {
        public int Part1(string[] input)
        {
            var data = input[0].Split(',').Select(x => int.Parse(x)).ToArray();
            var index = 0;
            var currentIntCode = data.ToIntCode(index);

            Part1ReplaceData(data);

            while (index < data.Length - 4 && currentIntCode.IsValid && !currentIntCode.IsFinished)
            {
                currentIntCode = data.ToIntCode(index);
                ExecuteIntCode(currentIntCode, data);
                index += 4;
            }

            return data[0];
        }

        public object Part2(string[] arg)
        {
            throw new NotImplementedException();
        }

        private void Part1ReplaceData(int[] data)
        {
            data[1] = 12;
            data[2] = 2;
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
