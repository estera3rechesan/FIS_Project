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
    public partial class SignIn : Form
    {
        public static string LoggedInSellerEmail { get; private set; }
        public static string LoggedInCustomerEmail { get; private set; }

        public SignIn()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Resize += new EventHandler(SignIn_Resize);

        }

        // Metoda pentru a obține adresa de email a utilizatorului autentificat
        public static void SetLoggedInSellerEmail(string email)
        {
            LoggedInSellerEmail = email;
        }
        public static void SetLoggedInCustomerEmail(string email)
        {
            LoggedInCustomerEmail = email;
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void SignIn_Resize(object sender, EventArgs e)
        {
            int panelX = (this.ClientSize.Width - SignInPanel.Width) / 2;
            int panelY = (this.ClientSize.Height - SignInPanel.Height) / 2;

            SignInPanel.Location = new Point(panelX, panelY);

            // Calculate Y-coordinate for the sign-in button
            int buttonY = panelY + SignInPanel.Height + 20; // 20 is the vertical spacing between the panel and the button

            // Calculate X-coordinate for the sign-in button
            int buttonX = (this.ClientSize.Width - SignUpButton.Width) / 2;

            // Set the location of the sign-in button
            SignUpButton.Location = new Point(buttonX, buttonY);
        }

        private void Validare_vanzatori(string caleFisier)
        {
            string email = textBox4.Text;
            string password = textBox2.Text;
            int ok = 0;
            try
            {
                string[] linii = File.ReadAllLines(caleFisier);

                foreach (string linie in linii)
                {
                    string[] elemente = linie.Split(',');
                    string numeUtilizator = elemente[0];
                    string parola = elemente[1];

                    if (email == numeUtilizator && password == parola)
                    {
                        ok = 1;
                        string status = elemente[2];
                        
                        this.Hide();
                        SetLoggedInSellerEmail(email);

                        HomeSeller homeSeller = new HomeSeller();
                        homeSeller.Closed += (s, args) => this.Close();
                        homeSeller.Show();
                        break;
                    }

                }
                if (ok == 0)
                {
                    MessageBox.Show("Numele de utilizator sau parola sunt incorecte.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcarea datelor din fișier: " + ex.Message);
            }
        }

        private void Validare_cumparator(string caleFisier)
        {
            string email = textBox4.Text;
            string password = textBox2.Text;
            int ok = 0;
            try
            {
                string[] linii = File.ReadAllLines(caleFisier);

                foreach (string linie in linii)
                {
                    string[] elemente = linie.Split(',');
                    string numeUtilizator = elemente[0];
                    string parola = elemente[1];

                    if (email == numeUtilizator && password == parola)
                    {
                        ok = 1;

                        this.Hide();
                        SetLoggedInCustomerEmail(email);

                        HomeCustomer homeCustomer = new HomeCustomer();
                        homeCustomer.Closed += (s, args) => this.Close();
                        homeCustomer.Show();
                        break;

                    }

                }
                if (ok == 0)
                {
                    MessageBox.Show($"Numele de utilizator sau parola sunt incorecte.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcarea datelor din fișier: " + ex.Message);
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.FormClosed += (s, args) => this.Close();
            signUp.Show();
        }

        private void SignCustumerButton_Click(object sender, EventArgs e)
        {
            Validare_cumparator("customers.csv");
        }

        private void SignSellerButton_Click(object sender, EventArgs e)
        {
            Validare_vanzatori("sellers.csv");
        }

        private void SignAdminButton_Click(object sender, EventArgs e)
        {

            string email = textBox4.Text;
            string password = textBox2.Text;
            if (email == "admin@gmail.com" && password == "admin")
            {
                this.Hide();
                HomeAdmin homeAdmin1 = new HomeAdmin();
                homeAdmin1.Closed += (s, args) => this.Close();
                homeAdmin1.Show();
            }
            else
            {
                MessageBox.Show("Numele de utilizator sau parola sunt incorecte.");
            }

        }

        private void AboutButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta pagina contine campurile de autentificare pentru fiecare tip de utilizator.");
        }

        private void SupportButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("In cazul in care intampinati probleme sau aveti nelamuriri, va rugam sa ne contactati la adresa de email: admin@gmail.com. Va multumim!");
        }
    }
}