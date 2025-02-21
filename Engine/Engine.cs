using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Pong
{
    public class Engine
    {
        void _init()
        {

        }

        void _compute()
        {

        }

        void _render()
        {
            Render render = new Render();
            render.Run();
        }

        void _fetch()
        {

        }

        public void _run()
        {
            _init();
            _compute();
            _render();
        }
    }
}
