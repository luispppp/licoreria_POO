using System;
class Detallesproducto{
    public void Mostrardetalles(){
         Console.Clear();
            Console.Write(
                "================================================" +
                "\n\n\n" +
                "                  LICORES                \n\n\n" +
                "================================================" +
                "\n\n\n" +
                "     ¡Bienvenido, estamos para ayudarte! \n\n\n" +
                "===============================================\n");
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.Write(
                "================================================" +
                "\n\n\n" +
                "          Detalles de los productos       \n\n\n" +
                "\n\n\n" +
                "===============================================\n");
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();
            Console.Clear();
            int opcion = 0;
            do
            {
                Console.WriteLine("Selecione el producto del que desea saber sus detalles:");
                Console.WriteLine("\n" +
                    "\n 1.-  Cerveza" +
                    "\n 2.-  Vodka" +
                    "\n 3.-  Aguardiente" +
                    "\n 4.-  Caña" +
                    "\n 5.-  Continuar sin verificar detalles de los productos \n");
                Console.WriteLine("Digite una opción :");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                    Console.Clear();
                    Console.WriteLine("Detalles de la Cerveza");
                    Console.WriteLine(
                    "\n Porcentaje de alcohol: 5%" +
                    "\n Precio: $2.00" +
                    "\n ID: 001");
                    Console.WriteLine("\n Presione enter para regresar");
                    Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                    Console.WriteLine("Detalles del Vodka");
                    Console.WriteLine(
                    "\n Porcentaje de alcohol: 34%" +
                    "\n Precio: $7.00" +
                    "\n ID: 002");
                    Console.WriteLine("\n Presione enter para regresar");
                    Console.ReadKey();
                        break;
                    case 3:
                    Console.Clear();
                    Console.WriteLine("Detalles del Aguardiente");
                    Console.WriteLine(
                    "\n Porcentaje de alcohol: 24%" +
                    "\n Precio: $1.00" +
                    "\n ID: 003");
                    Console.WriteLine("\n Presione enter para regresar");
                    Console.ReadKey();
                        break;
                    case 4:
                    Console.Clear();
                    Console.WriteLine("Detalles de la Caña");
                    Console.WriteLine(
                    "\n Porcentaje de alcohol: 29%" +
                    "\n Precio: $5.00" +
                    "\n ID: 004");
                    Console.WriteLine("\n Presione enter para regresar");
                    Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("La búsqueda ha sido cancelada, continúe con su compra");
                        break;
                    default:
                        break;
                }
            } while (opcion != 5);
    }
}