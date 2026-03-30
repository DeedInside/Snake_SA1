namespace ConsoleApp1.Models
{
    public class Vector
    {
        private Coordinate coordinate = new Coordinate(0,1);
        public Coordinate Coordinate
        {
            get { return coordinate; }
            set { coordinate = value; }
        }

        public override string ToString()
        {
            return Coordinate.ToString();
        }

        //todo проверки на существование вектора
        // [|1|:|1|]
        
        //todo методы изменения вектора (в них проверка)
        public bool MoveW()
        {
            if (Coordinate.X != 1)
            {
                Coordinate.X = -1;
                Coordinate.Y = 0;
                return true;
            }
            else
            {
                return false;
                throw new Exception("Движение заблокировано");
            }
        }
    }
}
