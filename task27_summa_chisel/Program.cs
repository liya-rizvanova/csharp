/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/
Console.Clear();

System.Console.WriteLine("Enter number");
int userN = Convert.ToInt32(Console.ReadLine());
int Num(int a)
{
    int result = 0;
    for (int i = userN; i > 0; i/=10)
    {
        result = result + i % 10;
    }
    return result;
}
int userResult = Num(userN);
System.Console.WriteLine($"{userN} -> {userResult}");