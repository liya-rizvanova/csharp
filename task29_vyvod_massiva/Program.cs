/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.Clear();


int[] GetRandArray(int size)
{
int[] randomArray = new int[8];
for (int i = 0; i < 8; i++)
{
randomArray[i] = new Random().Next(0, 100);
}
return randomArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}
int[] userArray = GetRandArray(9);
PrintArray(userArray);


/*
int[] randomArray = new int[8];
for (int i = 0; i < 8; i++)
{
randomArray[i] = new Random().Next(0, 1000);
Console.Write($"{randomArray[i]} ");
}
*/