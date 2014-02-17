using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre4_Equals {

  class Rectangle {
    private int largeur;

    public int Largeur {
      get { return largeur; }
      set { largeur = value; }
    }
    private int longueur;

    public int Longueur {
      get { return longueur; }
      set { longueur = value; }
    }

    public Rectangle(int largeur, int longueur) {
      this.largeur = largeur;
      this.longueur = longueur;
    }
  }

  class Ellipse {
    public int Largeur { get; set; }
    public int Longueur { get; set; }
  }

  class Program {
    static void Main(string[] args) {

      Rectangle r = new Rectangle(largeur: 100, longueur: 1000);
      Ellipse e = new Ellipse { Largeur = 100, Longueur = 1000 };

      Point p = new Point(10, 5);
      Point p2 = new Point(10, 5);

      PointD pDouble = new PointD(23.45, 12.8);

      p = (Point)pDouble;

      pDouble = p;

      //Point p3 = p + p2;

      //p3 += p;

      //if (p.Equals(p2)) {
      //  Console.WriteLine("égalité par valeur");      
      //}

      //if (Object.ReferenceEquals (p, p2)) {
      //  Console.WriteLine("égalité d'identité");
      //}
    }
  }
}
