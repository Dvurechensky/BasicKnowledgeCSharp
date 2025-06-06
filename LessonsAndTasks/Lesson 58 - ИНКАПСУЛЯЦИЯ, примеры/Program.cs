﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 02:47:11
 * Version: 1.0.3
 */

using System;

/*
 * Инкапсуляция
 */
class Gun
{
    /// <summary>
    /// Cостояние
    /// </summary>
    private bool isLoaded;

    /// <summary>
    /// Поведение
    /// Инкапсуляция - скрываем состояние объекта - защищаем от внешнего мира
    /// и  даём возможность изменить состояние только с помощью этого же объекта
    /// 
    /// Cпособ правильно организовать поведение(работу объекта через методы)
    /// </summary>
    private void Reload()
    {
        Console.WriteLine("Заряжаю...");

        isLoaded = true;

        Console.WriteLine("Заряжено!");
    }

    public void Shot()
    {
        if (!isLoaded)
        {
            Console.WriteLine("Орудие не заряжено!");
            Reload();
        }

        Console.WriteLine("Пыщ - Пыщ!\n");
        isLoaded = false;
    }
}

class Program
{
    static void Main()
    {
        Gun gun = new Gun();
        gun.Shot();
        Console.ReadKey();
    }
}