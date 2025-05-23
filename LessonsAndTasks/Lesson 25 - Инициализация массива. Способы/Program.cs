﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 02:47:11
 * Version: 1.0.3
 */

using System;
using System.Linq;

/*
 * Массивы
 * 
 * Одномерные массивы
 * 
 * Способы инициализации массива
 */
class Program
{
    static void Main()
    {
        int[] myArray_1 = new int[5] { 5, 6, 7, 8, 9 };
        int[] myArray_2 = new int[] { 5, 6, 7, 8 };
        int[] myArray_3 = new[] { 5, 6, 7, 8 };
        int[] myArray_4 = { 5, 6, 7, 8 };
        int[] myArray_5 = Enumerable.Repeat(5, 10).ToArray();
        int[] myArray_6 = Enumerable.Range(4, 5).ToArray();

        Console.ReadKey();
    }
}