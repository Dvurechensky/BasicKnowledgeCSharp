﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 02:47:11
 * Version: 1.0.3
 */

using System;


/*
 * 3. Напишите простой конвертер валют
 *    (без возможности динамического выбора валюты пользователем).
 *    Валюты заданы хардкодом и не изменяются. Тип валют на выбор программиста.
 */

namespace Task_Home_3___Конвертер_валют
{
    class Program
    {
        static void Main(string[] args)
        {
            //#3
            double ruble, dollar;

            Console.WriteLine("Введите количество рублей: ");

            double.TryParse(Console.ReadLine(), out ruble);

            dollar = ruble * 0.014;

            Console.WriteLine("Долларов: " + dollar);
        }
    }
}
