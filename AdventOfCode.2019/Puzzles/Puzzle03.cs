using AdventOfCode.Y2019.Models;
using AdventOfCode.Y2019.Puzzles.Generic;
using AdventOfCode2019;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Y2019.Puzzles
{
    public class Puzzle03 : IPuzzle
    {
        public int Part1(string[] input)
        {
            var wire1 = new ElectricalWire(GenerateVectors(input[0]));
            var wire2 = new ElectricalWire(GenerateVectors(input[1]));

            var intersections = wire1.Locations.Intersect(wire2.Locations);
            var intersectionCoun = intersections.Count();

            return intersections.Where(point => point.X != 0 && point.Y != 0)
                .OrderBy(point => Math.Abs(point.X) + Math.Abs(point.Y))
                .First()
                .DistanceToCenter();
        }

        public int Part2(string[] input)
        {
            var wire1 = new ElectricalWire(GenerateVectors(input[0]));
            var wire2 = new ElectricalWire(GenerateVectors(input[1]));

            var wire1intersections = wire1.Locations
                .Intersect(wire2.Locations)
                .Where(point => point.X != 0 && point.Y != 0)
                .OrderBy(point => point.Distance);

            var wire2intersections = wire2.Locations
                .Intersect(wire1.Locations)
                .Where(point => point.X != 0 && point.Y != 0)
                .OrderBy(point => point.Distance);

            var distances = new Dictionary<Point, int>();

            foreach (var intersection in wire1intersections)
            {
                var wire1Distance = wire1.Locations.First(p => p.X == intersection.X && p.Y == intersection.Y).Distance;
                var wire2Distance = wire2.Locations.First(p => p.X == intersection.X && p.Y == intersection.Y).Distance;

                distances.Add(intersection, wire1Distance + wire2Distance);
            }

            return distances
                .OrderBy(kvp => kvp.Value)
                .First()
                .Value;
        }

        private IList<Vector> GenerateVectors(string inputString)
        {
            var vectorList = new List<Vector>();
            var inputSplit = inputString.Split(',');

            foreach (var str in inputSplit)
            {
                var distance = int.Parse(str[1..]);
                var direction = str[0] switch
                {
                    'U' => Direction.Up,
                    'D' => Direction.Down,
                    'L' => Direction.Left,
                    'R' => Direction.Right,
                    _ => Direction.Invalid,
                };

                vectorList.Add(new Vector(direction, distance));
            }

            return vectorList;
        }
    }
}
