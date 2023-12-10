using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Zadanie2
{
    internal class Osoba
    {
        public string Imie;
        public string Nazwisko;
        public string Pesel;

        public void SetFirstName(string firstName)
        {
            Imie = firstName;
        }

        public void SetLastName(string lastName)
        {
            Nazwisko = lastName;
        }
        public void SetPesel(string pesel)
        {
            Pesel = pesel;
        }

        public int GetAge()
        {
            int birtYear = int.Parse(Pesel.Substring(0, 2));
            int currentYear = DateTime.Now.Year;
            int age = currentYear - (birtYear+1900 +100);
            return age;
        }
        public string GetGender()
        {

            if (Pesel[9] % 2 == 0)
            {
                return "Female";
            }
            else
            {
                return "Male";
            }
        }

        public string GetFullName()
        {
            return $"{Imie} {Nazwisko}";
        }

        public bool CanGoAloneToHome()
        {
            if (GetAge() < 12)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string GetEducationInfo()
        {
            int age = GetAge();

            if (age < 7)
            {
                return "Przedszkole";
            }
            else if (age < 16)
            {
                return "Podstawówka";
            }
            else if (age < 19)
            {
                return "Średnia";
            }
            else
            {
                return "Student";
            }
        }
    }
}
