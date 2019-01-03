using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_5
{
    class B7_P5_5_DictionaryOfNeighborSearch
    {
        public static void DictionaryOfNeighborSearch()
        {
            Dictionary<int, Neighbor_> dictionary = new Dictionary<int, Neighbor_>()
            {
                [1] = new Neighbor_() { FullName = "Ivanov", PhoneNumber = "24-25-89" },
                [2] = new Neighbor_() { FullName = "Petrov", PhoneNumber = "24-39-27" },
                [3] = new Neighbor_() { FullName = "Sidorov", PhoneNumber = "24-79-46" },
                [4] = new Neighbor_() { FullName = "Poluhina", PhoneNumber = "24-67-34" }
            };
            dictionary.Remove(4);
            foreach (var i in dictionary)
            {
                Console.WriteLine($"{i.Key} {i.Value.FullName} {i.Value.PhoneNumber}");
            }
            Console.WriteLine("Введите номер квартиры: ");
            var numberFlat = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{dictionary[numberFlat].FullName} - {dictionary[numberFlat].PhoneNumber}");
        }
    }
    class Neighbor_
    {
        public string FullName;
        public string PhoneNumber;
    }
}
