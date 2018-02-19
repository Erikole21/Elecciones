using System;
using System.Collections.Generic;
using System.Text;

namespace Elecciones.Modelos
{
    public class Propuesta
    {
        public TipoPropuestaEnum TipoPropuesta { get; set; }

        public short Idcandidato { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public string Link { get; set; }

    }
}
