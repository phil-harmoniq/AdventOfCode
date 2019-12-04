namespace AdventOfCode.Y2019.Models
{
    public struct Vector
    {
        public Direction Direction { get; }
        public int Distance { get; }

        public Vector(Direction direction, int distance)
        {
            Direction = direction;
            Distance = distance;
        }
    }
}
