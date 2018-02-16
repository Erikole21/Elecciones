using System;
using System.Collections.Generic;
using System.Text;

namespace Elecciones.Modelos
{
    public class Detalle
    {
        public short IdCandidato { get; set; }

        public string Descripcion { get; set; }

        public TipoDetalle TipoDetalle { get; set; }

    }
}
