using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_02_DiegoPinochet
{
    class Espotifai
    {
        List<Cancion> Canciones = new List<Cancion>();
        public List<Playlist> List_Playlist = new List<Playlist>();
        public List<Cancion> Lista_music = new List<Cancion>();
        public Espotifai()
        {

        }

        public bool AgregarCancion(Cancion cancion)
        {
            int comparacion = 0;
            for (int x = 0; x < Canciones.Count; x++)
            {
                if (Canciones[x].Informacion() == cancion.Informacion())
                {
                    comparacion++;
                }
            }

            if (comparacion == 0)
            {
                Canciones.Add(cancion);
                return true;
            }
            else
            {
                return false;
            }

        }

        public void VerCanciones()
        {
            Console.WriteLine("Las canciones en el gestor son: ");

            foreach (Cancion elementos in Canciones)
            {
                Console.WriteLine(elementos.Informacion());
            }

        }

        public List<Cancion> CancionesPorCriterio(string criterio, string valor)
        {
            List<Cancion> CancionesCriterio = new List<Cancion>();

            if (criterio == "canción")
            {
                foreach (Cancion elementos in Canciones)
                {
                    List<string> inform = elementos.Info_Canciones();

                    if (inform.Contains(valor) == true)
                    {
                        CancionesCriterio.Add(elementos);
                    }
                }
                return CancionesCriterio;
            }

            else if (criterio == "álbum")
            {
                foreach (Cancion elementos in Canciones)
                {
                    List<string> inform = elementos.Info_Canciones();

                    if (inform.Contains(valor) == true)
                    {
                        CancionesCriterio.Add(elementos);
                    }
                }
                return CancionesCriterio;
            }

            else if (criterio == "artista")
            {
                foreach (Cancion elementos in Canciones)
                {
                    List<string> inform = elementos.Info_Canciones();

                    if (inform.Contains(valor) == true)
                    {
                        CancionesCriterio.Add(elementos);
                    }
                }
                return CancionesCriterio;
            }
            else if (criterio == "género")
            {
                foreach (Cancion elementos in Canciones)
                {
                    List<string> inform = elementos.Info_Canciones();

                    if (inform.Contains(valor) == true)
                    {
                        CancionesCriterio.Add(elementos);
                    }
                }
                return CancionesCriterio;
            }
            else
            {
                Console.WriteLine("Este criterio no existe, busca otro...");
                return CancionesCriterio;
            }
           
        }

        public bool GenerarPlaylist(string criterio_, string valorCriterio, string nombrePlaylist)
        {
            List<Cancion> Lista_musica = CancionesPorCriterio(criterio_,valorCriterio);
            Playlist playlist = new Playlist(nombrePlaylist, Lista_musica);

            //Agregar canciones a la playlist
            foreach (Cancion canciones in Lista_musica)
            {
                List<string> song = canciones.Info_Canciones();

                if (song.Contains(valorCriterio) == true)
                {
                    Lista_music.Add(canciones);
                }
                else
                {
                    Console.WriteLine("No existen canciones que satisfagan este criterio...");
                    return false;
                }

            }

            //Existe o no la playlist
            int comparacion = 0;
            for (int x = 0; x < List_Playlist.Count(); x++)
            {
                if (List_Playlist[x].Información_Playlist() == playlist.Información_Playlist())
                {
                    comparacion++;
                }
            }

            if (comparacion == 0)
            {
                List_Playlist.Add(playlist);
                return true;
            }
            else
            {
                return false;
            }

        }


        public string VermisPlaylists()
        {
            string sort_songs = "";
            string x = "";
            
            foreach (Playlist valor in List_Playlist)
            {
                x = "" + valor.Información_Playlist();

                foreach (Cancion cancion in Lista_music)
                {
                    
                    sort_songs = sort_songs + "; Informacion de la Canción: " + cancion.Informacion();
                }
            }
            string final = x + sort_songs;
            return final;
        }

    }
}
