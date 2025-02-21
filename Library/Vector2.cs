using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Pong
{
    public class Vector2
    {
        public int x { get; set; }
        public int y { get; set; }

        public Vector2(int Vx, int Vy) { x = Vx; y = Vy; }
        public Vector2() { x = 0; y = 0; }

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            if (a == null) a = new Vector2(0, 0);
            return new Vector2(a.x + b.x, a.y + b.y);
        }

    }
}
