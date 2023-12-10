using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Circle : Shape
    {
        string name = "Kolo";

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine(name+ "\n");
            Console.WriteLine($"O wspołrzędnych ({X} {Y}) I promieniu {Height})");
        }

        
    }
}
