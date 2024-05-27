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
    public partial class HomeSeller : Form
    {
        string loggedInSellerEmail = SignIn.LoggedInSellerEmail;

        public HomeSeller()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Resize += new EventHandler(Product_Resize);

            //BookID,Cover,Title,Author,Genre,Seller,Price,Flag,Description
            ProductsGridView.Columns.Add("BookID", "BookID");
            ProductsGridView.Columns.Add("Title", "Title");
            ProductsGridView.Columns.Add("Author", "Author");
            ProductsGridView.Columns.Add("Genre", "Genre");
            ProductsGridView.Columns.Add("Price", "Price");
            ProductsGridView.Columns.Add("Flag", "PriceFlag");

            //BookId,Title,Seller,Offer,Status
            OffersGridView.Columns.Add("BookId", "BookId");
            OffersGridView.Columns.Add("Title", "Title");
            OffersGridView.Columns.Add("Buyer", "Buyer");
            OffersGridView.Columns.Add("Offer", "Offer");
            OffersGridView.Columns.Add("Status", "Status");

            //BookId,Price,Buyer,Status
            FixedPriceGrid.Columns.Add("BookId", "BookId");
            FixedPriceGrid.Columns.Add("Price", "Price");
            FixedPriceGrid.Columns.Add("Buyer", "Buyer");
            FixedPriceGrid.Columns.Add("Status", "Status");
        }

        private void HomeSeller_Load(object sender, EventArgs e)
        {
            writeProducts("products.csv", ProductsGridView);
            writeOffers("offers.csv", OffersGridView);
            writeFixedPriceOffers("almostBought.csv", FixedPriceGrid);
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddProduct addProduct = new AddProduct();
            addProduct.FormClosed += (s, args) => this.Close();
            addProduct.Show();
        }

        private void Product_Resize(object sender, EventArgs e)
        {
            int panelX = (this.ClientSize.Width - OffersPanel.Width) / 2;
            int panelY = (this.ClientSize.Height - OffersPanel.Height) / 2;

            OffersPanel.Location = new Point(panelX, panelY);
        }

        //scrie in grid datele citite din fisier
        private void writeProducts(string caleFisier, DataGridView d)
        {
            string[] linii = File.ReadAllLines(caleFisier);
            foreach (string linie in linii)
            {
                // Excludem linii goale
                if (string.IsNullOrWhiteSpace(linie))
                    continue;
                string[] coloane = linie.Split(',');
                // Verificăm dacă produsul este disponibil sau nu
                if (!(coloane[0] == "-"))
                { 
                    if (coloane[5] == loggedInSellerEmail) // Verificăm dacă vânzătorul din fișier este același cu cel care este logat
                    {
                        d.Rows.Add(coloane[0], coloane[2], coloane[3], coloane[4], coloane[6], coloane[7]);
                    }
                }
            }
        }

        private void writeOffers(string caleFisier, DataGridView d)
        {
            string[] linii = File.ReadAllLines(caleFisier);
            foreach (string linie in linii)
            {
                string[] date = linie.Split(',');
                if (date[5] == loggedInSellerEmail)
                {
                    d.Rows.Add(date[0],date[1], date[2], date[3], date[4]); 
                }
            }
        }

        private void writeFixedPriceOffers(string caleFisier, DataGridView d)
        {
            string[] linii = File.ReadAllLines(caleFisier);
            foreach (string linie in linii)
            {
                string[] date = linie.Split(',');
                if (date[4] == loggedInSellerEmail)
                {
                     d.Rows.Add(date[0], date[1], date[2], date[3]);
                }
            }
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            Hide();
            SalesHistory salesHistory = new SalesHistory();
            salesHistory.FormClosed += (s, args) => this.Close();
            salesHistory.Show();
        }

        private void OffersPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogoButton_Click(object sender, EventArgs e)
        {
            Hide();
            SignIn signIn = new SignIn();
            signIn.Closed += (s, args) => this.Close();
            signIn.Show();
        }

        //buton de search dupa titlu
        private void SearchButton_Click(object sender, EventArgs e)
        {
            {
                string searchTerm = textBox1.Text.ToLower();
                foreach (DataGridViewRow row in ProductsGridView.Rows)
                {
                    if (row.Cells["Title"].Value.ToString().ToLower().Contains(searchTerm))
                    {
                        row.Selected = true;
                        ProductsGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        break; // Ieși din buclă după ce ai găsit prima potrivire
                    }
                }
            };
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Hide();
            HomeSeller homeSeller = new HomeSeller();
            homeSeller.Closed += (s, args) => this.Close();
            homeSeller.Show();
        }

        private void DenyButton_Click(object sender, EventArgs e)
        {
            if (OffersGridView.SelectedRows.Count > 0)
            {
                //modify the status of the offer to "Denied"
                string bookId = OffersGridView.SelectedRows[0].Cells[0].Value.ToString();
                string titlu = OffersGridView.SelectedRows[0].Cells[1].Value.ToString();
                string customer = OffersGridView.SelectedRows[0].Cells[2].Value.ToString();
                string offeredPrice = OffersGridView.SelectedRows[0].Cells[3].Value.ToString();
                string status = "Refuzat";

                //apoi refacem fisierul offers.csv cu statusul modificat
                string[] linii = File.ReadAllLines("offers.csv");
                using (StreamWriter sw = new StreamWriter("offers.csv"))
                {
                    foreach (string linie in linii)
                    {
                        string[] coloane = linie.Split(',');
                        if (coloane[0] == bookId && coloane[2] == customer && coloane[3] == offeredPrice)
                        {
                            sw.WriteLine(bookId + "," + titlu + "," + customer + "," + offeredPrice + "," + status + "," + loggedInSellerEmail);
                        }
                        else
                        {
                            sw.WriteLine(linie);
                        }
                    }
                }
            }
        }

        private void AllowButton_Click(object sender, EventArgs e)
        {
            // Verificăm dacă există rânduri selectate în DataGridView
            if (OffersGridView.SelectedRows.Count > 0)
            {
                // Obținem primul rând selectat
                var selectedRow = OffersGridView.SelectedRows[0];

                // Verificăm dacă rândul selectat nu este null
                if (selectedRow != null)
                {
                    // Obținem valorile din celulele rândului selectat
                    string bookId = selectedRow.Cells[0].Value?.ToString();
                    string titlu = selectedRow.Cells[1].Value?.ToString();
                    string customer = selectedRow.Cells[2].Value?.ToString();
                    string offeredPrice = selectedRow.Cells[3].Value?.ToString();
                    string status = "Acceptat";

                    // Ștergem produsul la care s-a făcut oferta din lista de produse
                    string[] liniiProduse = File.ReadAllLines("products.csv");
                    using (StreamWriter sw = new StreamWriter("products.csv"))
                    {
                        foreach (string linie in liniiProduse)
                        {
                            string[] coloane = linie.Split(',');
                            if (coloane[0] != bookId)
                            {
                                sw.WriteLine(linie);
                            }
                            else
                            {
                                sw.WriteLine("-" + "," + coloane[1] + "," + coloane[2] + "," + coloane[3] + "," + coloane[4] + "," + coloane[5] + "," + coloane[6] + "," + coloane[7] + "," + coloane[8] + "," + coloane[9]);
                            }
                        }
                    }

                    // Refacem fișierul offers.csv cu statusul modificat
                    string[] linii = File.ReadAllLines("offers.csv");
                    using (StreamWriter sw = new StreamWriter("offers.csv"))
                    {
                        foreach (string linie in linii)
                        {
                            string[] coloane = linie.Split(',');
                            if (coloane[0] == bookId && coloane[2] == customer && coloane[3] == offeredPrice)
                            {
                                sw.WriteLine(bookId + "," + titlu + "," + customer + "," + offeredPrice + "," + status + "," + loggedInSellerEmail); // acceptăm oferta
                            }
                            else if (coloane[0] == bookId && coloane[2] != customer && coloane[3]!= offeredPrice) // Refuzăm ofertele care nu sunt ale clientului respectiv
                            {
                                sw.WriteLine(bookId + "," + titlu + "," + coloane[2] + "," + coloane[3] + "," + "Refuzat" + "," + loggedInSellerEmail);
                            }
                            else
                            {
                                sw.WriteLine(linie);
                            }
                        }
                    }

                    // Refacem fișierul history.csv cu noul produs vândut
                    using (StreamWriter sw = File.AppendText("history.csv"))
                    {
                        sw.WriteLine(bookId + "," + offeredPrice + "," + customer + "," + loggedInSellerEmail);
                    }
                }
                else
                {
                    // Mesaj de eroare sau acțiuni suplimentare în cazul în care rândul selectat este null
                }
            }
            else
            {
                // Mesaj de eroare sau acțiuni suplimentare în cazul în care nu există rânduri selectate
            }
        }

        private void AboutButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta este pagina de vânzător. Aici puteți adăuga produse noi, vizualiza produsele dumneavoastră, vizualiza ofertele primite și accepta sau refuza aceste oferte.");
        }

        private void SupportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In cazul in care intampinati probleme sau aveti nelamuriri, va rugam sa ne contactati la adresa de email: admin@gmail.com. Va multumim!");
        }

        private void SearchLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AllowFixed_Click(object sender, EventArgs e)
        {
            //modify the status of the offer to "Accepted"
            string bookId = FixedPriceGrid.SelectedRows[0].Cells[0].Value.ToString();
            string price = FixedPriceGrid.SelectedRows[0].Cells[1].Value.ToString();
            string customer = FixedPriceGrid.SelectedRows[0].Cells[2].Value.ToString();
            string status = "Cumparat";

            //sterg produsul la care s-a facut oferta din lista de produse
            string[] liniiProduse = File.ReadAllLines("products.csv");
            using (StreamWriter sw = new StreamWriter("products.csv"))
            {
                foreach (string linie in liniiProduse)
                {
                    string[] coloane = linie.Split(',');
                    if (coloane[0] != bookId)
                    {
                        sw.WriteLine(linie);
                    }
                    else
                    {
                        sw.WriteLine("-" + "," + coloane[1] + "," + coloane[2] + "," + coloane[3] + "," + coloane[4] + "," + coloane[5] + "," + coloane[6] + "," + coloane[7] + "," + coloane[8] + "," + coloane[9]);
                    }
                }
            }

            //apoi refacem fisierul almostBought.csv cu statusul modificat
            string[] linii = File.ReadAllLines("almostBought.csv");
            using (StreamWriter sw = new StreamWriter("almostBought.csv"))
            {
                foreach (string linie in linii)
                {
                    string[] coloane = linie.Split(',');
                    if (coloane[0] == bookId && coloane[2] == customer && coloane[1] == price)
                    {
                        sw.WriteLine(bookId + "," + price + "," + customer + "," + status + "," + loggedInSellerEmail);
                    }
                    else if (coloane[0] == bookId && coloane[2] != customer && coloane[1] != price) //refuzam ofertele care nu sunt ale clientului respectiv
                    {
                        sw.WriteLine(bookId + "," + price + "," + coloane[2] + "," + "Anulat" + "," + loggedInSellerEmail);
                    }
                    else
                    {
                        sw.WriteLine(linie);
                    }
                }
            }

            //refacem si fisierul history.csv cu noul produs vandut
            using (StreamWriter sw = File.AppendText("history.csv"))
            {
                sw.WriteLine(bookId + "," + price + "," + customer + "," + loggedInSellerEmail);
            }
        }

        private void DenyFixed_Click(object sender, EventArgs e)
        {
            // Verificăm dacă există rânduri selectate în DataGridView
            if (OffersGridView.SelectedRows.Count > 0)
            {
                //modify the status of the offer to "Denied"
                string bookId = FixedPriceGrid.SelectedRows[0].Cells[0].Value.ToString();
                string price = FixedPriceGrid.SelectedRows[0].Cells[1].Value.ToString();
                string customer = FixedPriceGrid.SelectedRows[0].Cells[2].Value.ToString();
                string status = "Anulat";

                //apoi refacem fisierul almostBought.csv cu statusul modificat
                string[] linii = File.ReadAllLines("almostBought.csv");
                using (StreamWriter sw = new StreamWriter("almostBought.csv"))
                {
                    foreach (string linie in linii)
                    {
                        string[] coloane = linie.Split(',');
                        if (coloane[0] == bookId && coloane[2] == customer && coloane[1] == price)
                        {
                            sw.WriteLine(bookId + "," + price + "," + customer + "," + status + "," + loggedInSellerEmail);
                        }
                        else
                        {
                            sw.WriteLine(linie);
                        }
                    }
                }
            }
        }
    }
}