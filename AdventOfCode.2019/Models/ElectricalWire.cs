using System.Collections.Generic;

namespace AdventOfCode.Y2019.Models
{
    public class ElectricalWire
    {
        public int Distance { get; private set; }
        public IList<Point> Locations { get; }

        public ElectricalWire(IEnumerable<Vector> vectors)
        {
            Locations = new List<Point>();
            MapLocations(vectors);
        }

        private void MapLocations(IEnumerable<Vector> vectors)
        {
            var x = 0;
            var y = 0;

            foreach (var vector in vectors)
            {
                for (var i = 0; i < vector.Distance; i++)
                {
                    switch (vector.Direction)
                    {
                        case Direction.Up:
                            y++;
                            break;
                        case Direction.Down:
                            y--;
                            break;
                        case Direction.Right:
                            x++;
                            break;
                        case Direction.Left:
                            x--;
                            break;
                    }

                    Distance++;
                    Locations.Add(new Point(x, y, Distance));
                }
            }
        }
    }
}
