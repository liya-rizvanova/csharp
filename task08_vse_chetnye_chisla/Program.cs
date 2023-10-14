/*
8. Напишите метод PrintEvenNumbers, которая на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.

number = 5 -> 2    4
number = 8 -> 2    4    6    8
*/


System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= number; i += 2)
{
    System.Console.Write(i + "\t");
}


/*
System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i ++)
{
    int remain = i % 2;
    if (remain == 0)
    System.Console.Write(i + "\t");
}
*/