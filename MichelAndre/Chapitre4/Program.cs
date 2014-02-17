using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre4 {
  class Moteur {
    private readonly int cylindrée;
    private static int compteur = 0;

    public Moteur(int cylindrée = 500) {
      this.cylindrée = cylindrée;
      compteur++;
    }

    static Moteur() {
      Console.WriteLine("chargement de la classe Moteur");
    }

    static public void Truc() {
      Console.WriteLine("Moteur.Truc()");
    }

    public void Afficher() {
      Console.WriteLine(cylindrée);
    }

    internal static void Foo() {
      throw new NotImplementedException();
    }
  }

  class B {
    private int n;
    public B(int n = 3) {
      this.n = n;
    }
    public void Afficher() {
      Console.WriteLine(n);
    }
  }


  class Program {
    static void Main(string[] args) {
      Moteur a = new Moteur();

      a.Afficher();

      B b = new B(123);
      b.Afficher();
      B b2 = new B();
      b2.Afficher();
    }
  }
}
