﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 02:47:11
 * Version: 1.0.3
 */

using System;

/*
 * Ключесвое слово static
 * 
 * Статические методы класса
 * 
 * Статические свойства класса
 */
class Numb
{
    public Numb() => Counter++;

    private static int counter;

    public static int Counter
    {
        get { return counter; }
        private set { counter = value; }
    }

    public int ObjectsCount => counter;

    public static int GetCounter() => counter;

    public int GetObjectsCount() => counter;
}

class MyClass_1
{
    private static int a;

    private int b;

    public static void Foo()
    {
        Console.WriteLine("Вызван метод Foo()");
        a = 5;
        Console.WriteLine(a);
    }

    public void Bar()
    {
        Console.WriteLine("Вызван метод Bar()");
        Console.WriteLine(a);
        Foo();
    }

    private static int c;

    public static int C
    {
        get { return c; }
        set { c = value; }
    }

    public static int D { get; set; }

}

class Program
{
    static void Main()
    {
        //Полиморфизм требует создание объекта класса и вызова метода на уровне экземпляра 
        MyClass_1 myClass = new MyClass_1();
        myClass.Bar();
        MyClass_1.Foo();// - статические методы недоступны на уровне экземпляра класса
        MyClass_1.C = 3;
        MyClass_1.D = 2;

        Numb numb = new Numb();
        Numb numb1 = new Numb();
        Numb numb2 = new Numb();
        Console.WriteLine(numb2.GetObjectsCount());
        Console.WriteLine(numb2.ObjectsCount);
        Console.WriteLine(Numb.Counter);
        Console.WriteLine(Numb.GetCounter());
        Console.ReadKey();
    }
}