using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_5
{
    class B7_P3_5_GenericListOfSongsSort
    {
        public static void GenericListOfSongsSort()
        {
            List<Song_> list = new List<Song_>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите строку: ");
                list.Add(new Song_(Console.ReadLine()));
            }
            list.RemoveAt(list.Count - 1);
            Console.WriteLine("Массив объектов");
            foreach (var i in list)
            {
                Console.WriteLine(i.Lyrics);
            }
        }
    }
    class Song_
    {
        public string Lyrics;

        public Song_(string lyrics)
        {
            Lyrics = lyrics;
        }
    }
}
