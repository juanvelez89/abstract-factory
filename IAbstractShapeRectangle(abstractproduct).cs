using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory
{
    public interface IAbstractShapeRectangle
    {
        double GetArea(double l1, double l2);
        double GetPerimeter(double l1, double l2);
    }
}
