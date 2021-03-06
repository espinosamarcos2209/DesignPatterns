# Design patterns o patrones de diseño

## Descripción de los patrones de diseño 
Hemos decidido describir los patrones de diseño con ayuda de los siguientes lenguajes: 

* El lenguaje de modelización UML introducido por el OMG (http://www.omg.org). 
* El lenguaje de programación C# .Net core (https://dotnet.github.io/). 


## Catálogo de patrones de diseño 

En este libro se presentan los veintitrés patrones de diseño descritos en el libro de
referencia del "GoF". Estos patrones son diversas respuestas a problemas conocidos de
la programación orientada a objetos. La lista que sigue no es exhaustiva y es resultado,
como hemos explicado, de la experiencia. 

### Abstract Factory: 
tiene como objetivo la creación de objetos reagrupados en
familias sin tener que conocer las clases concretas destinadas a la creación de
estos objetos. 

### Builder: 
permite separar la construcción de objetos complejos de su
implementación de modo que un cliente pueda crear estos objetos complejos con
implementaciones diferentes. 
### Factory Method: 
tiene como objetivo presentar un método abstracto para la
creación de un objeto reportando a las subclases concretas la creación efectiva. 
### Prototype: 
permite crear nuevos objetos por duplicación de objetos existentes
llamados prototipos que disponen de la capacidad de clonación. 
### Singleton: 
permite asegurar que de una clase concreta existe una única
instancia y proporciona un método único que la devuelve. 
### Adapter: 
tiene como objetivo convertir la interfaz de una clase existente en la
interfaz esperada por los clientes también existentes para que puedan trabajar de
forma conjunta. 
### Bridge:
tiene como objetivo separar los aspectos conceptuales de una jerarquía
de clases de su implementación. 
### Composite: 
proporciona un marco de diseño de una composición de objetos con
una profundidad de composición variable, basando el diseño en un árbol. 
### Decorator: 
permite agregar dinámicamente funcionalidades suplementarias a un
objeto. 
### Facade: 
tiene como objetivo reagrupar las interfaces de un conjunto de objetos
en una interfaz unificada que resulte más fácil de utilizar. 
### Flyweight: 
facilita la compartición de un conjunto importante de objetos con
granularidad muy fina. 
### Proxy: 
construye un objeto que se substituye por otro objeto y que controla su
acceso. 
### Chain of responsibility: 
crea una cadena de objetos tal que si un objeto de la
cadena no puede responder a una petición, la pueda transmitir a sus sucesores
hasta que uno de ellos responda. 
### Command: 
tiene como objetivo transformar una consulta en un objeto,
facilitando operaciones como la anulación, la actualización de consultas y su
seguimiento. 
### Interpreter: 
proporciona un marco para dar una representación mediante
objetos de la gramática de un lenguaje con el objetivo de evaluar,
interpretándolas, expresiones escritas en este lenguaje. 
### Iterator: 
proporciona un acceso secuencial a una colección de objetos sin que
los clientes se preocupen de la implementación de esta colección. 
### Mediator: 
construye un objeto cuya vocación es la gestión y el control de las
interacciones en el seno de un conjunto de objetos sin que estos elementos se
conozcan mutuamente. 
### Memento: 
salvaguarda y restaura el estado de un objeto. 
### Observer: 
construye una dependencia entre un sujeto y sus observadores de
modo que cada modificación del sujeto sea notificada a los observadores para
que puedan actualizar su estado. 
### State: 
permite a un objeto adaptar su comportamiento en función de su estado
interno. 
### Strategy: 
adapta el comportamiento y los algoritmos de un objeto en función de
una necesidad concreta sin por ello cargar las interacciones con los clientes de
este objeto. 
### Template Method: 
permite reportar en las subclases ciertas etapas de una de las
operaciones de un objeto, estando éstas descritas en las subclases. 
### Visitor: 

construye una operación a realizar en los elementos de un conjunto de
objetos. Es posible agregar nuevas operaciones sin modificar las clases de estos
objetos. 


# Organización del catálogo de patrones de diseño 
Para organizar el catálogo de patrones de diseño, retomamos la clasificación del "GoF"
que organiza los patrones según su vocación: construcción, estructuración y
comportamiento. 

## Los patrones de construcción 
tienen como objetivo organizar la creación de objetos. Se describen en la parte 2 - Patrones de contrucción. Son un total de cinco: Abstract Factory, Builder, Factory Method, Prototype y Singleton. 

## Los patrones de estructuración 
facilitan la organización de la jerarquía de clases y de sus relaciones. Se describen en la parte 3 - Patrones de estructuración. Son un total de siete: Adapter, Bridge, Composite, Decorator, Facade, Flyweight y Proxy. 

## Los patrones de comportamiento 
proporcionan soluciones para organizar las interacciones y para repartir el procesamiento entre los objetos. Se describen en la parte 4- Patrones de comportamiento. Son un total de once: Chain of responsibility, Command, Interpreter, Iterator, Mediator, Memento, Observer, State, Strategy, Template Method y Visitor. 
 
 
 # Caso de Estudio Venta Online de vehiculos 
## Descripción del sistema 
En este libro tomaremos un ejemplo de diseño de un sistema para ilustrar el uso de los
veintitrés patrones de diseño. 
El sistema que vamos a diseñar es un sitio web de venta online de vehículos como, por
ejemplo, automóviles o motocicletas. Este sistema autoriza distintas operaciones como
la visualización de un catálogo, la recogida de un pedido, la gestión y el seguimiento de
los clientes. Además estará accesible bajo la forma de un servicio web. 
## Cuaderno de carga 
El sitio permite visualizar un catálogo de vehículos puestos a la venta, realizar
búsquedas en el catálogo, realizar el pedido de un vehículo, seleccionar las opciones
para el mismo mediante un sistema de carro de la compra virtual. Las opciones
incompatibles también deben estar gestionadas (por ejemplo "asientos deportivos" y
"asientos en cuero" son opciones incompatibles). También es posible volver a un estado
anterior del carro de la compra. 
El sistema debe administrar los pedidos. Debe ser capaz de calcular los impuestos en
función del país de entrega del vehículo. También debe gestionar los pedidos pagados al
contado y aquellos que están ligados a una petición de crédito. Para ello, se tendrá en
cuenta las peticiones de crédito. El sistema administra los estados del pedido: en curso,
validado y entregado. 
Al realizar el pedido de un vehículo, el sistema construye el conjunto de documentos
necesarios como la solicitud de matriculación, el certificado de cesión y la orden de
pedido. Estos documentos estarán disponibles en formato PDF o en formato HTML. 
El sistema también permite rebajar los vehículos de difícil venta, como por ejemplo
aquellos que se encuentran en stock pasado un tiempo. 
También permite realizar una gestión de los clientes, en particular de empresas que
poseen filiales para proporcionarles, por ejemplo, la compra de una flota de vehículos. 
Tras la virtualización del catálogo, es posible visualizar animaciones asociadas a un
vehículo. El catálogo puede presentarse con uno o tres vehículos por cada línea de
resultados. 

La búsqueda en el catálogo puede realizarse con ayuda de palabras clave y de
operadores lógicos (y, o). 
Es posible acceder al sistema mediante una interfaz web clásica o a través de un sistema
de servicios web. 
## Uso de patrones de diseño 
Para cumplir con los distintos requisitos expresados en el cuaderno de carga,
utilizaremos en los siguientes capítulos los patrones de diseño. Se tomarán en cuenta en
las siguientes partes de la concepción del sitio web: 

Descripción de la sección /#/ 
### Patrón de diseño 
----------------------------
Construir los objetos de dominio (coche de gasolina,
coche diesel, coche eléctrico, etc.). 
### Abstract Factory 
 ----------------------------
Construir los conjuntos de documentos necesarios en
caso de comprar un vehículo. 
### Builder, Prototype 
----------------------------
Crear los pedidos. 
### Factory Method 
----------------------------
Crear el conjunto en blanco de los documentos.  
### Singleton 
----------------------------
Gestionar los documentos PDF. 
### Adapter 
----------------------------
Implementar los formularios en HTML o mediante un
applet.
### Bridge 
----------------------------
Representar las empresas clientes. 
### Composite 
----------------------------
Visualizar los vehículos del catálogo. 
### Decorator, Observer, Strategy 
----------------------------
Proporcionar la interfaz mediante servicios web del
sitio.
### Facade 
----------------------------
Administrar las opciones de un vehículo en un pedido. 
### Flyweight, Memento
----------------------------
Administrar la visualización de animaciones para cada
vehículo del catálogo.
### Proxy 
----------------------------
Administrar la descripción de un vehículo. 
### Chain of responsibility 
----------------------------
Rebajar los vehículos en stock pasado un periodo
determinado.
### Command 
----------------------------
Realizar búsquedas en la base de vehículos mediante
una búsqueda escrita en forma de expresión lógica.
### Interpreter 
----------------------------
Devolver secuencialmente los vehículos del catálogo. 
### Iterator
----------------------------
Gestionar el formulario de una solicitud de crédito. 
### Mediator
----------------------------
Gestionar los estados de un pedido. 
### State 
----------------------------
Calcular el importe de un pedido. 
### Template Method 
----------------------------
Enviar propuestas comerciales por correo electrónico a
ciertas empresas clientes.
### Visitor 
----------------------------

Patrones de diseño para C#
Los 23 modelos de diseño: descripción y soluciones ilustradas en UML 2 y C#

Dirigido a aquellos diseñadores y desarrolladores que trabajen con Programación Orientada a Objetos. Para comprenderlo bien, es preferible tener conocimientos previos de los principales elementos de los diagramas de clases UML y la última versión del lenguaje C# (a partir de la versión 3.0).
