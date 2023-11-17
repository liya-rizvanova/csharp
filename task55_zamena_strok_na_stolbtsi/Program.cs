/*
55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/
Console.Clear();

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

int[,] ChangeArray(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Ошибка: невозможно заменить строки на столбцы. Введите одинаковое количество строк и столбцов");
        return array.Empty();
    }    
    else
    {
        int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                newArray[i, j] = array[j, i];
            }
        }
        return newArray;
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

int userArrayRow = TakeEnteredNumber("Введите количестов строк:");
int userArrayColumn = TakeEnteredNumber("Введите количестов столбцов:");
int userArrayStart = TakeEnteredNumber("Введите начало диапозона:");
int userArrayEnd = TakeEnteredNumber("Введите конец диапозона:");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);
Print2DArray(user2DArray);

System.Console.WriteLine();
int[,] userNewArray = ChangeArray(user2DArray);
Print2DArray(userNewArray);
*/

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

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void SwapRowsAndColumns(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    if (rows != columns)
    {
        System.Console.WriteLine("Невозможно заменить строки на столбцы");
        return;
    }
    int[,] newArray = new int[columns, rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < i; j++)
        {
            int tmp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = tmp;
        }
    }
}

int[,] array2D = new int[2, 3];   // указываем количество строк и столбцов
FillArray(array2D);
Print2DArray(array2D);
SwapRowsAndColumns(array2D);
System.Console.WriteLine();
Print2DArray(array2D);
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

int[,] CopyArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i, j] = array[i, j];
        }
    }
    return result;
}

int[,] ChangeRows(int[,] array)
{
    int temperary = 0;
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    result = CopyArray(array);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temperary = result[0, j];
        result[0, j] = result[array.GetLength(0) - 1, j];
        result[array.GetLength(0) - 1, j] = temperary;
    }
    return result;
}

int[,] ReplaceRowsColumns(int[,] array)
{
    int[,] result = CopyArray(array);
    int temporary = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            if (i != j)
            {
                temporary = result[i, j];
                result[i, j] = result[j, i];
                result[j, i] = temporary;
            }
        }
    }
    return result;
}

int userArrayRow = TakeEnteredNumber("Введите количество строк и столбцов:");
int userArrayColumn = userArrayRow;
int userArrayStart = TakeEnteredNumber("Введите начало диапазона:");
int userArrayEnd = TakeEnteredNumber("Введите конец диапазона:");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);
Print2DArray(user2DArray);

int[,] userArray2 = ReplaceRowsColumns(user2DArray);
System.Console.WriteLine();
Print2DArray(userArray2);
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

int userArrayRow = TakeEnteredNumber("Введите количестов строк:");
int userArrayColumn = TakeEnteredNumber("Введите количестов столбцов:");
int userArrayStart = TakeEnteredNumber("Введите начало диапозона:");
int userArrayEnd = TakeEnteredNumber("Введите конец диапозона:");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);
Print2DArray(user2DArray);

int[,] ChangeArray(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Ошибка: невозможно заменить строки на столбцы. Введите одинаковое количество строк и столбцов");
        return array;
    }
    else
    {
        int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                newArray[i, j] = array[j, i];
            }
        }
        return newArray;
    }
}

System.Console.WriteLine();
int[,] userNewArray = ChangeArray(user2DArray);
Print2DArray(userNewArray);
*/


// Метод, позволяющий заменить строки на столбцы, независимо от количества строк и столбцов.
int Prompt(string massage)
{
    System.Console.Write(massage);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int result = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    return result;
}

int[,] GenerateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    System.Console.WriteLine("\nДвумерный массив:");
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.Write(matrixOne[i, j]);
            if (j < matrixOne.GetLength(1) - 1)
                System.Console.Write("\t");
            else System.Console.WriteLine();
            Console.ResetColor();
        }
    }
    System.Console.WriteLine("\nНовый массив:");
    for (int i = 0; i < matrixTwo.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.Write(matrixTwo[i, j]);
            if (j < matrixTwo.GetLength(1) - 1)
                System.Console.Write("\t");
            else System.Console.WriteLine();
            Console.ResetColor();
        }
    }
}

int[,] ConvertMatrix(int[,] matrixOne)
{
    int[,] matrixTwo = new int[matrixOne.GetLength(1), matrixOne.GetLength(0)];
    for (int i = 0; i < matrixTwo.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            matrixTwo[i, j] = matrixOne[j, i];
        }
    }
    return matrixTwo;
}

int rows = Prompt("Количество строк: ");
int columns = Prompt("Количество столбцов: ");
int min = Prompt("Минимальное значение: ");
int max = Prompt("Максимальное значене: ");
int[,] matrix = GenerateMatrix(rows, columns, min, max);
PrintMatrix(matrix, ConvertMatrix(matrix));
