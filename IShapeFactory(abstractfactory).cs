using abstract_factory.ConcreteShapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory
{
    public interface IShapeFactory_abstractfactory_
    {
        //Métodos de fabrica de figuras geometricas los cuales devuelven objetos de tipo: circulo, triangulo o rectangulo.
         IAbstractShapeCircle CreateShapeCircle();
         IAbstractShapeTriangle  CreateShapeTriangle();
         IAbstractShapeRectangle CreateShapeRectangle();
    }
}
