using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory.ConcreteShapes
{
    public class Triangle : IAbstractShapeTriangle
    {
        public double GetArea(double l1, double l2, double l3)
        {
            // Fórmula de Herón
            double s = (l1 + l2 + l3) / 2;
            return Math.Sqrt(s * (s - l1) * (s - l2) * (s - l3));
        }

        public double GetPerimeter(double l1, double l2, double l3)
        {
            return l1 + l2 + l3;
        }
    }
}
