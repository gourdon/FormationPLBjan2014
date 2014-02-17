using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapitre4_mercredi.Metier.Comparateur;

namespace Chapitre4_mercredi
{
    class Program
    {
        static void Main(string[] args)
        {

            AfficherMenu();
            Console.WriteLine("votre choix ?");
            string choix = Console.ReadLine();
            switch (choix.ToLower())
            {
                case "1":
                    ajouterContact();
                    break;
                case "2":
                    listerContact();
                    break;
                case "3":
                    trierContact();
                    break;
                case "4":
                    trierContactParDate();
                    break;
                case "5":
                    rechercheSimple();
                    break;
                case "6":
                    rechercheParDate();
                    break;
                case "7":
                    rechercheAvecLinq();
                    break;
                case "q":
                    return;
                default:
                    Console.WriteLine("Erreur");
                    break;
            }
            Console.WriteLine(" appuyez pour continuer");
            Console.ReadLine();
        }

        private static void rechercheAvecLinq()
        {
            List<Contact> l = Contact.Lister();

            Console.WriteLine("debut?");
            DateTime debut = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("fin?");
            DateTime fin = DateTime.Parse(Console.ReadLine());

            //l.OrderBy(r => r.Nom);  //r est typé automatiquement en un Contact, comme l est une liste de contacts
                                        // OrderBy = methode d'extension de Linq

            //IOrderedEnumerable<Contact> lt =  l.OrderBy(r => r.Nom).ThenBy(r => r.Prenom);
                                            // utilisation des expressions lambda

            //IEnumerable<Contact> resultat = l.Where(z => z.DateNaissance <= fin && z.DateNaissance >= debut);

            IEnumerable<Contact> resultat = from z in l //langage Linq
                                            where z.DateNaissance <= fin && z.DateNaissance >= debut
                                            orderby z.Nom
                                            select z;

            foreach (Contact c in resultat)
                Console.WriteLine(c.ToString());

            //IEnumerable<string> resultat3 = from x in l //langage Linq
            //                                where x.Nom.StartsWith("T")
            //                                orderby x.Nom
            //                                select x.Nom;

            IEnumerable<dynamic> resultat3 = from x in l //langage Linq
                                             where x.Nom.StartsWith("r")
                                             orderby x.Nom  //création (dessous) d'un type dynamique, sans créer une classe séparée
                                             select new { NomContact = x.Nom, DateContact = x.DateNaissance };

            foreach (dynamic d in resultat3)
                Console.WriteLine(d.NomContact);

        }

        private static void dico()
        {
            List<Contact> l = Contact.Lister();
            Dictionary<string, List<Contact>> d = new Dictionary<string, List<Contact>>();
            foreach (Contact c in l)
            {
                string lettre = c.Prenom.Substring(0, 1);
                if (!d.ContainsKey(lettre))
                    d.Add(lettre, new List<Contact>());
                d[lettre].Add(c);
            }

            foreach (KeyValuePair<string, List<Contact>> kvp in d)
            {
                Console.WriteLine("{0}", kvp.Key);
                foreach(Contact c in kvp.Value)
                {
                    Console.WriteLine("\t{0}", c.Prenom);
                }
            }


        }

        private static void rechercheParDate()
        {
            List<Contact> l = Contact.Lister();
            Console.WriteLine("debut?");
            DateTime debut = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("fin?");
            DateTime fin = DateTime.Parse(Console.ReadLine());
            List<Contact> resultat = l.FindAll(delegate(Contact c)
            {
                return c.DateNaissance >= debut && c.DateNaissance <= fin;  //methode anonyme
            });
        }

        private static void rechercheSimple()
        {
            List<Contact> l = Contact.Lister();
            List<Contact> resultat = l.FindAll(MethodeDeRecherche); //sans paranthese
            foreach (Contact c in resultat)
                Console.WriteLine(c.ToString());
        }

        private static bool MethodeDeRecherche(Contact c)
        {
            return c.Nom.Contains("h");
        }

        private static void trierContactParDate()
        {
            List<Contact> l = Contact.Lister();

            l.Sort(new ComparateurContactDate());
            foreach (Contact c in l)
                Console.WriteLine(c.ToString());
        }

        private static void trierContact()
        {
            //List<string> list = new List<string>();
            //list.Add("aaa3");
            //list.Add("aaa2");
            //list.Add("aaa5");
            //list.Sort();

            List<Contact> l = Contact.Lister();
            l.Sort();
            foreach (Contact c in l)
                Console.WriteLine(c.ToString());
        }

        private static void listerContact()
        {
            List<Contact> l = Contact.Lister();
            
            foreach(Contact c in l)
                Console.WriteLine(c.ToString());
        }

        private static void ajouterContact()
        {
            Contact c = new Contact();

            Console.WriteLine("Nom?");
            c.Nom = Console.ReadLine();

            Console.WriteLine("Prenom?");
            c.Prenom = Console.ReadLine();

            Console.WriteLine("Mail?");
            c.Mail = Console.ReadLine();

            while (true)    //boucle infinie
            {
                try
                {
                    Console.WriteLine("Date de naissance?");
                    c.DateNaissance = DateTime.Parse(Console.ReadLine());
                    break;   //sortie boucle infinie
                }
                catch (Exception)
                {
                    Console.WriteLine("Erreur !!");
                }
            }
            c.Enregistrer();

        }

        private static void AfficherMenu()
        {
            Console.Clear();
            Console.WriteLine(" --MENU --");
            Console.WriteLine(" -1- Ajouter un contact");
            Console.WriteLine(" -2- Lister des contacts");
            Console.WriteLine(" -3- Trier les contacts");
            Console.WriteLine(" -4- Trier les contacts par date");
            Console.WriteLine(" -5- Recherche par le nom");
            Console.WriteLine(" -6- Recherche par date");
            Console.WriteLine(" -7- Recherche avec Linq");
            Console.WriteLine(" -Q- Quitter");
        }


    }
}
