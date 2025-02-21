using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Pong
{
    internal class Grid : Vector2
    {
        public Vector2 Cordinates {  get; set; }
        public Vector2 Size { get; set; }


        public Grid(Vector2 _Size) { Size = _Size; }
        public Grid(int _Size_X, int _Size_Y) { Size.x = _Size_X; Size.y = _Size_Y; }
        public Grid(Grid grid) { Size = grid; }
        
        public Vector2 getCords(Grid grid)
        {
            return grid.Cordinates;
        }
    }
}
