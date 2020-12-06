using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final_EDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> Pedidos = new Queue<int>();
            int opcion = 0;
            bool cola_creada = false;

            do
            {
                Console.WriteLine("Elija el numero correspondiente a la opcion que prefiere:\n" +
                "1.Crear Cola\n" +
                "2.Borrar Cola\n" +
                "3.Agregar Pedido\n" +
                "4.Borrar Pedido\n" +
                "5.Listar todos los Pedidos\n" +
                "6.Listar último Pedido\n" +
                "7.Listar primer Pedido\n" +
                "8.Cantidad de Pedido\n" +
                "9.Confirmacion de la existencia del Pedido\n" +
                "10.Saber cuantos pedidos hay antes\n" +
                "11.Salir\n");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Pedidos = new Queue<int>();
                        Console.WriteLine("Cola Creada\n");
                        cola_creada = true;
                        break;
                    case 2:
                        Pedidos.Clear();
                        Console.WriteLine("Cola Borrada\n");
                        cola_creada = false;
                        break;
                    case 3:
                        if (cola_creada)
                        {
                            string guardar = "s";
                            while (guardar == "s")
                            {
                                Console.WriteLine("Por favor, ingrese el nuevo elemento: \n");
                                int pedido = int.Parse(Console.ReadLine());
                                if (pedido > 0 && pedido < 999)
                                {
                                    Pedidos.Enqueue(pedido);
                                }
                                else
                                {
                                    Console.WriteLine("El elemento no se encuentra dentro del rango disponible");
                                    Console.ReadKey();
                                }
                                Console.WriteLine("Nuevo elemento agregado\n" +
                                    "Quiere agregar otro elemento? s/n");
                                guardar = Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("La cola aún no fue creada!\n");
                        }
                        break;
                    case 4:
                        int borrado = Pedidos.Dequeue();
                        Console.WriteLine("Se ha borrado el pedido " + borrado + " de la cola de Pedidos");
                        break;
                    case 5:
                        foreach (int n in Pedidos)
                            Console.Write("{0}\n", n);
                        Console.WriteLine();
                        break;
                    case 6:
                        int cont = 0;
                        int total = Pedidos.Count;
                        foreach (int i in Pedidos)
                            if (cont == (total - 1))
                            {
                                Console.WriteLine(i + " es el ultimo pedido de la cola");
                            }
                            else
                            {
                                cont++;
                            }
                        break;
                    case 7:
                        int valor1 = Pedidos.Peek();
                        Console.WriteLine(valor1 + " es el siguiente pedido");
                        break;
                    case 8:
                        int cantidad = Pedidos.Count();
                        Console.WriteLine("La cola tiene " + cantidad + " de pedidos");
                        break;
                    case 9:
                        Console.WriteLine("Ingrese el elemento que quiere confirmar: ");
                        int valor = int.Parse(Console.ReadLine());
                        if (Pedidos.Contains(valor))
                        {
                            Console.WriteLine("Ese pedido se encuentra dentro de la cola");
                        }
                        else
                        {
                            Console.WriteLine("Ese pedido no se encuentra dentro de la cola");
                        }
                        break;
                    case 10:
                        int count = 0;
                        Console.WriteLine("Ingrese el elemento que quiere confirmar: ");
                        int valor2 = int.Parse(Console.ReadLine());
                        foreach (int n in Pedidos)
                            if (n == valor2)
                            {
                                Console.WriteLine("Hay " + count + " pedidos antes que ese");
                            }
                            else
                            {
                                count++;
                            }
                        break;
                    case 11:
                        Console.WriteLine("¡Muchas gracias por utilizar este servicio!");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Esa Opcion no existe");
                        break;
                }
            } while (opcion != 11);
            Console.ReadLine();
        }
    }
}
