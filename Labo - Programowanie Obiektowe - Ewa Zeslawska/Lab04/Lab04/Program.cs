// See https://aka.ms/new-console-template for more information

using Lab04;

List <Shape> shapes= new List<Shape> ();
Circle circle = new Circle { Name = "Kolo", X = 0, Y = 2, Height = 10 };
Rectangle rectangle = new Rectangle { Name = "Prostokąt", X=2,Y=2, Width = 23, Height=23 };
Triangle triangle = new Triangle { Name = "Trojkat", X = 2, Y= 34, Width = 23, Height = 14 };

shapes.Add (circle);
shapes.Add (rectangle);
shapes.Add (triangle);
foreach (Shape shape in shapes)
{
    shape.Draw(); Console.WriteLine();
}