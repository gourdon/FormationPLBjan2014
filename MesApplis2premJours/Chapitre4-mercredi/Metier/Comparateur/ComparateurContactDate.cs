using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapitre4_mercredi.Metier;

namespace Chapitre4_mercredi.Metier.Comparateur
{
    class ComparateurContactDate : IComparer<Contact>
    {
        public int Compare(Contact x, Contact y)
        {
            return x.DateNaissance.CompareTo(y.DateNaissance);
        }
    }
}
