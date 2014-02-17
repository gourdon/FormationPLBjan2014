using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre2
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture v = new Voiture();
            v.Démarrer(vitesse: 100);
            v.Stopper();
        }
    }
}
