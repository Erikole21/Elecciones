using Elecciones.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elecciones.Datos
{
    public class Petro
    {
        public static Detalle GetBiografia()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Político y economista colombiano, egresado de la Universidad Externado de Colombia.​");
            sb.AppendLine("Desde temprana edad vivió en Zipaquirá, Cundinamarca y en esta ciudad ocupó diversos cargos públicos.");
            sb.AppendLine("En su juventud fue parte de la guerrilla del M-19.");
            sb.AppendLine("Fue bautizado Gustavo Francisco en honor a su padre y su abuelo. Cuando cursaba 2º grado su familia se trasladó a Zipaquirá. Allí, estudió en el Colegio Nacional de La Salle de Zipaquirá, donde fundó el periódico llamado Carta al Pueblo y un centro cultural al que llamó Gabriel García Márquez.​ Durante esa etapa, Petro empezó a reunirse con movimientos sindicalistas y obreros de Zipaquirá.");
            sb.AppendLine("Petro se graduó a los 16 años del colegio Nacional San Juan Bautista De La Salle y logró uno de los mejores puntajes del examen del ICFES para el ingreso a la educación superior, en toda Colombia");
            sb.AppendLine("Denunció el 'cartel de la contratación' en Bogotá, donde estaban implicados el senador Iván Moreno y el alcalde de Bogotá Samuel Moreno, ambos miembros de su partido.");
            sb.AppendLine("A finales del 2010 se fue del Polo para fundar su movimiento 'Progresistas' y lanzarse como candidato a la Alcaldía de Bogotá.");
            sb.AppendLine("El 30 de Octubre de 2011 ganó las elecciones con 721.308 votos, seguido por Enrique Peñalosa, quien obtuvo 559.307 votos.");
            sb.AppendLine("Como alcalde, Petro abrió varios debates y se enfrentó a fuertes críticas de líderes de opinión y de sus antiguos rivales en las elecciones, especialmente de Enrique Peñalosa y de Gina Parody.");
            sb.AppendLine("Su modelo para Bogotá, cristalizado en múltiples propuestas como la fusión de las empresas de servicios públicos, el tranvía por la Séptima, la negativa a construir la Avenida Longitudinal de Occidente o la creación de un mínimo vital gratuito de agua lo convirtieron en un personaje rodeado de polémica.");
            sb.AppendLine("Precisamente por los líos al implementar el nuevo modelo de recolección de basuras, que implementó el 18 de diciembre de 2012, el 9 de diciembre de 2013 el entonces Procurador general, Alejandro Ordóñez, lo inhabilitó y destituyó en primera instancia. Petro reaccionó hablando de un \"golpe de Estado\" y acusando a Ordóñez de fascista.");
            sb.AppendLine("Al final, la CIDH le otorgó medidas cautelares y eso lo mantuvo en su puesto hasta el final de su gobierno.");            
            return new Detalle()
            {
                IdCandidato = 2,
                Descripcion = sb.ToString(),
                TipoDetalle = TipoDetalle.Biografia,
                Titulo = "https://es.wikipedia.org/wiki/Gustavo_Petro"
            };
        }

        public static List<Detalle> GetEstudios()
        {
            List<Detalle> estudios = new List<Detalle>();
            Detalle estudio = new Detalle()
            {
                IdCandidato = 2,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Economista de la Universidad Externado de Colombia."
            };
            estudios.Add(estudio);
            Detalle estudio1 = new Detalle()
            {
                IdCandidato = 2,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Diplomado en Medio Ambiente y Desarrollo Poblacional en la Universidad Católica de Lovaina."
            };
            estudios.Add(estudio1);
            Detalle estudio2 = new Detalle()
            {
                IdCandidato = 3,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Doctorado en Nuevas Tendencias de la Administración de Empresas en la Universidad Jorge Tadeo Lozano y la Universidad de Salamanca"
            };
            estudios.Add(estudio2);
            Detalle estudio3 = new Detalle()
            {
                IdCandidato = 2,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Especializacion en Administración publica"
            };
            estudios.Add(estudio3);
            Detalle estudio4 = new Detalle()
            {
                IdCandidato = 2,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Reconocimiento",
                Descripcion = "En el 2014 fue nombrado como uno de los ocho alcaldes que parecieron interesantes en el mundo por el Huffington Post."
            };
            estudios.Add(estudio4);
            Detalle estudio5 = new Detalle()
            {
                IdCandidato = 2,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Reconocimiento",
                Descripcion = "Premio mundial de Liderazgo Climático y Ciudad"
            };
            estudios.Add(estudio5);
            return estudios;
        }

        public static List<Propuesta> GetPropuestas()
        {
            List<Propuesta> propuestas = new List<Propuesta>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Pondremos en marcha las reformas para alcanzar una paz definitiva con equidad y libertad, reduciendo las distintas formas de desigualdad y de discriminación social. Para ello implementaremos un nuevo pacto social y político, con amplia participación de todos los sectores y ciudadanías, para superar definitivamente la guerra, para edificar una justicia autónoma y al alcance de la gente, para vencer la corrupción y procurar el buen vivir de todas y todos los colombianos");
            Propuesta propuesta = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "Superar la segregación",
                Descripcion = sb.ToString(),
                Link = "https://www.publimetro.co/co/noticias/2018/02/13/propuestas-gustavo-petro-presidencia-colombia-2018.html"
            };
            propuestas.Add(propuesta);
            sb.Clear();
            sb.AppendLine("Haremos de nuestro país un territorio socialmente justo, ambientalmente sano, sustentablemente productivo, con una población que confía en sus instituciones y participa efectivamente en el fortalecimiento de la democracia y de lo público. Nuestro gobierno se orientará hacia la garantía plena de derechos y hacia el reconocimiento de nuestra diversidad poblacional, social y cultural. En esta vía, garantizaremos el derecho fundamental a la salud de manera universal y equitativa y a la educación de calidad, pluralista, universal y gratuita");
            Propuesta propuesta1 = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "Fortalecimiento de lo público",
                Descripcion = sb.ToString(),
                Link = "https://www.publimetro.co/co/noticias/2018/02/13/propuestas-gustavo-petro-presidencia-colombia-2018.html"
            };
            propuestas.Add(propuesta1);
            sb.Clear();
            sb.AppendLine("Implementaremos cambios profundos en el modelo económico, a fin de enfrentar la crisis ambiental. Dinamizaremos la economía mediante el fortalecimiento de la agricultura, la reindustrialización de sectores estratégicos, la transición hacia energías sustentables y la generación de cambio tecnológico. Es urgente superar el extractivismo que, acompañado de la tercerización de los sectores financiero, de transporte y de servicios, ha llevado al deterioro del aparato productivo, industrial y agropecuario nacional, provocando devastación ambiental, pobreza e inequidad");
            Propuesta propuesta2 = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "Cambio climático",
                Descripcion = sb.ToString(),
                Link = "https://www.publimetro.co/co/noticias/2018/02/13/propuestas-gustavo-petro-presidencia-colombia-2018.html"
            };
            propuestas.Add(propuesta2);
            sb.Clear();            
            sb.AppendLine("En materia de educación pública superior propone que sea gratuita y de calidad, y en el campo de la salud, indicó que no habría intermediación financiera que permita que “el derecho sea primero que el negocio”.");
            sb.AppendLine("Por otro lado, en el eje económico indicó cómo pasar a una economía productiva que incluya a la población colombiana.");
            sb.AppendLine("En cuanto a política, manifestó que la separaría de la corrupción, y la justicia sería independiente del poder político para que se dirija a la atención de los ciudadanos en materia de violación de los derechos.");
            Propuesta propuesta3 = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "Educación, Salud, Economía, Justicia",
                Descripcion = sb.ToString(),
                Link = "https://www.bluradio.com/politica/las-propuestas-de-petro-en-educacion-economia-salud-y-justicia-167464"
            };
            propuestas.Add(propuesta3);
            sb.Clear();
            sb.AppendLine("En mi gobierno prohibiré el Fracking");            
            Propuesta propuesta4 = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "Fracking",
                Descripcion = sb.ToString(),
                Link = "http://www.eltiempo.com/elecciones-colombia-2018/presidenciales/claudia-palacios-entrevista-a-gustavo-petro-en-mejor-hablemos-180020"
            };
            propuestas.Add(propuesta4);
            sb.Clear();            
            return propuestas;
        }

        public static List<Detalle> GetCargos()
        {
            List<Detalle> cargos = new List<Detalle>();
            Detalle cargo = new Detalle()
            {
                IdCandidato = 2,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Fundador Alianza democratica M-19",
                Descripcion = "pariticipó en la Asamblea Nacional Constituyente de 1991 y, en consecuencia, influyó en la redacción de la Constitución de 1991"
            };
            cargos.Add(cargo);
            Detalle cargo1 = new Detalle()
            {
                IdCandidato = 2,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Cámara de Representantes",
                Descripcion = "Por el departamento de Cundinamarca"
            };
            cargos.Add(cargo1);
            Detalle cargo2 = new Detalle()
            {
                IdCandidato = 2,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Agregado diplomático en Bruselas",
                Descripcion = "Gobierno Samper"
            };
            cargos.Add(cargo2);
            Detalle cargo3 = new Detalle()
            {
                IdCandidato = 2,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Senador de la República",
                Descripcion = "Durante ese año destapó el escándalo de la llamada parapolítica."
            };
            cargos.Add(cargo3);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("En la administración de Gustavo Petro, argumentan que cumplieron el 80% de las metas propuestas. La Veeduría, sin embargo, salió al paso para asegurar que lo logrado solo alcanzó el 57%. Su punto mas fuerte donde se vio mas avance fue lo social");
            Detalle cargo4 = new Detalle()
            {
                IdCandidato = 2,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Alcalde de Bogotá",
                Descripcion = sb.ToString()
            };
            cargos.Add(cargo4);
            return cargos;
        }
    }
}
