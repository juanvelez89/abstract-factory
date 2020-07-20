using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory.ConcreteShapes
{
    public class Circle : IAbstractShapeCircle
    {
        public double GetArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public double GetPerimeter(string r)
        {
            throw new NotImplementedException();
        }
    }
}
