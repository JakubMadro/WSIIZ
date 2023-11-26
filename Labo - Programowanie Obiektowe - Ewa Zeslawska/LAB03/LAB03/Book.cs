using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB03
{
    internal class Book 
    {
        private string title;

        Person author;

        DateTime datePublication;

        public string Title
        {
            get { return title; }
            set { }
        }

        public Book(string title, Person author, DateTime datePublication)
        {
            this.title = title;
            this.author = author;
            this.datePublication = datePublication;
        }

        public void View()
        {
            Console.Write($"Tytul Książki: {Title}\tAutor:\t");
            author.View();
            Console.Write($"Data wydania: {datePublication.ToShortDateString()}\n");
        }
    }

}
