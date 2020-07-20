using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory.ConcreteShapes
{
    public class Triangle : IAbstractShapeTriangle
    {
        public double GetArea(string l1, string l2, string l3)
        {
            throw new NotImplementedException();
        }

        public double GetPerimeter(string l1, string l2, string l3)
        {
            throw new NotImplementedException();
        }
    }
}
