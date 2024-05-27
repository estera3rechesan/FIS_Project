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
    public partial class AddProduct : Form
    {
        public class Product
        {
            public string BookID { get; set; }
            public string Cover { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public string Genre { get; set; }
            public string Seller { get; set; }
            public string Price { get; set; }
            public string FlagPrice { get; set; }
            public string Description { get; set; }
            public string MinPrice { get; set; }
        }
        public List<Product> products = new List<Product>();

        public AddProduct()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Resize += new EventHandler(AddProduct_Resize);
            InitializeProducts("products.csv");

            // Hide the fields for the negociable price
            MinPriceTextBox.Hide();
            MinPriceLabel.Hide();
        }

        public void AddProduct_Load(object sender, EventArgs e)
        {

        }

        //metoda care stocheaza datele din fisierul products.csv in lista de produse
        public void InitializeProducts(string caleFisier)
        {
            try
            {
                string[] linii = File.ReadAllLines(caleFisier);

                foreach (string linie in linii)
                {
                    string[] date = linie.Split(',');
                    Product product = new Product();
                    product.BookID = date[0];
                    product.Cover = date[1];
                    product.Title = date[2];
                    product.Author = date[3];
                    product.Genre = date[4];
                    product.Seller = date[5];
                    product.Price = date[6];
                    product.FlagPrice = date[7];
                    product.Description = date[8];
                    product.MinPrice = date[9];
                    products.Add(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea datelor din fișier: " + ex.Message);
            }
        }

        public void AddProduct_Resize(object sender, EventArgs e)
        {
            int panelX = (this.ClientSize.Width - AddProductPanel.Width) / 2;
            int panelY = (this.ClientSize.Height - AddProductPanel.Height) / 2;

            AddProductPanel.Location = new Point(panelX, panelY);
        }

        public void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HomeSeller homeSeller = new HomeSeller();
            homeSeller.Closed += (s, args) => this.Close();
            homeSeller.Show();
        }

        //metoda care salveaza datele din lista de produse in fisierul products.csv
        public void SaveProducts(string caleFisier)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(caleFisier))
                {
                    foreach (Product product in products)
                    {
                        
                        sw.WriteLine(product.BookID + "," + product.Cover + "," + product.Title + "," + product.Author + "," + product.Genre + "," + product.Seller + "," + product.Price + "," + product.FlagPrice + "," + product.Description + "," + product.MinPrice);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la scrierea datelor în fișier: " + ex.Message);
            }
        }

        public void FixedButton_Click(object sender, EventArgs e)
        {
            if (!(MinPriceTextBox.Text == ""))
            { 
                MessageBox.Show("Produsul nu se va adauga cu pret minim, deoarece pretul produsului este fix. Sterge pretul minim!");
                return;
            }

            Product product = new Product();
            product.BookID = (products.Count + 1).ToString();
            product.Cover = CoverTextBox.Text;
            product.Title = TitleTextBox.Text;
            product.Author = AuthorTextBox.Text;
            product.Genre = GenreTextBox.Text;
            product.Seller = SignIn.LoggedInSellerEmail;
            product.Price = PriceTextBox.Text;
            product.FlagPrice = "FixedPrice";
            product.Description = DescriptionTextBox.Text;
            product.MinPrice = "0";

            if(product.Genre != "Romance" && 
               product.Genre != "Thriller" && 
               product.Genre != "Mystery" && 
               product.Genre != "Fantasy" && 
               product.Genre != "Science Fiction" && 
               product.Genre != "Historical Fiction" && 
               product.Genre != "Horror" && 
               product.Genre != "Biography" && 
               product.Genre != "Self-Help")
            {
                MessageBox.Show("Genre should be one of the following: Romance, Thriller, Mystery, Fantasy, Science Fiction, Historical Fiction, Horror, Biography, Self-Help");
            }
            else
            {
                products.Add(product);

                CoverTextBox.Text = "";
                TitleTextBox.Text = "";
                AuthorTextBox.Text = "";
                GenreTextBox.Text = "";
                PriceTextBox.Text = "";
                DescriptionTextBox.Text = "";
                
                MinPriceLabel.Hide();
                MinPriceTextBox.Hide();

                SaveProducts("products.csv");
            }
        }

        public void NegotiableButton_Click(object sender, EventArgs e)
        {
            // Show the fields for the negociable price
            MinPriceTextBox.Show();
            MinPriceLabel.Show();

            if(MinPriceTextBox.Text == "")
            {
                MinPriceLabel.ForeColor = Color.Red;
                MinPriceLabel.Text = "Introduceti un pret minim!";
            }
            else {

                //verificare daca pretul minim este mai mic decat pretul produsului
                if (Convert.ToInt32(MinPriceTextBox.Text) > Convert.ToInt32(PriceTextBox.Text))
                {
                    MessageBox.Show("Pretul minim trebuie sa fie mai mic decat pretul produsului!");
                    return;
                }

                Product product = new Product();
                product.BookID = (products.Count + 1).ToString();
                product.Cover = CoverTextBox.Text;
                product.Title = TitleTextBox.Text;
                product.Author = AuthorTextBox.Text;
                product.Genre = GenreTextBox.Text;
                product.Seller = SignIn.LoggedInSellerEmail;
                product.Price = PriceTextBox.Text;
                product.FlagPrice = "NegociablePrice";
                product.Description = DescriptionTextBox.Text;
                product.MinPrice = MinPriceTextBox.Text;

                if (product.Genre != "Romance" &&
                   product.Genre != "Thriller" &&
                   product.Genre != "Mystery" &&
                   product.Genre != "Fantasy" &&
                   product.Genre != "Science Fiction" &&
                   product.Genre != "Historical Fiction" &&
                   product.Genre != "Horror" &&
                   product.Genre != "Biography" &&
                   product.Genre != "Self-Help")
                {
                    MessageBox.Show("Genre should be one of the following: Romance, Thriller, Mystery, Fantasy, Science Fiction, Historical Fiction, Horror, Biography, Self-Help");
                }
                else
                {
                    products.Add(product);

                    CoverTextBox.Text = "";
                    TitleTextBox.Text = "";
                    AuthorTextBox.Text = "";
                    GenreTextBox.Text = "";
                    PriceTextBox.Text = "";
                    DescriptionTextBox.Text = "";
                    MinPriceTextBox.Text = "";

                    MinPriceLabel.Hide();
                    MinPriceTextBox.Hide();

                    SaveProducts("products.csv");
                }
            } 
        }

        public void LogoButton_Click(object sender, EventArgs e)
        {
            Hide();
            SignIn signIn = new SignIn();
            signIn.Closed += (s, args) => this.Close();
            signIn.Show();
        }

        public void SupportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In cazul in care intampinati probleme sau aveti nelamuriri, va rugam sa ne contactati la adresa de email: admin@gmail.com. Va multumim!");
        }

        public void AboutButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta pagina este destinata adaugarii de produse in magazinul online. Pentru a adauga un produs, completati toate campurile si apasati butonul de adaugare. Daca doriti sa reveniti la pagina principala, apasati butonul de logo.");
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
