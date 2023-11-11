/*
44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
Console.Clear();


int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] Fibonacci(int number)
{
    int size = number;
    if (number < 2) size = 2;
    int[] array = new int[size];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] arrayOne)
{
    System.Console.Write("Number N -> ");
    Console.ForegroundColor = ConsoleColor.Blue;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(" " + arrayOne[i]);
    }
    System.Console.WriteLine();
}
int number = Prompt("Enter number: ");
PrintArray(Fibonacci(number));


/*
int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] Fibonacci(int number)
{
    int[] n = new int[number];
    n[0] = 0;
    if (number == 1) System.Console.Write("Number N = " + n[0] + ": ");
    int size = number;
    if (number < 2) size = 2;
    int[] array = new int[size];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] arrayOne)
{
    System.Console.Write("Number N = " + arrayOne.Length + ": ");
    Console.ForegroundColor = ConsoleColor.Blue;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(" " + arrayOne[i]);
    }
    System.Console.WriteLine();
}
int number = Prompt("Enter number: ");
PrintArray(Fibonacci(number));
*/

/*
System.Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine());

if (N < 1)
{
    Console.WriteLine("Пожалуйста, введите положительное число.");
    return;
}

int first = 0;
int second = 1;

Console.Write("Первые " + N + " чисел Фибоначчи: ");

if (N >= 1)
{
    Console.Write(first);
}

if (N >= 2)
{
    Console.Write(", " + second);
}

for (int i = 3; i <= N; i++)
{
    int next = first + second;
    Console.Write(", " + next);
    first = second;
    second = next;
}

Console.WriteLine();
*/

/*
// for idea
 cache = {}

    def cached_fibonacci(n):
        if n == 0:
            return 0
        elif n <= 2:
            return 1
        else:
            if n not in cache:
                cache[n] = cached_fibonacci(n-1) + cached_fibonacci(n-2)
            return cache[n]
    return cached_fibonacci


def iteractive_fibonacci(n):
    '''Non-recursive implementation for fibonnacci'''
    if n == 0:
        return 0
    elif n <= 2:
        return 1
    else:
        current = previous = 1
        for i in range(2, n):
            previous, current = current, current + previous
        return current
*/