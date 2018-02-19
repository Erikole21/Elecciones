using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Elecciones.Modelos
{
    public class Detalle
    {
        public short IdCandidato { get; set; }

        public string Descripcion { get; set; }

        public TipoDetalle TipoDetalle { get; set; }

        public string Titulo { get; set; }        

    }
}
