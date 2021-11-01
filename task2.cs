using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repitition_Lagunovski
{
    class task2
    {
        /*task 2 from exercise 6*/
        /* Задан массив действительных чисел из N элементов (используйте генератор случайных чисел).
        Определить количество элементов, значения которых находятся вне диапазона от -10 до +10.*/
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //
            Console.Write("N = ");
            var N = int.Parse(Console.ReadLine()); //создается целочисленная переменная N
            var number = new int[N];
            var counting = 0;
            for (var i = 0; i < N; i++)//массив с числами от 1 до 20
            {
                number[i] = rnd.Next(1, 20);
                if (number[i] > -10 && number[i] < 10) counting++;
            }
            //
            Console.WriteLine($"Count {counting}");//выдаёт нам количество элементов, значения которых находятся вне диапазона от -10 до +10.
            Console.ReadLine();
            //
        }
    }
}
