using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7_Player1_2_SongsListShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = GetSongs();
            var player = new Player(songs);
            var song = CreateSongs();
            songs.Add(song);
            TraceInfo(player);

            songs = Shuffle(songs);
            player = new Player(songs);
            TraceInfo(player);
            player.Start(songs);
            SortByTitle(songs);
            var sortedSongs = SortByTitle(songs);
            TraceInfo(new Player(sortedSongs));
           
            Console.ReadLine();
        }

        public static void TraceInfo(Player player)
        {
            foreach (var i in player.Song)
            {
                Console.WriteLine($"Name Artist: {i.Artist.Name}");
                Console.WriteLine($"Name song: {i.Name}");
                Console.WriteLine($"Genre: {i.Artist.Genre}");
                Console.WriteLine($"Album: {i.Album.Name}");
                Console.WriteLine($"Year of album release: {i.Album.Year}");
                Console.WriteLine($"Duration song: {i.Duration} second\n");
                Console.WriteLine($"Lyrics: {i.Lyrics}");
            }
        }

        public static List<Song> GetSongs()
        {
            List<Artist> artists = new List<Artist>()
            {
                new Artist("Queen", "Rock"),
                new Artist("Marilyn Manson", "Rock"),
                new Artist("Maroon 5", "Rock"),
                new Artist("Nirvana", "Rock"),
                new Artist("Green Day", "Rock")
            };
            List<Album> album = new List<Album>()
            {
                new Album("Queen II", 1974),
                new Album("Sweet Dreams", 2000),
                new Album("Makes Me Wonder", 2008),
                new Album("Nevermind", 1991),
                new Album("Greatest", 2017)
            };

            List<Song> songs = new List<Song>()
            {
                new Song(120, "I want to break free", artists[0], album[0]),
                new Song(130, "Bowling for Columbine", artists[1], album[1]),
                new Song(200, "Makes Me Wonder", artists[2], album[2]),
                new Song(240, "Flash Gordon", artists[3], album[3]),
                new Song(300, "Windowpane", artists[4], album[4])
            };
            return songs;
        }

        public static Song CreateSongs()
        {
            var artist = new Artist("Queen", "Rock");
            var album = new Album();
            album.Name = "Bohemian Rhapsody";
            album.Year = 1975;
            var song = new Song()
            {
                Album = album,
                Duration = 100,
                Name = "I want to break free",
                Artist = artist
            };

            return song;
        }

        public static List<Song> Shuffle(List<Song> songs)
        {
            List<Song> newSong = new List<Song>();
            Random rand = new Random();
            int count = 0;
            while (songs.Count >= 1)
            {
                count = rand.Next(songs.Count);
                newSong.Add(songs[count]);
                songs.RemoveAt(count);
            }
            return newSong;
        }

        //B7-Player2/2. SongsListSort

        public static List<Song> SortByTitle(List<Song> songs)
        {
            List<string> songName = new List<string>();
            foreach (var i in songs)
            {
                songName.Add(i.Name);
            }
            songName.Sort();
            List<Song> newListSongs = new List<Song>();
            for (int i = 0; i < songName.Count; i++)
            {
                if (songName[i] == songs[i].Name)
                {
                    newListSongs.Add(songs[i]);
                }
            }
            var sortedName = newListSongs.OrderBy(u => u.Name).ToList();
            return sortedName;
        }
    }
}
