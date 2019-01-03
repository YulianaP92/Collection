using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_5
{
    public class SongList
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public SongList(string name, string artist, string album)
        {
            Name = name;
            Artist = artist;
            Album = album;
        }
    }

    public class PlayList : ICollection<SongList>
    {
        private List<SongList> innerCol;

        public PlayList()
        {
            innerCol = new List<SongList>();
        }
        public IEnumerator<SongList> GetEnumerator()
        {
            return innerCol.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new SongEnumerator(this);
        }

        public SongList this[int index]
        {
            get { return (SongList)innerCol[index]; }
            set { innerCol[index] = value; }
        }
        public bool Contains(SongList item)
        {
            bool found = false;

            foreach (SongList bx in innerCol)
            {
                if (Equals(bx, item))
                {
                    found = true;
                    Console.WriteLine("Такая песня уже существует");
                }
            }

            return found;
        }
        public bool Equals(SongList x, SongList y)
        {
            if (x.Name == y.Name && x.Album == y.Album
                && x.Artist == y.Artist)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Contains(SongList item, EqualityComparer<SongList> comp)
        {
            bool found = false;

            foreach (SongList bx in innerCol)
            {
                if (comp.Equals(bx, item))
                {
                    found = true;
                }
            }

            return found;
        }
        public void Add(SongList item)
        {

            if (!Contains(item))
            {
                innerCol.Add(item);
            }
        }

        public void Clear()
        {
            innerCol.Clear();
        }

        public void CopyTo(SongList[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("The array cannot be null.");
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            if (Count > array.Length - arrayIndex + 1)
                throw new ArgumentException("The destination array has fewer elements than the collection.");

            for (int i = 0; i < innerCol.Count; i++)
            {
                array[i + arrayIndex] = innerCol[i];
            }
        }

        public int Count
        {
            get
            {
                return innerCol.Count;
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(SongList item)
        {
            bool result = false;

            innerCol.Remove(item);
            result = true;

            return result;
        }
    }

    public class SongEnumerator : IEnumerator<SongList>
    {
        private PlayList _collection;
        private int curIndex;
        private SongList curBox;


        public SongEnumerator(PlayList collection)
        {
            _collection = collection;
            curIndex = -1;
            curBox = default(SongList);
        }

        public bool MoveNext()
        {
            if (++curIndex >= _collection.Count)
            {
                return false;
            }
            return true;
        }

        public void Reset() { curIndex = -1; }

        void IDisposable.Dispose() { }

        public SongList Current
        {
            get { return curBox; }
        }


        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}
