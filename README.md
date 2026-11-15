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

Capturas

 menu
 <img width="400" height="235" alt="image" src="https://github.com/user-attachments/assets/e67ea427-1f16-4238-9441-7ecbf7ba08f4" />

 opcion 1
 <img width="424" height="378" alt="image" src="https://github.com/user-attachments/assets/6366a73e-a150-4ddd-9d46-c48b99c60c0e" />

 opcion 2
 <img width="383" height="324" alt="image" src="https://github.com/user-attachments/assets/5bc8d6d8-cd4c-4200-b230-6ec4885e835a" />

 opcion 3
 <img width="587" height="125" alt="image" src="https://github.com/user-attachments/assets/908ff26c-5929-472d-9523-fb5cf3e21a6f" />

opcion 4
<img width="617" height="365" alt="image" src="https://github.com/user-attachments/assets/2dd11db4-86c0-49b5-b24e-3ea2631efd22" />

opcion 5
<img width="603" height="341" alt="image" src="https://github.com/user-attachments/assets/1d5997c6-636e-4203-8164-07e0e0e1a6e2" />

opcion 6
<img width="400" height="419" alt="image" src="https://github.com/user-attachments/assets/0a0670fa-13c3-4e6c-912f-b60e1ca3d4d0" />



 
