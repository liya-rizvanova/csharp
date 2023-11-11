/*
37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
второй и предпоследний и т.д. Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3
[6 7 3 6]   -> 36 21
*/
Console.Clear();


int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 50);
    }
    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
}

int[] ProductArray(int[] arr) // метод для перемножения пар чисел в одномерном массиве 
                              // и передачи результатов перемножения в новый массив
{
    int size = 0;
    if (arr.Length % 2 == 1) size = arr.Length / 2 + 1; // условие, при котором если в исходном массиве нечетное число элементов, 
    else size = arr.Length / 2;                         // чтобы при перемножении пар элементов, начиная с концов массива создать иллюзию
                                                        // перемножения центрального элемента самого на себя
    int[] res = new int[size];				            // создание нового массива, куда будут записаны результаты перемножения
    for (int i = 0; i < size; i++)
    {
        if ((arr.Length % 2 == 1) && (i == size - 1)) res[i] = arr[i];	// условие, при котором при нечетном количестве элементов исходного массива 
        else res[i] = arr[i] * arr[arr.Length - i - 1];		            // средний его элемент будет приравнен к последнему элементу нового массива
    }
    return res;
}

int[] userArray = GetRandomArray(7);
PrintArray(userArray);
System.Console.WriteLine();
int[] newArray = ProductArray(userArray);
PrintArray(newArray);


/*
int[] GetRandomArray(int size)
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
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
}

int[] ProductArray(int[] pArr)
{
    int[] result = new int[pArr.Length / 2 + 1];
    int sum = 0;
    for (int i = 0; i <= pArr.Length / 2; i++)
    {
        sum = pArr[i] * pArr[pArr.Length - 1 - i];
        if (pArr[pArr.Length - 1 - i] == pArr[pArr.Length / 2])
            sum = pArr[pArr.Length - 1 - i] * 1;
        result[i] = sum;
    }
    return result;
}

int[] userArray = GetRandomArray(7);
PrintArray(userArray);
System.Console.WriteLine();
int[] newArray = ProductArray(userArray);
PrintArray(newArray);
*/

/*
//Метод работает только для массива с четным количеством чисел
int[] GetRandomArray(int size)
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
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);

        if (i < arr.Length - 1) System.Console.Write(", ");

    }

    System.Console.Write("]");
}

int[] ProductArray(int[] pArr)
{
    int[] result = new int[pArr.Length / 2];
    int sum = 0;
    for (int i = 0; i < pArr.Length / 2; i++)
    {
        sum = pArr[i] * pArr[pArr.Length - 1 - i];
        result[i] = sum;
    }
    return result;
}

int[] userArray = GetRandomArray(7);
PrintArray(userArray);
System.Console.WriteLine();
int[] newArray = ProductArray(userArray);
PrintArray(newArray);
*/