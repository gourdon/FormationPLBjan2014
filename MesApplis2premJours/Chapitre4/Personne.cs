using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapitre4
{
    class Personne
    {
        private readonly string nom;

        public string Nom
        {
            get { return nom; }
        }

        private readonly string prénom;

        public string Prénom
        {
            get { return prénom; }
        } 

        private static int nbreInstances;

        public Personne(string nom, string prénom)
        {
            this.nom = nom;
            this.prénom = prénom;
            nbreInstances += 1;
        }

        internal static void LireCombien()
        {
            Console.WriteLine(" Nbre d instances = {0}", nbreInstances);
        }

        public static bool operator ==(Personne a, Personne b)
        {
            return a.nom == b.nom && a.prénom == b.prénom;
        }

        public static bool operator !=(Personne a, Personne b)
        {
            return !(a==b);
        }

        public override bool Equals(object obj)
        {
            return this == (Personne) obj;
        }

    }
}
