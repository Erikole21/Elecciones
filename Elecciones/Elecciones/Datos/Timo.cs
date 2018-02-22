using Elecciones.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elecciones.Datos
{
    public class Timo
    {
        public static Detalle GetBiografia()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Es un médico cardiólogo​, político y ex guerrillero que ejerció como el último comandante en jefe de la estructura militar de las extintas Fuerzas Armadas Revolucionarias de Colombia (FARC-EP) desde 2011 hasta la transformación de la organización insurgente, el 1 de septiembre de 2017, en el partido político Fuerza Alternativa Revolucionaria del Común (FARC),​ del cual es presidente y su candidato para las elecciones presidenciales de 2018.​ Previamente había sido comandante del Bloque Magdalena Medio.");
            sb.AppendLine("Fue el tercer comandante en jefe en la historia de las FARC-EP, sucediendo a Alfonso Cano de quien heredó el liderazgo en los diálogos de paz con el gobierno de Juan Manuel Santos.");
            sb.AppendLine("En 2012, fue designado dentro del grupo negociador de las FARC-EP para acordar el fin de la guerra en Colombia con el gobierno del presidente Santos, en unas negociaciones que dieron como resultado los acuerdos de La Habana del 26 de septiembre de 2016.");
            sb.AppendLine("Londoño ha sido acusado y condenado por diversos crímenes por la justicia colombiana,​ varios de los cuales él niega.​ Durante años fue considerado terrorista por diversos países entre ellos Estados Unidos y Canadá.​ Hasta 2015 Londoño había acumulado en su contra varias acusaciones legales por sus actividades en la ex guerrilla.");
            sb.AppendLine("En diciembre de 2017, Londoño entró en el listado de 50 pensadores del año de la revista norteamericana Foreing Policy (Política Exterior)​ “por deponer las armas y colocar a Colombia en el camino hacia la paz”");
            return new Detalle()
            {
                IdCandidato = 8,
                Descripcion = sb.ToString(),
                TipoDetalle = TipoDetalle.Biografia,
                Titulo = "https://es.wikipedia.org/wiki/Rodrigo_Londoño"
            };
        }

        public static List<Propuesta> GetEscandalos()
        {
            List<Propuesta> escandalos = new List<Propuesta>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Abucheos y agresiones contra timochenko en quindio y valle.");
            Propuesta escandalo = new Propuesta()
            {
                Idcandidato = 8,
                Titulo = "Abucheos contra TimoChenko",
                Descripcion = sb.ToString(),
                Link = "http://www.semana.com/nacion/articulo/las-dos-caras-de-los-abucheos-y-agresiones-contra-timochenko-en-quindio-y-valle/556481"
            };
            escandalos.Add(escandalo);
            sb.Clear();
            sb.AppendLine("Los investigadores del CNMH recopilaron aproximadamente 30 casos de reclutamiento infantil entre 1997 y 1999, cuando 'Timochenko' era jefe de personal.");
            Propuesta escandalo1 = new Propuesta()
            {
                Idcandidato = 8,
                Titulo = "Informe implica a Timochenko en reclutamiento infantil de las Farc",
                Descripcion = sb.ToString(),
                Link = "http://www.elpais.com.co/proceso-de-paz/informe-implica-a-timochenko-en-reclutamiento-infantil-de-las-farc.html"
            };
            escandalos.Add(escandalo1);
            sb.Clear();
            sb.AppendLine("Los investigadores del CNMH recopilaron aproximadamente 30 casos de reclutamiento infantil entre 1997 y 1999, cuando 'Timochenko' era jefe de personal.");
            Propuesta escandalo2 = new Propuesta()
            {
                Idcandidato = 8,
                Titulo = "Informe implica a Timochenko en reclutamiento infantil de las Farc",
                Descripcion = sb.ToString(),
                Link = "http://www.elpais.com.co/proceso-de-paz/informe-implica-a-timochenko-en-reclutamiento-infantil-de-las-farc.html"
            };
            escandalos.Add(escandalo2);
            sb.Clear();
            sb.AppendLine("Fue condenado a 40 años de prisión por el atentado contra una embarcación que viajaba por el río Ariari, a la altura del municipio de Puerto Rico, Meta;..");
            Propuesta escandalo3 = new Propuesta()
            {
                Idcandidato = 8,
                Titulo = "Este es el prontuario delictivo de 'Timochenko' ",
                Descripcion = sb.ToString(),
                Link = "http://www.vanguardia.com/colombia/311819-este-es-el-prontuario-delictivo-de-timochenko"
            };
            escandalos.Add(escandalo3);
            sb.Clear();
            sb.AppendLine("Después de la muerte de alias 'Alfonso Cano' en 2011, 'Timochenko' asumió como número uno de las Farc, cerebro del manejo de la coca y jefe de operaciones... ");
            Propuesta escandalo4 = new Propuesta()
            {
                Idcandidato = 8,
                Titulo = "Este es el prontuario de 'Timochenko', ahora candidato presidencial",
                Descripcion = sb.ToString(),
                Link = "http://www.noticiasrcn.com/nacional-pais/este-el-prontuario-timochenko-ahora-candidato-presidencial"
            };
            escandalos.Add(escandalo4);
            sb.Clear();
            sb.AppendLine("El presidente de la Cámara respondió así al candidato presidencial de las Farc quien dijo que el congresista defiende a los responsables intelectuales del asesinato de su padre.");
            Propuesta escandalo5 = new Propuesta()
            {
                Idcandidato = 8,
                Titulo = "Timochenko es de ese tipo de personas que fusilan moralmente ",
                Descripcion = sb.ToString(),
                Link = "https://www.lafm.com.co/politica/timochenko-es-de-ese-tipo-de-personas-que-fusilan-moralmente-rodrigo-lara/"
            };
            escandalos.Add(escandalo5);
            sb.Clear();
            sb.AppendLine("Todo indica que hemos recibido un muy duro golpe que nos afecta internamente.");
            sb.AppendLine("Todos los que tengan objetivos deben entrar a actuar lo más pronto posible!.");
            sb.AppendLine("Esa orden de arreciar en sus acciones violentas la dio a sus hombres el jefe de las Farc, Rodrigo Londoño Echeverri.");
            Propuesta escandalo6 = new Propuesta()
            {
                Idcandidato = 8,
                Titulo = "El correo de 'Timochenko' que desató ola de atentados",
                Descripcion = sb.ToString(),
                Link = "http://www.eltiempo.com/archivo/documento/CMS-15985419"
            };
            escandalos.Add(escandalo6);
            sb.Clear();
            return escandalos;
        }

        public static List<Detalle> GetEstudios()
        {
            List<Detalle> estudios = new List<Detalle>();
            Detalle estudio1 = new Detalle()
            {
                IdCandidato = 8,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Médico Cardiólogo Universidad Patricio Lumumba de Moscú,"
            };
            estudios.Add(estudio1);            
            return estudios;
        }

        public static List<Propuesta> GetPropuestas()
        {
            List<Propuesta> propuestas = new List<Propuesta>();            
            Propuesta propuesta = new Propuesta()
            {
                Idcandidato = 8,
                Titulo = "Paz estable y duradera para todos y todas",                
                Link = "https://timopresidente.com.co/propuestas"
            };
            propuestas.Add(propuesta);                        
            Propuesta propuesta1 = new Propuesta()
            {
                Idcandidato = 8,
                Titulo = "Democracia sin corrupción y clientelismo",                
                Link = "https://timopresidente.com.co/propuestas"
            };
            propuestas.Add(propuesta1);            
            Propuesta propuesta2 = new Propuesta()
            {
                Idcandidato = 8,
                Titulo = "Reconomicimiento del papel protagónico de las gentes del cumun",
                Link = "https://timopresidente.com.co/propuestas"
            };
            propuestas.Add(propuesta2);            
            Propuesta propuesta3 = new Propuesta()
            {
                Idcandidato = 8,
                Titulo = "Seguridad humana y política sin armas",
                Descripcion = "Desmonte de estructuras paramilitares, Erradicar las armas de la política, proteccion de los terrenos indígenas y campesinos. Reclamo de celeridad a entes investigativos y de control",
                Link = "https://www.publimetro.co/co/noticias/2018/02/19/propuestas-timochenko-presidencia-colombia-2018.html"
            };
            propuestas.Add(propuesta3);
            Propuesta propuesta4 = new Propuesta()
            {
                Idcandidato = 8,
                Titulo = "Modelo económico plural incluyente y ambientalmente sustentable",
                Descripcion = "Modelo neoliberal se transforme en economía plural",
                Link = "https://www.publimetro.co/co/noticias/2018/02/19/propuestas-timochenko-presidencia-colombia-2018.html"
            };
            propuestas.Add(propuesta4);
            Propuesta propuesta5 = new Propuesta()
            {
                Idcandidato = 8,
                Titulo = "Ambiente sano y recuperación de los bienes naturales",
                Descripcion = "Modelo neoliberal se transforme en economía plural",
                Link = "https://www.publimetro.co/co/noticias/2018/02/19/propuestas-timochenko-presidencia-colombia-2018.html"
            };
            propuestas.Add(propuesta5);
            return propuestas;
        }

        public static List<Detalle> GetCargos()
        {
            List<Detalle> cargos = new List<Detalle>();
            Detalle cargo = new Detalle()
            {
                IdCandidato = 8,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Trabajó en el campo sembrando, cosechando, podando con azadón y machete, cortando leña y como vendedor en una tienda"
            };
            cargos.Add(cargo);
            Detalle cargo1 = new Detalle()
            {
                IdCandidato = 8,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Llegó al quinto puesto del Estado Mayor Central"
            };
            cargos.Add(cargo1);
            Detalle cargo2 = new Detalle()
            {
                IdCandidato = 8,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Uno de los siete miembros del Secretariado",
                Descripcion = "En el grupo amado FARC"
            };
            cargos.Add(cargo2);
            Detalle cargo3 = new Detalle()
            {
                IdCandidato = 8,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Miembro del Estado Mayor Central de las FARC"
            };
            cargos.Add(cargo3);                        
            Detalle cargo4 = new Detalle()
            {
                IdCandidato = 8,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Comandante en jefe de las FARC-EP"                
            };
            cargos.Add(cargo4);
            Detalle cargo5 = new Detalle()
            {
                IdCandidato = 8,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Lider del partido politico Fuerza Alternativa Revolucionaria del Común",                
            };
            cargos.Add(cargo5);            
            return cargos;
        }

    }
}
