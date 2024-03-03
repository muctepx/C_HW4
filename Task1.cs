using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_4
{/*Дан список целых чисел (числа не последовательны), в котором некоторые числа повторяются. 
  * Выведите список чисел на экран, исключив из него повторы.
  * List<int> ints = new List<int> { 0, 1, 1, -1, 101, 102, 101, 11, 1111, 11 };
  * */
    internal class Task1
    {
        List<int> ints = new List<int> { 0, 1, 1, -1, 101, 102, 101, 11, 1111, 11 };



        static void UniqNum(List<int> ints)
        {

            //var list = ints.Where(x => !ints.Contains(x));
            List<int> list = new List<int>();
            foreach (int i in ints)
            {
                //if (!list.Contains(i))                list.Add(i);
                // if (!list.Contains(Math.Abs(i)) && !list.Contains(i)) list.Add(i);
                if (!list.Any(x => x == i || x == -i)) list.Add(i);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //решение 2
            /*
            HashSet<int> set = new HashSet<int>(ints);
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            */
        }

    }
}
