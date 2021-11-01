using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repitition_Lagunovski
{
    class task3
    {
        static void Main(string[] argumendid)
        {
            //
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
            string[] Mfull_name =
            {
                "Isaev Yaroslav Egorovich", "Morozova Zlata Timurovna", "Bogdanova Daria Ivanovna", "Vasilyeva Lyubov Valerievna"
            };
            //
            //номер улицы
            string[] Madress =
            {
                "1130 Small Street", "3620 Hanover Street", "4313 Jarvisville Road", "2770 Fieldcrest Road"
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
            int counting = 0;
            //
            //Добавляем примечание тому человеку,который родился позже 2003 года
            for (int i = 0; i < Mfull_name.Length; i++)
            {
                //
                if (Myear[counting] < 2003)
                {
                    Array.Sort(Madress, Mfull_name);
                    Console.WriteLine(Madress[counting] + "/" + Mfull_name[counting]);
                }
                else
                {
                    Console.WriteLine(Mfull_name[counting] + "People who are at least 18 years of age have the right to vote.");
                }
                counting++;
                //
            }
            Console.ReadLine();
        }
    }
}
