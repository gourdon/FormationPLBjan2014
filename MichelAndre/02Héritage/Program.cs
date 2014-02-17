using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02Héritage {
  
  class Program {
    static void Main(string[] args) {
      DéPipé d2 = new DéPipé(facePipée: 3);
      for (int n = 0; n < 10; ++n) {
        d2.Lancer();
      }
    }
  }
}
