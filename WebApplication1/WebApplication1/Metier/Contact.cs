using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace WebApplication1.Metier
{
    public class Contact
    {

        public long id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public long PaysId { get; set; }


        public Contact(string nom, string prenom, string date_naissance, long pays_id)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = Convert.ToDateTime(date_naissance); //car ne gere que date anglaise
            this.PaysId = pays_id;
        }

        public Contact()
        {
        }

        public static void Enregitrer(Contact co)
        {
            using (MySqlConnection connexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["MaConnexion"].ConnectionString))
            {
                connexion.Open();
                string req = "INSERT INTO Contact (nom, prenom, date_naissance, pays_id) VALUES (?nom, ?prenom, ?date_naissance, ?pays_id);";

                MySqlCommand command = new MySqlCommand(req, connexion);

                //2: pour types standards
                command.Parameters.AddWithValue("?nom", co.Nom);
                command.Parameters.AddWithValue("?prenom", co.Prenom);
                command.Parameters.AddWithValue("?date_naissance", co.DateNaissance);
                command.Parameters.AddWithValue("?pays_id", co.PaysId);

                command.ExecuteNonQuery();

                co.id = command.LastInsertedId;
            }
        }

        public static List<Contact> Lister()
        {
            List<Contact> list = new List<Contact>();

            using (MySqlConnection connexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["MaConnexion"].ConnectionString))
            {
                connexion.Open();
                string req = "SELECT * FROM Contact;";
                MySqlCommand command = new MySqlCommand(req, connexion);

                using (MySqlDataReader resultat = command.ExecuteReader())  //car il faut fermer le jeu d'enregistrement avant de pouvoir fermer la connexion
                {
                    while (resultat.Read())
                    {
                        Contact co = new Contact();
                        co.id = resultat.GetInt64("id");
                        co.Nom = resultat.GetString("nom");
                        co.Prenom = resultat.GetString("prenom");
                        co.DateNaissance = resultat.GetDateTime("date_naissance");
                        co.PaysId = resultat.GetInt64("pays_id");
                        list.Add(co);
                    }
                }
            }
            return list;
        }
    }
}