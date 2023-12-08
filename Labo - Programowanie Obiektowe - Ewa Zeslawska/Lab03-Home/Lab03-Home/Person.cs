using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Home
{
    internal class Person
    {
        private string firstname;
        string lastname;
        int age;

        public string FirstName { get { return firstname; } set {  firstname = value; } }
        public string LastName { get { return lastname; } set {  lastname = value; } }
        public int Age { get { return age; } set { age = value; } }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void View()
        {
            Console.WriteLine($"Imie: {FirstName}\tNazwisko: {LastName}\t Wiek: {Age}\t");
        }
    }
}
