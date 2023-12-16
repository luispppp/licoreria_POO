using System;
using System.Collections.Generic;
using System.Text;

namespace _3POO_Licoreria
{
    public class Obsequio : ExtraDecorator
    {
        public Obsequio (DatosUsuario Extra): base (Extra) {}
        public override string Descripcion => "Por su compra usted llevará gratis una botella de cerveza pilsener";
        public override string Nombre => throw new NotImplementedException();

        public override string Apellido => throw new NotImplementedException();

        public override string CédulaoRuc => throw new NotImplementedException();

        public override string Domicilio => throw new NotImplementedException();
    }
}
