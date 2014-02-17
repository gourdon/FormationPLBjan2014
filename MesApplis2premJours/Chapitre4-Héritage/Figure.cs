using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapitre4_Héritage
{
    abstract class Figure
    {
        private int x;
        private int y;

        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        internal virtual void Afficher()
        {
            Console.WriteLine("x:{0} et y:{1} ", x , y);
        }
    }
}
