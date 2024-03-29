﻿// See https://aka.ms/new-console-template for more information
using Lab03_Home;
using System.Reflection.PortableExecutable;

List<Person> people = new List<Person>();


people.Add(new Person("Jan", "Nowak", 12));
people.Add(new Person("Janina", "Kowlaska", 14));
people.Add(new Person("Kacper", "Majka", 72));
people.Add(new Person("Nikodem", "Wikotr", 62));
people.Add(new Person("Jurek", "Kpaut", 53));


Book[] books = new Book[]
{
    new Book("Tytuł 1", people[0], new DateTime(2023,11,26)),
    new Book("Tytuł 2", people[1], new DateTime(2022,05,21)),
    new Book("Tytuł 3", people[2], new DateTime(2021,02,16)),
    new Book("Tytuł 4", people[3], new DateTime(2020,04,05))
};

List<Reviewer> reviewers = new List<Reviewer>();
reviewers.Add(new Reviewer("Bledi", "Boboci", 88));
reviewers.Add(new Reviewer("Luca", "Parmegiano", 76));



List<Reader> readers = new List<Reader>();
for (int i = 0; i < people.Count; i++)
{
    readers.Add(new Reader(people[i].FirstName, people[i].LastName, people[i].Age));
    if (i == 0)
        readers[i].Books = new Book[] { books[randInt()] };
    else if (i == 1)
        readers[i].Books = new Book[] { books[randInt()], books[randInt()] };
    else
        readers[i].Books = new Book[] { books[randInt()], books[randInt()], books[randInt()] };
}
Person o = new Reader(people[0].FirstName, people[0].LastName, people[0].Age);
o.View();


foreach (var item in readers)
{
    //item.ViewBook();
    item.View();
};
int randInt()
{
    Random random = new Random();
    return random.Next(books.Length);
};


for (int i = 0; i < reviewers.Count; i++)
{
    reviewers[i].Books = new Book[] { books[randInt()], books[randInt()], books[randInt()] };
};

foreach (var reviewer in reviewers)
{
    reviewer.ReviewBooks();
};


//foreach (Person person in people)
//{
//    person.View();
//};

//Person person = new Person("Jan", "Kowalski", 30);
//Book book = new Book("Tytul 1", person, new DateTime(2023, 11, 26));

//foreach (Book book in books)
//{
//    book.View();
//}


List<Person> Lista = people.Concat<Person>(readers).Concat<Person>(reviewers).ToList();

foreach (var person in Lista)
{
    person.View();
}