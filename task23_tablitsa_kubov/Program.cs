/*
Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и 
выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.

N = 3 -> 1 8 27
N = 5 -> 1 8 27 64 125
*/

System.Console.WriteLine("Enter number: ");
int N = Convert.ToInt32(Console.ReadLine());
/*
for (int i = 1; i <= N; i++)
{
   System.Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
}
*/
for (int i = 1; i <= N; i++)
{
   System.Console.Write(Math.Pow(i, 3) + " ");
}   