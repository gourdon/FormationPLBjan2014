using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapitre3 {
  struct Article {
    private string nom;
    private float prix;
    private uint quantité;
    private TypeArticle type;

    public Article(string nom, float prix, uint quantité, TypeArticle type) {
      this.nom = nom;
      this.prix = prix;
      this.quantité = quantité;
      this.type = type;
    }

    internal void Afficher() {
      Console.WriteLine("{0} ({1}) {2} euros, {3} article(s) en stock", nom, type, prix, quantité);
    }

    internal void Ajouter(uint qtéAjoutée) {
      quantité += qtéAjoutée;
    }

    internal void Retirer(uint qtéRetirée) {
      quantité -= qtéRetirée;
    }
  }
}
