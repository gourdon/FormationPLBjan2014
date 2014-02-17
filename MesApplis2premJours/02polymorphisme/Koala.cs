using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02polymorphisme
{
    class Koala : Ianimal
    {
        public void Manger()
        {
            Console.WriteLine("je mange eucalyptus");
        }

        public void Boire()
        {
            Console.WriteLine("je bois coca");
        }
    }
}
