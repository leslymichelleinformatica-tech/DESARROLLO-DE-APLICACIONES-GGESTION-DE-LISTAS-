using System;
using System.Collections.Generic;

namespace GestionLista
{
    internal class Program
    {
        static List<string> productos = new List<string>();

        static List<double> precios = new List<double>();

        static void Main(string[] args)
        {
            int opcion = 0;

            while (opcion != 8)
            {
                Console.WriteLine("=== Menu de opciones ===");
                Console.WriteLine("1. Agregar un producto");
                Console.WriteLine("2. Mostrar todos los producto");
                Console.WriteLine("3. Buscar un producto");
                Console.WriteLine("4. modificar un producto");
                Console.WriteLine("5. Eliminar un producto");
                Console.WriteLine("6. Mostrar estadisticas");
                Console.WriteLine("7. Ordenar lista");
                Console.WriteLine("8. salir");

                Console.WriteLine("Elija una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarProductos();
                        break;
                    case 2:
                        MostrarProductos();
                        break;
                    case 3:
                        BuscarProducto();
                        break;
                    case 4:
                        ModificarProducto();
                        break;
                    case 5:
                        EliminarProducto();
                        break;
                    case 6:
                        MostrarEstadistica();
                        break;
                    case 7:
                        OrdenarLista();
                        break;
                    case 8:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida. Intente nuevamente.");
                        break;
                }
            }
        }


        static void AgregarProductos()
        {
            Console.WriteLine("Ingrese el nombre del producto:");
            string producto = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del producto:");
            double precio = Convert.ToDouble(Console.ReadLine());

            productos.Add(producto);
            precios.Add(precio);

            Console.WriteLine("Producto agregado correctamente.");
        }

        static void MostrarProductos()
        {

            Console.WriteLine("Lista de productos:");
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos registrados");
                return;
            }

            for (int i = 0; i < productos.Count; i++)
            {
                Console.WriteLine(productos[i] + " - " + precios[i]);
            }
        }

        static void BuscarProducto()
        {
            Console.WriteLine("Ingrese el nombre del producto que desea buscar:");
            string buscando = Console.ReadLine();

            if (productos.Contains(buscando))
            {
                Console.WriteLine("El producto '" + buscando + "' se encuentra en la lista.");
            }
            else
            {
                Console.WriteLine("El producto '" + buscando + "' no se encuentra en la lista.");
            }
        }

        static void ModificarProducto()
        {
            Console.WriteLine("Ingrese el nombre del producto que desea modificar:");

            string productoAntiguo = Console.ReadLine();

            if (productos.Contains(productoAntiguo))
            {
                Console.WriteLine("Ingrese el nuevo nombre del producto:");
                string productoNuevo = Console.ReadLine();
                int index = productos.IndexOf(productoAntiguo);
                productos[index] = productoNuevo;
                Console.WriteLine("Producto modificado correctamente.");
            }
            else
            {
                Console.WriteLine("El producto '" + productoAntiguo + "' no se encuentra en la lista.");
            }
        }


        static void EliminarProducto()
        {
            Console.WriteLine("Ingrese el nombre del producto que desea eliminar:");
            string productoEliminar = Console.ReadLine();

            if (productos.Contains(productoEliminar))
            {
                productos.Remove(productoEliminar);
                Console.WriteLine("Producto eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("El producto '" + productoEliminar + "' no se encuentra en la lista.");
            }
        }

        static void MostrarEstadistica()
        {
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos  registrados");
                return;
            }

            double suma = 0;
            double mayor = precios[0];
            double menor = precios[0];

            foreach (double precio in precios)
            {
                suma += precio;

                if (precio < menor)
                {
                    menor = precio;
                }

                if (precio > mayor)
                {
                    mayor = precio;
                }
            }

            double promedio = (double)suma / precios.Count;

            Console.WriteLine("\n=== ESTADISTICAS ===");
            Console.WriteLine("Total de PRODUCTOS " + productos.Count);
            Console.WriteLine("Precio menor: " + mayor);
            Console.WriteLine("Precio mayor: " + menor);
            Console.WriteLine("Promedio de los productos: " + promedio);
        }

        static void OrdenarLista()
        {
            productos.Sort();
            Console.WriteLine("Lista de productos ordenada ");
        }
    }
}