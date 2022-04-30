using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figury
{
    class Obraz
    {
        private List<Trojkat> tr = new List<Trojkat>();
        private List<Czworokat> cz = new List<Czworokat>();
        public Obraz() {}
        public void dodajTrojkat(Trojkat trojkat)
        {
            tr.Add(trojkat);
        }
        public void dodajCzworokat(Czworokat czworokat)
        {
            cz.Add(czworokat);
        }
        public void przesun(int dx, int dy)
        {
            for(int i=0; i<tr.Count; i++)
            {
                tr[i].przesun(dx,dy);
            }
            for(int i=0; i<cz.Count; i++)
            {
                cz[i].przesun(dx,dy);
            }
        }

        public List<Trojkat> getTrojkat()
        {
            return tr;
        }

        public List<Czworokat> getCzworokat()
        {
            return cz;
        }

        public override String ToString()
        {
            return string.Join(",", tr) + "," + string.Join(",", cz);
        }
    }
}