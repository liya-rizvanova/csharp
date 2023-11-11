﻿/*
38. 1. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

2. Реализуйте класс ArrayOperations, который содержит следующие статические методы:
FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает максимальное число из массива.
FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает минимальное число из массива.
CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает разницу 
между максимальным и минимальным числами в массиве.
PrintArray(double[] array): Метод для вывода массива на экран. Он принимает на вход массив array и выводит его элементы с 
двумя знаками после запятой через табуляцию.

Аргументы, передаваемые в метод/функцию:
'3.17, 8.94, 2.36, 5.72, 0.85'

На выходе:
3.17    8.94    2.36    5.72    0.85           Разность между максимальным и минимальным элементом = 8.09
*/
Console.Clear();

/*
// 1.
Console.WriteLine("Выполняется создание массива и расчет разницы между максимальным и минимальным элементом массива... ");
double[] arr = GetRandomArray(5);                           // вызов метода создания одномерного массива случайных вещественных чисел
double min = GetMinArray(arr);                              // вызов метода определения минимального элемента массива
double max = GetMaxArray(arr);                              // вызов метода определения максимального элемента массива
double res = GetResult(min, max);                           // вызов метода определения разницы между max и min элементами массива.
Console.WriteLine($"[{String.Join(", ", arr)}] -> {res}");  // вывод массива и результата пользователю
// -------------------------- Конец программы ----------------------------------
// -------------------------Определение методов ---------------------------------
// ------------------------------------------------------------------------------
// метода создания одномерного массива случайных вещественных чисел
double[] GetRandomArray(int size)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(1, 50);
    }
    return result;
}
// метод определения минимального элемента массива
double GetMinArray(double[] array)
{
    double min = array[0];
    foreach (double a in array)
    {
        if (min > a) min = a;
    }
    return min;
}
// метода определения максимального элемента массива
double GetMaxArray(double[] array)
{
    double max = array[0];
    foreach (double b in array)
    {
        if (max < b) max = b;
    }
    return max;
}
// метод определения разницы между max и min элементами массива.
double GetResult(double min, double max)
{
    double result = max - min;
    return result;
}
*/

/*
// 2.
double[] GetDoubleRnd(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99, 99) + new Random().NextDouble();
    }
    return array;
}

void PrintDoubleArray(double[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(1);
        System.Console.Write(Math.Round(arr[i], 2));
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("]");
    Console.ResetColor();
}

double[] arrayDouble = GetDoubleRnd(5);
PrintDoubleArray(arrayDouble);
*/


int Prompt(string massage)
{
    System.Console.Write(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[] GenerateArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (maxValue + 0.01 - minValue) + minValue, 2);
    }
    return array;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
            max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
            min = array[i];
    }
    return min;
}

double CalcDifferenceBetweenMaxMin(double[] array)
{
    double result = FindMax(array) - FindMin(array);
    return result;
}

void PrintArray(double[] arrayOne)
{
    System.Console.WriteLine("Массив:");
    System.Console.Write("[");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(arrayOne[i]);
        if (i < arrayOne.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
    System.Console.WriteLine();
    System.Console.WriteLine($"Минимальный элемент: {FindMin(arrayOne)}");
    System.Console.WriteLine($"Максимальный элемент: {FindMax(arrayOne)}");
    System.Console.WriteLine($"Разность между максимальным и минимальным элементами = {CalcDifferenceBetweenMaxMin(arrayOne)}");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Минимальное значение: ");
int max = Prompt("Максимальное значене: ");
double[] array = GenerateArray(length, min, max);
PrintArray(array);
