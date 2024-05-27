using System;
using System.Drawing;
using System.Windows.Forms;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace MagazinOnlineUI.UnitTests
{
    [TestFixture]
    public class Tests_Anastasia
    {
        //    private AddProduct addProduct;

        //    [SetUp]
        //    public void Setup()
        //    {
        //        addProduct = new AddProduct();
        //    }

        //    [TearDown]
        //    public void TearDown()
        //    {
        //        addProduct.Close();
        //    }

        //    [Test]
        //    public void TestFixedButton_Click_AddsProductWithValidData()
        //    {
        //        // Arrange
        //        addProduct.CoverTextBox.Text = "Cover";
        //        addProduct.TitleTextBox.Text = "Title";
        //        addProduct.AuthorTextBox.Text = "Author";
        //        addProduct.GenreTextBox.Text = "Romance";
        //        addProduct.PriceTextBox.Text = "10";
        //        addProduct.DescriptionTextBox.Text = "Description";

        //        // Act
        //        addProduct.FixedButton_Click(null, null);

        //        // ClassicAssert
        //        List<AddProduct.Product> products = addProduct.GetProducts();
        //        ClassicAssert.AreEqual(1, products.Count);
        //        ClassicAssert.AreEqual("Cover", products[0].Cover);
        //        ClassicAssert.AreEqual("Title", products[0].Title);
        //        ClassicAssert.AreEqual("Author", products[0].Author);
        //        ClassicAssert.AreEqual("Romance", products[0].Genre);
        //        ClassicAssert.AreEqual("10", products[0].Price);
        //        ClassicAssert.AreEqual("Description", products[0].Description);
        //    }

        //}
        //    private const string FilePath = "test_products.csv"; // Fișier temporar pentru testare

        //    [SetUp]
        //    public void Setup()
        //    {
        //        // Cream un fișier temporar pentru teste cu date de test
        //        string[] lines = {
        //        "1,Cover1,Title1,Author1,Genre1,Seller1,10,Fixed,Description1,5",
        //        "2,Cover2,Title2,Author2,Genre2,Seller2,15,Negotiable,Description2,7"
        //        };
        //        File.WriteAllLines(FilePath, lines);
        //    }

        //    [TearDown]
        //    public void TearDown()
        //    {
        //        // Ștergem fișierul temporar după fiecare test
        //        File.Delete(FilePath);
        //    }

        //    [Test]
        //    public void InitializeProducts_EmptyFile()
        //    {
        //        // Arrange
        //        var addProduct = new AddProduct();
        //        File.WriteAllText(FilePath, ""); // Scriem un fișier gol

        //        // Act
        //        addProduct.InitializeProducts(FilePath);

        //        // ClassicAssert
        //        ClassicAssert.AreEqual(0, addProduct.products.Count); // Nu ar trebui să fie inițializate produse
        //    }

        //    [Test]
        //    public void InitializeProducts_InvalidFileFormat()
        //    {
        //        // Arrange
        //        var addProduct = new AddProduct();
        //        File.WriteAllText(FilePath, "invalid, test, text"); // Scriem un fișier cu format invalid

        //        // Act
        //        addProduct.InitializeProducts(FilePath);

        //        // ClassicAssert
        //        ClassicAssert.AreEqual(0, addProduct.products.Count); // Nu ar trebui să fie inițializate produse din cauza formatului invalid
        //    }
        //}
    }
}
