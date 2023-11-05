using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Licz
    {
        public double value;
        private double dodaj(double d)
        {
            return value += d;
        }
        private double odejmij(double d)
        {
            return value -= d;
        }
        public void view(double a)
        {
            Console.WriteLine($"Wartosc poczatkowa: \t{value}" +
                 $"\nWartosc po dodaniu: \t{dodaj(a)}" +
                 $"\nWartosc po odjeciu: \t{odejmij(a)}");
        }
    }
}
