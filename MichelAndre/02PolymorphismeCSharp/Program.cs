using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PolymorphismeCSharp {

  interface IAnimal {
    void Manger();
    void Boire();
  }

  class Lion : IAnimal {
    public void Manger() {
      Console.WriteLine("je mange de la gazelle");
    }

    public void Boire() {
      Console.WriteLine("je bois du Fronsac");
    }

    public void Rugir() {
      Console.WriteLine("GGGRRRRRRR");
    }
  }

  class Gazelle : IAnimal {
    public void Manger() {
      Console.WriteLine("je mange du lion");
    }

    public void Boire() {
      Console.WriteLine("je bois du Pommerol");
    }
  }

  class Program {
    static void Main(string[] args) {

      Lion l = new Lion();

      IAnimal a = l;


      Nourrir(new Lion());
      Nourrir(new Gazelle());
      Nourrir(new Koala());
    }

    private static void Nourrir(IAnimal a) {
      a.Manger();
      a.Boire();
    }
  }
}
