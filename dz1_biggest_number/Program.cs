/*
Большее из двух чисел:

a = 5; b = 7 -> Первое число 5 меньше чем второе число 7
a = 2; b = 2 -> Введенные числа равны 2
a = -3; b = -9 -> Первое число -3 больше чем второе число -9
*/
System.Console.WriteLine("Enter number1: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter number2: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

bool result = userNumber1 == userNumber2;

if (userNumber1 >= userNumber2)
{
    System.Console.WriteLine(userNumber1);
}
else
if (userNumber1 <= userNumber2)
{
    System.Console.WriteLine(userNumber2);
}
else
    System.Console.WriteLine(result);
