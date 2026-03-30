internal class Program
{
    private static void Main(string[] args)
    {
        int[,] Field = new int[10,10];
        
        bool start = true;
        while (start)
        {
            char ch = Console.ReadKey().KeyChar;
            switch (ch)
            {
                case 'w':
                    {
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