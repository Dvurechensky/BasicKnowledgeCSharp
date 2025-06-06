﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 02:47:11
 * Version: 1.0.3
 */

using System;
using System.Diagnostics;

/*
 * Ключевое слово in
 */
class Program
{
    private static float k = 0;

    struct Point
    {
        public float x;
        public float y;
        public float z;
        public decimal e;
        public decimal e1;
        public decimal e2;
        public decimal e3;
        public decimal e4;
        public decimal e5;
        public decimal e6;
        public decimal e7;
        public decimal e8;
        public decimal e9;
        public decimal e0;
        public decimal e11;
        public decimal e12;
        public decimal e13;
        public decimal e14;
        public decimal e15;
    }

    static void Fos(Point value)
    {

    }

    static void Bar(in Point value)
    {
        k = value.x;
    }

    /// <summary>
    /// in позволяет только извлечь данные из переменной
    /// полезно для структур, для экономии памяти 
    /// </summary>
    /// <param name="value"></param>
    public static void Foo(in int value)
    {
        Console.WriteLine(value);
    }

    static void Main()
    {
        Point a = new Point();
        a.x = 5;

        Stopwatch sw = Stopwatch.StartNew();

        for (int i = 0; i < int.MaxValue; i++)
        {
            Fos(a);
        }

        sw.Stop();

        Console.WriteLine($"Fos {sw.ElapsedMilliseconds}");

        sw.Restart();

        for (int i = 0; i < int.MaxValue; i++)
        {
            Bar(a);
        }

        sw.Stop();

        Console.WriteLine($"Bar {sw.ElapsedMilliseconds}");
        Console.WriteLine(k);
        Console.ReadKey();
    }
}