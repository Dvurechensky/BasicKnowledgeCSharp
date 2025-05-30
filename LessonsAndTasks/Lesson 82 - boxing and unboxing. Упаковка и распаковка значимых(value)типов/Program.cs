﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 02:47:11
 * Version: 1.0.3
 */

using System;

/*
 * boxing and unboxing (значимые в стеке, ссылочные в куче)(лучше избегать таких ситуаций)
 */
interface IPrintable
{
    void Print();
}

struct Point : IPrintable
{
    public int X { get; set; }
    public int Y { get; set; }
    public void Print() => Console.WriteLine($"X:{X}; Y:{Y};");
}

class Program
{
    static void Print(IPrintable printable) => printable.Print();

    public static void Main()
    {
        int a = 1;
        object b = a;                               // boxing
        int c = (int)b;                             // unboxing
        // decimal d = (decimal)b;                  // InvalidCastException
        var point = new Point { X = 3, Y = 3 };     // boxing (ссылку содержит на данные в куче)
        Print(point);
        int d = 0; d.GetType();                     // boxing
        Console.ReadKey();
    }
}