using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_02_DiegoPinochet
{
    class Playlist
    {
        private List<Cancion> Lista_musica = new List<Cancion>();
        private string nombre;


        public Playlist(string nombre, List<Cancion> Lista_musica)
        {
            this.nombre = nombre;
            this.Lista_musica = Lista_musica;
        }

        public string Información_Playlist()
        {
            string info_playlist = ("Nombre de la PLaylist: " + nombre);
            return info_playlist;
        }
    }
}
