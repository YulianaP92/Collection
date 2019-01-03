using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_5
{
    class B7_P1_5_ArrayListPoemSort
    {
        public static void ArrayListPoemSort()
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите строку: ");
                var row = Console.ReadLine();
                arrayList.Add(row);
            }
            arrayList.Sort();
            arrayList.RemoveAt(arrayList.Count - 1);
            var mas = arrayList.ToArray(typeof(object));
            Console.WriteLine("Массив объектов");
            foreach (var i in mas)
            {
                Console.WriteLine(i);
            }
        }
    }
}
