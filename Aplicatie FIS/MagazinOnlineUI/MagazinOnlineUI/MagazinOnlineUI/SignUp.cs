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

namespace MagazinOnlineUI
{
    public partial class SignUp : Form
    {
        // Definim o structură pentru a stoca perechile de nume utilizator și parolă
        private Dictionary<string, string> new_obj = new Dictionary<string, string>();
        private Dictionary<string, string> new_seller = new Dictionary<string, string>();
        int ok = 0;

        public SignUp()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Resize += new EventHandler(SignUp_Resize);
            InitializeUsers("customers.csv", new_obj);
            InitializeUsers("consent_sellers.csv", new_seller);
        }

        private void InitializeUsers(string caleFisier, Dictionary<string,string> obj)
        {
            try
            {
                // Citim toate liniile din fișier
                string[] linii = File.ReadAllLines(caleFisier);

                // Parcurgem fiecare linie și adăugăm perechea de nume utilizator și parolă în dicționar
                foreach (string linie in linii)
                {
                    string[] date = linie.Split(',');
                    obj.Add(date[0], date[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea datelor din fișier: " + ex.Message);
            }
        }

        private void IncarcaUtilizatoriSiParole(string caleFisier, Dictionary<string,string> obj)
        {
            ok = 0;
            string email = EmailTextBox.Text;
            string parola = PasswordTextBox.Text;
            string confirmareParola = ConfirmationTextBox.Text;

            try
            {
                if (parola != confirmareParola)
                {
                    MessageBox.Show("Parolele nu coincid!");
                    ok = 1;
                    return;
                }

                if (obj.ContainsKey(email))
                {
                    MessageBox.Show("Acest email este deja folosit!");
                    ok = 1;
                }
                else
                {
                    obj.Add(email, parola);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcarea datelor în fișier: " + ex.Message);
            }
        }


        private void SignUpButton_Click_1(object sender, EventArgs e)
        {
            IncarcaUtilizatoriSiParole("customers.csv", new_obj);
            if(ok == 1)
                return;
            try
            {
                // Rescrie întreaga listă de utilizatori în fișier
                using (StreamWriter sw = new StreamWriter("customers.csv"))
                {
                    foreach (var utilizator in new_obj)
                    {
                        sw.WriteLine(utilizator.Key + "," + utilizator.Value);
                    }
                }
                
                //ne redirectineaza la pagina de login
                this.Hide();
                SignIn signIn = new SignIn();
                signIn.Closed += (s, args) => this.Close();
                signIn.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la scrierea datelor în fișier: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void SignUpPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignUp_Resize(object sender, EventArgs e)
        {
            int panelX = (this.ClientSize.Width - SignUpPanel.Width) / 2;
            int panelY = (this.ClientSize.Height - SignUpPanel.Height) / 2;

            SignUpPanel.Location = new Point(panelX, panelY);

            // Calculate Y-coordinate for the sign-in button
            int buttonY = panelY + SignUpPanel.Height + 20; // 20 is the vertical spacing between the panel and the button

            // Calculate X-coordinate for the sign-in button
            int buttonX = (this.ClientSize.Width - SignInButton.Width) / 2;

            // Set the location of the sign-in button
            SignInButton.Location = new Point(buttonX, buttonY);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.Closed += (s, args) => this.Close();
            signIn.Show();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void SellerButton_Click(object sender, EventArgs e)
        {
            IncarcaUtilizatoriSiParole("consent_sellers.csv", new_seller);
            if(ok == 1)
                return;
            try
            {
                // Rescrie întreaga listă de utilizatori în fișier
                using (StreamWriter sw = new StreamWriter("consent_sellers.csv"))
                {
                    foreach (var utilizator in new_seller)
                    {
                        sw.WriteLine(utilizator.Key + "," + utilizator.Value + ",0");
                    }
                }

                MessageBox.Show("Vă mulțumim pentru înregistrare! Contul va fi aprobat in scurt timp.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la scrierea datelor în fișier: " + ex.Message);
            }
        
        }

        private void AboutButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta pagina contine formularul de inregistrare pentru clienti si pentru vanzatori. Daca doriti sa va inregistrati ca vanzator, va rugam sa asteptati raspuns de la administrator.");
        }

        private void SupportButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("In cazul in care intampinati probleme sau aveti nelamuriri, va rugam sa ne contactati la adresa de email: admin@gmail.com. Va multumim!");
        }
    }
}
