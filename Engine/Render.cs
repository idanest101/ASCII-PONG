using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Pong
{
    internal class Render
    {
        public Grid grid = new Grid(new Vector2(100, 25));

        private const int Width = 100;
        private const int Height = 25;
        char[,] buffer = new char[Width, Height];


        public void Run()
        {
            _clearBuffer();

            _drawBorders();

            _printBuffer();
        }

        private void _clearBuffer()
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    buffer[x, y] = ' ';
                }
            }
        }

        private void _drawBorders()
        {
            for (int y = 0; y < Height; y++)
            {
                for(int x = 0; x < Width; x++)
                {
                    buffer[x, y] = '█';
                }
                
            }
        }
        void _printBuffer()
        {
            Console.SetCursorPosition(0, 0);
            StringBuilder output = new StringBuilder();

            for (int y = 0; y < grid.Size.y; y++)
            {
                for (int x = 0; x < grid.Size.x; x++)
                {
                    output.Append(buffer[x, y]);
                }
                output.AppendLine();
            }

            Console.Write(output.ToString());
        }
    }
}
