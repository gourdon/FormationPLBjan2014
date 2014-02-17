using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace WebApplication1.Metier
{
    public class Pays
    {
        public long id { get; set; }
        public string Nom { get; set; }
        public string Code { get; set; }

        public static void Enregitrer(Pays pi)
        {
            using (MySqlConnection connexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["MaConnexion"].ConnectionString ))
            {
                connexion.Open();
                string req = "INSERT INTO Pays (nom, code) VALUES (?nom, ?code);";

                MySqlCommand command = new MySqlCommand(req, connexion);

                //1: pour les types non standard: fichiers binaires, types spécifiques, etc...
                MySqlParameter paramNom = new MySqlParameter("?nom", MySqlDbType.VarChar);
                paramNom.Value = pi.Nom;
                command.Parameters.Add(paramNom);

                //2: pour types standards
                command.Parameters.AddWithValue("?code", pi.Code);

                command.ExecuteNonQuery();

                pi.id = command.LastInsertedId;

            }  
        }

        public static List<Pays> Lister()
        {
            List<Pays> list = new List<Pays>(); 

            using (MySqlConnection connexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["MaConnexion"].ConnectionString))
            {
                connexion.Open();
                string req = "SELECT * FROM Pays;";
                MySqlCommand command = new MySqlCommand(req, connexion);

                using (MySqlDataReader resultat = command.ExecuteReader())  //car il faut fermer le jeu d'enregistrement avant de pouvoir fermer la connexion
                {
                    while (resultat.Read())
                    {
                        Pays pi = new Pays();
                        pi.id=resultat.GetInt64("id");
                        pi.Nom= resultat.GetString("nom");
                        pi.Code = resultat.GetString("code");
                        list.Add(pi);
                    }
                }
            }
            return list;
        }

        public Pays()
        {
        }

        public Pays(string nom, string code)
        {
            // TODO: Complete member initialization
            this.Nom = nom;
            this.Code = code;
        }
    }
}