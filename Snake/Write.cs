using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Write
    {
        int x;
        int y;
        int scr;

        public Write(int x, int y, int scr)
        {
            this.x = x;
            this.y = y;
            this.scr = scr;
        }
        public void DrawScore()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(x, y);
            Console.Write("score:{0}", scr);
        }
        public void DrawSpeed()
        {
            scr = 100 - scr;
            scr = scr / 10;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(x, y);
            Console.Write("speed LVL:{0}", scr);
        }





    }
}
