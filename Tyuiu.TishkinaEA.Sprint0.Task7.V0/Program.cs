﻿using Tyuiu.TishkinaEA.Sprint0.Task7.V0.Lib;

namespace Tyuiu.TishkinaEA.Sprint0.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 0 | Выполнила Тишкина Елизавета Андреевна | РППБ-24-1";
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine(" * СПРИНТ 0                                                                                                       *");
            Console.WriteLine(" * Тема: Создание итогового решения по спринту                                                                    *");
            Console.WriteLine(" * Задание №7                                                                                                     *");
            Console.WriteLine(" * Вариант №0                                                                                                     *");
            Console.WriteLine(" * Выполнила Тишкина Елизавета Андреевна | РППБ-24-1                                                              *");
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine(" * УСЛОВИЕ:                                                                                                       *");
            Console.WriteLine(" * Написать консольную программу на C#, которая суммирует значения двух                                           *");
            Console.WriteLine(" * одинаковых по длине массивов                                                                                   *");
            Console.WriteLine(" *                                                                                                                *");
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine(" * ИСХОДНЫЕ ДАННЫЕ:                                                                                               *");
            Console.WriteLine("*******************************************************************************************************************");

            int[] arrayNums = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива №1");
            for (int i = 0; i < arrayNums.Length; i++)
            { 
                Console.Write(arrayNums[i]+ ", ");
            }
            Console.WriteLine();
            int[] arrayNums2 = new int[] {1, 2, 3, 4, 5};
            Console.WriteLine("Значение элементов массива №2");
            for (int i = 0;i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i]+ ", ");
            }
            Console.WriteLine();
            Console.WriteLine("*******************************************************************************************************************");
            Console.WriteLine(" * РЕЗУЛЬТАТ:                                                                                                     *");
            Console.WriteLine("*******************************************************************************************************************");
            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

                Console.WriteLine("Сумма элементов массива равна");
                for (int i = 0; ; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
            }
            Console.ReadKey();
        }
    }
}
