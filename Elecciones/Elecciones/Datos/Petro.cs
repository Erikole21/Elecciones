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

        public static List<Propuesta> GetEscandalos()
        {
            List<Propuesta> escandalos = new List<Propuesta>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("A petición de la defensa del investigado exmagistrado Leónidas Bustos, serán llamados a declarar como testigos en la Comisión de Acusación de la Cámara de Representantes los candidatos presidenciales Germán Vargas Lleras y Gustavo Petro.");
            Propuesta escandalo5 = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "Cartel de la toga: Vargas Lleras, Petro y Montealegre tendran que declarar",
                Descripcion = sb.ToString(),
                Link = "https://www.bluradio.com/judicial/cartel-de-la-toga-vargas-lleras-petro-y-montealegre-declararan-como-testigos-164779"
            };
            escandalos.Add(escandalo5);
            sb.Clear();            
            sb.AppendLine("Gustavo Petro también enfrentó polémicas por sus propios trabajadores. Una funcionaria de la administración dijo que salía de la Alcaldía por los celos de la esposa del mandatario. Pero el escándalo más grande y que siempre lo tuvo contra las cuerdas fue el del esquema de basuras.");
            Propuesta escandalo = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "Las polémicas que enfrentó el alcalde Petro durante su mandato",
                Descripcion = sb.ToString(),
                Link = "http://www.noticiasrcn.com/nacional-bogota/las-polemicas-enfrento-el-alcalde-petro-durante-su-mandato"
            };
            escandalos.Add(escandalo);
            sb.Clear();
            sb.AppendLine("Los contratos a dedo de la Alcaldía de Petro. Una investigación de la Contraloría capitalina encontró que entre 2012 y 2015 el 96 por ciento de los contratos de la ciudad se hicieron de forma directa y sin licitación.");
            Propuesta escandalo1 = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "Contraloría de Bogotá encuentra fallas de corrupción",
                Descripcion = sb.ToString(),
                Link = "http://www.semana.com/nacion/articulo/contraloria-de-bogota-encuentra-fallas-de-corrupcion/492262"
            };
            escandalos.Add(escandalo1);
            sb.Clear();
            sb.AppendLine("El debate por la inexistencia del título de doctorado del alcalde Enrique Peñalosa se convirtió en una pelea política de todos contra todos.");
            sb.AppendLine("El periodista Melquisedec Torres asegura que Gustavo Petro también infló sus títulos académicos. El exmandatario dijo que nunca ha asegurado que sea doctor.");
            Propuesta escandalo2 = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "Los tres títulos falsos de Gustavo Petro",
                Descripcion = sb.ToString(),
                Link = "https://www.elespectador.com/noticias/bogota/los-tres-titulos-falsos-de-gustavo-petro-articulo-628574"
            };
            escandalos.Add(escandalo2);
            sb.Clear();
            sb.AppendLine("El periodista Melquisedec Torres asegura que Gustavo Petro también infló sus títulos académicos. El exmandatario dijo que nunca ha asegurado que sea doctor.");
            Propuesta escandalo3 = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "En el Congreso ven en la alcaldía de Petro toda una cadena de corrupción",
                Descripcion = sb.ToString(),
                Link = "https://www.elespectador.com/noticias/politica/el-congreso-ven-alcaldia-de-petro-toda-una-cadena-de-co-articulo-510600"
            };
            escandalos.Add(escandalo3);
            sb.Clear();
            sb.AppendLine("Investigación, 850 colombianos estarían involucrados en el escándalo. Entre los nombres revelados, aparece Carlos Gutiérrez Robayo, concuñado del exalcalde de Bogotá, Gustavo Petro.");
            Propuesta escandalo4 = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "Concuñado de Petro, salpicado por escándalo mundial de paraísos fiscales",
                Descripcion = sb.ToString(),
                Link = "https://noticias.caracoltv.com/mundo/concunado-de-petro-salpicado-por-escandalo-mundial-de-paraisos-fiscales-en-panama"
            };
            escandalos.Add(escandalo4);
            sb.Clear();
            sb.AppendLine("Se investiga el presunto pago de $2.000 millones en comisiones por la ampliación en tiempo de contratos de particulares en TransMilenio");
            Propuesta escandalo6 = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "Procuraduría abrió investigación a Gustavo Petro por contratación en transmilenio",
                Descripcion = sb.ToString(),
                Link = "https://www.larepublica.co/procuradur%C3%ADa-abri%C3%B3-investigaci%C3%B3n-gustavo-petro-por-contrataci%C3%B3n-en-transmilenio_138406"
            };
            escandalos.Add(escandalo6);
            sb.Clear();
            return escandalos;
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
            sb.AppendLine("En Colombia la atención a la primera infancia, la educación de calidad, la ciencia y la cultura hoy son privilegios. Durante las últimas décadas los gobiernos aumentaron la matrícula de la educación básica en las ciudades, pero los recursos destinados a construir una sociedad del conocimiento incluyente y una paz generacional fueron priorizados para financiar la guerra. La Colombia Humana reconoce que solo las sociedades que han priorizado la formación integral de sus ciudadanos han logrado construir condiciones duraderas de desarrollo humano y de dignidad.");
            Propuesta propuesta = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "1. EDUCACIÓN, CUIDADO DE LA INFANCIA Y BÚSQUEDA DE LA EQUIDAD",
                Descripcion = sb.ToString(),
                Link = "https://petro.com.co/programa-educacion/"
            };
            propuestas.Add(propuesta);
            sb.Clear();
            sb.AppendLine("En nuestro gobierno la salud será pública, gratuita, preventiva y para todas y todos sin ninguna discriminación, guiados por la ley estatutaria de salud, que resultó de un consenso entre los distintos actores del sector, en el que hay que avanzar. Nuestro modelo de salud estará dispuesto y al servicio del buen vivir de las personas y avanzaremos en la erradicación de las enfermedades y muertes evitables o por falta de atención a niñas, niños, mujeres y poblaciones más pobres. En Colombia Humana no morirán niños de hambre.");
            Propuesta propuesta1 = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "2. SALUD COMO DERECHO FUNDAMENTAL PARA EL BUEN VIVIR",
                Descripcion = sb.ToString(),
                Link = "https://petro.com.co/programa-salud/"
            };
            propuestas.Add(propuesta1);
            sb.Clear();
            sb.AppendLine("La apuesta de los últimos años por un modelo extractivista aumentó la fragilidad de la economía colombiana, agravada por la caída de los precios internacionales del petróleo y el cambio en el uso de energías. A esto se suma las inequidades entre actividades productivas del campo, el creciente proceso de potrerización, monocultivos y deforestación, además de la concentración de la tierra que ha estado siempre en el centro del conflicto interno.");
            Propuesta propuesta2 = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "3. HACIA UNA ECONOMÍA PRODUCTIVA",
                Descripcion = sb.ToString(),
                Link = "https://petro.com.co/programa-economia/"
            };
            propuestas.Add(propuesta2);
            sb.Clear();            
            sb.AppendLine("Adoptaremos medidas para que la ciudadanía acceda expeditamente al sistema judicial. Garantizaremos a la población el acceso a los mecanismos de protección de los derechos fundamentales consagrados por la Constitución Política. Haremos un mayor énfasis en la ética aplicada al ejercicio del derecho, tanto en la formación académica como en el control del desempeño profesional: lo legal debe identificarse con lo ético.");            
            Propuesta propuesta3 = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "4. JUSTICIA AUTÓNOMA Y LIBRE DE PRESIONES POLÍTICAS",
                Descripcion = sb.ToString(),
                Link = "https://petro.com.co/programa-justicia/"
            };
            propuestas.Add(propuesta3);
            sb.Clear();
            sb.AppendLine("Para impedir que el miedo y la desconfianza sigan inmovilizando al pueblo colombiano y perpetuando en el poder a quienes por siglos nos han dominado, debemos limpiar la política de la corrupción. La política debe dejar de ser un negocio en que los corruptos invierten para ganar poder a costa de la necesidad del pueblo. La política debe ser el ejercicio del poder de la ciudadanía, debe ser el vehículo para que la gente pueda satisfacer sus necesidades colectivas. En nuestro gobierno los corruptos además de ir a cárcel deberán devolver los dineros que se hayan robado de las finanzas públicas.");            
            Propuesta propuesta4 = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "5. POR UNA POLÍTICA LIBRE DE CORRUPCIÓN",
                Descripcion = sb.ToString(),
                Link = "https://petro.com.co/programa-politica/"
            };
            propuestas.Add(propuesta4);
            sb.Clear();
            sb.AppendLine("La lucha contra la discriminación y la segregación social de un país pasa por reconocer la diversidad de sus ciudadanías y así poder implementar políticas afirmativas que, con la voz de todas y todos, garanticen la inclusión social y la participación efectiva.");
            Propuesta propuesta5 = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "6. UN PAÍS DIVERSO Y MULTICOLOR QUE SUPERA LA DISCRIMINACIÓN",
                Descripcion = sb.ToString(),
                Link = "https://petro.com.co/programa-pais-diverso/"
            };
            propuestas.Add(propuesta5);
            sb.Clear();
            sb.AppendLine("La lucha contra la discriminación y la segregación social de un país pasa por reconocer la diversidad de sus ciudadanías y así poder implementar políticas afirmativas que, con la voz de todas y todos, garanticen la inclusión social y la participación efectiva.");
            Propuesta propuesta6 = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "7. RELACIONES INTERNACIONALES PARA LA SEGURIDAD HUMANA Y LA PAZ",
                Descripcion = sb.ToString(),
                Link = "https://petro.com.co/programa-relaciones-internacionales/"
            };
            propuestas.Add(propuesta6);
            sb.Clear();
            sb.AppendLine("Establecer reforma tributaria para la equidad., Gasto público transparente, eficiente y participativo., Sostenibilidad fiscal basada en productividad, transparencia y eficiencia, Descentralización con recursos");
            Propuesta propuesta7 = new Propuesta()
            {
                Idcandidato = 2,
                Titulo = "8. PILARES DE LA POLÍTICA ECONÓMICA DE COLOMBIA HUMANA",
                Descripcion = sb.ToString(),
                Link = "https://petro.com.co/programa-pilares-politica-economica/"
            };
            propuestas.Add(propuesta7);            
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
