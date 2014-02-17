using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapitre4_Héritage
{
    abstract class FigurePleine: Figure
    {
        private int largeur;
        private int longueur;

        public FigurePleine(int x, int y, int largeur, int longueur) : base(x,y)
        {
            this.largeur = largeur;
            this.longueur = longueur;
        }

        internal override void Afficher()
        {
            base.Afficher();
        }

        public int Largeur { get { return largeur; } }
        public int Longueur { get { return longueur; } }
        public abstract float Surface{get;}
    }
}
