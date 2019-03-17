using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SGALib;

namespace GuichetSATM
{
    public partial class Connection : Form
    {
        GestionnaireGuichet ATM = new SGALib.GestionnaireGuichet();
        public string NIP { get; set; }
        public string username;

        public Connection()
        {
           InitializeComponent();
        }

        string[] usernames = { "Korben Dallas" };
        string[] passwords = { "D001" };

        List<string> users = new List<string>();
        List<string> pass = new List<string>();

        private void button2_Click(object sender, EventArgs e)
        {
            if (users.Contains(name.Text) && pass.Contains(nip.Text) && Array.IndexOf(users.ToArray(), name.Text) == Array.IndexOf(pass.ToArray(), nip.Text))
            {
                this.Hide();
                //MessageBox.Show("BIENVENUE Mr "+ users);
                Guichet gh = new Guichet();
                gh.Visible = true;
                gh.Activate();
            }
            else
              if (usernames.Contains(name.Text) && passwords.Contains(nip.Text) && Array.IndexOf(users.ToArray(), name.Text) == Array.IndexOf(pass.ToArray(), nip.Text))
            {
                this.Hide();
                //MessageBox.Show("BIENVENUE Mr" + usernames);
                Superviseur administrateur = new Superviseur();
                administrateur.Visible = true;
                administrateur.Activate();
            }
            else
            {
                MessageBox.Show("Veuillez insérer le Nom et NIP valide");
            }
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Clients.txt");
            string line = "";
            while((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]);
                pass.Add(components[1]);
            }

        }
    }
}
