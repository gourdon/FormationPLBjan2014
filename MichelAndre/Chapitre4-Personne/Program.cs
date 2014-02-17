using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre4_Personne {
  class Program {
    static void Main(string[] args) {
      Personne p = new Personne { Nom = "Valjean", Prénom = "Jean" };

      Personne p3 = new Personne();
      p3.Nom = "Valjean";
      p3.Prénom = "Jean";


      Personne p2 = new Personne { Prénom = "Toto" };

      var v = new { Nom = "Toto", Prénom = "Titi" };




    }
  }
}
