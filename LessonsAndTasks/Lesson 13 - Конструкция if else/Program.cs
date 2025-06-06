﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 02:47:11
 * Version: 1.0.3
 */

using System;

/*
 * Конструкция if else
    if(утверждение или выражение)
    {
        действие 1;
    }
    else
    {
        действие 2;
    }
*/
class Program
{
    static void Main()
    {
        bool isInfected = true;

        if (isInfected)     // утверждение
        {
            Console.WriteLine("Персонаж инфицирован!");
        }
        else
        {
            Console.WriteLine("Персонаж не инфицирован!");
        }

        int a;

        int.TryParse(Console.ReadLine(), out a);

        if (a == 5)         // выражение
        {
            Console.WriteLine("a равно 5");
        }
        else
        {
            Console.WriteLine("a не равно 5");
        }

        //#Свой аналог
        Console.WriteLine(isInfected ? "Персонаж инфицирован!" : "Персонаж не инфицирован!");
        Console.ReadKey();
    }
}