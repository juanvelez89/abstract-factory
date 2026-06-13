using System;

namespace abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = new ShapeFactory();
            Console.WriteLine("Get Geometric Shape!");
            Console.WriteLine("1.Circle");
            Console.WriteLine("2.Rectangle");
            Console.WriteLine("3.Square");
            Console.WriteLine("4.Triangle");
            var shape = Console.ReadLine();
            switch (shape)
            {
                case "1":
                    Console.WriteLine("write the radio's length in centimeters");
                    var radio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area:");
                    Console.WriteLine(shapeFactory.CreateShapeCircle().GetArea(radio));
                    Console.WriteLine("Perimeter:");
                    Console.WriteLine(shapeFactory.CreateShapeCircle().GetPerimeter(radio));
                    break;
                case "2":
                    Console.WriteLine("write the base's length in centimeters");
                    var baseRectangle = double.Parse(Console.ReadLine());
                    Console.WriteLine("write the height's length in centimeters");
                    var hRectangle = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area:");
                    Console.WriteLine(shapeFactory.CreateShapeRectangle().GetArea(baseRectangle, hRectangle));
                    Console.WriteLine("Perimeter:");
                    Console.WriteLine(shapeFactory.CreateShapeRectangle().GetPerimeter(baseRectangle, hRectangle));
                    break;
                case "3":
                    Console.WriteLine("write the side's length in centimeters");
                    var side = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area:");
                    Console.WriteLine(new ConcreteShapes.Square().GetArea(side, side));
                    Console.WriteLine("Perimeter:");
                    Console.WriteLine(new ConcreteShapes.Square().GetPerimeter(side, side));
                    break;
                case "4":
                    Console.WriteLine("write the length of side 1 in centimeters");
                    var l1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("write the length of side 2 in centimeters");
                    var l2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("write the length of side 3 in centimeters");
                    var l3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area:");
                    Console.WriteLine(shapeFactory.CreateShapeTriangle().GetArea(l1, l2, l3));
                    Console.WriteLine("Perimeter:");
                    Console.WriteLine(shapeFactory.CreateShapeTriangle().GetPerimeter(l1, l2, l3));
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
