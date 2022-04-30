using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figury
{
    class Linia
    {
        private Punkt p1, p2;
        public Linia(Punkt a, Punkt b)
        {
            p1 = new Punkt(a);
            p2 = new Punkt(b);
        }
        public Linia()
        {
            p1 = new Punkt(0,0);
            p2 = new Punkt(1,0);
        }
        public Linia(Linia l)
        {
            p1 = new Punkt(l.p1);
            p2 = new Punkt(l.p2);
        }
        public void przesun(int dx, int dy)
        {
            p1.przesun(dx,dy);
            p2.przesun(dx,dy);
        }
        public override string ToString()
        {
            return p1 + "->" + p2;
        }
    }
}