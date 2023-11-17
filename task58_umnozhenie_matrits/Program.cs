/*
58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Матрица A:
   5   2
   8   1
Матрица B:
   5   6
   7   8
Произведение матриц:
  39  46
  47  56
*/
Console.Clear();


// Метод с ручным вводом значений матрицы
int[,] GetMatrixFromConsole(string name)
{
    Console.Write("Количество строк матрицы {0}:    ", name);
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Количество столбцов матрицы {0}: ", name);
    int m = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write("{0}[{1},{2}] = ", name, i, j);
            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j].ToString().PadLeft(4));
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(0) != matrixB.GetLength(1))
    {
        throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        //throw new Exception("It is impossible to multiply.");
    }

    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;

            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

Console.WriteLine("Программа для умножения матриц");

int[,] a = GetMatrixFromConsole("A");
int[,] b = GetMatrixFromConsole("B");

Console.WriteLine("Матрица A:");
PrintMatrix(a);

Console.WriteLine("Матрица B:");
PrintMatrix(b);

int[,] result = MatrixMultiplication(a, b);
Console.WriteLine("Произведение матриц:");
PrintMatrix(result);


/*
// Решение от GeekBrains
void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine("It is impossible to multiply.");
    }
    else
    {
        int[,] multiplicative = MatrixMultiplication(matrixA, matrixB);
        PrintMatrix(multiplicative);
    }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] multiplicative = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < multiplicative.GetLength(0); i++)
    {
        for (int j = 0; j < multiplicative.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                multiplicative[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return multiplicative;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix;

    if (args.Length == 0)
    {
        // Если аргументы не переданы, используем матрицу по умолчанию
        matrix = new int[,]
        {
                {5, 2},
                {8, 1}
        };
    }
    else
    {
        // Иначе, парсим аргументы в двумерный массив
        string[] rows = args[0].Split(';');
        matrix = new int[rows.Length, rows[0].Split(',').Length];
        for (int i = 0; i < rows.Length; i++)
        {
            string[] elements = rows[i].Split(',');
            for (int j = 0; j < elements.Length; j++)
            {
                if (int.TryParse(elements[j], out int number))
                {
                    matrix[i, j] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                    return;
                }
            }
        }
    }

    Console.WriteLine("Исходная матрица:");
    PrintMatrix(matrix);

    int[,] matrixB = { { 5, 6 }, { 7, 8 } };

    Console.WriteLine("\nMatrix B:");
    PrintMatrix(matrixB);

    Console.WriteLine("\nMultiplication result:");

    MultiplyIfPossible(matrix, matrixB);
*/

/*
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); //Для увеличения размера чисел в матрицах поменять число 5 на большее
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = InputInt("размерность матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArrayRandomNumbers(matrixA);
FillArrayRandomNumbers(matrixB);
int[,] matrixC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
PrintArray(matrixC);
*/

/*
int a = GetNumberFromUser("Введите число строк 1-й матрицы: ", "Ошибка ввода!");
int b = GetNumberFromUser("Введите число столбцов 1-й матрицы (и строк 2-й): ", "Ошибка ввода!");
int c = GetNumberFromUser("Введите число столбцов 2-й матрицы: ", "Ошибка ввода!");
int range = GetNumberFromUser("Введите диапазон случайных чисел: от 1 до ", "Ошибка ввода!");

int[,] Matrix1 = new int[a, b];
CreateArray(Matrix1);
Console.WriteLine($"\nПервая матрица:");
WriteArray(Matrix1);

int[,] Matrix2 = new int[b, c];
CreateArray(Matrix2);
Console.WriteLine($"\nВторая матрица:");
WriteArray(Matrix2);

int[,] resultMatrix = new int[a, c]; // число строк первой матрицы должно быть равно числу столбцов 2й матрицы

MatrixMultiplication(Matrix1, Matrix2, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return Math.Abs(userNumber);
        Console.WriteLine(errorMessage);
    }
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void MatrixMultiplication(int[,] Matrix1, int[,] Matrix2, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < Matrix1.GetLength(1); k++)
            {
                sum += Matrix1[i, k] * Matrix2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}
*/