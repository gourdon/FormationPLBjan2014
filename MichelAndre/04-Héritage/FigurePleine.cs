using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Héritage {
  abstract class FigurePleine : Figure {
    private readonly int largeur;
    public int Largeur {get { return largeur; }}
    private readonly int longueur;
    public int Longueur {get { return longueur; }}

    public FigurePleine(int x, int y, int largeur, int longueur) : base (x, y) {
      this.largeur = largeur;
      this.longueur = longueur;
    }

    public abstract int Surface { get; }
  }
}
