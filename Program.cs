using System;

namespace abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var radio = 0.0;
            var baseRectangle = 0.0;
            var hrectangle = 0.0;
            var shapeFactory = new ShapeFactory();
            Console.WriteLine("Get Geometric Shape!");
            Console.WriteLine("1.Circle");
            Console.WriteLine("2.Rectangle");
            Console.WriteLine("3.Square");
            Console.WriteLine("4.Triangle");
            var shape = Console.ReadLine();
            object shapeObject = null;
            switch (shape)
            {
                case "1":
                    Console.WriteLine("write the radio's length in centimeters");
                    radio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area:");
                    Console.WriteLine(shapeFactory.CreateShapeCircle().GetArea(radio));
                    break;
                case "2":
                    Console.WriteLine("write the base's length in centimeters");
                    baseRectangle =double.Parse(Console.ReadLine());
                    Console.WriteLine("write the height's length in centimeters");
                    hrectangle = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area:");
                    Console.WriteLine(shapeFactory.CreateShapeRectangle().GetArea(baseRectangle, hrectangle));
                    break;
                case "4":
                    shapeObject = shapeFactory.CreateShapeTriangle();
                    break;
                default:
                    break;
            }

        }
    }
}
