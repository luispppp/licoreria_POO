using System;
using System.Collections.Generic;
using System.Text;

namespace _3POO_Licoreria
{
    public abstract class ExtraDecorator : DatosUsuario
    {
        protected DatosUsuario Extras;
        public ExtraDecorator(DatosUsuario Extra)
        {
            Extras = Extra;
        }
    }
}
