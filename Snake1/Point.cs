using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snake1
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write( sym );
        }
    }
}
