namespace ConsoleApp1.Models
{
    public class Coordinate
    {
        public short X;
        public short Y;

        public Coordinate(short x, short y)
        {
            X = x;
            Y = y;

        }
        public override string ToString()
        {
            return $"[{X}:{Y}]";
        }
    }
}
