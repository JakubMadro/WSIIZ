using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stwórz klasę Reader, dziedziczącą z klasy Person. Dodatkowo klasa Reader powinna posiadać pole –
//listę / tablicę obiektów typu Book - listę książek przeczytanych przez danego czytelnika oraz metodę
//ViewBook - wypisujące tytuły książek, które czytelnik przeczytał.


namespace Lab03_Home
{
    internal class Reader : Person
    {
        public Book[] Books { get; set; }

        public Reader(string firstname , string lastname, int age):base(firstname, lastname, age)
        {
            this.Books = Books;
        }

        public void View()
        {
            base.View();
            ViewBook();
        }

        public void ViewBook()
        {
            Console.WriteLine($"{FirstName} {LastName} przeczytał(a) następujące książki:");
            foreach (var book in Books)
            {
                Console.WriteLine(book.Title);
            }
        }

    }
}
