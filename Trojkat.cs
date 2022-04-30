using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figury
{
    class Trojkat
    {
        private Linia l1, l2, l3;

       public Trojkat(Punkt a, Punkt b, Punkt c)
       {
            l1 = new Linia(a,b);
            l2 = new Linia(b,c);
            l3 = new Linia(c,a);
       }
       public Trojkat()
       {
           Punkt p1 = new Punkt(0,0);
           Punkt p2 = new Punkt(1,0);
           Punkt p3 = new Punkt(0,1);

           l1 = new Linia(p1,p2);
           l2 = new Linia(p2,p3);
           l3 = new Linia(p3,p1);
       }
       public Trojkat(Trojkat t)
       {
           l1 = new Linia(t.l1);
           l2 = new Linia(t.l2);
           l3 = new Linia(t.l3);
       }
       public void przesun(int dx, int dy)
       {
           l1.przesun(dx,dy);
           l2.przesun(dx,dy);
           l3.przesun(dx,dy);
       }
       public override String ToString()
       {
           return l1 + "," + l2 + "," + l3;
       }
    }
}