using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2 {
  class Program {
    static void Main(string[] args) {
      using (Voiture v = new Voiture()) {
        v.Démarrer(vitesseInitiale: 100);
        v.Stopper();
      }
    }
  }
}
