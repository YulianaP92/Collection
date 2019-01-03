using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //B7_P1_5_ArrayListPoemSort.ArrayListPoemSort();
            //B7_P2_5_ArrayListOfSongsSort.ArrayListOfSongsSort();
            //B7_P3_5_GenericListOfSongsSort.GenericListOfSongsSort();
            //B7_P4_5_GenericListOfNeighborSearch.GenericListOfNeighborSearch();
            //B7_P5_5_DictionaryOfNeighborSearch.DictionaryOfNeighborSearch();

            //Task №7
            PlayList list = new PlayList();
            list.Add(new SongList("I want to break free", "Queen", "QueenII"));
            list.Add(new SongList("Цвет настроения синий", "Киркоров", "Я"));
            var song = new SongList("I want to break free", "Queen", "QueenII");
            Console.WriteLine(list.Contains(song).ToString());
            foreach (SongList i in list)
            {
                Console.WriteLine($"{i.Name} - {i.Album} - {i.Artist}");
            }
            list.Remove(list[0]);
            list.Clear();

            Console.ReadLine();
        }
    }
}
