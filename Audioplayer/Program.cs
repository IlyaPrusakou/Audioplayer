using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Audioplayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song
            {
                Duration = 300,
                Title = "Cvet nastroenia sinii",
                SongGenre = "Metal",
                Lyrics = "lalala",
                Artist = new Artist { Name = "Kirkorov" }
            };
            Song song2 = new Song();


                song2.Duration = 300;
                song2.Title = "Anaconda";
                song2.SongGenre = "Pop";
                song2.Lyrics = "lalala";
                song2.Artist = new Artist { Name = "Minaj" };

            Player player = new Player();
            player.Songs = new[] { song1, song2 };

            while (true)
            {
                switch (ReadLine())
                {
                    case "a":
                        {
                            player.VolumeUp();
                            break;
                        }
                    case "s":
                        {
                            player.VolumeDown();
                            break;
                        }
                    case "d": 
                        {
                            player.Start();
                            break;
                        }
                         
                }
            }

            

            Console.ReadLine();
        }
    }
}
