// See https://aka.ms/new-console-template for more information
using LAB03;
using System.ComponentModel.Design;

Person[] people = new Person[]
{
    new Person("Jan", "Nowak", 12),
    new Person("Janina", "Kowlaska", 14),
    new Person("Kacper", "Majka", 72),
    new Person("Nikodem", "Wikotr", 62),
    new Person("Jurek", "Kpaut", 53)
};



Book[] books = new Book[]
{
    new Book("Tytuł 1", people[0], new DateTime(2023,11,26)),
    new Book("Tytuł 2", people[1], new DateTime(2022,05,21)),
    new Book("Tytuł 3", people[2], new DateTime(2021,02,16)),
    new Book("Tytuł 4", people[3], new DateTime(2020,04,05))
};

Reader[] readers = new Reader[people.Length];
for (int i = 0; i < readers.Length; i++)
{
    readers[i] = new Reader(people[i].FirstName, people[i].LastName, people[i].Age);
    if (i == 0)
        readers[i].Books = new Book[] { books[randInt()] };
    else if (i == 1)
        readers[i].Books = new Book[] { books[randInt()], books[randInt()] };
    else
        readers[i].Books = new Book[] { books[randInt()], books[randInt()], books[randInt()] };
}
//wywołanie metody viewBook

foreach (var item in readers)
{
    item.ViewBook();
}

//metoda do losowania 

int randInt()
{
    Random random = new Random();
    return random.Next(books.Length);
}

//foreach (Book item in books)
//{
//    item.View();
//}