using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_5
{
    class B7_P2_5_ArrayListOfSongsSort
    {
        public static void ArrayListOfSongsSort()
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите строку: ");
                arrayList.Add(new Song(Console.ReadLine()));
            }
            arrayList.RemoveAt(arrayList.Count - 1);
            //var mas = arrayList.ToArray(typeof(object));
            //ArrayList является нетипизированной коллекцией, т.е. все элементы-типа object.
            //чтобы получит доступ к конкретному полю типа (Song),необходимо сделать явный cast.
            //Это уменьшает производительность и типобезопасность. Поэтому лучше использовать обобщенную типизированную
            //коллекцию List<Song>
            var mas = (Song[])arrayList.ToArray(typeof(Song));
            Console.WriteLine("Массив объектов");
            foreach (var i in mas)
            {
                Console.WriteLine(i.Lyrics);
            }
        }
    }
    class Song
    {
        public string Lyrics;

        public Song(string lyrics)
        {
            Lyrics = lyrics;
        }
    }
}
