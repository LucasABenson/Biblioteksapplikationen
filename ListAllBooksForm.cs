using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bibliotekapplikationen
{
    public partial class ListAllBooksForm : Form
    {
        public ListAllBooksForm()
        {
            InitializeComponent();
        }

        private void ListAllBooksForm_Load(object sender, EventArgs e)
        {
            
            List<Book> books = new List<Book>();
            books.AddRange(Librarian.PrintAllBooks());
            if (books.Count == 0)
            {
                ErrorForm errorForm = new ErrorForm("Det finns inga böcker!");
                errorForm.ShowDialog();
                this.Close();
            }
            this.Height = (books.Count + 2) * 20 + 10;
            this.Width = 610;
            int placePos = 0;
            foreach (Book book in books)
            {
                Label label = new Label();
                Controls.Add(label);
                label.Text = $"{book.Titel}, en {book.Booktype} skriven av {book.Author} ({book.RealeseYear})";
                label.Location = new Point(0, placePos * 20 );
                label.Size = new Size(600, 20);
                label.BackColor = Color.Red;
                    
                placePos++;
            }
        }
    }
}
