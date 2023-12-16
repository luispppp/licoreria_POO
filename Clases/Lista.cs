using _3POO_Licoreria.Clases;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace _3POO_Licoreria.Clases
{
    class Lista:DatosUsuario
    {
        Clases.Detalles detalles = new Clases.Detalles();
        public static Clases.Factura nuevafactura = new Clases.Factura();
        public string opciones;
        //Se implementa la clase abstract del miembro heredado
        public override string Nombre => throw new NotImplementedException();

        public override string Apellido => throw new NotImplementedException();

        public override string CédulaoRuc => throw new NotImplementedException();

        public override string Domicilio => throw new NotImplementedException();

        public override string Descripcion => throw new NotImplementedException();

        public void Enlistar()
        {
            opciones = "0";
            do
            {
                Console.WriteLine("================================================\n\n" +
                "                  Bebidas:" +"\n\n================================================\n" +
                "Digite el número de la opción que desea  elegir:\n" +
                "\n1.- Cerveza" +
                "\n2.- Vodka" +
                "\n3.- Aguardiente" +
                "\n4.- Caña" +
                "\n5.- Mostrar factura" +
                "\n0.- Salir\n");
                opciones = Console.ReadLine();
                switch (opciones)
                {
                    case "1":
                        Console.WriteLine("El valor de la botella de cerveza es de $2.00");
                        Detalles.Lista(opciones);
                        Console.Write(
                            "================================================" +
                            "\n\n\n" +
                            "   Por su compra usted recibirá un obsequio \n\n\n" +
                            "================================================\n");
                        Console.WriteLine("Presione enter para continuar...");
                        Console.ReadKey();
                        int opcion = 0;
                            Console.Clear();
                            Console.WriteLine("Extra disponible");
                            Console.WriteLine("\n" +
                                "\n 1.-  Botella de cerveza" +
                                "\n 2.-  Cancelar compra \n");
                            Console.WriteLine("Digite una opción :");
                            opcion = Convert.ToInt32(Console.ReadLine());
                            switch (opcion)
                            {
                                case 0:
                                    break;
                                case 1:
                                    DatosUsuario datosUsuario1 = new Clases.Lista();
                                    datosUsuario1 = new Obsequio(datosUsuario1);
                                    Console.WriteLine($"{datosUsuario1.Descripcion}");
                                    Console.WriteLine("Usted elegió la botella de cerveza como su extra");
                                    Console.WriteLine("Gracias por su compra");
                                    break;
                                case 2:
                                    Console.WriteLine("Lo esperamos en una próxima ocasión");
                                    break;
                                default:
                                    break;
                            }
                            Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("El valor de la botella de vodka es de $7.00");
                        Detalles.Lista(opciones);
                        Console.Write(
                            "================================================" +
                            "\n\n\n" +
                            "   Por su compra usted recibirá un obsequio \n\n\n" +
                            "================================================\n");
                        Console.WriteLine("Presione enter para continuar...");
                        Console.ReadKey();
                        int opcion2 = 0;
                            Console.WriteLine("Extra disponible");
                            Console.WriteLine("\n" +
                                "\n 1.-  Botella de cerveza" +
                                "\n 2.-  Cancelar compra \n");
                            Console.WriteLine("Digite una opción :");
                            opcion2 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion2)
                            {
                                case 0:
                                    break;
                                case 1:
                                    DatosUsuario datosUsuario1 = new Clases.Lista();
                                    datosUsuario1 = new Obsequio(datosUsuario1);
                                    Console.WriteLine($"{datosUsuario1.Descripcion}");
                                    Console.WriteLine("Usted elegió la botella de cerveza como su extra");
                                    Console.WriteLine("Gracias por su compra");
                                    break;
                                case 2:
                                    Console.WriteLine("Lo esperamos en una próxima ocasión");
                                    break;
                                default:
                                    break;
                            }
                            Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("El valor de la botella de aguardiente es de $1.00");
                        Detalles.Lista(opciones);
                        Console.Write(
                            "================================================" +
                            "\n\n\n" +
                            "   Por su compra usted recibirá un obsequio \n\n\n" +
                            "================================================\n");
                        Console.WriteLine("Presione enter para continuar...");
                        Console.ReadKey();
                        int opcion3 = 0;
                            Console.WriteLine("Extra disponible");
                            Console.WriteLine("\n" +
                                "\n 1.-  Botella de cerveza" +
                                "\n 2.-  Cancelar compra \n");
                            Console.WriteLine("Digite una opción :");
                            opcion3 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion3)
                            {
                                case 0:
                                    break;
                                case 1:
                                    DatosUsuario datosUsuario1 = new Clases.Lista();
                                    datosUsuario1 = new Obsequio(datosUsuario1);
                                    Console.WriteLine($"{datosUsuario1.Descripcion}");
                                    Console.WriteLine("Usted elegió la botella de cerveza como su extra");
                                    Console.WriteLine("Gracias por su compra");
                                    break;
                                case 2:
                                    Console.WriteLine("Lo esperamos en una próxima ocasión");
                                    break;
                                default:
                                    break;
                            }
                            Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("El valor de la botella de caña es de $5.00");
                        Detalles.Lista(opciones);
                        Console.Write(
                            "================================================" +
                            "\n\n\n" +
                            "   Por su compra usted recibirá un obsequio \n\n\n" +
                            "================================================\n");
                        Console.WriteLine("Presione enter para continuar...");
                        Console.ReadKey();
                        int opcion4 = 0;
                            Console.WriteLine("Extra disponible");
                            Console.WriteLine("\n" +
                                "\n 1.-  Botella de cerveza" +
                                "\n 2.-  Cancelar compra \n");
                            Console.WriteLine("Digite una opción :");
                            opcion4 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion4)
                            {
                                case 0:
                                    break;
                                case 1:
                                    DatosUsuario datosUsuario1 = new Clases.Lista();
                                    datosUsuario1 = new Obsequio(datosUsuario1);
                                    Console.WriteLine($"{datosUsuario1.Descripcion}");
                                    Console.WriteLine("Usted elegió la Botella de cerveza como su extra");
                                    Console.WriteLine("Gracias por su compra");
                                    break;
                                case 2:
                                    Console.WriteLine("Lo esperamos en una próxima ocasión");
                                    break;
                                default:
                                    break;
                            }
                            Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Mostrar factura");
                        Detalles.nuevafactura.Facturafinal();
                        Console.ReadKey();
                        break;
                    case "0":
                        Console.WriteLine("Su pedido ha sido cancelado");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("El dato que ingresó está incorrecto. Vuelva a intentarlo");
                        Console.ReadKey();
                        break;
                }

            } while (opciones != "0");
        }

    }
}