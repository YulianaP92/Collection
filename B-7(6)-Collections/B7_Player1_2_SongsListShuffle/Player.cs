using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7_Player1_2_SongsListShuffle
{
    class Player
    {
        private const int minVolume = 0;
        private const int maxVolume = 300;
        private int _volume;
        public bool Locked;
        public bool Playing;
        public List<Song> Song;
        public Player(List<Song> Song)
        {
            this.Song = Song;
        }
        public int Volume
        {
            get { return _volume; }
            set
            {
                if (value < minVolume)
                {
                    _volume = minVolume;
                }
                if (value > maxVolume)
                {
                    _volume = maxVolume;
                }
                else
                {
                    _volume = value;
                }
            }
        }


        public void VolumeUp()
        {
            if (Locked)
                Console.WriteLine("Player is locked");
            else
            {
                Volume++;
                Console.WriteLine("Increase volume by one");
            }
        }
        public void VolumeDown()
        {
            if (Locked)
                Console.WriteLine("Player is locked");
            else
            {
                Volume--;
                Console.WriteLine("Decrease volume by one");
            }
        }
        public void VolumeChange(int step)
        {
            if (Locked)
                Console.WriteLine("Player is locked");
            else
            {
                Volume += step;
                Console.WriteLine($"To change the volume on: {step}");
            }

        }

        public void Lock()
        {
            Locked = true;
            Console.WriteLine("Player is locked");
        }
        public void Unlock()
        {
            Locked = false;
            Console.WriteLine("Player is unlocked");
        }


        public bool Stop()
        {
            if (!Locked)
            {
                Playing = false;
                Console.WriteLine("Player is stopped");
            }
            else
                Console.WriteLine("Player is locked");
            return Playing;
        }
        public bool Start(List<Song> songs, bool loop = false)
        {

            if (!Locked)
            {
                Playing = true;
                Console.WriteLine("Player is playing");
                if (loop)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"{songs[i].Name} - {songs[i].Lyrics}");
                    }
                }
                else
                {
                    Console.WriteLine($"{songs[0].Name} - {songs[0].Lyrics}");
                }
            }
            else
                Console.WriteLine("Player is locked");
            return Playing;
        }
    }
}
