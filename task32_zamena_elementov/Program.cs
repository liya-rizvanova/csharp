/*
32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
Console.Clear();


int[] GetRandArray(int size, int start, int end)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}
void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}
System.Console.WriteLine("Ввести размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ввести диапазон массива от: ");
int userStart = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ввести диапазон массива до: ");
int userEnd = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetRandArray(userSize, userStart, userEnd);
PrintArray(userArray);

int[] Result(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
}
//PrintArray(Result(userArray));
int[] userResult = Result(userArray);
PrintArray(userResult);


/*
int Prompt(string massage)
{
    System.Console.Write(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine();
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("] -> [");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -1 * array[i];
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значене для дапазона случайного числа: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);
*/