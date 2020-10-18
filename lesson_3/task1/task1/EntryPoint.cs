using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(4);
            Console.WriteLine(circle.Perimetr());
            Console.WriteLine(circle.Square());

            Ellipse ellipse = new Ellipse(5, 3);
            Console.WriteLine(ellipse.Perimetr());
            Console.WriteLine(ellipse.Square());

            Foursquare foursquare = new Foursquare(4);
            Console.WriteLine(foursquare.Square());
            Rectangle rectangle = new Rectangle(3, 5);
            Console.WriteLine(rectangle.Square());
            Rhombus rhombus = new Rhombus(4, 5);
            Console.WriteLine(rectangle.Square());
            Console.WriteLine(foursquare.Square() + rectangle.Square() + rhombus.Square());

            CompoundFigure compoundFigure1 = new CompoundFigure(ellipse, circle);
            Console.WriteLine(compoundFigure1.Square());
            Console.WriteLine();
            CompoundFigure compoundFigure2 = new CompoundFigure(foursquare, rectangle, rhombus, circle);
            Console.WriteLine(compoundFigure2.Square());
        }
    }
}
