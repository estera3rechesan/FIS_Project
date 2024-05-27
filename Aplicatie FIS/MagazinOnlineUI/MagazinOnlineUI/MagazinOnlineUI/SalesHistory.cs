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
using static MagazinOnlineUI.HomeSeller;

namespace MagazinOnlineUI
{
    public partial class SalesHistory : Form
    {
       
        public SalesHistory()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Resize += new EventHandler(AddProduct_Resize);

            //BookId, Price, Buyer
            HistoryGridView.Columns.Add("BookId", "BookId");
            HistoryGridView.Columns.Add("Price", "Price");
            HistoryGridView.Columns.Add("Buyer", "Buyer");
        }

        private void SalesHistory_Load(object sender, EventArgs e)
        {
            writeHistory("history.csv", HistoryGridView);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            HomeSeller homeSeller = new HomeSeller();
            homeSeller.Closed += (s, args) => this.Close();
            homeSeller.Show();
        }

        private void AddProduct_Resize(object sender, EventArgs e)
        {
            int panelX = (this.ClientSize.Width - HistoryPanel.Width) / 2;
            int panelY = (this.ClientSize.Height - HistoryPanel.Height) / 2;

            HistoryPanel.Location = new Point(panelX, panelY);
        }

        //scrie in grid datele citite din fisierul history.csv, fara a afisa datele despre vanzator
        private void writeHistory(string caleFisier, DataGridView gridView)
        {
            string loggedSellerEmail = SignIn.LoggedInSellerEmail;
            string[] linii = File.ReadAllLines(caleFisier);
            foreach (string linie in linii)
            {
                string[] date = linie.Split(',');
                if (date[3] == loggedSellerEmail)
                {
                    gridView.Rows.Add(date[0], date[1], date[2]);
                }
            }
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
            MessageBox.Show("Aici puteti vedea istoricul vanzarilor dumneavoastra.");
        }

        private void SupportButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("In cazul in care intampinati probleme sau aveti nelamuriri, va rugam sa ne contactati la adresa de email: admin@gmail.com. Va multumim!");
        }
    }
}
