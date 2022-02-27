using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotekapplikationen
{
    class Book
    {
        public bool searchfound { get; set; }
        public string Titel;
        public string Author;
        public string Booktype;
        public int RealeseYear;
        public bool Available;

        virtual public string ToString() //Asså ja... Denna används ju aldrig. vet inte riktigt när den är bra
        {
            Console.WriteLine("Generic book");
            return "";
        }
    }
    class Novel : Book
    {
        /*
         Alla sub-klasser är likadana och behövs igentligen inte då ingen av de har några unika egenskaper än. 
        Men här får folket en beskrivning av vad det är ändå.
            Klasen startar med en constructor som ger huvudklassen info om vad alla varibler ska inneha som värden
            Klassen har en ToString metod som skriver ut alla info om alla värdena på variblerna. 
         */
        public Novel(string _titel, string _author, int realeseYear, bool _availeble)
        {

            Titel = _titel;
            Author = _author;
            Booktype = "Roman";
            RealeseYear = realeseYear;
            Available = _availeble;
        }
        override public string ToString()
        {
            Console.WriteLine($"{Titel}, en {Booktype} skriven av {Author} ({RealeseYear})");
            return $"{Titel}\nEn {Booktype} skriven av {Author} ({RealeseYear})";
        }
    }
    class Journal : Book
    {
        public Journal(string _titel, string _author, int realeseYear, bool _availeble)
        {
            Titel = _titel;
            Author = _author;
            Booktype = "Tidsskrift";
            RealeseYear = realeseYear;
            Available = _availeble;
        }
        override public string ToString()
        {
            Console.WriteLine($"{Titel}, en {Booktype} skriven av {Author} ({RealeseYear})");
            return $"{Titel}\nEn {Booktype} skriven av {Author} ({RealeseYear})";
        }
    }
    class ShortStory : Book
    {
        public ShortStory(string _titel, string _author, int realeseYear, bool _availeble)
        {
            Titel = _titel;
            Author = _author;
            Booktype = "Novel";
            RealeseYear = realeseYear;
            Available = _availeble;
        }

        override public string ToString()
        {
            Console.WriteLine($"{Titel}, en {Booktype} skriven av {Author} ({RealeseYear})");
            return $"{Titel}\nEn {Booktype} skriven av {Author} ({RealeseYear})";
        }
    }
}
