using System;
using System.Collections.Generic;
using System.Text;
using abstract_factory.ConcreteShapes;

namespace abstract_factory
{
    public class ShapeFactory : IShapeFactory_abstractfactory_
    {


        public Circle CreateShapeCircle()
        {
            return new Circle();
        }

        public Rectangle CreateShapeRectangle()
        {
            return new Rectangle();
        }

        public Triangle CreateShapeTriangle()
        {
            return new Triangle();
        }
    }
}
