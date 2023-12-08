using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Home
{
    internal class Book
    {
        protected private string title;
        protected Person author;
        protected DateTime datePublication;

        public string Title { get { return title; } set { } }

        public Book(string title, Person author, DateTime datePublication )
        {
            this.author = author;
            this.datePublication = datePublication;
            this.title = title;
        }

        public void View()
        {
            Console.Write($"Tytul Książki: {Title}\tAutor:\t");
            author.View();
            Console.Write($"Data wydania: {datePublication.ToShortDateString()}\n");
        }
    }
}
