using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Héritage {
    class Program {
      static void Main(string[] args) {
        Figure r = new Rectangle(x: 10, y: 30, largeur: 100, longueur: 300);
        Figure e = new Ellipse (x: 40, y: 30, largeur: 50, longueur: 80);
        Figure s = new Segment(x: 50, y: 50, x2: 70, y2: 80);

        Console.WriteLine(r);
        r.Move(123, 78);
        Console.WriteLine(r);

        Console.WriteLine(s);
        Console.WriteLine(e);

        Console.WriteLine((r as FigurePleine).Surface + " m2");
        Console.WriteLine((e as FigurePleine).Surface + " m2");
      }  
   }
}
