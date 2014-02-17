using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02polymorphisme
{
    class Lion : Ianimal
    {
        public void Manger()
        {
            Console.WriteLine("je mange gazelle");
        }

        public void Boire()
        {
            Console.WriteLine("je bois bière");
        }
    }
}
