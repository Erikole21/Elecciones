using Elecciones.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elecciones.Datos
{
    public class Piedad
    {
        public static Detalle GetBiografia()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Abogada y política colombiana. Ha sido miembro del Partido Liberal durante toda su vida política y líder del movimiento Poder Ciudadano Siglo XXI, ubicado en el ala izquierda de su partido. Como congresista trabajó principalmente por los derechos de la mujer, las minorías étnicas y sexuales (sociedad LGBT) y los derechos humanos.");
            sb.AppendLine("Fue Senadora de la República desde 1994 hasta su destitución en el 2010, luego de que la Procuraduría General de la Nación, en cabeza de Alejandro Ordóñez, la acusara de colaboración con las FARC, en el denominado «Caso Piedad Córdoba». El 27 de septiembre de 2010 fue inhabilitada en primera instancia por un periodo de 18 años para ejercer cualquier cargo público en la República de Colombia.");
            sb.AppendLine("Sin embargo, luego de una larga investigación, ﻿el 11 de octubre de 2016 el Consejo del Estado retiró ambas inhabilidades por falta de pruebas sobre los supuestos vínculos de la ex-senadora con la guerrilla de las FARC decisión que le devuelve a Piedad Córdoba la posibilidad de ocupar cargos públicos y de elección popular.");
            sb.AppendLine("Córdoba continuó trabajando por la liberación de los secuestrados y logró convocar a un grupo de intelectuales de varios países para iniciar un diálogo epistolar con la cúpula de las FARC.​ Gracias al intercambio epistolar, las FARC respondieron los pronunciamientos de Córdoba y su grupo Colombianos y Colombianas por la Paz y decidieron liberar unilateralmente a tres policías y un soldado y a los últimos dos rehenes políticos que permanecían en su poder. ");
            sb.AppendLine("Para la operación de la liberación, llevada a cabo en febrero de 2009, la senadora contó con el apoyo de el CICR y el gobierno de Brasil, así como con la autorización del gobierno colombiano.10​ Por estos actos, el Premio Nobel de la Paz Adolfo Pérez Esquivel propuso públicamente, y de manera formal ante el Comité del premio Nobel en Oslo, el nombre de Córdoba como candidata al Premio Nobel de la Paz 2009, La senadora se declaró no merecedora del premio,12​ aunque su nombre figuró entre los favoritos para obtenerlo.13​ Finalmente el premio recayó en el Presidente de los Estados Unidos Barack Obama.");
            return new Detalle()
            {
                IdCandidato = 9,
                Descripcion = sb.ToString(),
                TipoDetalle = TipoDetalle.Biografia,
                Titulo = "https://es.wikipedia.org/wiki/Piedad_Córdoba"
            };
        }

        public static List<Propuesta> GetEscandalos()
        {
            List<Propuesta> escandalos = new List<Propuesta>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("La Procuraduría informó que cuenta con las pruebas suficientes para iniciar una investigación formal contra la senadora por sus supuestos vínculos con las Farc. Formulan cargos contra Piedad Córdoba por 'Farcpolítica' La senadora liberal");
            Propuesta escandalo = new Propuesta()
            {
                Idcandidato = 9,
                Titulo = "Formulan cargos contra Piedad Córdoba por 'Farcpolítica'",
                Descripcion = sb.ToString(),
                Link = "http://www.semana.com/nacion/articulo/formulan-cargos-contra-piedad-cordoba-farcpolitica/115454-3"
            };
            escandalos.Add(escandalo);
            sb.Clear();
            sb.AppendLine("La Procuraduría deberá pagar a la excongresista una indemnización por daños y perjuicios. La suma podría superar los $1.000 millones.");
            Propuesta escandalo1 = new Propuesta()
            {
                Idcandidato = 9,
                Titulo = "$1.000 millones de indemnización pagará Procuraduría a Piedad",
                Descripcion = sb.ToString(),
                Link = "http://www.semana.com/nacion/articulo/mas-de-1000-millones-de-indemnizacion-pagara-procuraduria-a-piedad-cordoba/486391"
            };
            escandalos.Add(escandalo1);
            sb.Clear();
            sb.AppendLine("En el primer Congreso Binacional de Mujeres que se desarrolla en el estado de Táchira en Venezuela participó la líder Piedad Córdoba. Sus palabras han generado diferentes posturas en las redes sociales.");
            Propuesta escandalo2 = new Propuesta()
            {
                Idcandidato = 9,
                Titulo = "Polémica por declaraciones de Piedad Córdoba en Venezuela",
                Descripcion = sb.ToString(),
                Link = "https://www.publimetro.co/co/actualidad/2017/04/08/polemica-declaraciones-piedad-cordoba-venezuela.html"
            };
            escandalos.Add(escandalo2);
            sb.Clear();
            sb.AppendLine("Piedad Córdoba dijo que aunque Alejandro Ordóñez le hizo “tanto daño” al sacarla del Congreso, ella no le guarda rencor. “No lo odio porque el odio amarra, no deja ver hacia adelante, no deja ver el futuro”");
            Propuesta escandalo3 = new Propuesta()
            {
                Idcandidato = 9,
                Titulo = "Así fue el 'agarrón' entre Ordóñez y Piedad en un foro sobre corrupción",
                Descripcion = sb.ToString(),
                Link = "https://www.pulzo.com/elecciones-2018/agarron-entre-alejandro-ordonez-piedad-cordoba-foro-sobre-corrupcion/PP439006"
            };
            escandalos.Add(escandalo3);
            sb.Clear();
            sb.AppendLine("La W Radio pudo establecer que Camilo Castro Córdoba, hijo de la ex senadora Piedad Córdoba fue detenido en la ciudad de Medellín, por conducir una camioneta que había sido reportada como hurtada el año pasado en la ciudad de Cali.");
            Propuesta escandalo4 = new Propuesta()
            {
                Idcandidato = 9,
                Titulo = "Capturan al hijo de Piedad Córdoba por conducir camioneta robada",
                Descripcion = sb.ToString(),
                Link = "https://www.wradio.com.co/noticias/actualidad/8203capturan-al-hijo-de-piedad-cordoba-por-conducir-camioneta-robada/20160204/nota/3052837.aspx"
            };
            escandalos.Add(escandalo3);
            sb.Clear();
            return escandalos;
        }

            public static List<Detalle> GetEstudios()
        {
            List<Detalle> estudios = new List<Detalle>();
            Detalle estudio1 = new Detalle()
            {
                IdCandidato = 9,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Abogada en la Universidad Pontificia Bolivariana de Medellín"
            };
            estudios.Add(estudio1);
            Detalle estudio2 = new Detalle()
            {
                IdCandidato = 9,
                TipoDetalle = TipoDetalle.Estudio,
                Titulo = "Especialista en Opinión Pública y Mercadeo en la Pontificia Universidad Javeriana"
            };
            estudios.Add(estudio2);
            return estudios;
        }

        public static List<Propuesta> GetPropuestas()
        {
            List<Propuesta> propuestas = new List<Propuesta>();
            Propuesta propuesta = new Propuesta()
            {
                Idcandidato = 9,
                Titulo = "Crear un ministerio de ciencia, tecnología e innovación",
                Link = "http://www.eltiempo.com/tecnosfera/novedades-tecnologia/las-propuestas-de-piedad-cordoba-en-el-sector-tic-183576"
            };
            propuestas.Add(propuesta);
            Propuesta propuesta1 = new Propuesta()
            {
                Idcandidato = 9,
                Titulo = "Eliminar el IVA",
                Link = "http://www.eltiempo.com/elecciones-colombia-2018/presidenciales/piedad-cordoba-propone-eliminar-el-iva-si-llega-a-la-presidencia-162282"
            };
            propuestas.Add(propuesta1);
            Propuesta propuesta2 = new Propuesta()
            {
                Idcandidato = 9,
                Titulo = "Educación universitaria gratis",
                Link = "http://www.eluniversal.com.co/colombia/piedad-cordoba-propone-educacion-universitaria-gratis-272328"
            };
            propuestas.Add(propuesta2);
            Propuesta propuesta3 = new Propuesta()
            {
                Idcandidato = 9,
                Titulo = "Eliminar comisiones de los bancos",
                Link = "http://www.elcolombiano.com/elecciones-2018-colombia/piedad-cordoba-propone-eliminar-comisiones-de-los-bancos-EY8144622"
            };
            propuestas.Add(propuesta3);
            return propuestas;
        }

        public static List<Detalle> GetCargos()
        {
            List<Detalle> cargos = new List<Detalle>();
            Detalle cargo = new Detalle()
            {
                IdCandidato = 9,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Subcontralora municipal de Medellín"
            };
            cargos.Add(cargo);
            Detalle cargo1 = new Detalle()
            {
                IdCandidato = 9,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Cámara de Representantes de Colombia"
            };
            cargos.Add(cargo1);
            Detalle cargo2 = new Detalle()
            {
                IdCandidato = 9,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Senado de la República",
            };
            cargos.Add(cargo2);
            Detalle cargo3 = new Detalle()
            {
                IdCandidato = 9,
                TipoDetalle = TipoDetalle.Antecedente,
                Titulo = "Facilitadora del acuerdo humanitario"
            };
            cargos.Add(cargo3);
            return cargos;
        }

    }
}
