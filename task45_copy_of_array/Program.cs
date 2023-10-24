/*
45. Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования.
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
    System.Console.Write(" ");
}

System.Console.Write("Ввести размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ввести диапазон массива от: ");
int userStart = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ввести диапазон массива до: ");
int userEnd = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetRandArray(userSize, userStart, userEnd);
PrintArray(userArray);

Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write("-> ");

int[] Copy(int[] array)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * 1;
    }
    return array;
}
PrintArray(Copy(userArray));
//int[] userCopy = Copy(userArray);
//PrintArray(userCopy);
