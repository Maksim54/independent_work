using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repitition_Lagunovski
{
    class Program
    {
        /*task 2 from exercise 6*/
        /* Задан массив действительных чисел из N элементов (используйте генератор случайных чисел).
        Определить количество элементов, значения которых находятся вне диапазона от -10 до +10.*/
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //
            Console.WriteLine("--Task 2--");
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
            /*-----------------------------------------------------------------------------------------------------------------------------*/
            //
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
            Console.WriteLine("--Task 1--");
            var massiv = new[] { 5, 0, 3, 2, 1 };
            checking(massiv);
            Console.ReadLine();
            //
            /*-----------------------------------------------------------------------------------------------------------------------------*/
            /*task 3 from exercise 6*/
            //
            /*Дано: информация о каждом жителе города содержит следующие элементы:
            а) фамилия, имя, отчество;
            б) домашний адрес (улица, дом);
            в) дата рождения.
            Информация о жителе является элементом одного большого массива М[ ].
            Требуется составить списки избирателей, живущих по заданному адресу в алфавитном порядке.
            Примечание: Правом участия в выборах обладают люди не моложе 18 лет.*/
            //
            //фамилия,имя,отчество
            Console.WriteLine("--Task 3--");
            string[] Mfull_name =
            {
                "Isaev Yaroslav Egorovich -", "Morozova Zlata Timurovna -", "Bogdanova Daria Ivanovna -", "Vasilyeva Lyubov Valerievna -"
            };
            //
            //номер улицы
            string[] Madress =
            {
                 "- 3620 Hanover Street","- 4313 Jarvisville Road","- 1130 Small Street","- 2770 Fieldcrest Road"
            };
            //
            //день,месяц и год рождения каждого из людей введенных в списке
            int[] Myear =
            {
                1990, 1984, 1999, 2005
            };
            int[] Mmonth =
            {
                12, 04, 9, 03
            };
            int[] Mday =
            {
                03, 12, 07, 25
            };
            //
            int a = Myear[0];
            int b = Myear[1];
            int c = Myear[2];
            int counting1 = 0;
            //
            //Добавляем примечание тому человеку,который родился позже 2003 года
            for (int i = 0; i < Mfull_name.Length; i++)
            {
                //
                if (Myear[counting1] < 2003)
                {
                    Array.Sort(Madress, Mfull_name);
                    Console.WriteLine(Madress[counting1] + " - / - " + Mfull_name[counting1]);
                }
                else
                {
                    Console.WriteLine(Mfull_name[counting1] + "People who are at least 18 years of age have the right to vote.");
                }
                counting1++;
                //
            }
            Console.ReadLine();
        }
    }
}
