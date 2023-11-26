// See https://aka.ms/new-console-template for more information
using LAB03;




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

foreach (Book item in books)
{
    item.View();
}