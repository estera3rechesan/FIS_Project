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
    public partial class Offers : Form
    {
        string loggedInCustomerEmail = SignIn.LoggedInCustomerEmail;
        public Offers()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Resize += new EventHandler(Offers_Resize);

            //Title, Price, Status, Seller
            OffersGridView.Columns.Add("Title", "Title");
            OffersGridView.Columns.Add("Price", "Price");
            OffersGridView.Columns.Add("Status", "Status");
            OffersGridView.Columns.Add("Seller", "Seller");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeCustomer homeCustomer = new HomeCustomer();
            homeCustomer.Closed += (s, args) => this.Close();
            homeCustomer.Show();
        }
        private void Offers_Resize(object sender, EventArgs e)
        {
            int panelX = (this.ClientSize.Width - OffersPanel.Width) / 2;
            int panelY = (this.ClientSize.Height - OffersPanel.Height) / 2;

            OffersPanel.Location = new Point(panelX, panelY);
        }

        private void Offers_Load(object sender, EventArgs e)
        {
            writeOffers();
        }

        private void writeOffers()
        {
            string[] lines = File.ReadAllLines("offers.csv");
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                if (columns[2] == loggedInCustomerEmail)
                    OffersGridView.Rows.Add(columns[1], columns[3], columns[4], columns[5]);
            }
        }

        private void AboutButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Aceasta pagina contine ofertele dumneavoastra. Puteti vedea ofertele pe care le-ati facut si statusul acestora.");
        }

        private void SupportButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("In cazul in care intampinati probleme sau aveti nelamuriri, va rugam sa ne contactati la adresa de email: admin@gmail.com. Va multumim!");
        }
    }
}
