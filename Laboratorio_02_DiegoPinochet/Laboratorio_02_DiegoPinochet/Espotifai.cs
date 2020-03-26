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
        List<Cancion> CancionesCriterio = new List<Cancion>();
        List<Playlist> List_Playlist = new List<Playlist>();
        List<Cancion> Lista_musica = new List<Cancion>();

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
            if (criterio == "canción")
            {
                foreach (Cancion elementos in Canciones)
                {
                    string songs = elementos.Informacion();
                    if (songs.Contains(valor) == true)
                    {
                        CancionesCriterio.Add(elementos);
                    }
                    else
                    {
                        Console.WriteLine("No se han encontrado canciones con criterio...");
                    }
                }
                return CancionesCriterio;
            }

            else if (criterio == "álbum")
            {
                foreach (Cancion elementos in Canciones)
                {
                    string songs = elementos.Informacion();
                    if (songs.Contains(valor) == true)
                    {
                        CancionesCriterio.Add(elementos);
                    }
                    else
                    {
                        Console.WriteLine("No se han encontrado canciones con criterio...");
                    }
                }
                return CancionesCriterio;
            }

            else if (criterio == "artista")
            {
                foreach (Cancion elementos in Canciones)
                {
                    string songs = elementos.Informacion();
                    if (songs.Contains(valor) == true)
                    {
                        CancionesCriterio.Add(elementos);
                    }
                    else
                    {
                        Console.WriteLine("No se han encontrado canciones con criterio...");

                    }
                }
                return CancionesCriterio;
            }
            else if (criterio == "género")
            {
                foreach (Cancion elementos in Canciones)
                {
                    string songs = elementos.Informacion();
                    if (songs.Contains(valor) == true)
                    {
                        CancionesCriterio.Add(elementos);
                    }
                    else
                    {
                        Console.WriteLine("No se han encontrado canciones con criterio...");

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
            Playlist playlist = new Playlist(nombrePlaylist);

            foreach (Cancion elemento in CancionesCriterio)
            {
                string sort_songs = elemento.Informacion();
                if (sort_songs.Contains(valorCriterio) == true)
                {
                    Lista_musica.Add(elemento);
                }
                else
                {
                    Console.WriteLine("No existen canciones que satisfagan este criterio...");
                    return false;
                }

            }

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
            string x = "";
            foreach (Playlist elemento in List_Playlist)
            {
                string nombre_Playlist = elemento.Información_Playlist();
                Console.WriteLine(nombre_Playlist);

                foreach (Cancion cancion in Lista_musica)
                {
                    string sort_song = cancion.Informacion();
                    return sort_song;
                }
            }
            return x;
        }

    }
}
