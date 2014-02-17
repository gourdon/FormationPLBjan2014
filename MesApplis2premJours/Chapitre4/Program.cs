using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom = "gourdon";
            string prénom = "jean";
            Personne a = new Personne(nom,prénom);
            nom = "coucou";
            prénom = "toto";
            Personne b = new Personne(nom, prénom);

            Personne.LireCombien();

            if (a == b)
            {
                Console.WriteLine("Egaux!!");
            }
            else
            {
                Console.WriteLine("Pas Egaux!!");
            }

            nom = "gourdon";
            prénom = "jean";
            b = new Personne(nom, prénom);
            if (a == b)
            {
                Console.WriteLine("Enfin Egaux!!");
            }
            else
            {
                Console.WriteLine("Toujours Pas Egaux!!");
            }
        }
    }
}
