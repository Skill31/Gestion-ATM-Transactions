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
using System.IO;
using System.Data.SqlClient;

namespace GuichetSATM
{
    public partial class Guichet : Form
    {
        public GestionnaireGuichet gest = new GestionnaireGuichet();
        public string code;
        private string NIP;
        double balance;

       
        public Guichet()
        {
            InitializeComponent();
        }     

        public Guichet(string nIP)
        {
            this.NIP = nIP;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AmountBox.Text = AmountBox.Text + "1";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AmountBox.Text = AmountBox.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AmountBox.Text = AmountBox.Text + "3";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AmountBox.Text = ""; 
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AmountBox.Text = AmountBox.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AmountBox.Text = AmountBox.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AmountBox.Text = AmountBox.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AmountBox.Text = AmountBox.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AmountBox.Text = AmountBox.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AmountBox.Text = AmountBox.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AmountBox.Text = AmountBox.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AmountBox.Text = AmountBox.Text + ",";
        }

        private void AmountBox_TextChanged(object sender, EventArgs e)
        {
            var box = (TextBox)sender;
            if (box.Text.StartsWith(".")) box.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            CHQRadioBox.Checked = true;
            EPGRadioBox.Enabled = true;
            CHQRadioBox.Text = "CHEQUE";
            EPGRadioBox.Text = "EPARGNE";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            CHQRadioBox.Checked = true;
            EPGRadioBox.Enabled = true;
            CHQRadioBox.Text = "CHEQUE";
            EPGRadioBox.Text = "EPARGNE";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            CHQRadioBox.Checked = true;
            EPGRadioBox.Enabled = true;
            CHQRadioBox.Text = "De Cheque À Epargne";
            EPGRadioBox.Text = "De Epargne À Cheque";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            CHQRadioBox.Checked = true;
            EPGRadioBox.Enabled = false;
            CHQRadioBox.Text = "CHEQUE";
            EPGRadioBox.Text = "EPARGNE";
        }

        private void Guichet_Load(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
          
            double montant = Convert.ToDouble(AmountBox.Text);
            double solde;

            try
            {

                if (DepotRadioBox.Checked == true)
                {
                    if (montant == 0)
                    {
                        MessageBox.Show("Le montant doit être plus que 0");
                        return;
                    }
                    if (CHQRadioBox.Checked == true)
                    {
                        balance += montant;
                        AmountBox.Clear();
                        MessageBox.Show("Nouveau solde est :  $" + balance);
                    }
                    else
                    {
                        AmountBox.Clear();
                        MessageBox.Show("Solde courant est :  $" + balance);
                    }
                }
                else if (RetaritRadioBox.Checked == true)
                {
                    if (montant == 0)
                    {
                        AmountBox.Clear();
                        MessageBox.Show("Le montant doit être plus que 0");
                        return;
                    }
                    if (montant > 1000)
                    {
                        AmountBox.Clear();
                        MessageBox.Show("Vous ne pouvez pas retier plus de $1,000");
                        return;
                    }
                    if (montant % 10 != 0)
                    {
                        AmountBox.Clear();
                        MessageBox.Show("Vous n'avez le droit qu'aux montants par $10");
                        return;
                    }
                    if (CHQRadioBox.Checked == true)
                    {
                        if (montant > balance)
                        {

                            AmountBox.Clear();
                            MessageBox.Show("Pas assez de fonds \n\n ");
                        }
                        else
                        {
                            balance -= montant;
                            AmountBox.Clear();
                            MessageBox.Show("Nouveau solde de:  $" + balance);
                        }
                    }
                    else
                    {
                        if (gest.RetraitEpargne(code, montant) == false)
                        {
                            balance -= montant;
                            AmountBox.Clear();
                            MessageBox.Show("Pas assez de fonds \n\n Le solde est de:  $" + balance);
                        }
                        else
                        {
                            balance -= montant;
                            AmountBox.Clear();
                            MessageBox.Show("Nouveau solde de:  $" + balance);
                        }
                    }
                }
                else if (TransfertRadioBox.Checked == true)
                {
                    if (montant == 0)
                    {
                        MessageBox.Show("Le montant doit être plus de 0");
                        return;
                    }
                    if (CHQRadioBox.Checked == true)
                    {
                        if (montant > 100000)
                        {
                            AmountBox.Clear();
                            MessageBox.Show("Transfert interdit à plus de $100,000");
                        }
                        else
                        {
                            if (balance < montant)
                            {
                                MessageBox.Show("Pas assez de fonds \n\n Le solde est de:  $:  $" + balance);
                            }
                            else
                            {
                                balance -= montant;
                                AmountBox.Clear();
                                MessageBox.Show("Compte Epargne est de:  " + montant + "\n" + "Le Nouveau solde est :  $" + balance);
                               
                            }
                        }
                    }
                    else
                    {
                        if (montant > 100000)
                        {
                            MessageBox.Show("Transfert interdit de plus de $100,000");
                        }
                        else
                        {
                            if (balance < montant)
                            {
                                MessageBox.Show("Pas assez de fonds \n\n Le solde est de :  $" + balance);
                            }
                            else
                            {
                                balance += montant;
                                solde = balance + montant;
                                AmountBox.Clear();
                                MessageBox.Show("Compte Eepargne est de:  " + montant + "\n" + "Nouveau solde est de :  $" + solde);
                            }
                        }
                    }
                }
                else if (PayFactureRadioBox.Checked == true)
                {
                    if (montant == 0)
                    {
                        MessageBox.Show("Le montant doit être plus de 0");
                        return;
                    }
                    if (montant > 10000)
                    {
                        MessageBox.Show("Impossible de payer plus de $10,000");
                    }
                    else
                    {
                        if (balance < montant)
                        {
                            MessageBox.Show("Pas assez de fonds \n\n Balance de:  $" + balance);
                        }
                        else
                        {
                            balance -= montant + 1.25;
                            AmountBox.Clear();
                            MessageBox.Show("Paiement facture de: " + montant + "\n" + "Le Nouveau solde est : $" + balance);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Veuillez séléctionner un montant pour débuter la transaction");
            }

        }
    }
}
