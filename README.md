# DESARROLLO-DE-APLICACIONES-GESTION-DE-LISTAS

Descripción del programa

El programa Gestión de Productos es una aplicación de consola desarrollada en C# que permite administrar una lista de productos y sus respectivos precios.

Este sistema permite registrar, buscar, modificar y eliminar productos, así como mostrar estadísticas y ordenar la lista alfabéticamente.

Entrada

- opcion
- producto
- precio
- buscando
- productoAntiguo
- productoNuevo
- productoEliminar

  Proceso

El programa realiza las siguientes operaciones:

1. Agregar productos

Solicita el nombre y el precio del producto. Luego, almacena ambos datos en sus respectivas listas utilizando el método Add().

2. Mostrar productos

Recorre las listas mediante un ciclo for y muestra los nombres de los productos junto con sus precios. También comprueba si existen productos registrados utilizando Count.

3. Buscar productos

Solicita el nombre del producto y utiliza Contains() para comprobar si se encuentra registrado en la lista.

4. Modificar productos

Comprueba si el producto existe mediante Contains(). Después, utiliza IndexOf() para localizar su posición y reemplazar el nombre anterior por el nuevo mediante su índice.

5. Eliminar productos

Comprueba si el producto existe y utiliza Remove() para eliminarlo de la lista.

6. Mostrar estadísticas

Calcula la cantidad total de productos, el precio menor, el precio mayor y el promedio de los precios registrados.

Para realizar estos cálculos utiliza ciclos foreach, acumuladores y condiciones if.

7. Ordenar lista

Utiliza el método Sort() para organizar alfabéticamente los nombres de los productos.

8. Salir

Finaliza la ejecución del programa cuando el usuario selecciona la opción correspondiente.


Salida

El programa muestra los resultados de las operaciones realizadas:

Confirmación de productos agregados.

Lista de productos registrados con sus respectivos precios.

Mensajes indicando si un producto fue encontrado o no.

Confirmación de productos modificados.

Confirmación de productos eliminados.

Estadísticas generales de los productos.

Lista ordenada alfabéticamente.

Mensaje de salida del programa.

Tecnologías aplicadas
- C#
- Visual Studio Community
- .NET




  <img width="472" height="168" alt="image" src="https://github.com/user-attachments/assets/776bf1a7-efb5-43f9-a178-6dc6da971250" />
