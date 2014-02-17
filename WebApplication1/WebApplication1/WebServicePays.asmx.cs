using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApplication1.Metier;

namespace WebApplication1
{
    /// <summary>
    /// Description résumée de WebServicePays
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServicePays : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Pays> ListerPays()
        {
            return Pays.Lister();
        }

        [WebMethod]
        public long EnregistrerPays(Pays pi)
        {
            Pays.Enregitrer(pi);
            return pi.id; ;
        }

        [WebMethod]
        public long TestEnregistrerPays(string nom, string code)
        {
            Pays pi = new Pays(nom, code);
            Pays.Enregitrer(pi);
            return pi.id; ;
        }

    }
}
