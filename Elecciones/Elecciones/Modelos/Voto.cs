using System;
using System.Collections.Generic;
using System.Text;

namespace Elecciones.Modelos
{
    public class Voto
    {
        public byte id { get; set; }
        public string usuario { get; set; }
        public string llave { get; set; }
    }
}
