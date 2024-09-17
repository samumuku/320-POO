using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace parachutes
{
    internal class Plane
    {
        public string[] _View =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        public int _PosX;



        public Plane(int PosX)
        {
            this._PosX = PosX;
  
        }
        public void update()
        {
            Console.Clear();
        }
        public void Move()
        {
            _PosX++;
            Console.SetCursorPosition(_PosX,1);

            for (int i = 0; i < _View.Length; i++)
            {
                Console.SetCursorPosition(_PosX, i + 1);
                Console.Write(_View[i]);
                
            }
            
        }

        


    }
}
