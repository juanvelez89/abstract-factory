using System;
using System.Collections.Generic;
using System.Text;
using abstract_factory.ConcreteShapes;

namespace abstract_factory
{
    public class ShapeFactory : IShapeFactory_abstractfactory_
    {
        public IAbstractShapeCircle CreateShapeCircle()
        {
            return new Circle();
        }

        public IAbstractShapeRectangle CreateShapeRectangle()
        {
            return new Rectangle();
        }

        public IAbstractShapeTriangle CreateShapeTriangle()
        {
            return new Triangle();
        }
    }
}
