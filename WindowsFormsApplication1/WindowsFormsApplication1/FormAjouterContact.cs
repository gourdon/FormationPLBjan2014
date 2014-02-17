using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplicationJanvier.ServiceReferenceContact;
using WindowsFormsApplicationJanvier.ServiceReferencePays;

namespace WindowsFormsApplicationJanvier
{
    public partial class FormAjouterContact : Form
    {
        public FormAjouterContact()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Contact co = new Contact();
            co.Nom = textBox1.Text;
            co.Prenom =textBox2.Text;
            co.DateNaissance = dateTimePicker1.Value;
            co.PaysId = ((Pays)comboBox1.SelectedItem).id;

            //Enregistre ds BD
            WebServiceContactSoapClient service = new WebServiceContactSoapClient();
            service.EnregistrerContact(co);

            //Vide le Form
            this.textBox1.Text = ""; //  "" plutot que null
            this.textBox2.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            this.comboBox1.SelectedIndex = 0;

            //Maj de datagridview1 dans Form1
            if (EventNouveauContact != null) //on teste toujours d'abord l'existance d'un evenement (cad qu'au moins une méthode lui est associé, cad qu'il est écouté) car si null=> bug
                EventNouveauContact(this, co);
            
        }

        private void FormAjouterContact_Load(object sender, EventArgs e)
        {

            using (WebServicePaysSoapClient service = new WebServicePaysSoapClient()) //meilleure perf avec using
            {
                List<Pays> list = service.ListerPays();
                this.comboBox1.DisplayMember = "Nom"; //pour éviter d'avoir toute l'info (longue) qui s'affiche dans la combo (et mieux que d'overrider le ToString)
                this.comboBox1.DataSource = list;
            }

        }

        //création d'un événement
        public event DelegueNouveauContact EventNouveauContact;
    }

    //creation d'un délégué
    public delegate void DelegueNouveauContact(object sender, Contact c);
}

//on peut aussi créer un evenement qui hérite eventArgs