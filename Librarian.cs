using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Bibliotekapplikationen
{
    static class Librarian
    {
        static internal string currentPath = Environment.CurrentDirectory;
        
        /*
        * Allt är static eftersom det finns bara en bibliotekarie.
        */
        static private List<Book> librarianBooks = new List<Book>();
        static public void AddBook(Book book)
        {
            librarianBooks.Add(book);
        }
        static public void SearchForBooks()
        {

        }
        static public List<Book> PrintAllBooks()
        {
            return librarianBooks;
        }
        static public void EraseAllBooks()
        {
            librarianBooks.Clear();
        }
        static public void AddBooksFromFile()
        {
            string[] readText = File.ReadAllLines(currentPath + @"\TextFiles\OrginalText.txt");
            try
            {
                foreach (string line in readText)
                {
                    string[] splitString = line.Split("###");
                
                    switch (splitString[2])
                    {
                        case "Roman":
                            Novel novel = new Novel(splitString[0], splitString[1], 1999, Convert.ToBoolean(splitString[3]));
                            librarianBooks.Add(novel);
                            break;
                        case "Tidskrift":
                            Journal journal = new Journal(splitString[0], splitString[1], 1999, Convert.ToBoolean(splitString[3]));
                            librarianBooks.Add(journal);
                            break;
                        case "Novellsamling":
                            ShortStory shortStory = new ShortStory(splitString[0], splitString[1], 1999, Convert.ToBoolean(splitString[3]));
                            librarianBooks.Add(shortStory);
                            break;
                        default:
                            Console.WriteLine($"Error by (class)Librarian (method)AddBooksFromFile. Did not find {splitString[2]} ");
                            break;
                    }
                } 
            }
            catch (Exception)
            {
                ErrorForm errorForm = new ErrorForm("Filen Kunder inte hittas!");
                errorForm.ShowDialog();
            }
        }
    }
}
