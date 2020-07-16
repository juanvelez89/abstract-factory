# abstract-factory
Este es el ejemplo práctico del patrón de diseño abstract factory en c# y una corta explicación en lo que consiste.

Basado en el libro:
#### Design Patterns Eelements of reusable Object-Oriented Software de Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides.

## Definición
Es un patrón de diseño creacional el cual provee una interfaz para crear familias de objetos relacionados o dependientes sin especificar la clase en concreto.

## Aplicabilidad
El patrón abstract factory debería usarse cuando el sistema debe ser independiente de cómo sus objetos son creados, compuestos y representados y cuando el sistema debe ser configurado con uno de las múltiples familias de objetos.

## Participantes en el patrón

### AbstractFactory
Declara una interfaz para las operaciones que crean los objetos abstractos.

### ConcreteFactory
Implementa las operaciones de AbstractFactory que crean los objetos concretos.

### AbstractProduct
Declara una interfaz por un tipo de objeto.

### ConcreteProduct
Define un objeto para ser creado por su correspondiente ConcreteFactory e implementa la interfaz de AbstractProduct.

### Client
usa solamente las interfaces declaradas por AbstractFactory y AbstractProduct
