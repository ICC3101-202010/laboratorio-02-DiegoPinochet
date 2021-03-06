﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_02_DiegoPinochet
{
    class Cancion
    {
        private List<string> Info_Cancion = new List<string>();

        private string Nombre;
        private string Album;
        private string Artista;
        private string Genero;

        public Cancion(string nombre, string album, string artista, string genero)
        {
            this.Nombre = nombre;
            this.Album = album;
            this.Artista = artista;
            this.Genero = genero;
        }

        public string Informacion()
        {
            string informacion = ("genero: " + Genero + ", artista: " + Artista + ", album: " + Album + ", nombre: " + Nombre);

            return informacion;
        }

        public List<string> Info_Canciones()
        {
            Info_Cancion.Add(Genero);
            Info_Cancion.Add(Artista);
            Info_Cancion.Add(Album);
            Info_Cancion.Add(Nombre);

            return Info_Cancion;
        }
    }
}
