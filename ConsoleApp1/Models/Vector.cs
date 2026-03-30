namespace ConsoleApp1.Models
{
    public class Vector
    {
        public Coordinate Coordinate;

        public override string ToString()
        {
            return Coordinate.ToString();
        }

        //todo проверки на существование вектора
        // [|1|:|1|]

        //todo методы изменения вектора (в них проверка)
    }
}
