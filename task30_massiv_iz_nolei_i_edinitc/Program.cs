/*
30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
*/
Console.Clear();


int[] GetRandArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
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
    System.Console.WriteLine("]");
}

int[] userArray = GetRandArray(9);
PrintArray(userArray);