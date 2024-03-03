using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_4
{/*
  * Дан массив и число. Найдите три числа в массиве сумма которых равна искомому числу.
  * Подсказка: если взять первое число в массиве, можно ли найти в оставшейся его части два числа равных по сумме первому.
  * */

    internal class HW
    {
        public static void FindSumOfThreeNums1(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < arr.Length - 1; k++)
                    {


                        if (arr[i] + arr[j] + arr[k] == target)
                        {
                            Console.WriteLine($"{arr[i]} + {arr[j]} + {arr[k]}= {target}");
                        }
                    }
                }
            }
        }

    }
   
 }




