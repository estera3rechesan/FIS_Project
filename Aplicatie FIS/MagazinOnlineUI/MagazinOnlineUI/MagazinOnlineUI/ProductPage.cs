using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazinOnlineUI
{
    public partial class ProductPage : Form
    {
        string loggedInCustomerEmail = SignIn.LoggedInCustomerEmail;
        string nume;
        private Dictionary<string, string> minPrices = new Dictionary<string, string>();

        public ProductPage(string nume)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Resize += new EventHandler(Product_Resize);
            ProductDescription.ReadOnly = true;
            ProductDescription.HideSelection = true;
            ProductId.Hide();
            this.nume = nume;

            afisarePePagina("products.csv");
        }

        private void Product_Resize(object sender, EventArgs e)
        {
            int panelX = (this.ClientSize.Width - ProductPanel.Width) / 2;
            int panelY = (this.ClientSize.Height - ProductPanel.Height) / 2;

            ProductPanel.Location = new Point(panelX, panelY);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeCustomer homeCustumer = new HomeCustomer();
            homeCustumer.Closed += (s, args) => this.Close();
            homeCustumer.Show();
        }

        //public void afisarePePagina(string caleFisier)
        //{
        //    HideOfferFields();
        //    string[] linii = File.ReadAllLines(caleFisier);
        //    foreach (string linie in linii)
        //    {
        //        string[] coloane = linie.Split(',');
        //        if (coloane[2] == nume)
        //        {
        //            using (WebClient wc = new WebClient())
        //            {
        //                byte[] bytes = wc.DownloadData(coloane[1]);
        //                using (MemoryStream ms = new MemoryStream(bytes))
        //                {
        //                    ProductCover.Image = Image.FromStream(ms);
        //                }
        //            }

        //            ProductId.Text = coloane[0];
        //            ProductTitle.Text = coloane[2];
        //            ProductAuthor.Text = coloane[3];
        //            ProductGenre.Text = coloane[4];
        //            ProductSeller.Text = coloane[5];
        //            ProductPrice.Text = coloane[6];
        //            ProductDescription.Text = coloane[8];

        //            if (coloane[7] == "NegociablePrice")
        //            {
        //                ShowOfferFields();
        //                if (!minPrices.ContainsKey(coloane[0]))
        //                {
        //                    minPrices[coloane[0]] = coloane[9];
        //                }
        //            }
        //        }
        //    }
        //}

        private void afisarePePagina(string caleFisier)
        {
            HideOfferFields();
            var produse = CitesteProduseDinFisier(caleFisier);
            foreach (var produs in produse)
            {
                if (produs["Title"] == nume)
                {
                    IncarcaImagine(produs["ImageUrl"]);
                    SeteazaValoriProdus(produs);
                    if (produs["PriceType"] == "NegociablePrice")
                    {
                        ShowOfferFields();
                        if (!minPrices.ContainsKey(produs["Id"]))
                        {
                            minPrices[produs["Id"]] = produs["MinPrice"];
                        }
                    }
                }
            }
        }

        public List<Dictionary<string, string>> CitesteProduseDinFisier(string caleFisier)
        {
            var produse = new List<Dictionary<string, string>>();
            string[] linii = File.ReadAllLines(caleFisier);
            foreach (string linie in linii)
            {
                string[] coloane = linie.Split(',');
                if (coloane.Length >= 10) // Verificăm dacă linia are cel puțin 10 coloane
                {
                    var produs = new Dictionary<string, string>
                    {
                        { "Id", coloane[0].Trim() },
                        { "ImageUrl", coloane[1].Trim() },
                        { "Title", coloane[2].Trim() },
                        { "Author", coloane[3].Trim() },
                        { "Genre", coloane[4].Trim() },
                        { "Seller", coloane[5].Trim() },
                        { "Price", coloane[6].Trim() },
                        { "PriceType", coloane[7].Trim() },
                        { "Description", coloane[8].Trim() },
                        { "MinPrice", coloane[9].Trim() }
                    };
                    produse.Add(produs);
                }
            }
            return produse;
        }

        private void IncarcaImagine(string imageUrl)
        {
            using (WebClient wc = new WebClient())
            {
                byte[] bytes = wc.DownloadData(imageUrl);
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    ProductCover.Image = Image.FromStream(ms);
                }
            }
        }

        private void SeteazaValoriProdus(Dictionary<string, string> produs)
        {
            ProductId.Text = produs["Id"];
            ProductTitle.Text = produs["Title"];
            ProductAuthor.Text = produs["Author"];
            ProductGenre.Text = produs["Genre"];
            ProductSeller.Text = produs["Seller"];
            ProductPrice.Text = produs["Price"];
            ProductDescription.Text = produs["Description"];
        }

        private void DisableOfferButton()
        {
            OfferButton.Enabled = false;
        }

        private void DisableBuyButton()
        {
            BuyButton.Enabled = false;
        }

        private void HideOfferFields()
        {
            OfferLabel.Hide();
            OfferPriceBox.Hide();
            OfferButton.Hide();
        }

        private void ShowOfferFields()
        {
            OfferLabel.Show();
            OfferPriceBox.Show();
            OfferButton.Show();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText("almostBought.csv"))
            {
                sw.WriteLine(ProductId.Text + "," + ProductPrice.Text + "," + loggedInCustomerEmail + "," + "Cumparat" + "," + ProductSeller.Text);
            }

            DisableBuyButton();
        }

        private void OfferButton_Click(object sender, EventArgs e)
        {
            string productId = ProductId.Text;

            if (minPrices.ContainsKey(productId))
            {
                string minPrice = minPrices[productId];
                if (Convert.ToInt32(OfferPriceBox.Text) < Convert.ToInt32(minPrice))
                {
                    MessageBox.Show("Pretul oferit trebuie sa fie mai mare decat " + minPrice);
                    return;
                }
            }

            using (StreamWriter sw = File.AppendText("offers.csv"))
            {
                sw.WriteLine(ProductId.Text + "," + ProductTitle.Text + "," + loggedInCustomerEmail + "," + OfferPriceBox.Text + "," + "In asteptare" + "," + ProductSeller.Text);
            }

            DisableOfferButton();
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {

        }

        private void LogoButton_Click(object sender, EventArgs e)
        {
            Hide();
            SignIn signIn = new SignIn();
            signIn.Closed += (s, args) => this.Close();
            signIn.Show();
        }

        private void AboutButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta pagina contine detaliile produsului selectat. Aici puteti vedea informatii despre produsul selectat si puteti face o oferta sau cumpara produsul.");
        }

        private void SupportButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("In cazul in care intampinati probleme sau aveti nelamuriri, va rugam sa ne contactati la adresa de email: admin@gmail.com. Va multumim!");
        }
    }
}
