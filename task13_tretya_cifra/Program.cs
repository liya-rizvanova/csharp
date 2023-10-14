/*
13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

for (int i = number; i >= 100; i = i / 10)
{
    result = i % 10;
}
if (number < 100)
{
    System.Console.WriteLine("No third digit!");
}
else
{
    System.Console.WriteLine(result);
}


/*
System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("Нет третьей цифры!!!");
    return;
}
int third(int number)
{
    while (number >= 999)
        number /= 10;
    int result = number % 10;
    return result;
}
Console.WriteLine(third(number));
*/