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
using System.Net;

namespace MagazinOnlineUI
{
    
    public partial class HomeCustomer : Form
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
            public string Flag { get; set; }
            public string Description { get; set; }
            public string MinPrice { get; set; }
        }
        private List<Product> products = new List<Product>();


        public HomeCustomer()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Resize += new EventHandler(Product_Resize);
            Initialize("products.csv", products);
            HidePanels();
        }

        private void HomeCustomer_Load(object sender, EventArgs e)
        {

        }

        private void HidePanels()
        {
            Product1Panel.Visible = false;
            Product2Panel.Visible = false;
            Product3Panel.Visible = false;
            Product4Panel.Visible = false;
            Product5Panel.Visible = false;
        }

        private void RefreshPanels()
        {
            //refresh all panels
            Product1Panel.Controls.Clear();
            Product2Panel.Controls.Clear();
            Product3Panel.Controls.Clear();
            Product4Panel.Controls.Clear();
            Product5Panel.Controls.Clear();

            //add the buttons back
            Product1Panel.Controls.Add(ViewButton1);
            Product2Panel.Controls.Add(ViewButton2);
            Product3Panel.Controls.Add(ViewButton3);
            Product4Panel.Controls.Add(ViewButton4);
            Product5Panel.Controls.Add(ViewButton5);
        }

        private void ShowPanels()
        {
            Product1Panel.Visible = true;
            Product2Panel.Visible = true;
            Product3Panel.Visible = true;
            Product4Panel.Visible = true;
            Product5Panel.Visible = true;
        }

        //citire produse din fisier
        private void Initialize(string caleFisier, List<Product> products)
        {
            string[] linii = File.ReadAllLines(caleFisier);
            foreach (string linie in linii)
            {
                string[] coloane = linie.Split(',');
                products.Add(new Product
                {
                    BookID = coloane[0],
                    Cover = coloane[1],
                    Title = coloane[2],
                    Author = coloane[3],
                    Genre = coloane[4],
                    Seller = coloane[5],
                    Price = coloane[6],
                    Flag = coloane[7],
                    Description = coloane[8]
                });
            }
        }

        private void Product_Resize(object sender, EventArgs e)
        {
            int panelX = (this.ClientSize.Width - ProductsPanel.Width) / 2;
            int panelY = (this.ClientSize.Height - ProductsPanel.Height) / 2;

            ProductsPanel.Location = new Point(panelX, panelY);
        }

        private void LogoButton_Click(object sender, EventArgs e)
        {
            Hide();
            SignIn signIn = new SignIn();
            signIn.Closed += (s, args) => this.Close();
            signIn.Show();
        }

        //adauga produs in panel
        private void AddProductToPanel(Product product, Panel panel, PictureBox cover, Label title, Label author)
        {
            using (WebClient wc = new WebClient())
            {
                byte[] bytes = wc.DownloadData(product.Cover);
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    cover.Image = Image.FromStream(ms);
                }
            }

            title.Text = product.Title;
            author.Text = product.Author;

            panel.Controls.Add(cover);
            panel.Controls.Add(title);
            panel.Controls.Add(author);

            ProductsPanel.Controls.Add(panel);
        }

        private void Offers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Offers offersPage = new Offers();
            offersPage.Closed += (s, args) => this.Close();
            offersPage.Show();
        }

        private void HideEmptyPanels()
        {
            // Verifică fiecare panou și ascunde-l dacă nu conține o imagine
            if (Product1Picture.Image == null)
                Product1Panel.Visible = false;

            if (Product2Picture.Image == null)
                Product2Panel.Visible = false;

            if (Product3Picture.Image == null)
                Product3Panel.Visible = false;

            if (Product4Picture.Image == null)
                Product4Panel.Visible = false;

            if (Product5Picture.Image == null)
                Product5Panel.Visible = false;
        }

        private void AddProducts(string genre)
        {
            ShowPanels();
            int panelIndex = 1; // Indexul panoului la care se adaugă elementul

            foreach (Product product in products)
            {
                if (!(product.BookID == "-"))
                {
                    // Verifică dacă genul produsului este cel dat ca parametru
                    if (product.Genre == genre)
                    {
                        switch (panelIndex)
                        {
                            case 1:
                                AddProductToPanel(product, Product1Panel, Product1Picture, Title1, Autor1);
                                break;
                            case 2:
                                AddProductToPanel(product, Product2Panel, Product2Picture, Title2, Autor2);
                                break;
                            case 3:
                                AddProductToPanel(product, Product3Panel, Product3Picture, Title3, Autor3);
                                break;
                            case 4:
                                AddProductToPanel(product, Product4Panel, Product4Picture, Title4, Autor4);
                                break;
                            case 5:
                                AddProductToPanel(product, Product5Panel, Product5Picture, Title5, Autor5);
                                break;
                        }

                        // Incrementarea indexului panoului pentru a trece la următorul panou
                        panelIndex++;

                        // Dacă am ajuns la panoul 5, ne oprim pentru a nu depăși numărul de panouri
                        if (panelIndex > 5)
                            break;
                    }
                }
            }
            HideEmptyPanels();
        }

        private void RomanceButton_Click(object sender, EventArgs e)
        {
           RefreshPanels();
           AddProducts("Romance");
        }

        private void ButtonFantasy_Click(object sender, EventArgs e)
        {
            RefreshPanels();
            AddProducts("Fantasy");
        }

        private void ButtonThriller_Click(object sender, EventArgs e)
        {
            RefreshPanels();
            AddProducts("Thriller");
        }

        private void ButtonMystery_Click(object sender, EventArgs e)
        {
            RefreshPanels();
            AddProducts("Mystery");
        }

        private void ButtonScienceFiction_Click(object sender, EventArgs e)
        {
            RefreshPanels();
            AddProducts("Science Fiction");
        }

        private void ButtonHistorical_Click(object sender, EventArgs e)
        {
           RefreshPanels();
           AddProducts("Historical Fiction");
        }

        private void ButtonHorror_Click(object sender, EventArgs e)
        {
            RefreshPanels();
            AddProducts("Horror");
        }

        private void ButtonBiography_Click(object sender, EventArgs e)
        {
            RefreshPanels();
            AddProducts("Biography");
        }

        private void ButtonsSelfHelp_Click(object sender, EventArgs e)
        {
           RefreshPanels();
           AddProducts("Self-Help");
        }

        private void ViewDescription(string name)
        {
            ProductPage productView = new ProductPage(name);
            productView.Closed += (s, args) => this.Close();
            productView.Show();
            this.Hide();
        }

        private void ViewButton1_Click(object sender, EventArgs e)
        {
            ViewDescription(Title1.Text);
        }

        private void ViewButton2_Click(object sender, EventArgs e)
        {
            ViewDescription(Title2.Text);
        }

        private void ViewButton3_Click(object sender, EventArgs e)
        {
            ViewDescription(Title3.Text);
        }

        private void ViewButton4_Click(object sender, EventArgs e)
        {
            ViewDescription(Title4.Text);
        }

        private void ViewButton5_Click(object sender, EventArgs e)
        {
            ViewDescription(Title5.Text);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchBox.Text.ToLower();

            // Caută produsul în lista de produse
            Product foundProduct = products.FirstOrDefault(p => p.Title.ToLower().Contains(searchTerm));

            // Verifică dacă s-a găsit un produs cu titlul căutat
            if (foundProduct != null)
            {
                // Afisează produsul în panel1
                ShowProductInPanel(foundProduct, Product1Panel);

                if (Product1Panel.Visible == false)
                {
                    Product1Panel.Visible = true;
                }
                Product2Panel.Visible = false;
                Product3Panel.Visible = false;
                Product4Panel.Visible = false;
                Product5Panel.Visible = false;
            }
            else
            {
                // Dacă nu s-a găsit niciun produs, afișează un mesaj corespunzător
                MessageBox.Show("Produsul căutat nu a fost găsit.");
            }
        }
        
        private void ShowProductInPanel(Product product, Panel panel)
        {
            // Încarcă imaginea copertei din URL-ul specificat în produs
            using (WebClient wc = new WebClient())
            {
                byte[] bytes = wc.DownloadData(product.Cover);
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    Product1Picture.Image = Image.FromStream(ms);
                }
            }

            // Actualizează titlul și autorul produsului
            Title1.Text = product.Title;
            Autor1.Text = product.Author;

            // Adaugă controlurile în panoul specific
            panel.Controls.Add(Product1Picture);
            panel.Controls.Add(Title1);
            panel.Controls.Add(Autor1);

            // Adaugă panoul în panoul principal (ProductsPanel)
            ProductsPanel.Controls.Add(panel);
        }


        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicația noastră este un magazin online de cărți. Aici puteți găsi o gamă largă de cărți din diferite genuri literare. Vă dorim o experiență plăcută!");
        }

        private void SupportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In cazul in care intampinati probleme sau aveti nelamuriri, va rugam sa ne contactati la adresa de email: admin@gmail.com. Va multumim!");
        }

        private void Product1Panel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            //Refresh the page
            Hide();
            HomeCustomer homeCustomer = new HomeCustomer();
            homeCustomer.Closed += (s, args) => this.Close();
            homeCustomer.Show();
        }

        private void HomeCustomer_Load_1(object sender, EventArgs e)
        {

        }
    }
}