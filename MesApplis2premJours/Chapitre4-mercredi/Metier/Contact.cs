using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Chapitre4_mercredi;   //pour pouvoir utiliser nom relatif du fichier
using System.IO;

namespace Chapitre4_mercredi
{
    /// <summary>
    /// 
    /// </summary>
    class Contact : IComparable<Contact>
    {
        private const char SEPARATEUR = ';';
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom { get; set; }

        private string mail;

        public string Mail
        {
            get { return mail; }
            set {
                Regex reg = new Regex(@"^[a-zA-Z0-9_.-]+@{1}[a-zA-Z0-9_.-]{2,}\.[a-zA-Z.]{2,5}$");
                if (reg.IsMatch(value))
                    mail = value;
                else
                    throw new FormatException("Format incorrect");
                }
        }

        private DateTime dateNaissance;

        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }

        public Contact()
        {

        }

        public Contact(string nom, string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }

        public void Enregistrer()
        {
            StreamWriter sw = new StreamWriter(Settings1.Default.Chemin, true, Encoding.UTF8);  //true pour qu'il écrive à la suite
            try
            {
                sw.WriteLine(this.ToString());
            }
            finally
            {
                sw.Close();
            }
        }

        public override string ToString()
        {
            StringBuilder build = new StringBuilder();
            build.Append(this.Nom);
            build.Append(SEPARATEUR);
            build.Append(this.Prenom);
            build.Append(SEPARATEUR);
            build.Append(this.Mail);
            build.Append(SEPARATEUR);
            build.Append(this.DateNaissance.ToString("dd/MM/yyyy"));    //M pour mois; m pour minutes

            return build.ToString();
        }

        public static List<Contact> Lister()
        {
            List<Contact> list = new List<Contact>();

            //StreamReader ou.... :
            //Directory.   ou... :
            IEnumerable<string> fichier = File.ReadLines(Settings1.Default.Chemin, Encoding.UTF8);
            foreach (string ligne in fichier)
            {
                string[] tab = ligne.Split(SEPARATEUR);
                Contact c = new Contact();
                c.Nom = tab[0];
                c.Prenom = tab[1];
                c.Mail = tab[2];
                c.DateNaissance = DateTime.Parse(tab[3]);
                list.Add(c);
            }
            return list;
        }

        public int CompareTo(Contact other) //compare this et other int>
        {
            return this.Nom.CompareTo(other.Nom) == 0 ? this.Prenom.CompareTo(other.Prenom) : this.Nom.CompareTo(other.Nom);   //marche car string implémente IComparable
        }
    }
}
