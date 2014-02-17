using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            Nourrir(new Lion());
            Nourrir(new Gazelle());
            Nourrir(new Koala());
        }

        private static void Nourrir(Ianimal a)
        {
            a.Manger();
            a.Boire();
        }
    }
}
