using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("nom ? ==> ");
            //string nom = Console.ReadLine();
            //Console.WriteLine("prix ? ==> ");
            //float prix = float.Parse(Console.ReadLine());
            //Console.WriteLine("quantité ? ==> ");
            //uint quantité = uint.Parse(Console.ReadLine());

            //Console.WriteLine("type ? ==> ");
            //TypeArticle s = (TypeArticle)Enum.Parse(typeof(TypeArticle), Console.ReadLine());

            //Article a = new Article(nom, prix, quantité, s);
            //a.Afficher();

            //a.Ajouter(10);
            //a.Afficher();

            //a.Retirer(5);
            //a.Afficher();

            Article a = new Article("jean", 25, 2, TypeArticle.Vestimentaire);
            Article b = new Article("chemise", 45, 22, TypeArticle.Vestimentaire);
            Article c = new Article("pâtes", 5, 32, TypeArticle.Alimentaire);

            Article[] tab = { a, b, c };

            foreach (Article art in tab)
            {
                art.Afficher();
            }
        }
    }

   
}
