namespace ConsoleApp1.Models
{
    public class Snake
    {
        public int Id;
        public uint Speed = 1;
        public uint Lenght = 1;
        public Coordinate Head;
        public Vector Vector;

        public Snake(Coordinate head, Vector vector)
        {
            Head = head;
            Vector = vector;
        }
        //todo управление 
        // 4? функции на управление (wsad - по вектору) (проверки)
    }
}
