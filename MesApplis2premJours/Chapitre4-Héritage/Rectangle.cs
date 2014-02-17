using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapitre4_Héritage
{
    class Rectangle : FigurePleine
    {

        public Rectangle(int x, int y, int largeur, int longueur)
            : base(x, y, largeur, longueur)
        {

        }

        internal override void Afficher()
        {
            Console.WriteLine("L'origine du rectangle est: ");
            base.Afficher();
        }

        public override float Surface { get { return (Longueur * Largeur); } }


    }
}
