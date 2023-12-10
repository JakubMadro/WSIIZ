using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Shape
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }


        public virtual void Draw()
        {
            Console.WriteLine("Rysuje krztałt");
        }
    }
}
