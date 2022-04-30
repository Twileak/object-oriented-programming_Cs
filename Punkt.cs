using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figury
{
    class Punkt
    {
        private int x, y;
        public Punkt(int xx, int yy)
        {
            x=xx;
            y=yy;
        }
        public Punkt()
        {
            x=0;
            y=0;
        }
        public Punkt(Punkt p)
        {
            x=p.x;
            y=p.y;
        }
        public void przesun(int dx, int dy)
        {
            x+=dx;
            y+=dy;
        }
        public override String ToString()
        {
            return "(" + x + "," + y + ")";
        }
    }
}