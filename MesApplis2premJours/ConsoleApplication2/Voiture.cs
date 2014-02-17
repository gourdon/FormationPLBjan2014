using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapitre2
{
    class Voiture
    {
        internal void Démarrer(int vitesse)
        {
            Console.WriteLine("je démarre à la {0}", vitesse);
        }

        internal void Stopper()
        {
            Console.WriteLine("je stoppe");
        }
    }
}
