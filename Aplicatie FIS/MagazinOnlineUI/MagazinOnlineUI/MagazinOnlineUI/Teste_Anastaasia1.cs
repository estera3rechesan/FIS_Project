using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.IO;
using System.Windows.Forms;

namespace MagazinOnlineUI
{
    [TestFixture]
    public class Teste_Anastaasia1
    {
        private string loggedInSellerEmail = "seller@example.com";
        private DataGridView OffersGridView;
        private string productsFilePath;
        private string offersFilePath;
        private string historyFilePath;

        [SetUp]
        public void SetUp()
        {
            // Inițializare DataGridView și adăugare coloane
            OffersGridView = new DataGridView();
            OffersGridView.Columns.Add("Id", "ID");
            OffersGridView.Columns.Add("Title", "Title");
            OffersGridView.Columns.Add("Customer", "Customer");
            OffersGridView.Columns.Add("OfferedPrice", "OfferedPrice");
            OffersGridView.Columns.Add("Status", "Status");

            // Adăugare date exemplu în DataGridView
            OffersGridView.Rows.Add("1", "Book1", "customer1@example.com", "50", "Pending");

            // Creare fișiere CSV temporare
            CreateTempFiles();
        }

        [TearDown]
        public void TearDown()
        {
            // Eliminare DataGridView după fiecare test
            if (OffersGridView != null)
            {
                OffersGridView.Dispose();
                OffersGridView = null;
            }

            // Ștergere fișiere temporare
            DeleteTempFiles();
        }

        private void CreateTempFiles()
        {
            // Creare cale fișiere temporare
            productsFilePath = Path.GetTempFileName();
            offersFilePath = Path.GetTempFileName();
            historyFilePath = Path.GetTempFileName();

            // Scriere date exemplu în fișierul products.csv
            File.WriteAllLines(productsFilePath, new string[]
            {
                "1,https://example.com/image1.jpg,Book1,Author1,Genre1,seller@example.com,100,NegociablePrice,Description1,50",
                "2,https://example.com/image2.jpg,Book2,Author2,Genre2,seller@example.com,200,NegociablePrice,Description2,100"
            });

            // Scriere date exemplu în fișierul offers.csv
            File.WriteAllLines(offersFilePath, new string[]
            {
                "1,Book1,customer1@example.com,50,Pending,seller@example.com",
                "1,Book1,customer2@example.com,60,Pending,seller@example.com",
                "2,Book2,customer1@example.com,150,Pending,seller@example.com"
            });

            // Creare fișier history.csv temporar (gol)
            File.Create(historyFilePath).Dispose();
        }

        private void DeleteTempFiles()
        {
            File.Delete(productsFilePath);
            File.Delete(offersFilePath);
            File.Delete(historyFilePath);
        }

        [Test]
        public void AllowButton_Click_AcceptsOfferAndUpdatesFiles()
        {
            // Crearea unui obiect Button pentru a simula click-ul
            var button = new Button();
            button.Click += AllowButton_Click;

            // Selectarea rândului din DataGridView pentru a simula selecția utilizatorului
            OffersGridView.Rows[0].Selected = true;

            // Simularea click-ului pe buton
            button.PerformClick();

            // Verificarea actualizării fișierului products.csv
            string[] updatedProducts = File.ReadAllLines(productsFilePath);
            ClassicAssert.IsTrue(updatedProducts[0].StartsWith("-"));

            // Verificarea actualizării fișierului offers.csv
            string[] updatedOffers = File.ReadAllLines(offersFilePath);
            ClassicAssert.IsTrue(updatedOffers[0].Contains("Acceptat"));
            ClassicAssert.IsTrue(updatedOffers[1].Contains("Refuzat"));

            // Verificarea actualizării fișierului history.csv
            string[] updatedHistory = File.ReadAllLines(historyFilePath);
            ClassicAssert.AreEqual(1, updatedHistory.Length);
            ClassicAssert.IsTrue(updatedHistory[0].Contains("1,50,customer1@example.com,seller@example.com"));
        }

        [Test]
        public void AllowButton_Click_NoOfferSelected_NoChanges()
        {
            // Crearea unui obiect Button pentru a simula click-ul
            var button = new Button();
            button.Click += AllowButton_Click;

            // Niciun rând selectat

            // Simularea click-ului pe buton
            button.PerformClick();

            // Verificarea că fișierele nu au fost modificate
            string[] products = File.ReadAllLines(productsFilePath);
            ClassicAssert.AreEqual(2, products.Length);
            ClassicAssert.IsFalse(products[0].StartsWith("-"));

            string[] offers = File.ReadAllLines(offersFilePath);
            ClassicAssert.AreEqual(3, offers.Length);
            ClassicAssert.IsFalse(offers[0].Contains("Acceptat"));
            ClassicAssert.IsFalse(offers[1].Contains("Refuzat"));

            string[] history = File.ReadAllLines(historyFilePath);
            ClassicAssert.AreEqual(0, history.Length);
        }

        [Test]
        public void AllowButton_Click_OfferAlreadyAccepted_NoChanges()
        {
            // Actualizare status pentru primul rând la "Acceptat"
            OffersGridView.Rows[0].Cells[4].Value = "Acceptat";

            // Crearea unui obiect Button pentru a simula click-ul
            var button = new Button();
            button.Click += AllowButton_Click;

            // Selectarea rândului din DataGridView pentru a simula selecția utilizatorului
            OffersGridView.Rows[0].Selected = true;

            // Simularea click-ului pe buton
            button.PerformClick();

            // Verificarea că fișierele nu au fost modificate
            string[] products = File.ReadAllLines(productsFilePath);
            ClassicAssert.AreEqual(2, products.Length);
            ClassicAssert.IsTrue(products[0].StartsWith("-"));

            string[] offers = File.ReadAllLines(offersFilePath);
            ClassicAssert.AreEqual(3, offers.Length);
            ClassicAssert.IsTrue(offers[0].Contains("Acceptat"));
            ClassicAssert.IsTrue(offers[1].Contains("Refuzat"));

            string[] history = File.ReadAllLines(historyFilePath);
            ClassicAssert.AreEqual(1, history.Length);
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
                    string[] liniiProduse = File.ReadAllLines(productsFilePath);
                    using (StreamWriter sw = new StreamWriter(productsFilePath))
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
                    string[] linii = File.ReadAllLines(offersFilePath);
                    using (StreamWriter sw = new StreamWriter(offersFilePath))
                    {
                        foreach (string linie in linii)
                        {
                            string[] coloane = linie.Split(',');
                            if (coloane[0] == bookId && coloane[2] == customer && coloane[3] == offeredPrice)
                            {
                                sw.WriteLine(bookId + "," + titlu + "," + customer + "," + offeredPrice + "," + status + "," + loggedInSellerEmail); // acceptăm oferta
                            }
                            else if (coloane[0] == bookId && coloane[2] != customer && coloane[3] != offeredPrice) // Refuzăm ofertele care nu sunt ale clientului respectiv
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
                    using (StreamWriter sw = File.AppendText(historyFilePath))
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

    }
}