using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB03
{
    internal class Person
    {
        private string fistname;
        private string lastname;
        private int age;
        //wlasciwosci pól

        public string FirstName { get { return fistname; } set {  fistname = value; } }
        public string LastName { get { return lastname; } set {  lastname = value; } }

        public int Age { get { return age;} set { age = value; } }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void View()
        {
            Console.WriteLine($"Imie: {FirstName}" +
                $"\tNazwisko: {LastName}\t Wiek: {Age}");
        }
        public void View1()
        {
            Console.WriteLine($"Imie: {FirstName}" +
                $"\tNazwisko: {LastName}");
        }
    }
}
