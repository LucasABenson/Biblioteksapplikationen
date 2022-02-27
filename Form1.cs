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

namespace Bibliotekapplikationen
{
    public partial class Form1 : Form
    {
        private string currentPath = Environment.CurrentDirectory;
        //Alla dessa är bara sparade bilder. Tror egentligen inte att man bbehöver spara de här men aja
        Bitmap plusImage;
        Bitmap listImage;
        Bitmap dealeteImage;
        Bitmap tipImage;
        Bitmap searchImage;
        Random random = new Random();
        Label label = new Label();
        public Form1()
        {
            InitializeComponent();
            Librarian.AddBooksFromFile(); //Får alla böcker från txt-dokumentet.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetPictures(); //skapar alla bilder på knapparna.
        }


        private void AddBookButton_Click(object sender, EventArgs e)
        {
            //öppnar lägg till bok menyn. Egentligen kanske addbookform borde vara static
            //eftersom det inte bör kunna skapas flera objekt av den.
            AddBookForm addBookForm = new AddBookForm();
            
            addBookForm.ShowDialog();        
        }

        private void ListAllBooks_Click(object sender, EventArgs e)
        {
            ListAllBooksForm listAllBooksForm = new ListAllBooksForm();
            listAllBooksForm.ShowDialog();
            

        }

        private void EraseBooksButton_Click(object sender, EventArgs e)
        {
            Librarian.EraseAllBooks();
        }

        private void RandomBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Book> books = new List<Book>();
                books.AddRange(Librarian.PrintAllBooks());

                label.AutoSize = false;
                label.ResetText();

                label.Font = new Font("Arial", 15);
                label.Size = new Size(1000, 80);
                label.Location = new Point(0, 150);
                Controls.Add(label);
                label.Text = books[random.Next(books.Count)].ToString();
            }
            catch (Exception)
            {
                ErrorForm errorForm = new ErrorForm("Det finns inga böcker!");
                errorForm.ShowDialog();
            }

        }

        private void SearchForBookButton_Click(object sender, EventArgs e)
        {
            SearchForPost searchForPost = new SearchForPost();
            searchForPost.ShowDialog();
        }

        private void GetPictures()
        {
            AddBookButton.Text = null;
            plusImage = new Bitmap(currentPath + @"\Pictures\Plus.jpg");
            AddBookButton.Image = (Image)(new Bitmap(plusImage, new Size(144, 144)));

            ListAllBooks.Text = null;
            listImage = new Bitmap(currentPath + @"\Pictures\List.png");
            ListAllBooks.Image = (Image)(new Bitmap(listImage, new Size(144, 144)));

            EraseBooksButton.Text = null;
            dealeteImage = new Bitmap(currentPath + @"\Pictures\Delete.png");
            EraseBooksButton.Image = (Image)(new Bitmap(dealeteImage, new Size(144, 144)));

            RandomBookButton.Text = null;
            tipImage = new Bitmap(currentPath + @"\Pictures\Exclamationmark.jpg");
            RandomBookButton.Image = (Image)(new Bitmap(tipImage, new Size(144, 144)));

            SearchForBookButton.Text = null;
            searchImage = new Bitmap(currentPath + @"\Pictures\Glass.jpg");
            SearchForBookButton.Image = (Image)(new Bitmap(searchImage, new Size(144, 144)));
        }
    }
}
