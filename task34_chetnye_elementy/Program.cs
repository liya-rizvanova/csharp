/*
34. Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
Console.Clear();


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

int GetSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            sum++;
    }
    return sum;
}
System.Console.Write("\t->\t");
Console.Write(GetSum(array));


/*
Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void mas(int a)
{
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = new Random().Next(99, 999);
        Console.Write(randomArray[i] + "\t");
    }
}

int kol(int[] randomArray)
{
    int kol = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] % 2 == 0)
            kol = kol + 1;
    }
    return kol;
}
mas(a);
Console.Write($"Количество чётных чисел в массиве: {kol(randomArray)}");
*/