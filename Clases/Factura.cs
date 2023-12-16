using System;
using System.Collections.Generic;
using System.Text;

namespace _3POO_Licoreria.Clases
{
    public class Factura: DatosUsuario
    {
        public int cerveza, vodka, aguardiente, cana, resultado;
        public override string Nombre => throw new NotImplementedException();
        public override string Apellido => throw new NotImplementedException();
        public override string CédulaoRuc => throw new NotImplementedException();
        public override string Domicilio => throw new NotImplementedException();
        public override string Descripcion => throw new NotImplementedException();
        public void Sumarafactura(int cantidad, string opcion)
        {
            if (opcion == "1")
            {
                cerveza += cantidad;
                resultado += cantidad * 2;
            }
            else if (opcion == "2")
            {
                vodka += cantidad;
                resultado += cantidad * 7;
            }
            else if (opcion == "3")
            {
                aguardiente += cantidad;
                resultado += cantidad * 1;
            }
            else if (opcion == "4")
            {
                cana += cantidad;
                resultado += cantidad * 5;
            }
        }
        public void Facturafinal()
        {
            Console.Clear();
            String Nombre;
            String Apellido;
            String CedulaoRuc;
            String Domicilio;
            Console.WriteLine("Datos de de facturación");
            Console.WriteLine("Ingrese su nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su cédula o RUC: ");
            CedulaoRuc = Console.ReadLine();
            Console.WriteLine("Ingrese su dirección domiciliaria: ");
            Domicilio = Console.ReadLine();
            Console.WriteLine("\n-----------------------------Detalles de la factura----------------------------\n");
            Console.WriteLine("Item               Precio por c/u              Cantidad                Subtotal\n");
            if (cerveza > 0)
            {
                int subtotal = 0;
                subtotal += cerveza * 2;
                Console.WriteLine("La botella de cerveza            $2.00                      " + cerveza + "                       $" + subtotal);
            }
            if (vodka > 0)
            {
                int subtotal = 0;
                subtotal += vodka * 2;
                Console.WriteLine("La botella de vodka        $7.00                       " + vodka + "                       $" + subtotal);
            }
            if (aguardiente > 0)
            {
                int subtotal = 0;
                subtotal += aguardiente * 1;
                Console.WriteLine("La botella de aguardiente           $1.00                       " + aguardiente + "                       $" + subtotal);
            }
            if (cana > 0)
            {
                int subtotal = 0;
                subtotal += cana * 5;
                Console.WriteLine("La caja de caña            $5.00                       " + cana + "                       $" + subtotal);
            }
            Console.WriteLine("\nTOTAL:                                                                 $" + resultado);
            Console.WriteLine("\n\n\nPresiona enter para continuar...");
            Console.ReadKey();
        }
    }
}