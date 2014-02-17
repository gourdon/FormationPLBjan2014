using System;
//using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;



namespace Chapitre3 {
  class Program {
    static void Main(string[] args) {

      Console.Write("nom ? ==> ");
      String nom = Console.ReadLine();

      Console.Write("type ? ==> ");
      TypeArticle type = (TypeArticle)Enum.Parse(typeof(TypeArticle), Console.ReadLine());


      Console.Write("prix ? ==> ");
      float prix = float.Parse(Console.ReadLine());
      Console.Write("quantité ? ==> ");
      uint quantité = uint.Parse(Console.ReadLine());

      Article a = new Article(nom, prix, quantité, type);

      Article[] tab = { a, a, a };
      tab[0].Ajouter(qtéAjoutée: 2);
      tab[1].Retirer(qtéRetirée: 1);

      foreach (Article item in tab) {
        item.Afficher();
      }
    }

    private static int Moyenne(params int[] values) {
      int somme = 0;
      foreach (int n in values)
        somme += n;
      return somme / values.Length;
    }

    private static void Init(out int c) {
      c = 99;
    }

    private static void Swap(ref int a, ref int b) {
      int c = a;
      a = b;
      b = c;
    }
  }
}
