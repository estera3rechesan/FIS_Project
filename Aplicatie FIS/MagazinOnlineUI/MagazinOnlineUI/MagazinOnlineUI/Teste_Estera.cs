using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.IO;

namespace MagazinOnlineUI
{
    [TestFixture]
    public class Teste_Estera
    {
        private string _testCsvFilePath;

        [SetUp]
        public void SetUp()
        {
            // Crearea unui fișier CSV temporar
            _testCsvFilePath = Path.Combine(Path.GetTempPath(), "test_products.csv");
        }

        [TearDown]
        public void TearDown()
        {
            // Ștergerea fișierului CSV temporar după fiecare test
            if (File.Exists(_testCsvFilePath))
            {
                File.Delete(_testCsvFilePath);
            }
        }

        [Test]
        public void CitesteProduseDinFisier_ValidCsv_ReturnsCorrectData()
        {
            // Scrierea datelor de test în fișierul CSV
            File.WriteAllLines(_testCsvFilePath, new string[]
            {
                "1,https://example.com/image1.jpg,Carte1,Autor1,Gen1,Vanzator1,100,NegociablePrice,Descriere1,50",
                "2,https://example.com/image2.jpg,Carte2,Autor2,Gen2,Vanzator2,200,FixedPrice,Descriere2,0"
            });

            // Instanțierea formularului de test
            var productPage = new ProductPage("Carte1");

            // Apelarea funcției și obținerea rezultatului
            List<Dictionary<string, string>> produse = productPage.CitesteProduseDinFisier(_testCsvFilePath);

            // Verificarea rezultatului
            ClassicAssert.AreEqual(2, produse.Count);

            // Verificarea primului produs
            ClassicAssert.AreEqual("1", produse[0]["Id"]);
            ClassicAssert.AreEqual("https://example.com/image1.jpg", produse[0]["ImageUrl"]);
            ClassicAssert.AreEqual("Carte1", produse[0]["Title"]);
            ClassicAssert.AreEqual("Autor1", produse[0]["Author"]);
            ClassicAssert.AreEqual("Gen1", produse[0]["Genre"]);
            ClassicAssert.AreEqual("Vanzator1", produse[0]["Seller"]);
            ClassicAssert.AreEqual("100", produse[0]["Price"]);
            ClassicAssert.AreEqual("NegociablePrice", produse[0]["PriceType"]);
            ClassicAssert.AreEqual("Descriere1", produse[0]["Description"]);
            ClassicAssert.AreEqual("50", produse[0]["MinPrice"]);

            // Verificarea celui de-al doilea produs
            ClassicAssert.AreEqual("2", produse[1]["Id"]);
            ClassicAssert.AreEqual("https://example.com/image2.jpg", produse[1]["ImageUrl"]);
            ClassicAssert.AreEqual("Carte2", produse[1]["Title"]);
            ClassicAssert.AreEqual("Autor2", produse[1]["Author"]);
            ClassicAssert.AreEqual("Gen2", produse[1]["Genre"]);
            ClassicAssert.AreEqual("Vanzator2", produse[1]["Seller"]);
            ClassicAssert.AreEqual("200", produse[1]["Price"]);
            ClassicAssert.AreEqual("FixedPrice", produse[1]["PriceType"]);
            ClassicAssert.AreEqual("Descriere2", produse[1]["Description"]);
            ClassicAssert.AreEqual("0", produse[1]["MinPrice"]);
        }

        [Test]
        public void CitesteProduseDinFisier_EmptyCsv_ReturnsEmptyList()
        {
            // Crearea unui fișier CSV gol
            File.WriteAllText(_testCsvFilePath, string.Empty);

            // Instanțierea formularului de test
            var productPage = new ProductPage("Carte1");

            // Apelarea funcției și obținerea rezultatului
            List<Dictionary<string, string>> produse = productPage.CitesteProduseDinFisier(_testCsvFilePath);

            // Verificarea rezultatului
            ClassicAssert.IsEmpty(produse);
        }


        [Test]
        public void CitesteProduseDinFisier_IncompleteData_ReturnsPartialData()
        {
            // Scrierea datelor incomplete în fișierul CSV
            File.WriteAllLines(_testCsvFilePath, new string[]
            {
                "1,https://example.com/image1.jpg,Carte1,Autor1,Gen1,Vanzator1,100,NegociablePrice,Descriere1,50",
                "2,https://example.com/image2.jpg,Carte2" // Linie incompletă
            });

            // Instanțierea formularului de test
            var productPage = new ProductPage("Carte1");

            // Apelarea funcției și obținerea rezultatului
            List<Dictionary<string, string>> produse = productPage.CitesteProduseDinFisier(_testCsvFilePath);

            // Verificarea rezultatului
            ClassicAssert.AreEqual(1, produse.Count);

            // Verificarea primului produs
            ClassicAssert.AreEqual("1", produse[0]["Id"]);
            ClassicAssert.AreEqual("https://example.com/image1.jpg", produse[0]["ImageUrl"]);
            ClassicAssert.AreEqual("Carte1", produse[0]["Title"]);
            ClassicAssert.AreEqual("Autor1", produse[0]["Author"]);
            ClassicAssert.AreEqual("Gen1", produse[0]["Genre"]);
            ClassicAssert.AreEqual("Vanzator1", produse[0]["Seller"]);
            ClassicAssert.AreEqual("100", produse[0]["Price"]);
            ClassicAssert.AreEqual("NegociablePrice", produse[0]["PriceType"]);
            ClassicAssert.AreEqual("Descriere1", produse[0]["Description"]);
            ClassicAssert.AreEqual("50", produse[0]["MinPrice"]);
        }

        [Test]
        public void CitesteProduseDinFisier_TooManyColumns_IgnoresExtraColumns()
        {
            // Scrierea datelor de test cu prea multe coloane în fișierul CSV
            File.WriteAllLines(_testCsvFilePath, new string[]
            {
                "1,https://example.com/image1.jpg,Carte1,Autor1,Gen1,Vanzator1,100,NegociablePrice,Descriere1,50,ExtraData"
            });

            // Instanțierea formularului de test
            var productPage = new ProductPage("Carte1");

            // Apelarea funcției și obținerea rezultatului
            List<Dictionary<string, string>> produse = productPage.CitesteProduseDinFisier(_testCsvFilePath);

            // Verificarea rezultatului
            ClassicAssert.AreEqual(1, produse.Count);

            // Verificarea primului produs
            ClassicAssert.AreEqual("1", produse[0]["Id"]);
            ClassicAssert.AreEqual("https://example.com/image1.jpg", produse[0]["ImageUrl"]);
            ClassicAssert.AreEqual("Carte1", produse[0]["Title"]);
            ClassicAssert.AreEqual("Autor1", produse[0]["Author"]);
            ClassicAssert.AreEqual("Gen1", produse[0]["Genre"]);
            ClassicAssert.AreEqual("Vanzator1", produse[0]["Seller"]);
            ClassicAssert.AreEqual("100", produse[0]["Price"]);
            ClassicAssert.AreEqual("NegociablePrice", produse[0]["PriceType"]);
            ClassicAssert.AreEqual("Descriere1", produse[0]["Description"]);
            ClassicAssert.AreEqual("50", produse[0]["MinPrice"]);
        }

        [Test]
        public void CitesteProduseDinFisier_BlankLines_IgnoresBlankLines()
        {
            // Scrierea datelor de test cu linii goale în fișierul CSV
            File.WriteAllLines(_testCsvFilePath, new string[]
            {
                "1,https://example.com/image1.jpg,Carte1,Autor1,Gen1,Vanzator1,100,NegociablePrice,Descriere1,50",
                "",
                "2,https://example.com/image2.jpg,Carte2,Autor2,Gen2,Vanzator2,200,FixedPrice,Descriere2,0"
            });

            // Instanțierea formularului de test
            var productPage = new ProductPage("Carte1");

            // Apelarea funcției și obținerea rezultatului
            List<Dictionary<string, string>> produse = productPage.CitesteProduseDinFisier(_testCsvFilePath);

            // Verificarea rezultatului
            ClassicAssert.AreEqual(2, produse.Count);

            // Verificarea primului produs
            ClassicAssert.AreEqual("1", produse[0]["Id"]);
            ClassicAssert.AreEqual("https://example.com/image1.jpg", produse[0]["ImageUrl"]);
            ClassicAssert.AreEqual("Carte1", produse[0]["Title"]);
            ClassicAssert.AreEqual("Autor1", produse[0]["Author"]);
            ClassicAssert.AreEqual("Gen1", produse[0]["Genre"]);
            ClassicAssert.AreEqual("Vanzator1", produse[0]["Seller"]);
            ClassicAssert.AreEqual("100", produse[0]["Price"]);
            ClassicAssert.AreEqual("NegociablePrice", produse[0]["PriceType"]);
            ClassicAssert.AreEqual("Descriere1", produse[0]["Description"]);
            ClassicAssert.AreEqual("50", produse[0]["MinPrice"]);

            // Verificarea celui de-al doilea produs
            ClassicAssert.AreEqual("2", produse[1]["Id"]);
            ClassicAssert.AreEqual("https://example.com/image2.jpg", produse[1]["ImageUrl"]);
            ClassicAssert.AreEqual("Carte2", produse[1]["Title"]);
            ClassicAssert.AreEqual("Autor2", produse[1]["Author"]);
            ClassicAssert.AreEqual("Gen2", produse[1]["Genre"]);
            ClassicAssert.AreEqual("Vanzator2", produse[1]["Seller"]);
            ClassicAssert.AreEqual("200", produse[1]["Price"]);
            ClassicAssert.AreEqual("FixedPrice", produse[1]["PriceType"]);
            ClassicAssert.AreEqual("Descriere2", produse[1]["Description"]);
            ClassicAssert.AreEqual("0", produse[1]["MinPrice"]);
        }

        [Test]
        public void CitesteProduseDinFisier_DataWithWhitespace_TrimmedValues()
        {
            // Scrierea datelor de test cu spații albe în fișierul CSV
            File.WriteAllLines(_testCsvFilePath, new string[]
            {
                " 1 , https://example.com/image1.jpg , Carte1 , Autor1 , Gen1 , Vanzator1 , 100 , NegociablePrice , Descriere1 , 50 "
            });

            // Instanțierea formularului de test
            var productPage = new ProductPage("Carte1");

            // Apelarea funcției și obținerea rezultatului
            List<Dictionary<string, string>> produse = productPage.CitesteProduseDinFisier(_testCsvFilePath);

            // Verificarea rezultatului
            ClassicAssert.AreEqual(1, produse.Count);

            // Verificarea primului produs
            ClassicAssert.AreEqual("1", produse[0]["Id"]);
            ClassicAssert.AreEqual("https://example.com/image1.jpg", produse[0]["ImageUrl"]);
            ClassicAssert.AreEqual("Carte1", produse[0]["Title"]);
            ClassicAssert.AreEqual("Autor1", produse[0]["Author"]);
            ClassicAssert.AreEqual("Gen1", produse[0]["Genre"]);
            ClassicAssert.AreEqual("Vanzator1", produse[0]["Seller"]);
            ClassicAssert.AreEqual("100", produse[0]["Price"]);
            ClassicAssert.AreEqual("NegociablePrice", produse[0]["PriceType"]);
            ClassicAssert.AreEqual("Descriere1", produse[0]["Description"]);
            ClassicAssert.AreEqual("50", produse[0]["MinPrice"]);
        }
    }
}
