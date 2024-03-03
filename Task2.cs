using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_4
{/*
  * Дан список целых чисел (числа не последовательны),
  * в котором некоторые числа повторяются.  Выведите список чисел на экран,
  * расположив их в порядке возрастания частоты повторения
  * */
   // List<int> ints = new List<int> { 1, 2, 2, 2, 3, 4, 4, 5, 5, 5, 5, 6, 7, 0 };

    internal class Task2
    {
        static void IncreaseFriquencyNum(Dictionary<int, int> num)
        {
            List<int> ints = new List<int> { 1, 2, 2, 2, 3, 4, 4, 5, 5, 5, 5, 6, 7, 0 };
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int i in ints)
            {
                if (dic.ContainsKey(i))
                {
                    dic[i]++;
                }
                else
                {
                    dic.Add(i, 1);
                }
                PriorityQueue<int, int> priority = new PriorityQueue<int, int>();
                foreach (var item in dic)
                {
                    priority.Enqueue(item.Key, -item.Value); // "-" для соритроваки по убыванию
                }
                while (priority.Count>0)
                {
                    Console.WriteLine(priority.Dequeue());
                }
            }
        }

    }
}
