/*
10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


System.Console.Write("Enter three digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 1000)
{
    System.Console.WriteLine("Error, here's not three digit!");
}
else
{
    int result = number / 10 % 10;
    System.Console.WriteLine(result);
}


/*
System.Console.Write("Enter three digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (number < 1000 && number > 99)
{
    result = number / 10 % 10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Error, here's not three digit!");
}
*/

/*
System.Console.Write("Enter three digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number / 10 % 10;
System.Console.WriteLine(result);
*/

/*
System.Console.Write("Enter three digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

//int number = new Random().Next(100, 1000);
//System.Console.WriteLine(number);

if (number < 100 || number >= 1000)
{
    System.Console.WriteLine("You entered not three digit number, enter three digit number: ");
}
else if (number >= 100 || number <= 999)
{
    int num = number % 100 / 10;
    System.Console.Write(num);
}
*/