/*
27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452  -> 11
82   -> 10
9012 -> 12
*/
Console.Clear();


int Prompt(string message)
{
    System.Console.Write(message); // вводим приглашение ко вводу
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput); // приводим к числу
    return result; // возвращаем результат
}

int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = Prompt("Введите число: ");
System.Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumAllDigit(number)}");


/*
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
*/