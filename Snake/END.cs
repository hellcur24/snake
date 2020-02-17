using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class END
    {
        int x;
        int y;
        int scr;
        public END(int x, int y, int scr)
        {
            this.x = x;
            this.y = y;
            this.scr = scr;
        }
        public void DrawEnd()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x, y);
            Console.Write("!!!!!Snake is dead!!!!!");
            Console.SetCursorPosition(x+6, y+1);
            Console.Write("Press F");
            Console.SetCursorPosition(x+3, y + 2);
            Console.Write("Your score:{0}", scr);
        }
    }
}
