using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory.ConcreteShapes
{
    public class Rectangle : IAbstractShapeRectangle
    {
        public double GetArea(double l1, double l2)
        {
            return l1 * l2;
        }

        public double GetPerimeter(double l1, double l2)
        {
            return 2 * (l1 + l2);
        }
    }
}
