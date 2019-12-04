using System;

namespace AdventOfCode.Y2019.Models
{
    public struct Point
    {
        public int X { get; }
        public int Y { get; }
        public int Distance { get; }
        public Guid Id { get; }

        public Point(int x, int y, int distance)
        {
            X = x;
            Y = y;
            Distance = distance;
            Id = Guid.NewGuid();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Point)) { return false; }
            var otherPoint = (Point)obj;
            return X == otherPoint.X && Y == otherPoint.Y;
        }

        public override int GetHashCode()
        {
            return X * 17 + Y * 17;
        }
    }
}
