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
        List<Playlist> List_Playlist = new List<Playlist>();

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
            List<Cancion> Lista_musi = CancionesPorCriterio(criterio_, valorCriterio);
            List<Cancion> Lista_music = new List<Cancion>();

            Playlist playlist = new Playlist(nombrePlaylist, Lista_music);

            //Agregar canciones a la playlist

            foreach(Cancion elemento in Lista_musi)
            {
                List<string> song = elemento.Info_Canciones();
                if (song.Contains(valorCriterio) == true)
                {
                    Lista_music.Add(elemento);
                }
                else
                {
                    Console.WriteLine("No existen canciones que satisfagan este criterio, intete otra vez...");
                    return false;
                }
            }

            int cont = 0;

            for (int i = 0; i < List_Playlist.Count; i++)
            {
                if (List_Playlist[i].Información_Playlist() == playlist.Información_Playlist())
                {
                    cont++;
                }
            }

            if(cont == 0)
            {
                List_Playlist.Add(playlist);
                return true;
            }
            else
            {
                Console.WriteLine("Ya existe una Playlist con este nombre, intentelo otra vez...");
                return false;
            }
            

        }


        public string VermisPlaylists()
        {
            string x = "";

            for (int y = 0; y < List_Playlist.Count(); y++)
            {
                foreach(Cancion elemento in List_Playlist[y].Info_List())
                {
                    string final = elemento.Informacion();
                    x = x + List_Playlist[y].Información_Playlist() + "\n" + "Información CANCION: " + final + ". \n";
                }

            }
            return x;

        }
    }
}

