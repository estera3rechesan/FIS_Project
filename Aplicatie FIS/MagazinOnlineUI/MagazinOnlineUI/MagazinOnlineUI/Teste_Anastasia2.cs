using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace MagazinOnlineUI
{
    [TestFixture]
    public class Teste_Anastasia2
    {
        private string loggedInSellerEmail = "seller@example.com";
        private DataGridView FixedPriceGrid;


        [SetUp]
        public void SetUp()
        {
            // Inițializare DataGridView și adăugare coloane
            FixedPriceGrid = new DataGridView();
            FixedPriceGrid.Columns.Add("Id", "ID");
            FixedPriceGrid.Columns.Add("Price", "Price");
            FixedPriceGrid.Columns.Add("Customer", "Customer");
            FixedPriceGrid.Columns.Add("Status", "Status");

            // Adăugare date exemplu în DataGridView
            FixedPriceGrid.Rows.Add("1", "100", "customer1@example.com", "Pending", "estera@gmail.com");

            // Creare fișier CSV temporar
            CreateTempFile();
        }

        [TearDown]
        public void TearDown()
        {
            // Eliminare DataGridView după fiecare test
            if (FixedPriceGrid != null)
            {
                FixedPriceGrid.Dispose();
                FixedPriceGrid = null;
            }

            // Ștergere fișier temporar
            DeleteTempFile();
        }

        private void CreateTempFile()
        {
            // Creare fișier CSV temporar
            File.WriteAllText("test_almostBought.csv", "1,100,customer1@example.com,Pending,estera@gmail.com\n");
        }

        private void DeleteTempFile()
        {
            // Ștergere fișier temporar
            File.Delete("test_almostBought.csv");
        }

        private void DenyFixed_Click(object sender, EventArgs e)
        {
            // Verificăm dacă există rânduri selectate în DataGridView
            if (FixedPriceGrid.SelectedRows.Count > 0)
            {
                // Obținem primul rând selectat
                var selectedRow = FixedPriceGrid.SelectedRows[0];

                // Verificăm dacă rândul selectat nu este null
                if (selectedRow != null)
                {
                    // Modificarea stării ofertei în "Denied"
                    string bookId = FixedPriceGrid.SelectedRows[0].Cells[0].Value.ToString();
                    string price = FixedPriceGrid.SelectedRows[0].Cells[1].Value.ToString();
                    string customer = FixedPriceGrid.SelectedRows[0].Cells[2].Value.ToString();
                    string status = "Anulat";

                    // Apoi refacerea fișierului almostBought.csv cu starea modificată
                    string[] lines = File.ReadAllLines("test_almostBought.csv");
                    using (StreamWriter sw = new StreamWriter("test_almostBought.csv"))
                    {
                        foreach (string line in lines)
                        {
                            string[] columns = line.Split(',');
                            if (columns[0] == bookId && columns[2] == customer && columns[1] == price)
                            {
                                sw.WriteLine(bookId + "," + price + "," + customer + "," + status + "," + loggedInSellerEmail);
                            }
                            else
                            {
                                sw.WriteLine(line);
                            }
                        }
                    }
                }
            }
        }

        [Test]
        public void DenyFixed_Click_ValidSelection_StatusUpdatedToDenied()
        {
            // Simularea datelor de test în DataGridView
            FixedPriceGrid.Rows.Clear();
            FixedPriceGrid.Rows.Add("1", "100", "customer1@example.com", "Pending", "estera@gmail.com");

            // Simularea selectării unui rând în DataGridView
            FixedPriceGrid.Rows[0].Selected = true;

            // Simularea unui click pe butonul de refuzare
            DenyFixed_Click(null, EventArgs.Empty);

            // Verificarea actualizării stării în fișierul almostBought.csv
            string[] lines = File.ReadAllLines("test_almostBought.csv");
            string lastLine = lines[lines.Length - 1];
            string[] colomns = lastLine.Split(',');
            ClassicAssert.AreEqual("Anulat", colomns[3]);
        }

        [Test]
        public void DenyFixed_Click_NoRowSelected_NoChanges()
        {
            // Simularea datelor de test în DataGridView
            FixedPriceGrid.Rows.Clear();
            FixedPriceGrid.Rows.Add("1", "100", "customer1@example.com", "Pending", "estera@gmail.com");

            // Simularea unui click pe butonul de refuzare fără să fie selectat niciun rând
            DenyFixed_Click(null, EventArgs.Empty);

            // Verificarea că nu s-au efectuat modificări în fișierul almostBought.csv
            string[] lines = File.ReadAllLines("test_almostBought.csv");
            ClassicAssert.AreEqual(1, lines.Length); // Fișierul trebuie să conțină doar antetul
        }

        [Test]
        public void DenyFixed_Click_InvalidData_NoChanges()
        {
            // Simularea datelor de test în DataGridView
            FixedPriceGrid.Rows.Clear();
            FixedPriceGrid.Rows.Add("1", "15", "customer1@example.com", "Pending", "estera@gmail.com");

            // Simularea selectării unui rând în DataGridView
            FixedPriceGrid.Rows[0].Selected = true;

            // Simularea unui click pe butonul de refuzare cu date invalide
            // (de exemplu, când este selectat un rând care nu conține date valide pentru refuz)
            DenyFixed_Click(null, EventArgs.Empty);

            // Verificarea că nu s-au efectuat modificări în fișierul almostBought.csv
            string[] lines = File.ReadAllLines("test_almostBought.csv");
            ClassicAssert.AreEqual(1, lines.Length); // Fișierul trebuie să conțină doar antetul
        }
    }
}
