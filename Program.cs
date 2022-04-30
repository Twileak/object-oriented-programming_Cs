using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figury
{
    class Program
    {
       static void Main(string[] args)
       {
           int wybor = -1;
            int wsp_x, wsp_y;
            Obraz obrazek = new Obraz();
            List<Trojkat> troj = new List<Trojkat>();
            List<Czworokat> czwo = new List<Czworokat>();

            
            
            while (wybor!=0)
            {
                Console.WriteLine("\n1.Dodaj Trojkat do obrazu.");
                Console.WriteLine("2.Dodaj kwadrat do obrazu.");
                Console.WriteLine("3.Przesun caly obraz.");
                Console.WriteLine("4.Wypisz figury w obrazie.");
                Console.WriteLine("0.Zakoncz dzialanie programu.\n");

                wybor = Convert.ToInt32(Console.ReadLine());

                switch(wybor)
                {
                    case 1:
                        Console.WriteLine("wspolrzedne 1 punktu(x -> y):");
                        wsp_x = Convert.ToInt32(Console.ReadLine());
                        wsp_y = Convert.ToInt32(Console.ReadLine());
                        Punkt t1 = new Punkt(wsp_x,wsp_y);
                        Console.WriteLine("wspolrzedne 2 punktu(x -> y):");
                        wsp_x = Convert.ToInt32(Console.ReadLine());
                        wsp_y = Convert.ToInt32(Console.ReadLine());
                        Punkt t2 = new Punkt(wsp_x,wsp_y);
                        Console.WriteLine("wspolrzedne 3 punktu(x -> y):");
                        wsp_x = Convert.ToInt32(Console.ReadLine());
                        wsp_y = Convert.ToInt32(Console.ReadLine());
                        Punkt t3 = new Punkt(wsp_x,wsp_y);
                        Trojkat trojkacik = new Trojkat(t1,t2,t3); 
                        obrazek.dodajTrojkat(trojkacik);
                        break;
                    
                    case 2:
                        Console.WriteLine("wspolrzedne 1 punktu(x -> y):");
                        wsp_x = Convert.ToInt32(Console.ReadLine());
                        wsp_y = Convert.ToInt32(Console.ReadLine());
                        Punkt c1 = new Punkt(wsp_x,wsp_y);
                        Console.WriteLine("wspolrzedne 2 punktu(x -> y):");
                        wsp_x = Convert.ToInt32(Console.ReadLine());
                        wsp_y = Convert.ToInt32(Console.ReadLine());
                        Punkt c2 = new Punkt(wsp_x,wsp_y);
                        Console.WriteLine("wspolrzedne 3 punktu(x -> y):");
                        wsp_x = Convert.ToInt32(Console.ReadLine());
                        wsp_y = Convert.ToInt32(Console.ReadLine());
                        Punkt c3 = new Punkt(wsp_x,wsp_y);
                        Console.WriteLine("wspolrzedne 4 punktu(x -> y):");
                        wsp_x = Convert.ToInt32(Console.ReadLine());
                        wsp_y = Convert.ToInt32(Console.ReadLine());
                        Punkt c4 = new Punkt(wsp_x,wsp_y);
                        Czworokat czworokacik = new Czworokat(c1,c2,c3,c4) ;
                        obrazek.dodajCzworokat(czworokacik);
                        break;
                    
                    case 3:
                        int d_x,d_y;
                        Console.WriteLine("podaj przesuniecie(x -> y)");
                        d_x = Convert.ToInt32(Console.ReadLine());
                        d_y = Convert.ToInt32(Console.ReadLine());
                        obrazek.przesun(d_x,d_y);
                        break;
                    
                    case 4:
                        troj = obrazek.getTrojkat();
                        czwo = obrazek.getCzworokat();

                        for(int i=0; i<troj.Count; i++) Console.WriteLine(troj[i]);
                        for(int i=0; i<czwo.Count; i++) Console.WriteLine(czwo[i]);
                        break;
                }
            }
       }
    }
}