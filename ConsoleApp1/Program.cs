using ConsoleApp1.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] Field = new int[10,10];
        Vector vector = new Vector();
        bool start = true;
        while (start)
        {
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