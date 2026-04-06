using ConsoleApp1.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        int x = 10, y = 10;
        Field field = new Field(x,y);
        Vector vector = new Vector();
        Snake snake = new Snake(new Coordinate(2,2), vector);
        bool start = true;
        while (start)
        {
            Console.Clear();
            field.Render(snake.Head);
            char ch = Console.ReadKey().KeyChar;
            switch (ch)
            {
                case 'w':
                    {
                        try
                        {
                            vector.MoveW();
                            //изменение вектора
                            //Смещение головы по вектору

                        }
                        catch
                        {

                        }
                        break;
                    }
                case 's':
                    {
                        break;
                    }
                case 'a':
                    {
                        break;
                    }
                case 'd':
                    {
                        break;
                    }
                case '1':
                    {
                        start = false;
                        break;
                    }
            }
        }
    }
}