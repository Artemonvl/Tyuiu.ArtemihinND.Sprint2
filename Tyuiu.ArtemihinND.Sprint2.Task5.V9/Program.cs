﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ArtemihinND.Sprint2.Task5.V9.Lib;

namespace Tyuiu.ArtemihinND.Sprint2.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Артемихин. Н. Д. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Оператор switch                                                         *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Артемихин Никита Дмитриевич | ПКТб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу которая использует оператор switch                   *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер месяца (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            string season;

            if ((month < 1) || (month > 12))
            {
                season = "Введено неправильное значение";
            }
            else
            {
                season = "Это месяц " + ds.FindMonthSeason(month);
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(season);

            Console.ReadKey();
        }
    }
}