﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 02:47:11
 * Version: 1.0.3
 */

using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

/*
 * Ключевое слово var
 * 
 * Неявно типизированные локальные переменные
 */
class Program
{
    static int Sum_Int(int a, int b)
    {
        int aa = a + b;
        return aa;
    }
    static int Sum_Var(int a, int b)
    {
        var aa = a + b;
        return aa;
    }

    static void Main()
    {
        var u = 5;

        // Когда полезен?
        // 1 - сократить длинну кода
        var dict = new Dictionary<int, string>();
        var list = new List<int>();
        // 2 - создать анонимный тип данных
        var obj = new { Name = "Мартин", Age = 25 };

        // 3 - использовать при выборке элементов в массиве
        int[] numbers = { 1, 2, 3, 2, 4, 5 };
        var result = from i in numbers where i > 1 select i;
        foreach (var item in result)
            Console.WriteLine($"{item}\t");


        Stopwatch sw = Stopwatch.StartNew();
        // 4 - когда нужно получить результат выполнения метода
        for (int i = 0; i < int.MaxValue; i++)
        {
            var sum_int = Sum_Int(1, i);
        }
        sw.Stop();
        Console.WriteLine($"Sum_Int {sw.ElapsedMilliseconds}");
        sw.Restart();
        for (int i = 0; i < int.MaxValue; i++)
        {
            var sum_var = Sum_Var(1, i);
        }
        sw.Stop();
        Console.WriteLine($"Sum_Var {sw.ElapsedMilliseconds}");


        /*
         * Не может быть использовано параметром метода
         * static void Bar (var a) 
         * Не может быть типом возвращаемого значения
         * static var Foo()
         * Не может быть полями класса
         * class MyClass { public var a}
         */
        Console.WriteLine();
        Console.WriteLine(u.GetType());
        Console.ReadKey();
    }
}