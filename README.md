En este repositorio se almacena una pequeña demostraci{on de lo que puede ser un carrito de compras, con una Base de Datos SQL Server y la tecnología MVC 5 de ASP.NET con el Lenguaje de programación C#.

Patrón de arquitectura
Expresa un esquema de organización estructural para una aplicación, teniendo así un nivel de abstracción alto.

MVC
Patrón de arquitectura que separa los datos de la aplicación, la interfaz de usuario y la lógica de control en tres componentes distintos, modelo-vistacontrolador.

¿Por qué MVC?
Probablemente hayas llegado a este punto porque desea informarse o aclarar sus dudas sobre si vale la pena incorporar MVC a sus proyectos de una aplicación ASP.NET, o 
también es posible que conozca el patrón MVC porque lo haya usado en otro lenguaje, como puede ser Java o PHP, y le interese saber si funciona igual en 
.NET, de cualquier forma, las ventajas de utilizarlo en un lenguaje u otro son prácticamente las mismas.

Entonces, ¿Cuáles son las ventajas de utilizarlo en ASP .NET?
La primera de todas y por ello más importante, es la facilidad que nos aporta a nosotros, como desarrolladores que somos, administrar una aplicación web 
compleja teniéndola dividida en tres pilares fundamentales (modelo, vista, controlador, como ya comentamos antes).
La segunda ventaja es el uso de un “FrontController” que procesa todas las solicitudes a nuestra aplicación. Esto permite diseñar una infraestructura con un 
sistema de enrutamiento avanzado.
Otra ventaja también muy importante es su funcionamiento para aplicaciones web en las que trabajan grandes equipos formados por desarrolladores y 
diseñadores. Al tener la vista completamente separada de la lógica, unos no “interfieren” en las tareas de los otros.

Frente a los WebForms 
MVC tiene un par de ventajas, la primera de ellas es que no utiliza formularios de servidor con lo cual el desarrollador tiene mucho mayor control sobre la aplicación, la otra ventaja es que tampoco utiliza los “ViewState”, consiguiendo así ahorrar notablemente en el ancho de banda consumido.

ING. GUILLERMO ANTONIO PÉREZ
