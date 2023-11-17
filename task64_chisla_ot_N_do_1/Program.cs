/*
64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.Clear();


System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void intN(int n, int count = 1)
{
    if (count <= n)
    {
        intN(n, count + 1);
        System.Console.Write(count + " ");
    }
    else
        return;
}

intN(number);


/*
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

// Функция рекурсии
string LineGenRec(int num)
{
    if (num == 0)
    {
        return string.Empty;
    }
    else
    {
        //return LineGenRec(num - 1) + " " + num ;
        return num + " " + LineGenRec (num - 1);
    }
}

int number = ReadData("Введите число N: ");
string resultLine = LineGenRec(number);
PrintResult(resultLine);
*/