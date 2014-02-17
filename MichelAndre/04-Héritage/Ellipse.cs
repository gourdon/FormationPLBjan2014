using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Héritage {
  class Ellipse : FigurePleine {
    public Ellipse(int x, int y, int largeur, int longueur) : base (x, y, largeur, longueur) {}

    public override string ToString() {
      return "je suis une ellipse" + base.ToString();
    }

    public override int Surface {
      get {return Convert.ToInt32 (Math.PI * Largeur / 2 * Longueur / 2); } 
    }
  }
}
