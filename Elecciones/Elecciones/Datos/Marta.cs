using Elecciones.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elecciones.Datos
{
    public class Marta
    {
        public static Detalle GetBiografia()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Líder del Partido Conservador Colombiano, política, abogada colombiana graduada de la Pontificia Universidad Javeriana.");
            sb.AppendLine("Es la mayor de cuatro hermanos y la única hija, desde muy pequeña soñaba con ser presidenta. ");
            sb.AppendLine("Estudió Derecho en la Pontificia Universidad Javeriana e hizo especializaciones en Derecho Comercial, Alta Dirección Empresarial, Legislación Financiera y tiene un Fellow del Centro de Asuntos Internacionales de la Universidad de Harvard. ");
            sb.AppendLine("Gran especialista en el tema de comercio internacional, fue la última directora del Instituto Colombiano de Comercio Exterior (1990-1991), dando paso al Ministerio de Comercio Exterior, con Juan Manuel Santos a la cabeza, de quien fue viceministra (1991-1994).");
            sb.AppendLine("Regresó al gobierno como Ministra de Comercio Exterior durante la presidencia de Andrés Pastrana, desde 1998 hasta enero de 2002, cuando fue nombrada embajadora de Colombia en Francia. Tras la elección de Álvaro Uribe Vélez como presidente, este la designa Ministra de Defensa (2002-2003), convirtiéndose en la primera y única mujer en Colombia en ser designada para este cargo. ");
            sb.AppendLine("Destacada asesora comercial a nivel nacional e internacional (asesora de la OMC).");
            sb.AppendLine("Fue profesora de la Facultad de Derecho en la Universidad de los Andes y en la Pontificia Universidad Javeriana.");
            return new Detalle()
            {
                IdCandidato = 7,
                Descripcion = sb.ToString(),
                TipoDetalle = TipoDetalle.Biografia,
                Titulo = "https://es.wikipedia.org/wiki/Marta_Lucía_Ramírez"
            };
        }

        public static List<Detalle> GetEstudios()
        {
            List<Detalle> estudios = new List<Detalle>();
            Detalle estudio1 = new Detalle()
            {
                IdCandidato = 7,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Abogada Pontificia Universidad Javeriana"
            };
            estudios.Add(estudio1);
            Detalle estudio = new Detalle()
            {
                IdCandidato = 7,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Especializaciones en Derecho Comercial, Alta Dirección Empresarial, Legislación Financiera"
            };
            estudios.Add(estudio);
            Detalle estudio2 = new Detalle()
            {
                IdCandidato = 7,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Fellow del Centro de Asuntos Internacionales de la Universidad de Harvard."
            };
            estudios.Add(estudio2);
            return estudios;
        }

        public static List<Propuesta> GetPropuestas()
        {
            List<Propuesta> propuestas = new List<Propuesta>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("En Colombia las mujeres enfrentan innumerables desafíos para lograr igualdad de oportunidades de desarrollo y crecimiento individual frente a los hombres. La mujer no es tratada con igualdad, siendo víctima de mayor violencia, salarios más bajos que los de los hombres, menor participación en el mercado laboral y menor posibilidad de llegada a cargos directivos, menores posibilidades de participación en política, menor acceso a servicios de salud. Y feminización de la pobreza, especialmente entre mujeres cabeza de hogar. ");
            sb.AppendLine("El electorado Colombiano es representado en un 50% por la Mujer Colombiana y su representación en altos cargos de decisión del Estado, Senado, Cámara, es de solo, aproximadamente el 8%.");
            sb.AppendLine("En materia educativa, prevalece el alto índice del analfabetismo en la mujer campesina y continua la deserción escolar por embarazos en adolescentes. La aplicación de normas discriminatorias, contra la mujer crea desventajas de las mujeres en el acceso a la justicia.");
            Propuesta propuesta = new Propuesta()
            {
                Idcandidato = 7,
                Titulo = "Mujer",
                Descripcion = sb.ToString(),
                Link = "https://www.martalucia.com/participa/que-ideas-propones-para-que-en-colombia-haya-igualdad"
            };
            propuestas.Add(propuesta);
            sb.Clear();            
            sb.AppendLine("El crecimiento de la economía colombiana está marcado por factores importantes como la diversificación de la producción, la promoción de empleo, el crecimiento de las empresas, capacidades comerciales a nivel nacional e internacional, gestión del gasto público, estimulación de las inversiones, y aspectos relacionados que garanticen un eficiente y productivo desarrollo nacional.");            
            sb.AppendLine("Por ahora, nuestra economía se mide por el Producto Interno Bruto, conocido como la suma de toda la producción de bienes y servicios que tiene Colombia en valor monetario. En 2010 y 2011 la economía tenía crecimientos estimados en 4,4% y en 6,6% respectivamente. Actualmente, las estimaciones de crecimiento para este año se mantienen debajo del 2%.  ");
            Propuesta propuesta1 = new Propuesta()
            {
                Idcandidato = 7,
                Titulo = "Economia y empleo",
                Descripcion = sb.ToString(),
                Link = "https://www.martalucia.com/participa/que-ideas-tienes-para-que-mejore-la-economia-en-colombia"
            };
            propuestas.Add(propuesta1);
            sb.Clear();
            sb.AppendLine("Colombia es el segundo país más biodiverso del mundo; cuenta con la variedad más grande de aves y anfibios (1.815 y 634 especies, respectivamente) y posee el 10 por ciento de la diversidad biológica de la Tierra. ");            
            sb.AppendLine("Los problemas ambientales generan un alto impacto sobre esta biodiversidad. En los últimos años la calidad medio ambiental en Colombia ha desmejorado a un ritmo constante y sin precedente caracterizada entre otras por una alta deforestación contaminación hídrica y alteraciones del ecosistema.");
            Propuesta propuesta2 = new Propuesta()
            {
                Idcandidato = 7,
                Titulo = "Biodiversidad",
                Descripcion = sb.ToString(),
                Link = "https://www.martalucia.com/participa/que-ideas-tienes-para-garantizar-la-preservacion-y-uso"
            };
            propuestas.Add(propuesta2);
            sb.Clear();
            sb.AppendLine("El desarrollo rural está íntimamente ligado al concepto del agro. Sin embargo, va mucho más allá bajo una visión y estrategia integral que conciba criterios como acceso a educación, salud, vivienda, saneamiento básico, electricidad, transporte, etc. Más del 90 por ciento del territorio es rural y sólo un 32 por ciento vive allí.");
            Propuesta propuesta3 = new Propuesta()
            {
                Idcandidato = 7,
                Titulo = "Desarrollo Rural",
                Descripcion = sb.ToString(),
                Link = "https://www.martalucia.com/participa/que-necesita-el-campo-para-ser-mas-productivo-y-evitar"
            };
            propuestas.Add(propuesta3);
            sb.Clear();
            sb.AppendLine("Nuestro sistema educativo tiene enormes retos para promover criterios de calidad e igualdad. ");
            sb.AppendLine("Se han logrado buenos índices de acceso en la educación de la primera infancia, pero en educación secundaria, media y superior aún tenemos bajos niveles de cobertura y altas las tasas de deserción de nuestros jóvenes en estas últimas etapas. ");
            sb.AppendLine("Por otro lado, pruebas realizadas a nuestros niños y jóvenes revelan deficiencias en componentes de ciencias y matemáticas.   ");
            Propuesta propuesta4 = new Propuesta()
            {
                Idcandidato = 7,
                Titulo = "Educación",
                Descripcion = sb.ToString(),
                Link = "https://www.martalucia.com/participa/que-se-te-ocurre-para-mejorar-la-educacion-en-colombia"
            };
            propuestas.Add(propuesta4);
            sb.Clear();
            sb.AppendLine("La corrupción es una enfermedad que padece el país, causante de los retrasos que mantiene, por ahora, en términos económicos y sociales. Según la Contraloría, en Colombia se pierden anualmente cerca de 50 billones de pesos por corrupción.  ");
            Propuesta propuesta5 = new Propuesta()
            {
                Idcandidato = 7,
                Titulo = "Lucha Contra la Corrupción",
                Descripcion = sb.ToString(),
                Link = "https://www.martalucia.com/participa/cuales-son-tus-propuestas-para-acabar-con-la-corrupcion"
            };
            propuestas.Add(propuesta5);
            sb.Clear();
            sb.AppendLine("Estudios realizados a lo largo de estos tres años han revelado que casi el 65% de los colombianos no cree en la eficacia del sistema judicial en Colombia a la hora de perseguir y juzgar a los delincuentes. ");
            sb.AppendLine("Esto conlleva a que las personas no entablen acciones a su alcance para resolver sus conflictos, gracias a deficiencias en el sistema penitenciario en cuanto a tecnología, puntos de acceso, capital de humano capacitado, etc.  ");
            Propuesta propuesta6 = new Propuesta()
            {
                Idcandidato = 6,
                Titulo = "Justicia",
                Descripcion = sb.ToString(),
                Link = "https://www.martalucia.com/participa/como-mejorar-la-justicia-en-colombia-y-acabar-con-la"
            };
            propuestas.Add(propuesta6);
            sb.Clear();
            sb.AppendLine("La seguridad nacional siempre se ha percibido bajo una vocación civilista dentro de la estructura del Estado. ");
            sb.AppendLine("La violencia va más allá de la guerra de guerrillas, y tiene amplia presencia en ámbitos tanto rurales como urbanos con la consolidación de bandas criminales. ");
            sb.AppendLine("Según el calendario criminal de la Fiscalía del año pasado, en Colombia se robaban 5 vehículos, 6 celulares, 3 casas y 2 locales por hora. ");
            Propuesta propuesta7 = new Propuesta()
            {
                Idcandidato = 7,
                Titulo = "Seguridad y Defensa",
                Descripcion = sb.ToString(),
                Link = "https://www.martalucia.com/participa/como-podemos-hacer-de-colombia-un-pais-mas-seguro"
            };
            propuestas.Add(propuesta7);
            sb.Clear();
            sb.AppendLine("Generar interés en la población para que participe en asuntos de índole público es vital. Por ejemplo, de cada 100 colombianos, sólo 49 tienden a participar en la votación para las elecciones presidenciales. ");
            sb.AppendLine("Y esta cifra se reduce mucho cuando se trata de población marginada y con bajo nivel de escolaridad.    ");
            Propuesta propuesta8 = new Propuesta()
            {
                Idcandidato = 7,
                Titulo = "Gobernanza",
                Descripcion = sb.ToString(),
                Link = "https://www.martalucia.com/participa/que-ideas-tienes-para-promover-la-participacion-ciudadana"
            };
            propuestas.Add(propuesta8);
            sb.Clear();
            sb.AppendLine("En ciencia, tecnología e innovación (CT&I) nuestro país tiene enormes deficiencias. ");
            sb.AppendLine("El problema viene desde la poca importancia que tiene este componente en el sector público y en el privado. El primero viene reduciendo gradualmente el presupuesto para CT&I, y el segundo no participa lo suficiente: por cada dólar que invierte el Estado, el sector privado colombiano invierte menos de 1 dólar; mientras que en Estados Unidos su sector privado invierte hasta 2,5 dólares.  ");
            Propuesta propuesta9 = new Propuesta()
            {
                Idcandidato = 7,
                Titulo = "Tecnología",
                Descripcion = sb.ToString(),
                Link = "https://www.martalucia.com/participa/como-impulsar-la-innovacion-el-desarrollo-y-la-adopcion"
            };
            propuestas.Add(propuesta9);
            sb.Clear();
            sb.AppendLine("El bienestar poblacional está estrechamente ligado con el acceso real que tienen las personas a diversos bienes y servicios que garanticen una buena calidad de vida. ");
            sb.AppendLine("Existe una proporción básica de necesidades que debe satisfacerse, en cuanto a aspectos como salud, educación, trabajo, etc. Necesitamos brindar un mayor acceso de estos factores fundamentales a todas las personas, en todo el territorio, sin discriminación alguna.");
            Propuesta propuesta10 = new Propuesta()
            {
                Idcandidato = 7,
                Titulo = "Desarrollo social",
                Descripcion = sb.ToString(),
                Link = "https://www.martalucia.com/participa/que-ideas-tienes-para-mejorar-la-calidad-de-vida-de"
            };
            propuestas.Add(propuesta10);
            sb.Clear();
            sb.AppendLine("Las micro, pequeñas y mediana empresas (MIPYMES) constituyen más del 90% del tejido empresarial en Colombia y contribuyen con casi el 80% del empleo en el país. Su importancia es fundamental. Sin embargo, en el país sobreviven 30 de cada 100 empresas creadas en 2011. La idea es que podamos generar mayor número de empresas, con una mayor probabilidad de supervivencia. ");
            Propuesta propuesta11 = new Propuesta()
            {
                Idcandidato = 7,
                Titulo = "Emprendimiento",
                Descripcion = sb.ToString(),
                Link = "https://www.martalucia.com/participa/que-se-te-ocurre-para-estimular-el-emprendimiento-en"
            };
            propuestas.Add(propuesta11);
            sb.Clear();
            sb.AppendLine("Colombia es un país que requiere inclusión. ");
            sb.AppendLine("De hecho, es una respuesta a la diversidad y al reconocimiento de que todas las personas sin importar su religión, raza, género y condición socioeconómica tienen derecho a acceder a las mismas oportunidades sin discriminación alguna");
            Propuesta propuesta12 = new Propuesta()
            {
                Idcandidato = 7,
                Titulo = "Inclusión",
                Descripcion = sb.ToString(),
                Link = "https://www.martalucia.com/participa/que-ideas-propones-para-construir-un-pais-mas-incluyente"
            };
            propuestas.Add(propuesta12);
            sb.Clear();
            sb.AppendLine("En el país hay más de 26 millones de personas afiliadas a entidades que se encuentran en medidas especiales como intervención; liquidación o vigilancia, la mayoría de casos asociados a falta de recursos para pagar deudas y/o a líos de corrupción. ");
            Propuesta propuesta13 = new Propuesta()
            {
                Idcandidato = 7,
                Titulo = "Salud",
                Descripcion = sb.ToString(),
                Link = "https://www.martalucia.com/participa/cuales-son-tus-propuestas-para-mejorar-los-servicios"
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
                IdCandidato = 7,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Senadora de la República"
            };
            cargos.Add(cargo);
            Detalle cargo1 = new Detalle()
            {
                IdCandidato = 7,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Directora General - Incomex"
            };
            cargos.Add(cargo1);
            Detalle cargo2 = new Detalle()
            {
                IdCandidato = 7,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Viceministra - Ministerio de Comercio Exterior"                
            };
            cargos.Add(cargo2);
            Detalle cargo3 = new Detalle()
            {
                IdCandidato = 7,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Gerente General - Marta Lucía Ramírez de Rincón y Asociados"
            };
            cargos.Add(cargo3);                        
            Detalle cargo4 = new Detalle()
            {
                IdCandidato = 7,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Presidenta Ejecutiva - Invercolsa"                
            };
            cargos.Add(cargo4);
            Detalle cargo5 = new Detalle()
            {
                IdCandidato = 7,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Ministra Ministerio de Comercio Exterior"
            };
            cargos.Add(cargo5);
            Detalle cargo6 = new Detalle()
            {
                IdCandidato = 7,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Embajadora de Colombia en Francia - Ministerio de Relaciones Exteriores",
            };
            cargos.Add(cargo6);
            Detalle cargo7 = new Detalle()
            {
                IdCandidato = 7,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Ministra - Ministerio de Defensa",
            };
            cargos.Add(cargo7);
            Detalle cargo8 = new Detalle()
            {
                IdCandidato = 7,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Gerente General Ramírez & Orozco International Strategy Consultants"
            };
            cargos.Add(cargo8);
            return cargos;
        }

    }
}
