using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_5
{
    class B7_P4_5_GenericListOfNeighborSearch
    {
        public static void GenericListOfNeighborSearch()
        {
            List<Neighbor> floorNeighbors = new List<Neighbor>();
            floorNeighbors.Add(new Neighbor() { FlatNumber = 2, FullName = "Petrov", PhoneNumber = "24-39-27" });
            floorNeighbors.Add(new Neighbor() { FlatNumber = 1, FullName = "Ivanov", PhoneNumber = "24-25-89" });
            floorNeighbors.Add(new Neighbor() { FlatNumber = 4, FullName = "Poluhina", PhoneNumber = "24-67-34" });
            floorNeighbors.Add(new Neighbor() { FlatNumber = 3, FullName = "Sidorov", PhoneNumber = "24-79-46" });
            floorNeighbors.Sort();
            floorNeighbors = floorNeighbors.Where(x => x.FlatNumber != 4).ToList();
            foreach (var i in floorNeighbors)
            {
                Console.WriteLine($"{i.FullName} - {i.FlatNumber} - {i.PhoneNumber}");
            }
            Console.WriteLine("Введите номер квартиры соседа: ");
            var numberFlat = Int32.Parse(Console.ReadLine());
            var select = floorNeighbors.Where(x => x.FlatNumber == numberFlat);
            foreach (var i in select)
            {
                Console.WriteLine($"{i.FullName} - {i.PhoneNumber}");
            }
        }
    }

    class Neighbor : IComparable<Neighbor>
    {
        public string FullName;
        public int FlatNumber;
        public string PhoneNumber;

        public int CompareTo(Neighbor other)
        {
            return this.FlatNumber.CompareTo(other.FlatNumber);
        }
    }
}
