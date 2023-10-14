/*
15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0 || number >= 8)
{
    System.Console.WriteLine("No such day!");
}
else if (number == 6 || number == 7)
{
    System.Console.WriteLine("Dayoff");
}
else if (number >= 1 || number <= 5)
{
    System.Console.WriteLine("Weekday");
}


/*
System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
//System.Console.Write("Day: ");

if (number <= 5 && number > 0)
{
    System.Console.WriteLine("Weekday");
}
if (number == 6 || number == 7)
{
    System.Console.WriteLine("Dayoff");
}
if (number < 1 || number > 7)
{
    System.Console.WriteLine("No such day!");
}
*/

/*
System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
//System.Console.Write("Day: ");

if (number <= 5 && number > 0)
{
    System.Console.WriteLine("Weekday");
}
else if (number == 6 || number == 7)
{
    System.Console.WriteLine("Dayoff");
}
else
{
    System.Console.WriteLine("No such day!");
}
*/

/*
if (number == 6 || number == 7)
{
    System.Console.WriteLine("Dayoff");
}
else if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
{
    System.Console.WriteLine("Weekday");
}
else
    System.Console.WriteLine("No such day!");
*/