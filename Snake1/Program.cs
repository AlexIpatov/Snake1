using System;

namespace Snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char sim1 = '*';
            Drew(x1, y1, sym1);

            

            int x2 = 4;
            int y2 = 5;
            char sim2 = '#';
            Drew(x2, y2, sym2);

            Console.ReadLine();
        }

        static void Drew(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write( sim );
        }
    }
}
