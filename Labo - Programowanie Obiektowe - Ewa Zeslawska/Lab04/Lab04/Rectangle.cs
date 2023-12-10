using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab04
{
    internal class Rectangle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine(Name + "\n");
            Console.WriteLine($"O wspołrzędnych ({X} {Y}) I bokach {Height} {Width})");
        }
    }
}
