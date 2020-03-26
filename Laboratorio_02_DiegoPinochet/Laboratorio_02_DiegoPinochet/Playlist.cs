using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_02_DiegoPinochet
{
    class Playlist
    {
        Cancion[] playlist = new Cancion[2];

        private string nombre;


        public Playlist(string nombre)
        {
            this.nombre = nombre;
        }

        public string Información_Playlist()
        {
            string info_playlist = ("Nombre de la PLaylist: " + nombre);
            return info_playlist;
        }
    }
}
