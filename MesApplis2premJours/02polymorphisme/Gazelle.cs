using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02polymorphisme
{
    class Gazelle : Ianimal
    {
        public void Manger()
        {
            Console.WriteLine("je mange herbe");
        }

        public void Boire()
        {
            Console.WriteLine("je bois eau");
        }
    }
}
