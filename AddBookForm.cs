using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bibliotekapplikationen
{
    public partial class AddBookForm : Form
    {
        internal string Title;
        internal string Author;
        internal int PublishedYear;
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void NovelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NovelCheckBox.Checked == true)
            {
                ShortStoryCheckBox.Enabled = false;
                JournalCheckBox.Enabled = false;
            }
            else
            {
                ShortStoryCheckBox.Enabled = true;
                JournalCheckBox.Enabled = true;
            }
        }

        private void ShortStoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShortStoryCheckBox.Checked == true)
            {
                NovelCheckBox.Enabled = false;
                JournalCheckBox.Enabled = false;
            }
            else
            {
                NovelCheckBox.Enabled = true;
                JournalCheckBox.Enabled = true;
            }
        }

        private void JournalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (JournalCheckBox.Checked == true)
            {
                NovelCheckBox.Enabled = false;
                ShortStoryCheckBox.Enabled = false;
            }
            else
            {
                NovelCheckBox.Enabled = true;
                ShortStoryCheckBox.Enabled = true;
            }
        }

        private void CreateBookButton_Click(object sender, EventArgs e)
        {
            if (JournalCheckBox.Checked)
            {
                Journal journal = new Journal(Title,Author,PublishedYear, true);
                Librarian.AddBook(journal);
                this.Close();
            }
            else if(ShortStoryCheckBox.Checked)
            {
                ShortStory shortStory = new ShortStory(Title, Author, PublishedYear, true);
                Librarian.AddBook(shortStory);
                this.Close();
            }
            else if (NovelCheckBox.Checked)
            {
                Novel novel = new Novel(Title, Author, PublishedYear, true);
                Librarian.AddBook(novel);
                this.Close();
            }
        }

        private void TitelTextBox_TextChanged(object sender, EventArgs e)
        {
            Title = TitelTextBox.Text;
        }

        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            Author = AuthorTextBox.Text;
        }

        private void PublishedYearTextBox_TextChanged(object sender, EventArgs e)
        {
            if(PublishedYearTextBox.Text.Length > 0)
            {
                try
                {
                    PublishedYear = Convert.ToInt32(PublishedYearTextBox.Text);
                }
                catch (Exception)
                {
                    PublishedYearTextBox.Text = null;
                    ErrorForm errorForm = new ErrorForm("Skriv bara in ett nummer!");                  
                    errorForm.ShowDialog();
                }
            }          
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
