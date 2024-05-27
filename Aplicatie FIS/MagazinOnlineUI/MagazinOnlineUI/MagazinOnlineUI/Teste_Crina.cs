using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace MagazinOnlineUI
{
    [TestFixture]
    public class Teste_Crina
    {
        private DataGridView sourceGrid;
        private DataGridView destinationGrid;
        private Dictionary<string, string> new_seller;
        private Dictionary<string, string> new_xseller;
        private string productsFilePath;
        private string offersFilePath;
        private string historyFilePath;

        [SetUp]
        public void SetUp()
        {
            // Inițializarea grilelor și a dicționarelor
            sourceGrid = new DataGridView();
            sourceGrid.Columns.Add("Email", "Email");
            sourceGrid.Columns.Add("Parola", "Parola");
            sourceGrid.Rows.Add("seller1@example.com", "password1");

            destinationGrid = new DataGridView();
            destinationGrid.Columns.Add("Email", "Email");
            destinationGrid.Columns.Add("Parola", "Parola");

            new_seller = new Dictionary<string, string>();
            new_xseller = new Dictionary<string, string>();

            // Adăugare date exemplu în DataGridView
            sourceGrid.Rows.Add("claudia@gmail.com", "claudia", "0");
            destinationGrid.Rows.Add("claudia@gmail.com", "claudia", "0");
        }

        [TearDown]
        public void TearDown()
        {
            if (sourceGrid != null)
            {
                sourceGrid.Dispose();
                sourceGrid = null;
            }
            if (destinationGrid != null)
            {
                destinationGrid.Dispose();
                destinationGrid = null;
            }
            new_seller.Clear();
            new_xseller.Clear();
        }

        private void MoveRowBetweenGrids(DataGridView sourceGrid, DataGridView destinationGrid)
        {
            if(sourceGrid == null || destinationGrid == null)
            {
                return;
            }
            // Verificați dacă a fost selectat un rând în DataGridView-ul sursă
            if (sourceGrid.SelectedRows.Count > 0)
            {
                // Obțineți rândul selectat
                DataGridViewRow selectedRow = sourceGrid.SelectedRows[0];

                // Adăugați un nou rând în DataGridView-ul destinație și copiați datele din rândul selectat
                destinationGrid.Rows.Add(selectedRow.Cells[0].Value, selectedRow.Cells[1].Value);

                string email = selectedRow.Cells["Email"].Value.ToString();
                string parola = selectedRow.Cells["Parola"].Value.ToString();

                // Ștergeți rândul selectat din DataGridView-ul sursă
                sourceGrid.Rows.Remove(selectedRow);

                // Actualizați dicționarele corespunzătoare, în funcție de grila destinație
                if (destinationGrid == sourceGrid)
                {
                    new_xseller.Add(email, parola);
                    new_seller.Remove(email);
                }
                else
                {
                    new_seller.Add(email, parola);
                    new_xseller.Remove(email);
                }
            }
            else
            {
                MessageBox.Show("Selectați un rând înainte de a muta.");
            }
        }

        [Test]
        public void MoveRowBetweenGrids_ValidSelection_RowMovedSuccessfully()
        {
            // Simularea datelor de test în DataGridView
            sourceGrid.Rows.Clear();
            sourceGrid.Rows.Add("claudia@gmail.com", "claudia", "0");
            destinationGrid.Rows.Clear();
            // Simularea selectării unui rând în DataGridView
            sourceGrid.Rows[0].Selected = true;
            // Simularea unei selecții valide și a mutării unui rând între grile
            MoveRowBetweenGrids(sourceGrid, destinationGrid);

            // Verificarea dacă rândul a fost mutat cu succes în grila destinație și eliminat din grila sursă
            ClassicAssert.AreEqual(2, destinationGrid.Rows.Count);
            ClassicAssert.AreEqual(1, sourceGrid.Rows.Count);

            // Verificarea dacă datele au fost actualizate corect în dicționarele corespunzătoare
            ClassicAssert.IsFalse(new_xseller.ContainsKey("claudia@gmail.com"));
            ClassicAssert.IsTrue(new_seller.ContainsKey("claudia@gmail.com"));
        }

        [Test]
        public void MoveRowBetweenGrids_NoRowSelected_NoChanges()
        {
            // Simularea datelor de test în DataGridView
            sourceGrid.Rows.Clear();
            sourceGrid.Rows.Add("claudia@gmail.com", "claudia", "0");
            destinationGrid.Rows.Clear();
            // Simulam ca nu a fost selectat niciun rand
            sourceGrid.Rows[0].Selected = false;
            // Simularea va afisa un messagebox cu mesajul "Selectați un rând înainte de a muta."
            MoveRowBetweenGrids(sourceGrid, destinationGrid);

            // Verificarea dacă rândul a fost mutat cu succes în grila destinație și eliminat din grila sursă
            ClassicAssert.AreEqual(1, destinationGrid.Rows.Count);
            ClassicAssert.AreEqual(2, sourceGrid.Rows.Count);
        }

        [Test]
        public void MoveRowBetweenGrids_DuplicateEmailInDestinationGrid_NoChanges()
        {
            // Simularea datelor de test în DataGridView
            sourceGrid.Rows.Clear();
            sourceGrid.Rows.Add("claudia@gmail.com", "claudia");
            destinationGrid.Rows.Clear();
            destinationGrid.Rows.Add("claudia@gmail.com", "duplicate");

            // Simularea selectării unui rând în DataGridView
            sourceGrid.Rows[0].Selected = true;

            // Încercarea de a muta un rând care conține un email duplicat în grila destinație
            MoveRowBetweenGrids(sourceGrid, destinationGrid);

            // Verificarea că nu s-au efectuat modificări în grilele sau dicționarele implicate
            ClassicAssert.AreEqual(1, sourceGrid.Rows.Count);
            ClassicAssert.AreEqual(3, destinationGrid.Rows.Count);
            ClassicAssert.IsFalse(new_xseller.ContainsKey("claudia@gmail.com"));
            ClassicAssert.IsTrue(new_seller.ContainsKey("claudia@gmail.com"));
        }

        [Test]
        public void MoveRowBetweenGrids_SourceGridEqualToDestinationGrid_NoChanges()
        {
            // Simularea datelor de test în DataGridView
            sourceGrid.Rows.Clear();
            sourceGrid.Rows.Add("claudia@gmail.com", "claudia");

            // Setarea grilelor să fie egale
            destinationGrid = sourceGrid;

            // Simularea selectării unui rând în DataGridView
            sourceGrid.Rows[0].Selected = true;

            // Încercarea de a muta un rând între două grile identice
            MoveRowBetweenGrids(sourceGrid, destinationGrid);

            // Verificarea că nu s-au efectuat modificări în grilele sau dicționarele implicate
            ClassicAssert.AreEqual(2, sourceGrid.Rows.Count);
            ClassicAssert.IsTrue(new_xseller.ContainsKey("claudia@gmail.com"));
            ClassicAssert.IsFalse(new_seller.ContainsKey("claudia@gmail.com"));
        }

        [Test]
        public void MoveRowBetweenGrids_EmptySourceGrid_NoChanges()
        {
            // Simularea datelor de test în DataGridView
            sourceGrid.Rows.Clear();
            destinationGrid.Rows.Clear();

            // Simularea încercării de a muta un rând dintr-o grilă sursă goală
            MoveRowBetweenGrids(sourceGrid, destinationGrid);

            // Verificarea că nu s-au efectuat modificări în grilele sau dicționarele implicate
            ClassicAssert.AreEqual(1, sourceGrid.Rows.Count);
            ClassicAssert.AreEqual(1, destinationGrid.Rows.Count);
            ClassicAssert.AreEqual(0, new_seller.Count);
            ClassicAssert.AreEqual(0, new_xseller.Count);
        }

        [Test]
        public void MoveRowBetweenGrids_NullSourceGrid_NoChanges()
        {
            // Simularea unei grile sursă nule
            sourceGrid = null;

            // Simularea unei grile destinație ne-nule
            destinationGrid.Rows.Clear();
            destinationGrid.Rows.Add("claudia@gmail.com", "claudia");

            // Încercarea de a muta un rând dintr-o grilă sursă nulă
            MoveRowBetweenGrids(sourceGrid, destinationGrid);

            // Verificarea că nu s-au efectuat modificări în grila destinație
            ClassicAssert.AreEqual(2, destinationGrid.Rows.Count);
        }

        [Test]
        public void MoveRowBetweenGrids_NullDestinationGrid_NoChanges()
        {
            // Simularea unei grile destinație nule
            destinationGrid = null;

            // Simularea datelor de test în DataGridView
            sourceGrid.Rows.Clear();
            sourceGrid.Rows.Add("claudia@gmail.com", "claudia");

            // Încercarea de a muta un rând către o grilă destinație nulă
            MoveRowBetweenGrids(sourceGrid, destinationGrid);

            // Verificarea că nu s-au efectuat modificări în grila sursă
            ClassicAssert.AreEqual(2, sourceGrid.Rows.Count);
        }

    }
}
