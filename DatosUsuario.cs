using System;
using System.Collections.Generic;
using System.Text;

namespace _3POO_Licoreria
{
    public abstract class DatosUsuario
    {
        public abstract string Nombre { get; }
        public abstract string Apellido { get; }
        public abstract string CédulaoRuc { get; }
        public abstract string Domicilio { get; }
        public abstract string Descripcion { get; }
    }
}
