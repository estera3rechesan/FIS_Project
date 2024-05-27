using NUnit.Framework;
using System;
using System.IO;
using System.Windows.Forms;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.IO;

namespace MagazinOnlineUI
{
    [TestFixture]
    public class Teste_Lorena
    {
        private string loggedInSellerEmail;
        private DataGridView dataGridView;

        [SetUp]
        public void SetUp()
        {
            // Curățarea DataGridView înainte de fiecare test
            dataGridView.Rows.Clear();
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            // Inițializare DataGridView înainte de fiecare test
            dataGridView = new DataGridView();

            // Adăugare coloane la DataGridView
            dataGridView.Columns.Add("Id", "ID");
            dataGridView.Columns.Add("Title", "Title");
            dataGridView.Columns.Add("Author", "Author");
            dataGridView.Columns.Add("Genre", "Genre");
            dataGridView.Columns.Add("Price", "Price");
            dataGridView.Columns.Add("PriceType", "Price Type");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // Eliminare DataGridView după finalizarea tuturor testelor
            dataGridView.Dispose();
        }

        [Test]
        public void WriteProducts_ValidData_AddsRowsToDataGridView()
        {
            // Simularea datelor de test
            string[] testData = new string[]
            {
                "1,https://example.com/image1.jpg,Carte1,Autor1,Gen1,Vanzator1,100,NegociablePrice",
                "2,https://example.com/image2.jpg,Carte2,Autor2,Gen2,Vanzator2,200,FixedPrice"
            };

            // Crearea unui fișier CSV temporar pentru test
            string tempCsvFilePath = Path.GetTempFileName();
            File.WriteAllLines(tempCsvFilePath, testData);

            // Setarea vânzătorului logat pentru test
            loggedInSellerEmail = "Vanzator1";

            // Apelarea funcției pentru test
            writeProducts(tempCsvFilePath, dataGridView);

            // Verificarea rezultatului
            ClassicAssert.AreEqual(2, dataGridView.Rows.Count);
            ClassicAssert.AreEqual("1", dataGridView.Rows[0].Cells[0].Value);
            ClassicAssert.AreEqual("Carte1", dataGridView.Rows[0].Cells[1].Value);
            ClassicAssert.AreEqual("Autor1", dataGridView.Rows[0].Cells[2].Value);
            ClassicAssert.AreEqual("Gen1", dataGridView.Rows[0].Cells[3].Value);
            ClassicAssert.AreEqual("100", dataGridView.Rows[0].Cells[4].Value);
            ClassicAssert.AreEqual("NegociablePrice", dataGridView.Rows[0].Cells[5].Value);

            // Ștergerea fișierului temporar creat pentru test
            File.Delete(tempCsvFilePath);
        }

        [Test]
        public void WriteProducts_InvalidSellerEmail_NoRowsAddedToDataGridView()
        {
            // Simularea datelor de test
            string[] testData = new string[]
            {
                "1,https://example.com/image1.jpg,Carte1,Autor1,Gen1,Vanzator1,100,NegociablePrice",
                "2,https://example.com/image2.jpg,Carte2,Autor2,Gen2,Vanzator2,200,FixedPrice"
            };

            // Crearea unui fișier CSV temporar pentru test
            string tempCsvFilePath = Path.GetTempFileName();
            File.WriteAllLines(tempCsvFilePath, testData);

            // Setarea unui vânzător diferit de cel logat pentru test
            loggedInSellerEmail = "AltVanzator";

            // Apelarea funcției pentru test
            writeProducts(tempCsvFilePath, dataGridView);

            // Verificarea rezultatului
            ClassicAssert.AreEqual(1, dataGridView.Rows.Count);

            // Ștergerea fișierului temporar creat pentru test
            File.Delete(tempCsvFilePath);
        }

        [Test]
        public void WriteProducts_EmptyFile_NoRowsAddedToDataGridView()
        {
            // Crearea unui fișier CSV temporar gol pentru test
            string tempCsvFilePath = Path.GetTempFileName();

            // Apelarea funcției pentru test
            writeProducts(tempCsvFilePath, dataGridView);

            // Verificarea rezultatului
            ClassicAssert.AreEqual(1, dataGridView.Rows.Count);
        }

        [Test]
        public void WriteProducts_InvalidData_NoRowsAddedToDataGridView()
        {
            // Simularea datelor de test nevalide în fișierul CSV
            string[] testData = new string[]
            {
                "1,https://example.com/image1.jpg,Carte1,Autor1,Gen1,Vanzator1,100", // Linie incompletă
                "2,https://example.com/image2.jpg,Carte2,Autor2,Gen2,Vanzator2,200,FixedPrice,ExtraColumn" // Linie cu prea multe coloane
            };

            // Crearea unui fișier CSV temporar pentru test
            string tempCsvFilePath = Path.GetTempFileName();
            File.WriteAllLines(tempCsvFilePath, testData);

            // Apelarea funcției pentru test
            writeProducts(tempCsvFilePath, dataGridView);

            // Verificarea rezultatului
            ClassicAssert.AreEqual(1, dataGridView.Rows.Count);

            // Ștergerea fișierului temporar creat pentru test
            File.Delete(tempCsvFilePath);
        }

        [Test]
        public void WriteProducts_MultipleSellers_MultipleRowsAddedToDataGridView()
        {
            // Simularea datelor de test cu mai mulți vânzători
            string[] testData = new string[]
            {
                "1,https://example.com/image1.jpg,Carte1,Autor1,Gen1,Vanzator1,100,NegociablePrice",
                "2,https://example.com/image2.jpg,Carte2,Autor2,Gen2,Vanzator2,200,FixedPrice",
                "3,https://example.com/image3.jpg,Carte3,Autor3,Gen3,Vanzator1,300,FixedPrice"
            };

            // Crearea unui fișier CSV temporar pentru test
            string tempCsvFilePath = Path.GetTempFileName();
            File.WriteAllLines(tempCsvFilePath, testData);

            // Setarea vânzătorului logat pentru test
            loggedInSellerEmail = "Vanzator1";

            // Apelarea funcției pentru test
            writeProducts(tempCsvFilePath, dataGridView);

            // Verificarea rezultatului
            ClassicAssert.AreEqual(3, dataGridView.Rows.Count);

            // Ștergerea fișierului temporar creat pentru test
            File.Delete(tempCsvFilePath);
        }

        [Test]
        public void WriteProducts_WhitespaceInData_RowsAddedToDataGridView()
        {
            // Simularea datelor de test cu spații albe în datele produselor
            string[] testData = new string[]
            {
                "1,https://example.com/image1.jpg, Carte1 ,Autor1,Gen1, Vanzator1 ,100,NegociablePrice",
                "2,https://example.com/image2.jpg,Carte2,Autor2,Gen2,Vanzator1,200,FixedPrice"
            };

            // Crearea unui fișier CSV temporar pentru test
            string tempCsvFilePath = Path.GetTempFileName();
            File.WriteAllLines(tempCsvFilePath, testData);

            // Setarea vânzătorului logat pentru test
            loggedInSellerEmail = "Vanzator1";

            // Apelarea funcției pentru test
            writeProducts(tempCsvFilePath, dataGridView);

            // Verificarea rezultatului
            ClassicAssert.AreEqual(2, dataGridView.Rows.Count);

            // Ștergerea fișierului temporar creat pentru test
            File.Delete(tempCsvFilePath);
        }

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
    }
}
