using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figury
{
    class Czworokat
    {
       private Linia l1, l2, l3, l4;
        public Czworokat()
        {
            l1 = new Linia();
            l2 = new Linia();
            l3 = new Linia();
            l4 = new Linia();
        }
        public Czworokat(Punkt a, Punkt b, Punkt c, Punkt d)
        {
            l1 = new Linia(a,b);
            l2 = new Linia(b,c);
            l3 = new Linia(c,d);
            l4 = new Linia(d,a);
        }
        public Czworokat(Czworokat c)
        {
           Punkt p1 = new Punkt(0,0);
           Punkt p2 = new Punkt(1,0);
           Punkt p3 = new Punkt(1,1);
           Punkt p4 = new Punkt(0,1);

           l1 = new Linia(p1,p2);
           l2 = new Linia(p2,p3);
           l3 = new Linia(p3,p4);
           l4 = new Linia(p4,p1);
        }
        public void przesun(int dx, int dy)
        {
            l1.przesun(dx,dy);
            l2.przesun(dx,dy);
            l3.przesun(dx,dy);
            l3.przesun(dx,dy);
        }
        public override String ToString()
        {
            return l1 + "," + l2 + "," + l3 + "," +l4;
        }
    }
}