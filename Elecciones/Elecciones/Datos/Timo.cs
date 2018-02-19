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
