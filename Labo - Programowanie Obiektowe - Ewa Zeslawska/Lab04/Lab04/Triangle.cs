using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab04
{
    internal class Triangle : Shape
    {
        //string name = "Trójkąt"
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine(Name + "\n");
            Console.WriteLine($"O wspołrzędnych ({X} {Y}) I promieniu {Height})");
        }
    }
}
