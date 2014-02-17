using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02Héritage {
  class Dé {
    private Random générateur = new Random();
    internal virtual void Lancer() {
      Console.WriteLine(générateur.Next(1, 7));
    }
  }
}
