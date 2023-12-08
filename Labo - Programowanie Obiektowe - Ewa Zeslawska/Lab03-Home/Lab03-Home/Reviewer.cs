using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Home
{
    internal class Reviewer : Reader
    {
        public Reviewer(string firstname, string lastname, int age) : base (firstname, lastname, age) { }

        public void ReviewBooks()
        {
            Console.WriteLine ($"Ocenione przez {FirstName} {LastName} :");
            foreach (var book in Books)
            {
                int rating = new Random().Next(1, 6);
                Console.WriteLine($" {book.Title}: Ocena {rating}");
            }
        }
    }
}
