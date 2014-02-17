using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02Héritage {
  class DéPipé : Dé {
    private int facePipée;
    private bool flip = true;

    public DéPipé(int facePipée) {
      this.facePipée = facePipée;
    }

    internal override void Lancer() {
      flip = !flip;
      if (flip)
        base.Lancer();
      else
        Console.WriteLine(facePipée);
    }
  }
}
