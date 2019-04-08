using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audioplayer
{
    class Player
    {
        private int Volume;
        const int minVolume = 0;
        const int maxVolume = 100;
        bool IsLock;
        public Song[] Songs;

        public int volume 
            {
                get
                {
                    return Volume;
                }
                set
                {
                    if (Volume < minVolume)
                    {
                        Volume = minVolume;
                    }
                    else if (Volume > maxVolume)
                    {
                        Volume = maxVolume;
                    }
                    else
                    {
                        Volume = volume;
                    }
            }

            }

        public void VolumeUp()
        {
            volume = volume + 5;
            Console.WriteLine("Volume " + volume);
            
        }

        public void VolumeDown()
        {
            volume = volume - 5;
            Console.WriteLine("Volume " + volume);
        }

        public void Start()
        {
            for (int i = 0; i < Songs.Length; i++)
            {
                Console.WriteLine(Songs[i].Title);
                System.Threading.Thread.Sleep(2000);
            }
        }

    }
}
