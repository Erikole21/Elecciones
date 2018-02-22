using Elecciones.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elecciones.Datos
{
    public class Duque
    {
        public static Detalle GetBiografia()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Abogado y político Colombiano,fue Registrador Nacional durante el Gobierno de Andrés Pastrana. ");
            sb.AppendLine("Es hermano de Andrés y María Paula Duque, esposa del periodista Néstor Morales. ");
            sb.AppendLine("Duque Márquez es abogado de la Universidad Sergio Arboleda con maestrías​ en Derecho Internacional Económico de American University y gerencia pública de Georgetown University. ");
            sb.AppendLine("Ha cursado estudios de formación continua en Negociación Estratégica, Políticas de Fomento al sector privado y Gerencia de Capital de Riesgo en las Escuelas de Negocios y Gobierno de la Universidad de Harvard. ");
            sb.AppendLine("Fue consultor de la Presidencia del Banco Interamericano de Desarrollo y asesor del Panel de Investigación conformado por el Secretario General de las Naciones Unidas.");
            sb.AppendLine("Entre los años 2001 y 2010 fue consejero principal de Colombia en el directorio ejecutivo del Banco Interamericano de Desarrollo.");
            sb.AppendLine("Es autor de los libros ¨Maquiavelo en Colombia”, Pecados Monetarios y coautor de la Economía Naranja,​ una investigación sobre el peso de las industrias creativas en la economía latinoamericana.");
            sb.AppendLine("Ha sido colaborador de la revista PODER y columnista del periódico Portafolio​ de la Casa Editorial El Tiempo en Colombia.");
            return new Detalle()
            {
                IdCandidato = 4,
                Descripcion = sb.ToString(),
                TipoDetalle = TipoDetalle.Biografia,
                Titulo = "https://es.wikipedia.org/wiki/Iván_Duque_Márquez"
            };
        }


        public static List<Propuesta> GetEscandalos()
        {
            List<Propuesta> escandalos = new List<Propuesta>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Iván Duque estuvo presente en reunión de Zuluaga con 'Duda' Mendoca. El senador del Centro Democrático aseguró que allí no se habló de dinero y que fue invitado por el excandidato presidencial.");
            Propuesta escandalo = new Propuesta()
            {
                Idcandidato = 4,
                Titulo = "Corrupción en el uribismo: Iván Duque estuvo presente en reunión",
                Descripcion = sb.ToString(),
                Link = "http://caracol.com.co/radio/2017/02/02/politica/1486074091_494614.html"
            };
            escandalos.Add(escandalo);
            sb.Clear();
            sb.AppendLine("El exministro y dirigente del Centro Democrático, Fernando Londoño, arremetió este viernes en su programa radial contra el senador");
            Propuesta escandalo1 = new Propuesta()
            {
                Idcandidato = 4,
                Titulo = "Pelea en el uribismo: Fernando Londoño arremete contra Iván Duque",
                Descripcion = sb.ToString(),
                Link = "http://www.elcolombiano.com/colombia/politica/fernando-londono-arremetio-contra-ivan-duque-MY7177916"
            };
            escandalos.Add(escandalo1);
            sb.Clear();
            sb.AppendLine("Desde que llegó al Congreso, Iván Duque, ha sido considerado como el favorito de Álvaro Uribe y del mismo modo como una de las revelaciones de la clase política. Paradójicamente, el hecho de llegar al Congreso sin ser conocido terminó por ser una virtud en la Colombia de hoy");
            Propuesta escandalo2 = new Propuesta()
            {
                Idcandidato = 4,
                Titulo = "Iván Duque, el hombre de Uribe",
                Descripcion = sb.ToString(),
                Link = "http://www.semana.com/nacion/articulo/perfil-de-ivan-duque-candidato-del-centro-democratico-elecciones-2018/550159"
            };
            escandalos.Add(escandalo2);
            sb.Clear();
            sb.AppendLine("El candidato presidencial del Centro Democrático defendió al expresidente quien, a través de las redes sociales, ha sido acusado del abuso sexual que confesó la periodista");
            Propuesta escandalo3 = new Propuesta()
            {
                Idcandidato = 4,
                Titulo = "Me hago moler por la honorabilidad de Álvaro Uribe",
                Descripcion = sb.ToString(),
                Link = "https://www.elespectador.com/noticias/politica/me-hago-moler-por-la-honorabilidad-de-alvaro-uribe-ivan-duque-articulo-735347"
            };
            escandalos.Add(escandalo3);
            sb.Clear();
            sb.AppendLine("La degradación de la contienda electoral no es el único daño que esta corriente le ha infligido a la democracia en los mandatos de Uribe se han descubierto 27 escándalos de corrupción");
            Propuesta escandalo4 = new Propuesta()
            {
                Idcandidato = 4,
                Titulo = "Uribe: seis campañas, seis escándalos",
                Descripcion = sb.ToString(),
                Link = "https://www.semana.com/opinion/articulo/leon-valencia-opinion-sobre-la-propuesta-de-alvaro-uribe-de-ley-anticorrupcion/519521"
            };
            escandalos.Add(escandalo4);
            sb.Clear();
            return escandalos;
        }

        public static List<Detalle> GetEstudios()
        {
            List<Detalle> estudios = new List<Detalle>();
            Detalle estudio = new Detalle()
            {
                IdCandidato = 4,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Abogado de la Universidad Sergio Arboleda"
            };
            estudios.Add(estudio);
            Detalle estudio1 = new Detalle()
            {
                IdCandidato = 4,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Maestrías en Finanzas y Administración Pública y Derecho Internacional de “American University” y “George Town University”, de Washington D.C."
            };
            estudios.Add(estudio1);
            Detalle estudio2 = new Detalle()
            {
                IdCandidato = 4,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Especialización en negociación de la Universidad de Harvard."
            };
            estudios.Add(estudio2);            
            return estudios;
        }

        public static List<Propuesta> GetPropuestas()
        {
            List<Propuesta> propuestas = new List<Propuesta>();            
            Propuesta propuesta = new Propuesta()
            {
                Idcandidato = 4,
                Titulo = "Salud",
                Descripcion = "10 Propuestas para mejorar la salud",
                Link = "https://d3n8a8pro7vhmx.cloudfront.net/construyendopais/pages/351/attachments/original/1515594531/Propuestas_Salud.pdf?1515594531"
            };
            propuestas.Add(propuesta);
            Propuesta propuesta1 = new Propuesta()
            {
                Idcandidato = 4,
                Titulo = "Corrupción",
                Descripcion = "10 Propuestas para combatir la corrupción",
                Link = "https://d3n8a8pro7vhmx.cloudfront.net/construyendopais/pages/351/attachments/original/1517605084/Propuestas_Corrupcion.png?1517605084"
            };
            propuestas.Add(propuesta1);
            Propuesta propuesta2 = new Propuesta()
            {
                Idcandidato = 4,
                Titulo = "Cultura",
                Descripcion = "8 Propuestas para la cultura",
                Link = "https://d3n8a8pro7vhmx.cloudfront.net/construyendopais/pages/351/attachments/original/1515593721/Propuestas_Cultura.pdf?1515593721"
            };
            propuestas.Add(propuesta2);
            Propuesta propuesta3 = new Propuesta()
            {
                Idcandidato = 4,
                Titulo = "País Emprendedor",
                Descripcion = "10 Propuestas para un país emprendedor",
                Link = "https://d3n8a8pro7vhmx.cloudfront.net/construyendopais/pages/351/attachments/original/1515593725/Propuestas_Emprendimiento.pdf?1515593725"
            };
            propuestas.Add(propuesta3);
            Propuesta propuesta4 = new Propuesta()
            {
                Idcandidato = 4,
                Titulo = "Familia",
                Descripcion = "6 Propuestas para la familia",
                Link = "https://d3n8a8pro7vhmx.cloudfront.net/construyendopais/pages/351/attachments/original/1515593731/Propuestas_Familia.pdf?1515593731"
            };
            propuestas.Add(propuesta4);
            Propuesta propuesta5 = new Propuesta()
            {
                Idcandidato = 4,
                Titulo = "Seguridad",
                Descripcion = "12 Propuestas para la seguridad",
                Link = "https://d3n8a8pro7vhmx.cloudfront.net/construyendopais/pages/351/attachments/original/1515593735/Propuestas_Seguridad.pdf?1515593735"
            };
            propuestas.Add(propuesta5);
            Propuesta propuesta6 = new Propuesta()
            {
                Idcandidato = 4,
                Titulo = "Educación",
                Descripcion = "10 Propuestas para la educación",
                Link = "https://d3n8a8pro7vhmx.cloudfront.net/construyendopais/pages/351/attachments/original/1515594703/Propuestas_Educación.pdf?1515594703"
            };
            propuestas.Add(propuesta6);
            return propuestas;
        }

        public static List<Detalle> GetCargos()
        {
            List<Detalle> cargos = new List<Detalle>();
            Detalle cargo = new Detalle()
            {
                IdCandidato = 4,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Senado de la República",
                Descripcion= "Se ha opuesto a la venta de empresas públicas como ISAGEN, Ecopetrol, entre otras. También se opuso a las reformas tributarias del 2014 y 2016, votó en contra del aumento del IVA."
            };
            cargos.Add(cargo);
            Detalle cargo1 = new Detalle()
            {
                IdCandidato = 4,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Columnista",
                Descripcion = "Diarios como Portafolio. Hoy también escribe de manera continua para El País, de España, El Colombiano, de Medellín, y el portal noticioso Kien & Ke, sobre temas de actualidad política y democracia"
            };
            cargos.Add(cargo1);
            Detalle cargo2 = new Detalle()
            {
                IdCandidato = 4,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Asesor Internacional",
                Descripcion = "Del ex – Presidente Álvaro Uribe Vélez en su gesta internacional en Defensa de la Democracias de nuestro hemisferio y la promoción de Colombia en el exterior."
            };
            cargos.Add(cargo2);            
            return cargos;
        }
    }
}
