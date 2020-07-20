using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory.ConcreteShapes
{
    public class Square : IAbstractShapeRectangle
    {
        public double GetArea(double l1, double l2)
        {
            return Math.Pow(l1, 2);
        }

        public double GetPerimeter(double l1, double l2)
        {
            throw new NotImplementedException();
        }
    }
}
