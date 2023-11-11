/*
1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго. 

a = 25;  b = 5   -> да
a =  2;  b = 10  -> нет
a =  9;  b = -3  -> да
a = -3;  b = 9   -> нет
*/

System.Console.WriteLine("Enter number1: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter number2: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

int sqNumber2 = userNumber2 * userNumber2;

bool result = userNumber1 == sqNumber2;

System.Console.WriteLine(result);