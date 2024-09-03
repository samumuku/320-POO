using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace parachutes
{
    class Plane
    {
        private readonly string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        public int PosX;


        public static void move(int PosX)
        {
            PosX++;
        }
        public static void draw(string[] view,int PosX)
        {
            Console.SetCursorPosition(PosX, 0);
            Console.Write(view);
        }

        public static void update()
        {
            Console.Clear();
        }

        Plane plane1 = new Plane(0);

        public Plane(int PosX) 
        {
            this.PosX = PosX;
        }

        while(int PosX)
        

    }
}
