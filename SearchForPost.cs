using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bibliotekapplikationen
{
    public partial class SearchForPost : Form
    {
        List<Book> books = new List<Book>();
        
        public SearchForPost()
        {
            //sätter alla searchfound i books = False.
            //Detta gör så att det går att kolla om boken existerar i sökrutan.
            InitializeComponent();
            books.AddRange(Librarian.PrintAllBooks());
            foreach (Book book in books)
            {
                book.searchfound = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {      
            /* för varje gång användare trycker in en karaktär i sökboxen (textbox1) så  
             *loopar foreach-loopen genom alla böcker. Där får tre stycken parametrar att söka efter. 
             *Första boolen söker efter om det användaren söker efter existerar i författar strängen. 
             *Det vill säga om användaren söker efter "tr" så kommer "astrid lindgren"'s böcker 
             *komma upp eftersom "tr" ingår i "astrid lindgren". däremot kommer "trk" in få upp något.
             *Det fungerar eftersom rad 43-45 kolla om användarens text existerar i någon av de olika
             *parametrarna.
             *      OM det är så att användarens string är samma som något av parametrarna så läggs
             *boken ToString text till i sökrutan och boken blir markerad som searchfound = true för
             *att inte kunna hitta samma objekt igen.
             *      OM det är så att användarens sökord inte matchar något så blir markerad som osökt
             *och försvinner från sökboxen.
             */
            foreach (Book book in books)
            {
                bool containsStringAuthor = book.Author.ToLower().Contains(textBox1.Text.ToLower());
                bool containsStringTitle = book.Titel.ToLower().Contains(textBox1.Text.ToLower());
                bool containsStringyear = Convert.ToString(book.RealeseYear).Contains(textBox1.Text);

                if (containsStringAuthor || containsStringTitle || containsStringyear)
                {
                    if (book.searchfound == false)
                    {
                        FoundAlternatives.Items.Add(book.ToString());
                        book.searchfound = true;
                    }
                }
                else
                {
                    if (book.searchfound == true)
                    {
                        FoundAlternatives.Items.Remove(book.ToString());
                        book.searchfound = false;
                    }
                }
            }
        }

        private void FoundAlternatives_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CloseFrombutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
