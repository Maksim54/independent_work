using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repitition_Lagunovski
{
    class task1
    {
        static void Main(string[] argumendid)
        {
            /*task 2 from exercise 6*/
            /*Задано пять произвольных целых чисел (элементы массива).
            Определить, является ли их расположение в массиве упорядоченным (т.е. по возрастанию или по убыванию) или неупорядоченным.*/
            //
            static bool proizvoljnoe(int[] mass, bool ask)
            {
                for (int i = 0; i < mass.Length - 1; i++)
                    if ((ask && (mass[i] > mass[i + 1])) || (!ask && (mass[i] < mass[i + 1]))) return false;
                return true;
            }
            //
            static void checking(int[] massiv)
            {
                if (proizvoljnoe(massiv, true))
                {
                    Console.WriteLine("In ascending order");//в порядке возрастания
                }
                else if (proizvoljnoe(massiv, false))
                {
                    Console.WriteLine("In descending order");//В порядке убывания
                }
                else
                {
                    Console.WriteLine("Not ordered");//Неупорядочено
                }
            }
            var massiv = new[] { 5, 0, 3, 2, 1 };
            checking(massiv);
            Console.ReadLine();
            //
        }
    }
}
