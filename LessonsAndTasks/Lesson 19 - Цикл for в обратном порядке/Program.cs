﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 02:47:11
 * Version: 1.0.3
 */

using System;

/*
 * $1 Цикл for особенности
 * $2 нескольок переменных
 * $3 Цикл for в обратном порядке
 * $4 несколько условий
 */
class Program
{
    static void Main()
    {
        #region $1
        int limit = int.Parse(Console.ReadLine());

        for (int i = 1; i <= limit; i++)
        {
            Console.WriteLine(i);
        }

        for (; ; )
        {
            Console.WriteLine("for is working");
            System.Threading.Thread.Sleep(300);
            break;
        }

        int t = 0;
        for (; t < 3; t++)
        {
            Console.WriteLine("for_1: " + t);
        }

        for (; t < 5; t++)
        {
            Console.WriteLine("for_2: " + t);
        }

        for (int i = 0; i < 5;)
        {
            i++;
            Console.WriteLine(i);
        }
        #endregion
        #region $2
        for (int i = 0, j = 5; i < 10; i++)
        {
            Console.WriteLine("i: " + i);
            Console.WriteLine("j: " + j);
            j++;
        }
        #endregion
        #region $3
        for (int i = 10; i > 0; i--)
        {
            Console.WriteLine("-- " + i);
        }
        #endregion
        #region $4
        for (int i = 0, j = 5; i < 10 && j < 12; i++)
        {
            Console.WriteLine("i: " + i);
            Console.WriteLine("j: " + j);
            j++;
        }
        #endregion
        Console.ReadKey();
    }
}