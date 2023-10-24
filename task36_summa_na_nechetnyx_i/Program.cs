/*
36. Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.Clear();


int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(1);
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("]");
    Console.ResetColor();
}

void SumNegIdx(int[] arr)
{
    int summ = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        summ = arr[i] + summ;
    }
    System.Console.WriteLine(summ);
}

int[] array = GetRnd(5);
PrintArray(array);
System.Console.WriteLine();
SumNegIdx(array);

/*
int Prompt(string message)
{
    System.Console.Write(message);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

int[] GenerateArray(int Length)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(100, 999);
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]},\t");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.Write("]");
}

int length = Prompt("Длина массива: ");
int[] array = GenerateArray(length);
PrintArray(array);

int GetSum(int[] randomArray)
{
    int sum = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (i % 2 == 1)
            sum = sum + randomArray[i];
    }
    return sum;
}
System.Console.Write("\t->\t");
Console.Write(GetSum(array));
*/

/*
Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void mas(int a)
{
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = new Random().Next(10, 100);
        Console.Write(randomArray[i] + "\t");
    }
}

int nSum(int[] randomArray)
{
    int sum = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (i % 2 == 1)
            sum = sum + randomArray[i];
    }
    return sum;
}
mas(a);
System.Console.Write("\t->\t");
Console.Write(nSum(randomArray));
*/