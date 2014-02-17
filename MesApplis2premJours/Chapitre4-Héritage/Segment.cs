using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapitre4_Héritage
{
    class Segment: Figure
    {
        private int x2;
        private int y2;

        public Segment(int x, int y, int x2, int y2):base(x,y)
        {
            this.x2 = x2;
            this.y2 = y2;
        }

        internal override void Afficher()
        {
            Console.WriteLine("L'origine du segment est: ");
            base.Afficher();
        }

    }
}
