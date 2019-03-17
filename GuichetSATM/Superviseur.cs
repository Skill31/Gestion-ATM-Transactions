using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGALib;


namespace GuichetSATM
{
    public partial class Superviseur : Form
    {
        private string iNIP;

        public GestionnaireGuichet gest = new GestionnaireGuichet();
        public string code;
        private double balance;
        private double montant;

        public string NIP { get; private set; }

        public Superviseur()
        {
            InitializeComponent();
        }

        public Superviseur(string iNIP)
        {
            this.iNIP = iNIP;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button1, 0, button1.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(button2, 0, button2.Height);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            contextMenuStrip3.Show(button3, 0, button3.Height);
        }

        private void Superviseur_Load(object sender, EventArgs e)
        {

        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quitterATMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comptesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Les comptes sont désormais sauvegardés");
            gest.WriteCurators();
        }

        private void dépotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (balance > 0)
            {
               
                MessageBox.Show("Un montant de $10,000 a été ajouté au solde");
            }
            else
            {
                MessageBox.Show("Un montant de $10,000 a été ajouté au solde");
            }
        }

        private void paiementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            montant = 5000;
            balance = 10000;

            if (balance > montant)
            {
                balance -= montant;
                MessageBox.Show("La facture a été payée, Le solde est :" + balance);
            }
            else
            {
                MessageBox.Show("La facture a ne peut etre payé" );
            }
        }
    }
}
