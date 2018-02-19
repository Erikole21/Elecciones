using Elecciones.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elecciones.Datos
{
    public class Calle
    {
        public static Detalle GetBiografia()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Abogado, político, diplomático y escritor colombiano; es doctor en Derecho con experiencia en políticas y asuntos públicos, derecho constitucional y administrativo.");
            sb.AppendLine("con gran influencia conservadora, en el seno de una familia liberal y de intelectuales notables, como sus tíos Hernando de la Calle, rector del Instituto Universitario de Manizales y alcalde encargado de Bogotá en los años cincuenta, y Flaminio Lombana, primer rector de la Universidad de Caldas. Su padre, Honorio de la Calle, era trabajador en la Central Hidroeléctrica de Caldas y su madre Georgina Lombana, era educadora de profesión. Las incisivas oleadas de violencia de los conservadores contra los liberales en 1947 en Manzanares, obligaron a su familia a huir del pueblo y emprender la huída, primero hacia Pereira para alojarse en casa de Camilo Mejía Duque, líder social que protegía a las víctimas de la violencia bipartidista de la época; y finalmente, se radicaron el barrio Campo Hermoso, a las afueras de Manizales. ");
            sb.AppendLine("Humberto de la Calle, su esposa Rosalba y sus hijos Natalia, Alejandra y José Miguel (1990)");
            sb.AppendLine("De la Calle cursó estudios de secundaria en el Colegio Mayor de Nuestra Señora del Rosario, uno de los colegios más importantes de Caldas que pertenecía a la Arquidiócesis de Manizales. Durante la época de bachiller, tomó la dirección del periódico Juventud en el que publicó poemas y escritos irreverentes para el ambiente académico y religioso de la institución. Estas publicaciones motivaron la ira del rector, Monseñor Santiago Marín, quién decidió expulsarlo. ");
            sb.AppendLine("La orden se revocó horas después, luego de la gestión que adelantó el profesor de filosofía del colegio, Raúl Aristizábal. Años después y durante su adolescencia se destacó como un activista intelectual del movimiento nadaísta y gran admirador de los poetas Gonzalo Arango y Jotamario Arbeláez, líderes de esta vanguardia caracterizada por el humor negro, el erotismo, la irreverencia social y antimoralista con un lenguaje directo, voluntariamente prosaico y bastante contundente.5​ Su temprano interés por los estudios del psicoanálisis los aprendió de los textos de Wilhelm Steckel y Sigmund Freud, en los que estudió el tránsito hacia el inconsciente y los articuló con la obra de Erich Fromm como afinidad espiritual de su futuro político.");
            sb.AppendLine("A los veinte años, De la Calle ingresó a la Universidad de Caldas y cursó sus estudios en Derecho obteniendo el título de abogado en 1969. ");
            sb.AppendLine("Allí conoció a Rosalba Restrepo, su esposa, con quien algún tiempo después se mudó a Salamina para desempeñarse como juez municipal. Actualmente tiene tres hijos: José Miguel, Alejandra y Natalia; y seis nietos.");
            return new Detalle()
            {
                IdCandidato = 6,
                Descripcion = sb.ToString(),
                TipoDetalle = TipoDetalle.Biografia,
                Titulo = "https://es.wikipedia.org/wiki/Humberto_de_La_Calle"
            };
        }

        public static List<Detalle> GetEstudios()
        {
            List<Detalle> estudios = new List<Detalle>();
            Detalle estudio1 = new Detalle()
            {
                IdCandidato = 6,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Abogado Universidad de Caldas"
            };
            estudios.Add(estudio1);
            Detalle estudio = new Detalle()
            {
                IdCandidato = 6,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Doctor en Derecho con experiencia en políticas y asuntos públicos, derecho constitucional y administrativo."
            };
            estudios.Add(estudio);
            return estudios;
        }

        public static List<Propuesta> GetPropuestas()
        {
            List<Propuesta> propuestas = new List<Propuesta>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("La Colombia que soñamos entiende que hay que hacer la paz con la naturaleza para que podamos vivir en paz como sociedad.");
            sb.AppendLine("Nuestra bandera será velar por el derecho a la vida con dignidad, con el debido respeto a la diversidad de ecosistemas y culturas.");
            sb.AppendLine("Garantizaremos el acceso al agua en cantidad y calidad para los seres humanos y no humanos.");
            sb.AppendLine("Apostaremos a tener seguridad alimentaria en todos los territorios.");
            sb.AppendLine("La degradación de nuestros recursos y el cambio climático constituyen una amenaza que no podemos seguir ignorando.");
            sb.AppendLine("Trabajaremos para tener territorios más resilientes apostándole a una eficaz gestión del riesgo. Tenemos la responsabilidad con las generaciones futuras, de preservar y proteger nuestra exuberante biodiversidad.");
            sb.AppendLine("Es por esto que pondremos la paz en marcha con el ambiente.");
            Propuesta propuesta = new Propuesta()
            {
                Idcandidato = 6,
                Titulo = "Medio Ambiente",
                Descripcion = sb.ToString(),
                Link = "http://www.humbertodelacalle.co/medio_ambiente"
            };
            propuestas.Add(propuesta);
            sb.Clear();
            sb.AppendLine("1. Vamos a crear entre 500 mil y un millón de empleos en los primeros años de operación de este programa que se mantendrá hasta cuando tengamos una economía más justa.");
            sb.AppendLine("2. Voy a destinar el 1% del PIB a un servicio social obligatorio, para que todos los jóvenes que terminen su bachillerato se vuelquen a ayudar a los pobres, a los necesitados.");
            sb.AppendLine("3. Vamos a establecer programas “post-secundaria” en los colegios públicos y privados para brindarles a las jóvenes competencias básicas para el trabajo y capacitación técnica en oficios de alta tecnología, agricultura, ganadería y competencias ambientales; según los intereses de nuestros jóvenes.");
            sb.AppendLine("4. Impulsaremos un sistema de becas completas para los más pobres. Que incluyan la manutención para que no ocurra que muchos jóvenes logran ingresar a la Universidad y luego se tienen que retirar por falta de plata. Y a los que puedan pagar, les daremos crédito. Hay que el Icetex por un organismo más humano, con créditos más suaves.");            
            sb.AppendLine("6. El 8 de agosto de este año comenzaremos a sacar las IPS públicas de las manos de los políticos locales, para recuperar el rumbo a través de gerentes y directivos escogidos técnicamente, por sus competencias y méritos.");
            sb.AppendLine("7. Pondremos en cintura a los evasores, que no aportan al sistema de salud, para generar recursos con los que construiremos más y mejores hospitales, clínicas, centros de salud, laboratorios, para los más humildes de Colombia.");
            sb.AppendLine("8. Vincularemos grandes recursos de inversión a megaproyectos estratégicamente seleccionados que, en alianza con el sector privado, permitan el nacimiento de empresas o iniciativas altamente productivas, que demanden grandes cantidades de trabajadores en sectores industriales, agrícolas y de tecnología.");
            sb.AppendLine("9. Para seguir recuperando nuestro país, habrá beneficios especiales para quienes inviertan en las zonas que fueron más afectadas por el conflicto, para que generen empleo y empresa en esas regiones tan queridas, pero tan olvidadas de nuestra patria.");
            sb.AppendLine("10. En mi gobierno no habrá complacencia con los criminales que atentan contra la tranquilidad, la vida, honra y bienes de los colombianos. ¡Los perseguiremos y combatiremos con todo! Mantendré y seguiré fortaleciendo el poderío de nuestras Fuerzas Militares y de Policía.");
            sb.AppendLine("11. Trabajaremos de la mano con la rama judicial para depurarla, para darle más herramientas, para modernizarla y agilizarla, de forma que sea la garante de derechos de los colombianos que debe ser.");
            sb.AppendLine("12. No con casa por cárcel para los corruptos. Que paguen como los ladrones que son, y que reciban la sanción social que corresponde.");
            sb.AppendLine("13. Me propongo dar ejemplo desde el alto Gobierno. La primera y mejor forma de controlar la corrupción es designar en los cargos de responsabilidad a personas íntegras, capaces, y no a cuotas del clientelismo y el amiguismo.");
            sb.AppendLine("14. Frenaremos esa feria de concesiones mineras que tuvo su auge en la primera década de este siglo, y vamos a castigar severamente cualquier actividad extractiva que no sea responsable con el ambiente o las comunidades.");
            sb.AppendLine("15. Colombia es el país más biodiverso del mundo en relación a su extensión. Trabajaremos para que siga siéndolo.");
            Propuesta propuesta1 = new Propuesta()
            {
                Idcandidato = 6,
                Titulo = "La Paz En Marcha",
                Descripcion = sb.ToString(),
                Link = "http://www.humbertodelacalle.co/propuestas_la_paz_en_marcha"
            };
            propuestas.Add(propuesta1);
            sb.Clear();
            sb.AppendLine("Cinco décadas de conflicto en Colombia significaron que durante este largo periodo los gobiernos sucesivos se vieran obligados a relegar las tareas importantes para abordar la más urgente, que fue combatir a los grupos subversivos, y especialmente a las FARC.");
            sb.AppendLine("La desmovilización y entrega de armas por parte de este grupo le abre a Colombia una inmensa ventana de oportunidad para que los próximos gobernantes se ocupen de lo importante, empezando por dos de los grandes males que aún aquejan al país: la pobreza y la desigualdad.");
            Propuesta propuesta2 = new Propuesta()
            {
                Idcandidato = 6,
                Titulo = "Primero Los Pobres",
                Descripcion = sb.ToString(),
                Link = "http://www.humbertodelacalle.co/primero_los_pobres"
            };
            propuestas.Add(propuesta2);
            sb.Clear();
            sb.AppendLine("Para Colombia es de vital importancia que la economía vuelva a crecer, porque del crecimiento económico depende la posibilidad de crear riqueza para disminuir la pobreza y mejorar el bienestar de los colombianos.");
            sb.AppendLine("Un crecimiento económico vigoroso y un sistema tributario más justo y progresivo nos permitirán volcarnos hacia lo que más necesitamos: construir una sociedad en la que todos tengamos las mismas oportunidades de progreso, sin distinción por el lugar en el que hayamos nacido, por la educación de nuestros padres o por el color de nuestra piel: UN PAÍS DONDE QUEPAMOS TODOS.");
            Propuesta propuesta3 = new Propuesta()
            {
                Idcandidato = 6,
                Titulo = "Economía y Tributos",
                Descripcion = sb.ToString(),
                Link = "http://www.humbertodelacalle.co/economia"
            };
            propuestas.Add(propuesta3);
            sb.Clear();

            sb.AppendLine("El fin del conflicto con las Farc por fin le permite a Colombia concentrarse en lo importante en vez de atacar lo urgente, que por cinco décadas se tradujo en la necesidad de combatir al grupo armado. El poner fin a la guerra le permitirá al Estado ponerse al día con un gran número de tareas que son esenciales para poner a Colombia en la senda definitiva del desarrollo.");
            sb.AppendLine("Una de estas tareas inaplazables es la de mejorar la competitividad del país, para responder mejor a los retos que nos impone la globalización y poder competir en mejores condiciones en los mercados internacionales. ");
            sb.AppendLine("La generación de riqueza para la economía colombiana es de vital importancia para mejorar las condiciones de vida de todos los colombianos, empezando por los más pobres. Una economía pujante basada en la competitividad de nuestros productos y servicios nos permitirá asumir con éxito el gran reto de disminuir la pobreza y la desigualdad que nos impide avanzar como el gran país que somos.");
            sb.AppendLine("Mi compromiso con Colombia es el de eliminar las barreras que nos impiden tener una economía más productiva y facilitar los medios que nos permitan generar una mayor riqueza y bienestar.");
            Propuesta propuesta4 = new Propuesta()
            {
                Idcandidato = 6,
                Titulo = "Competitividad",
                Descripcion = sb.ToString(),
                Link = "http://www.humbertodelacalle.co/competitividad"
            };
            propuestas.Add(propuesta4);
            sb.Clear();
            sb.AppendLine("Uno de los obstáculos al desarrollo en Colombia radica en la estructura misma del Estado, cuya gestión frente a los ciudadanos es lenta e ineficaz, además de carecer de transparencia. Adicionalmente, la falta de información unificada y actualizada por parte del Estado, y la dificultad en la coordinación entre las distintas entidades estatales, les impide a los ciudadanos actuar con certeza en su diario vivir y en su actividad económica.");
            sb.AppendLine("Esto, a su vez, afecta la productividad de empleados, empresas y de la economía en general. ");
            sb.AppendLine("Por esta razón, uno de mis propósitos será el de llevar a cabo un ambicioso rediseño de la arquitectura del Estado, de manera que recupere su razón de ser: la de un Estado eficaz y transparente al servicio de todos los colombianos.");
            Propuesta propuesta5 = new Propuesta()
            {
                Idcandidato = 6,
                Titulo = "Organización del estado",
                Descripcion = sb.ToString(),
                Link = "http://www.humbertodelacalle.co/organizacion_del_estado"
            };
            propuestas.Add(propuesta5);
            sb.Clear();
            sb.AppendLine("Los jóvenes son el presente de Colombia. Por eso, no podemos seguir postergando las soluciones a los problemas que ser joven implica en nuestro país.");
            sb.AppendLine("El Estado tiene el deber moral de brindar a los jóvenes colombianos, que constituyen una cuarta parte de la población del país, la oportunidad de estudiar y desarrollarse como personas y como profesionales.");
            sb.AppendLine("A ellos les corresponde decidir el futuro de Colombia, y por eso deben contar con las mejores herramientas para seguir construyendo un país donde quepamos todos.");
            Propuesta propuesta6 = new Propuesta()
            {
                Idcandidato = 6,
                Titulo = "Jovenes",
                Descripcion = sb.ToString(),
                Link = "http://www.humbertodelacalle.co/jovenes"
            };
            propuestas.Add(propuesta6);
            return propuestas;
        }

        public static List<Detalle> GetCargos()
        {
            List<Detalle> cargos = new List<Detalle>();
            Detalle cargo = new Detalle()
            {
                IdCandidato = 6,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Profesor y decano de la Universidad de Caldas"
            };
            cargos.Add(cargo);
            Detalle cargo1 = new Detalle()
            {
                IdCandidato = 6,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = " Secretario General en la Gobernación de Óscar Salazar Chávez"                
            };
            cargos.Add(cargo1);
            Detalle cargo2 = new Detalle()
            {
                IdCandidato = 6,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Concejal y abogado litigante",
                Descripcion = "En el año 1971 fundó en Manizales, junto a otros colegas suyos, el Centro de Estudios Jurídicos con el propósito de racionalizar los procesos jurídicos con los juristas más notables de Caldas"
            };
            cargos.Add(cargo2);
            Detalle cargo3 = new Detalle()
            {
                IdCandidato = 6,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Profesor de Derecho Constitucional"
            };
            cargos.Add(cargo3);                        
            Detalle cargo4 = new Detalle()
            {
                IdCandidato = 6,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Registrador Nacional del Estado Civil",
                Descripcion = "Emprendió un proceso de modernización del sistema electoral, además de ser el primero en proponer el uso del tarjetón. No obstante, esta innovadora iniciativa la ahogaron rápidamente en el Congreso."
            };
            cargos.Add(cargo4);
            Detalle cargo5 = new Detalle()
            {
                IdCandidato = 6,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Magistrado de la Corte Suprema de Justicia",                
            };
            cargos.Add(cargo5);
            Detalle cargo6 = new Detalle()
            {
                IdCandidato = 6,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Jefe del Equipo Negociador del Gobierno Nacional en los Diálogos de paz con las FARC",
            };
            cargos.Add(cargo6);
            return cargos;
        }

    }
}
