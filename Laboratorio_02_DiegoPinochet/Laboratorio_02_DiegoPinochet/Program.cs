using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_02_DiegoPinochet
{
    class Program
    {
        static void Main(string[] args)
        {
            Espotifai spotify = new Espotifai();

            Console.WriteLine("Bienvenido a Espotifai, aquí está el menú: ");

            Console.WriteLine("");

            Console.WriteLine("**Elige una opción escribiendo el numero que se le otorga.**");

            Console.WriteLine("1. Ver todas las canciones.");
            Console.WriteLine("2. Agregar una canción.");
            Console.WriteLine("3. Ver canciones por criterio.");
            Console.WriteLine("4. Ver Playlists");
            Console.WriteLine("5. Cerrar el programa");

            bool x = true;

            while (x == true)
            {
                string eleccion = Console.ReadLine();

                if (eleccion == "1")
                {
                    spotify.VerCanciones();
                }

                else if (eleccion == "2")
                {
                    Console.WriteLine("Para agregar una canción escribe su: nombre, album, artista y genero.");
                    string Name = Console.ReadLine();
                    string Albums = Console.ReadLine();
                    string Artist = Console.ReadLine();
                    string Gender = Console.ReadLine();

                    Cancion cancion = new Cancion(Name, Albums, Artist, Gender);

                    bool u = spotify.AgregarCancion(cancion);
                    if (u == false)
                    {
                        Console.WriteLine(u);
                    }
                    else
                    {
                        Console.WriteLine(u);
                    }

                    Console.WriteLine("Puede ver la lista de canciones (1), agregar más canciones (2), ver listas por criterio (3), ver lista de playlist (4) o cerrar el programa (5)...");

                }
                else if (eleccion == "3")
                {
                    Console.WriteLine("Elige un criterio para ver las canciones (canción, álbum, artista o género): ");
                    string criterio = Console.ReadLine();

                    if (criterio == "canción" || criterio == "álbum" || criterio == "artista" || criterio == "género")
                    {
                        Console.WriteLine("Dime en específico que canción, álbum, artista o género buscas...");
                        string valor = Console.ReadLine();

                        List<Cancion> CancionesCriterio = spotify.CancionesPorCriterio(criterio, valor);

                        foreach (Cancion elemento in CancionesCriterio)
                        {
                            string song = elemento.Informacion();
                            Console.WriteLine(song);
                        }
                    }
                }
                else if (eleccion == "4")
                {
                    Console.WriteLine("Elige un criterio para crear la playlist(canción, álbum, artista o género): ");
                    string criterio_ = Console.ReadLine();

                    if (criterio_ == "canción" || criterio_ == "álbum" || criterio_ == "artista" || criterio_ == "género")
                    {
                        Console.WriteLine("Dime en específico que canción, álbum, artista o género buscas...");
                        string valorCriterio = Console.ReadLine();
                        Console.WriteLine("Dime el nombre que le pondras a la playlist: ");
                        string nombrePlaylist = Console.ReadLine();

                        bool i = spotify.GenerarPlaylist(criterio_, valorCriterio, nombrePlaylist);
                        if (i == false)
                        {
                            Console.WriteLine("Ya existe una Playlist con este nombre, intentelo de nuevo con otro nombre...");
                            Console.WriteLine(i);
                        }
                        else
                        {
                            Console.WriteLine(i);
                        }
                    }

                    else
                    {
                        Console.WriteLine("Criterio inválido, intentelo de nuevo...");
                    }
                }

                else if (eleccion == "5")
                {

                }





                    else
                    {
                        break;
                    }

            }
        }
    }
}
