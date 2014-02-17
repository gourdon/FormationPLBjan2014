using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2 {
  class Voiture : IDisposable {
    private int vitesse;

    ~Voiture() {
      Dispose();
    }

    internal void Démarrer(int vitesseInitiale) {
      vitesse = vitesseInitiale;
      Console.WriteLine("je démarre à {0} km/h", vitesseInitiale);
    }

    internal void Stopper() {
      vitesse = 0;
      Console.WriteLine("je stoppe");
    }

    public void Dispose() {
      Console.WriteLine("goodbye crual world");
      GC.SuppressFinalize(this);
    }
  }
}
