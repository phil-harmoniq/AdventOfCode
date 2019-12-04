using AdventOfCode.Y2019.Puzzles.Generic;
using System;

namespace AdventOfCode2019.Puzzles
{
    public class Puzzle01 : Puzzle
    {
        public int Part1(string[] input)
        {
            var fuel = 0;

            foreach (var massString in input)
            {
                var mass = int.Parse(massString);
                fuel += mass / 3 - 2;
            }

            return fuel;
        }

        public int Part2(string[] input)
        {
            var fuel = 0;

            foreach (var massString in input)
            {
                var mass = int.Parse(massString);
                fuel += RecursivelyCalculateFuel(mass);
            }

            return fuel;
        }

        private int RecursivelyCalculateFuel(int mass)
        {
            var fuelNeeded = mass / 3 - 2;

            if (fuelNeeded < 0)
            {
                return 0;
            }

            fuelNeeded += RecursivelyCalculateFuel(fuelNeeded);
            return fuelNeeded;
        }
    }
}