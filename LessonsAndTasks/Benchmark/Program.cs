﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 02:47:11
 * Version: 1.0.3
 */

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;
using System.Collections;
using System.Collections.Generic;

[MemoryDiagnoser]
[RankColumn]
public class Benchmark_1
{
    [Benchmark]
    public void StructTest()
    {
        StructPoint structPoint = new StructPoint()
        {
            X = 1,
            Y = 2
        };
        var result = structPoint.X = structPoint.Y;
    }

    [Benchmark]
    public void ClassTest()
    {
        ClassPoint classPoint = new ClassPoint()
        {
            X = 1,
            Y = 2
        };
        var result = classPoint.X = classPoint.Y;
    }
}

[MemoryDiagnoser]
[RankColumn]
public class Benchmark_2
{
    [Benchmark]
    public void StructArrayTest()
    {
        var structPoints = new StructPoint[100];
        // частично находится в куче
        // в массиве через каждый интервал который отвечает
        // размеру минимального элемента находятся реальные данные структуры
        // разница в быстродействии в том, что мы выделяем память в управляемой куче лишь единожды для массива структур
        for (int i = 0; i < structPoints.Length; i++)
        {
            structPoints[i] = new StructPoint();
        }
    }

    [Benchmark]
    public void ClassArrayTest()
    {
        // в начале в куче создается сам массив
        // но для каждого объекта класса есть ссылка которую мы помещаем в массив и по каждой ссылке нужно запросить данные из кучи
        ClassPoint[] classPoints = new ClassPoint[100];
        // в массиве находятся не реальные данные а ссылки на данные
        for (int i = 0; i < classPoints.Length; i++)
        {
            classPoints[i] = new ClassPoint();
        }
    }
}

[MemoryDiagnoser]
[RankColumn]
public class Benchmark_3
{
    struct MyStruct
    {
        public decimal MyProperty1 { get; set; }
        public decimal MyProperty2 { get; set; }
        public decimal MyProperty3 { get; set; }
        public decimal MyProperty4 { get; set; }
        public decimal MyProperty5 { get; set; }
        public decimal MyProperty6 { get; set; }
        public decimal MyProperty7 { get; set; }
        public decimal MyProperty8 { get; set; }
        public decimal MyProperty9 { get; set; }
        public decimal MyProperty10 { get; set; }
    }

    class MyClass
    {
        public decimal MyProperty1 { get; set; }
        public decimal MyProperty2 { get; set; }
        public decimal MyProperty3 { get; set; }
        public decimal MyProperty4 { get; set; }
        public decimal MyProperty5 { get; set; }
        public decimal MyProperty6 { get; set; }
        public decimal MyProperty7 { get; set; }
        public decimal MyProperty8 { get; set; }
        public decimal MyProperty9 { get; set; }
        public decimal MyProperty10 { get; set; }
    }

    private MyStruct _myStruct = new MyStruct();
    private MyClass _myClass = new MyClass();

    private void Foo(MyClass myClass)
    {
        var t = myClass.MyProperty1 + myClass.MyProperty2;
    }

    private void Bar(MyStruct myStruct)
    {
        var t = myStruct.MyProperty1 + myStruct.MyProperty2;
    }

    private void BarIn(in MyStruct myStruct)
    {
        var t = myStruct.MyProperty1 + myStruct.MyProperty2;
    }

    [Benchmark]
    public void StructTest()
    {
        Bar(_myStruct);
    }

    [Benchmark]
    public void StructTestIn()
    {
        BarIn(_myStruct);
    }

    [Benchmark]
    public void ClassTest()
    {
        Foo(_myClass);
    }
}

[MemoryDiagnoser]
[RankColumn]
public class Benchmark_4
{
    [Benchmark]
    public void NoBoxing()
    {
        int res = 0;
        double a = 1;
        res += (int)a;
    }

    [Benchmark]
    public void Boxing()
    {
        int res = 0;
        object a = 1;
        res += (int)a;
    }
}

[MemoryDiagnoser]
[RankColumn]
public class Benchmark_5
{
    [Benchmark]
    public void Swaps()         // 4ns
    {
        object a = 5;
        object b = 1;
        SwapTestClass.Swap(ref a, ref b);
    }

    [Benchmark]
    public void GenericSwaps()  // 0ns
    {
        double p1 = 5;
        double p2 = 1;
        SwapTestClass.GenericSwap(ref p1, ref p2);
    }
}

[MemoryDiagnoser]
[RankColumn]
public class Benchmark_6
{
    [Benchmark]
    public void ArrayListBench()
    {
        var arrayList = new ArrayList();
        for (int el = 0; el < 1000; el++)
        {
            arrayList.Add(el);
        }
    }

    [Benchmark]
    public void ListBench()
    {
        var _list = new List<int>();
        for (int el = 0; el < 1000; el++)
        {
            _list.Add(el);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        //BenchmarkRunner.Run<MyParserBenchmark>();
        //BenchmarkRunner.Run<Benchmark_1>();
        //BenchmarkRunner.Run<Benchmark_2>();
        //BenchmarkRunner.Run<Benchmark_3>();
        //BenchmarkRunner.Run<Benchmark_4>();
        var config = new ManualConfig()
           .WithOptions(ConfigOptions.DisableOptimizationsValidator)
           .AddValidator(JitOptimizationsValidator.DontFailOnError)
           .AddLogger(ConsoleLogger.Default)
           .AddColumnProvider(DefaultColumnProviders.Instance);

        BenchmarkRunner.Run<Benchmark_5>(config);
    }
}