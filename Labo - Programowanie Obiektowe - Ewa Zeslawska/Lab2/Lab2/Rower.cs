using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Rower
    {
        //pola klasy 
        String typRoweru, kolor, rozmiarRamy;
        public int iloscBiegow;
        double v = 0;

        public void View()
        {
            Console.WriteLine($"Typ Roweru: \t{typRoweru}" +
                $"\nKolor: \t{kolor}" +
                $"\nRozmiar Ramy: \t{rozmiarRamy}" +
                $"\nIlość Biegów: \t{iloscBiegow}" +
                $"\nPrednosc: \t{v}");
        }
        public double predkoscJazdy(double predkosc)
        {
            return v += predkosc;
        }

        public Rower(string typRoweru, string kolor, string rozmiarRamy, int iloscBiegow, double v)
        {
            this.typRoweru = typRoweru;
            this.kolor = kolor;
            this.rozmiarRamy = rozmiarRamy;
            this.iloscBiegow = iloscBiegow;
            this.v = v;
        }
    }
}
