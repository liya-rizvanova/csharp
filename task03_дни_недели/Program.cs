/*
3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда
5 -> Пятница
*/

System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Day: ");

if (number == 1)
{
    System.Console.WriteLine("Monday");
}
else if (number == 2)
{
    System.Console.WriteLine("Tuesday");
}
else if (number == 3)
{
    System.Console.WriteLine("Wednesday");
}
else if (number == 4)
{
    System.Console.WriteLine("Thursday");
}
else if (number == 5)
{
    System.Console.WriteLine("Friday");
}
else if (number == 6)
{
    System.Console.WriteLine("Saturday");
}
else if (number == 7)
{
    System.Console.WriteLine("Sunday");
}
else
    System.Console.WriteLine("No such day!");


/*
System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Day: ");

if (number == 1)
    System.Console.WriteLine("Monday");
if (number == 2)
    System.Console.WriteLine("Tuesday");
if (number == 3)
    System.Console.WriteLine("Wednesday");
if (number == 4)
    System.Console.WriteLine("Thursday");
if (number == 5)
    System.Console.WriteLine("Friday");
if (number == 6)
    System.Console.WriteLine("Saturday");
if (number == 7)
    System.Console.WriteLine("Sunday");
if (number > 7 || number < 1)
    System.Console.WriteLine("No such day!");
*/