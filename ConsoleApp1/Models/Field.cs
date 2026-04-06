namespace ConsoleApp1.Models
{
    public class Field
    {
        private int x = 10;
        private int y = 10;
        private List<List<char>> field;

        public Field(int x, int y)
        {
            this.x = x;
            this.y = y;
            field = new List<List<char>>()
            { 
                new List<char>(){'-','-','-','-','-','-','-','-','-','-'},
                new List<char>(){'|',' ', ' ',' ',' ',' ',' ',' ',' ', '|'},
                new List<char>(){'|',' ', ' ',' ',' ',' ',' ',' ',' ', '|'},
                new List<char>(){'|',' ', ' ',' ',' ',' ',' ',' ',' ', '|'},
                new List<char>(){'|',' ', ' ',' ',' ',' ',' ',' ',' ', '|'},
                new List<char>(){'|',' ', ' ',' ',' ',' ',' ',' ',' ', '|'},
                new List<char>(){'|',' ', ' ',' ',' ',' ',' ',' ',' ', '|'},
                new List<char>(){'|',' ', ' ',' ',' ',' ',' ',' ',' ', '|'},
                new List<char>(){'|',' ', ' ',' ',' ',' ',' ',' ',' ', '|'},
                new List<char>(){'-','-','-','-','-','-','-','-','-','-' }
            };
        }

    public void Render(Coordinate head)
        {
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if(head.X == i && head.Y == j)
                    {
                        Console.Write('@');
                    }
                    else
                    {
                        Console.Write(field[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
