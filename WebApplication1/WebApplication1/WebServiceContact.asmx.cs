using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApplication1.Metier;

namespace WebApplication1
{
    /// <summary>
    /// Description résumée de WebServiceContact
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceContact : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Contact> ListerContact()
        {
            return Contact.Lister();
        }

        [WebMethod]
        public long EnregistrerContact(Contact co)
        {
            Contact.Enregitrer(co);
            return co.id; ;
        }

        [WebMethod]
        public long TestEnregistrerContact(string nom, string prenom, string date_naissance, long pays_id)
        {
            Contact co = new Contact(nom, prenom, date_naissance, pays_id);
            Contact.Enregitrer(co);
            return co.id; ;
        }
    }
}
