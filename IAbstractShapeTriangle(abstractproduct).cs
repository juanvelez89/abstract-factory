using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory
{
    public interface IAbstractShapeTriangle
    {
        //Metodos para obtener area y perimetro de un triangulo
        double GetArea(double l1, double l2, double l3);
        double GetPerimeter(double l1, double l2, double l3);
    }
}
