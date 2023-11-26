using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB03
{
    internal class Reader : Person
    {
        public Book[] Books { get; set; }

        public Reader(string firstname, string lastname, int age):base(firstname,lastname,age)
        { 
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
