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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MagazinOnlineUI
{
    public partial class HomeAdmin : Form
    {
        private Dictionary<string, string> new_xseller = new Dictionary<string, string>();
        private Dictionary<string, string> new_seller = new Dictionary<string, string>();

        public HomeAdmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Resize += new EventHandler(Product_Resize);

            xSellerGridView.Columns.Add("Email", "Email");
            xSellerGridView.Columns.Add("Parola", "Parola");

            AllowedGridView.Columns.Add("Email", "Email");
            AllowedGridView.Columns.Add("Parola", "Parola");

            InitializeSellers("consent_sellers.csv", new_xseller);
            InitializeSellers("sellers.csv", new_seller);

        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            writeData("consent_sellers.csv", xSellerGridView);
            writeData("sellers.csv", AllowedGridView);
        }

        private void writeData(string caleFisier,DataGridView  d)
        {
            string[] linii = File.ReadAllLines(caleFisier);
            foreach (string linie in linii)
            {
                string[] coloane = linie.Split(',');
                d.Rows.Add(coloane[0], coloane[1]);
            }
        }

        private void Product_Resize(object sender, EventArgs e)
        {
            int panelX = (this.ClientSize.Width - RequestsPanel.Width) / 2;
            int panelY = (this.ClientSize.Height - RequestsPanel.Height) / 2;

            RequestsPanel.Location = new Point(panelX, panelY);
        }

        private void LogoButton_Click(object sender, EventArgs e)
        {
            Hide();
            SignIn signIn = new SignIn();
            signIn.Closed += (s, args) => this.Close();
            signIn.Show();
        }

        private void InitializeSellers(string caleFisier, Dictionary<string,string> obj)
        {
            try
            {
                string[] linii = File.ReadAllLines(caleFisier);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void AllowButton_Click(object sender, EventArgs e)
        {
            try
            {
                MoveRowBetweenGrids(xSellerGridView, AllowedGridView);

                // Rescrie întreaga listă de utilizatori în fișier
                using (StreamWriter sw = new StreamWriter("sellers.csv"))
                {
                    foreach (var utilizator in new_seller)
                    {
                        sw.WriteLine(utilizator.Key + "," + utilizator.Value + ",1");
                    }
                }

                using (StreamWriter sw = new StreamWriter("consent_sellers.csv"))
                {
                    foreach (var utilizator in new_xseller)
                    {
                        sw.WriteLine(utilizator.Key + "," + utilizator.Value + ",0");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la scrierea datelor în fișier: " + ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DenyButton_Click(object sender, EventArgs e)
        {
            try
            {
                MoveRowBetweenGrids(AllowedGridView, xSellerGridView);

                // Rescrie întreaga listă de utilizatori în fișier
                using (StreamWriter sw = new StreamWriter("consent_sellers.csv"))
                {
                    foreach (var utilizator in new_xseller)
                    {
                        sw.WriteLine(utilizator.Key + "," + utilizator.Value + ",0"); 
                    }
                }

                using (StreamWriter sw = new StreamWriter("sellers.csv"))
                {
                    foreach (var utilizator in new_seller)
                    {
                        sw.WriteLine(utilizator.Key + "," + utilizator.Value + ",1");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la scrierea datelor în fișier: " + ex.Message);
            }
        }

        private void MoveRowBetweenGrids(DataGridView sourceGrid, DataGridView destinationGrid)
        {
            // Verificați dacă a fost selectat un rând în DataGridView-ul sursă
            if (sourceGrid.SelectedRows.Count > 0)
            {
                // Obțineți rândul selectat
                DataGridViewRow selectedRow = sourceGrid.SelectedRows[0];

                // Adăugați un nou rând în DataGridView-ul destinație și copiați datele din rândul selectat
                destinationGrid.Rows.Add(selectedRow.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray());

                string email = selectedRow.Cells["Email"].Value.ToString();
                string parola = selectedRow.Cells["Parola"].Value.ToString();

                // Actualizăm dicționarul corespunzător, în funcție de grila destinație
                if (destinationGrid == xSellerGridView)
                {
                    // Adăugați datele în dicționarul corespunzător (new_xseller)
                    new_xseller.Add(email, parola);
                    new_seller.Remove(email);
                }
                else
                {
                    // Adăugați datele în dicționarul corespunzător (new_seller)
                    new_seller.Add(email, parola);
                    new_xseller.Remove(email);
                }

                // Ștergeți rândul selectat din DataGridView-ul sursă
                sourceGrid.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Selectați un rând înainte de a muta.");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            {
                string searchTerm = SearchBox.Text.ToLower();
                foreach (DataGridViewRow row in xSellerGridView.Rows)
                {
                    if (row.Cells["Email"].Value.ToString().ToLower().Contains(searchTerm))
                    {
                        row.Selected = true;
                        xSellerGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        break; // Ieși din buclă după ce ai găsit prima potrivire
                    }
                }
            };
        }

        private void AboutButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Această pagină este destinată administratorului. Aici puteți aproba sau respinge cererile de înregistrare ale vânzătorilor.");
        }

        private void SupportButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("In cazul in care intampinati probleme sau aveti nelamuriri, va rugam sa ne contactati la adresa de email: admin@gmail.com. Va multumim!");
        }
    }
}