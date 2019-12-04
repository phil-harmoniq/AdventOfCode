using AdventOfCode.Y2019.Models;
using System;

namespace AdventOfCode2019
{
    public static class Extensions
    {
        public static IntCode ToIntCode(this int[] data, int index)
        {
            return new IntCode(data[index], data[index + 1], data[index + 2], data[index + 3]);
        }
    }
}