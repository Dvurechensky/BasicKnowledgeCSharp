﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 02:47:11
 * Version: 1.0.3
 */

using System;

/*
 * Перегрузка методов (несколько реализаций одного и того же метода с разной сигнатурой)
 */
class Program
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    /// <summary>
    /// Сумма чисел разных типов 
    /// </summary>
    /// <param name="a">Число 1</param>
    /// <param name="b">Число 2(double)</param>
    /// <param name="c">Число 3</param>
    /// <returns>Сумма</returns>
    public static double Sum(int a, double b, int c)
    {
        return (double)a + b + c;
    }

    static void Main()
    {
        double sum = Sum(1, 2.3, 4);
        Console.WriteLine(sum);
        Console.ReadKey();
    }
}