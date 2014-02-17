using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre4_Héritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(x: 10, y: 30, largeur: 100, longueur: 300);
            Segment s = new Segment(x: 50, y : 50, x2: 70, y2: 80);
            r.Afficher();
            s.Afficher();
            Console.WriteLine(r.Surface);

        }
    }
}
