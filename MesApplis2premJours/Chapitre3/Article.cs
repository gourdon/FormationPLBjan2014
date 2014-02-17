using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapitre3
{
    struct Article
    {
        string nom;
        float prix;
        uint quantité;
        TypeArticle type;

        public Article(string nom, float prix, uint quantité, TypeArticle type)
        {
            this.nom = nom;
            this.prix = prix;
            this.quantité = quantité;
            this.type = type;
        }

        internal void Afficher()
        {
            Console.WriteLine("{0} {1} {2} {3}", nom, prix, quantité, type);
        }

        internal void Ajouter(uint qtéSuppl)
        {
            quantité +=  qtéSuppl;
        }

        internal void Retirer(uint qtéSuppl)
        {
            quantité -=  qtéSuppl;
        }
    }
}
