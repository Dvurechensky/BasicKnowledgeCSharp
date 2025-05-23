﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 02:47:11
 * Version: 1.0.3
 */

using System;

/*
 * Переменные в C#
 * 
 * Объявление (создание) переменных
 * 
 * Инициализация переменных
 * 
 * Присвоение значения переменной (помещение данных)
 */
class Program
{
    static void Main()
    {
        int a = 5, b = 9;           // Тип_данных имя_переменной;
        
        Console.WriteLine(a);
   
        a = 747;                    // Помещение значения

        Console.WriteLine(a);
        Console.WriteLine(b);

        Console.WriteLine("\t");

        bool variable1 = false;     // Объявление переменной
        bool Variable1 = false;
        bool variable2 = true;

        Console.WriteLine(variable1);
        Console.WriteLine(variable2);
        Console.WriteLine(Variable1);

        Console.WriteLine("\t");

        double t = 1.33;

        Console.WriteLine(t);

        char c = '#';
        string cc = "dfdfdsf";

        Console.WriteLine(c);
        Console.WriteLine(cc);

        Console.WriteLine("\t");
        Console.ReadKey();
    }
}