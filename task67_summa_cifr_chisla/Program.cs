/*
67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
*/
Console.Clear();


System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int intN(int n)
{
    if (n % 10 > 0) return n % 10 + intN(n / 10);
    else
        return 0;
}

int result = intN(number);
System.Console.WriteLine(result);