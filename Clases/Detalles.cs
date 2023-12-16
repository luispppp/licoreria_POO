using _3POO_Licoreria.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3POO_Licoreria.Clases
{
    class Detalles:DatosUsuario
    {
        public static Clases.Factura nuevafactura = new Clases.Factura();
        public override string Nombre => throw new NotImplementedException();
        public override string Apellido => throw new NotImplementedException();
        public override string CédulaoRuc => throw new NotImplementedException();
        public override string Domicilio => throw new NotImplementedException();
        public override string Descripcion => throw new NotImplementedException();
        public static void Lista(string opcion)
        {
            if (opcion == "1")
            {
                int opciones;
                int cantidad = 0;
                Console.WriteLine("¿Cuántas desea?");
                cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Usted ha comprado " + cantidad + " botellas de cerveza.\n");
                do
                {
                    Console.WriteLine("================================" +
                    "\n1. Finalizar compra. Podrá acceder a su extra");
                    opciones = int.Parse(Console.ReadLine());
                    if (opciones== 1)
                    {
                        nuevafactura.Sumarafactura(cantidad, opcion);
                        nuevafactura.Facturafinal();
                    }
                    else if (opciones > 1 || opciones < 1)
                    {
                        Console.WriteLine("La opción que ingresó (" + opciones + ") no existe, por favor, intente de nuevo.\n");
                    }
                } while (opciones > 1 || opciones < 1);
            }
            else if (opcion == "2")
            {
                int opciones;
                int cantidad = 0;
                Console.WriteLine("¿Cuántas desea?");
                cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Usted ha comprado " + cantidad + " botellas de vodka.\n");
                do
                {
                    Console.WriteLine("================================" +
                    "\n1. Finalizar compra. Podrá acceder a su extra");
                    opciones = int.Parse(Console.ReadLine());
                    if (opciones == 1)
                    {
                        nuevafactura.Sumarafactura(cantidad, opcion);
                        nuevafactura.Facturafinal();
                    }
                    else if (opciones > 1 || opciones < 1)
                    {
                        Console.WriteLine("La opción que ingresó (" + opciones + ") no existe, por favor, intente de nuevo.\n");
                    }
                } while (opciones > 1 || opciones < 1);
            }
            else if (opcion == "3")
            {
                int opciones;
                int cantidad = 0;
                Console.WriteLine("¿Cuántas desea?");
                cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Usted ha comprado " + cantidad + " botellas de aguardiente.\n");
                do
                {
                    Console.WriteLine("================================" +
                     "\n1. Finalizar compra. Podrá acceder a su extra");
                    opciones = int.Parse(Console.ReadLine());
                    if (opciones == 1)
                    {
                        nuevafactura.Sumarafactura(cantidad, opcion);
                        nuevafactura.Facturafinal();
                    }
                    else if (opciones > 1 || opciones < 1)
                    {
                        Console.WriteLine("La opción que ingresó (" + opciones + ") no existe, por favor, intente de nuevo.\n");
                    }
                } while (opciones > 1 || opciones < 1);
            }
            else if (opcion == "4")
            {
                int opciones;
                int cantidad = 0;
                Console.WriteLine("¿Cuántas desea?");
                cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Usted ha comprado " + cantidad + " botellas de caña.\n");
                do
                {
                    Console.WriteLine("================================" +
                     "\n1. Finalizar compra. Podrá acceder a su extra");
                    opciones = int.Parse(Console.ReadLine());
                    if (opciones == 1)
                    {
                        nuevafactura.Sumarafactura(cantidad, opcion);
                        nuevafactura.Facturafinal();
                    }
                    else if (opciones > 1 || opciones < 1)
                    {
                        Console.WriteLine("La opción que ingresó (" + opciones + ") no existe, por favor, intente de nuevo.\n");
                    }
                } while (opciones > 1 || opciones < 1);

            }
        }

    }
}
