using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _3POO_Licoreria
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Clear();
            Detallesproducto productos = new Detallesproducto();
            productos.Mostrardetalles();
            Clases.Lista lista = new Clases.Lista();
            lista.Enlistar();
            Console.Clear();
            Console.ReadKey();          
        }
    }
}
