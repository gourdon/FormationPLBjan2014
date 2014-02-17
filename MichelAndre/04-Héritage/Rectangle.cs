using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Héritage {
  class Rectangle : FigurePleine {
    public Rectangle(int x, int y, int largeur, int longueur) : base (x, y, largeur, longueur) {}

    public override string ToString() {
      return "je suis un rectangle" + base.ToString();
    }

    public override int Surface { get { return Largeur * Longueur; } }
  }
}
