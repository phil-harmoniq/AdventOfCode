using System;

namespace AdventOfCode.Y2019.Models
{
    public class IntCode
    {
        public OpCode OpCode { get; }
        public int Position0 { get; }
        public int Position1 { get; }
        public int Position2 { get; }
        public int Position3 { get; }

        public bool IsValid => OpCode != OpCode.Invalid;
        public bool IsFinished => OpCode == OpCode.Finished;

        public IntCode(int position0, int position1, int position2, int position3)
        {
            Position0 = position0;
            Position1 = position1;
            Position2 = position2;
            Position3 = position3;

            switch (position0)
            {
                case 1:
                    OpCode = OpCode.Addition;
                    break;
                case 2:
                    OpCode = OpCode.Multiplication;
                    break;
                case 99:
                    OpCode = OpCode.Finished;
                    break;
                default:
                    OpCode = OpCode.Invalid;
                    break;
            }
        }
    }
}
