/*
62. Заполните спирально массив 4 на 4.
*/
Console.Clear();



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
System.Console.WriteLine();
int[,] result = SpiralArray(userArraySize);
PrintArray(result);


/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

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

PrintArray(nums);

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
*/