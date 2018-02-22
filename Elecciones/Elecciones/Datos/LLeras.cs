using Elecciones.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elecciones.Datos
{
    public class LLeras
    {
        public static Detalle GetBiografia()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Abogado colombiano, graduado de la Universidad del Rosario.");
            sb.AppendLine("Luego de pasar por varios colegios, como el Liceo Francés de Bogotá y el Gimnasio Campestre, terminó sus estudios en el Gimnasio José Joaquín Casas, institución dirigida por Jaime Leal González y familia. ");
            sb.AppendLine("Al obtener el título de bachiller, Vargas Lleras estudió en la preparatoria de Georgetown, en Washington, realizó sus estudios universitarios en la Facultad de Jurisprudencia de la Universidad del Rosario donde se recibió de abogado, y en el Instituto Ortega y Gasset de la Universidad Complutense de Madrid en España donde realizó estudios en Gobierno y Administración Pública.");
            sb.AppendLine("Inició su vida política a los 19 años en el municipio de Bojacá, Cundinamarca, en 1981, donde fue elegido concejal, por el Nuevo Liberalismo, movimiento fundado previamente por Luis Carlos Galán.");
            sb.AppendLine("Galán lo nombró coordinador político de la localidad de Los Mártires en Bogotá. La experiencia adquirida en este cargo lo motivó a aspirar al Concejo de Bogotá en 1988. Después del asesinato de su mentor, en 1989, Vargas Lleras, que en ese entonces se desempeñaba como secretario privado del Ministerio de Agricultura de Colombia, se integró al Liberalismo oficialista.");
            return new Detalle()
            {
                IdCandidato = 3,
                Descripcion = sb.ToString(),
                TipoDetalle = TipoDetalle.Biografia,
                Titulo = "https://es.wikipedia.org/wiki/Germán_Vargas_Lleras"
            };
        }

        public static List<Detalle> GetEstudios()
        {
            List<Detalle> estudios = new List<Detalle>();
            Detalle estudio = new Detalle()
            {
                IdCandidato = 3,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Abogado Universidad del Rosario."
            };
            estudios.Add(estudio);
            Detalle estudio1 = new Detalle()
            {
                IdCandidato = 3,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Estudios en Gobierno y Administración Pública. Universidad Complutense de Madrid España"
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
                IdCandidato = 3,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "La Universidad del Rosario rindió un homenaje como egresado ilustre"
            };
            estudios.Add(estudio3);
            Detalle estudio4 = new Detalle()
            {
                IdCandidato = 3,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Reconocimiento",
                Descripcion = "Canal RCN y RCN Radio mejor político del 2010"
            };
            estudios.Add(estudio4);
            Detalle estudio5 = new Detalle()
            {
                IdCandidato = 3,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Reconocimiento",
                Descripcion = "Medalla Servicios Distinguidos Clase Excepcional Primera Vez Policía Nacional"
            };
            estudios.Add(estudio5);
            Detalle estudio6 = new Detalle()
            {
                IdCandidato = 3,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Reconocimiento",
                Descripcion = "Orden de la Democracia Simón Bolívar en el Grado de Gran Cruz, Congreso de la República"
            };
            estudios.Add(estudio6);
            Detalle estudio7 = new Detalle()
            {
                IdCandidato = 3,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Reconocimiento",
                Descripcion = "Orden de la Sal en Zipaquirá. y Cruz de Boyacá"
            };
            estudios.Add(estudio7);
            return estudios;
        }

        public static List<Propuesta> GetPropuestas()
        {
            List<Propuesta> propuestas = new List<Propuesta>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tiene 6 estrategias para hacer más oportuna y eficiente la atención en salud de todos los colombianos. ");
            sb.AppendLine("1.Mejorar y equiparar el sistema de salud para todos ");
            sb.AppendLine("2.Implantar un modelo integral de atención que mejore la calidad de los servicios.");
            sb.AppendLine("3.Asegurar el recurso humano necesario y suficiente en salud.");
            sb.AppendLine("4. Recuperar la salud pública y orientarla ala prevención.");
            sb.AppendLine("5. Desarrollar una política farmacéutica que controle el gasto.");
            sb.AppendLine("6.Regulación efectiva del Sistema de Salud.");
            Propuesta propuesta = new Propuesta()
            {
                Idcandidato = 3,
                Titulo = "Salud",
                Descripcion = sb.ToString(),
                Link = "https://www.mejorvargaslleras.com/propuestas/salud"
            };
            propuestas.Add(propuesta);
            sb.Clear();
            sb.AppendLine("Un crecimiento económico del 5% anual, la creación de mínimo 1´200.000 nuevos empleos formales, una ambiciosa reforma tributaria y estabilidad en las finanzas públicas, son los objetivos principales de la política económica que el candidato a la presidencia, Germán Vargas Lleras, presentó a los colombianos.");
            Propuesta propuesta1 = new Propuesta()
            {
                Idcandidato = 3,
                Titulo = "Economía",
                Descripcion = sb.ToString(),
                Link = "https://www.mejorvargaslleras.com/propuestas/economía"
            };
            propuestas.Add(propuesta1);
            sb.Clear();
            sb.AppendLine("Seguridad ciudadana las 24 horas del día y cero impunidad");
            sb.AppendLine("Es claro que uno de los desafíos más grandes de Colombia en los próximos años es superar la inseguridad ciudadana que exige firmeza y voluntad política. ");
            sb.AppendLine("El delito que hoy afecta cotidianamente a los colombianos en cualquier ciudad o población del país no puede seguir siendo un negocio criminal que no tenga control ni sanción");
            Propuesta propuesta2 = new Propuesta()
            {
                Idcandidato = 3,
                Titulo = "Seguridad",
                Descripcion = sb.ToString(),
                Link = "https://www.mejorvargaslleras.com/propuestas/seguridad"
            };
            propuestas.Add(propuesta2);
            sb.Clear();
            sb.AppendLine("La mejor apuesta que puede hacer una Nación es actuar pensando en la familia. ");
            sb.AppendLine("Por eso, crearemos el Ministerio de la Familia, que se hará por medio de una eficiente reestructuración institucional que agrupe y redistribuya funciones que hoy están a cargo de numerosas instituciones. ");
            sb.AppendLine("Lo haremos a cero costo e impactando positivamente el bienestar de las familias colombianas");
            Propuesta propuesta3 = new Propuesta()
            {
                Idcandidato = 3,
                Titulo = "Familia",
                Descripcion = sb.ToString(),
                Link = "https://www.mejorvargaslleras.com/propuestas/lafamilia"
            };
            propuestas.Add(propuesta3);
            sb.Clear();
            sb.AppendLine("El país requiere con urgencia construir o mejorar las carreteras, vías y autopistas, así como los aeropuertos, puertos o centros de logística que pongan fin a tantos y tantos años de atrasos.");
            Propuesta propuesta4 = new Propuesta()
            {
                Idcandidato = 3,
                Titulo = "Infraestructura",
                Descripcion = sb.ToString(),
                Link = "https://www.mejorvargaslleras.com/propuestas/infraestructura"
            };
            propuestas.Add(propuesta4);
            sb.Clear();
            sb.AppendLine("Soy un convencido de que uno de los mejores caminos para lograr mayor justicia social, mejorar la calidad de vida de millones de colombianos, dinamizar la economía, romper las barreras de la pobreza y generar empleo digno, es a través de la construcción de nuevos hogares dignos. Ya lo hicimos y ahora lo vamos a hacer mejor");
            Propuesta propuesta5 = new Propuesta()
            {
                Idcandidato = 3,
                Titulo = "Vivienda",
                Descripcion = sb.ToString(),
                Link = "https://www.mejorvargaslleras.com/propuestas/vivienda"
            };
            propuestas.Add(propuesta5);
            sb.Clear();
            sb.AppendLine("Una justicia rápida y confiable es un instrumento indispensable dentro de un Estado moderno a la hora de garantizar los derechos de los ciudadanos y de asegurar la resolución idónea, integral y definitiva de todos los conflictos, sin importar su cuantía o motivación. Un buen sistema aumenta los niveles de transparencia y de competitividad económica");
            Propuesta propuesta6 = new Propuesta()
            {
                Idcandidato = 3,
                Titulo = "Justicia",
                Descripcion = sb.ToString(),
                Link = "https://www.mejorvargaslleras.com/propuestas/justicia"
            };
            propuestas.Add(propuesta6);
            sb.Clear();
            sb.AppendLine("Nuestra visión es que Colombia debe llegar dentro de cuatro años a tener 10 millones de visitantes extranjeros, que el sector genere divisas por 10.000 millones de dólares anuales y que se creen 800.000 nuevos puestos de trabajo en todo el país");
            Propuesta propuesta7 = new Propuesta()
            {
                Idcandidato = 3,
                Titulo = "Turismo",
                Descripcion = sb.ToString(),
                Link = "https://www.mejorvargaslleras.com/propuestas/turismo"
            };
            propuestas.Add(propuesta7);
            sb.Clear();
            sb.AppendLine("Mi compromiso es trabajar sin descanso durante mi gobierno para garantizar el derecho a una educación de calidad, que garantice el acceso con inclusión, la permanencia y el éxito en todos los niveles de la educación y formación. Debemos tener una educación competitiva que nos permita crecer en un mundo global, que reduzca las brechas de inequidad entre el sector urbano y el rural, así como entre instituciones públicas y privadas");
            Propuesta propuesta8 = new Propuesta()
            {
                Idcandidato = 3,
                Titulo = "Educación",
                Descripcion = sb.ToString(),
                Link = "https://www.mejorvargaslleras.com/propuestas/educación"
            };
            propuestas.Add(propuesta8);
            sb.Clear();
            sb.AppendLine("Nuestro país cuenta con importantes recursos minero-energéticos y su desarrollo es imprescindible para garantizar nuestra seguridad energética, la inversión social, la competitividad de nuestro sector productivo y la calidad de vida de todos nuestros ciudadanos. Hacer este desarrollo de manera sostenible, como lo han hecho muchos países en el mundo, es nuestro reto principal");
            Propuesta propuesta9 = new Propuesta()
            {
                Idcandidato = 3,
                Titulo = "Minas y energía",
                Descripcion = sb.ToString(),
                Link = "https://www.mejorvargaslleras.com/propuestas/minasyenergía"
            };
            propuestas.Add(propuesta9);
            sb.Clear();
            sb.AppendLine("La cultura y las artes son fundamentales para afianzar nuestra identidad, fortalecer la educación, mejorar la calidad de vida y el uso del tiempo libre. Es por ello, que de ser elegido Presidente, fortaleceré este sector y lo convertiré en un punto clave para consolidar el progreso y la reconciliación de muchas regiones y así lograr que la cultura y las artes se tomen a Colombia");
            Propuesta propuesta10 = new Propuesta()
            {
                Idcandidato = 3,
                Titulo = "Cultura",
                Descripcion = sb.ToString(),
                Link = "https://www.mejorvargaslleras.com/propuestas/cultura"
            };
            propuestas.Add(propuesta10);
            sb.Clear();
            sb.AppendLine("Colombia ha tenido muchos avances en materia de empleo, pero aún hay mucha informalidad y hay que reducir la tasa de desempleo; es por ello que propongo una política integral que comprende la creación de un sistema en donde el país sabrá qué sectores económicos están más activos, cuántos trabajadores se necesitan y de qué tipo, incluso en dónde se debe actuar para salvar empleos. Además, se capacitará a las personas y trabajadores para que ocupen las vacantes disponibles o aquellas que el aparato productivo necesite");
            Propuesta propuesta11 = new Propuesta()
            {
                Idcandidato = 3,
                Titulo = "Empleo",
                Descripcion = sb.ToString(),
                Link = "https://www.mejorvargaslleras.com/propuestas/empleo"
            };
            propuestas.Add(propuesta11);
            sb.Clear();
            sb.AppendLine("Llevaremos a los sistemas de transporte público formales a 500 mil pasajeros diarios que hoy utilizan medios de movilización informal, para esto vamos a eliminar la sobreoferta y los servicios ilegales, pero además vamos a fortalecer la capacidad institucional de inspección, vigilancia y control para lo cual nos ayudaremos con tecnologías que permitan monitorear la prestación de servicio de transporte");
            Propuesta propuesta12 = new Propuesta()
            {
                Idcandidato = 3,
                Titulo = "Transporte",
                Descripcion = sb.ToString(),
                Link = "https://www.mejorvargaslleras.com/propuestas/transporte"
            };
            propuestas.Add(propuesta12);
            sb.Clear();
            sb.AppendLine("Nuestra meta es que Colombia asuma el liderazgo diplomático en la región, fortaleceremos la Cancillería, la Carrera Diplomática y aumentaremos el número de profesionales de carrera, también trabajaremos para que los colombianos puedan viajar a más países sin VISA y apoyaremos a los connacionales en el exterior");
            Propuesta propuesta13 = new Propuesta()
            {
                Idcandidato = 3,
                Titulo = "Relaciones internacionales",
                Descripcion = sb.ToString(),
                Link = "https://www.mejorvargaslleras.com/propuestas/relacionesinternacionales"
            };
            propuestas.Add(propuesta13);
            sb.Clear();
            return propuestas;
        }

        public static List<Detalle> GetCargos()
        {
            List<Detalle> cargos = new List<Detalle>();
            Detalle cargo = new Detalle()
            {
                IdCandidato = 3,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Concejo de Bogotá"
            };
            cargos.Add(cargo);
            Detalle cargo1 = new Detalle()
            {
                IdCandidato = 3,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Senador de la República",
                Descripcion = "En 1994 se retiró del Concejo para buscar una curul en el Senado de la República. Un cargo para el cual sería escogido por cuatro (4) periodos consecutivos y desde donde logró impulsar algunas leyes."
            };
            cargos.Add(cargo1);
            Detalle cargo2 = new Detalle()
            {
                IdCandidato = 3,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Ministro de Interior y Justicia",
                Descripcion = "En julio de 2010, Vargas Lleras fue nombrado ministro del Interior y de Justicia por Juan Manuel Santos"
            };
            cargos.Add(cargo2);
            Detalle cargo3 = new Detalle()
            {
                IdCandidato = 3,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Ministro de Vivienda",
                Descripcion = "Tomó posesión del cargo el 17 de mayo de 2012, mientras el Ministerio del Interior quedó en manos de Federico Renjifo."
            };
            cargos.Add(cargo3);
            return cargos;
        }

        public static List<Propuesta> GetEscandalos()
        {
            List<Propuesta> escandalos = new List<Propuesta>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("El debate de control político que adelantó la congresista sobre el escándalo de Odebrecht se convirtió en una batalla de acusaciones tras la reaparición a la vida pública del exvicepresidente.");
            Propuesta escandalo = new Propuesta()
            {
                Idcandidato = 7,
                Titulo = "El debate de Odebrecht que se volvió contra Vargas Lleras",
                Descripcion = sb.ToString(),
                Link = "https://www.elespectador.com/noticias/politica/el-debate-de-odebrecht-que-se-volvio-contra-vargas-lleras-articulo-718591"
            };
            escandalos.Add(escandalo);
            sb.Clear();
            sb.AppendLine("El debate en el Senado de la República por los escándalos de corrupción se convirtió en un escenario para hacer fuertes acusaciones contra el exvicepresidente Germán Vargas Lleras");
            Propuesta escandalo1 = new Propuesta()
            {
                Idcandidato = 7,
                Titulo = "Debate sobre corrupción terminó siendo contra Germán Vargas Lleras",
                Descripcion = sb.ToString(),
                Link = "https://www.lafm.com.co/nacional/debate-corrupcion-termino-siendo-german-vargas/"
            };
            escandalos.Add(escandalo1);
            sb.Clear();
            sb.AppendLine("El exmandatario colombiano Álvaro Uribe, el exvicepresidente Germán Vargas Lleras y el exalcalde de Bogotá Gustavo Petro fueron llamados a declarar por el escándalo de corrupción que involucra a dos extitulares de la Corte Suprema de Justicia.");
            Propuesta escandalo2 = new Propuesta()
            {
                Idcandidato = 7,
                Titulo = "Uribe y Vargas Lleras tendrán que declarar por caso de corrupción ",
                Descripcion = sb.ToString(),
                Link = "https://www.publimetro.co/co/colombia/2018/01/24/uribe-vargas-lleras-tendran-declarar-caso-corrupcion.html"
            };
            escandalos.Add(escandalo2);
            sb.Clear();
            sb.AppendLine("Desde el Congreso consideraron grave que se compruebe algún vínculo del hermano del vicepresidente en este escándalo.");
            Propuesta escandalo3 = new Propuesta()
            {
                Idcandidato = 7,
                Titulo = "Piden investigar vínculos de familia Vargas Lleras con escándalo ",
                Descripcion = sb.ToString(),
                Link = "http://caracol.com.co/radio/2016/03/15/nacional/1458061324_976557.html"
            };
            escandalos.Add(escandalo3);
            sb.Clear();
            sb.AppendLine("Uno de esos procesos que, a juicio de Robledo, debería ser revisado, es el que en 2013 fue archivado contra el ex vicepresidente y hoy precandidato presidencial Germán Vargas Lleras por parapolítica");
            Propuesta escandalo4 = new Propuesta()
            {
                Idcandidato = 7,
                Titulo = "Senador Robledo pide reabrir investigación por parapolítica a Vargas lleras",
                Descripcion = sb.ToString(),
                Link = "https://www.bluradio.com/politica/senador-robledo-pide-reabrir-investigacion-por-parapolitica-vargas-lleras-157035"
            };
            escandalos.Add(escandalo4);
            sb.Clear();
            return escandalos;
        }
    }
}
