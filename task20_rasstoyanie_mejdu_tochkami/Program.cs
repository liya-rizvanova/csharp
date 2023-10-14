/*
20. Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/
Console.Clear();


System.Console.WriteLine("Введите координаты точки A (x, y): ");
int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B (x, y): ");
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());

// int squareX = (userBx - userAx) * (userBx - userAx)
double squareX = Math.Pow(userBx - userAx, 2); // Math.Pow(a, 3) функция возведения в степень,(что возводим в степень, в какую степень)
double squareY = Math.Pow(userBy - userAy, 2);
double rootXY = Math.Sqrt(squareX + squareY); // Math.Sqrt(то, что идет на вход) находит квадратный корень
System.Console.WriteLine(Math.Round(rootXY, 2)); // Math.Round(a, 2) округление чисел после запятой(число, сколько чисел после запятой оставить)


/*
System.Console.Write("Введите координаты x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());

//double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);
// Math.Round ((берем всю функцию в скобки), 2 - и после запятой указываем до скольки знаков необходимо сделать округление)
System.Console.WriteLine(d);
*/