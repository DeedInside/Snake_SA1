namespace ConsoleApp1.Models
{
    public class Coordinate
    {
        public short X;
        public short Y;

        public override string ToString()
        {
            return $"[{X}:{Y}]";
        }
    }
}
