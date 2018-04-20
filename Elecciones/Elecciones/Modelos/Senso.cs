using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Elecciones.Modelos
{
    public class Senso
    {
        public byte IdCandidato { get; set; }
        public int Cantidad { get; set; }
        public string DescripcionCantidad { get; set; }
        public string Porcentaje { get; set; }
        public string Nombre { get; set; }
        public ImageSource Foto { get; set; }
    }
}
