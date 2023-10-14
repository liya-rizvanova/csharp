/*
11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/
Console.Clear();


int number = new Random().Next(100, 1000);
System.Console.Write(number);

int first = number / 100;
int last = number % 10;
System.Console.Write(" -> ");
System.Console.Write(first + "" + last);


/*
int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);

int first = number / 100;
int last = number % 10;
int result = first * 10 + last;
System.Console.WriteLine(result);
*/

/*
int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);

int first = number / 100;
System.Console.Write(first);

int second = number % 10;
System.Console.WriteLine(second);
*/

/*
Random random = new Random();
int number = random.Next(100, 1000);
Console.WriteLine(number);

int firstNumber = number / 100;
int threeNumber = number % 10;
int result = firstNumber * 10 + threeNumber;

Console.WriteLine(result);
*/