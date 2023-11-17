/*int a = 2;
double result = Math.Pow(a, 3);
System.Console.WriteLine(result);
*/
/*
int b = 8;
double result = Math.Sqrt(b);
System.Console.WriteLine(result);
*/
// Console.ForegroundColor = ConsoleColor.Blue; // окрашивает в синий цвет


/*
void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;    
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(1);
        System.Console.Write(arr[i] + "\t");
    }
    Console.ForegroundColor = ConsoleColor.Green;    
    Console.ResetColor();
}

int[] GetSumRowArray(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int result = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result = result + array[i, j];
        }
        sumArray[i] = result;
    }
    return sumArray;
}
System.Console.WriteLine();
int[] resultArray = GetSumRowArray(user2DArray);
PrintArray(resultArray);
*/

/*
void CreateArray(int[,] myArray)
        {
            Random rnd = new Random();
             
            //   ---Заполнение массива рандомными числами (-10,10)--- 
            //   ---вывод его на консоль---
            
            for(int i = 0; i < 10; i++) //Проходим по циклу строк
            {
                Console.Write("\n{0}:", i);
                for(int j = 0; j < 20; j++) //Проходим по циклу столбцов
                {
                    myArray[i, j] = rnd.Next(10, 99); //Заполняем текущий элемент
                    Console.Write("{0}  ", myArray[i, j]);
                }
            }
        }
 
        void Main(string[] args)
        {
            int[,] myArray = new int[10,20];
            int Sum = 0, Sum1 = 0, Sum2 = 0, Row = 0;
            CreateArray(myArray);
 
            for(int i = 0; i < 10; i++) //Проходим по циклу строк
            {
                Sum2 = 0;
                for(int j = 0; j < 20; j++) //Проходим по циклу столбцов
                {   Sum2 += myArray[i, j];  } //Сумма всех членов 1ой строки.
                if(Sum2 < Sum1)
                {   Sum = Sum2; Row = i;    }
                Sum1 = Sum2;
            }
            Console.WriteLine("\n\t Наименьшаяя сумма = {0}",Sum);
            Console.WriteLine("\n\t Номер строки = {0}", Row);
 
            Console.ReadKey();
        }





        int matrixC = new int[matrix.GetLength(0), matrixB.GetLength(1)];
 
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;
 
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrixC[i, j] += matrix[i, k] * matrixB[k, j];
                }
            }
        }
 
        return matrixC;

    */

/*
// метод расширения для получения количества строк матрицы
int RowsCount(this int[,] matrix)
{
    return matrix.GetUpperBound(0) + 1;
}
*/
// метод расширения для получения количества столбцов матрицы
//int ColumnsCount(int[,] matrix)
//{
//    return matrix.GetLength(1) + 1;
//}

/*
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
        //throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        throw new Exception("It is impossible to multiply.");
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

Console.ReadLine();
*/


int TakeEnteredNumber(string message)
{
   Console.WriteLine(message);
int size = Convert.ToInt32(Console.ReadLine());
return size;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine("]");
        Console.WriteLine("");
    }
}

int[,] SpiralArray(int size)
{
    int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}
    return nums;
}

int userArraySize = TakeEnteredNumber("Введите размер массива");
int[,] result = SpiralArray(userArraySize);
PrintArray(result);