// See https://aka.ms/new-console-template for more information
using Lab04_Zadanie2;
using System;

Console.WriteLine("Hello, World!");

Osoba person = new Osoba();

person.SetFirstName("Maks");
person.SetLastName("Kmieć");
person.SetPesel("1501011233");



Console.WriteLine($"Imie i Nazwisko: {person.GetFullName()}");
Console.WriteLine($"Wiek: {person.GetAge()}");
Console.WriteLine($"Płeć: {person.GetGender()}");
Console.WriteLine($"Szkoła: {person.GetEducationInfo()}");
Console.WriteLine($"Czy może iśc sam do domu: {person.CanGoAloneToHome()}");
