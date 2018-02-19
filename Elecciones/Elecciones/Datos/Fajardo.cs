using Elecciones.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elecciones.Datos
{
    public class Fajardo
    {

        public static Detalle GetBiografia()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Político, matemático y docente universitario Colombiano.");
            sb.AppendLine("Durante bastante tiempo orientó sus esfuerzos en el área académica de importantes universidades de Colombia y del mundo, y ha sido galardonado en varias ocasiones por su espíritu investigador y emprendedor, fundamentalmente gracias a su labor en la Universidad de los Andes, de Bogotá.");
            sb.AppendLine("Fue miembro del Consejo Nacional de Ciencias Básicas, la Comisión Nacional de Maestrías y Doctorados, la Junta Directiva de la Fundación de Apoyo a la Universidad de Antioquia y Director del Centro de Ciencia y Tecnología de Antioquia.");
            sb.AppendLine("Como periodista ha estado enfocado en diferentes temas de la esfera nacional.");
            sb.AppendLine("Fue Subdirector de El Colombiano y columnista de El Mundo, El Espectador y la Revista Dinero; trabajó en los programas de televisión Operación Ciudad de Telemedellín y Zanahoria de Teleantioquia y perteneció al equipo de Viva FM de Caracol Radio, cadena radial en la que recaló durante los primeros meses de 2008, como parte del equipo periodístico del programa 6 AM - Hoy por Hoy.");
            sb.AppendLine("Ha participado en procesos de paz como miembro fundador de la Comisión Facilitadora de Paz de Antioquia durante la gobernación del ex Presidente Álvaro Uribe y ha dictado conferencias sobre el conflicto armado en Colombia.");
            sb.AppendLine("En julio del 2017 Fajardo lanzó su candidatura a la Presidencia de la República para las elecciones del 2018 y en diciembre fue designado candidato presidencial en la llamada Coalición Colombia, compuesta por su movimiento Compromiso Ciudadano, el Partido Alianza Verde y el Polo Democrático Alternativo.");

            return new Detalle()
            {
                IdCandidato = 1,
                Descripcion = sb.ToString(),
                TipoDetalle = TipoDetalle.Biografia,
                Titulo = "https://es.wikipedia.org/wiki/Fajardo"
            };
        }

        public static List<Detalle> GetEstudios()
        {
            List<Detalle> estudios = new List<Detalle>();
            Detalle estudio = new Detalle()
            {
                IdCandidato = 1,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Matemático de la Universidad de los Andes"
            };
            estudios.Add(estudio);
            Detalle estudio1 = new Detalle()
            {
                IdCandidato = 1,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Magister en matemáticas Universidad de los Andes"
            };
            estudios.Add(estudio1);
            Detalle estudio2 = new Detalle()
            {
                IdCandidato = 1,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Máster en matemáticas (1981) de la Universidad de Wisconsin-Madison."
            };
            estudios.Add(estudio2);
            Detalle estudio3 = new Detalle()
            {
                IdCandidato = 1,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Doctor en matemáticas (1984) de la Universidad de Wisconsin-Madison"
            };
            estudios.Add(estudio3);
            Detalle estudio4 = new Detalle()
            {
                IdCandidato = 1,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Reconocimiento",
                Descripcion = "Medalla de oro por su programa de urbanismo social en la Alcaldía de Medellín."
            };
            estudios.Add(estudio4);
            Detalle estudio5 = new Detalle()
            {
                IdCandidato = 1,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Distinción Gran sol del área andina",
                Descripcion = "Por su enfoque de la educación y su convicción de la transcendencia de ésta para la construcción de una nueva Colombia"
            };
            estudios.Add(estudio5);
            Detalle estudio6 = new Detalle()
            {
                IdCandidato = 1,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Premio City to City Barcelona FAD Award",
                Descripcion = "En reconocimiento a la apuesta de inclusión social que lideró durante su administración como Alcalde de Medellín."
            };
            estudios.Add(estudio6);
            Detalle estudio7 = new Detalle()
            {
                IdCandidato = 1,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Premio Curry Stone Design",
                Descripcion = "Por Obras Públicas Transformadoras (2009)."
            };
            estudios.Add(estudio7);
            Detalle estudio9 = new Detalle()
            {
                IdCandidato = 1,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Premio Antonio Sancha de la Asociación de Editores de Madrid",
                Descripcion = "Por su defensa de los valores culturales"
            };
            estudios.Add(estudio9);
            Detalle estudio10 = new Detalle()
            {
                IdCandidato = 1,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Premio de Ciudadanía Global de la Universidad de Tufts",
                Descripcion = "Por gestion en la alcaldia de Medellín"
            };
            estudios.Add(estudio10);
            return estudios;
        }

        public static List<Propuesta> GetPropuestas()
        {
            List<Propuesta> propuestas = new List<Propuesta>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Es un programa que nace de la necesidad de acabar un problema fundamental en la educación del país: ¡La falta de oportunidades!, y a ésto se le se suma la deserción escolar, la entrada de los jóvenes al mundo de la violencia y la ilegalidad; por eso la iniciativa plantea el reto de cerrar, poco a poco y de manera eficiente, los caminos de la ilegalidad y la violencia brindando a los jóvenes oportunidades para que sean ellos los que decidan qué quieren ser en la vida mirando un abanico de posibilidades reales. ");
            sb.AppendLine("Queremos trabajar arduamente para que el futuro de por lo menos 150 mil jóvenes entre los 16 y 24 años que no hayan terminado décimo u once, sea en el marco de la legalidad. Las oportunidades pasan por lo educativo, lo cultural y lo deportivo y comprenden un acompañamiento psicosocial, no solo para estos jóvenes sino también para sus familias. ");
            Propuesta propuesta = new Propuesta()
            {
                Idcandidato = 1,
                Titulo = "Jóvenes con Futuro, abrimos la puerta de las oportunidades",
                Descripcion = sb.ToString(),
                Link = "http://sergiofajardo.co/2018/02/jovenes-futuro-abriremos-la-puerta-las-oportunidades/"
            };
            propuestas.Add(propuesta);
            sb.Clear();
            sb.AppendLine("Apostar a la inteligencia y las capacidades de las personas para transformar nuestra sociedad.");
            sb.AppendLine("Para luchar contra las desigualdades profundas de Colombia nosotros le apostamos a las capacidades de la gente. Esa es nuestra apuesta para construir un país distinto.");
            Propuesta propuesta1 = new Propuesta()
            {
                Idcandidato = 1,
                Titulo = "Educación, ciencia, tecnología, innovación, emprendimiento y cultura",
                Descripcion = sb.ToString(),
                Link = "http://sergiofajardo.co/2018/02/educacion-ciencia-tecnologia-innovacion-emprendimiento-cultura/"
            };
            propuestas.Add(propuesta1);
            sb.Clear();
            sb.AppendLine("Nosotros enfrentamos tres grandes barreras en Colombia: las desigualdades, la violencia y la cultura de la ilegalidad.");
            sb.AppendLine("La gran mayoría de los colombianos vive ante un muro gigantesco que los separa de las oportunidades y que no saben cómo superar. Al mismo tiempo, ven que existe una puerta, muy grande en muchos lugares, que es la entrada al mundo de la ilegalidad y que les ofrece acceso a esas oportunidades negadas. Así, muchas personas se enfrentan un dilema permanente.");
            sb.AppendLine("Nuestro reto político es derrumbar ese muro y cerrar esa puerta que lleva a la ilegalidad y a la violencia. La educación en su sentido más amplio y que incluye la ciencia, tecnología, emprendimiento, innovación y cultura es la que nos permite ir abriendo espacios en ese muro para que las personas puedan acceder a las oportunidades.");
            Propuesta propuesta2 = new Propuesta()
            {
                Idcandidato = 1,
                Titulo = "El muro que separa a las personas de las oportunidades",
                Descripcion = sb.ToString(),
                Link = "http://sergiofajardo.co/2018/02/muro-separa-las-personas-las-oportunidades/"
            };
            propuestas.Add(propuesta2);
            sb.Clear();
            sb.AppendLine("Es un problema ético, de actitudes. Por eso repetimos constantemente que de la forma como se llega al poder, así se gobierna. Y quien paga para llegar, llegar a robar con puestos y contratos. Por eso sostenemos que la corrupción es una empresa criminal más difícil de combatir que la guerrilla y las bandas criminales.");
            sb.AppendLine("Nuestra primera medida para luchar contra la corrupción es que no pagamos un peso por un voto y después cuando llegamos al poder no damos un puesto ni un contrato a un congresista. Nosotros no pagamos para llegar y así podemos gobernar con transparencia. Lo hicimos en Medellín y en la Gobernación de Antioquia.");
            Propuesta propuesta3 = new Propuesta()
            {
                Idcandidato = 1,
                Titulo = "Lucha contra la corrupción",
                Descripcion = sb.ToString(),
                Link = "http://sergiofajardo.co/2018/02/lucha-la-corrupcion/"
            };
            propuestas.Add(propuesta3);
            sb.Clear();
            sb.AppendLine("Acuerdos de Paz. Nosotros le apostamos a los Acuerdos de Paz por convicción. Una vez se resuelve un conflicto dialogando, avanzamos. Una de las raíces de la violencia en nuestro país ha estado asociada por más de cinco décadas a los grupos guerrilleros. Todo avance que podamos lograr en arrancar esa raíz nos permite avanzar y generar oportunidades para todos.");
            sb.AppendLine("Cultura ciudadana. Después de todas estas décadas donde los protagonistas han sido guerrilleros, paramilitares, narcotraficantes, ilegales y corruptos tenemos cambiar la forma cómo nos relacionamos. A través de la cultura ciudadana y una cultura de la legalidad podremos aprender a convivir y aceptar las diferencias de los demás sin ser enemigos. Desde la familia, la escuela y toda la sociedad vamos a construir una pedagogía capaz de transformar.");
            sb.AppendLine("Seguridad ciudadana. Estamos cerrando un capítulo con la guerrilla de las FARC y ojalá con la del ELN, pero aparecen otras formas de violencia en el país que deben ser abordadas. Tenemos que garantizar la seguridad de las personas, tanto en las ciudades como en el campo, para que podamos avanzar en construir una cultura de la legalidad y de convivencia.");
            Propuesta propuesta4 = new Propuesta()
            {
                Idcandidato = 1,
                Titulo = "La Reconciliación",
                Descripcion = sb.ToString(),
                Link = "http://sergiofajardo.co/2018/02/la-reconciliacion/"
            };
            propuestas.Add(propuesta4);
            sb.Clear();
            sb.AppendLine("La fórmula para transformar nuestra sociedad es apostar a la paz, la legalidad y la educación. Así pasaremos la página de la violencia y escribiremos la de las oportunidades. La ciencia, la tecnología, la innovación, el emprendimiento y la cultura serán los protagonistas de una nueva Colombia.");
            Propuesta propuesta5 = new Propuesta()
            {
                Idcandidato = 1,
                Titulo = "La nueva fórmula",
                Descripcion = sb.ToString(),
                Link = "http://sergiofajardo.co/2018/02/la-nueva-formula/"
            };
            propuestas.Add(propuesta5);
            sb.Clear();
            sb.AppendLine("La clave de cómo entendemos la política: los principios y los fundamentos nos rigen como personas y como movimiento. Esto representa el tipo de política que hemos hecho durante dieciocho años.");
            sb.AppendLine("Nos basamos en cuatro valores: la dignidad, el respeto, el reconocimiento y la apuesta por las capacidades de las personas y de las comunidades.");
            sb.AppendLine("Nuestro principio rector: los medios justifican el fin, en contraposición a que el fin justifica los medios, que es una de las causas por las que la ilegalidad y la trampa hacen parte de nuestra sociedad.");
            sb.AppendLine("El resultado de nuestro trabajo, basado en valores y principios, es la confianza y es no tiene precio.");
            Propuesta propuesta6 = new Propuesta()
            {
                Idcandidato = 1,
                Titulo = "El esquema fundamental",
                Descripcion = sb.ToString(),
                Link = "http://sergiofajardo.co/2018/02/el-esquema-fundamental/"
            };
            propuestas.Add(propuesta6);
            sb.Clear();
            sb.AppendLine("Lucha contra la corrupción, reconciliación y educación son los tres pilares de las bases programáticas acordadas por la Alianza Verde, el Polo Democrático Alternativo y el movimiento Compromiso Ciudadano");
            Propuesta propuesta7 = new Propuesta()
            {
                Idcandidato = 1,
                Titulo = "Propuesta programática de la Coalición Colombia",
                Descripcion = sb.ToString(),
                Link = "http://sergiofajardo.co/2017/10/que-propone-fajardo/"
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
                IdCandidato = 1,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Profesor",
                Descripcion = "Universidad de Colorado en Boulder, Math Science Research Institute, Berkley College, Universidad de Wisconsin, en Estados Unidos, Universidad de Oslo, en Noruega. Universidad Nacional del Sur, en Argentina. Pontificia Universidad Católica de Chile, Universidad Central de Venezuela."
            };
            cargos.Add(cargo);
            Detalle cargo1 = new Detalle()
            {
                IdCandidato = 1,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Director",
                Descripcion = "Centro de Ciencia y Tecnología de Antioquia."
            };
            cargos.Add(cargo1);
            Detalle cargo2 = new Detalle()
            {
                IdCandidato = 1,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Alcalde Medellín 2004-2007",
                Descripcion = "Terminó su gobierno en el 2007, con un índice de popularidad del 80%."
            };
            cargos.Add(cargo2);
            Detalle cargo3 = new Detalle()
            {
                IdCandidato = 1,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Gobernador de Antioquia 2012-2015",
                Descripcion = "Durante su administración, Antioquia tuvo el mejor desempeño de todos los departamentos del país en Gobierno Abierto, transparencia y en inversión de regalías. En 2015, Sergio Fajardo fue elegido como Mejor Gobernador por la Fundación Colombia Líder."
            };
            cargos.Add(cargo3);

            return cargos;
        }
    }
}
