/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();


System.Console.WriteLine("Enter number: ");
int userN = Convert.ToInt32(Console.ReadLine());
int userM = Convert.ToInt32(Console.ReadLine());

double Num(int a)
{
    double result = Math.Pow(userN, userM);
    return result;
}
double userResult = Num(userN);
System.Console.WriteLine($"{userN}, {userM} -> {userResult}");