using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Elecciones.Modelos
{
    public class Candidato
    {        
        public short Id { get; set; }

        public string Nombre { get; set; }

        public ImageSource Foto { get; set; }

        public string PartidoPolitico { get; set; }

        public string Edad { get; set; }

        public string Origen { get; set; }

        public string Slogan { get; set; }        
    }
}
