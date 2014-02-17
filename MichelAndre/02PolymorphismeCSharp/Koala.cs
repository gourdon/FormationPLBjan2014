using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02PolymorphismeCSharp {
  class Koala : IAnimal {
    public void Manger() {
      Console.WriteLine("je mange des feuilles");
    }

    public void Boire() {
      Console.WriteLine("je bois du Coca");
    }
  }
}
