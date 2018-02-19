using Elecciones.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elecciones.Datos
{
    public class Ordonez
    {
        public static Detalle GetBiografia()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Alejandro Ordóñez Maldonado (Bucaramanga, Santander; 29 de mayo de 1955) es un abogado y político colombiano. Es egresado de la Universidad Santo Tomás de Bucaramanga.");
            sb.AppendLine("El menor de cinco hermanos, es hijo de Mary Maldonado y Miguel Ordoñez, un empresario y antropólogo que fundó una fábrica de galletas llamada La Aurora.3​");
            sb.AppendLine("Estudió en el Colegio San Pedro Claver,4​ posteriormente ingresó a la Universidad Santo Tomás donde terminó sus estudios de pregrado en Ciencias Políticas y Derecho vinculándose a la docencia en esta institución.");
            sb.AppendLine("En la Universidad Santo Tomas de Bucaramanga se especializó en Derecho Administrativo.");
            sb.AppendLine("Ordoñez es un reconocido exponente de la ideología conservadora en Colombia.");
            sb.AppendLine("Entre sus posiciones ideólogias están la oposición a la adopción homosexual y al matrimonio del mismo sexo además de estar opuesto al aborto. El 24 de julio de 2013, la Corte Constitucional rechazó la solicitud de Ordóñez de anular la sentencia C-577 de 2011, donde se avalaban las uniones homosexuales.");
            sb.AppendLine("Ordóñez acató la sentencia, aunque pidió a notarios no realizar uniones con la forma jurídica del matrimonio y solicitó al Superintendente de Notariado y Registro no crear una cartilla donde estas uniones se constituyesen bajo la forma legal del matrimonio.");
            sb.AppendLine("En abril de 2016, la Corte Constitucional otorga legalidad jurídica a los matrimonios civiles entre parejas de mismo sexo, otorgándoles los mismos derechos y beneficios de un matrimonio heterosexual.​ Ordoñez rechaza este nuevo fallo, argumentando que la Corte esta \"legislando\" para modificar la Constitución y solicitó al Congreso de la República un Acto Legislativo para reversar el fallo del máximo tribunal.");
            return new Detalle()
            {
                IdCandidato = 5,
                Descripcion = sb.ToString(),
                TipoDetalle = TipoDetalle.Biografia,
                Titulo = "https://es.wikipedia.org/wiki/Alejandro_Ordóñez"
            };
        }

        public static List<Detalle> GetEstudios()
        {
            List<Detalle> estudios = new List<Detalle>();
            Detalle estudio = new Detalle()
            {
                IdCandidato = 5,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Pregrado en Ciencias Políticas y Derecho. Universidad Santo Tomás"
            };
            estudios.Add(estudio);
            Detalle estudio1 = new Detalle()
            {
                IdCandidato = 5,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Especializacion en Derecho Administrativo. Universidad Santo Tomás"
            };
            estudios.Add(estudio1);
            Detalle estudio2 = new Detalle()
            {
                IdCandidato = 5,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Profesor de Filosofía de la Facultad de Derecho de la Universidad Santo Tomás"
            };
            estudios.Add(estudio2);
            Detalle estudio3 = new Detalle()
            {
                IdCandidato = 5,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Magíster Honoris Causa en Ciencias Políticas de la Universidad de Salerno"
            };
            estudios.Add(estudio3);
            return estudios;
        }

        public static List<Propuesta> GetPropuestas()
        {
            List<Propuesta> propuestas = new List<Propuesta>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ampliaré la cobertura pensional: eliminaré las trabas legales que impiden el reconocimiento de la pensión familiar, crearé pensiones asistenciales para los mayores de 70 años sin ingresos; la crianza de las madres se tendrá en cuenta como tiempo de cotización y crearé un sistema de pilares para acabar la competencia de los fondos");
            Propuesta propuesta = new Propuesta()
            {
                Idcandidato = 5,
                Titulo = "Pensiones",
                Descripcion = sb.ToString(),
                Link = "https://ordonezpresidente.co/pensiones/"
            };
            propuestas.Add(propuesta);
            sb.Clear();
            sb.AppendLine("Las políticas se construirán en perspectiva de familia porque es allí donde se inculcan los valores de los colombianos.");
            sb.AppendLine("Con los ojos puestos en la familia veremos con seguridad que los sectores de la salud, la educación, las pensiones, los impuestos y la economía en general empezarán a mejorar");
            Propuesta propuesta1 = new Propuesta()
            {
                Idcandidato = 5,
                Titulo = "Familia",
                Descripcion = sb.ToString(),
                Link = "https://ordonezpresidente.co/familia/"
            };
            propuestas.Add(propuesta1);
            sb.Clear();

            sb.AppendLine("La seguridad y la defensa se centrarán en la protección de las familias colombianas. Desarrollaré políticas públicas eficientes para prevenir el delito con apoyo de las Policía Nacional y demás instituciones.");
            sb.AppendLine("Mi Gobierno sí perseguirá el narcotráfico en toda la cadena de producción y distribución y reforzaré la seguridad del campo colombiano");
            Propuesta propuesta2 = new Propuesta()
            {
                Idcandidato = 5,
                Titulo = "Seguridad",
                Descripcion = sb.ToString(),
                Link = "https://ordonezpresidente.co/seguridad-2/"
            };
            propuestas.Add(propuesta2);
            sb.Clear();
            sb.AppendLine("Las EPS no pueden continuar siendo intermediarias del sector, ni en el pago a las IPS ni en el acceso a los servicios.");
            sb.AppendLine("No toleraré más Entidades Promotoras de Salud quebradas que impidan a las familias el acceso efectivo a los servicios de salud. ");
            sb.AppendLine("Las EPS que no cumplan con su deber de prevención y protección deben salir del sistema.");
            Propuesta propuesta3 = new Propuesta()
            {
                Idcandidato = 5,
                Titulo = "Salud",
                Descripcion = sb.ToString(),
                Link = "https://ordonezpresidente.co/salud/"
            };
            propuestas.Add(propuesta3);
            sb.Clear();

            sb.AppendLine("Convocaré una Asamblea Nacional Constituyente para reconstruir la patria. ");
            sb.AppendLine("Debemos dirigir nuestros esfuerzos para saldar la deuda con el pueblo colombiano tras el robo del 2 de octubre de 2016, ante el ilegítimo acuerdo de La Habana. ");
            sb.AppendLine("Reformaré el actual diseño institucional que fue destruido por el actual gobierno y protegeré las políticas públicas contrarias al fortalecimiento y la defensa de la familia");
            Propuesta propuesta4 = new Propuesta()
            {
                Idcandidato = 5,
                Titulo = "Corrupción",
                Descripcion = sb.ToString(),
                Link = "https://ordonezpresidente.co/lucha-contra-la-corrupcion/"
            };
            propuestas.Add(propuesta4);
            sb.Clear();
            sb.AppendLine("Brindaré espacios óptimos de aseguramiento para las mujeres, niños y adolescentes, los cuales impacten en su familia como núcleo central de la sociedad, calidad de vida y transformación del entorno");
            Propuesta propuesta5 = new Propuesta()
            {
                Idcandidato = 5,
                Titulo = "Mujeres",
                Descripcion = sb.ToString(),
                Link = "https://ordonezpresidente.co/mujeres/"
            };
            propuestas.Add(propuesta5);
            sb.Clear();            
            sb.AppendLine("Aliviaré la carga tributaria a las empresas y consumidores, bajando la Renta del 33% al 30%, el IVA volverá al 16%, y reestructuraré el exceso de entidades creadas por este Gobierno que representan un gasto innecesario para el Estado");
            Propuesta propuesta6 = new Propuesta()
            {
                Idcandidato = 5,
                Titulo = "Economía",
                Descripcion = sb.ToString(),
                Link = "https://ordonezpresidente.co/economia/"
            };
            propuestas.Add(propuesta6);            
            return propuestas;
        }

        public static List<Detalle> GetCargos()
        {
            List<Detalle> cargos = new List<Detalle>();
            Detalle cargo = new Detalle()
            {
                IdCandidato = 5,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Director del Centro de Investigaciones Socio-Jurídicas, Universidad Santo Tomás en Bucaramanga y Bogotá"
            };
            cargos.Add(cargo);
            Detalle cargo1 = new Detalle()
            {
                IdCandidato = 5,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Docente en la Escuela de Derecho y Ciencia Política ",
                Descripcion = "De la Universidad Sergio Arboleda, la Universidad Católica, la Universidad Autónoma de Bucaramanga, la Universidad Autónoma de Nariño, la Universidad Nacional y la Universidad Industrial de Santander"
            };
            cargos.Add(cargo1);
            Detalle cargo2 = new Detalle()
            {
                IdCandidato = 5,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Concejal de Bucaramanga",
                Descripcion = "Por el Partido Conservador en el periodo 1986-1989."
            };
            cargos.Add(cargo2);
            Detalle cargo3 = new Detalle()
            {
                IdCandidato = 5,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Senado de Colombia"
            };
            cargos.Add(cargo3);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Con su gestión la entidad por primera vez en su historia usó la función sancionatoria de la entidad para destituir a Congresistas, la mayoría fueron destituidos por parapolítica.​");
            sb.AppendLine("Ordóñez, destituyó, suspendió e inhabilitó a diversos altos funcionarios, ministros, gobernadores, alcaldes y congresistas de diversos partidos.12​ Entre ellos al exministro de Agricultura, Andrés Felipe Arias, a quien inhabilitó por malversación de fondos y contratación indebida, a la exsenadora Piedad Córdoba el ministerio público la inhabilitó por haber realizado reuniones ilegales con la guerrilla de las FARC, a las congresistas Eleonora Pineda y Rocío Arias la Procuraduría las destituyó por parapolítica, al exalcalde Samuel Moreno Rojas lo inhabilitó por falta de gestión para evitar las demoras de los contratistas de la calle 26 de Bogotá y a su hermano el excongresista Iván lo inhabilitó por el llamado Carrusel de la Contratación por medio del cual los hermanos permitieron la malversación de fondos por parte de los contratistas de la calle 26 apropiándose de recursos del erario público. Entre otros destituyó al exministro Sabas Pretelt de la Vega,​ a los exdirectores del DAS Jorge Noguera y María del Pilar Hurtado, al exsecretario general de la Presidencia de Álvaro Uribe Bernardo Moreno, al exdirector nacional de estupefacientes Carlos Albornoz, al exconcejal de Bogotá Hipólito Moreno, al exsuperintendente financiero Gerardo Hernández Correa, al exalcalde de Medellín Alonso Salazar, al alcalde de Bogotá Gustavo Petro, su secretario Guillermo Asprilla y al exgerente del Acueducto de Bogotá Diego Bravo.");
            Detalle cargo4 = new Detalle()
            {
                IdCandidato = 5,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Procurador General de la Nación (2009-2016)",
                Descripcion = sb.ToString()
            };
            cargos.Add(cargo4);
            return cargos;
        }

    }
}
