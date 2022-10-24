using BackEnd_ejemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd_ejemplo1.Services;


public class PeliculaService
{
    public Peliculas()
    {
        public List<Peliculas> ObtenerPelicula()
        {
            var pelicula1 = new Peliculas()
            {
                Titulo = "SuperMan",
                Duracion = 150,
                Pais = "USA",
                Publicacion = new DateTime(2012, 12, 11)
            };

            var pelicula2 = new Peliculas()
            {
                Titulo = "SpiderMan",
                Duracion = 180,
                Pais = "USA",
                Publicacion = new DateTime(2015, 05, 02)
            };

            return new List<Peliculas> { pelicula1, pelicula2 };
        }
    }
}
}