﻿/*
49. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.

Например, изначально массив              Новый массив будет выглядеть 
выглядел вот так:                        вот так:
[0] [1] [2] [3] [4]                      [0] [1] [2] [3] [4] 
[1]  1   4   7   2                       [1]  1   4   7   2
[2]  5   9   2   3                       [2]  5   81  2   9
[3]  8   4   2   4                       [3]  8   4   2   4
*/
Console.Clear();

/*
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
void EvenIndex(int[,] newArr)
{
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) newArr[i, j] = newArr[i, j] * newArr[i, j];
        }
    }
}

int[,] array2D = new int[3, 4];
FillArray(array2D);
PrintArray(array2D);
System.Console.WriteLine();
EvenIndex(array2D);
PrintArray(array2D);
*/

/*
int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetRandom2DArray(int start, int end, int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}

int[,] ModifyEvenIndexSquare(int[,] array)
{
    int[,] result = array;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) result[i, j] = array[i, j] * array[i, j];
        }
    }
    return result;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int userArrayRow = TakeEnteredNumber("Введите количестов строк:");
int userArrayColumn = TakeEnteredNumber("Введите количестов столбцов:");
int userArrayStart = TakeEnteredNumber("Введите начало диапозона:");
int userArrayEnd = TakeEnteredNumber("Введите конец диапозона:");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);
Print2DArray(user2DArray);

System.Console.WriteLine();
int[,] userNewArray = ModifyEvenIndexSquare(user2DArray);
Print2DArray(userNewArray);
*/


// Вывод с наглядным отображением индексов
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print2DArray(int[,] array)
{
    System.Console.Write($"[ ]\t");
    int start = 0;
    for (int i = start; i < start + array.GetLength(1); i++)
    {
        System.Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"[" + i + "]\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
void EvenIndex(int[,] newArr)
{
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) newArr[i, j] = newArr[i, j] * newArr[i, j];
        }
    }
}

int[,] array2D = new int[3, 4];
FillArray(array2D);
Print2DArray(array2D);
System.Console.WriteLine();
EvenIndex(array2D);
Print2DArray(array2D);