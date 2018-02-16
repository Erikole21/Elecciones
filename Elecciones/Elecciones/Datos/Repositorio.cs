using Elecciones.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Elecciones.Datos
{
    public class Repositorio
    {
        public static List<Candidato> GetCandidatos()
        {
            List<Candidato> candidatos = new List<Candidato>();
            Candidato fajardo = new Candidato()
            {
                Id = 1,
                Nombre = "Sergio Fajardo Valderrama",
                Foto = ImageSource.FromResource("Elecciones.Imagenes.Fajardo.jpg"),
                Edad = $"{ Math.Abs(DateTime.Now.Subtract(new DateTime(1956, 06, 19)).TotalDays / 365) } Años",
                Origen = "Medellín",
                PartidoPolitico = "Coalición Colombia conformada por el Polo Democrático Alternativo, la Alianza Verde y el Movimiento Compromiso Ciudadano",
                Slogan = "Compromiso Ciudadano"
            };
            candidatos.Add(fajardo);
            Candidato petro = new Candidato()
            {
                Id = 2,
                Nombre = "Gustavo Francisco Petro Urrego",
                Foto = ImageSource.FromResource("Elecciones.Imagenes.Petro.jpg"),
                Edad = $"{ Math.Abs(DateTime.Now.Subtract(new DateTime(1960, 4, 19)).TotalDays / 365) } Años",
                Origen = "Ciénaga de Oro, Córdoba",
                PartidoPolitico = "Movimiento Progresistas",
                Slogan = "Colombia Humana"
            };
            candidatos.Add(petro);
            Candidato lleras = new Candidato()
            {
                Id = 3,
                Nombre = "Germán Vargas Lleras",
                Foto = ImageSource.FromResource("Elecciones.Imagenes.LLeras.jpg"),
                Edad = $"{ Math.Abs(DateTime.Now.Subtract(new DateTime(1962, 2, 19)).TotalDays / 365) } Años",
                Origen = "Bogotá",
                PartidoPolitico = "Cambio Radical",
                Slogan = "Mejor Vargas Lleras"
            };
            candidatos.Add(lleras);
            Candidato duque = new Candidato()
            {
                Id = 4,
                Nombre = "Iván Duque Márquez",
                Foto = ImageSource.FromResource("Elecciones.Imagenes.Duque.jpg"),
                Edad = $"{ Math.Abs(DateTime.Now.Subtract(new DateTime(1976, 8, 1)).TotalDays / 365) } Años",
                Origen = "Bogotá",
                PartidoPolitico = "Centro Democrático",
                Slogan = "Centro Democrático"
            };
            candidatos.Add(duque);
            Candidato ordonez = new Candidato()
            {
                Id = 5,
                Nombre = "Alejandro Ordóñez Maldonado",
                Foto = ImageSource.FromResource("Elecciones.Imagenes.Ordonez.jpg"),
                Edad = $"{ Math.Abs(DateTime.Now.Subtract(new DateTime(1955, 5, 29)).TotalDays / 365) } Años",
                Origen = "Bucaramanga, Santander",
                PartidoPolitico = "",
                Slogan = "La patria de pie"
            };
            candidatos.Add(ordonez);
            Candidato calle = new Candidato()
            {
                Id = 6,
                Nombre = "Humberto de la Calle Lombana",
                Foto = ImageSource.FromResource("Elecciones.Imagenes.Calle.jpg"),
                Edad = $"{ DateTime.Now.Subtract(new DateTime(1946, 7, 14)).TotalDays / 365 } Años",
                Origen = "Manzanares, Caldas",
                PartidoPolitico = "Liberal",
                Slogan = ""
            };
            candidatos.Add(calle);
            Candidato marta = new Candidato()
            {
                Id = 7,
                Nombre = "Marta Lucía Ramírez Blanco",
                Foto = ImageSource.FromResource("Elecciones.Imagenes.Marta.jpg"),
                Edad = $"{ Math.Abs(DateTime.Now.Subtract(new DateTime(1954, 7, 4)).TotalDays / 365) } Años",
                Origen = "Zipaquirá",
                PartidoPolitico = "Conservador",
                Slogan = "Por una Colombia Honesta y Fuerte Marta Lucía"
            };
            candidatos.Add(marta);
            Candidato timo = new Candidato()
            {
                Id = 8,
                Nombre = "Rodrigo Londoño Echeverri",
                Foto = ImageSource.FromResource("Elecciones.Imagenes.Timo.jpg"),
                Edad = $"{ Math.Abs(DateTime.Now.Subtract(new DateTime(1959, 1, 20)).TotalDays / 365) } Años",
                Origen = "La Tebaida, Quindío",
                PartidoPolitico = "Fuerza Alternativa Revolucionaria del Común",
                Slogan = "FARC"
            };
            candidatos.Add(timo);
            Candidato piedad = new Candidato()
            {
                Id = 9,
                Nombre = "Piedad Esneda Córdoba Ruíz",
                Foto = ImageSource.FromResource("Elecciones.Imagenes.Piedad.jpg"),
                Edad = $"{ Math.Abs(DateTime.Now.Subtract(new DateTime(1955, 1, 25)).TotalDays / 365) } Años",
                Origen = "Medellín",
                PartidoPolitico = "Poder Ciudadano Siglo XXI",
                Slogan = "Poder Ciudadano"
            };
            candidatos.Add(piedad);

            return candidatos;
        }
    }
}
