using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7_Player1_2_SongsListShuffle
{
    class Song
    {
        public int Duration;
        public string Name;
        public Artist Artist;
        public Album Album;
        public string Lyrics;

        public Song()
        {
            
        }
        public Song(int duration, string name, Artist artist, Album album)
        {
            Duration = duration;
            Name = name;
            Artist = artist;
            Album = album;
            Lyrics = "Текст песни";
        }
    }
}
