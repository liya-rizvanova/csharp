/*
6. Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number 
и выводит, является ли число чётным (делится ли оно на два без остатка).

number = 4 -> Число 4 чётное
number = 3 -> Число 3 нечётное
number = 7 -> Число 7 нечётное
*/

System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    System.Console.WriteLine($"Число `{number}` чётное");
}
else
{
    System.Console.WriteLine($"Число `{number}` нечётное");
}