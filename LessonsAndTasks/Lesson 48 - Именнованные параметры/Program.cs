﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 02:47:11
 * Version: 1.0.3
 */

using System;

/*
 * Именнованные параметры
 */

class Program
{
    /// <summary>
    /// Параметры по умолчанию всегда должны быть в конце списка
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="enableLogging"></param>
    /// <returns></returns>
    private static int Sum(int a, int b, bool enableLogging = false)
    {
        int result = a + b;

        if (enableLogging)
        {
            Console.WriteLine($"Значение переменной a = {a}");
            Console.WriteLine($"Значение переменной b = {b}");
            Console.WriteLine($"Значение переменной result = {result}");
        }

        return result;
    }

    static void Main()
    {
        Sum(a: 1, b: 2);

        int firstValue = 2;
        int secondValue = 3;

        //Чтобы внести ясность тому что выполнит функция 
        Sum(a: firstValue, b: secondValue, enableLogging: true);
        Console.ReadKey();
    }
}