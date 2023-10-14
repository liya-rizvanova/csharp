/*
7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

456 -> 6
782 -> 2
918 -> 8
*/

// 6 : 2 = 3 целых (0) - остаток
// 7 : 2 = 3 целых (1) - остаток
// 123 : 10 = 12 целых (3) - остаток

/*
System.Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 10;
System.Console.WriteLine(result);
*/


System.Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
    System.Console.WriteLine("Error");
}
else
{
    number = (number % 10);
    System.Console.WriteLine("The last digit is " + number);
}