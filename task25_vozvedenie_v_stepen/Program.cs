/*
25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Clear();


int Prompt(string message)
{
    System.Console.Write(message); // Водим приглашение ко вводу
    string readInput = System.Console.ReadLine(); // Вводим значение
    int result = int.Parse(readInput); // приводим к числу
    return result; // возвращаем результат
}

int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}

bool ValidateExponent(int exponent)
{
    if (exponent < 0)

    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}

int powerBase = Prompt("Введите основание: ");
int exponent = Prompt("Bведите показатель: ");
if (ValidateExponent(exponent))
{
    System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}


/*
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
*/