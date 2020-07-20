using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory
{
    interface IAbstractShapeTriangle
    {
        //Metodos para obtener area y perimetro de un triangulo
        double GetArea(string l1, string l2, string l3);
        double GetPerimeter(string l1, string l2, string l3);
    }
}
