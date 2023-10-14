/*
21. Напишите метод DistanceBetweenPoints, который принимает на вход координаты двух точек pointA и pointB 
в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();


System.Console.WriteLine("Введите координаты точки A (x, y, z): ");
int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());
int userAz = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B (x, y, z): ");
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());
int userBz = Convert.ToInt32(Console.ReadLine());

double squareX = Math.Pow(userBx - userAx , 2);
double squareY = Math.Pow(userBy - userAy, 2);
double squareZ = Math.Pow(userBz - userAz, 2);
double rootXYZ = Math.Sqrt(squareX + squareY + squareZ); 
System.Console.WriteLine(Math.Round(rootXYZ, 2));


/*
System.Console.Write("Введите координаты x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

//double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
//Console.Write(d);

double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.Write(Math.Round(d, 2));
*/

/*
System.Console.WriteLine("Введите координаты точки A (x, y, z): ");
int x1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int x3 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B (x, y, z): ");
int y1 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int y3 = Convert.ToInt32(Console.ReadLine());
double squareX = Math.Pow(y1 - x1, 2);
double squareY = Math.Pow(y2 - x2, 2);
double squareZ = Math.Pow(y3 - x3, 2);
double result = Math.Sqrt(squareX + squareY + squareZ); 
System.Console.WriteLine(Math.Round(result, 2));
*/