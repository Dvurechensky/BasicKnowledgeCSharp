﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 02:47:11
 * Version: 1.0.3
 */

using System;

/*
 * Ссылочные (reference type) и значимые (value types) типы
 * 
 * Стек (stack) и куча (heap)
 */
class Program
{
    /// <summary>
    /// Данные удаляются из стека после выполненения
    /// </summary>
    /// <param name="a">val</param>
    static void Foo(int a)
    {
        a = 5;
    }

    static void Bar(int[] a)
    {
        a[0] = 3;
    }


    /// <summary>
    /// Stack - Enum, Struct 
    /// Heap - Class
    /// </summary>
    static void Main()
    {
        {
            int y = 2;
        }

        //Stack
        int a = 4;
        System.Int32 g = 5;

        //Heap
        Random rnd = new Random();

        //Heap gg(data) - реальные данные теущего массива Stack gg(ref) - ссылка
        Array array;
        int[] gg;

        //Stack
        ConsoleKey consoleKey;

        Foo(a);

        int[] ba = new int[1];
        ba[1] = 2;
        Bar(ba);
        Console.ReadKey();  
    }
}