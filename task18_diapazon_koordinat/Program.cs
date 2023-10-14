/*
18. Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/


Console.WriteLine("Введите номер четверти: ");
int userCvoter = Convert.ToInt32(Console.ReadLine());
if (userCvoter == 1)
{
    System.Console.WriteLine("Все X и Y больше 0");
}
if (userCvoter == 2)
{
    System.Console.WriteLine("Все X меньше 0, а Y больше 0");
}
if (userCvoter == 3)
{
    System.Console.WriteLine("Все X и Y меньше 0"); D
}
if (userCvoter == 4)
{
    System.Console.WriteLine("Все X больше 0, а Y меньше 0");
}


/*
string f(int a)
{
    if (a == 1)
        return "x > 0 && y > 0";
    else if (a == 2)
        return "x < 0 && y > 0";
    else if (a == 3)
        return "x < 0 && y < 0";
    return "x > 0 && y < 0";
}

System.Console.WriteLine("Enter number: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(f(x));
*/