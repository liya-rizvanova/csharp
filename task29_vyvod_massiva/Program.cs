/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.Clear();


// Ввод числа с экрана
int Prompt (string message)
{
System.Console.Write (message); // выводим приглашение ко вводу
string ReadInput = System.Console.ReadLine();
int result = int.Parse(ReadInput); // приводим к числу
return result; // возвращаем результат
}

// Метод для получения случайных значений массива
int[] GenerateArray(int Length, int minValue, int maxValue)
{
int[] array = new int[Length]; // объявляем массив
Random random = new Random();
for (int i = 0; i < Length; i++)
{
array[i] = random.Next (minValue, maxValue + 1); // заполняем случайными цифрами из диапазона SatrArr до EndArr
}
return array;
}
void PrintArray(int[] array)
{
System.Console.Write("[");
for (int i = 0; i < array.Length - 1; i++)
{
System.Console.Write($"{array[i]}, "); // вывод значения массива
}
System.Console.Write($"{array[array.Length - 1]}"); // вывод значения массива
System.Console.WriteLine("]");
}
int length = Prompt ("Длина массива: ");
int min = Prompt("Начальное значение, для диапазона случайного числа: ");
int max = Prompt ("Конечное значение, для диапазона случайного числа: ");
int[] array = GenerateArray(length, min, max); // заполнение массива
PrintArray (array); // вывод массива


/*
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
*/

/*
int[] randomArray = new int[8];
for (int i = 0; i < 8; i++)
{
randomArray[i] = new Random().Next(0, 1000);
Console.Write($"{randomArray[i]} ");
}
*/