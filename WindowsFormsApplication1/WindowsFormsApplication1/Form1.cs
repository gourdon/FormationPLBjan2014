using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplicationJanvier.ServiceReferencePays;
using WindowsFormsApplicationJanvier.ServiceReferenceContact;

namespace WindowsFormsApplicationJanvier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bonjour " + this.textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merci d'avoir cliqué");
            this.button2.Click -= new System.EventHandler(this.button2_Click);
            this.button2.Click += new System.EventHandler(this.button2_Click2emeFois);
        }

        private void button2_Click2emeFois(object sender, EventArgs e)
        {
            MessageBox.Show("STOP ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Button ancien = (Button)sender;    cast for => bug si sender n'est pas un bouton
            //Button ancien = sender as Button; cast faible => ancien renvoie null si...

            string previous_text = ((Button)sender).Text; //et pas (Button)sender.Text
            Color previous_color = ((Button)sender).BackColor;
            Button new_button = new Button();
            new_button.Text = previous_text;
            new_button.BackColor = previous_color;
            new_button.Tag = "suppr";
            
            Random r = new Random();
            new_button.Location = new Point(r.Next(0, 300),r.Next(0, 300));

            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            ((Button)sender).Click -= button3_Click;
            new_button.Click += new System.EventHandler(button3_Click);

            this.Controls.Add(new_button);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Button> list = new List<Button>();
            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Tag != null && c.Tag.ToString() == "suppr") //3 tests faits dans l'ordre d'écriture: s'arrête dés qu'un n'est pas vérifié
                {
                    //this.Controls.Remove(c);    //sans list; ne marche pas car suppression dans une liste qu'on parcourt
                    list.Add((Button)c);
                }
            }
            foreach (Button b in list)
                this.Controls.Remove(b);

            this.button3.Click += this.button3_Click;
            this.button3.BackColor = Color.BlueViolet;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (WebServicePaysSoapClient service = new WebServicePaysSoapClient()) //meilleure perf avec using
            {
                List<Pays> list = service.ListerPays();
                this.comboBox1.DisplayMember = "Nom"; //pour éviter d'avoir toute l'info (longue) qui s'affiche dans la combo (et mieux que d'overrider le ToString)
                this.comboBox1.DataSource = list;
            }

            WebServiceContactSoapClient service2 = new WebServiceContactSoapClient();
            List<Contact> list2 = service2.ListerContact();
            //this.dataGridView1.  
            this.dataGridView1.DataSource = list2;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormAjouterContact fac = new FormAjouterContact();
            fac.EventNouveauContact += fac_EventNouveauContact;
            fac.ShowDialog();
        }

        void fac_EventNouveauContact(object sender, Contact c)
        {
            //datasource pas raffraichi => il faut raffraichir l'objet reference
            List<Contact> list = new List<Contact>( //il faut faire new car sinon, pas de chgt de reference => pas de rafraichissement
                (List<Contact>)this.dataGridView1.DataSource);
            list.Add(c);
            this.dataGridView1.DataSource=list;
        }

    }
}
